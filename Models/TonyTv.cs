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
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Brand { get; set; }

       
        [Range(1, 3000)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string OriginCountry { get; set; }


        public int SerialNumber { get; set; }

        public string DisplayClearity { get; set; }

        public int Size { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Launch Date")]
        public DateTime LaunchDate { get; set; }
       
        [Range(1, 5)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TvRatings { get; set; }
    }
}
