namespace OOP02
{
    public class InternationalShipment : Shipment
    {
        private string destinationCountry = "Unknown";
        private decimal customsFee;

        public string DestinationCountry
        {
            get => destinationCountry;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    destinationCountry = value;
            }
        }

        public decimal CustomsFee
        {
            get => customsFee;
            set
            {
                if (value >= 0)
                    customsFee = value;
            }
        }

        public override decimal EstimatedCost => DeliveryFee + (Weight * 5m) + CustomsFee;

        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = string.IsNullOrWhiteSpace(destinationCountry) ? "Unknown" : destinationCountry;
            CustomsFee = customsFee >= 0 ? customsFee : 0m;
        }

        public InternationalShipment(string trackingCode)
            : base(trackingCode)
        {
            DestinationCountry = "Unknown";
            CustomsFee = 0m;
        }

        public override void PrintShipment()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} KG");
            Console.WriteLine($"Delivery Fee: {DeliveryFee} EGP");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine($"Destination Country: {DestinationCountry}");
            Console.WriteLine($"Customs Fee: {CustomsFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }
    }
}
