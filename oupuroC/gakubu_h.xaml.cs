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
    /// gakubu_h.xaml の相互作用ロジック
    /// </summary>
    public partial class gakubu_h : Page
    {
        private MainWindow mainWindow;
        public gakubu_h(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            SetDictionary();

            // ボタンを押していたら画面遷移して戻ってきてもボタンを押したままにしておく
            void f(Button hoge)
            {
                if (TanniInfo.gakubu_h_ButtonToBool[hoge.Name].isClicked == 1)
                {
                    hoge.Background = buttonClickedColor;
                }
                else
                {
                    hoge.Background = buttonColor;
                }
            }

            f(souron);
            f(konpute);
            f(data);
            f(prog);
            f(hyogenho);
            f(komisukiA);
            f(prog2);
            f(pbl);
            f(komisukiB);
            f(sekyu);
            f(hoho);
        }

        private void Button_Click_back(object sender, RoutedEventArgs e)
        {
            var start = new start(mainWindow);
            NavigationService.Navigate(start);
        }

        private void SetDictionary()
        {
            if (!TanniInfo.gakubu_h_ButtonToBool.ContainsKey(souron.Name))
            {
                TanniInfo.gakubu_h_ButtonToBool.Add(souron.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakubu_h_ButtonToBool.ContainsKey(konpute.Name))
            {
                TanniInfo.gakubu_h_ButtonToBool.Add(konpute.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakubu_h_ButtonToBool.ContainsKey(data.Name))
            {
                TanniInfo.gakubu_h_ButtonToBool.Add(data.Name, new Kamoku_states(0, 1));
            }
            if (!TanniInfo.gakubu_h_ButtonToBool.ContainsKey(prog.Name))
            {
                TanniInfo.gakubu_h_ButtonToBool.Add(prog.Name, new Kamoku_states(0, 1));
            }
            if (!TanniInfo.gakubu_h_ButtonToBool.ContainsKey(hyogenho.Name))
            {
                TanniInfo.gakubu_h_ButtonToBool.Add(hyogenho.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakubu_h_ButtonToBool.ContainsKey(komisukiA.Name))
            {
                TanniInfo.gakubu_h_ButtonToBool.Add(komisukiA.Name, new Kamoku_states(0, 1));
            }
            if (!TanniInfo.gakubu_h_ButtonToBool.ContainsKey(prog2.Name))
            {
                TanniInfo.gakubu_h_ButtonToBool.Add(prog2.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakubu_h_ButtonToBool.ContainsKey(pbl.Name))
            {
                TanniInfo.gakubu_h_ButtonToBool.Add(pbl.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakubu_h_ButtonToBool.ContainsKey(komisukiB.Name))
            {
                TanniInfo.gakubu_h_ButtonToBool.Add(komisukiB.Name, new Kamoku_states(0, 1));
            }
            if (!TanniInfo.gakubu_h_ButtonToBool.ContainsKey(sekyu.Name))
            {
                TanniInfo.gakubu_h_ButtonToBool.Add(sekyu.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakubu_h_ButtonToBool.ContainsKey(hoho.Name))
            {
                TanniInfo.gakubu_h_ButtonToBool.Add(hoho.Name, new Kamoku_states(0, 1));
            }
        }

        SolidColorBrush buttonClickedColor = new SolidColorBrush(Color.FromArgb(0xFF, 0xFF, 0xED, 0xB3));
        SolidColorBrush buttonColor = new SolidColorBrush(Color.FromArgb(0xFF, 221, 221, 221));
        private void Button_Click_kamoku(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                // 選択したら背景色変える
                if (TanniInfo.gakubu_h_ButtonToBool.ContainsKey(btn.Name))
                {
                    if (TanniInfo.gakubu_h_ButtonToBool[btn.Name].isClicked == 0)
                    {
                        btn.Background = buttonClickedColor;
                        // Dictionaryいじる クリックした
                        TanniInfo.gakubu_h_ButtonToBool[btn.Name].isClicked = 1;
                    }
                    else
                    {
                        btn.Background = buttonColor;
                        // Dictionaryいじる クリックしてない
                        TanniInfo.gakubu_h_ButtonToBool[btn.Name].isClicked = 0;
                    }
                }
            }
        }

        public static int htanni_gakubu_h = 17; // 必要単位数
        public static int tanni_gakubu_h = 0; //取った単位数
        private void Button_Click_kettei(object sender, RoutedEventArgs e)
        {
            // 学部共通科目必修の単位数を出力させる
            // 計算する (計算した単位数が戻り値)
            tanni_gakubu_h = TanniInfo.CalculateTanni(TanniInfo.gakubu_h_ButtonToBool);
            // (必要単位数) - (計算した単位数) を出力させる
            // 必要単位数は17
            MessageBox.Show("学部共通科目 必修 " + tanni_gakubu_h + " 単位(17単位中) " +
                "\n\rあと" + (htanni_gakubu_h - tanni_gakubu_h).ToString() + "単位");
        }
    }
}
