using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class SubCategory : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Category> SubCategories { get; set; }
    }
}
