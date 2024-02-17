using Microsoft.Data.Analysis;
using Pre.Cu.LINQ.Console.Exercises.Interfaces;
using Pre.Cu.LINQ.Console.Exercises.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static PandasNet.PandasApi;

namespace Pre.Cu.LINQ.Console.Exercises
{
    public class ExerciseD : IExercise
    {
        List<Product> products;
        List<Customer> customers;
        List<Employee> employees;
        public void Run()
        {
            /* TODO 1. Toon de productnamen waarvan we minder dan 20 UnitsInStock tellen, toon ook de bijbehorende categorienaam */

            /* TODO 2. Toon de namen van de klanten waar in de ContactTitle het woord "sales" (hoofdletterongevoelig) voorkomt en die afkomstig zijn uit UK */

            /* TODO 3. Toon de namen van de klanten waar in de ContactTitle het woord "sales" (hoofdletterongevoelig) voorkomt en die afkomstig zijn uit
                   UK, Germany of Brazil*/

            /* TODO	4. Geef voor elke werknemer die een overste heeft (reportsto is ingevuld)
                de voornaam en familienaam weer alsook hoeveel orders ze hebben behandeld in het meest recente jaar */

            /*  TODO 5. Toon de eerste letter en het aantal ProductNames dat met deze letter begint.
                We zien enkel de letters waarvoor er meer dan 2 producten zijn. */
        }

        public ExerciseD()
        {
            
            List<Category> categories = new List<Category>()
            {
                new Category(1, "Beverages", "Soft drinks, coffees, teas, beers, and ales"),
                new Category(2, "Condiments", "Sweet and savory sauces, relishes, spreads, and seasonings"),
                new Category(3, "Confections", "Desserts, candies, and sweet breads"),
                new Category(4, "Dairy Products", "Cheeses"),
                new Category(5, "Grains/Cereals", "Breads, crackers, pasta, and cereal"),
                new Category(6, "Meat/Poultry", "Prepared meats"),
                new Category(7, "Produce", "Dried fruit and bean curd"),
                new Category(8, "Seafood", "Seaweed and fish")
            };

            employees = new List<Employee>()
            {
                new Employee(1, "Davolio", "Nancy", "Sales Representative", "Ms.", DateTime.Parse("Dec  8 1948 12:00AM"),
                    DateTime.Parse("May  1 1992 12:00AM"),
                    new Address("507 - 20th Ave. E. Apt. 2A", "Seattle", "WA", "98122", "USA"), "(206) 555-9857", "5467",
                    "2",
                    "Education includes a BA in psychology from Colorado State University in 1970.She also completed " +
                    "'The Art of the Cold Call' Nancy is a member of Toastmasters International."),
                new Employee(2, "Fuller", "Andrew", "Vice President, Sales", "Dr.", DateTime.Parse("Feb 19 1952 12:00AM"),
                    DateTime.Parse("Aug 14 1992 12:00AM"),
                    new Address("908 W. Capital Way", "Tacoma", "WA", "98401", "USA"), "(206) 555-9482", "3457", "",
                    "Andrew received his BTS commercial in 1974 and a Ph.D. in international marketing from the University of Dallas in 1981. " +
                    " He is fluent in French and Italian and reads German.  He joined the company as a sales representative, was promoted to sales manager " +
                    "in January 1992 and to vice president of sales in March 1993.  Andrew is a member of the Sales Management Roundtable, the Seattle Chamber " +
                    "of Commerce, and the Pacific Rim Importers Association."),
                new Employee(3, "Leverling", "Janet", "Sales Representative", "Ms.", DateTime.Parse("Aug 30 1963 12:00AM"),
                    DateTime.Parse("Apr  1 1992 12:00AM"),
                    new Address("722 Moss Bay Blvd.", "Kirkland", "WA", "98033", "USA"), "(206) 555-3412", "3355", "2",
                    "Janet has a BS degree in chemistry from Boston College (1984).  She has also completed a certificate program in food retailing management.  Janet was hired as a sales associate in 1991 and promoted to sales representative in February 1992."),
                new Employee(4, "Peacock", "Margaret", "Sales Representative", "Mrs.",
                    DateTime.Parse("Sep 19 1937 12:00AM"), DateTime.Parse("May  3 1993 12:00AM"),
                    new Address("4110 Old Redmond Rd.", "Redmond", "WA", "98052", "USA"), "(206) 555-8122", "5176", "2",
                    "Margaret holds a BA in English literature from Concordia College (1958) and an MA from the American Institute of Culinary Arts (1966).  She was assigned to the London office temporarily from July through November 1992."),
                new Employee(5, "Buchanan", "Steven", "Sales Manager", "Mr.", DateTime.Parse("Mar  4 1955 12:00AM"),
                    DateTime.Parse("Oct 17 1993 12:00AM"), new Address("14 Garrett Hill", "London", "", "SW1 8JR", "UK"),
                    "(71) 555-4848", "3453", "2",
                    "Steven Buchanan graduated from St. Andrews University, Scotland, with a BSC degree in 1976.  Upon joining the company as a sales representative in 1992, he spent 6 months in an orientation program at the Seattle office and then returned to his permanent post in London.  He was promoted to sales manager in March 1993.  Mr. Buchanan has completed the courses \"Successful Telemarketing\" and \"International Sales Management.\"  He is fluent in French."),
                new Employee(6, "Suyama", "Michael", "Sales Representative", "Mr.", DateTime.Parse("Jul  2 1963 12:00AM"),
                    DateTime.Parse("Oct 17 1993 12:00AM"),
                    new Address("Coventry House Miner Rd.", "London", "", "EC2 7JR", "UK"), "(71) 555-7773", "428", "5",
                    "Michael is a graduate of Sussex University (MA, economics, 1983) and the University of California at Los Angeles (MBA, marketing, 1986).  He has also taken the courses \"Multi-Cultural Selling\" and \"Time Management for the Sales Professional.\"  He is fluent in Japanese and can read and write French, Portuguese, and Spanish."),
                new Employee(7, "King", "Robert", "Sales Representative", "Mr.", DateTime.Parse("May 29 1960 12:00AM"),
                    DateTime.Parse("Jan  2 1994 12:00AM"),
                    new Address("Edgeham Hollow Winchester Way", "London", "", "RG1 9SP", "UK"), "(71) 555-5598", "465",
                    "5",
                    "Robert King served in the Peace Corps and traveled extensively before completing his degree in English at the University of Michigan in 1992, the year he joined the company.  After completing a course entitled \"Selling in Europe,\" he was transferred to the London office in March 1993."),
                new Employee(8, "Callahan", "Laura", "Inside Sales Coordinator", "Ms.",
                    DateTime.Parse("Jan  9 1958 12:00AM"), DateTime.Parse("Mar  5 1994 12:00AM"),
                    new Address("4726 - 11th Ave. N.E.", "Seattle", "WA", "98105", "USA"), "(206) 555-1189", "2344", "2",
                    "Laura received a BA in psychology from the University of Washington.  She has also completed a course in business French.  She reads and writes French."),
                new Employee(9, "Dodsworth", "Anne", "Sales Representative", "Ms.", DateTime.Parse("Jan 27 1966 12:00AM"),
                    DateTime.Parse("Nov 15 1994 12:00AM"), new Address("7 Houndstooth Rd.", "London", "", "WG2 7LT", "UK"),
                    "(71) 555-4444", "452", "5",
                    "Anne has a BA degree in English from St. Lawrence College.  She is fluent in French and German."),
            };

            customers = new List<Customer>()
            {
                new Customer("ALFKI",
                    "Alfreds Futterkiste",
                    "030-0074321",
                    "030-0076545",
                    new Contact("Maria Anders", "Sales Representative"),
                    new Address("Obere Str. 57", "Berlin", "", "12209", "Germany")),

                new Customer("ANATR", "Ana Trujillo Emparedados y helados", "(5) 555-4729", "(5) 555-3745",
                    new Contact("Ana Trujillo", "Owner"),
                    new Address("Avda. de la Constitución 2222", "México D.F.", "", "05021", "Mexico")),
                new Customer("ANTON", "Antonio Moreno Taquería", "(5) 555-3932", "", new Contact("Antonio Moreno", "Owner"),
                    new Address("Mataderos  2312", "México D.F.", "", "05023", "Mexico")),
                new Customer("AROUT", "Around the Horn", "(171) 555-7788", "(171) 555-6750",
                    new Contact("Thomas Hardy", "Sales Representative"),
                    new Address("120 Hanover Sq.", "London", "", "WA1 1DP", "UK")),
                new Customer("BERGS", "Berglunds snabbköp", "0921-12 34 65", "0921-12 34 67",
                    new Contact("Christina Berglund", "Order Administrator"),
                    new Address("Berguvsvägen  8", "Luleå", "", "S-958 22", "Sweden")),
                new Customer("BLAUS", "Blauer See Delikatessen", "0621-08460", "0621-08924",
                    new Contact("Hanna Moos", "Sales Representative"),
                    new Address("Forsterstr. 57", "Mannheim", "", "68306", "Germany")),
                new Customer("BLONP", "Blondesddsl père et fils", "88.60.15.31", "88.60.15.32",
                    new Contact("Frédérique Citeaux", "Marketing Manager"),
                    new Address("24, place Kléber", "Strasbourg", "", "67000", "France")),
                new Customer("BOLID", "Bólido Comidas preparadas", "(91) 555 22 82", "(91) 555 91 99",
                    new Contact("Martín Sommer", "Owner"), new Address("C/ Araquil, 67", "Madrid", "", "28023", "Spain")),
                new Customer("BONAP", "Bon app'", "91.24.45.40", "91.24.45.41", new Contact("Laurence Lebihan", "Owner"),
                    new Address("12, rue des Bouchers", "Marseille", "", "13008", "France")),
                new Customer("BOTTM", "Bottom-Dollar Markets", "(604) 555-4729", "(604) 555-3745",
                    new Contact("Elizabeth Lincoln", "Accounting Manager"),
                    new Address("23 Tsawassen Blvd.", "Tsawassen", "BC", "T2F 8M4", "Canada")),
                new Customer("BSBEV", "B's Beverages", "(171) 555-1212", "",
                    new Contact("Victoria Ashworth", "Sales Representative"),
                    new Address("Fauntleroy Circus", "London", "", "EC2 5NT", "UK")),
                new Customer("CACTU", "Cactus Comidas para llevar", "(1) 135-5555", "(1) 135-4892",
                    new Contact("Patricio Simpson", "Sales Agent"),
                    new Address("Cerrito 333", "Buenos Aires", "", "1010", "Argentina")),
                new Customer("CENTC", "Centro comercial Moctezuma", "(5) 555-3392", "(5) 555-7293",
                    new Contact("Francisco Chang", "Marketing Manager"),
                    new Address("Sierras de Granada 9993", "México D.F.", "", "05022", "Mexico")),
                new Customer("CHOPS", "Chop-suey Chinese", "0452-076545", "", new Contact("Yang Wang", "Owner"),
                    new Address("Hauptstr. 29", "Bern", "", "3012", "Switzerland")),
                new Customer("COMMI", "Comércio Mineiro", "(11) 555-7647", "",
                    new Contact("Pedro Afonso", "Sales Associate"),
                    new Address("Av. dos Lusíadas, 23", "Sao Paulo", "SP", "05432-043", "Brazil"))
            };

            products = new List<Product>()
            {
                new Product(1, "Chai", 1, categories.Single(c => c.Id == 1), "10 boxes x 20 bags", 18.00M, 39, 0),
                new Product(2, "Chang", 1, categories.Single(c => c.Id == 1), "24 - 12 oz bottles", 19.00M, 17, 40),
                new Product(3, "Aniseed Syrup", 1, categories.Single(c => c.Id == 2), "12 - 550 ml bottles", 10.00M, 13,
                    70),
                new Product(4, "Chef Anton's Cajun Seasoning", 2, categories.Single(c => c.Id == 2), "48 - 6 oz jars",
                    22.00M,
                    53, 0),
                new Product(5, "Chef Anton's Gumbo Mix", 2, categories.Single(c => c.Id == 2), "36 boxes", 21.35M, 0, 0),
                new Product(6, "Grandma's Boysenberry Spread", 3, categories.Single(c => c.Id == 2), "12 - 8 oz jars",
                    25.00M,
                    120, 0),
                new Product(7, "Uncle Bob's Organic Dried Pears", 3, categories.Single(c => c.Id == 7), "12 - 1 lb pkgs.",
                    30.00M, 15, 0),
                new Product(8, "Northwoods Cranberry Sauce", 3, categories.Single(c => c.Id == 2), "12 - 12 oz jars",
                    40.00M, 6,
                    0),
                new Product(9, "Mishi Kobe Niku", 4, categories.Single(c => c.Id == 6), "18 - 500 g pkgs.", 97.00M, 29, 0),
                new Product(10, "Ikura", 4, categories.Single(c => c.Id == 8), "12 - 200 ml jars", 31.00M, 31, 0),
                new Product(11, "Queso Cabrales", 5, categories.Single(c => c.Id == 4), "1 kg pkg.", 21.00M, 22, 30),
                new Product(12, "Queso Manchego La Pastora", 5, categories.Single(c => c.Id == 4), "10 - 500 g pkgs.",
                    38.00M,
                    86, 0),
                new Product(13, "Konbu", 6, categories.Single(c => c.Id == 8), "2 kg box", 6.00M, 24, 0),
                new Product(14, "Tofu", 6, categories.Single(c => c.Id == 7), "40 - 100 g pkgs.", 23.25M, 35, 0),
                new Product(15, "Genen Shouyu", 6, categories.Single(c => c.Id == 2), "24 - 250 ml bottles", 15.50M, 39, 0),
                new Product(16, "Pavlova", 7, categories.Single(c => c.Id == 3), "32 - 500 g boxes", 17.45M, 29, 0),
                new Product(17, "Alice Mutton", 7, categories.Single(c => c.Id == 6), "20 - 1 kg tins", 39.00M, 0, 0),
                new Product(18, "Carnarvon Tigers", 7, categories.Single(c => c.Id == 8), "16 kg pkg.", 62.50M, 42, 0),
                new Product(19, "Teatime Chocolate Biscuits", 8, categories.Single(c => c.Id == 3), "10 boxes x 12 pieces",
                    9.20M, 25, 0),
                new Product(20, "Sir Rodney's Marmalade", 8, categories.Single(c => c.Id == 3), "30 gift boxes", 81.00M, 40,
                    0)
            };
        }

    }
}