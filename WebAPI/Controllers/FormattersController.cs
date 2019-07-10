using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class FormattersController : ApiController
    {
        public IEnumerable<string> Get()
        {
            IList<string> formats = new List<string>();

            foreach(var ex in GlobalConfiguration.Configuration.Formatters)
            {
                formats.Add(ex.ToString());
            }

            return formats.AsEnumerable<string>();
        }
    }
}
