using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStoreRevision2020MAY.Models
{
    public class Product
    {
        /// <summary>
        /// Gets or sets the product identifier.
        /// </summary>
        /// <value>
        /// The product identifier.
        /// </value>
        public int ProductID { get; set; }
        public string Name {get; set;}
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }

}
