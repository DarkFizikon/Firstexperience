using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixHelper
{
    public class MatrixInstance
    {
        private int[,] matrixArr = new int[3, 3];
        public MatrixInstance(MatrixInstance param)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    this.matrixArr[i, j] = param.MatrixArr[i, j];
                }
            }
        }
        public MatrixInstance Peremnogenie(MatrixInstance umnmatrix)
        {
            MatrixInstance ResultMatrix = new MatrixInstance();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    MatrixInstance.PeremnogenieDetail(this, umnmatrix, ResultMatrix, i, j);
                }
            }

                return ResultMatrix;
        }

        private static void PeremnogenieDetail(MatrixInstance matrixInstance,
            MatrixInstance umnmatrix, MatrixInstance resultMatrix, int i, int j)
        {
            int temp = 0;
            for (int n = 0; n < 3; n++)
            {
                temp = temp + (matrixInstance.MatrixArr[i, n] * umnmatrix.MatrixArr[n, j]);
            }
            resultMatrix.MatrixArr[i, j] = temp;
        }
        public MatrixInstance()
        {

        }

        public int[,] MatrixArr
        {
            get
            {
                return matrixArr;
            }

            set
            {
                matrixArr = value;
            }
        }

        public void NewMethod( int j, int i, string cell)
        {
            this.MatrixArr[j, i] = Convert.ToInt32(cell);
        }
    }
}
