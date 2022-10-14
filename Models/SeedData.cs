using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using GadaElectronics.Data;
using GadaElectronics.Models;

namespace GadaElectronics.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GadaElectronicsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<GadaElectronicsContext>>()))
            {
                // Look for any TV's.
                if (context.TonyTv.Any())
                {
                    return;   // DB has been seeded
                }

                context.TonyTv.AddRange(
                    new TonyTv
                    {
                        Brand = "Samsung",
                        Price = 189.99M,
                        OriginCountry = "North Korea",
                        SerialNumber = 8698456,
                        DisplayClearity = "1440p HD",
                        Size = 41
                    },

                    new TonyTv
                    {
                        Brand = "Sony",
                        Price = 299.99M,
                        OriginCountry = "Japan",
                        SerialNumber = 7664090,
                        DisplayClearity = "1440p, 2110p HD",
                        Size = 52
                    },

                   new TonyTv
                   {
                       Brand = "Tony",
                       Price = 149.99M,
                       OriginCountry = "India",
                       SerialNumber = 1290922,
                       DisplayClearity = "1440p HD",
                       Size = 56
                   },

                    new TonyTv
                    {
                        Brand = "Nokia",
                        Price = 200.99M,
                        OriginCountry = "China",
                        SerialNumber = 3567547,
                        DisplayClearity = "1440p, 2110p HD XHDR",
                        Size = 44
                    },
                    new TonyTv
                    {
                        Brand = "Toshiba",
                        Price = 279.99M,
                        OriginCountry = "India",
                        SerialNumber = 4589364,
                        DisplayClearity = "1440p",
                        Size = 38
                    },
                    new TonyTv
                    {
                        Brand = "Roku",
                        Price = 599.99M,
                        OriginCountry = "Canada",
                        SerialNumber = 8143423,
                        DisplayClearity = "2440p XHDR",
                        Size = 44
                    },
                    new TonyTv
                    {
                        Brand = "Hp",
                        Price = 499.99M,
                        OriginCountry = "North Korea",
                        SerialNumber = 2367854,
                        DisplayClearity = "144p",
                        Size = 76
                    },
                    new TonyTv
                    {
                        Brand = "TCL",
                        Price = 399.99M,
                        OriginCountry = "USA",
                        SerialNumber = 5767568,
                        DisplayClearity = "1440p, 3260p HD",
                        Size = 80
                    },
                    new TonyTv
                    {
                        Brand = "Apple",
                        Price = 1999.99M,
                        OriginCountry = "USA",
                        SerialNumber = 1234567,
                        DisplayClearity = "1440p, 3200p HD XHDR FULL HD",
                        Size = 98
                    },
                    new TonyTv
                    {
                        Brand = "OXL TV",
                        Price = 999.99M,
                        OriginCountry = "China",
                        SerialNumber = 8564323,
                        DisplayClearity = "1260p HD",
                        Size = 39
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
