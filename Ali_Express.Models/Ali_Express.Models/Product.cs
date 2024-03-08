using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Ali_Express.Models
{
    public class Product:BaseEntity
    {
        
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int StockQuantity { get; set; }
       
        public string Seller { get; set; }
        public string ShippingMethod { get; set; }
        public int ShippingTime { get; set; } // In days
        public string ReturnPolicy { get; set; }
        public string Warranty { get; set; }
        public  ICollection<ProductCategory> ProductCategories { get; set; }

        public  ICollection<Images> Imag { get; set; }
    }
}
