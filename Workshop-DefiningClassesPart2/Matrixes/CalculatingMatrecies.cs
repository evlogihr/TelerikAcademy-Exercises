using System;
using System.Linq;

using Matrixes.Models;

namespace Matrixes
{
    class CalculatingMatrecies
    {
        static void Main()
        {
            int row = 4, col = 5;
            var matrix1 = new Matrix<int>(row, col);
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    matrix1[r, c] = r + c + 2;
                }
            }

            row = 5;
            col = 3;
            var matrix2 = new Matrix<int>(row, col);
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    matrix2[r, c] = r + c;
                }
            }

            Console.WriteLine(matrix1);
            Console.WriteLine(matrix2);

            //Console.WriteLine(matrix1 + matrix2);
            //Console.WriteLine(matrix1 - matrix2);
            Console.WriteLine(matrix1 * matrix2);

            if (!matrix1)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }

            Type type = typeof(Matrix<int>);
            object[] attr = type.GetCustomAttributes(false);
            foreach (var item in attr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
