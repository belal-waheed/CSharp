namespace OOP03
{
    public sealed class CompletedShipment : Shipment
    {
        public CompletedShipment(string trackingCode)
            : base(trackingCode)
        {
        }

        public CompletedShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }
        public override decimal EstimatedCost => DeliveryFee + (Weight * 5m);

        public override void PrintShipment()
        {
            Console.WriteLine("Completed Shipment");
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
            Console.WriteLine("Status: Completed");
        }
    }
}
