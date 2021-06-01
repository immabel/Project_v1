using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_v1
{
    public class Product
    {
        public readonly int id;
        public string Name { get; protected set; }
        public string Type { get; protected set; }
        public string Description { get; protected set; }

        public Product(
            string name,
            string type, 
            string description)
        {
            Name = name;
            Type = type;
            Description = description;
        }

        public override string ToString() => Name;
    }
}
