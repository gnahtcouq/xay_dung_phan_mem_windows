   M S B A M L   `   `   `  ����=  9on, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:onon  5   	   'clr-namespace:on.ModelVM
on.ModelVM  5   	       on.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:on     5   	   ,localVMclr-namespace:on.ModelVM     5   	   -   5          � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5        lenhChon��   Command$  localVM:CCommands.lenhChon��5   	   5   	     5   
   -   5        lenhThem��$  localVM:CCommands.lenhThem��5   	   5   	   .��5      �� .+�5   
   9� $��Form nhập sách��6   .��5      �� .+�5      �� $��Chọn nhà sản xuất��6   $
��Bold"�64   � 5      -   5         �Name$ gridNXB��5       � ColumnDefinitions 5      �� 5      �� 5      $��3* �6+   �� 5      $��3* �6+   �� 5       � RowDefinitions 5       �� 5!      �� 5"      .+�5%      �� $��Mã số��6    $��0��6-   $��0��6=   �� 5&      $��Tên nhà xuất bản��6    $��1��68   $��0��6H   �� 5'      $��Địa chỉ��6    $��2��6/   $��0��6?   �� 5(      $��Số điên thoại��6    $��3��65   $��0��6E   �� 5+      -   5         ��Name$ cmbMaSo��5+      $��0��60   $��1��6@    �� SelectedValuePath$ Manxb��5,       �� DisplayMemberPath$ Manxb��60   	 �� SelectedValue	 6J   �� *Manxb+�� 5-      $��1��6   $��1��6+   
 �� 
IsReadOnly$

 True��6;   ��6M   ��  �� ElementName$ cmbMaSo�� �� Path$ SelectedItem.Tennxb��� 5.      $��1��6   $��2��6+   $

 True��6;   ��6M   �� $ cmbMaSo��$ SelectedItem.Diachi��� 5/      $��1��6   $��3��6+   $

 True��6;   ��6M   �� $ cmbMaSo��$ SelectedItem.Dienthoai�51      �� 52      $��Chọn tác giả��6   $
��Bold"�6/   � 53      -   5        $ gridGT��53       54      �� 55      �� 56      $��3* �6+   �� 57      �� 58      �� 59       5<      �� 5=      �� 5>      .+�5A      �� $��Mã tác giả��6    $��0��62   $��0��6B   �� 5B      $��	Họ tên��6    $��1��6.   $��0��6>   �� 5C      $��
Ngày sinh��6    $��2��61   $��0��6A   �� 5D      $��Phái��6    $��3��6,   $��0��6<   �� 5F      -   5        $ 	cmbTacGia��5F      $��0��62   $��1��6B   $
 Matg��5G      $
 Matg��6.   	 6G   �� *Matg+�� 5H      $��1��6   $��1��6+   $

 True��6;   ��6M   �� $ 	cmbTacGia��$ SelectedItem.Tentg��� 5I      $��1��6   $��2��6+   $

 True��6;   ��6M   �� $ 	cmbTacGia��$ SelectedItem.Ngaysinh��� 5J      $��1��6   $��3��6+   $

 True��6;   ��6M   �� $ 	cmbTacGia��$ SelectedItem.Phai��� 5K      $��Chọn��6   $��1��6,   $��4��69   $ ��localVM:CCommands.lenhChon��6I   5L      �� 5M      $.��(Danh sách tác giả của cuốn sách��6   $
��Bold"�6B   &   System.Windows.Controls.DataGrid  5N      -   5          Name$
 dgGT��5N         AutoGenerateColumns$ False��6)      Columns 5O      0  *System.Windows.Controls.DataGridTextColumn  5P      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã tác giả��6-   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� *Matg+  5Q      $ 	Họ tên��6-    6=   �� *Tentg+  5R      $ 
Ngày sinh��6-    6@   �� *
Ngaysinh+  5S      $ Phái��6-    6;   �� *Phai+5U      �� 5V      $��Thông tin sách��6   $
��Bold"�61   � 5W      -	   5        $ gridsach��5W       
  rssach � DataContext# [  6)    5X      �� 5Y      �� 5Z      $��2* �6+   �� 5[      $��6* �6+   �� 5\      �� 5]      $��2* �6+   �� 5^       5`      �� 5a      �� 5b      �� 5c      �� 5d      .+�5g      �� $��Mã sách: ��6    $��0��61   $��1��6>   �� 5h      $��Tên sách ��6    $��1��61   $��1��6>   �� 5i      $��Mã loại: ��6    $��2��61   $��1��6>   �� 5j      $��Năm xuất bản: ��6    $��3��66   $��1��6C   �� 5l      $��0��6   $��2��6+   ��6;   �� *Masach+�� 5m      $��1��6   $��2��6+   ��6;   �� *	Tensach+�� 5n      $��2��6   $��2��6+   ��6;   �� *	Theloai+�� 5o      $��3��6   $��2��6+   ��6;   �� *Namxb+�� 5q      -
   5         ��Name$ btnThem��5q   I   $��Thêm��6   $��4��6,   $��0��6<   $ ��localVM:CCommands.lenhThem��6Z   5s      5t      5w      9� 5x   
   $��Danh sách quyển sách��6   .��5y      �� .+�5z        -   5        $ dgSach��5z      $ False��5{      $
��0 15q�5|      $ Masach��5}       5~        5      $ 	Mã sách��6-    6>   �� *Masach+  5�      $ 
Tên sách��6-    6?   �� *	Tensach+  5�      $ Thể loại��6-    6?   �� *	Theloai+  5�      $ Năm sản xuất��6-    6C   �� *Namxb+  5�      $ Mã nhà sản xuất��6-    6F   �� *Manxb+5�      5�      5�      5�      5�      