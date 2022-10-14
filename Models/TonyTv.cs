using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GadaElectronics.Models
{
    public class TonyTv
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public string OriginCountry { get; set; }
        public int SerialNumber { get; set; }
        public string DisplayClearity { get; set; }
        public int Size { get; set; }
    }
}
