using Tyuiu.SmirnovaYV.Sprint4.Task7.V1.Lib;
namespace Tyuiu.SmirnovaYV.Sprint4.Task7.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 3;
            int columns = 3;
            int[,] mtrx= new int[rows, columns];
            string str = "135792468";
            DataService ds = new DataService();
            Console.Title = "Спринт #4| Выполнила: Смирнова Ю.В.| АСОиУБ-26-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                *");
            Console.WriteLine("* Тема: Добавление крешению итоговых проектов по спринту                   *");
            Console.WriteLine("* Задание #7                                                               *");
            Console.WriteLine("* Вариант #1                                                               *");
            Console.WriteLine("* Выполнила: Смирнова Юлия Валерьевна | АСОиУБ-26-1                        *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"135792468\".                         *");
            Console.WriteLine("* Преобразуйте ее в матрицу 3 на 3 и подсчитайте количество четных чисел.  *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            int index = 0;
            Console.WriteLine("\nМассив: ");
            for (int i=0; i<rows; i++)
            {
                for (int j=0; j<columns; j++)
                {
                    Console.Write($"{str[index]}\t");
                    index++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Результат:                                                               *");
            Console.WriteLine("****************************************************************************");
            int res = ds.Calculate(rows, columns, str);
            Console.WriteLine("Количество чётных элементов= " + res);
            Console.ReadKey();
        }
    }
}
