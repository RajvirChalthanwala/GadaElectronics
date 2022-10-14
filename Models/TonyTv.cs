using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GadaElectronics.Models
{
    public class TonyTv
    {
        public int Id { get; set; }
        [Display(Name = "Brand Name")]
        public string Brand { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public string OriginCountry { get; set; }
        public int SerialNumber { get; set; }
        public string DisplayClearity { get; set; }
        public int Size { get; set; }
        [DataType(DataType.Date)]
        public DateTime LaunchDate { get; set; }

        public int TvRatings { get; set; }
    }
}
