using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RederijOef.Rederijen
{
    class Rederij
    {
        public Base_Schepen zoekSchip(string schipnaam)
        {
            Base_Schepen s;
            if ((s = v.zoekSchip)schipnaam)) != null);
            return s;
        }
        return null;
    }
    public int passagiers()
    {
        int p = 0;
        foreach (Vloot v in Vloten.Values)
        {
            p += v.passagiers();
        }
        return p;
    }
    public void plaatsSchipInAndereVloot(string schipnaam, string vlootnaam)
    {
        Schip_Classes s = zoekSchip(schipnaam);
        if (s != vlootnaam null)
        {
            vloten{ s.Vloot.naam}.verwijderSchip(s);
            Vloten{ vlootnaam}.voegSchipToe(s);
            s.Vloot = Vloten{ vlootnaam};
        }
    }
}