using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_106_OOP_05
{
    internal abstract class Shipment
    {
        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;




        public DeliveryAddress Destination { get; set; }

        public string TrackingCode
        {
            get => trackingCode;
            private set
            {

                if (!string.IsNullOrWhiteSpace(value))
                {
                    trackingCode = value;
                }
            }
        }


        public string Description
        {
            get => description;
            set
            {

                if (!string.IsNullOrWhiteSpace(value))
                {
                    description = value;
                }
            }
        }


        public decimal Weight
        {
            get => weight;
            set
            {

                if (value > 0)
                {
                    weight = value;
                }
            }
        }


        public decimal DeliveryFee
        {
            get => deliveryFee;
            private set
            {

                if (value > 0)
                {
                    deliveryFee = value;
                }
            }
        }



        public Shipment(string trackingCode)
        {

            this.trackingCode = "DEFAULT_CODE";
            this.description = "Unknown";
            this.weight = 1m;
            this.deliveryFee = 50m;
            this.Destination = default;


            TrackingCode = trackingCode;
        }


        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {

            this.trackingCode = "DEFAULT_CODE";
            this.description = "Unknown";
            this.weight = 1m;
            this.deliveryFee = 50m;
            this.Destination = destination;


            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
        }


        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = newFee;
            }
        }


        public void UpdateWeight(decimal newWeight)
        {
            if (newWeight > 0)
            {
                Weight = newWeight;
            }
        }


        public void UpdateWeight(decimal newWeight, decimal extraPackingWeight)
        {
            if (newWeight > 0 && extraPackingWeight > 0)
            {
                Weight = newWeight + extraPackingWeight;
            }
        }


        
        public abstract decimal EstimatedCost { get; }

        public abstract void PrintShipment();

        



    }
}

