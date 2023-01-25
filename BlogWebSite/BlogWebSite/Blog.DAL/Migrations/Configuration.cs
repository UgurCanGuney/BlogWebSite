namespace Blog.DAL.Migrations
{
    using BlogWebSite.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Blog.DAL.BlogEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Blog.DAL.BlogEntities context)
        {
            var categories = new List<Category>()
            {
                new Category{CategoryName="Kültür"},
                new Category{CategoryName="Sanat"},
                new Category{CategoryName="Bilim"},
                new Category{CategoryName="Spor"},
                new Category{CategoryName="Müzik"},
                new Category{CategoryName="Gezi"},
                new Category{CategoryName="Diğer"},
            };
            context.Categories.AddRange(categories);


            ICollection<Makale> makales = new List<Makale>()
            {
                new Makale {CategoryId=2,MakaleBaslik="Kültürlü Bir Yazı",
                    Icerik="Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.",
                Tarih=new DateTime (2020,3,10),Yazar="Cem Taş"
                },
                new Makale {CategoryId=4,MakaleBaslik="Vay Anam",
                    Icerik="Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat lmuştur.",
                Tarih=new DateTime (2020,3,12),Yazar="Deniz Yaman"
                },
                new Makale {CategoryId=6,MakaleBaslik="Vay Babam",
                    Icerik="Lorem Ipsum, dizgi ve baskı endüstrisinde kull bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.",
                Tarih=new DateTime (2020,3,16),Yazar="Ahmet Ateş"
                },
                new Makale {CategoryId=3,MakaleBaslik="Yok Böylesi...",
                    Icerik="Lorem Ipsum, dizgi ve baskı endüstrisinde kull bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri.",
                Tarih=new DateTime (2020,3,17),Yazar="Can Taş"
                }
            };
            context.Makaleler.AddRange(makales);

        }
    }
}
