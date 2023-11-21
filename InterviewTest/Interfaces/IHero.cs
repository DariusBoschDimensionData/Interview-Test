using InterviewTest.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewTest.Interfaces
{
    public interface IHero
    {
        //List<KeyValuePair<string, int>> stats { get; set; }
        Hero[] GetHero();
        int Evolve(int statIncrease);
    }
}
