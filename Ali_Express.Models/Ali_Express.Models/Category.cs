using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ali_Express.Models
{
    public class Category:BaseEntity
    {

       
        public string Name { get; set; }
        public int? ParentCategoryId { get; set; }
        public virtual Category ParentCategory { get; set; }
        public virtual ICollection<Category> Subcategories { get; set; }
        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
