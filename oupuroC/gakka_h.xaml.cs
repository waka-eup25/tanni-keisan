using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    /// gakka_h.xaml の相互作用ロジック
    /// </summary>
    public partial class gakka_h : Page
    {
        private MainWindow mainWindow;
        public gakka_h(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            SetDictionary();

            // ボタンを押していたら画面遷移して戻ってきてもボタンを押したままにしておく
            void f(Button hoge)
            {
                if (TanniInfo.gakka_h_ButtonToBool[hoge.Name].isClicked == 1)
                {
                    hoge.Background = buttonClickedColor;
                }
                else
                {
                    hoge.Background = buttonColor;
                }
            }

            f(biseki1);
            f(senkei1);
            f(syugou);
            f(senkei2);
            f(gurahu);
            f(suri1);
            f(zyohoriron);
            f(ad);
            f(ronrikairo);
            f(proho);
            f(otomaton);
            f(konne);
            f(modering);
            f(singou);
            f(keisanki1);
            f(zinkoutinou);
            f(zikkenA);
            f(keisanki2);
            f(kikaigo);
            f(os);
            f(zikkenB);
            f(zikkenC);
            f(sotuken);
        }

        private void Button_Click_back(object sender, RoutedEventArgs e)
        {
            var start = new start(mainWindow);
            NavigationService.Navigate(start);
        }

        private void SetDictionary()
        {
            if (!TanniInfo.gakka_h_ButtonToBool.ContainsKey(biseki1.Name))
            {
                TanniInfo.gakka_h_ButtonToBool.Add(biseki1.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_h_ButtonToBool.ContainsKey(senkei1.Name))
            {
                TanniInfo.gakka_h_ButtonToBool.Add(senkei1.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_h_ButtonToBool.ContainsKey(syugou.Name))
            {
                TanniInfo.gakka_h_ButtonToBool.Add(syugou.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_h_ButtonToBool.ContainsKey(senkei2.Name))
            {
                TanniInfo.gakka_h_ButtonToBool.Add(senkei2.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_h_ButtonToBool.ContainsKey(gurahu.Name))
            {
                TanniInfo.gakka_h_ButtonToBool.Add(gurahu.Name, new Kamoku_states(0, 1));
            }
            if (!TanniInfo.gakka_h_ButtonToBool.ContainsKey(suri1.Name))
            {
                TanniInfo.gakka_h_ButtonToBool.Add(suri1.Name, new Kamoku_states(0, 1));
            }
            if (!TanniInfo.gakka_h_ButtonToBool.ContainsKey(zyohoriron.Name))
            {
                TanniInfo.gakka_h_ButtonToBool.Add(zyohoriron.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_h_ButtonToBool.ContainsKey(ad.Name))
            {
                TanniInfo.gakka_h_ButtonToBool.Add(ad.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_h_ButtonToBool.ContainsKey(ronrikairo.Name))
            {
                TanniInfo.gakka_h_ButtonToBool.Add(ronrikairo.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_h_ButtonToBool.ContainsKey(proho.Name))
            {
                TanniInfo.gakka_h_ButtonToBool.Add(proho.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_h_ButtonToBool.ContainsKey(otomaton.Name))
            {
                TanniInfo.gakka_h_ButtonToBool.Add(otomaton.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_h_ButtonToBool.ContainsKey(konne.Name))
            {
                TanniInfo.gakka_h_ButtonToBool.Add(konne.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_h_ButtonToBool.ContainsKey(modering.Name))
            {
                TanniInfo.gakka_h_ButtonToBool.Add(modering.Name, new Kamoku_states(0, 1));
            }
            if (!TanniInfo.gakka_h_ButtonToBool.ContainsKey(singou.Name))
            {
                TanniInfo.gakka_h_ButtonToBool.Add(singou.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_h_ButtonToBool.ContainsKey(keisanki1.Name))
            {
                TanniInfo.gakka_h_ButtonToBool.Add(keisanki1.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_h_ButtonToBool.ContainsKey(zinkoutinou.Name))
            {
                TanniInfo.gakka_h_ButtonToBool.Add(zinkoutinou.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_h_ButtonToBool.ContainsKey(zikkenA.Name))
            {
                TanniInfo.gakka_h_ButtonToBool.Add(zikkenA.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_h_ButtonToBool.ContainsKey(keisanki2.Name))
            {
                TanniInfo.gakka_h_ButtonToBool.Add(keisanki2.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_h_ButtonToBool.ContainsKey(kikaigo.Name))
            {
                TanniInfo.gakka_h_ButtonToBool.Add(kikaigo.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_h_ButtonToBool.ContainsKey(os.Name))
            {
                TanniInfo.gakka_h_ButtonToBool.Add(os.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_h_ButtonToBool.ContainsKey(zikkenB.Name))
            {
                TanniInfo.gakka_h_ButtonToBool.Add(zikkenB.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_h_ButtonToBool.ContainsKey(zikkenC.Name))
            {
                TanniInfo.gakka_h_ButtonToBool.Add(zikkenC.Name, new Kamoku_states(0, 2));
            }
            if (!TanniInfo.gakka_h_ButtonToBool.ContainsKey(sotuken.Name))
            {
                TanniInfo.gakka_h_ButtonToBool.Add(sotuken.Name, new Kamoku_states(0, 6));
            }
        }

        SolidColorBrush buttonClickedColor = new SolidColorBrush(Color.FromArgb(0xFF, 0xFF, 0xED, 0xB3));
        SolidColorBrush buttonColor = new SolidColorBrush(Color.FromArgb(0xFF, 221, 221, 221));
        private void Button_Click_kamoku(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                // 選択したら背景色変える
                if (TanniInfo.gakka_h_ButtonToBool.ContainsKey(btn.Name))
                {
                    if (TanniInfo.gakka_h_ButtonToBool[btn.Name].isClicked == 0)
                    {
                        btn.Background = buttonClickedColor;
                        // Dictionaryいじる クリックした
                        TanniInfo.gakka_h_ButtonToBool[btn.Name].isClicked = 1;
                    }
                    else
                    {
                        btn.Background = buttonColor;
                        // Dictionaryいじる クリックしてない
                        TanniInfo.gakka_h_ButtonToBool[btn.Name].isClicked = 0;
                    }
                }
            }
        }

        public static int htanni_gakka_h = 47; // 必要単位数
        public static int tanni_gakka_h = 0; //取った単位数
        private void Button_Click_kettei(object sender, RoutedEventArgs e)
        {
            // 学科専門科目必修の単位数を出力させる
            // 計算する (計算した単位数が戻り値)
            tanni_gakka_h = TanniInfo.CalculateTanni(TanniInfo.gakka_h_ButtonToBool);
            // (必要単位数) - (計算した単位数) を出力させる
            // 必要単位数は47
            MessageBox.Show("学科専門科目 必修(47) あと" + (htanni_gakka_h -tanni_gakka_h).ToString());
        }
    }
}

