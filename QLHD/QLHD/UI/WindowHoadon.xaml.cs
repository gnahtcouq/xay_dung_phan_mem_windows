using QLHD.Models;
using QLHD.ModelVM;
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

namespace QLHD.UI {
    /// <summary>
    /// Interaction logic for WindowHoadon.xaml
    /// </summary>
    public partial class WindowHoadon : Window {
        private Hoadon hd;
        public WindowHoadon() {
            InitializeComponent();
        }

        private void hienthiDSHoadon() {
            hoadonContext db = new hoadonContext();
            //dgHoadon.ItemsSource = db.Hoadons.ToList();
            dgHoadon.ItemsSource = db.Hoadons.Select(t => CHoadon.chuyendoi(t)).ToList();
        }

        private void hienthiCTHD(DataGrid dg, Hoadon x) {
            dg.ItemsSource = ChitietHoadonView.getChitietHoadons(x);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            hd = new Hoadon();

            hoadonContext db = new hoadonContext();
            hienthiDSHoadon();
            cmbMahang.ItemsSource = db.Hanghoas.ToList();
        }

        private void dgHoadon_LoadingRowDetails(object sender, DataGridRowDetailsEventArgs e) {
            hoadonContext db = new hoadonContext();
            DataGrid dg = e.DetailsElement.FindName("dgCTHD") as DataGrid;
            string sohd = dgHoadon.SelectedValue.ToString();
            Hoadon x = db.Hoadons.Find(sohd);
            x.Chitiethoadons = db.Chitiethoadons.Where(t => t.Sohd == sohd).ToList();
            foreach (Chitiethoadon ct in x.Chitiethoadons) {
                ct.MahangNavigation = db.Hanghoas.Find(ct.Mahang);
            }
            hienthiCTHD(dg, x);
        }

        private void lenhChon_Executed(object sender, ExecutedRoutedEventArgs e) {
            hoadonContext db = new hoadonContext();
            ChitietHoadonVM x = gridCTHD.DataContext as ChitietHoadonVM;
            Chitiethoadon ct = hd.Chitiethoadons.FirstOrDefault(t => t.Mahang == x.Mahang);
            if (ct == null) {
                ct = new Chitiethoadon();
                ct.Mahang = x.Mahang;
                ct.Soluong = int.Parse(x.Soluong);
                ct.MahangNavigation = db.Hanghoas.Find(ct.Mahang);
                ct.Dongia = ct.MahangNavigation.Dongia;
                hd.Chitiethoadons.Add(ct);
            } else {
                ct.Soluong += int.Parse(x.Soluong);
            }
            hienthiCTHD(dgCTHD, hd);
        }

        private void lenhChon_CanExecute(object sender, CanExecuteRoutedEventArgs e) {
            e.CanExecute = true;
        }
    }
}
