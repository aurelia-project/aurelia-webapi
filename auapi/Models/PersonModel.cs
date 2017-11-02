using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace auapi.Models
{
    public class PersonModel
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        private string _surname;
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }
    }

    public class PersonList
    {
        public PersonList()
        {
            Persons = new List<PersonModel>();
        }
        
        public List<PersonModel> Persons { get; set; }
    }
}