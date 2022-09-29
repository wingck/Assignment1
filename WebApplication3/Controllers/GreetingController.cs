﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication3.Controllers
{
    public class GreetingController : ApiController
    {
        // GET api/Greeting
        public IEnumerable<string> Post()
        {
            return new string[] { "Hello World!" } ;
        }
        // GET api/Greeting/{id}
        public IEnumerable<string> Get(int id)
        {
            return new string[] { "Greetings to" + " " + id + " " + "people!" };
        }
    }
}
