namespace OOP02
{
    public struct DeliveryAddress
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
            City = city ?? "";
            Street = street ?? "";
            BuildingNumber = buildingNumber;
        }

        public string GetFullAddress()
        {
            return $"{Street} {BuildingNumber}, {City}";
        }

        public override string ToString()
        {
            return GetFullAddress();
        }
    }
}
