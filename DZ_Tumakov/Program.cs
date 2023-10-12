using System;
using System.IO;
using System.Reflection;

namespace DZ_Tumakov
{
    class Program
    {
        static void Main(string[] args)
        {
            var appDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var relativePath = @"Tumakov.txt";
            var fullPath = Path.Combine(appDir, relativePath);
            string str = File.ReadAllText(fullPath);
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