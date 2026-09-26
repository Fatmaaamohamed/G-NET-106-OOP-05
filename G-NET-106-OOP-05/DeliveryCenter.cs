using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_106_OOP_05
{
    internal class DeliveryCenter
    {
        Shipment[] shipments;

        public string CenterName { get; set; }

        public Driver AssignedDriver { get; set; }

        public DeliveryCenter(string centerName = "Main Delivery Center ")
        {

            CenterName = centerName;

            shipments = new Shipment[20];
        }


        public Shipment this[int index]
        {
            get
            {
                if (shipments == null || index < 0 || index >= shipments.Length)
                {
                    return null;
                }
                return shipments[index];
            }
            set
            {
                if (shipments != null && index >= 0 && index < shipments.Length)
                {
                    shipments[index] = value;
                }
            }
        }


        public Shipment this[string trackingCode]
        {
            get
            {
                if (shipments == null || string.IsNullOrWhiteSpace(trackingCode))
                {
                    return null;
                }

                foreach (var s in shipments)
                {
                    if (s != null && s.TrackingCode == trackingCode)
                    {
                        return s;
                    }
                }

                return null;
            }
        }


        public bool AddShipment(Shipment shipment)
        {
            if (shipments == null)
            {
                shipments = new Shipment[20];
            }

            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null || string.IsNullOrEmpty(shipments[i].TrackingCode))
                {
                    shipments[i] = shipment;
                    return true;
                }
            }

            return false; // Center is full
        }


        public bool RemoveShipment(string trackingCode)
        {
            if (shipments == null || string.IsNullOrWhiteSpace(trackingCode))
            {
                return false;
            }

            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null && shipments[i].TrackingCode == trackingCode)
                {
                    shipments[i] = null; // Clear position
                    return true;
                }
            }

            return false; // Tracking code not found
        }



        public void PrintAllShipments()
        {
            Console.WriteLine($"=== Shipments at {CenterName} ===");
            bool hasShipments = false;

            foreach (Shipment s in shipments)
            {
                if (s != null && !string.IsNullOrEmpty(s.TrackingCode))
                {
                    hasShipments = true;

                    s.PrintShipment();
                }
            }

            if (!hasShipments)
            {
                Console.WriteLine("No shipments stored in this center.");
            }
        }

        public void PrintTrackingStatuses()
        {
            Console.WriteLine($"=== Tracking Statuses at {CenterName} ===");
            bool hasShipments = false;

            foreach (Shipment s in shipments)
            {
                if (s is ITrackable trackableShipment)
                {
                    hasShipments = true;
                    DeliveryReport.PrintShipment(trackableShipment);
                }
            }

            if (!hasShipments)
            {
                Console.WriteLine("No trackable shipments found.");
            }
        }
   

        public void PrintInsurancePolicies()
        {
            Console.WriteLine($"=== Insurance Reports at {CenterName} ===");
            bool hasInsurable = false;

            foreach (Shipment s in shipments)
            {
                if (s is IInsurable insurableShipment)
                {
                    hasInsurable = true;
                    DeliveryReport.PrintInsurance(insurableShipment);
                }
            }

            if (!hasInsurable)
            {
                Console.WriteLine("No insurable shipments found.");
            }
        }
    }

}

