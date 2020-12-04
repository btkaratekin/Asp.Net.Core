using OgrIsler.Core.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OgrIsler.Entities.Concrete.EntityFramework
{
   public class Danisman:IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Dkodu { get; set; }
        [Required, StringLength(15)]
        public string Dadi { get; set; }
        [Required, StringLength(20)]
        public string Dsoyadi { get; set; }

        public virtual IList<Okul> okullar { get; set; }
        public virtual Bolum Bolumkodu { get; set; }
    }
}
