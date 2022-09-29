using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication3.Controllers
{
    public class GreetingController : ApiController
    {
        // <summary>
        // This method returns the string "Hello World!" when receiving a post request
        // <example>POST api/Greeting</example>
        // <returns>"Hello World!"</returns>
        //</summary>
        // GET api/Greeting
        public IEnumerable<string> Post()
        {
            return new string[] { "Hello World!" } ;
        }

        // <summary>
        // int id is first changed to string
        // Then the method gets "Greeting to {id} people!"
        // <example>POST api/Greeting/10</example>
        // <returns>"Greeting to 10 people!"</returns>
        //</summary>
        // GET api/Greeting/{id}
        public IEnumerable<string> Get(int id)
        {
            return new string[] { "Greetings to" + " " + id + " " + "people!" };
        }
    }
}
