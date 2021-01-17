using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityFrameworkDemo
{
    public class ProductDal
    {
        //GetAll veri tabanından verileri çekip listeye dönüştürme işlemi gerçekleştirmektedir
        public List<Product> GellAll()
        {
            using (ETradeContext context = new ETradeContext()) // ETradeContext pahalı bir nesne olduğundan using kullanarak onunla işimiz bittiğinde nesneyi zorla bellekten atıyoruz
            {
                return context.Products.ToList();
            }
        }

        public void Add(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                context.Products.Add(product); //context deki products a product ekle
                context.SaveChanges(); //veri tabanına yaz
            }
        }

        public void Update(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product); //uygulamadan girdi olarak gönderdiğimiz product ı veri tabanındakiyle eşitliyor
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
