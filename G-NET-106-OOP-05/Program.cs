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


        }
    }
}
