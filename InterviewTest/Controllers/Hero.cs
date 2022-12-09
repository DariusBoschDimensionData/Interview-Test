using InterviewTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewTest.Controllers
{
    public class Hero :IHero
    {
        public string name { get; set; }
        public string power { get; set; }
        public List<KeyValuePair<string, int>> stats {get;set;}

        public Hero Evolve(Hero hero, int statIncrease = 5)
        {
            List<KeyValuePair<string, int>> kvp = new List<KeyValuePair<string, int>>();
            foreach (var item in hero.stats)
            {
                var newEntry = new KeyValuePair<string, int>(item.Key, (int)(Math.Floor(item.Value * 1.5)));
                kvp.Add(newEntry);
            }

            hero.stats = kvp;

            return hero;
        }
    }
}
