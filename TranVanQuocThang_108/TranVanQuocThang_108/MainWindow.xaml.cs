using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using waDienke_Giuaky.Models;

namespace TranVanQuocThang_108 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void hienThi() {
            csdl_dienkeContext db = new csdl_dienkeContext();
            cmbMaSo.ItemsSource = db.Khachhangs.ToList();

            dgDienke.ItemsSource = db.Dienkes.ToList();
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e) {
            MessageBoxResult result = MessageBox.Show("Ban co chac chan xoa?", "Xac nhan", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes) {
                csdl_dienkeContext dc = new csdl_dienkeContext();
                if (dgDienke.SelectedValue == null) return;
                string ms = dgDienke.SelectedValue.ToString();
                Dienke mh = dc.Dienkes.Find(ms);
                int flag = 0;
                foreach (Sudungdien ct in dc.Sudungdiens) {
                    if (ct.Madk == mh.Madk) {
                        flag++;
                    }
                }
                if (mh != null && flag == 0) {
                    dc.Dienkes.Remove(mh);
                    dc.SaveChanges();
                    hienThi();
                } else {
                    MessageBox.Show("Khong the xoa vi dien ke dang duoc su dung", "thong bao");
                }
            } else {
                MessageBox.Show("Ban da bam huy", "thong bao");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            hienThi();
        }

        private void lenhThem_Executed(object sender, ExecutedRoutedEventArgs e) {
            if (cmbMaSo.SelectedItem == null || string.IsNullOrEmpty(txtMaDienKe.Text) || dpNgayDangKy.SelectedDate == null) {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            string selectedCustomerId = (cmbMaSo.SelectedItem as Khachhang)?.Makh;
            string newMeterId = txtMaDienKe.Text;
            DateTime? registrationDate = dpNgayDangKy.SelectedDate;

            using (csdl_dienkeContext db = new csdl_dienkeContext()) {
                // Kiểm tra ràng buộc khóa chính
                if (db.Dienkes.Any(d => d.Madk == newMeterId)) {
                    MessageBox.Show("Mã điện kế đã tồn tại. Vui lòng chọn một mã khác.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                // Thêm mới "Dienke"
                Dienke newMeter = new Dienke {
                    Madk = newMeterId,
                    Ngaydk = registrationDate.Value,
                    Makh = selectedCustomerId
                };

                db.Dienkes.Add(newMeter);
                db.SaveChanges();

                // Cập nhật giao diện
                hienThi();
                MessageBox.Show("Thêm điện kế thành công.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void lenhThem_CanExecute(object sender, CanExecuteRoutedEventArgs e) {
            e.CanExecute = true; // Cho phép thực hiện lệnh thêm
        }
    }
}