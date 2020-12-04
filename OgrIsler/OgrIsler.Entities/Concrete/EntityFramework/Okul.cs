using OgrIsler.Core.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OgrIsler.Entities.Concrete.EntityFramework
{
   public class Okul:IEntity
    {
        [Required, StringLength(9), Key]
        public string OgrNo { get; set; }

        [Required]
        public byte Sinif { get; set; }

        public virtual Bilgi bilgi { get; set; }
        public virtual PrograM Programkodu { get; set; }
        public virtual Danisman Danismankodu { get; set; }
    }
}
