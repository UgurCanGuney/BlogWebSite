using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite.Entities
{
   public class Category
    {
        public Category()
        {
            Makales = new HashSet<Makale>();
        }
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<Makale> Makales { get; set; }
    }
}
