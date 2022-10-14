using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GadaElectronics.Models
{
    public class TonyTvCountryViewModel
    {
        public List<TonyTv> TonyTvs { get; set; }
        public SelectList OriginCountry { get; set; }
        public string TonyTvCountry { get; set; }
        public string SearchString { get; set; }
    }
}
