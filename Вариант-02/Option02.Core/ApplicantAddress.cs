using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Option02.Core
{
   public class ApplicantAddress
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string Край_Область { get; set; } = "Пермский край";
        public string город { get; set; } = "г.Пермь";
        public string район  { get; set; }






    }
}
