using InterviewTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewTest.Controllers
{
    public class Hero: IHero
    {
        public string name { get; set; } 
        public string power { get; set; } 
        public List<KeyValuePair<string, int>> stats { get; set; } 
        public int Evolve(int statIncrease = 5)
        {
            var stats = GetHero();
            var statVal = 0;

            for (int i = 0; i < stats.Count(); i++)
            {
                
                var stat = stats[i];

                for(int j = 0; j <stat.stats.Count(); j++)
                {
                    var keyStats = stat.stats[j];
                    int keyVal = keyStats.Value;

                    int multiple = keyVal / 2;

                    statVal =  keyVal + multiple;
                }

                return statVal;

            }

            return statVal;
        }

        public Hero[] GetHero()
        {
            var hero = new Hero[] {
               new Hero()
               {
                   name= "Hulk",
                   power="Strength from gamma radiation",
                   stats=
                   new List<KeyValuePair<string, int>>()
                   {
                       new KeyValuePair<string, int>( "strength", 5000 ),
                       new KeyValuePair<string, int>( "intelligence", 50),
                       new KeyValuePair<string, int>( "stamina", 2500 )
                   }
               }
            };

            return hero;


        }
    }
}
