using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oupuroC
{
    public static class TanniInfo
    {
        public static Dictionary<string, Kamoku_states> kyoyo_h_ButtonToBool = new Dictionary<string, Kamoku_states>();
        public static Dictionary<string, Kamoku_states> kyoyo_s_ButtonToBool = new Dictionary<string, Kamoku_states>();
        public static Dictionary<string, Kamoku_states> kyoyoA_ButtonToBool = new Dictionary<string, Kamoku_states>();
        public static Dictionary<string, Kamoku_states> kyoyoB_ButtonToBool = new Dictionary<string, Kamoku_states>();
        public static Dictionary<string, Kamoku_states> gakusaiA_ButtonToBool = new Dictionary<string, Kamoku_states>();
        public static Dictionary<string, Kamoku_states> gakubu_h_ButtonToBool = new Dictionary<string, Kamoku_states>();
        public static Dictionary<string, Kamoku_states> gakubu_s_ButtonToBool = new Dictionary<string, Kamoku_states>();
        public static Dictionary<string, Kamoku_states> gakka_h_ButtonToBool = new Dictionary<string, Kamoku_states>();
        public static Dictionary<string, Kamoku_states> gakka_sh_ButtonToBool = new Dictionary<string, Kamoku_states>();

        //Dictionaryを引数にして単位数計算ができる
        public static int CalculateTanni(Dictionary<string, Kamoku_states> hoge)
        {
            int result = 0;
            foreach (var item in hoge.Values)
            {
                result += item.isClicked * item.tannisu;
            }
            return result;
        }
    }

    public class Kamoku_states
    {
        public int isClicked;
        public int tannisu { get; }

        public Kamoku_states(int isClicked, int tannisu)
        {
            this.isClicked = isClicked;
            this.tannisu = tannisu;
        }
    }

    
}
