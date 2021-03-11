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
using System.Windows.Navigation;
using System.Windows.Shapes;
using DataBase;

namespace DataGrid_Sekillendirme
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cikis_button_Click(object sender, RoutedEventArgs e)
        {
            if(MessageBox.Show("Programdan Çıkmak İstermisiniz","Çıkış",MessageBoxButton.YesNo)==MessageBoxResult.Yes)
            {
                this.Close();
                
            }
        }

        private void listele_button_Click(object sender, RoutedEventArgs e)
        {
            DB_Listeleme.DBGrid_Listelme(kitap_liste_grid);
        }

        private void temizle_button_Click(object sender, RoutedEventArgs e)
        {
            kitap_liste_grid.ItemsSource = null;
        }
    }
}
