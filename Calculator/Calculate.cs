﻿using System;
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
            string show;
            List<String> elem = Split(_in);
            while (elem.Count>3)
            {
                if (new []{"*","/" }.Contains(elem[3]))
                {
                    elem[4] = Op(elem[2], elem[3], elem[4]);
                    elem.RemoveRange(2, 2);
                }
                else
                {
                    elem[2] = Op(elem[0], elem[1], elem[2]);
                    elem.RemoveRange(0, 2);
                }
            }
            show = Op(elem[0], elem[1], elem[2]);
            return show;
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

        public static String Show(String _out)
        {
            String show = "";
            foreach (String st in Split(_out))
            {
                show += (st + " ");
            }
            return show;
        }

        public static String Op(String n1, String si, String n2)
        {
            float m1 = float.Parse(n1);
            float m2 = float.Parse(n2);
            float _out = 0;
            switch (si)
            {
                case "+":
                    _out = m1 + m2;
                    break;
                case "-":
                    _out = m1 - m2;
                    break;
                case "*":
                    _out = m1 * m2;
                    break;
                case "/":
                    _out = m1 / m2;
                    break;
            }
            n2 = _out.ToString();
            return n2;
        }

    }
}
