using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProbeAPI.Model;

namespace ProbeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        ProbeAPIContext _context;

        public PersonController(ProbeAPIContext context)
        {
            _context = context;
        }
        //public string Index()
        //{
        //    return "Hans";
        //}

        public string AddPerson()
        {
            var person = new Person();
            person.Name = "Nicolas";
            _context.Person.Add(person);
            _context.SaveChanges();
            return person.Name;
        }
    }
}