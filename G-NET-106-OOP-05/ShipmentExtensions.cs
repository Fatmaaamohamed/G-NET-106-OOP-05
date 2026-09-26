using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_106_OOP_05
{
    internal static class ShipmentExtensions
    {
        public static string GetSummary(this Shipment shipment)
        {
            if (shipment == null)
                return string.Empty;

            string shipmentType = shipment.GetType().Name.Replace("Shipment", " ");

            string status = (shipment is ITrackable trackable) ? trackable.GetTrackingStatus() : "Unknown";

            return $"{shipment.TrackingCode} | {shipmentType} | {shipment.Weight} KG | {status}";

        }

        public static bool IsDelivered(this Shipment shipment)
        {
            if (shipment == null)
                return false;

            string status = (shipment is ITrackable trackable) ? trackable.GetTrackingStatus() : "";

            return status.EndsWith("Delivered.", StringComparison.OrdinalIgnoreCase);
        }
    }
}
