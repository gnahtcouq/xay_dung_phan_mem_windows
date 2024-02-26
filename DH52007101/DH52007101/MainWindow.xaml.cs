using DH52007101.Models;
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

namespace DH52007101 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void hienThi() {
            qlhvContext db = new qlhvContext();
            dg.ItemsSource = db.Monhocs.Select(x => CMonhoc.chuyendoi(x)).ToList();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            hienThi();

        }

        private void btnThem_Click(object sender, RoutedEventArgs e) {
            qlhvContext db = new qlhvContext();
            CMonhoc x = gridMonhoc.DataContext as CMonhoc;
            if (string.IsNullOrEmpty(x.Msmh) == true) {
                MessageBox.Show("Mã môn học không được để trống!");
                return;
            } else if (string.IsNullOrEmpty(x.Tenmh) == true) {
                MessageBox.Show("Tên môn học không được để trống!");
                return;
            } else if (x.Sotiet == null || x.Sotiet <= 0) {
                MessageBox.Show("Số tiết không hợp lệ!");
                return;
            }

            if (db.Monhocs.Find(x.Msmh) != null) {
                MessageBox.Show("Đã tồn tại môn học này trong hệ thống!");
                return;
            }

            Monhoc a = CMonhoc.chuyendoi(x);
            db.Monhocs.Add(a);
            db.SaveChanges();
            hienThi();
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e) {
            qlhvContext db = new qlhvContext();
            string msmh = dg.SelectedValue.ToString();
            Monhoc x = db.Monhocs.Find(msmh);
            if (x != null) {
                try {
                    db.Monhocs.Remove(x);
                    db.SaveChanges();
                    hienThi();
                } catch (Exception) {
                    MessageBox.Show("Không thể xoá môn học '" + x.Msmh + "'!");
                }
            }
        }

        private void dg_LoadingRowDetails(object sender, DataGridRowDetailsEventArgs e) {
            Grid gr = e.DetailsElement.FindName("gridMonhoc") as Grid;
            CMonhoc x = CMonhoc.saochep(dg.SelectedItem as CMonhoc);
            gr.DataContext = x;
        }

        private void btnSua_Click(object sender, RoutedEventArgs e) {
            qlhvContext db = new qlhvContext();
            Button btn = sender as Button;
            Grid gr = btn.Parent as Grid;
            CMonhoc x = gr.DataContext as CMonhoc;
            Monhoc a = CMonhoc.chuyendoi(x);

            db.Monhocs.Update(a);
            db.SaveChanges();
            hienThi();
        }
    }
}