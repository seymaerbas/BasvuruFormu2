using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BasvuruFormu2.Models
{
    public class Context : DbContext
    {
        public DbSet<Form> Formlar { get; set; }
        public DbSet<Gezi> Geziler { get; set; }
        public DbSet<Sehir> Sehirler { get; set; }
        public DbSet<Ilce> Ilceler { get; set; }
    }
}