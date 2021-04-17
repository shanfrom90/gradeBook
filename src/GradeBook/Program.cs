using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //arrays need to have a specified size, this is why data structures like list is a good option
            double [] arrayGrades = new [] {12.7, 34.1, 38.6};

             //lists are dynamic
            List<double> grades = new List<double>();
            grades.Add(56.1);
             
            var result = 0.0;
            foreach(double grade in grades){
                result += grade;
            }

            result /= grades.Count;
            System.Console.WriteLine($"The average grade is: {result:N2}");
            if(args.Length > 0){

                Console.WriteLine($"Hello, {args[0]}!");
            }
            else{
                System.Console.WriteLine("Hello!");
            }
        }
    }
}
