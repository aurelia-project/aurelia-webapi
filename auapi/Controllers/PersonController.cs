using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using auapi.Models;

namespace auapi.Controllers
{
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        [HttpGet]
        [Route("All")]
        public List<PersonModel> All()
        {
            PersonList persons = new PersonList();

            string[] names = { "Ali", "Burak", "Emre", "Onur" };
            string[] surnames = { "GÖREN", "KARADAŞ", "ALAKUŞ", "GÜRBÜZ" };

            for(int i = 0; i < names.Length; i++)
            {
                PersonModel person = new PersonModel()
                {
                    Name = names[i],
                    Surname = surnames[i]
                };

                persons.Persons.Add(person);
            }


            return persons.Persons;
        }
    }
}