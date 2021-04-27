using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            IBook book = new DiskBook ("Shannon's Grade Book");

            book.GradeAdded += OnGradeAdded;

            EnterGrades(book);

            var stats = book.GetStatistics();

            System.Console.WriteLine($"For the book named {book.Name}");
            System.Console.WriteLine($"The average grade is: {stats.Average:N2}");
            System.Console.WriteLine($"The lowest grade is: {stats.Low}");
            System.Console.WriteLine($"The highest grade is: {stats.High}");
            System.Console.WriteLine($"The letter is: {stats.Letter}");


            //arrays need to have a specified size, this is why data structures like list is a good option
            // double [] arrayGrades = new [] {12.7, 34.1, 38.6};

            //lists are dynamic
            // List<double> grades = new List<double>(){12.7, 34.1, 38.6};
            // grades.Add(56.1);



        }


        //it may be an in memory book, but it might be another type of book(the base clases)
        private static void EnterGrades(IBook book)
        {
    
            while (true)
            {
                System.Console.WriteLine("Please enter a grade to add or enter 'q' to quit");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);

                }
                catch (ArgumentException ex)
                {
                    System.Console.WriteLine(ex.Message);

                }
                catch (FormatException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
                finally
                {
                    System.Console.WriteLine("**");
                }

            }
        }

        static void OnGradeAdded(object sender, EventArgs e){
            System.Console.WriteLine("A grade was added.");
        }
    }
}
