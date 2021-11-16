using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Services.Exceptions
{
    public class DbConcurrencyexception : ApplicationException
    {
        public DbConcurrencyexception(string message) : base(message)
        { 
        
        }
    }
}
