using System;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void FillRand(int[] arr, int left = 0, int right = 100) //copy of REFERENCE(array is refernce type)
        {
            Random rnd = new Random(); //srand(base)
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(left, right + 1);
            }
        }
        static void PrintArray(int[] arr,string line = "")
        {
            Console.WriteLine(line);
            foreach (var item in arr) //var = auto(C++)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //int[] arr = null;
            //Console.Write("Enter array size: ");
            //int size;
            //while(!int.TryParse(Console.ReadLine(),out size))
            //{
            //    Console.WriteLine("Value error. Try again!");
            //}
            //arr = new int[size];
            //FillRand(arr, 1, 101);
            //PrintArray(arr, "Array: ");
            //// Array.Clear(arr, 0, arr.Length / 2);
            ////PrintArray(arr, "\nAfter clear: ");

            //int[] arr2 = new int[arr.Length * 2];
            ////arr.CopyTo(arr2, 2);
            //Array.Copy(arr, 1, arr2, 4, 5); //from arr 5 elements into arr2 in 4 position
            //PrintArray(arr2, "Array 2:");

            //Console.WriteLine("Enter value for search: ");
            //int value = int.Parse(Console.ReadLine());
            //int index = Array.IndexOf(arr, value);
            //if(index!=-1)
            //    Console.WriteLine("Index: "+index);
            //else
            //    Console.WriteLine("Not found");

            //int limit = 30;
            //index = Array.FindIndex(arr, (int e) => { return e > limit; });
            //Console.WriteLine($"Index of first number bigger then {limit} in arr: {index}");

            //index = Array.FindIndex(arr,  e => e % 2 == 0);
            //Console.WriteLine($"Index of first diviable number in arr: {index}");
            //Array.Resize(ref arr, size+1);
            //arr[arr.Length - 1] = 111;
            //PrintArray(arr, "After resize: ");

            //Array.Sort(arr);
            //PrintArray(arr, "After sort: ");

            //Array.Sort(arr,(x,y)=>-x.CompareTo(y));
            //PrintArray(arr, "After sort: ");

            //string[] products = { "apple", "milk", "jogurt", "bread" };
            //double[] prices = { 20, 22.4, 28.9, 15.5 };
            //Array.Sort(prices, products);
            //for(int i = 0; i<prices.Length;++i)
            //{
            //    Console.WriteLine($"{products[i], 10} {prices[i], 10}");
            //}




            //prakt
            //------------ - Одновимірні масиви C #---------------------------------------------
            //7.Перерозташувати елементи у масиві(відємні, потім невідємні) у порядку їх слідування. 
            //Для масиву : 2  1 - 4 - 55 - 7 100 10
            //Повинні отримати змінений масив: -4 - 55 - 7  2 1 100 10
            //Використати FindAll(), CopyTo().

            //8.Вводиться число.Масив заповнити випадковими числами. Знайти кількість входжень у масив введеного числа.
            //Скористатися Count() з System.Linq

            //9.Визначити суму елементів, розміщених між максимальним та мінімальним елементом масиву.
            //Користуватися методами(Max, Min, IndexOf)

            //10.Створити 2 паралельних масиви: назви та ціни тoварів. Впорядкувати масиви по зростанню ціни(Sort(keys, values)).


            int[] mass = { 2 , 1 ,- 4 ,- 55 ,- 7, 100 ,10 };

            int[] temp = Array.FindAll(mass, e => e < 0);
            int[] temp2 = Array.FindAll(mass, e => e > 0);
            temp.CopyTo(mass, 0);
            temp2.CopyTo(mass, temp.Length);
            PrintArray(mass, "Seven: ");

            Array.Resize(ref mass, 15);
            Console.Write("\nEight\nEnter number: ");
            int num = int.Parse(Console.ReadLine());
            FillRand(mass, num - 20, num + 21);
            PrintArray(mass, "Array: ");

            int count = mass.Count(x=>x==num);
            Console.WriteLine("Count: " + count);

            int max = mass.Max();
            int min = mass.Min();
            int indMax = Array.IndexOf(mass, max);
            int indMin = Array.IndexOf(mass, min);
            int sum = 0;

            Console.Write("\nNinth: ");
            if (indMin< indMax)
            {
                for (int i = indMin; i <= indMax; ++i)
                {
                    sum += mass[i];
                }
            }
            else if (indMin > indMax)
            {
                for (int i = indMax; i <= indMin; ++i)
                {
                    sum += mass[i];
                }
            }
            else
                sum += mass[indMax];
            Console.WriteLine($"Sum: {sum}");




        }
    }
}
