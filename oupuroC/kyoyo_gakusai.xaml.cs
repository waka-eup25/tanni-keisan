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
    /// kyoyo_gakusai.xaml の相互作用ロジック
    /// </summary>
    public partial class kyoyo_gakusai : Page
    {
        private MainWindow mainWindow;
        public kyoyo_gakusai(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            SetDictionary();

            // ボタンを押していたら画面遷移して戻ってきてもボタンを押したままにしておく
            void f(Button hoge)
            {
                if (TanniInfo.kyoyoA_ButtonToBool[hoge.Name].isClicked == 1)
                {
                    hoge.Background = buttonClickedColor;
                }
                else
                {
                    hoge.Background = buttonColor;
                }
            }

            void f1(Button hoge)
            {
                if (TanniInfo.kyoyoB_ButtonToBool[hoge.Name].isClicked == 1)
                {
                    hoge.Background = buttonClickedColor;
                }
                else
                {
                    hoge.Background = buttonColor;
                }
            }

            void f2(Button hoge)
            {
                if (TanniInfo.gakusaiA_ButtonToBool[hoge.Name].isClicked == 1)
                {
                    hoge.Background = buttonClickedColor;
                }
                else
                {
                    hoge.Background = buttonColor;
                }
            }

            // それぞれのボタンについてボタンを押してあるかどうかチェック→ボタンの色を変更
            f(sisouA);
            f(sisouB);
            f(tiikiA);
            f(tiikiB);
            f(sinriA);
            f(sinriB);
            f(keieiA);
            f(keieiB);
            f(syakaiA);
            f(syakaiB);
            f(kotoba);
            f(nihon);

            f1(suugaku);
            f1(suuri);
            f1(buturi);
            f1(sizen);
            f1(kagaku);
            f1(seikatu);
            f1(seimei);
            f1(seibutu);
            f1(kagaku2);

            f2(sisei);
            f2(tiikisyakai);
            f2(gensiryoku);
            f2(tiikimedhia);
            f2(zisin);
            f2(saigai);
            f2(kigyou);
            f2(igaku);
            f2(nanoteku);

            
        }
        private void Button_Click_back(object sender, RoutedEventArgs e)
        {
            var start = new start(mainWindow);
            NavigationService.Navigate(start);
        }

        private void SetDictionary()
        {
            if (!TanniInfo.kyoyoA_ButtonToBool.ContainsKey(sisouA.Name))
            {
                TanniInfo.kyoyoA_ButtonToBool.Add(sisouA.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyoA_ButtonToBool.ContainsKey(sisouB.Name))
            {
                TanniInfo.kyoyoA_ButtonToBool.Add(sisouB.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyoA_ButtonToBool.ContainsKey(tiikiA.Name))
            {
                TanniInfo.kyoyoA_ButtonToBool.Add(tiikiA.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyoA_ButtonToBool.ContainsKey(tiikiB.Name))
            {
                TanniInfo.kyoyoA_ButtonToBool.Add(tiikiB.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyoA_ButtonToBool.ContainsKey(sinriA.Name))
            {
                TanniInfo.kyoyoA_ButtonToBool.Add(sinriA.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyoA_ButtonToBool.ContainsKey(sinriB.Name))
            {
                TanniInfo.kyoyoA_ButtonToBool.Add(sinriB.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyoA_ButtonToBool.ContainsKey(keieiA.Name))
            {
                TanniInfo.kyoyoA_ButtonToBool.Add(keieiA.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyoA_ButtonToBool.ContainsKey(keieiB.Name))
            {
                TanniInfo.kyoyoA_ButtonToBool.Add(keieiB.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyoA_ButtonToBool.ContainsKey(syakaiA.Name))
            {
                TanniInfo.kyoyoA_ButtonToBool.Add(syakaiA.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyoA_ButtonToBool.ContainsKey(syakaiB.Name))
            {
                TanniInfo.kyoyoA_ButtonToBool.Add(syakaiB.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyoA_ButtonToBool.ContainsKey(kotoba.Name))
            {
                TanniInfo.kyoyoA_ButtonToBool.Add(kotoba.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyoA_ButtonToBool.ContainsKey(nihon.Name))
            {
                TanniInfo.kyoyoA_ButtonToBool.Add(nihon.Name, new Kamoku_states(0, 2));
            }

            if (!TanniInfo.kyoyoB_ButtonToBool.ContainsKey(suugaku.Name))
            {
                TanniInfo.kyoyoB_ButtonToBool.Add(suugaku.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyoB_ButtonToBool.ContainsKey(suuri.Name))
            {
                TanniInfo.kyoyoB_ButtonToBool.Add(suuri.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyoB_ButtonToBool.ContainsKey(buturi.Name))
            {
                TanniInfo.kyoyoB_ButtonToBool.Add(buturi.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyoB_ButtonToBool.ContainsKey(sizen.Name))
            {
                TanniInfo.kyoyoB_ButtonToBool.Add(sizen.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyoB_ButtonToBool.ContainsKey(kagaku.Name))
            {
                TanniInfo.kyoyoB_ButtonToBool.Add(kagaku.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyoB_ButtonToBool.ContainsKey(seikatu.Name))
            {
                TanniInfo.kyoyoB_ButtonToBool.Add(seikatu.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyoB_ButtonToBool.ContainsKey(seimei.Name))
            {
                TanniInfo.kyoyoB_ButtonToBool.Add(seimei.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyoB_ButtonToBool.ContainsKey(seibutu.Name))
            {
                TanniInfo.kyoyoB_ButtonToBool.Add(seibutu.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyoB_ButtonToBool.ContainsKey(kagaku2.Name))
            {
                TanniInfo.kyoyoB_ButtonToBool.Add(kagaku2.Name, new Kamoku_states(0, 2));
            }

            if (!TanniInfo.gakusaiA_ButtonToBool.ContainsKey(sisei.Name))
            {
                TanniInfo.gakusaiA_ButtonToBool.Add(sisei.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakusaiA_ButtonToBool.ContainsKey(tiikisyakai.Name))
            {
                TanniInfo.gakusaiA_ButtonToBool.Add(tiikisyakai.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakusaiA_ButtonToBool.ContainsKey(gensiryoku.Name))
            {
                TanniInfo.gakusaiA_ButtonToBool.Add(gensiryoku.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakusaiA_ButtonToBool.ContainsKey(tiikimedhia.Name))
            {
                TanniInfo.gakusaiA_ButtonToBool.Add(tiikimedhia.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakusaiA_ButtonToBool.ContainsKey(zisin.Name))
            {
                TanniInfo.gakusaiA_ButtonToBool.Add(zisin.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakusaiA_ButtonToBool.ContainsKey(saigai.Name))
            {
                TanniInfo.gakusaiA_ButtonToBool.Add(saigai.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakusaiA_ButtonToBool.ContainsKey(kigyou.Name))
            {
                TanniInfo.gakusaiA_ButtonToBool.Add(kigyou.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakusaiA_ButtonToBool.ContainsKey(igaku.Name))
            {
                TanniInfo.gakusaiA_ButtonToBool.Add(igaku.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakusaiA_ButtonToBool.ContainsKey(nanoteku.Name))
            {
                TanniInfo.gakusaiA_ButtonToBool.Add(nanoteku.Name, new Kamoku_states(0, 2));
            }
        }

        SolidColorBrush buttonClickedColor = new SolidColorBrush(Color.FromArgb(0xFF, 0xFF, 0xED, 0xB3)); //クリックした
        SolidColorBrush buttonColor = new SolidColorBrush(Color.FromArgb(0xFF, 221, 221, 221)); //クリックしてない
        private void Button_Click_kamoku(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                // 選択したら背景色変える
                if(TanniInfo.kyoyoA_ButtonToBool.ContainsKey(btn.Name))
                {
                    if (TanniInfo.kyoyoA_ButtonToBool[btn.Name].isClicked == 0)
                    {
                        btn.Background = buttonClickedColor;
                        // Dictionaryいじる クリックした
                        TanniInfo.kyoyoA_ButtonToBool[btn.Name].isClicked = 1;
                    }
                    else
                    {
                        btn.Background = buttonColor;
                        // Dictionaryいじる クリックしてない
                        TanniInfo.kyoyoA_ButtonToBool[btn.Name].isClicked = 0;
                    }
                }

                if (TanniInfo.kyoyoB_ButtonToBool.ContainsKey(btn.Name))
                {
                    if (TanniInfo.kyoyoB_ButtonToBool[btn.Name].isClicked == 0)
                    {
                        btn.Background = buttonClickedColor;
                        // Dictionaryいじる クリックした
                        TanniInfo.kyoyoB_ButtonToBool[btn.Name].isClicked = 1;
                    }
                    else
                    {
                        btn.Background = buttonColor;
                        // Dictionaryいじる クリックしてない
                        TanniInfo.kyoyoB_ButtonToBool[btn.Name].isClicked = 0;
                    }
                }

                if (TanniInfo.gakusaiA_ButtonToBool.ContainsKey(btn.Name))
                {
                    if (TanniInfo.gakusaiA_ButtonToBool[btn.Name].isClicked == 0)
                    {
                        btn.Background = buttonClickedColor;
                        // Dictionaryいじる クリックした
                        TanniInfo.gakusaiA_ButtonToBool[btn.Name].isClicked = 1;
                    }
                    else
                    {
                        btn.Background = buttonColor;
                        // Dictionaryいじる クリックしてない
                        TanniInfo.gakusaiA_ButtonToBool[btn.Name].isClicked = 0;
                    }
                }
                    
            }
        }

        public static int htanni_kyoyoA = 2; // 必要単位数
        public static int htanni_kyoyoB = 2; // 必要単位数
        public static int htanni_gakusaiA = 2; // 必要単位数
        public static int tanni_kyoyoA = 0; // 取った単位数
        public static int tanni_kyoyoB = 0; // 取った単位数
        public static int tanni_gakusaiA = 0; // 取った単位数
        public static int tanni_kyoyo_gakusai = 0; // 取った単位数
        
        private void Button_Click_kettei(object sender, RoutedEventArgs e)
        {
            // 教養科目選択の単位数 (教養領域A・B、学際領域A・B) を出力させる
            // 計算する (計算した単位数が戻り値)
            tanni_kyoyoA = TanniInfo.CalculateTanni(TanniInfo.kyoyoA_ButtonToBool);
            tanni_kyoyoB = TanniInfo.CalculateTanni(TanniInfo.kyoyoB_ButtonToBool);
            tanni_gakusaiA = TanniInfo.CalculateTanni(TanniInfo.gakusaiA_ButtonToBool);

            int nokori1 = htanni_kyoyoA - tanni_kyoyoA;
            if(nokori1 < 0 ) 
            {
                nokori1 = 0;
            }
            int nokori2 = htanni_kyoyoB - tanni_kyoyoB;
            if (nokori2 < 0)
            {
                nokori2 = 0;
            }
            int nokori3 = htanni_gakusaiA - tanni_gakusaiA;
            if (nokori3 < 0)
            {
                nokori3 = 0;
            }
            MessageBox.Show("教養科目 教養領域A " + tanni_kyoyoA + " 単位(2単位中) " +
                "\n\rあと" + nokori1.ToString() + "単位"
                + "\n\r教養科目 教養領域B " + tanni_kyoyoB + " 単位(2単位中) " +
                "\n\rあと" + nokori2.ToString() + "単位"
                + "\n\r教養科目 学際領域A " + tanni_gakusaiA + " 単位(2単位中) " +
                "\n\rあと" + nokori3.ToString() + "単位");

            //溢れた分(必修分の単位数)を削る
            if(tanni_kyoyoA > 2)
            {
                tanni_kyoyo_gakusai += tanni_kyoyoA - 2;
            }
            if(tanni_kyoyoB > 2)
            {
                tanni_kyoyo_gakusai += tanni_kyoyoB - 2;
            }
            if(tanni_gakusaiA > 2)
            {
                tanni_kyoyo_gakusai += tanni_gakusaiA - 2;
            }

            //MessageBox.Show("教養科目 選択(13) あと" + (13 - tanni_kyoyo_gakusai).ToString() + "\r\n(教養領域A・B、学際領域A・Bは含まない)");

            // 教養科目の選択科目(kyoyo_s)+教養領域学際領域(kyoyo_gakusai)の和が19あればよい
        }

    }
}
