﻿namespace ShopTARge22.Models.Spaceships
{
    public class SpaceshipDeleteViewModel
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime BuiltDate { get; set; }
        public int Passengers { get; set; }
        public int CargoWeight { get; set; }
        public int Crew { get; set; }
        public int EnginePower { get; set; }

        public List<SpaceshipImageViewModel> ImageViewModels { get; set; } = new List<SpaceshipImageViewModel>();


        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
