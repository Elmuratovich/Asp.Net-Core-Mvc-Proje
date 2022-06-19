using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjeCore.Models
{
    public class Birim
    {
        [Key]
        public int BirimID { get; set; }
        public string BirimAd { get; set; }

        public List<Personel> Personels { get; set; }
    }
}
