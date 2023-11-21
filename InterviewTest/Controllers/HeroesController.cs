using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterviewTest.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InterviewTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroesController : ControllerBase
    {
        private readonly IHero _heroService;
        public HeroesController(IHero heroService)
        {
            _heroService = heroService;

        }


        // GET: api/Heroes
        [HttpGet]
        public IEnumerable<Hero> Get()
        {
            //return this.heroes;
            _heroService.Evolve(5);
            return _heroService.GetHero();
        }

        // GET: api/Heroes/5
        [HttpGet("{id}", Name = "Get")]
        public Hero Get(int id)
        {
            //return this.heroes.FirstOrDefault();
            return _heroService.GetHero().FirstOrDefault();
        }

        // POST: api/Heroes
        [HttpPost]
        public IActionResult Post([FromForm] string action, [FromBody] string value)
        {
            if(string.IsNullOrEmpty(action.ToLower()) || action != "evolve")
            {
                return BadRequest("The action is not evolve. Please ensure the action is evolve");
            }

            var hero = new Hero()
            {
                name = "Hulk",
                power = "Strength from gamma radiation",
                stats =
                   new List<KeyValuePair<string, int>>()
                   {
                       new KeyValuePair<string, int>( "strength", 5000 ),
                       new KeyValuePair<string, int>( "intelligence", 50),
                       new KeyValuePair<string, int>( "stamina", 2500 )
                   }
            };

            return Ok(hero);

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
