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
            int tanni1 = 0;
            int tanni2 = 0;
            int tanni3 = 0;
            int tanni4 = 0;
            int tanni5 = 0;
            int tanni6 = 0;
            int tanni7 = 0;
            //ポップアップで単位数一覧を表示させる
            //教養科目必修 9
            tanni1 += kyoyo_h.tanni_kyoyo_h;
            if(kyoyo_gakusai.tanni_kyoyoA <= 2) // 単位数が2以下のとき
            {
                tanni1 += kyoyo_gakusai.tanni_kyoyoA; // そのまま足す
            }
            else
            {
                tanni1 += 2; // 必修分
            }
            if(kyoyo_gakusai.tanni_kyoyoB<= 2)
            {
                tanni1 += kyoyo_gakusai.tanni_kyoyoB;
            }
            else
            {
                tanni1+= 2;
            }
            if (kyoyo_gakusai.tanni_gakusaiA <= 2)
            {
                tanni1 += kyoyo_gakusai.tanni_gakusaiA;
            }
            else
            {
                tanni1 += 2;
            }

            //教養科目選択 13 tanni_kyoyo_s + tanni_kyoyo_gakusai
            tanni2 += kyoyo_s.tanni_kyoyo_s + kyoyo_gakusai.tanni_kyoyo_gakusai;

            //教養科目の溢れたもの→自由科目
            if(kyoyo_s.htanni_kyoyo_s - tanni2 < 0)
            {
                tanni7 += tanni2 - kyoyo_s.htanni_kyoyo_s;
            }

            //学部共通科目必修 17
            tanni3 += gakubu_h.tanni_gakubu_h;

            //学部共通科目選択→学科専門科目選択
            tanni6 += gakubu_s.tanni_gakubu_s;

            //学科専門科目必修 47
            tanni4 += gakka_h.tanni_gakka_h;

            //学科専門科目選択必修 16
            tanni5 += gakka_sh.tanni_gakka_sh;

            //学科専門科目選択必修の溢れたもの→学科専門科目選択
            if(gakka_sh.htanni_gakka_sh - tanni5 < 0)
            {
                tanni6 += tanni5 - gakka_sh.htanni_gakka_sh;
            }

            //学科専門科目選択 6
            tanni6 += gakka_s.tanni_gakka_s;

            //学科専門科目の溢れたもの→自由科目
            if(gakka_s.htanni_gakka_s - tanni6 < 0)
            {
                tanni7 += tanni6 - gakka_s.htanni_gakka_s;
            }

            //自由科目
            tanni7 += sonota.tanni_ziyu;

            var itiran = new itiran(mainWindow);
            NavigationService.Navigate(itiran);

            /* MessageBoxじゃ入りきらなかった
            MessageBox.Show("教養科目 必修 " + (tanni1).ToString() + " 単位(15単位中) \n\r必要単位はあと " + (kyoyo_h.htanni_kyoyo_h - tanni1).ToString() + " 単位です" 
                + " 選択 " + (tanni2).ToString() + " 単位(13単位中) \n\r必要単位はあと " + (kyoyo_s.htanni_kyoyo_s - tanni2).ToString()  +" 単位です" 
                + "\n\r学部共通科目 必修 " + (tanni3),ToString() + " 単位(17単位中) \n\r必要単位はあと " + (gakubu_h.htanni_gakubu_h - tanni3).ToString() + " 単位です"
                + "\n\r学科専門科目 必修 " + (tanni4).ToString() + " 単位(47単位中) \n\r必要単位はあと " + (gakka_h.htanni_gakka_h - tanni4).ToString() + " 単位です"
                + "選択必修 " + (tanni5).ToString() + " 単位(16単位中) \n\r必要単位はあと " + (gakka_sh.htanni_gakka_sh - tanni5).ToString() + " 単位です"
                + "選択 " + (tanni6) + " 単位(6単位中) \n\r必要単位はあと " + (gakka_s.htanni_gakka_s - tanni6).ToString() + " 単位です"
                + "\n\r自由科目 " + (tanni7).ToString() + " 単位(10単位中) \n\r必要単位はあと " + (sonota.htanni_ziyu - tanni7) + " 単位です");
            */

            /* fomat
            教養科目 必修(15) あと3　選択(13) あと9
            学部共通科目 必修(17) あと3
            必修(47) あと27　選択必修(16) あと11　選択(6) あと4
            その他 あと4
            */
        }

        private void Button_Click_quit(object sender, RoutedEventArgs e)
        {
            mainWindow.Close();
        }
    }
}
