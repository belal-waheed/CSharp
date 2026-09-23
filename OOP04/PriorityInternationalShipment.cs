namespace OOP03
{
    public class PriorityInternationalShipment : InternationalShipment
    {
        public PriorityInternationalShipment(string trackingCode)
            : base(trackingCode)
        {
        }

        public PriorityInternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee)
            : base(trackingCode, description, weight, deliveryFee, destination, destinationCountry, customsFee)
        {
        }

        public sealed override void GenerateCustomsReport()
        {
            base.GenerateCustomsReport();
            Console.WriteLine("Priority Clearance: Expedited");
        }
    }
}
