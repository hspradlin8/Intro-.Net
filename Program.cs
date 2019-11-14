using System;
// importing System and all its properties it has from every file. 

namespace Intro
{
    class Program
    {
        //  any method you create needs to be specified on what you return.
        //  Void does not return anything. 
        // Main is defined and never invoked- dotnet does that- 
        // automatically and internally invokes the method.
        static void Main(string[] args)
        {
            string name = "Adam";
            int cohort = 34;
            int theBestCohort = 35;

            // reassigning varibales

            name = "Jisie";
            cohort = 35;

            // string concatenation
            string greeting = "Hello " + name + ". Welcome to cohort " + cohort;

            // String interpolation

            string greeting2 = $"Hello {name}. Welcome to cohort {cohort}";

            // declare boolean variables

            bool isTheBest = cohort == theBestCohort;
            // conditionals
            if (isTheBest)
            {
                Console.WriteLine("Ah, the best around");
            }
            else if (name == "Jisie")
            {
                Console.WriteLine("Well, not in the right cohort. But she's pretty cool.");
            }
            else
            {
                Console.WriteLine("You may... want to rethink your decisions");
            }

            // Loops 
            // For Loops
            int[] cohorts = new int[] { 34, 35, 36, 37 };

            for (int i = 0; i < cohorts.Length; i++)
            {
                Console.WriteLine($"Cohort {cohorts[i]}");
            }

            // ForEach Loops

            foreach (int item in cohorts)
            {
                Console.WriteLine($"Cohort {item}");
            }

            // While Loops 

            while (cohort > 0)
            {
                cohort--;
                Console.WriteLine(cohort);
            }

            //  Console.WriteLine(greeting2);
        }
    }
}