using System;
using System.Collections.Generic;
using System.Text;

namespace OOP01
{
    internal struct DeliveryAddress
    {
        public string City { get; set; }
        public string Street { get; set; }
        public int BuildingNumber { get; set; }
        public DeliveryAddress()
        {
            City = "";
            Street = "";
            BuildingNumber = 0;
        }
        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            City = city;
            Street = street;
            BuildingNumber = buildingNumber;
        }
        public string GetFullAddress()
        {
            return $"{Street} {BuildingNumber}, {City}";
        }

    }
}
