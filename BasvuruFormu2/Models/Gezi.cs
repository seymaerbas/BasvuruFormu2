using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasvuruFormu2.Models
{
    public class Gezi
    {
        public int ID { get; set; }

        public string GeziAdı { get; set; }

        public int SehirID { get; set; }

        public int IlceID { get; set; }

        public bool Status { get; set; } 

    }
}