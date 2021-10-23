using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    /// <summary>
    /// Exercise 1 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Tests LastIndexOf and AllIndexesOf methods
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // build test dynamic array

            UnorderedIntDynamicArray tablica = new UnorderedIntDynamicArray();

            // dodajemy 2 4 4 3 5 4
            tablica.Add(2);
            tablica.Add(4);
            tablica.Add(4);
            tablica.Add(3);
            tablica.Add(5);
            tablica.Add(4);

            // Console.WriteLine(tablica);

            // test LastIndexOf with one item in dynamic array
            // szukamy indeks 5, pierwszy z prawej

            // Console.WriteLine(tablica.LastIndexOf(5));

            // test LastIndexOf with multiple items in the dynamic array
            // szukamy indeks  4
            // Console.WriteLine(tablica.LastIndexOf(4));

            // test LastIndexOf with item not in dynamic array
            // szukamy indeks  10
            // Console.WriteLine(tablica.LastIndexOf(10));

            // test AllIndexesOf with one item in dynamic array

            // test AllIndexesOf with multiple items in dynamic array
            // szukamy indeks 4
            Console.WriteLine(tablica.AllIndexesOf(4));

            // test AllIndexesOf with item not in dynamic array

            Console.ReadKey();
        }
    }
}
