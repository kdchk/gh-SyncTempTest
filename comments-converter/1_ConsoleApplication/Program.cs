using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "\u041d\u0443 \u0432\u043e\u043e\u0431\u0449\u0435\u043c \u0442\u0430\u043a \u043a\u0430\u043a-\u0442\u043e. 10 \u0434\u043d\u0435\u0439, 5 \u0441\u0442\u0440\u0430\u043d, \u0441\u043e\u0442\u043d\u0438 \u043a\u0438\u043b\u043e\u043c\u0435\u0442\u0440\u043e\u0432 \u0434\u043e\u0440\u043e\u0433, \u043d\u0435\u0440\u0432\u043e\u0432 \u0438 \u0434\u0435\u043d\u0435\u0433 :) 3 \u0434\u0435\u0432\u043e\u0447\u043a\u0438, 2 \u0447\u0435\u043c\u043e\u0434\u0430\u043d\u0430, 5 \u0441\u0430\u043c\u043e\u043b\u0451\u0442\u043e\u0432, 2 \u0430\u0432\u0442\u043e\u0431\u0443\u0441\u0430, 1 \u043c\u0430\u0448\u0438\u043d\u0430. \u0427\u0442\u043e \u0434\u0430\u043b\u044c\u0448\u0435? \u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0438\u043c ;)".Normalize();
            Console.WriteLine(s);
            //Output: Ну вообщем так как-то. 10 дней, 5 стран, сотни километров дорог, нервов и денег :) 3 девочки, 2 чемодана, 5 самолётов, 2 автобуса, 1 машина. Что дальше? Посмотрим ;)

            Console.ReadLine();

            //or

            //http://www.sql.ru/forum/674370/preobrazovat-stroku-u0440-u044f-u0434-v-stroku-ryad
            //Подскажите есть ли простой способ перевода строку "\u0440\u044f\u0434" в строку "ряд" без распарсивания и перевода каждого символа unicoda и обратной сборки

            /*
               1) string s = "\u0440\u044f\u0434".Normalize();

               2) string.Format("\u0440\u044f\u0434")

               3) "Если проще: есть TextBox и кнопка. В ТехtBoxe набрана строка \u0440\u044f\u0434. после нажатия кнопки там должно быть "ряд".":
                  using System.Text.RegularExpressions;
                    ...

		            textBox1.Text = Regex.Replace(textBox1.Text, @"\\u([0-9a-fA-F]{4})", delegate(Match m) 
		            	{
		            	return ((char)int.Parse(m.Groups[1].Value, System.Globalization.NumberStyles.HexNumber)).ToString();
		            	});
                                  
            */

        }
    }
}
