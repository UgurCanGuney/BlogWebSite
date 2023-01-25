using Blog.DAL;
using BlogWebSite.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class MakaleRepository : IRepository<Makale>
    {
        BlogEntities db = new BlogEntities();
        public void Add(Makale entity)
        {
            db.Makaleler.Add(entity);
            db.SaveChanges();
        }

        public bool Delete(Makale entity)
        {
            bool result = true;
            try
            {
                db.Makaleler.Remove(entity);
                db.SaveChanges();
            }
            catch (Exception)
            {

                result = false;
            }
            return result;
        }

        public List<Makale> Listele()
        {
           return db.Makaleler.ToList();
        }

        public bool Update(Makale entity)
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
