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
    /// Interaction logic for WindowChinh.xaml
    /// </summary>
    public partial class WindowChinh : Window {
        public WindowChinh() {
            InitializeComponent();
        }

        private void menuMonhoc_Click(object sender, RoutedEventArgs e) {
            MainWindow f = new MainWindow();
            f.Show();
        }

        private void menuHocvien_Click(object sender, RoutedEventArgs e) {
            WindowHocvien f = new WindowHocvien();
            f.Show();
        }
    }
}
