   M S B A M L   `   `   `  ����N  JDesktopColorChanger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:DesktopColorChangerDesktopColorChanger  5   	   $    DesktopColorChanger.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:DesktopColorChanger     5   	   X TXceed.Wpf.Toolkit, Version=4.2.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5	   	   -   5          � Title$  Registry Colors Editor��5   	   $	��385��6(   $	��371��65   .��5
      � .+�5   
   �� -   5         ��Name$ cboField��5      $
��Left=�6%   $��	69,12,0,0q�6@   $	��Top=�6S   $	��120��6k   6w   �� 5   
   -   5         ��Name$ lblField��5      $��Option��6"   $
��Left=�63   $��	10,10,0,0q�6N   $	��Top=�6a   $��50��6y   $��Right=�6�   �� 5   
   -   5        $ lblValue��5      $��Color��6"   $
��Left=�62   $��	10,37,0,0q�6M   $	��Top=�6`   $��Right=�6x   $��50��6�   #  Xceed.Wpf.Toolkit.ColorPicker  5   
   -   5          Name$ 	clrPicker��5      $��24��6n   $	��Top=�6z   $
��Left=�6�   $	��120��6�   $��	69,40,0,0q�6�   6�   �� 5   
   -   5         ��Name$ btnSet��5      $	��Set��6!   $
��Left=�6/   $��
194,13,0,0q�6J   $	��Top=�6^   $��94��6v   6�   �� 5   
   -   5        $ btnReset��5      $��Reset to default��6#   $
��Left=�6>   $��
194,41,0,0q�6Y   $	��Top=�6m   6�   5      5      