using System.Net.Http.Headers;
using System.Xml.Serialization;

namespace lesson4_
{



    internal class Program
    {
        static int size;
    
        static void SortMatrix(int[,] matrix)
        {
            int[,] matr = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matr[i, j] = matrix[i, j];
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; i < size - 1; i++)
                {
                    for (int k = j + 1; j < size; j++)
                    {
                        if (matr[i, j] > matr[i,k])
                        {
                            int temp = matr[i, j];
                            matr[i, j] = matr[i, k];
                            matr[i, k] = temp;
                        }
                    }
                }
            }
            WriteMatrx(matr);
        }

        static void InvertMatrix(int[,] matr)
        {
            int[,] inverted = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    inverted[i, j] = matr[i, size - 1 - j]; //! !!! out of range
                }
            }
            WriteMatrx(inverted);

        }


        static void NegativePositive(int[,] matr)
        {
            int negative = 0;
            int positive = 0;
            int zeros = 0;
            for (int j = 0; j < size; j++)
            {
                for (int i = 0; i < size; i++)
                {
                    if (matr[i, j] > 0) positive++;
                    else if (matr[i, j] < 0) negative++;
                    else zeros++;
                }
            }
            Console.WriteLine($"Всего {positive} положительных числел, {negative} отрицательных и {zeros} нулей");
        }


        static void WriteMatrx(int[,] matr)
        {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                Console.Write("|");
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    Console.Write($" {matr[i,j]} ");
                }
                Console.Write("|");
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер матрицы");
            size = 0;
            bool isValidSize = false;
            while (true)
            {
                isValidSize = int.TryParse(Console.ReadLine(), out size);
                if (isValidSize) { break; }
            }
            int[,] matrix = new int[size, size];


            Random rndElement = new Random();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = rndElement.Next(1, 50);
                }
            }
            WriteMatrx(matrix);
            int choice;
            while (true)
            {
                Console.Clear();
                WriteMatrx(matrix);
                Console.WriteLine("Выбор действия");
                Console.WriteLine("1) Найти кол-во положительных и отрицательных элеиентов"); 
                Console.WriteLine("2) Сортировка эл-ов построчно"); 
                Console.WriteLine("3) Инвертировать элементы матрицы построчно"); 
                while (true)
                {
                    Console.WriteLine("Напишите ваш выбор(1-3)");
                    if (int.TryParse(Console.ReadLine(), out choice) && choice >=1 && choice <=3) { break; }
                }
                switch (choice)
                {
                    case 1: NegativePositive(matrix); break;
                    case 2: SortMatrix(matrix); break;
                    case 3: InvertMatrix(matrix); break;
                    default: Console.WriteLine("error :("); break;
                }
                Console.WriteLine("Если повторно использовать код не нужно, то введите -");
                int exitKey = Console.Read();
                if (exitKey == 45) break;
            }

        }
    }
}
