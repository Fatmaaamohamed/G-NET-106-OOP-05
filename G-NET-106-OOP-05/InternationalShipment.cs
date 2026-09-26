using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_106_OOP_05
{
    internal class InternationalShipment : Shipment, ITrackable, IInsurable
    {
        string destinationCountry;


        Decimal customsFee;


        public string DestinationCountry
        {
            get => destinationCountry;


            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    destinationCountry = value;
                }
            }

        }


        public decimal CustomsFee
        {
            get => customsFee;


            set
            {
                if (value >= 0)
                {
                    customsFee = value;
                }
            }

        }




        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee) :
            base(trackingCode, description, weight, deliveryFee, destination)
        {

            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;

        }



        public override void PrintShipment()
        {
            Console.WriteLine("International Shipment\n");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight} KG");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
            Console.WriteLine($"Destination Country : {DestinationCountry}");
            Console.WriteLine($"Customs Fee         : {CustomsFee} EGP");
            Console.WriteLine($"Estimated Cost      : {EstimatedCost} EGP");
            Console.WriteLine($"Destination   : {Destination?.GetFullAddress()}");
        }

        public override decimal EstimatedCost => DeliveryFee + CustomsFee;



        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine($"Customs Report for {DestinationCountry}: Fee = {CustomsFee} EGP");
        }

  
        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} has been Delivered.";
        }




        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.12m;

        }

        #region Question01
        public override Shipment CopyShipment()
        {
            return new InternationalShipment(TrackingCode, Description, Weight, DeliveryFee, Destination, DestinationCountry, CustomsFee);
        }
        #endregion

        #region Question03

        public override Shipment DeepCopy()
        {
            return new ExpressShipment(TrackingCode, Description, Weight, DeliveryFee, Destination?.DeepCopy(), CustomsFee);
        }


        #endregion

    }
}
