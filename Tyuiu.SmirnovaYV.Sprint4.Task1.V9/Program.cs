using Tyuiu.SmirnovaYV.Sprint4.Task1.V9.Lib;
namespace Tyuiu.SmirnovaYV.Sprint4.Task1.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4| Выполнила: Смирнова Ю.В.| АСОиУБ-26-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт#4                                                                 *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод c клавиатуры)                             *");
            Console.WriteLine("* Задание #1                                                               *");
            Console.WriteLine("* Вариант #9                                                               *");
            Console.WriteLine("* Выполнила: Смирнова Юлия Валерьевна | АСОиУБ-26-1                        *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 13 элементов заполненный          *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 3 до 8                            *");
            Console.WriteLine("* подсчитать произведение четных элементов массива.                        *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            int len;
            Console.WriteLine("Введите количество элементов массива:");
            len =Convert.ToInt32(Console.ReadLine());
            int[] numsArry=new int[len];
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("Введите значение " + i + " элемента массива:");
                numsArry[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Массив: ");
            for (int i=0; i<=len-1; i++)
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
