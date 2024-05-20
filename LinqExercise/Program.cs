using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //DONE: Print the Sum of numbers
            var sumOfNumbers = numbers.Sum();
            Console.WriteLine("Sum:");
            Console.WriteLine(sumOfNumbers);
            Console.WriteLine();

            //DONE: Print the Average of numbers
            var averageOfNumbers = numbers.Average();
            Console.WriteLine("Average:");
            Console.WriteLine(averageOfNumbers);
            Console.WriteLine();

            //DONE: Order numbers in ascending order and print to the console
            var numbersAscending = numbers.OrderBy(number => number).ToArray();
            Console.WriteLine("Ascending Order:");
            foreach (int number in numbersAscending)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            //DONE: Order numbers in descending order and print to the console
            var numbersDescending = numbers.OrderByDescending(number => number).ToArray();
            Console.WriteLine("Descending Order:");
            foreach (int number in numbersDescending)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            //DONE: Print to the console only the numbers greater than 6
            Console.WriteLine("Numbers Above Six:");
            var numbersAboveSix = numbers.Where(number => number > 6).ToArray();
            foreach (int num in  numbersAboveSix)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            //DONE: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("Only Four:");
            var onlyFour = numbers.OrderByDescending(number => number).Take(4).ToArray();
            foreach (int num in onlyFour)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            //DONE: Change the value at index 4 to your age, then print the numbers in descending order
            Console.WriteLine("Insert Your Age At Index Four and Ten Order By Descending:");
            numbers[4] = 29;
            numbers = numbers.OrderByDescending(numbers => numbers).ToArray();
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //DONE: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            Console.WriteLine("Employees Who's Name Starts With C or S:");
            var startsWithCOrS = employees.Where(employee => employee.FirstName.StartsWith("C") || employee.FirstName.StartsWith("S")).OrderBy(employee => employee.FirstName).ToList();
            foreach (var employee in startsWithCOrS)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }
            Console.WriteLine();

            //DONE: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            Console.WriteLine("Employees Who's Age is Over 26:");
            var overTwentySixSorted = employees.Where(employee => employee.Age > 26).OrderBy(employee => employee.Age).ThenBy(employee => employee.FirstName).ToArray();
            foreach (var employee in  overTwentySixSorted)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} - {employee.Age}");
            }
            Console.WriteLine();

            //DONE: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            Console.WriteLine("Sum of Experience:");
            var sumOfExperience = employees.Where(employee => employee.YearsOfExperience <= 10 && employee.Age > 35).Sum(employee => employee.YearsOfExperience);
            Console.WriteLine(sumOfExperience.ToString());
            Console.WriteLine();

            //DONE: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            Console.WriteLine("Average of Experience:");
            var avgOfExperience = employees.Where(employee => employee.YearsOfExperience <= 10 && employee.Age > 35).Average(employee => employee.YearsOfExperience);
            Console.WriteLine(avgOfExperience.ToString());
            Console.WriteLine();

            //DONE: Add an employee to the end of the list without using employees.Add()
            employees.Append(new Employee("Kazuma", "Kuwabara", 18, 1));

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
