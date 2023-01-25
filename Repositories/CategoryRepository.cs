using Blog.DAL;
using BlogWebSite.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        BlogEntities db = new BlogEntities();
        public void Add(Category entity)
        {
            db.Categories.Add(entity);
            db.SaveChanges();
        }

        public bool Delete(Category entity)
        {
            bool result = true;
            try
            {
                db.Categories.Remove(entity);
                db.SaveChanges();
            }
            catch (Exception)
            {

                result = false;
            }
            return result;
        }

        public List<Category> Listele()
        {
            return db.Categories.ToList();
        }

        public bool Update(Category entity)
        {
            bool result = true;
            try
            {
                db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

            }
            catch (Exception)
            {

                result = false;
            }
            return result;
           
        }
    }
}
