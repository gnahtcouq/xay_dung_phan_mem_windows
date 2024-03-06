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
    /// Interaction logic for WindowHanghoa.xaml
    /// </summary>
    public partial class WindowHanghoa : Window {
        public WindowHanghoa() {
            InitializeComponent();
        }

        private void hienThi() {
            hoadonContext db = new hoadonContext();
            dgHanghoa.ItemsSource = db.Hanghoas.ToList();
            //dgHanghoa.ItemsSource = db.Hanghoas.Select(t => HanghoaVM.chuyendoi(t)).ToList();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            hienThi();
        }

        private void lenhThem_CanExecute(object sender, CanExecuteRoutedEventArgs e) {
            hoadonContext db = new hoadonContext();
            HanghoaVM x = gridHanghoa.DataContext as HanghoaVM;
            if (x == null || string.IsNullOrEmpty(x.Mahang)) {
                e.CanExecute = false;
                return;
            }

            double dongia;
            if (double.TryParse(x.Dongia, out dongia) == false) {
                e.CanExecute = false;
                return;
            }

            if (db.Hanghoas.Find(x.Mahang) != null) {
                e.CanExecute = false;
                return;
            }

            e.CanExecute = true;
        }

        private void lenhThem_Executed(object sender, ExecutedRoutedEventArgs e) {
            hoadonContext db = new hoadonContext();
            HanghoaVM x = gridHanghoa.DataContext as HanghoaVM;
            Hanghoa a = HanghoaVM.chuyendoi(x);
            db.Hanghoas.Add(a);
            db.SaveChanges();
            hienThi();
        }

        private void dgHanghoa_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            gridHanghoa.DataContext = HanghoaVM.chuyendoi(dgHanghoa.SelectedItem as Hanghoa);
        }

        private void lenhXoa_CanExecute(object sender, CanExecuteRoutedEventArgs e) {
            hoadonContext db = new hoadonContext();
            HanghoaVM x = gridHanghoa.DataContext as HanghoaVM;
            if (x == null || string.IsNullOrEmpty(x.Mahang)) {
                e.CanExecute = false;
                return;
            }

            if (db.Hanghoas.Find(x.Mahang) == null) {
                e.CanExecute = false;
                return;
            }

            if (db.Chitiethoadons.Count(t => t.Mahang == x.Mahang) > 0) {
                e.CanExecute = false;
                return;
            }

            e.CanExecute = true;
        }

        private void lenhXoa_Executed(object sender, ExecutedRoutedEventArgs e) {
            hoadonContext db = new hoadonContext();
            HanghoaVM x = gridHanghoa.DataContext as HanghoaVM;
            Hanghoa a = db.Hanghoas.Find(x.Mahang);
            db.Hanghoas.Remove(a);
            db.SaveChanges();

            hienThi();
            gridHanghoa.DataContext = new HanghoaVM();
        }

        private void lenhSua_CanExecute(object sender, CanExecuteRoutedEventArgs e) {
            hoadonContext db = new hoadonContext();
            HanghoaVM x = gridHanghoa.DataContext as HanghoaVM;
            if (x == null || string.IsNullOrEmpty(x.Mahang)) {
                e.CanExecute = false;
                return;
            }

            double dongia;
            if (double.TryParse(x.Dongia, out dongia) == false) {
                e.CanExecute = false;
                return;
            }

            if (db.Hanghoas.Find(x.Mahang) == null) {
                e.CanExecute = false;
                return;
            }

            e.CanExecute = true;
        }

        private void lenhSua_Executed(object sender, ExecutedRoutedEventArgs e) {
            hoadonContext db = new hoadonContext();
            HanghoaVM x = gridHanghoa.DataContext as HanghoaVM;
            Hanghoa a = HanghoaVM.chuyendoi(x);
            db.Hanghoas.Update(a);
            db.SaveChanges();
            hienThi();
        }
    }
}
