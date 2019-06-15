﻿using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {  
            
            var book = new Book("Robert's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);

            
            var grades = new List<double>() {12.7, 10.3, 6.11, 4.1};
            grades.Add(56.1);
            
            var result = 0.0;
            var highGrade = double.MinValue;
            foreach(var number in grades)
            {
                highGrade = Math.Max(number, highGrade);
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"The average grade is, {result:N1}");   
        }
    }
}
