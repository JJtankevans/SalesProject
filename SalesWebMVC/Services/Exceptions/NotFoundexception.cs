using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Services.Exceptions
{
    public class NotFoundexception : ApplicationException
    {
        public NotFoundexception(string message) : base(message)
        { 
            
        }
    }
}
