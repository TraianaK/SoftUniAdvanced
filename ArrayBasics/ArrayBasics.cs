using System;
using System.Collections.Generic;
using System.Linq;

class ArrayBasics
{
    static void Main()
    {
        //Basics();
        //Symetric();
        //Iteration();
        //IterationWithLoops();
        //TryingWithList();
        //FindingAverageInList();
    }

    private static void FindingAverageInList()
    {
        List<int> numbers = new List<int>();

        for (int i = 0; i < 10; i++)
        {
            numbers.Add(i);
        }

        Console.WriteLine(numbers.Average());
    }

    private static void TryingWithList()
    {
        List<int> numbers = new List<int>();

        for (int i = 0; i < 10; i++)
        {
            numbers.Add(i);
        }

        numbers[0] = 5;

        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }
    }

    private static void IterationWithLoops()
    {
        int[] array = new int[] { 1, 2, 3, 4, 5 };

        Console.WriteLine("Output : ");
        for (int i =0; i<array.Length; i++)
        {
            //Doubling the number :
            array[i] = 2 * array[i];
            Console.WriteLine(array[i] + "");
        }
    }

    private static void Iteration()
    {
        string[] array = { "one", "two", "three", "four" };
        for (int index = 0; index < array.Length; index++)
        {
            Console.WriteLine("Element [{0}] = {1}", index, array[index]);
        }
        
    }

    private static void Symetric()
    {
        Console.WriteLine("Enter a number : ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        Console.WriteLine("Enter values of the array : ");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        bool symetric = true;
        for (int i = 0; i < array.Length / 2; i++)
        {
            if (array[i] != array[n - i - 1])
            {
                symetric = false;
            }
        }
        Console.WriteLine("Is symetric - {0} ?", symetric);
    }

    private static void Basics()
    {
        int[] arr = new int[5];
        arr[0] = 100;
        for (int i = 1; i < arr.Length; i++)
        {
            arr[i] = arr[i - 1] * 2;
        }
        foreach (var i in arr)
        {
            Console.WriteLine(i);
        }
    }
}

