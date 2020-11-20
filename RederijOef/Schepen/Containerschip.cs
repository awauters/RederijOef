using RederijOef.Schip_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RederijOef.Schepen
{
    class Containerschip : Vrachtschip
    {
        public string cargowaarde;
        public int aantalContainers;

        public void PrintContainerschip()
        {
            Console.WriteLine("lengte" + lengte);
            Console.WriteLine("breedte" + breedte);
            Console.WriteLine("tonnage" + tonnage);
            Console.WriteLine("naam" + naam);
            Console.WriteLine("cargowaarde" + cargowaarde);
            Console.WriteLine("aantalContainers" + aantalContainers);
        }
    }


}