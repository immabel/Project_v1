using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_v1
{
    public class Prescription
    {
        public readonly int id;
        private List<Product> products = new List<Product>();
        public string Description { get; protected set; }

        public Prescription(
            int id,
            List<Product> products,
            string description = "")
        {
            this.id = id;
            this.products = products;
            Description = description;
        }

        public string GetProductsInfo() => string.Join(", ", products.Select(prod => prod.ToString()));
        public void GetInfo() => Console.WriteLine(ToString());
        public override string ToString() => $"---Prescription Info---\nID: {id}\nProducts: {GetProductsInfo()}\nDescription: {Description}";

        public static Prescription operator +(Prescription p, Product product)
        {
            if (p.products.Contains(product))
                return p;
            p.products.Add(product);
            return p;
        }

        public static Prescription operator -(Prescription p, Product product)
        {
            if (p.products.Contains(product))
                p.products.Remove(product);
            return p;
        }
    }
}
