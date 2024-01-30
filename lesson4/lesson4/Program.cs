namespace lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task 1
            //for (int i = 1; i < 100; i+=2)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            Console.WriteLine();

            #region task 2
            //for (int i = 5;i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            Console.WriteLine();

            #region task 3
            //Console.WriteLine("Введите число");
            //int last = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for (int i = 1; i <= last; i++)
            //{
            //    sum+= i;
            //}
            //Console.WriteLine($"Сумма от 1 до {last} равна: {sum}");
            #endregion

            Console.WriteLine();

            #region task 4
            //int j = 7;
            //while (j < 100)
            //{
            //    Console.Write(j + ", ");
            //    j += 7;
            //}
            #endregion

            Console.WriteLine();

            #region task 5
            int[] array1 = new int[5];
            int[] array2 = new int[5];
            double avar1 = 0;
            double avar2 = 0;
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                array1[i] = rnd.Next();
                avar1 += array1[i];
                array2[i] = rnd.Next();
                avar2 += array2[i];
            }
            avar1 /= 5;
            avar2 /= 5;
            

            for (int i = 0; i < 5; i++)
            {
                Console.Write(array1[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                Console.Write(array2[i] + " ");
            }
            Console.WriteLine();


            if (avar1 > avar2) { Console.WriteLine($"Среднее арифметическое первого массива {avar1} больше чем у второго {avar2}"); }
            else if (avar1 < avar2) { Console.WriteLine($"Среднее арифметическое второго массива {avar2} больше чем у первого {avar1}"); }
            else { Console.WriteLine($"Среднее арифметическое первого равно среднему ариф второго {avar1}"); }
            #endregion
        }
    }
}
