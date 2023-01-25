using BlogWebSite.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DAL
{
   public class BlogEntities:DbContext
    {
        public BlogEntities():base("name=BlogMakaleBaglantisi")
        {
            
        }
        public virtual DbSet<Makale> Makaleler { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        
    }
}
