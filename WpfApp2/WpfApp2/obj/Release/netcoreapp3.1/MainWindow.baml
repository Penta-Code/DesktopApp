   M S B A M L   `   `   `  ���� B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2      WpfApp2.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:WpfApp2       � Title$  	Converter��$	��450��$	��800��.��� .+��� -    ��Name$ 
tabControl��.@��� $��Купить валюту��.��� ���	#FFE5E5E5 � ColumnDefinitions �� $
��130* ��� $	��33* ��� $
��631* �.+��� -    ��Name$
 soms��$
��Left=�$��	20,38,0,0q�$�� �� �� TextWrapping$
 Wrap=�$	��Top=�$	��120��$��18��$��2�� � Cursor$  ���� -    ��Name$ button��$��Купить USD��$
��Left=�$��	20,91,0,0q�$	��Top=�$	��120��$��20��$��2�����	#FFDDDDDD�� -   $ button1��$��Курсы валют��$
��Left=�$��289,194,0,0q�$	��Top=�$	��244��$��79��$��2���� -   $ button2��$��Купить EUR��$
��Left=�$��
20,125,0,0q�$	��Top=�$	��120��$��20��$��2���� -   $ button3��$��Купить RUB��$
��Left=�$��
20,160,0,0q�$	��Top=�$	��120��$��20��$��2���� -    ��Name$ 	textBlock��$
��Left=�$��	20,17,0,0q�$.��(Введите сумму в сомах:��$
��Wrap=�$	��Top=�$��16��$	��130��$��2���� $!��Продать валюту��.��� ���	#FFE5E5E5 �� $	��21* ��� $
��773* �.+��� -   $ currency��$
��Left=�$��0,46,0,0q�$�� ��$
 Wrap=�$	��Top=�$	��120��$��1���� -	   $ button4��$��Продать USD��$��1��$
��Left=�$��0,81,0,0q�$	��Top=�$	��120���� -
   $ button5��$��Продать EUR��$��1��$
��Left=�$��	0,122,0,0q�$	��Top=�$	��120���� -   $ button6��$��Продать RUB��$��1��$
��Left=�$��	0,162,0,0q�$	��Top=�$	��120���� -   $ 
textBlock1��$��1��$
��Left=�$��0,25,0,0q�$,��&Введите сумму валюты��$
��Wrap=�$	��Top=��� $��Курс валют��.��� ���	#FFE5E5E5.+�9� -    9�Name$ expander��$��Expander��$
��Left=�$	��100��$��
268,85,0,0q�$	��Top=�$	��298��	 9� 
IsExpanded$	 False�����	#FF666666$��Some content��