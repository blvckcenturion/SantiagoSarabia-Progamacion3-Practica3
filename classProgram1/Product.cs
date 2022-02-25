using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classProgram1
{
    public enum ProductType
    {
        Libros,
        MaterialOficina,
        MaterialEscolar,
        Pinturas
    }
    public class Product
    {
        public string Name { get; set; }
        public int Qty { get; }
        public ProductType Type { get; }

        public Product(string name, int qty, ProductType type) 
        {
            Name = name;
            Qty = qty;
            Type = type;
        }

    }
}
