using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication3.Controllers
{
    public class NumberMachineController : ApiController
    {   // <summary>
        // This method gets the result of (id * 5 + 2) / 2 - 1
        // <example>input id = 10</example>
        // <returns>(10 * 5 + 2) / 2 - 1 = 25</returns>
        //</summary>
        // GET api/NumberMachine/{id}
        public IEnumerable<int> Get(int id)
        {
            return new int[] { (id * 5 + 2) / 2 - 1};
        }
    }
}
