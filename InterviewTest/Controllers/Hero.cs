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
        private int id { get; set; }
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


        public void Evolve(string action, List<KeyValuePair<string, int>> stats)
        {
            action = action;
            if(stats != null && stats.Count()>0)
            {

                if(action == "evolve")
                {                    
                    foreach (var statts in stats)
                    {
                        string powerStat = statts.Key;
                        int powerStatValue = statts.Value;

                        int newPowerValue = powerStatValue/2;
                        int finalPowerValue = powerStatValue * newPowerValue;

                        Console.WriteLine(finalPowerValue); 

                        for (int i = 0;i < stats.Count; i++)
                        {                            

                            int mustRemove = stats.RemoveAll(x => x.Key == powerStat);

                            if (mustRemove == 1)
                            {
                                stats.Add(new KeyValuePair<string, int>(powerStat, finalPowerValue));
                            }

                        }

                    }


                }
            }

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
            throw new NotImplementedException();
        }

        public void Post([FromBody] string value, string action)
        {            

            throw new NotImplementedException();
        }

        public void Put(int id, [FromBody] string value)
        {
            throw new NotImplementedException();
        }

        void IHero.Evolve(string action, List<KeyValuePair<string, int>> stats, Hero hero)
        {
            
            throw new NotImplementedException();
        }
    }

}
