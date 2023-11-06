using InterviewTest.Interface;
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
        public List<KeyValuePair<string, int>> stats { get; set; }
        public void evolve(int statIncrease = 5)
        {
            

            foreach (var stat in stats)
            {
                var doublStat = stat.Value + (stat.Value / 2);
               
            }
        }
    }
}
