using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Talent.Domain;
using Talent.Domain.TestData;
using UclaExt.Common;
using UclaExt.Common.Extensions;

namespace LinqConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ Lab:");
            DomainObjectStore store = new DomainObjectStore();
            store.People.PrintToConsole();



            Console.WriteLine("Press <Enter> to quit the application");
            Console.ReadLine();
        }

   
    }
}
