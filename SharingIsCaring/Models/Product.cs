using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharingIsCaring.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Phonenumber { get; set; }
        public string Localization { get; set; }
        public int Type { get; set; }
        public string Description { get; set; }
        public string  ProductName { get; set; }
        public string Img { get; set; }

    }
}
