using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pre.Cu.LINQ.Console.Exercises.Interfaces;

namespace Pre.Cu.LINQ.Console.Exercises
{
    public class ExerciseA: IExercise
    {
        public void Run()
        {
            List<int> numbers = new List<int> { 20, 35, 17, 105, 90 };
            // TODO 1. Getallen deelbaar door 5

            // TODO 2. grootste getal

            // TODO 3. voorlaatste getal


            List<string> games = new List<string> { "Dominion", "Manillen", "Schaken", "Kolonisten van Catan", "Cluedo" };

            // TODO 4. Uit hoeveel letters bestaan alle spellen samen (spaties niet meetellen)?

            // TODO 5. koppel de nummers aan de spellen: nummer is prijs van spel op dezelfde positie

            System.Console.WriteLine("Hallo Oefening 1");
        }
    }
}
