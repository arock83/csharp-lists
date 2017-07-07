using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
             List<string> planetList = new List<string>(){"Mercury", "Mars"};
             planetList.Add("Jupiter");
             planetList.Add("Saturn");

             List<string> lastPlanets = new List<string>{
                 "Neptune", "Uranus"
             };

             planetList.AddRange(lastPlanets);
             planetList.Insert(1, "Venus");
             planetList.Insert(2, "Earth");
             planetList.Add("Pluto");

             List<string> rockyPlanets = new List<string>();

             rockyPlanets = planetList.GetRange(0, 4);

             foreach(string planet in rockyPlanets){

                 Console.WriteLine(planet);
             }

             planetList.Remove("Pluto");

             Console.WriteLine("**************");

             foreach(string planet in planetList){
                 Console.WriteLine(planet);
             }
             
        }
    }
}
