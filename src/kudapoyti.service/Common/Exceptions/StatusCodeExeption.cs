using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace kudapoyti.Service.Common.Exceptions
{
    public class NotFoundException:Exception
    {
        public HttpStatusCode StatusCode { get; set; }

        public NotFoundException(HttpStatusCode statusCode,string message)
            :base(message)
        {
            StatusCode = statusCode;
        }
    }
}
