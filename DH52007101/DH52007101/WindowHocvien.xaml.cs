using DH52007101.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DH52007101 {
    /// <summary>
    /// Interaction logic for WindowHocvien.xaml
    /// </summary>
    public partial class WindowHocvien : Window {
        public WindowHocvien() {
            InitializeComponent();
        }

        private void hienThi() {
            qlhvContext db = new qlhvContext();
            var items = db.Lyliches.Select(x => CHocvien.chuyendoi(x)).ToList();

            dg.Items.Clear(); // Clear existing items

            foreach (var item in items) {
                dg.Items.Add(item); // Add new items
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            qlhvContext db = new qlhvContext();
            cmbMalop.ItemsSource = db.Lops.ToList();
            hienThi();
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e) {
            qlhvContext db = new qlhvContext();
            if (dg.SelectedValue != null) {
                string maso = dg.SelectedValue.ToString();
                Lylich x = db.Lyliches.Find(maso);
                if (x != null) {
                    db.Lyliches.Remove(x);
                    db.SaveChanges();
                    hienThi();
                }
            }
        }

        private void btnThem_Click(object sender, RoutedEventArgs e) {
            qlhvContext db = new qlhvContext();
            CHocvien x = gridHocvien.DataContext as CHocvien;
            Lylich a = CHocvien.chuyendoi(x);
            db.Lyliches.Add(a);
            db.SaveChanges();
            hienThi();
        }

        private void dg_LoadingRowDetails(object sender, DataGridRowDetailsEventArgs e) {
            qlhvContext db = new qlhvContext();
            Grid gr = e.DetailsElement.FindName("gridHocvien") as Grid;
            string maso = dg.SelectedValue.ToString();
            Lylich x = db.Lyliches.Find(maso);
            gr.DataContext = CHocvien.chuyendoiSua(x);
        }

        private void btnSua_Click(object sender, RoutedEventArgs e) {
            qlhvContext db = new qlhvContext();
            Button btn = sender as Button;
            Grid gr = btn.Parent as Grid;
            CHocvien x = gr.DataContext as CHocvien;
            Lylich a = CHocvien.chuyendoi(x);
            db.Lyliches.Update(a);
            db.SaveChanges();
            hienThi();
        }
    }
}
