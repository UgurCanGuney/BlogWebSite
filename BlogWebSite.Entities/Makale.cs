using DocumentFormat.OpenXml.Drawing.ChartDrawing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebSite.Entities
{
    public class Makale
    {
        public int Id { get; set; }
        public string MakaleBaslik { get; set; }
        public string Icerik { get; set; }
        public string Yazar { get; set; }
        public DateTime Tarih { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
