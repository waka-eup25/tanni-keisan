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
    /// kyoyo_s.xaml の相互作用ロジック
    /// </summary>
    public partial class kyoyo_s : Page
    {
        private MainWindow mainWindow;
        public kyoyo_s(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            SetDictionary();

            // ボタンを押していたら画面遷移して戻ってきてもボタンを押したままにしておく
            void f(Button hoge)
            {
                if (TanniInfo.kyoyo_s_ButtonToBool[hoge.Name].isClicked == 1)
                {
                    hoge.Background = buttonClickedColor;
                }
                else
                {
                    hoge.Background = buttonColor;
                }
            }

            // それぞれのボタンについてボタンを押してあるかどうかチェック→ボタンの色を変更
            f(kisoA);
            f(kisoB);
            f(kisoC);
            f(tyuA);
            f(tyuB);
            f(tyuC);
            f(tyuD);
            f(zyouA);
            f(zyouB);
            f(zyouC);
            f(zyouD);
            f(sougou1A);
            f(sougou1B);
            f(sougou1C);
            f(sougou2A);
            f(sougou2B);
            f(sougou2C);
            f(sougou3);
            f(esp1);
            f(esp2);
            f(akademikku);
            f(bizinesu);
            f(intenA);
            f(intenB);
            f(intenC);
            f(intenD);
            f(kaigaiA);
            f(kaigaiB);
            f(syosyu_nyumon1);
            f(syosyu_nyumon2);
            f(syosyu1);
            f(syosyu2);
            f(zitugi1);
            f(zitugi2);
            f(ensyu);
            f(sport1);
            f(sport2);

        }

        private void Button_Click_back(object sender, RoutedEventArgs e)
        {
            var start = new start(mainWindow);
            NavigationService.Navigate(start);
        }

        private void SetDictionary()
        {
            if (!TanniInfo.kyoyo_s_ButtonToBool.ContainsKey(kisoA.Name))
            {
                TanniInfo.kyoyo_s_ButtonToBool.Add(kisoA.Name, new Kamoku_states(0, 1));
            }
            if (!TanniInfo.kyoyo_s_ButtonToBool.ContainsKey(kisoB.Name))
            {
                TanniInfo.kyoyo_s_ButtonToBool.Add(kisoB.Name, new Kamoku_states(0, 1));
            }
            if (!TanniInfo.kyoyo_s_ButtonToBool.ContainsKey(kisoC.Name))
            {
                TanniInfo.kyoyo_s_ButtonToBool.Add(kisoC.Name, new Kamoku_states(0, 1));
            }
            if (!TanniInfo.kyoyo_s_ButtonToBool.ContainsKey(tyuA.Name))
            {
                TanniInfo.kyoyo_s_ButtonToBool.Add(tyuA.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyo_s_ButtonToBool.ContainsKey(tyuB.Name))
            {
                TanniInfo.kyoyo_s_ButtonToBool.Add(tyuB.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyo_s_ButtonToBool.ContainsKey(tyuC.Name))
            {
                TanniInfo.kyoyo_s_ButtonToBool.Add(tyuC.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyo_s_ButtonToBool.ContainsKey(tyuD.Name))
            {
                TanniInfo.kyoyo_s_ButtonToBool.Add(tyuD.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyo_s_ButtonToBool.ContainsKey(zyouA.Name))
            {
                TanniInfo.kyoyo_s_ButtonToBool.Add(zyouA.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyo_s_ButtonToBool.ContainsKey(zyouB.Name))
            {
                TanniInfo.kyoyo_s_ButtonToBool.Add(zyouB.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyo_s_ButtonToBool.ContainsKey(zyouC.Name))
            {
                TanniInfo.kyoyo_s_ButtonToBool.Add(zyouC.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyo_s_ButtonToBool.ContainsKey(zyouD.Name))
            {
                TanniInfo.kyoyo_s_ButtonToBool.Add(zyouD.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyo_s_ButtonToBool.ContainsKey(sougou1A.Name))
            {
                TanniInfo.kyoyo_s_ButtonToBool.Add(sougou1A.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyo_s_ButtonToBool.ContainsKey(sougou1B.Name))
            {
                TanniInfo.kyoyo_s_ButtonToBool.Add(sougou1B.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyo_s_ButtonToBool.ContainsKey(sougou1C.Name))
            {
                TanniInfo.kyoyo_s_ButtonToBool.Add(sougou1C.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyo_s_ButtonToBool.ContainsKey(sougou2A.Name))
            {
                TanniInfo.kyoyo_s_ButtonToBool.Add(sougou2A.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyo_s_ButtonToBool.ContainsKey(sougou2B.Name))
            {
                TanniInfo.kyoyo_s_ButtonToBool.Add(sougou2B.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyo_s_ButtonToBool.ContainsKey(sougou2C.Name))
            {
                TanniInfo.kyoyo_s_ButtonToBool.Add(sougou2C.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyo_s_ButtonToBool.ContainsKey(sougou3.Name))
            {
                TanniInfo.kyoyo_s_ButtonToBool.Add(sougou3.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyo_s_ButtonToBool.ContainsKey(esp1.Name))
            {
                TanniInfo.kyoyo_s_ButtonToBool.Add(esp1.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyo_s_ButtonToBool.ContainsKey(esp2.Name))
            {
                TanniInfo.kyoyo_s_ButtonToBool.Add(esp2.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyo_s_ButtonToBool.ContainsKey(akademikku.Name))
            {
                TanniInfo.kyoyo_s_ButtonToBool.Add(akademikku.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyo_s_ButtonToBool.ContainsKey(bizinesu.Name))
            {
                TanniInfo.kyoyo_s_ButtonToBool.Add(bizinesu.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyo_s_ButtonToBool.ContainsKey(intenA.Name))
            {
                TanniInfo.kyoyo_s_ButtonToBool.Add(intenA.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyo_s_ButtonToBool.ContainsKey(intenB.Name))
            {
                TanniInfo.kyoyo_s_ButtonToBool.Add(intenB.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyo_s_ButtonToBool.ContainsKey(intenC.Name))
            {
                TanniInfo.kyoyo_s_ButtonToBool.Add(intenC.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyo_s_ButtonToBool.ContainsKey(intenD.Name))
            {
                TanniInfo.kyoyo_s_ButtonToBool.Add(intenD.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyo_s_ButtonToBool.ContainsKey(kaigaiA.Name))
            {
                TanniInfo.kyoyo_s_ButtonToBool.Add(kaigaiA.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyo_s_ButtonToBool.ContainsKey(kaigaiB.Name))
            {
                TanniInfo.kyoyo_s_ButtonToBool.Add(kaigaiB.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyo_s_ButtonToBool.ContainsKey(syosyu_nyumon1.Name))
            {
                TanniInfo.kyoyo_s_ButtonToBool.Add(syosyu_nyumon1.Name, new Kamoku_states(0, 1));
            }
            if (!TanniInfo.kyoyo_s_ButtonToBool.ContainsKey(syosyu_nyumon2.Name))
            {
                TanniInfo.kyoyo_s_ButtonToBool.Add(syosyu_nyumon2.Name, new Kamoku_states(0, 1));
            }
            if (!TanniInfo.kyoyo_s_ButtonToBool.ContainsKey(syosyu1.Name))
            {
                TanniInfo.kyoyo_s_ButtonToBool.Add(syosyu1.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyo_s_ButtonToBool.ContainsKey(syosyu2.Name))
            {
                TanniInfo.kyoyo_s_ButtonToBool.Add(syosyu2.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.kyoyo_s_ButtonToBool.ContainsKey(zitugi1.Name))
            {
                TanniInfo.kyoyo_s_ButtonToBool.Add(zitugi1.Name, new Kamoku_states(0, 1));
            }
            if (!TanniInfo.kyoyo_s_ButtonToBool.ContainsKey(zitugi2.Name))
            {
                TanniInfo.kyoyo_s_ButtonToBool.Add(zitugi2.Name, new Kamoku_states(0, 1));
            }
            if (!TanniInfo.kyoyo_s_ButtonToBool.ContainsKey(ensyu.Name))
            {
                TanniInfo.kyoyo_s_ButtonToBool.Add(ensyu.Name, new Kamoku_states(0, 1));
            }
            if (!TanniInfo.kyoyo_s_ButtonToBool.ContainsKey(sport1.Name))
            {
                TanniInfo.kyoyo_s_ButtonToBool.Add(sport1.Name, new Kamoku_states(0, 1));
            }
            if (!TanniInfo.kyoyo_s_ButtonToBool.ContainsKey(sport2.Name))
            {
                TanniInfo.kyoyo_s_ButtonToBool.Add(sport2.Name, new Kamoku_states(0, 1));
            }
        }

        SolidColorBrush buttonClickedColor = new SolidColorBrush(Color.FromArgb(0xFF, 0xFF, 0xED, 0xB3));
        SolidColorBrush buttonColor = new SolidColorBrush(Color.FromArgb(0xFF, 221, 221, 221));
        private void Button_Click_kamoku(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                // 選択したら背景色変える
                if (TanniInfo.kyoyo_s_ButtonToBool.ContainsKey(btn.Name))
                {
                    if (TanniInfo.kyoyo_s_ButtonToBool[btn.Name].isClicked == 0)
                    {
                        btn.Background = buttonClickedColor;
                        // Dictionaryいじる クリックした
                        TanniInfo.kyoyo_s_ButtonToBool[btn.Name].isClicked = 1;
                    }
                    else
                    {
                        btn.Background = buttonColor;
                        // Dictionaryいじる クリックしてない
                        TanniInfo.kyoyo_s_ButtonToBool[btn.Name].isClicked = 0;
                    }
                }
            }
        }

        public static int htanni_kyoyo_s = 13; // 必要単位数
        public static int tanni_kyoyo_s = 0; // 取った単位数

        private void Button_Click_kettei(object sender, RoutedEventArgs e)
        {
            // 教養科目選択の単位数 (教養領域A・B、学際領域A・Bは含まない) を出力させる
            // 計算する (計算した単位数が戻り値)
            tanni_kyoyo_s = TanniInfo.CalculateTanni(TanniInfo.kyoyo_s_ButtonToBool);
            // (必要単位数) - (計算した単位数) を出力させる
            // 必要単位数は13

            // 教養科目の選択科目(kyoyo_s)+教養領域学際領域(必修分を削った)(kyoyo_gakusai) をまとめる
            //13単位から 選択科目の単位数、教養領域学際領域の必修分を削った単位数 を引く
            int nokori = htanni_kyoyo_s - tanni_kyoyo_s - kyoyo_gakusai.tanni_kyoyo_gakusai;
            if(nokori< 0)
            {
                nokori = 0;
            }
            MessageBox.Show("教養科目 選択 " + tanni_kyoyo_s + " 単位(13単位中) " +
                "\n\rあと"+ nokori.ToString() + "単位");

            
        }
    }
}
