using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book("Shannon's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            var stats = book.GetStatistics();

            System.Console.WriteLine($"The average grade is: {stats.Average:N2}");
            System.Console.WriteLine($"The lowest grade is: {stats.Low}");
            System.Console.WriteLine($"The highest grade is: {stats.High}");   


            //arrays need to have a specified size, this is why data structures like list is a good option
            // double [] arrayGrades = new [] {12.7, 34.1, 38.6};

             //lists are dynamic
            // List<double> grades = new List<double>(){12.7, 34.1, 38.6};
            // grades.Add(56.1);
             
           
             
        }
    }
}
