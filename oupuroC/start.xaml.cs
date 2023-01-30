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

namespace oupuroC
{
    /// <summary>
    /// start.xaml の相互作用ロジック
    /// </summary>
    public partial class start : Page
    {

        private MainWindow mainWindow;
        public start(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void Button_Click_kyoyo_h(object sender, RoutedEventArgs e)
        {
            var kyoyo_h = new kyoyo_h(mainWindow);
            NavigationService.Navigate(kyoyo_h);
        }

        private void Button_Click_kyoyo_s(object sender, RoutedEventArgs e)
        {
            var kyoyo_s = new kyoyo_s(mainWindow);
            NavigationService.Navigate(kyoyo_s);
        }

        private void Button_Click_kyoyo_gakusai(object sender, RoutedEventArgs e)
        {
            var kyoyo_gakusai = new kyoyo_gakusai(mainWindow);
            NavigationService.Navigate(kyoyo_gakusai);
        }

        private void Button_Click_gakubu_h(object sender, RoutedEventArgs e)
        {
            var gakubu_h = new gakubu_h(mainWindow);
            NavigationService.Navigate(gakubu_h);
        }

        private void Button_Click_gakubu_s(object sender, RoutedEventArgs e)
        {
            var gakubu_s = new gakubu_s(mainWindow);
            NavigationService.Navigate(gakubu_s);
        }

        private void Button_Click_gakka_h(object sender, RoutedEventArgs e)
        {
            var gakka_h = new gakka_h(mainWindow);
            NavigationService.Navigate(gakka_h);
        }
        private void Button_Click_gakka_sh(object sender, RoutedEventArgs e)
        {
            var gakka_sh = new gakka_sh(mainWindow);
            NavigationService.Navigate(gakka_sh);
        }

        private void Button_Click_gakka_s(object sender, RoutedEventArgs e)
        {
            var gakka_s = new gakka_s(mainWindow);
            NavigationService.Navigate(gakka_s);
        }

        private void Button_Click_sonota(object sender, RoutedEventArgs e)
        {
            var sonota = new sonota(mainWindow);
            NavigationService.Navigate(sonota);
        }

        private void Button_Click_itiran(object sender, RoutedEventArgs e)
        {
            //ポップアップで単位数一覧を表示させる
        }

        private void Button_Click_quit(object sender, RoutedEventArgs e)
        {
            mainWindow.Close();
        }
    }
}
