using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatePlus;

namespace CalculatePlus
{
    class Func
    {
        /// <summary>
        /// Разделяет строку на Первыое число, Арифметическое действие, и второе число
        /// После разделения, Проводит Арифмет действие с двумя числами.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static double ariphmetikInText(string inputString)
        {
            string input1 = "", input2 = "";
            double result = 0f;
            char charValue = ' ';  // Арифметическое действие.
            bool oneToo = false;
            foreach (char c in inputString)
            {
                if ((c == '+') || (c == '-') || (c == '*') || (c == '/'))
                {
                    charValue = c;   ///  Записываем введенный Арефмет. оператор.
                    oneToo = true;
                    continue;
                }
                if (!oneToo)    ///  Записываем первое число
                    input1 += c;
                if (oneToo)         ///  Записываем второе число
                    input2 += c;
            }
            if (charValue == '+')
            { ///input == "+"   Прибавление
                result = Convert.ToDouble(input1) + Convert.ToDouble(input2);
            }
            if (charValue == '-')
            { ///input == "-"  Вычитание
                result = Convert.ToDouble(input1) - Convert.ToDouble(input2);
            }
            if (charValue == '/')
            { ///input == "/" Деление
                result = Convert.ToDouble(input1) / Convert.ToDouble(input2);
            }
            if (charValue == '*')
            { ///input == "*"  Умножение
                result = Convert.ToDouble(input1) * Convert.ToDouble(input2);
            }
            return result;
        }
    }
}
