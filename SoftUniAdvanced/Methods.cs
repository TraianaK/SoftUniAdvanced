using System;

class Methods
{
    static void PrintHyphens(int count)
    {
        Console.WriteLine(
            new string('-', count));
    }
    static void Main()
    {
        for ( int i=0; i<=10; i++)
        {
            PrintHyphens(i);
        }
        
    }
}

