using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BasvuruFormu2.Models
{
    public class Form
    {
        [Key]
        public int ID { get; set; }
        public string Ad { get; set; }
        public string TelefonNo { get; set; }
        public string Eposta { get; set; }
        public DateTimeOffset DogumTarihi { get; set; }

        public int GeziID { get; set; }

        [Required]
        [StringLength(11)]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "Geçerli bir TC kimlik numarası giriniz.")]
        [Display(Name = "TC")]
        public string TC { get; set; }

        [NotMapped]
        public string UniqueTC { get; set; }
       
    }
}