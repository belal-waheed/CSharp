namespace OOP02
{
    public class StandardShipment : Shipment
    {
        public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }

        public StandardShipment(string trackingCode)
            : base(trackingCode)
        {
        }
    }
}
