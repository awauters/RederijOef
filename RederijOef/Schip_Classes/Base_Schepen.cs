namespace RederijOef
{
    public abstract class Base_Schepen
    {
        public Schip_Classes(decimal lengte, int breedte, string naam, int tonnage);
        public decimal lengte { get; set; }
        public decimal breedte { get; set; }
        public int tonnage { get; set; }
        public string naam { get; set; }
        public override string ToString()
        {
            return $"(Schip {naam}, {lengte}, {breedte}, [tonnage}, {Vloot.naam},{this.GetType()})";
        }
    }
}