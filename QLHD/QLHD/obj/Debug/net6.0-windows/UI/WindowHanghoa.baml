   M S B A M L   `   `   `  ����?  ;QLHD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:QLHD.UIQLHD.UI  5   	   +clr-namespace:QLHD.ModelVMQLHD.ModelVM  5   	       QLHD.UI.WindowHanghoa   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:QLHD.UI     5   	   .localVMclr-namespace:QLHD.ModelVM     5   	   -   5          � Title$  WindowHanghoa��5	   	   $	��450��6   $	��800��6,    J� CommandBindings 5
      )  #System.Windows.Input.CommandBinding  5   
   -   5        lenhThem��   Command$" localVM:CMyCommands.lenhThem��5   +   6s     5   
   -   5        lenhXoa��$! localVM:CMyCommands.lenhXoa��5   *   6p     5   
   -   5        lenhSua��$! localVM:CMyCommands.lenhSua��5   *   6p   .��5      �� .+�5   
   �� $��Quản lý hàng hoá��6   $��Center=�6+   $��24(�6H   $
��Bold"�6V   � 5   
   -   5         �Name$ gridHanghoa��5         	rsHanghoa � DataContext# [  6$    � ColumnDefinitions 5      �� 5      �� 5      $��2* �6#   �� 5      $��6* �6#   �� 5      �� 5      $��2* �6#   �� 5       � RowDefinitions 5      �� 5      �� 5      �� 5      �� 5      .+�5"      �� $��0��6   $��1��6%   $��	Mã hàng��65   �� 5#      $��1��6   $��1��6%   $��
Tên hàng��65   �� 5$      $��2��6   $��1��6%   $��Đơn vị tính��65   �� 5%      $��3��6   $��1��6%   $��
Đơn giá��65   �� 5&      $��0��6   $��2��6#   $��25��63   ��6?   �� *Mahang+�� 5'      $��1��6   $��2��6#   $��25��63   ��6?   �� *	Tenhang+�� 5(      $��2��6   $��2��6#   $��25��63   ��6?   �� *Dvt+�� 5)      $��3��6   $��2��6#   $��25��63   ��6?   �� *Dongia+�� 5*      $��1��6   $��4��6"   $��Thêm��62   $"��localVM:CMyCommands.lenhThem��6A   �� 5+      $��2��6   $��4��6"   $
��Xoá��62   $!��localVM:CMyCommands.lenhXoa��6@   �� 5,      $��3��6   $��4��6"   $��Sửa��62   $!��localVM:CMyCommands.lenhSua��6@   5-      �� 5/   
   $��Danh sách hàng hoá��6   $��12(�6-   $
��Bold"�6;   &   System.Windows.Controls.DataGrid  50   
   -   5          Name$ 	dgHanghoa��50      $��10q�6&      AutoGenerateColumns$ False��62   	   Columns	 51      0  *System.Windows.Controls.DataGridTextColumn  52      ,  &System.Windows.Controls.DataGridColumn
   Header$
 	Mã hàng��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *Mahang+  53      $
 
Tên hàng��6%    67   �� *	Tenhang+  54      $
 Đơn vị tính��6%    6:   �� *Dvt+  55      $
 
Đơn giá��6%    66   �� *Dongia+5>      5?      5@      