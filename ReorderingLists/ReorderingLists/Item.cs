using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReorderingLists
{
    public class Item
    {
        /// <summary>
        /// The identifier of the member or measure in this column
        /// </summary>
        public int ID { get; protected set; }

        /// <summary>
        /// The type of item, member or measure, in this column
        /// </summary>
        public Type Type { get; protected set; }

        /// <summary>
        /// Constructs a new column entity
        /// </summary>
        /// <param name="id">The id of the member or measure in this column</param>
        /// <param name="type">The type of item in this column</param>
        public Item(int id, Type type)
        {
            ID = id;
            Type = type;
        }
    }
}
