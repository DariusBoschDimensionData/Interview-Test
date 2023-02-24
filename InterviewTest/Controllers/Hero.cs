using InterviewTest.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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
                // Case statement maybe? Or rather an interface?
                if(action == "evolve")
                {
                    foreach (var statts in stats)
                    {
                        // Get list
                        // Get values from list
                        // Get action
                        // Check action
                        // If correct action, enter loop
                        // Take current value, divide by 2
                        // Assign new value to stat
                        // Exit
                        Console.WriteLine(statts.Key);
                        statts.ForEach(x => Console.WriteLine(x));

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
    }
}
