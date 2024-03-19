using on.Models;
using on.ModelVM;
using System;
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

namespace on {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        List<string> listTacGia = new List<string>();
        public MainWindow() {
            InitializeComponent();
        }
        private void hienThi() {
            qlsachContext db = new qlsachContext();
            cmbMaSo.ItemsSource = db.Nhaxuatbans.ToList();

            cmbTacGia.ItemsSource = db.Tacgia.Select(e => CTacGia.chuyendoi(e)).ToList();

            dgSach.ItemsSource = db.Saches.ToList();
        }
        private void Windows_loaded(object sender, RoutedEventArgs e) {
            hienThi();
        }

        private void lenhChon_Executed(object sender, ExecutedRoutedEventArgs e) {
            var selectedItem = cmbTacGia.SelectedItem;
            if (!dgGT.Items.Contains(selectedItem)) {
                dgGT.Items.Add(selectedItem);
                var selectedmaso = cmbTacGia.SelectedValue;

                listTacGia.Add(selectedmaso.ToString());
            }

        }

        private void lenhChon_CanExecute(object sender, CanExecuteRoutedEventArgs e) {
            e.CanExecute = true;
        }

        private void lenhThem_Executed(object sender, ExecutedRoutedEventArgs e) {
            CSach s = gridsach.DataContext as CSach;

            qlsachContext db = new qlsachContext();

            int dem = listTacGia.Count;

            for (int i = 0; i < dem; i++) {
                ChitietSachTacgium x = new ChitietSachTacgium();
                x.Masach = s.Masach;
                x.Matg = listTacGia[i];
                db.ChitietSachTacgia.Add(x);
            }
            db.Saches.Add(CSach.chuyendoi(s));
            db.SaveChanges();

            listTacGia.Clear();
            dgGT.Items.Clear();
            hienThi();
        }

        private void lenhThem_CanExecute(object sender, CanExecuteRoutedEventArgs e) {
            qlsachContext db = new qlsachContext();

            CSach s = gridsach.DataContext as CSach;

            if (s == null || string.IsNullOrEmpty(s.Masach)) {
                e.CanExecute = false;
                return;
            }
            if (db.Saches.Find(s.Masach) != null) {
                e.CanExecute = false;
                return;
            }
            e.CanExecute = true;
        }
    }
}