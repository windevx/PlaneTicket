using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlaneTicket ticket1 = new PlaneTicket();
            PlaneTicket ticket2 = new PlaneTicket();

            ticket1.Origin = "JOGJA";
            ticket1.Destination = "PKU";
            ticket1.Cost = 100;
            ticket1.Currency = "USD";

            ticket2.Origin = "JKT";
            ticket2.Destination = "PKU";
            ticket2.Cost = 750000;
            ticket2.Currency = "IDR";

            Console.WriteLine("Origin : {0}", ticket1.Origin);
            Console.WriteLine("Destination : {0}", ticket1.Destination);
            Console.WriteLine("Cost : {0}", ticket1.Cost);
            Console.WriteLine("Convert to Rupiah : {0}", ticket1.Cost * 15000);

            Console.WriteLine("Origin : {0}", ticket2.Origin);
            Console.WriteLine("Destination : {0}", ticket2.Destination);
            Console.WriteLine("Cost : {0}", ticket2.Cost);
            Console.WriteLine("Convert to USD : {0}", ticket2.Cost / 15000);


        }

    }
}