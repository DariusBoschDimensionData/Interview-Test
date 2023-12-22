using System.Collections.Generic;

namespace InterviewTest.Controllers
{
    public interface IHero
    {
        Hero[] GetHero();
        int Evolve(int statIncrease);
    }
}