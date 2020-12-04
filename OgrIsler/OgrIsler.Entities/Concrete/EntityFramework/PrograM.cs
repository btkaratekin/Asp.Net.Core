using OgrIsler.Core.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OgrIsler.Entities.Concrete.EntityFramework
{
    public class PrograM:IEntity
    {
        [Key, StringLength(3)]
        public string Pkodu { get; set; }
        [Required]
        public string Padi { get; set; }

        public virtual IList<Okul> okullar { get; set; }
        public virtual Bolum Bolumkodu { get; set; }
    }
}
