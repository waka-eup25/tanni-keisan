using System;
using System.Collections.Generic;
using System.Configuration;
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
    /// kyoyo_h.xaml の相互作用ロジック
    /// </summary>
    public partial class kyoyo_h : Page
    {
        private MainWindow mainWindow;
        public kyoyo_h(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            SetDictionary();

            // ボタンを押していたら画面遷移して戻ってきてもボタンを押したままにしておく
            void f(Button hoge)
            {
                if (TanniInfo.kyoyo_h_ButtonToBool[hoge.Name].isClicked == 1)
                {
                    hoge.Background = buttonClickedColor;
                }
                else
                {
                    hoge.Background = buttonColor;
                }
            }

            // それぞれのボタンについてボタンを押してあるかどうかチェック→ボタンの色を変更
            f(sinsemi);
            f(suri);
            f(eikomyu);
            f(kyarideza);
            f(zyohosyori);
            f(eigoensyu);
        }
        

        private void Button_Click_back(object sender, RoutedEventArgs e)
        {
            var start = new start(mainWindow);
            NavigationService.Navigate(start);
        }


        private void SetDictionary()
        {
            if(!TanniInfo.kyoyo_h_ButtonToBool.ContainsKey(sinsemi.Name))
            {
                TanniInfo.kyoyo_h_ButtonToBool.Add(sinsemi.Name, new Kamoku_states(0, 2));
            }
            if(!TanniInfo.kyoyo_h_ButtonToBool.ContainsKey(suri.Name))
            {
                TanniInfo.kyoyo_h_ButtonToBool.Add(suri.Name, new Kamoku_states(0, 1));

            }
            if(!TanniInfo.kyoyo_h_ButtonToBool.ContainsKey(eikomyu.Name))
            {
                TanniInfo.kyoyo_h_ButtonToBool.Add(eikomyu.Name, new Kamoku_states(0, 2));

            }
            if(!TanniInfo.kyoyo_h_ButtonToBool.ContainsKey(kyarideza.Name))
            {
                TanniInfo.kyoyo_h_ButtonToBool.Add(kyarideza.Name, new Kamoku_states(0, 1));

            }
            if(!TanniInfo.kyoyo_h_ButtonToBool.ContainsKey(zyohosyori.Name))
            {
                TanniInfo.kyoyo_h_ButtonToBool.Add(zyohosyori.Name, new Kamoku_states(0, 2));

            }
            if(!TanniInfo.kyoyo_h_ButtonToBool.ContainsKey(eigoensyu.Name))
            {
                TanniInfo.kyoyo_h_ButtonToBool.Add(eigoensyu.Name, new Kamoku_states(0, 1));

            }
        }

        SolidColorBrush buttonClickedColor = new SolidColorBrush(Color.FromArgb(0xFF,0xFF, 0xED, 0xB3)); //クリックした
        SolidColorBrush buttonColor = new SolidColorBrush(Color.FromArgb(0xFF, 221, 221, 221)); //クリックしてない
        private void Button_Click_kamoku(object sender, RoutedEventArgs e)
        {
            if(sender is Button btn)
            {
                // 選択したら背景色変える
                if(TanniInfo.kyoyo_h_ButtonToBool[btn.Name].isClicked == 0)
                {
                    btn.Background = buttonClickedColor;
                    // Dictionaryいじる クリックした
                    TanniInfo.kyoyo_h_ButtonToBool[btn.Name].isClicked = 1;
                }
                else
                {
                    btn.Background = buttonColor;
                    // Dictionaryいじる クリックしてない
                    TanniInfo.kyoyo_h_ButtonToBool[btn.Name].isClicked = 0;
                }
            }
        }

        private void Butto_Click_kettei(object sender, RoutedEventArgs e)
        {
            // 教養科目必修の単位数を出力させる
        }
    }

  
}
