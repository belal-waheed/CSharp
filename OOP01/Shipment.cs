using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace OOP01
{
    internal struct Shipment
    {
        private string trackingCode;
        private string description;
        private double weight;
        private decimal deliveryFee;

        public string TrackingCode
        {
            get { return trackingCode; }
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    description = value;
            }
        }

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                    weight = value;
            }
        }

        public decimal DeliveryFee
        {
            get { return deliveryFee; }
            private
              set
            {
                if (value > 0)
                    deliveryFee = value;
            }
        }

        public DeliveryAddress Destination { get; set; }

        public decimal EstimatedCost
        {
            get { return DeliveryFee + ((decimal)Weight * 5); }
        }

        public Shipment(string trackingCode)
        {
            if (string.IsNullOrWhiteSpace(trackingCode))
                this.trackingCode = "Unknown";
            else
                this.trackingCode = trackingCode;

            description = "Unknown";
            weight = 1;
            deliveryFee = 50;
            Destination = new DeliveryAddress("Unknown", "Unknown", 0);
        }

        public Shipment(string trackingCode, string description, double weight, decimal deliveryFee,
                        DeliveryAddress destination)
        {
            if (string.IsNullOrWhiteSpace(trackingCode))
                this.trackingCode = "Unknown";
            else
                this.trackingCode = trackingCode;

            if (string.IsNullOrWhiteSpace(description))
                this.description = "Unknown";
            else
                this.description = description;

            if (weight > 0)
                this.weight = weight;
            else
                this.weight = 1;

            if (deliveryFee > 0)
                this.deliveryFee = deliveryFee;
            else
                this.deliveryFee = 50;

            Destination = destination;
        }

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
                DeliveryFee = newFee;
        }

        public void PrintShipment()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} KG");
            Console.WriteLine($"Delivery Fee: {DeliveryFee} EGP");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }
    }
}
