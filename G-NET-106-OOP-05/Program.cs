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




        }
    }
}
