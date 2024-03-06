using QLHD.Models;
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
        public WindowHoadon() {
            InitializeComponent();
        }

        private void hienthiDSHoadon() {
            hoadonContext db = new hoadonContext();
            dgHoadon.ItemsSource = db.Hoadons.ToList();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            hienthiDSHoadon();
        }

        private void dgHoadon_LoadingRowDetails(object sender, DataGridRowDetailsEventArgs e) {

        }
    }
}
