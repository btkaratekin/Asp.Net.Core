using OgrIsler.Core.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OgrIsler.Entities.Concrete.EntityFramework
{
   public class Bolum:IEntity
    {
        [Key, StringLength(3)]
        public string Bkodu { get; set; }
        [Required]
        public string Badi { get; set; }

        public virtual IList<PrograM> programlar { get; set; }
        public virtual IList<Danisman> danismanlar { get; set; }
    }
}
