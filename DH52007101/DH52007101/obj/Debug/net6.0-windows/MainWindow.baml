   M S B A M L   `   `   `  ����E  ADH52007101, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:DH52007101
DH52007101  5   	       DH52007101.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:DH52007101     5   	   -   5          � Title$  
MainWindow��5   	   $	��800��6   $	��800��6)   .��5	      �� .+�5
   
   �� $��Quản lý môn học��6   $��Center=�6*   $��24(�6G   $
��Bold"�6U   � 5   
   -   5         �Name$ 
gridMonhoc��5         rsMonhoc � DataContext# [  6#    � ColumnDefinitions 5      �� 5      �� 5      $
��1.5* �6#   �� 5      $��4* �6#   �� 5      �� 5      �� 5       � RowDefinitions 5      �� 5      �� 5      �� 5      .+�5      �� $��0��6   $��1��6%   $��Mã số môn học��65   �� 5      $��1��6   $��1��6%   $��Tên môn học��65   �� 5      $��2��6   $��1��6%   $��Số tiết��65   �� 5      $��0��6   $��2��6#   $��25��63   ��6?   �� *Msmh+�� 5      $��1��6   $��2��6#   $��25��63   ��6?   �� *Tenmh+�� 5       $��2��6   $��2��6#   $��25��63   ��6?   �� *Sotiet+�� 5!      -   5         ��Name$ btnThem��5!   A   $��1��6   $��4��6"   $��Thêm��62   6A   5"      �� 5#   
   $��Danh sách môn học��6   $��12(�6,   $
��Bold"�6:   &   System.Windows.Controls.DataGrid  5$   
   -   5          Name$ dg��5$         AutoGenerateColumns$ False��6    �� SelectedValuePath$
 Msmh��6;   	   Columns	 5%      0  *System.Windows.Controls.DataGridTextColumn  5&      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Mã số môn học��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *Msmh+  5'      $
 Tên môn học��6%    6:   �� *Tenmh+  5(      $
 Số tiết��6%    66   �� *Sotiet+4  .System.Windows.Controls.DataGridTemplateColumn  5)      $
 	Tác vụ��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 69      CellTemplate 5*      �� 5+      .R�5,      �� $ btnXoa��63   -   5        $
��Xoá��5,   %   6C   5-      5/         RowDetailsTemplate 52      �� 53      .R�54      9� .��55      �� .+�56      �� $��Form sửa môn học��6$   $��Center=�6?   $��20(�6\   $
��Bold"�6j   � 57      $ 
gridMonhoc��6#   # [  67    58   "   �� 59   &   �� 5:   &   $
��1.5* �67   �� 5;   &   $��4* �67   �� 5<   &   �� 5=   &   �� 5>   &    5A   "   �� 5B   &   �� 5C   &   �� 5D   &   .+�5G   "   �� $��0��6,   $��1��69   $��Mã số môn học��6I   �� 5H   "   $��1��6,   $��1��69   $��Tên môn học��6I   �� 5I   "   $��2��6,   $��1��69   $��Số tiết��6I   �� 5J   "   $��0��6*   $��2��67   $��25��6G    �� 
IsReadOnly$
 True��6S   ��6e   �� *Msmh+�� 5K   "   $��1��6*   $��2��67   $��25��6G   ��6S   �� *Tenmh+�� 5L   "   $��2��6*   $��2��67   $��25��6G   ��6S   �� *Sotiet+�� 5M   "   $ btnSua��6T   -   5        $��1��5M   )   $��4��66   $��Sửa��6F   6d   5N      5O      5P      5Q      5S      5T      5U      