using RederijOef.Schip_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RederijOef.Schepen
{
    class Olietanker : Tanker
    {
        public string volume;
        public string lading;
        public string cargowaarde;

        public void PrintOlietanker()
        {
            Console.WriteLine("lengte" + lengte);
            Console.WriteLine("breedte" + breedte);
            Console.WriteLine("tonnage" + tonnage);
            Console.WriteLine("naam" + naam);
            Console.WriteLine("volume" + volume);
            Console.WriteLine("lading" + lading);
            Console.WriteLine("cargowaarde" + cargowaarde);
        }
    }

}