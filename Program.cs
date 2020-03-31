using System;

namespace HomeWork31._03
{
    class Program
    {
        //Заполняет массив рандомными числами от 0 до 1000
        static void ZapolnenieMassiva (int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(1000);
            }
        }
        //Вывод массив в консоль
        static void VivodMassiva (int[] array)
        {
            foreach(int el in array)
            {
                System.Console.Write(el + " ");
            }
        }
        //Запись массива в обратном порядке
        static int[] PreobrazovanieMassiva (int[] array)
        {
            int[] array2 = new int[array.Length];
            int k = array.Length-1;
            foreach(int el in array)
            {
                array2[k] = el;
                k--;
            }
            return array2;
        }
        static void Main(string[] args)
        {
            //Задание 1
            Console.Write("Введите размер массива: ");
            int count = int.Parse(Console.ReadLine());
            int[] array = new int[count];
            ZapolnenieMassiva(array);
            int min_ = array[0];
            int max_ = array[0];
            double summaAndSredneArifmeticheskiy = 0;
            VivodMassiva(array);
            System.Console.WriteLine("\nВсе нечетные значения массива: ");
            foreach(int el in array)
            {
                min_ = (el < min_)?el:min_;
                max_ = (el >max_)?el:max_;
                summaAndSredneArifmeticheskiy += el;
                System.Console.Write((el%2==1)?el + " ":"");
            }
            System.Console.WriteLine($"\nНаименьшее значение массива: {min_}");
            System.Console.WriteLine($"Наибольшее значение массива: {max_}");
            System.Console.WriteLine($"Общая сумма всех элементов: {summaAndSredneArifmeticheskiy}");
            System.Console.WriteLine($"Среднее арифметическое всех элементов: {Math.Round(summaAndSredneArifmeticheskiy/array.Length,1)}");
            System.Console.WriteLine();
            //Задание 2
            System.Console.WriteLine("Запись заданного массива в обратном порядке.");
            VivodMassiva(PreobrazovanieMassiva(array));
            //Задание 3
            System.Console.WriteLine("\n");
            System.Console.WriteLine("Заданный массив:");
            VivodMassiva(array);
            System.Console.WriteLine();
            System.Console.Write("Введите количество элементов: ");
            count = int.Parse(Console.ReadLine());
            System.Console.Write("Введите индекс: ");
            int index_ = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Новый массив:");
            int[] arr = new int[count];
            if((array.Length - index_) >= count)
            {
                for(int i = 0; i < count;i++)
                {
                    arr[i] = array[index_];
                    index_++;
                }
                VivodMassiva(arr);
            }
            else {
                for(int i = 0; i < count; i++)
                {
                    if(index_<array.Length)
                    {
                        arr[i] = array[index_];
                        index_++;
                    }
                    else {
                        arr[i] = 1;
                    }
                }
                VivodMassiva(arr);
            }
            Console.ReadKey();
        }
    }
}
