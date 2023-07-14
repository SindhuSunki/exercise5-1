using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int noe, nwd;
            Console.Write("Enter the number of employees: ");
            noe = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of working days for each employee: ");
             nwd = int.Parse(Console.ReadLine());

            int[][] salaries = new int[noe][];

            for (int i = 0; i < noe; i++)
            {
                salaries[i] = new int[nwd];

                Console.WriteLine($"Enter salaries for employee {i + 1}:");
                for (int j = 0; j < nwd; j++)
                {
                    Console.Write($"Day{j + 1}: ");
                    salaries[i][j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nWeekly salary calculation:");
            Console.WriteLine("=======================");
            for (int i = 0; i < noe; i++)
            {
                int totalSalary = 0;

                Console.WriteLine($"Employee {i + 1}:");
                for (int j = 0; j < nwd; j++)
                {
                    Console.WriteLine($"Day{j + 1}: {salaries[i][j]}");
                    totalSalary += salaries[i][j];
                }
                Console.WriteLine($"Total Salary: {totalSalary}");
                Console.WriteLine("=======================");
            }

            Console.ReadLine();
        }
    }
}
    

