using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InterviewTest.Controllers
{
    //Refactor the Hero class to implement an interface of IHero.
    interface iHero
    {
         string name { get; set; }
         string power { get; set; }
         List<KeyValuePair<string, int>> stats { get; set; }
        void evolve();
    }
    public class Hero: iHero
    {
        public string name { get; set; }
        public string power { get; set; }
        public List<KeyValuePair<string, int>> stats { get; set; }

        /*public void evolve(int statIncrease = 5)
        {
            
        }*/

        public void evolve()
        {
            //declare new list 
            List<KeyValuePair<string, int>> newStats = new List<KeyValuePair<string, int>>();

            foreach (KeyValuePair<string, int> stat in stats)
            {
                //Ket values from list
                int value = stat.Value;
                string key = stat.Key;

                //calculation - multiple of half the original stats value
                /*the instruction was a bit unclear and I was not sure why the method accepted a parameter of default 5, the
                 implementation was based on how I understood the assigment of taking the value and multiplying it with half of 
                the original value*/
                int newValueIncrement = value * (value / 2);
               
                //Add updated stats to new list of keyvaluepairs
                newStats.Add(new KeyValuePair<string, int>(key, newValueIncrement));
            }

            //Assign new list to existing
            stats = newStats;
        }
    }
}
