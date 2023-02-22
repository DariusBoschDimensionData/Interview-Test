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
            throw new NotImplementedException();
        }

        public void Evolve(int statIncrease = 5)
        {
            
        }

        public void Evolve(Hero hero)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Hero> Get()
        {
            throw new NotImplementedException();
        }

        public Hero Get(int id)
        {
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
