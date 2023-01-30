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
    /// itiran.xaml の相互作用ロジック
    /// </summary>
    public partial class itiran : Page
    {
        private MainWindow mainWindow;
        public itiran(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;

            //それぞれのTextBlockに格納していく
            kyoyo_h_l.Text = kyoyo_h.tanni_kyoyo_h.ToString();
            if (kyoyo_h.htanni_kyoyo_h - kyoyo_h.tanni_kyoyo_h >= 0)
            {
                kyoyo_h_r.Text = (kyoyo_h.htanni_kyoyo_h - kyoyo_h.tanni_kyoyo_h).ToString();

            }
            else if(kyoyo_h.htanni_kyoyo_h - kyoyo_h.tanni_kyoyo_h < 0) kyoyo_h_r.Text = "0";
            
            kyoyo_s_l.Text = kyoyo_s.tanni_kyoyo_s.ToString();
            if (kyoyo_s.htanni_kyoyo_s - kyoyo_s.tanni_kyoyo_s >= 0)
            {
                kyoyo_s_r.Text = (kyoyo_s.htanni_kyoyo_s - kyoyo_s.tanni_kyoyo_s).ToString();

            }
            else if(kyoyo_s.htanni_kyoyo_s - kyoyo_s.tanni_kyoyo_s < 0) kyoyo_s_r.Text = "0";

            kyoyoA_l.Text = kyoyo_gakusai.tanni_kyoyoA.ToString();
            if (kyoyo_gakusai.htanni_kyoyoA - kyoyo_gakusai.tanni_kyoyoA >= 0)
            {
                kyoyoA_r.Text = (kyoyo_gakusai.htanni_kyoyoA - kyoyo_gakusai.tanni_kyoyoA).ToString();

            }
            else if(kyoyo_gakusai.htanni_kyoyoA - kyoyo_gakusai.tanni_kyoyoA < 0) kyoyoA_r.Text = "0";


            kyoyoB_l.Text = kyoyo_gakusai.tanni_kyoyoB.ToString();
            if (kyoyo_gakusai.htanni_kyoyoB - kyoyo_gakusai.tanni_kyoyoB >= 0)
            {
                kyoyoB_r.Text = (kyoyo_gakusai.htanni_kyoyoB - kyoyo_gakusai.tanni_kyoyoB).ToString();

            }
            else if(kyoyo_gakusai.htanni_kyoyoB - kyoyo_gakusai.tanni_kyoyoB < 0) kyoyoB_r.Text = "0";


            gakusaiA_l.Text = kyoyo_gakusai.tanni_gakusaiA.ToString();
            if (kyoyo_gakusai.htanni_gakusaiA - kyoyo_gakusai.tanni_gakusaiA >= 0)
            {
                kyoyoA_r.Text = (kyoyo_gakusai.htanni_kyoyoA - kyoyo_gakusai.tanni_kyoyoA).ToString();

            }
            else if(kyoyo_gakusai.htanni_gakusaiA - kyoyo_gakusai.tanni_gakusaiA < 0) gakusaiA_r.Text = "0";

            gakubu_h_l.Text = gakubu_h.tanni_gakubu_h.ToString();
            if (gakubu_h.htanni_gakubu_h - gakubu_h.tanni_gakubu_h >= 0)
            {
                gakubu_h_r.Text = (gakubu_h.htanni_gakubu_h - gakubu_h.tanni_gakubu_h).ToString();

            }
            else if (gakubu_h.htanni_gakubu_h - gakubu_h.tanni_gakubu_h < 0) gakubu_h_r.Text = "0";

            gakka_h_l.Text = gakka_h.tanni_gakka_h.ToString();
            if (gakka_h.htanni_gakka_h - gakka_h.tanni_gakka_h >= 0)
            {
                gakka_h_r.Text = (gakka_h.htanni_gakka_h - gakka_h.tanni_gakka_h).ToString();

            }
            else if (gakka_h.htanni_gakka_h - gakka_h.tanni_gakka_h < 0) gakka_h_r.Text = "0";

            gakka_sh_l.Text = gakka_sh.tanni_gakka_sh.ToString();
            if (gakka_sh.htanni_gakka_sh - gakka_sh.tanni_gakka_sh >= 0)
            {
                gakka_sh_r.Text = (gakka_sh.htanni_gakka_sh - gakka_sh.tanni_gakka_sh).ToString();

            }
            else if (gakka_sh.htanni_gakka_sh - gakka_sh.tanni_gakka_sh < 0) gakka_sh_r.Text = "0";

            gakka_s_l.Text = gakka_s.tanni_gakka_s.ToString();
            if (gakka_s.htanni_gakka_s - gakka_s.tanni_gakka_s >= 0)
            {
                gakka_s_r.Text = (gakka_s.htanni_gakka_s - gakka_s.tanni_gakka_s).ToString();

            }
            else if (gakka_s.htanni_gakka_s - gakka_s.tanni_gakka_s < 0) gakka_s_r.Text = "0";

            ziyu_l.Text = sonota.tanni_ziyu.ToString();
            if (sonota.htanni_ziyu - sonota.tanni_ziyu >= 0)
            {
                ziyu_r.Text = (sonota.htanni_ziyu - sonota.tanni_ziyu).ToString();

            }
            else if (sonota.htanni_ziyu - sonota.tanni_ziyu < 0) ziyu_r.Text = "0";
        }

        private void Button_Click_back(object sender, RoutedEventArgs e)
        {
            var start = new start(mainWindow);
            NavigationService.Navigate(start);
        }
    }
}
