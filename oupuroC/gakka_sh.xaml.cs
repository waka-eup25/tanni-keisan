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
    /// gakka_sh.xaml の相互作用ロジック
    /// </summary>
    public partial class gakka_sh : Page
    {
        private MainWindow mainWindow;
        public gakka_sh(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            SetDictionary();

            // ボタンを押していたら画面遷移して戻ってきてもボタンを押したままにしておく
            void f(Button hoge)
            {
                if (TanniInfo.gakka_sh_ButtonToBool[hoge.Name].isClicked == 1)
                {
                    hoge.Background = buttonClickedColor;
                }
                else
                {
                    hoge.Background = buttonColor;
                }
            }

            f(biseki2);
            f(suri2);
            f(nintikagaku);
            f(tinoukagaku);
            f(hugou);
            f(dhizitaru);
            f(oupuroA);
            f(oupuroB);
            f(oupuroC);
            f(keisanriron);
            f(debesys);
            f(konpaira);
            f(netpro);
            f(kikaigakusyu);
        }
        private void Button_Click_back(object sender, RoutedEventArgs e)
        {
            var start = new start(mainWindow);
            NavigationService.Navigate(start);
        }

        private void SetDictionary()
        {
            if (!TanniInfo.gakka_sh_ButtonToBool.ContainsKey(biseki2.Name))
            {
                TanniInfo.gakka_sh_ButtonToBool.Add(biseki2.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_sh_ButtonToBool.ContainsKey(suri2.Name))
            {
                TanniInfo.gakka_sh_ButtonToBool.Add(suri2.Name, new Kamoku_states(0, 1));
            }
            if (!TanniInfo.gakka_sh_ButtonToBool.ContainsKey(nintikagaku.Name))
            {
                TanniInfo.gakka_sh_ButtonToBool.Add(nintikagaku.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_sh_ButtonToBool.ContainsKey(tinoukagaku.Name))
            {
                TanniInfo.gakka_sh_ButtonToBool.Add(tinoukagaku.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_sh_ButtonToBool.ContainsKey(hugou.Name))
            {
                TanniInfo.gakka_sh_ButtonToBool.Add(hugou.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_sh_ButtonToBool.ContainsKey(dhizitaru.Name))
            {
                TanniInfo.gakka_sh_ButtonToBool.Add(dhizitaru.Name, new Kamoku_states(0, 1));
            }
            if (!TanniInfo.gakka_sh_ButtonToBool.ContainsKey(oupuroA.Name))
            {
                TanniInfo.gakka_sh_ButtonToBool.Add(oupuroA.Name, new Kamoku_states(0, 1));
            }
            if (!TanniInfo.gakka_sh_ButtonToBool.ContainsKey(oupuroB.Name))
            {
                TanniInfo.gakka_sh_ButtonToBool.Add(oupuroB.Name, new Kamoku_states(0, 1));
            }
            if (!TanniInfo.gakka_sh_ButtonToBool.ContainsKey(oupuroC.Name))
            {
                TanniInfo.gakka_sh_ButtonToBool.Add(oupuroC.Name, new Kamoku_states(0, 1));
            }
            if (!TanniInfo.gakka_sh_ButtonToBool.ContainsKey(keisanriron.Name))
            {
                TanniInfo.gakka_sh_ButtonToBool.Add(keisanriron.Name, new Kamoku_states(0, 1));
            }
            if (!TanniInfo.gakka_sh_ButtonToBool.ContainsKey(debesys.Name))
            {
                TanniInfo.gakka_sh_ButtonToBool.Add(debesys.Name, new Kamoku_states(0, 21));
            }
            if (!TanniInfo.gakka_sh_ButtonToBool.ContainsKey(konpaira.Name))
            {
                TanniInfo.gakka_sh_ButtonToBool.Add(konpaira.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_sh_ButtonToBool.ContainsKey(netpro.Name))
            {
                TanniInfo.gakka_sh_ButtonToBool.Add(netpro.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_sh_ButtonToBool.ContainsKey(kikaigakusyu.Name))
            {
                TanniInfo.gakka_sh_ButtonToBool.Add(kikaigakusyu.Name, new Kamoku_states(0, 2));
            }
        }

        SolidColorBrush buttonClickedColor = new SolidColorBrush(Color.FromArgb(0xFF, 0xFF, 0xED, 0xB3));
        SolidColorBrush buttonColor = new SolidColorBrush(Color.FromArgb(0xFF, 221, 221, 221));
        private void Button_Click_kamoku(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                // 選択したら背景色変える
                if (TanniInfo.gakka_sh_ButtonToBool.ContainsKey(btn.Name))
                {
                    if (TanniInfo.gakka_sh_ButtonToBool[btn.Name].isClicked == 0)
                    {
                        btn.Background = buttonClickedColor;
                        // Dictionaryいじる クリックした
                        TanniInfo.gakka_sh_ButtonToBool[btn.Name].isClicked = 1;
                    }
                    else
                    {
                        btn.Background = buttonColor;
                        // Dictionaryいじる クリックしてない
                        TanniInfo.gakka_sh_ButtonToBool[btn.Name].isClicked = 0;
                    }
                }
            }
        }

        private void Button_Click_kettei(object sender, RoutedEventArgs e)
        {
            // 教養科目必修の単位数を出力させる
        }
    }
}
