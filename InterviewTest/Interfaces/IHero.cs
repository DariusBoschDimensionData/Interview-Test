using InterviewTest.Controllers;
using System.Collections.Generic;

namespace InterviewTest.Interfaces
{
    public interface IHero
    {
        Hero Evolve(Hero hero, int statIncrease);
    }
}
