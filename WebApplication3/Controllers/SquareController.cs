using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication3.Controllers
{
    public class SquareController : ApiController
    {
        // <summary>
        // This method gets the result of id * id
        // <example>input id = 10</example>
        // <returns>10 * 10 = 100</returns>
        //</summary>
        // GET api/Square/{id}
        public IEnumerable<int> Get(int id)
        {
            return new int[] { id * id };
        }
    }
}
