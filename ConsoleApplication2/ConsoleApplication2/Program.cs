using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArr = new int[3, 3];
            int[,] myArk = new int[3, 3];
            using (FileStream f1 = new FileStream("Input.txt", FileMode.Open))
            {
                using (StreamReader dat = new StreamReader(f1))
                {
                    Massread(myArr, dat); /* метод, разработанный своими руками
                    для чего он нужен никто не знает*/
                    dat.ReadLine();
                    Massread(myArk, dat);
                }
            }
            // здесь должно быть алгоритм вычисления
            Massdeport(myArr);
            Massdeport(myArk);
        }

        private static void Massdeport(int[,] myArr)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("Output.txt"))
            {
                for (int y = 0; y < 3; y++)
                {
                    string line = myArr[y, 0] + " " + myArr[y, 1] + " " + myArr[y, 2];
                    file.WriteLine(line);
                }
            }
        }

        private static void Massread(int[,] myArr, StreamReader dat)
        {
            Char delimiter = ' ';
            for (int j = 0; j < 3; j++)
            {
                string[] Mass = dat.ReadLine().Split(delimiter);
                for (int i = 0; i < 3; i++)
                {
                    myArr[j, i] = Convert.ToInt32(Mass[i]);

                }
            }
        }
    }
}
