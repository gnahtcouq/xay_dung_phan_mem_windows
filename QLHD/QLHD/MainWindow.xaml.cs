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

namespace QLHD {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void menuHanghoa_Click(object sender, RoutedEventArgs e) {
            UI.WindowHanghoa f = new UI.WindowHanghoa();
            f.Show();
        }

        private void menuHoadon_Click(object sender, RoutedEventArgs e) {
            UI.WindowHoadon f = new UI.WindowHoadon();
            f.Show();
        }
    }
}