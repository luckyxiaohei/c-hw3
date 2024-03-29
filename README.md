# c-hw3

## 按照视频中敲入代码
### 编写tip类

![1](https://github.com/luckyxiaohei/img/blob/master/3.11.png)

由于系统是中文，因此在format方法转货币时候转换成的是￥而不是$，在后面反转剪切符号时候无法识别，所以改用 CultureInfo类来进行转换，具体方法如下:
```
using System.Globalization;
int m;//double等也可以
CultureInfo c = new CultureInfo("en-US");
string result = m.ToString("C", c);
```
###  设计器添加控件，并进行样式颜色等的优化
***
![2](https://github.com/luckyxiaohei/img/blob/master/3.12.png)
***
###  编写逻辑交互（控件事件）的方法
***
![3](https://github.com/luckyxiaohei/img/blob/master/3.13.png)
***
源代码中有个小bug就是输入金额之后再点击利率输出栏会归零，
调试发现这是因为点击时候tip对象的属性都归零了，
也许可以想办法持久保存tip属性，
但我这里选择了在交互方法这里判断当归零时候，再次根据textbox里面的值计算输出小费和总价
***
## 演示
### 调试开始
***
![1](https://github.com/luckyxiaohei/img/blob/master/3.1.jpg)
***
### 点击输入框触发事件，清除框内原有数据
***
![2](https://github.com/luckyxiaohei/img/blob/master/3.2.jpg)
***
### 输入金额
***
![3](https://github.com/luckyxiaohei/img/blob/master/3.3.jpg)
***
### 点击更换其他俩个利率
***
![4](https://github.com/luckyxiaohei/img/blob/master/3.4.jpg)
***
![5](https://github.com/luckyxiaohei/img/blob/master/3.5.jpg)
***



