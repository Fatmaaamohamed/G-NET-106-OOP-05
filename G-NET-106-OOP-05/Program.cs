using System.Net;

namespace G_NET_106_OOP_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            /*
            a) only the reference is copied, not the underlying object itself.
               Both variables end up pointing to the exact same location in memory. 


            b) No, assigning one object to another does not create a new object.
               It creates a new reference that points to the original object.
               Because both variables refer to the same instance in memory, modifying the object through one variable will reflect 
               immediately when accessed through the other:

            c) Copying a reference duplicates only the memory address so both variables point to the same object, 
               meaning changes to one affect the other. Copying an object allocates new memory and duplicates the 
               underlying data into a distinct instance, leaving both objects completely independent.


           */
            #endregion


            #region Question02

            /*
             
             a) A shallow copy creates a new object instance, but duplicates only the fields of the original object,
                keeping references to any nested objects shared between both instances and arrays.


             b) A deep copy creates a new object instance and recursively duplicates all nested objects and references,
                producing a completely independent object.


             c) For reference-type members, only their memory addresses are copied, so both the original object and the new copy end up
                referencing the exact same nested objects in memory except string.


             d) For reference-type members, new objects are instantiated in memory and filled with copies of the nested data, 
                giving the new object its own distinct reference-type members.
             

             e) When a user edits an item in their shopping cart , deep copy is safer whenever an object needs to be modified independently without 
                risking unintentional side effects on the original object's internal data.
             
            
             
             */



            #endregion


            #region Question03

            /*
             
             a) A static field belongs to the class itself and has a single shared copy across all instances. 
                An instance field belongs to a specific object, meaning every object instance gets its own independent copy of that field.

            
             b) A static method is a method that belongs to the class rather than an object instance and can be called directly 
               on the class itself. No, a static method cannot directly access instance members


             c) A static constructor is used to initialize static data or perform actions needed only once for a class. 
                It is executed automatically by the runtime before the first instance is created or any static member is accessed.
             

             d) A static class is a container class that can only hold static members and cannot be instantiated or inherited.
                No, you cannot create an object from a static class .
             
             
             */




            #endregion


            #region Question04

            /*
             
            a) An extension method is a static method that allows you to add new functionality to an existing type without modifying
               its source code, inheriting from it, or recompiling it. It can be invoked using instance method syntax 
               as if it were a natural member of that type.

            b) The this keyword must precede the first parameter to specify the type the method is extending.


            c) An extension method must be declared inside a static class.


            d) No. An extension method operates like any other external method and can only access the public
               or accessible internal members of the class it extends.
             
             
             
             
             
            */

            #endregion


            #region Question05

            /*
             
            a) A partial class is a special class definition that allows its source code to be split 
               across two or more separate code files within the same project, using the partial keyword.

            b) Auto-Generated Code: Keeps machine-generated code separate from custom code so edits aren't overwritten.

               Team Collaboration: Enables multiple developers to work on the same class across different files 
               simultaneously without merge conflicts.

               Code Organization: Keeps huge classes manageable and easier to navigate.
             
            c) A partial method is a method declared in one file of a partial class whose optional 
               implementation can be provided in another file of the same class.

            d) The compiler completely removes the method signature and all calls to it from the final compiled code,
               leaving zero runtime or performance overhead
             
             
             
             
             
             */

            #endregion


            #region Question07
            DeliveryUtilities.PrintSystemTitle("Delivery Center");

            #endregion
            #region Question04

            Console.WriteLine();

            DeliveryAddress address = new DeliveryAddress("Cairo", "123 Main St", 11511);

            StandardShipment s1 = new StandardShipment("SH001", "Laptop", 2.5m, 95m, address);
            ExpressShipment s2 = new ExpressShipment("SH002", "Documents", 1.0m, 50m, address, 30m);
            InternationalShipment s3 = new InternationalShipment("SH003", "Medical Supplies", 5.0m, 200m, address, "Germany", 60m);

            Console.WriteLine($"Total Shipments Created: {Shipment.GetTotalShipmentsCreated()}");


            Console.WriteLine();

            #endregion

            #region Question01

            Console.WriteLine("Object Copying");
            Console.WriteLine("===================================================================================");

            DeliveryAddress address1 = new DeliveryAddress("123 Main St", "Cairo", 11511);
            StandardShipment sh1 = new StandardShipment("SH001", "Laptop", 3, 95, address1);

            Shipment assignedShipment = sh1;

            Console.WriteLine($"Original Shipment  : {sh1.TrackingCode}");
            Console.WriteLine($"Assigned Shipment  : {assignedShipment.TrackingCode}\n");

            Console.WriteLine($"Same Object : {ReferenceEquals(sh1, assignedShipment)}");

            Console.WriteLine();


            #endregion

            #region Question02

            Console.WriteLine("Shallow Copy");
            Console.WriteLine("===================================================================================");

            DeliveryAddress shallowAddr = new DeliveryAddress("Cairo", "123 Main St", 11511);
            StandardShipment shallowOrig = new StandardShipment("SH001", "Laptop", 3, 95, shallowAddr);

            Shipment shallowCopy = shallowOrig.ShallowCopy();


            Console.WriteLine($"Original Shipment Address : {shallowOrig.Destination.City}");
            Console.WriteLine($"Copied Shipment Address   : {shallowCopy.Destination.City}\n");


            Console.WriteLine("Changing copied shipment address...\n");
            shallowCopy.Destination.City = "Giza";

            Console.WriteLine($"Original Shipment Address : {shallowOrig.Destination.City}");
            Console.WriteLine($"Copied Shipment Address   : {shallowCopy.Destination.City}\n");

            Console.WriteLine($"Same DeliveryAddress Object : {ReferenceEquals(shallowOrig.Destination, shallowCopy.Destination)}");


            #endregion


            #region Question03

            Console.WriteLine();

            Console.WriteLine("Deep Copy");
            Console.WriteLine("===================================================================================");

            DeliveryAddress deepAddr = new DeliveryAddress("Cairo", "123 Main St", 11511);
            StandardShipment deepOrig = new StandardShipment("SH001", "Laptop", 3, 95, deepAddr);

        
            Shipment deepCopy = deepOrig.DeepCopy();

        
            Console.WriteLine($"Original Shipment Address : {deepOrig.Destination.City}");
            Console.WriteLine($"Copied Shipment Address   : {deepCopy.Destination.City}\n");

            Console.WriteLine("Changing copied shipment address...\n");
            deepCopy.Destination.City = "Giza";

            Console.WriteLine($"Original Shipment Address : {deepOrig.Destination.City}");
            Console.WriteLine($"Copied Shipment Address   : {deepCopy.Destination.City}\n");

  
            Console.WriteLine($"Same DeliveryAddress Object : {ReferenceEquals(deepOrig.Destination, deepCopy.Destination)}");







            #endregion

        }
    }
}
