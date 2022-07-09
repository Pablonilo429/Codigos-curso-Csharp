using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services.Exception
{
    public class DbConcurrencyExcpetion : ApplicationException
    {
        public DbConcurrencyExcpetion(string message) : base(message)
        {
        }
    }
}
