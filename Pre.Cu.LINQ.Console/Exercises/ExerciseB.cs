using Pre.Cu.LINQ.Console.Exercises.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre.Cu.LINQ.Console.Exercises
{
    internal class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
    }
    public class ExerciseB : IExercise
    {
        public void Run()
        {
            var students = new List<Student>
            {
                new Student { Id = 1, FirstName = "Freddie", LastName = "Fish", Age = 18, Sex = "M" },
                new Student { Id = 2, FirstName = "Bill", LastName = "Jones", Age = 21, Sex = "M" },
                new Student { Id = 3, FirstName = "Kitty", LastName = "Cat", Age = 19, Sex = "F" },
                new Student { Id = 4, FirstName = "Suzy", LastName = "Wan", Age = 20, Sex = "F" }
            };

            // TODO 1. Studenten waarbij voor en familienaam start met dezelfde letter

            // TODO 2. Gemiddelde leeftijd van de vrouwelijke studenten

            // TODO 3. Student met grootste code gevormd door id^2 + 5, toon ook de code
        }


    }
}
