using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_106_OOP_05
{
    internal abstract partial class Shipment : ITrackable
    {

        public string TrackingStatus { get; protected set; } = "In Transit";

        public virtual string GetTrackingStatus()
        {
            return $"Shipment [{TrackingCode}] Status: {TrackingStatus}";
        }
        public virtual void UpdateTrackingStatus(string newStatus)
        {
            if (!string.IsNullOrWhiteSpace(newStatus))
            {
                TrackingStatus = newStatus;

                OnTrackingStatusChanged(newStatus);
            }
        }

        partial void OnTrackingStatusChanged(string newStatus)
        {
            Console.WriteLine($"Tracking status changed to: {newStatus}");
        }

    }
}
