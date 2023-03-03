using InterviewTest.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewTest.Controllers
{
    public class Hero : IHero
    {
        public string name { get; set; }
        public string power { get; set; }
        public List<KeyValuePair<string, int>> stats {get;set;}

        public void Delete(int id)
        {
            try
            {
                Console.WriteLine("Delete Works!");
            }
            catch {
                Console.WriteLine("in the catch block");
            }
            throw new NotImplementedException();
        }

        // Changing bool to string type, to handle 'none' defalt and for more possibilities I guess :/
        public void Evolve(string action, List<KeyValuePair<string, int>> stats)
        {
            action= action;
            if(stats!=null && stats.Count()>0)
            {
                //Hero.stats.g
                // Case statement maybe? Or rather an interface?
                if(action == "evolve")
                {                    
                    foreach (var statts in stats)
                    {
                        string strringgy = statts.Key;
                        int valuees = statts.Value;

                        Console.WriteLine(strringgy);

                        int newvaluees = valuees/2;
                        int dividednewvalue = newvaluees/2;

                        Console.WriteLine(dividednewvalue); 
                        // var statsdict = Dictionary(statts.Key, statts.Value);
                        // F it dude, let's use a hashtable and or a hashmap :'-)

                        // Get list
                        // Get values from list
                        // Get action
                        // Check action
                        // If correct action, enter loop
                        // Take current value, divide by 2
                        // Assign new value to stat
                        // Exit

                        // sSo many edge cases though, like how many flipping entries are we going to get???
                        // What data types am I getting in there???
                        // Will I have to change them at some point?
                        // Is performance a concern? If so what are the constraints?
                        // Attimesambiguitycanbeannoying
                        if (dividednewvalue != null)
                        {
                            statts.Value = dividednewvalue;
                        }
                        Console.WriteLine(statts.Key);

                    }

                    stats.ForEach(x => Console.WriteLine(x));
                }
            }

            Console.WriteLine(action);
            Console.WriteLine("yippee evolve accessed! ");

        }

        public void Evolve(Hero hero)
        {
            Console.WriteLine("Evolve but with a different signature, input param is Hero which is not good I guess lmao -> " + hero.name);
            throw new NotImplementedException();
        }

        public IEnumerable<Hero> Get()
        {
            Console.WriteLine(name + "Is our current hero name in the overloaded Evolve with enumerable");
            throw new NotImplementedException();
        }

        public Hero Get(int id)
        {
            Console.WriteLine($"{name} {id}" + "Yeah get you know...");

            throw new NotImplementedException();
        }

        public void Post([FromBody] string value)
        {
            throw new NotImplementedException();
        }

        public void Put(int id, [FromBody] string value)
        {
            throw new NotImplementedException();
        }

        void IHero.Evolve(string action, List<KeyValuePair<string, int>> stats, Hero )
        {
            throw new NotImplementedException();
        }
    }
}
