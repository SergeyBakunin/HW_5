using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5
{
    internal class HW_5
    {
        static void PrintDir(DirectoryInfo dir, string indent, bool lastDirectory)
        {
            Console.Write(indent);
            Console.Write(lastDirectory ? "└───" : "├──");
            indent += lastDirectory ? "  " : "│";
            Console.WriteLine(dir.Name);

            DirectoryInfo[] subDirs = dir.GetDirectories();
            for (int i = 0; i < subDirs.Length; i++)
            {
                PrintDir(subDirs[i], indent, i == subDirs.Length - 1);
            }
        }
        static void Main(string[] args)
        {
            // Exercise_1
            Console.WriteLine("Exercise_1");
            Console.WriteLine("_______________________");           
            Console.WriteLine("Введите сообщение: ");
            string str = Console.ReadLine();
            File.WriteAllText("text.txt", str);
            Console.WriteLine("Ваше сообщение в файле: " + File.ReadAllText("text.txt"));
            Console.WriteLine();

            // Exercise_2
            Console.WriteLine("Exercise_2");
            Console.WriteLine("_______________________");
            string currentTime = DateTime.Now.ToString();
            File.WriteAllText("startup.txt", currentTime);
            Console.WriteLine("Cообщение в файле: " + File.ReadAllText("startup.txt"));
            Console.WriteLine();

            // Exercise_3
            Console.WriteLine("Exercise_3");
            Console.WriteLine("_______________________");
            Console.WriteLine("Ввести с клавиатуры произвольный набор чисел(0...255): ");     
            string numbStr = Console.ReadLine();
            string[] numbStrArr = numbStr.Split();
            byte[] numbArr = new byte[100];
            for (int i = 0; i < numbStrArr.Length; i++)
            {
                Convert.ToByte(numbStrArr[i]);
                numbArr[i] = Convert.ToByte(numbStrArr[i]);
            };
            File.WriteAllBytes("bytes.bin", numbArr);
            Console.WriteLine("Файл записан.");
            Console.WriteLine();

            // Exercise_4
            Console.WriteLine("Exercise_4");
            Console.WriteLine("_______________________");
            PrintDir(new DirectoryInfo(@"C:\Users\Serge\YandexDisk-serge.bakunin1997@yandex.ru\GB\Lessons\HW_5"),"", true);
            
            // Не понимаю, как добавить файлы в иерархию и сохранить дерево в файл


            Console.ReadKey(true);
        }
    }
}
