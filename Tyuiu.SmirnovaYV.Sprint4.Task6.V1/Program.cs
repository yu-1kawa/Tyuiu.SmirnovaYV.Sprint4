using Tyuiu.SmirnovaYV.Sprint4.Task6.V1.Lib;
namespace Tyuiu.SmirnovaYV.Sprint4.Task6.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();
            Console.Title = "Спринт #4| Выполнила: Смирнова Ю.В.| АСОиУБ-26-1";
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                         *");
            Console.WriteLine("* Тема: Класс Array                                                                 *");
            Console.WriteLine("* Задание #6                                                                        *");
            Console.WriteLine("* Вариант #1                                                                        *");
            Console.WriteLine("* Выполнила: Смирнова Юлия Валерьевна | АСОиУБ-26-1                                 *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Дан строковый массив данных                                                       *");
            Console.WriteLine("* [\"Яблоко\",\"Банан\",\"Вишня\",\"Драгонфрут\",\"Бузина\",\"Инжир\",\"Виноград\"] *");
            Console.WriteLine("* используя класс Array подсчитайте количество элементов, длина которых больше 6.   *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");
            var frut = new string[] { "Яблко", "Банан", "Вишня", "Драгонфрут", "Бузина", "Инжир", "Виноград" };
            Console.WriteLine("Исходный массив: ");
            for (int i=0; i<=frut.Length-1;i++)
            {
                Console.WriteLine(frut[i]);
            }
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Результат:                                                                        *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("Количество элементов длина которых больше 6: ");
            int nums = ds.Calculate(frut);
            Console.WriteLine(nums);
            Console.ReadKey();
        }
    }
}
