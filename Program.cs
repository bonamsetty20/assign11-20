using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (LargeDataCollection collection = new LargeDataCollection(new object[] { 1, "janu", 3.14 }))
            {
                // Adding elements to the collection
                collection.Add("deva");
                collection.Add(42);

                // Accessing elements from the collection
                Console.WriteLine("Element at index 0: " + collection.GetElement(0));
                Console.WriteLine("Element at index 1: " + collection.GetElement(1));

                // Removing an element from the collection
                collection.Remove("janu");

                // Accessing the removed element (this will throw an exception)
                 Console.WriteLine(collection.GetElement(1));
            }
        }
    }
}
