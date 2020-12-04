using OgrIsler.Core.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OgrIsler.Entities.Concrete.EntityFramework
{
    public class Bilgi:IEntity
    {
        [Required, StringLength(9), Key]
        public string OgrNo { get; set; }
        [Required, StringLength(15)]
        public string Adi { get; set; }
        [Required, StringLength(20)]
        public string Soyadi { get; set; }
        [Required]
        public bool Cinsiyet { get; set; }
        [Required]
        public DateTime Dtarih { get; set; }

        public virtual Okul okul { get; set; }
    }
}
