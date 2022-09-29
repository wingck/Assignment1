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
        // GET api/Square
        public IEnumerable<int> Get(int id)
        {
            return new int[] { id * id };
        }
    }
}
