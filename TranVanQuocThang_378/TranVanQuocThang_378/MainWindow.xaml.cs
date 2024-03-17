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
using WebAPISach.Models;

namespace TranVanQuocThang_378 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void hienthiDSSach() {
            qlsachContext db = new qlsachContext();
            dgSach.ItemsSource = db.Saches.ToList();
        }

        private void lenhThem_CanExecute(object sender, CanExecuteRoutedEventArgs e) {

        }

        private void lenhThem_Executed(object sender, ExecutedRoutedEventArgs e) {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            qlsachContext db = new qlsachContext();
            hienthiDSSach();
            cmbManxb.ItemsSource = db.Nhaxuatbans.ToList();
        }

        private void dgSach_LoadingRowDetails(object sender, DataGridRowDetailsEventArgs e) {

        }
    }
}