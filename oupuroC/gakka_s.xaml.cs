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
    /// gakka_s.xaml の相互作用ロジック
    /// </summary>
    public partial class gakka_s : Page
    {
        private MainWindow mainWindow;
        public gakka_s(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            SetDictionary();

            // ボタンを押していたら画面遷移して戻ってきてもボタンを押したままにしておく
            void f(Button hoge)
            {
                if (TanniInfo.gakka_s_ButtonToBool[hoge.Name].isClicked == 1)
                {
                    hoge.Background = buttonClickedColor;
                }
                else
                {
                    hoge.Background = buttonColor;
                }
            }

            f(toukei);
            f(tahenryo);
            f(sentan1a);
            f(sentan1b);
            f(titeki1);
            f(syakaimoderu);
            f(saiba);
            f(hou);
            f(intaA);
            f(intaB);
            f(sozopro);
            f(kigosyori);
            f(keieikanri);
            f(patarn);
            f(system);
            f(human);
            f(sentan2a);
            f(software);
            f(basic);
            f(ensyu);
            f(intafase);
            f(sentan2b);
            f(bunsan);
            f(sentan3a);
            f(sentan3b);
        }

        private void Button_Click_back(object sender, RoutedEventArgs e)
        {
            var start = new start(mainWindow);
            NavigationService.Navigate(start);
        }

        private void SetDictionary()
        {
            if (!TanniInfo.gakka_s_ButtonToBool.ContainsKey(toukei.Name))
            {
                TanniInfo.gakka_s_ButtonToBool.Add(toukei.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_s_ButtonToBool.ContainsKey(tahenryo.Name))
            {
                TanniInfo.gakka_s_ButtonToBool.Add(tahenryo.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_s_ButtonToBool.ContainsKey(sentan1a.Name))
            {
                TanniInfo.gakka_s_ButtonToBool.Add(sentan1a.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_s_ButtonToBool.ContainsKey(sentan1b.Name))
            {
                TanniInfo.gakka_s_ButtonToBool.Add(sentan1b.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_s_ButtonToBool.ContainsKey(titeki1.Name))
            {
                TanniInfo.gakka_s_ButtonToBool.Add(titeki1.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_s_ButtonToBool.ContainsKey(syakaimoderu.Name))
            {
                TanniInfo.gakka_s_ButtonToBool.Add(syakaimoderu.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_s_ButtonToBool.ContainsKey(saiba.Name))
            {
                TanniInfo.gakka_s_ButtonToBool.Add(saiba.Name, new Kamoku_states(0, 1));
            }
            if (!TanniInfo.gakka_s_ButtonToBool.ContainsKey(hou.Name))
            {
                TanniInfo.gakka_s_ButtonToBool.Add(hou.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_s_ButtonToBool.ContainsKey(intaA.Name))
            {
                TanniInfo.gakka_s_ButtonToBool.Add(intaA.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_s_ButtonToBool.ContainsKey(intaB.Name))
            {
                TanniInfo.gakka_s_ButtonToBool.Add(intaB.Name, new Kamoku_states(0, 1));
            }
            if (!TanniInfo.gakka_s_ButtonToBool.ContainsKey(sozopro.Name))
            {
                TanniInfo.gakka_s_ButtonToBool.Add(sozopro.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_s_ButtonToBool.ContainsKey(kigosyori.Name))
            {
                TanniInfo.gakka_s_ButtonToBool.Add(kigosyori.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_s_ButtonToBool.ContainsKey(keieikanri.Name))
            {
                TanniInfo.gakka_s_ButtonToBool.Add(keieikanri.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_s_ButtonToBool.ContainsKey(patarn.Name))
            {
                TanniInfo.gakka_s_ButtonToBool.Add(patarn.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_s_ButtonToBool.ContainsKey(system.Name))
            {
                TanniInfo.gakka_s_ButtonToBool.Add(system.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_s_ButtonToBool.ContainsKey(human.Name))
            {
                TanniInfo.gakka_s_ButtonToBool.Add(human.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_s_ButtonToBool.ContainsKey(sentan2a.Name))
            {
                TanniInfo.gakka_s_ButtonToBool.Add(sentan2a.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_s_ButtonToBool.ContainsKey(software.Name))
            {
                TanniInfo.gakka_s_ButtonToBool.Add(software.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_s_ButtonToBool.ContainsKey(basic.Name))
            {
                TanniInfo.gakka_s_ButtonToBool.Add(basic.Name, new Kamoku_states(0, 1));
            }
            if (!TanniInfo.gakka_s_ButtonToBool.ContainsKey(ensyu.Name))
            {
                TanniInfo.gakka_s_ButtonToBool.Add(ensyu.Name, new Kamoku_states(0, 1));
            }
            if (!TanniInfo.gakka_s_ButtonToBool.ContainsKey(intafase.Name))
            {
                TanniInfo.gakka_s_ButtonToBool.Add(intafase.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_s_ButtonToBool.ContainsKey(sentan2b.Name))
            {
                TanniInfo.gakka_s_ButtonToBool.Add(sentan2b.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_s_ButtonToBool.ContainsKey(bunsan.Name))
            {
                TanniInfo.gakka_s_ButtonToBool.Add(bunsan.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_s_ButtonToBool.ContainsKey(sentan3a.Name))
            {
                TanniInfo.gakka_s_ButtonToBool.Add(sentan3a.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_s_ButtonToBool.ContainsKey(sentan3b.Name))
            {
                TanniInfo.gakka_s_ButtonToBool.Add(sentan3b.Name, new Kamoku_states(0, 2));
            }

        }

        SolidColorBrush buttonClickedColor = new SolidColorBrush(Color.FromArgb(0xFF, 0xFF, 0xED, 0xB3));
        SolidColorBrush buttonColor = new SolidColorBrush(Color.FromArgb(0xFF, 221, 221, 221));
        private void Button_Click_kamoku(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                // 選択したら背景色変える
                if (TanniInfo.gakka_s_ButtonToBool.ContainsKey(btn.Name))
                {
                    if (TanniInfo.gakka_s_ButtonToBool[btn.Name].isClicked == 0)
                    {
                        btn.Background = buttonClickedColor;
                        // Dictionaryいじる クリックした
                        TanniInfo.gakka_s_ButtonToBool[btn.Name].isClicked = 1;
                    }
                    else
                    {
                        btn.Background = buttonColor;
                        // Dictionaryいじる クリックしてない
                        TanniInfo.gakka_s_ButtonToBool[btn.Name].isClicked = 0;
                    }
                }
            }
        }

        
        public static int htanni_gakka_s = 6; // 必要単位数
        public static int tanni_gakka_s = 0; //取った単位数
        private void Button_Click_kettei(object sender, RoutedEventArgs e)
        {
            // 学科専門科目選択の単位数を出力させる
            // 計算する (計算した単位数が戻り値)
            tanni_gakka_s = TanniInfo.CalculateTanni(TanniInfo.gakka_s_ButtonToBool);
            // (必要単位数) - (計算した単位数) を出力させる
            // 必要単位数は6
            int nokori = htanni_gakka_s - tanni_gakka_s;
            if(nokori < 0)
            {
                nokori = 0;
            }
            MessageBox.Show("学科専門科目 選択 " + tanni_gakka_s + " 単位(6単位中) " +
                "\n\rあと" + nokori.ToString() + "単位");
        }
    }
}
