using System;

namespace ClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car();
            car1.Make = " Honda";
            car1.Model = "Accord";
            car1.Year = "2003";
            Console.WriteLine($"My {car1.Year} {car1.Make} {car1.Model} is on its last legs.");
        }
    }
}
