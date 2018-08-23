using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculate
    {
        public static String Calc(String _in)
        {
            float show = 0;
            List<String> elem = Split(_in);
            for (int i = 1; i < elem.Count; i += 2)
            {
                elem[2] = 5.ToString();
            }
            
            return show.ToString();
        }

        public static List<String> Split(String _in)
        {
            List<String> show = new List<string>();
            String temp = "";
            temp += _in[0].ToString();
            for (int i = 1; i < _in.Length; i++)
            {
                Char let = _in[i];
                if (Char.IsDigit(let))
                {
                    temp += let;
                }
                else if(let == '(')
                {
                    temp = Calc(_in.Substring(i+1, _in.LastIndexOf(')') - i));
                    i = _in.LastIndexOf(')');
                }
                else
                {
                    show.Add(temp);
                    temp = "";
                    show.Add(let.ToString());
                }
            }
            show.Add(temp);
            return show;
        }

        public static String Show(List<String> _out)
        {
            String show = "";
            foreach (String st in _out)
            {
                show += (st + " ");
            }
            return show;
        }

    }
}
