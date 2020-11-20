using RederijOef.Schip_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RederijOef.Schepen
{
    class RoRoschip : Vrachtschip
    {
        public int aantalAutos;
        public int aantalTrucks;
        public string cargowaarde;

        public void PrintRoRoschip()
        {
            Console.WriteLine("lengte" + lengte);
            Console.WriteLine("breedte" + breedte);
            Console.WriteLine("tonnage" + tonnage);
            Console.WriteLine("naam" + naam);
            Console.WriteLine("aantal auto's" + aantalAutos);
            Console.WriteLine("aantal trucks" + aantalTrucks);
            Console.WriteLine("cargowaarde" + cargowaarde);
        }
    }
}