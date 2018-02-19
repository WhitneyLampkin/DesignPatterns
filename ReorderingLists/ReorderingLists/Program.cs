using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReorderingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> myList = new List<Item>();
            List<Item> tempList = new List<Item>();
            List<Item> reorderedList = new List<Item>();

            myList.Add(new Item(0, Type.Measure));
            myList.Add(new Item(1, Type.Unknown));
            myList.Add(new Item(2, Type.Member));
            myList.Add(new Item(3, Type.Measure));
            myList.Add(new Item(4, Type.Member));
            
            Console.WriteLine("Original List:");

            foreach (var item in myList)
            {
                Console.WriteLine(String.Format("{0} {1}", item.ID, item.Type));
            }

            reorderedList.AddRange(myList.Where(i => i.Type != Type.Measure));
            reorderedList.AddRange(myList.Where(i => i.Type == Type.Measure));

            //foreach (var item in myList)
            //{
            //    if (item.Type == Type.Measure)
            //    {
            //        tempList.Add(item);
            //    }

            //    else
            //    {
            //        reorderedList.Add(item);
            //    }
            //}

            //reorderedList.AddRange(tempList);
            
            Console.WriteLine("Reordered List:");

            foreach (var item in reorderedList)
            {
                Console.WriteLine(String.Format("{0} {1}", item.ID, item.Type));
            }

            Console.WriteLine("Original List:");

            foreach (var item in myList)
            {
                Console.WriteLine(String.Format("{0} {1}", item.ID, item.Type));
            }

            Console.ReadLine();
        }
    }
}
