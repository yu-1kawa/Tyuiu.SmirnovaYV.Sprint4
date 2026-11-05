using Tyuiu.SmirnovaYV.Sprint4.Task0.V9.Lib;
namespace Tyuiu.SmirnovaYV.Sprint4.Task0.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4| Выполнила: Смирнова Ю.В.| АСОиУБ-26-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт#4                                                                 *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                              *");
            Console.WriteLine("* Задание #0                                                               *");
            Console.WriteLine("* Вариант #9                                                               *");
            Console.WriteLine("* Выполнила: Смирнова Юлия Валерьевна | АСОиУБ-26-1                        *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов, заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать                 *");
            Console.WriteLine("* сумму четных элементов массива.  { 4 ,6 ,2 ,8 ,4 ,5 ,6 ,9 ,8 ,7}         *"); 
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            int[] numsArray = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i <= numsArray.Length - 1; i++)
            { 
                Console.WriteLine(numsArray[i]);
            }
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Результат:                                                               *");
            Console.WriteLine("****************************************************************************");
            int res = ds.GetSumEvenArrEl(numsArray);
            Console.WriteLine("Сумма чётных чисел: " + res);
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
