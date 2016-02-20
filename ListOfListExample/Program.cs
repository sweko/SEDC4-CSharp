using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades1 = new List<int> { 7, 7, 8, 9, 10 };
            var grades2 = new List<int> { 7, 6, 9, 6, 5 };
            var grades3 = new List<int> { 7, 10, 8, 5, 10 };

            var allGrades = new List<List<int>>();
            allGrades.Add(grades1);
            allGrades.Add(grades2);
            allGrades.Add(grades3);

            for (int i = 0; i < allGrades.Count; i++)
            {
                var grades = allGrades[i];
                for (int j = 0; j < grades.Count; j++)
                {
                    Console.Write($"{grades[j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------");
            foreach (var grades in allGrades)
            {
                foreach (var grade in grades)
                {
                    Console.Write($"{grade} ");
                }
                Console.WriteLine();
            }

        }


    }
}
