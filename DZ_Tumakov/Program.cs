using System;
using System.IO;

namespace DZ_Tumakov
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string str = File.ReadAllText("C:\\Users\\fifif\\source\\repos\\Home_Work_14_10_2023\\Tumakov.txt");
            char[] ArrayChars = new char[str.Length];

            for (int j = 0; j < str.Length - 1; j++)
            {
                ArrayChars[j] = str[j];
            }

            int Glas = 0;
            int Sogl = 0;
            string StrSogl = "QqWwRrTtPpSsDdFfGgHhJjKkLlZzXxCcVvBbNnMmЙйЦцКкНнГгШшЩщЗзХхФфВвПпРрЛлДдЧчСсМмТтБб";
            string StrGlas = "EeYyUuIiOoAaУуЕеЫыАаОоЭэЯяИиЮю";
            foreach (char arg in ArrayChars)
            {
                if (StrSogl.Contains(Convert.ToString(arg))) 
                {
                    Sogl++;
                }
                else if (StrGlas.Contains(Convert.ToString(arg))) 
                {
                    Glas++;
                }
            }
            Console.WriteLine($"Количество согласных букв в файле равно - {Sogl} \nКоличество гласных букв в файле равно - {Glas}");
            Console.ReadKey();
        }
    }
}
