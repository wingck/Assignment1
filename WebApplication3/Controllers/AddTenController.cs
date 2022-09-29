using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication3.Controllers
{
    public class AddTenController : ApiController
    {
        // <summary>
        // This method gets the result of id + 1
        // <example>input id = 10</example>
        // <returns>21 + 10 = 31</returns>
        //</summary>
        // GET api/AddTen/{id}
        public IEnumerable<int> Get(int id)
        {
            return new int[] { id + 10 };
        }
    }
}
