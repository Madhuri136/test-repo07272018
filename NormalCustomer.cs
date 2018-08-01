using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    public class NormalCustomer:ICustomer
    {
        public string GetName()
        {
            return "I am a Normal Customer";
        }
    }
}
