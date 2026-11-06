using Tyuiu.SmirnovaYV.Sprint4.Task2.V2.Lib;
namespace Tyuiu.SmirnovaYV.Sprint4.Task2.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();
            Console.Title = "Спринт #4| Выполнила: Смирнова Ю.В.| АСОиУБ-26-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт#4                                                                 *");
            Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                     *");
            Console.WriteLine("* Задание #2                                                               *");
            Console.WriteLine("* Вариант #2                                                               *");
            Console.WriteLine("* Выполнила: Смирнова Юлия Валерьевна | АСОиУБ-26-1                        *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 11 элементов заполненный          *");
            Console.WriteLine("* лучайными в диапазоне от 1 до 8 подсчитать произведение                  *");
            Console.WriteLine("* нечетных элементов массива.                                              *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            int len;
            Console.WriteLine("Введите количество элементов массива:");
            len = Convert.ToInt32(Console.ReadLine());
            int[] numsArry = new int[len];
            for (int i =0; i<=len-1;i++)
            {
                numsArry[i] = rnd.Next(1, 8);
            }
            Console.WriteLine("Массив: ");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write(numsArry[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Результат:                                                               *");
            Console.WriteLine("****************************************************************************");
            int res = ds.Calculate(numsArry);
            Console.WriteLine(res);
        }
    }
}
