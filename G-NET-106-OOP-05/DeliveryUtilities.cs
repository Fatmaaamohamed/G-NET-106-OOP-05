using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_106_OOP_05
{
    internal static class DeliveryUtilities
    {
        #region Question07
        public static void PrintSeparator()
        {
            Console.WriteLine("==========================================");
        }

        public static void PrintSystemTitle(string title)
        {
            PrintSeparator();
            Console.WriteLine(title);
            PrintSeparator();
        }

        #endregion
    }
}
