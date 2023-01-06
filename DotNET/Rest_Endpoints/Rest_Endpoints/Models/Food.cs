﻿namespace Rest_Endpoints.Models
{
    public class Food
    {
        public Food(int id, string name, string country, double weight)
        {
            Id = id;
            Name = name;
            Country = country;
            Weight = weight;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public double Weight { get; set; }
        public DateTime CreationDateDime { get; set; }
    }
}
