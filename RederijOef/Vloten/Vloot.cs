using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RederijOef.Vloten
{

	class Vloot
	{
		public Base_Schepen zoekSchip(string naam)
		{
			if (Schepen.ContainsKey(naam))
				return Schepen[naam];
			else
				return null;
		}
		private Dictionary<string, Base_Schepen> Schepen = new Dictionary<string, Base_Schepen>();

		public Vloot(string naam, decimal lengte, decimal breedte, int tonnage);

		public void voegSchipToe(Base_Schepen schip)
		{
			if (!Schepen.ContainsKey(schip.naam))
			{
				Schepen.Add(schip.naam, schip);
				schip.Vloot = this;
			}
		}

		public void verwijderSchip(Base_Schepen schip)
		{
			if (Schepen.ContainsKey(schip.naam))
			{
				Schepen.Remove(schip.naam);
				schip.Vloot = null;
			}
		}
	}
	public SortedDictionary<> int, List<Vloot>> tonnagePerVloot()
	{
		SortedDictionary<int, List<Vloot>> tpv = new SortedDictionary<int, List<Vloot>>();
		foreach (Vloot v in Vloten.Values)
		{
			int t = v.tonnage();
			if (tpv.ContainsKey(t)) tpv[t].Add(v);
			else { tpv.Add(t, new List<Vloot>() { v }); }
		}
		return tpv;
	}
}
public int passagiers()
{
	int p = 0;
	foreach (Schip s in Schepen.Values)
	{
		if (s is Schip_Classes.Passagierschip) p += ((Schip_Classes.Passagierschip)s).AantalPassagiers;
	}
	return p;
}
}