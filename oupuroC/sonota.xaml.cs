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
    /// sonota.xaml の相互作用ロジック
    /// </summary>
    public partial class sonota : Page
    {
        private MainWindow mainWindow;
        public sonota(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void Button_Click_back(object sender, RoutedEventArgs e)
        {
            var start = new start(mainWindow);
            NavigationService.Navigate(start);
        }

        public static int htanni_ziyu = 10; // 必要単位数
        public static int tanni_ziyu = 0; //取った単位数

        private void Button_Click_kettei(object sender, RoutedEventArgs e)
        {
            //入力されたテキストを変数に格納→int型に変換
            String a = input.Text;
            tanni_ziyu = int.Parse(a);

            // (必要単位数) - (計算した単位数) を出力させる
            MessageBox.Show("自由科目(10) あと" + (htanni_ziyu - tanni_ziyu).ToString());
        }
    }
}
