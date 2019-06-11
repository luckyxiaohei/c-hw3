using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        Tip tip;
        public MainWindow()
        {
            InitializeComponent();

            tip = new Tip();
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            performCalculation();
        }

        private void performCalculation()
        {
            var selectedRadio = myStackPanel.Children.OfType<RadioButton>().FirstOrDefault(r => r.IsChecked == true);
            if (selectedRadio == null)
            {
              
            }
            else
            {
                double billAmount = 0.0;

                string m = string.Format("{0:C}", billAmount);
               


                tip.CalculateTip(billAmountTextBox.Text, double.Parse(selectedRadio.Tag.ToString()));




                if (tip.TipAmount!=m)
                {
                    amountToTipTextBlock.Text = tip.TipAmount;
                    totalTextBlock.Text = tip.TotalAmount;
                    
                }
                else  if(billAmountTextBox.Text != "")
                {
                   
                    double billa;
                    string bat = billAmountTextBox.Text;
                    MessageBox.Show(bat);
                    string ba = string.Format(new System.Globalization.CultureInfo("en-US"),"{0:C}", billAmountTextBox.Text);
                    MessageBox.Show(ba);

                    string baa = ba.Replace("$", "");
                    MessageBox.Show(baa);

                    billa = double.Parse(baa);
                    
                   
                    
                        double p = double.Parse(selectedRadio.Tag.ToString());

                       
       
                        double tipa = p * billa;
                        double am = billa + tipa;



                        amountToTipTextBlock.Text = string.Format(new System.Globalization.CultureInfo("en-US"),"{0:C}", tipa);
                        totalTextBlock.Text = string.Format(new System.Globalization.CultureInfo("en-US"),"{0:C}", am);



                      
                    
                }

            }


        }

        private void amountTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
           
            
            billAmountTextBox.Text = tip.BillAmount;
        }

        private void amountTextBox_MouseLeave(object sender, MouseEventArgs e)
        {
            performCalculation();
        }

        private void amountTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            billAmountTextBox.Text = "";
        }

        private void billAmountTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            performCalculation();
        }












    }
}
