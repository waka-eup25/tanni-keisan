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
    /// gakubu_s.xaml の相互作用ロジック
    /// </summary>
    public partial class gakubu_s : Page
    {
        private MainWindow mainWindow;
        public gakubu_s(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            SetDictionary();

            // ボタンを押していたら画面遷移して戻ってきてもボタンを押したままにしておく
            void f(Button hoge)
            {
                if (TanniInfo.gakubu_s_ButtonToBool[hoge.Name].isClicked == 1)
                {
                    hoge.Background = buttonClickedColor;
                }
                else
                {
                    hoge.Background = buttonColor;
                }
            }

            f(read);
            f(write);
            f(kougi2);
            f(akademikkuRead);
            f(discussion);
            f(kougi1);
            f(write2);
            f(akademikkuWrite);
        }

        private void Button_Click_back(object sender, RoutedEventArgs e)
        {
            var start = new start(mainWindow);
            NavigationService.Navigate(start);
        }

        private void SetDictionary()
        {
            if (!TanniInfo.gakubu_s_ButtonToBool.ContainsKey(read.Name))
            {
                TanniInfo.gakubu_s_ButtonToBool.Add(read.Name, new Kamoku_states(0, 1));
            }
            if (!TanniInfo.gakubu_s_ButtonToBool.ContainsKey(write.Name))
            {
                TanniInfo.gakubu_s_ButtonToBool.Add(write.Name, new Kamoku_states(0, 1));
            }
            if (!TanniInfo.gakubu_s_ButtonToBool.ContainsKey(kougi2.Name))
            {
                TanniInfo.gakubu_s_ButtonToBool.Add(kougi2.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakubu_s_ButtonToBool.ContainsKey(akademikkuRead.Name))
            {
                TanniInfo.gakubu_s_ButtonToBool.Add(akademikkuRead.Name, new Kamoku_states(0, 1));
            }
            if (!TanniInfo.gakubu_s_ButtonToBool.ContainsKey(discussion.Name))
            {
                TanniInfo.gakubu_s_ButtonToBool.Add(discussion.Name, new Kamoku_states(0, 1));
            }
            if (!TanniInfo.gakubu_s_ButtonToBool.ContainsKey(kougi1.Name))
            {
                TanniInfo.gakubu_s_ButtonToBool.Add(kougi1.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakubu_s_ButtonToBool.ContainsKey(write2.Name))
            {
                TanniInfo.gakubu_s_ButtonToBool.Add(write2.Name, new Kamoku_states(0, 1));
            }
            if (!TanniInfo.gakubu_s_ButtonToBool.ContainsKey(akademikkuWrite.Name))
            {
                TanniInfo.gakubu_s_ButtonToBool.Add(akademikkuWrite.Name, new Kamoku_states(0, 2));
            }
        }

        SolidColorBrush buttonClickedColor = new SolidColorBrush(Color.FromArgb(0xFF, 0xFF, 0xED, 0xB3));
        SolidColorBrush buttonColor = new SolidColorBrush(Color.FromArgb(0xFF, 221, 221, 221));
        private void Button_Click_kamoku(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                // 選択したら背景色変える
                if (TanniInfo.gakubu_s_ButtonToBool.ContainsKey(btn.Name))
                {
                    if (TanniInfo.gakubu_s_ButtonToBool[btn.Name].isClicked == 0)
                    {
                        btn.Background = buttonClickedColor;
                        // Dictionaryいじる クリックした
                        TanniInfo.gakubu_s_ButtonToBool[btn.Name].isClicked = 1;
                    }
                    else
                    {
                        btn.Background = buttonColor;
                        // Dictionaryいじる クリックしてない
                        TanniInfo.gakubu_s_ButtonToBool[btn.Name].isClicked = 0;
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
