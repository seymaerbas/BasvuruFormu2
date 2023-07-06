using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasvuruFormu2.Models
{
    public class Ilce
    {
        public int ID { get; set; }
        public string IlceAdi { get; set; }
        public int SehirID { get; set; } // Sehir seçimi için eklenen özellik
    }
}