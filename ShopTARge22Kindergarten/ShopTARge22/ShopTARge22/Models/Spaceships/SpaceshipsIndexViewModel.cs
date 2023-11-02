namespace ShopTARge22.Models.Spaceships
{
    public class SpaceshipIndexViewModel
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime BuiltDate { get; set; }
        public int Passengers { get; set; }
    }
}
