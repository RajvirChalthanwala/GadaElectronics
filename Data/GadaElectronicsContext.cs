using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GadaElectronics.Models;

namespace GadaElectronics.Data
{
    public class GadaElectronicsContext : DbContext
    {
        public GadaElectronicsContext(DbContextOptions<GadaElectronicsContext> options)
            : base(options)
        {
        }

        public DbSet<TonyTv> TonyTv { get; set; }
    }
}
