using InterviewTest.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace InterviewTest.Interfaces
{
    public interface IHero
    {
        IEnumerable<Hero> Get();

        Hero Get(int id);

        void Post([FromBody] string value, string action);

        void Put(int id, [FromBody] string value);

        void Delete(int id);

        void Evolve(Hero hero);
        void Evolve(string action, List<KeyValuePair<string, int>> stats, Hero hero );
    }
}
