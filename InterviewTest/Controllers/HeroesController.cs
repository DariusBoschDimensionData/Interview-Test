using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace InterviewTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroesController : ControllerBase
    {
        private Hero[] heroes = new Hero[] {
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

        // GET: api/Heroes
        [HttpGet]
        public IEnumerable<Hero> Get()
        {
            return this.heroes;
        }

        // GET: api/Heroes/5
        [HttpGet("{id}", Name = "Get")]
        public Hero Get(int id)
        {
            return this.heroes.FirstOrDefault();
        }

        // POST: api/Heroes
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // POST: api/Heroes/hulk
        [HttpPost]
        [Route("Evolve")]
        public async Task<ActionResult<Hero[]>> Evolve([FromBody] JObject data)
        {
            string name = data["name"].ToString();
            string action = data["action"].ToString();

            if (action == "none")
            {
                return BadRequest("Action is required");
            }

            Hero hero = heroes.Where(x => x.name == name).SingleOrDefault();

            if (hero != null)
            {

                List<KeyValuePair<string, int>> kvp = new List<KeyValuePair<string, int>>();
                foreach (var item in hero.stats)
                {
                    var newEntry = new KeyValuePair<string, int>(item.Key, (int)(Math.Floor(item.Value * 1.5)));
                    kvp.Add(newEntry);
                }

                hero.stats = kvp;
            }

            return Ok(heroes);
        }

        // PUT: api/Heroes/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
