using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public int SubCategoryID { get; set; }
        public SubCategory SubCategories { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
