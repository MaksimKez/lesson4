namespace lesson4_
{
//    Создать программу работы с матрицами(двухмерными массивами) c возможностью выбора размера матрицы
//Элементы вводятся вручную
//Вывести матрицу на консоль(добавить оформление, чтобы выглядело как матрица)
//Реализовать меню выбора действий:
//- Найти количество положительных/отрицательных чисел в матрице
//- Сортировка элементов матрицы построчно(в двух направлениях)
//- Инверсия элементов матрицы построчно
//- Все математические операции реализовать вручную, без использования статических методов класса Array

//PS: "Введите размер" - пользователь вводит 5 - значит матрица будет 5х5
//PS: Пользователь вводит матрицу либо построчно Введите строку 1 - "1 0 -11 - 5 0". ЛИБО поэлементно: Введите[0, 1]: -5
//PS: Можно и желательно использовать рандомное заполнение, вместо пользовательского ввода.


    internal class Program
    {
        static int size;

        static void Invert(int[,] matr)
        {
            int[,] inverted = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    inverted[i, j] = matr[i, size - j];
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
            size--;
            int[,] matrix = new int[size, size];


            Random rndElement = new Random();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = rndElement.Next(1, 100);
                }
            }
            WriteMatrx(matrix);
            while (true)
            {
                Console.Clear();
                WriteMatrx(matrix);
                Console.WriteLine("Выбор действия");
                Console.WriteLine("1) Найти кол-во положительных и отрицательных элеиентов"); // +
                Console.WriteLine("2) Сортировка эл-ов построчно"); //todo !!!
                Console.WriteLine("3) Инвертировать элементы матрицы построчно"); // todo !!!
                Invert(matrix); 
                Thread.Sleep(10000);
            }

        }
    }
}
