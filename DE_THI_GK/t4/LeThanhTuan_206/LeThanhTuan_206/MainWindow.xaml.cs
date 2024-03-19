using LeThanhTuan_206.Models;
using System.Runtime.CompilerServices;
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

namespace LeThanhTuan_206 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
        private void hienThi() {
            csdl_thuephongContext db = new csdl_thuephongContext();
            cmbLoaiPhong.ItemsSource = db.Loaiphongs.Select(e => CLoaIPhong.chuyendoi(e)).ToList();

            dgPhong.ItemsSource = db.Phongs.ToList();
        }
        private void btnXoa_Click(object sender, RoutedEventArgs e) {
            MessageBoxResult result = MessageBox.Show("Ban co chac chan xoa?", "Xac nhan", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes) {
                csdl_thuephongContext dc = new csdl_thuephongContext();
                if (dgPhong.SelectedValue == null) return;
                string ms = dgPhong.SelectedValue.ToString();
                Phong mh = dc.Phongs.Find(ms);
                int flag = 0;
                foreach (Chitietphieuthue ct in dc.Chitietphieuthues) {
                    if (ct.Maphong == mh.Maphong) {
                        flag++;
                    }
                }
                if (mh != null && flag == 0) {
                    dc.Phongs.Remove(mh);
                    dc.SaveChanges();
                    hienThi();
                } else {
                    MessageBox.Show("Khong the xoa do co trong chi tiet hoa don", "thong bao");
                }
            } else {
                MessageBox.Show("Ban da bam huy", "thong bao");
            }

        }

        private void Window_loader(object sender, RoutedEventArgs e) {
            hienThi();
        }

        private void lenhThem_Executed(object sender, ExecutedRoutedEventArgs e) {


            CPhong s = gridphong.DataContext as CPhong;

            csdl_thuephongContext db = new csdl_thuephongContext();
            var maphong = cmbLoaiPhong.SelectedValue;
            Phong c = CPhong.chuyendoi(s) as Phong;
            c.Maloai = maphong.ToString();
            string maloai = c.Maloai;
            db.Phongs.Add(c);
            db.SaveChanges();
            hienThi();
        }

        private void lenhThem_CanExecute(object sender, CanExecuteRoutedEventArgs e) {
            csdl_thuephongContext db = new csdl_thuephongContext();

            CPhong s = gridphong.DataContext as CPhong;
            if (s == null || string.IsNullOrEmpty(s.Maphong)) {
                e.CanExecute = false;
                return;
            }
            int dg;
            if (int.TryParse(s.Tinhtrang, out dg) == false) {
                e.CanExecute = false;
                return;
            }
            if (cmbLoaiPhong.SelectedIndex < 0) {
                e.CanExecute = false;
                return;
            }
            if (db.Phongs.Find(s.Maphong) != null) {
                e.CanExecute = false;
                return;
            }
            e.CanExecute = true;
        }
    }
}