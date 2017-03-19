using MatrixHelper;
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
            MatrixInstance myArr = new MatrixInstance();
            MatrixInstance myArk = new MatrixInstance();
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
            MatrixInstance newArr = myArr.Peremnogenie(myArk);
            Massdeport(newArr);
        }

        private static void Massdeport(MatrixInstance myArr)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("Output.txt"))
            {
                for (int y = 0; y < 3; y++)
                {
                    string line = myArr.MatrixArr[y, 0] + " " + myArr.MatrixArr[y, 1] + " " + myArr.MatrixArr[y, 2];
                    file.WriteLine(line);
                }
            }
        }

        private static void Massread(MatrixInstance myArr, StreamReader dat)
        {
            Char delimiter = ' ';
            for (int j = 0; j < 3; j++)
            {
                string[] Mass = dat.ReadLine().Split(delimiter);
                for (int i = 0; i < 3; i++)
                {
                    myArr.NewMethod(j,i, Mass[i]);
                }
            }
        }
    }
}
