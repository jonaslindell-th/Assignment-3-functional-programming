using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ImperativeToFunctional
{
    public class City
    {
        public string Name;
        public int Population;
        public double Area;
        public int Founded;
    }

    public class Cities
    {
        public static void Main()
        {
            City[] cities =
            {
                new City
                {
                    Name = "Stockholm",
                    Area = 381.63,
                    Population = 1515017,
                    Founded = 1252
                },
                new City
                {
                    Name = "Göteborg",
                    Area = 215.13,
                    Population = 590580,
                    Founded = 1621
                },
                new City
                {
                    Name = "Malmö",
                    Area = 77.06,
                    Population = 312012,
                    Founded = 1250
                },
                new City
                {
                    Name = "Uppsala",
                    Area = 43.74,
                    Population = 156854,
                    Founded = 1286
                },
                new City
                {
                    Name = "Västerås",
                    Area = 48.07,
                    Population = 121806,
                    Founded = 990
                },
                new City
                {
                    Name = "Örebro",
                    Area = 50.64,
                    Population = 119091,
                    Founded = 1200
                }
            };

            int highestPopulation = cities.OrderByDescending(c => c.Population).Select(c => c.Population).First();
            Console.WriteLine("Highest population: " + highestPopulation);

            int earliestFounding = cities.OrderBy(c => c.Founded).Select(c => c.Founded).First();
            Console.WriteLine("Earliest founding: " + earliestFounding);

            double averagePopulationDensity = Math.Round(cities.Select(c => c.Population / c.Area).Average());
            Console.WriteLine("Average population density: " + averagePopulationDensity + " people per square kilometer");

            var longNames = cities.Where(c => c.Name.Length > 6).Select(c => c.Name);
            Console.WriteLine("Cities with names longer than six letters: " + String.Join(", ", longNames));
            // asfasfa
        }
    }
}
