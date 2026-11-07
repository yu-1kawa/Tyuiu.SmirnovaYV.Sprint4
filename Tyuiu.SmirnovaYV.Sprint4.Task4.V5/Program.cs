using Tyuiu.SmirnovaYV.Sprint4.Task4.V5.Lib;
namespace Tyuiu.SmirnovaYV.Sprint4.Task4.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            DataService ds = new DataService();
            Console.Title = "Спринт #4| Выполнила: Смирнова Ю.В.| АСОиУБ-26-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                *");
            Console.WriteLine("* Тема: Двумерные массивы(ввод c клавиатуры)                               *");
            Console.WriteLine("* Задание #4                                                               *");
            Console.WriteLine("* Вариант #5                                                               *");
            Console.WriteLine("* Выполнила: Смирнова Юлия Валерьевна | АСОиУБ-26-1                        *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный         *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 3 до 9.                           *");
            Console.WriteLine("* Найдите сумму четных элементов массива.                                  *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Введите количество строк в массиве: ");
            int rows=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов в массиве: ");
            int colums = Convert.ToInt32(Console.ReadLine());
            int[,] mtrx = new int[rows, colums];
            Console.WriteLine("****************************************************************************");
            for (int i=0; i<rows; i++)
            {
                for (int j =0; j<colums; j++)
                {
                    Console.Write($"Введите {i},{j} элемент массива: ");
                    mtrx[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Результат:                                                               *");
            Console.WriteLine("****************************************************************************");
            int res = ds.Calculate(mtrx);
            Console.WriteLine("Сумма чётных элементов = " + res);
            Console.ReadKey();
        }
    }
}
