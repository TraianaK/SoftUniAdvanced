using System;
using System.Linq;
using System.Collections.Generic;


class Functions
{
    static void Main()
    {
        // SomeFunctions();
        //Names();
        //Matrice();
        //UsingList();
        //ListNames();


        Console.WriteLine();
    }

    private static void ListNames()
    {
        List<string> names = new List<string>()
        {
            "Pesho" , "Milena" ,
            "Juja", "Kiril",
        };

        names.Add("Teodor");
        names.RemoveAt(0);
        names.Insert(3, "Mihail");
        names[1] = "Razvigor";

        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }

    private static void UsingList()
    {
        List<List<int>> nums = new List<List<int>>()
        {
            new List<int>() {5,16,18,-90},
            new List<int>() {2,10},
            new List<int>() {256,14,3}
        };

        foreach (var num in nums)
        {
            Console.WriteLine(num.Average());
        }
    }

    private static void SomeFunctions()
    {
        int[] numbers = new int[10];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i + 1;
        }

        numbers[3] = 20;
        numbers[5] = numbers[2] + numbers[7];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("numbers[{0}] = {1}", i, numbers[i]);
        }

        Console.WriteLine();

        Console.WriteLine("Sum = " + numbers.Sum());
        Console.WriteLine("Min = " + numbers.Min());
        Console.WriteLine("Max = " + numbers.Max());
        Console.WriteLine("First = " + numbers.First());
        Console.WriteLine("Last = " + numbers.Last());

        Array.Sort(numbers);

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("numbers[{0}] = {1}", i, numbers[i]);
        }

    }

    private static void Names()
    {
        string[] names = { "Radka", "Milena", "Kiril", "Teodor" };

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        var result = names.Reverse();
        Console.WriteLine();

        names[0] = names[0] + "(junior)";

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }

    private static void Matrice()
    {
        int width = 4;
        int height = 6;
        string[,] matrix = new string[height, width];

        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                matrix[row, col] =
                    "" + (char)('a' + row) + (char)('a' + col);
            }
            Console.WriteLine();
        }
    }


}



