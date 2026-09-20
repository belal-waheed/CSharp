namespace OOP03
{
    public static class DeliveryHelper
    {
        public static void PrintShipmentDetails(Shipment? shipment)
        {
            if (shipment == null) return;
            shipment.PrintShipment();
            string typeName = shipment switch
            {
                StandardShipment => "Standard Shipment",
                ExpressShipment => "Express Shipment",
                InternationalShipment => "International Shipment",
                _ => shipment.GetType().Name
            };
            Console.WriteLine($"\n{typeName} Printed Successfully.\n");
        }
    }
}
