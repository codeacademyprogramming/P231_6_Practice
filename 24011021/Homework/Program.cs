using System;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;

            AddTen(ref num);

            Console.WriteLine(num);

            var str = "Sabahin xeyir Baki. Baki gozel seherdir. Bakiya gelin";

            var arr = str.Split(' ');
           var newStr = string.Join('+', arr);
            Console.WriteLine(newStr);


            str.Substring(str.LastIndexOf(' ')+1);
            str.Substring(9, str.LastIndexOf(' ') - 9);

            str.EndsWith("Baki");

            str.ToLower().Contains("sabah");

            var numbers = new int[] { 34, 45, 1, 43, 23 };

            Add(ref numbers, 5);
            Add(ref numbers, 15);
            Add(ref numbers, 25);

            Array.Resize(ref numbers, 3);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }




        }

        static void Resize(ref int[] arr,int newSize)
        {
            int[] newArr = new int[newSize];

            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }

            arr=newArr;
        }

        static void Add(ref int[] numbers,int num)
        {
            int[] newArr = new int[numbers.Length + 1];

            for (int i = 0; i < numbers.Length; i++)
            {
                newArr[i] = numbers[i];
            }

            newArr[newArr.Length - 1] = num;

            numbers = newArr;
        }

        static void AddTen(ref int number)
        {
            number = number + 10;
        }

    }
}
