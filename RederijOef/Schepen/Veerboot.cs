using RederijOef.Schip_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RederijOef.Schepen
{
    class Veerboot : Passagierschip
    {
        public int aantalPassagiers;
        public string traject;
        public string traject2;

        public void PrintVeerboot()
        {
            Console.WriteLine("lengte" + lengte);
            Console.WriteLine("breedte" + breedte);
            Console.WriteLine("tonnage" + tonnage);
            Console.WriteLine("naam" + naam);
            Console.WriteLine("aantal passagiers" + aantalPassagiers);
            Console.WriteLine("traject 1" + traject);
            Console.WriteLine("traject 2" + traject2);
        }
    }
}