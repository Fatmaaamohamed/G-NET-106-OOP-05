using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_106_OOP_05
{
    internal class DeliveryReport
    {
        public static void PrintShipment(ITrackable shipment)
        {
            if (shipment != null)
            {
                Console.WriteLine($"{shipment.GetTrackingStatus()}");
            }
        }

        public static void PrintInsurance(IInsurable shipment)
        {
            if (shipment != null)
            {
                Console.WriteLine($"Insurance Cost: {shipment.CalculateInsurance()} EGP");
            }
        }
    }
}
