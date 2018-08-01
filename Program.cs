using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Container;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer();
            container.RegisterType <ICustomer, NormalCustomer>();
            //NormalCustomer customer = new NormalCustomer();
           var customer= container.Resolve<ICustomer>();
            customer.GetName();
            Console.WriteLine("hi");
            Console.WriteLine(customer.GetName());
            PrefferedCustomer pcustomer = new PrefferedCustomer();
            Console.WriteLine(pcustomer.GetName());
            Console.ReadLine();
        }
    }
}
         