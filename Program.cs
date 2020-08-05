using System;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть довжину масива");
            Random rand = new Random();
            int length = int.Parse(Console.ReadLine());
            int[] mass = new int[length];
            int kilk = 0;
            int sum = 0;
            Console.Write("Невідсортований масив: ");
            for (int i = 0; i < length; i++)
            {
                mass[i] = rand.Next(0, 100);
                Console.Write(mass[i] + " ");
                if (mass[i] % 5 == 0)
                {
                    kilk++;
                    sum += mass[i];
                }
            }
            Console.WriteLine("\nКількість елементів масиву, які діляться на 5 без остачі = {0}, сума = {1} ", kilk, sum);
            Console.WriteLine("\nВідсортований масив: {0}", string.Join(", ", InsertionSort(mass)));
            Console.ReadKey();
        }

        static void Swap(ref int FirstNum, ref int SecondNum)
        {
            var temp = FirstNum;
            FirstNum = SecondNum;
            SecondNum = temp;
        }

        static int[] InsertionSort(int[] mass)
        {
            for (int i = 1; i < mass.Length; i++)
            {
                var key = mass[i];
                var j = i;
                while ((j > 0) && (mass[j - 1] > key))
                {
                    Swap(ref mass[j - 1], ref mass[j]);
                    j--;
                }

                mass[j] = key;
            }

            return mass;
        }
        
    }
}
