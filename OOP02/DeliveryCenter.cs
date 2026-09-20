namespace OOP02
{
    public class DeliveryCenter
    {
        public string CenterName { get; set; }
        private Shipment?[] shipments;
        private int count;

        public DeliveryCenter()
        {
            CenterName = "Unknown";
            shipments = new Shipment[20];
            count = 0;
        }

        public DeliveryCenter(string centerName)
        {
            CenterName = string.IsNullOrWhiteSpace(centerName) ? "Unknown" : centerName;
            shipments = new Shipment[20];
            count = 0;
        }

        public bool AddShipment(Shipment shipment)
        {
            if (shipment == null || count >= shipments.Length)
            {
                return false;
            }

            shipments[count] = shipment;
            count++;
            return true;
        }

        public bool RemoveShipment(string trackingCode)
        {
            if (string.IsNullOrWhiteSpace(trackingCode) || count == 0)
            {
                return false;
            }

            int targetIndex = -1;
            for (int i = 0; i < count; i++)
            {
                if (shipments[i]?.TrackingCode == trackingCode)
                {
                    targetIndex = i;
                    break;
                }
            }

            if (targetIndex == -1)
            {
                return false;
            }

            for (int i = targetIndex; i < count - 1; i++)
            {
                shipments[i] = shipments[i + 1];
            }

            shipments[count - 1] = null;
            count--;
            return true;
        }

        public void PrintAllShipments()
        {
            Console.WriteLine($"\nDelivery Center: {CenterName}");
            Console.WriteLine("========================================");

            for (int i = 0; i < count; i++)
            {
                shipments[i]?.PrintShipment();
                Console.WriteLine("----------------------------------------");
            }
        }
    }
}
