using System;
using System.Collections.Generic;

class HashTables
{
    static Dictionary<string, List<int>> marks = new Dictionary<string, List<int>>();

    static void Main()
    {
        AddMark("Pesho", 4);
        AddMark("Pesho", 5);
        AddMark("Pesho", 4);
        AddMark("Pesho", 3);

        AddMark("Kiro", 6);
        AddMark("Kiro", 5);
        AddMark("Kiro", 4);

        foreach (var studentAndMarks in marks)
        {
            Console.WriteLine(studentAndMarks.Key + " : ");
            foreach (var mark in studentAndMarks.Value)
            {
                Console.Write(mark + " " );
            }

            Console.WriteLine();

        }
    }

    static void AddMark(string studentName, int mark)
    {
        List<int> studentMarks;
        if (marks.ContainsKey(studentName))
        {
            studentMarks = marks[studentName];

        }
        else
        {
            studentMarks = new List<int>();
            marks[studentName] = studentMarks;
        }

        studentMarks.Add(mark);
    }
}

