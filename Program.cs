using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            //Creates a new list
            List<string> planetList2 = new List<string>() { "Uranus", "Neptune" };

            //Add the lists together
            planetList.AddRange(planetList2);

            //Inserting new planets
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            //Adding pluto to the end
            planetList.Add("Pluto");
            // planetList.ForEach(planet => Console.WriteLine(planet));


            // Now that all the planets are in the list, slice the list using GetRange() in 
            //order to extract the rocky planets into a new list called rockyPlanets. 
            List<string> rockyPlanets = planetList.GetRange(0, 4);
            rockyPlanets.ForEach(planets => Console.WriteLine(planets));

            //remove Pluto
            planetList.Remove("Pluto");
        }

    }
}
