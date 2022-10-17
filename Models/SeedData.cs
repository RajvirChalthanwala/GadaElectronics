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
                        Size = 41,
                        LaunchDate = DateTime.Parse("2021-10-15"),
                        TvRatings = 4.5M
                    },

                    new TonyTv
                    {
                        Brand = "Sony",
                        Price = 299.99M,
                        OriginCountry = "Japan",
                        SerialNumber = 7664090,
                        DisplayClearity = "1440p, 2110p HD",
                        Size = 52,
                        LaunchDate = DateTime.Parse("2017-08-18"),
                        TvRatings = 4.0M
                    },

                   new TonyTv
                   {
                       Brand = "Tony",
                       Price = 149.99M,
                       OriginCountry = "India",
                       SerialNumber = 1290922,
                       DisplayClearity = "1440p HD",
                       Size = 56,
                       LaunchDate = DateTime.Parse("2015-10-23"),
                       TvRatings = 5.0M
                   },

                    new TonyTv
                    {
                        Brand = "Nokia",
                        Price = 200.99M,
                        OriginCountry = "China",
                        SerialNumber = 3567547,
                        DisplayClearity = "1440p, 2110p HD XHDR",
                        Size = 44,
                        LaunchDate = DateTime.Parse("2012-10-13"),
                        TvRatings = 3.5M
                    },
                    new TonyTv
                    {
                        Brand = "Toshiba",
                        Price = 279.99M,
                        OriginCountry = "India",
                        SerialNumber = 4589364,
                        DisplayClearity = "1440p",
                        Size = 38,
                        LaunchDate = DateTime.Parse("2022-01-13"),
                        TvRatings = 3.0M
                    },
                    new TonyTv
                    {
                        Brand = "Roku",
                        Price = 599.99M,
                        OriginCountry = "Canada",
                        SerialNumber = 8143423,
                        DisplayClearity = "2440p XHDR",
                        Size = 44,
                        LaunchDate = DateTime.Parse("2004-10-13"),
                        TvRatings = 2.5M
                    },
                    new TonyTv
                    {
                        Brand = "Hp",
                        Price = 499.99M,
                        OriginCountry = "North Korea",
                        SerialNumber = 2367854,
                        DisplayClearity = "144p",
                        Size = 76,
                        LaunchDate = DateTime.Parse("2019-10-18"),
                        TvRatings = 5.0M
                    },
                    new TonyTv
                    {
                        Brand = "TCL",
                        Price = 399.99M,
                        OriginCountry = "USA",
                        SerialNumber = 5767568,
                        DisplayClearity = "1440p, 3260p HD",
                        Size = 80,
                        LaunchDate = DateTime.Parse("2020-11-13"),
                        TvRatings = 3.5M
                    },
                    new TonyTv
                    {
                        Brand = "Apple",
                        Price = 1999.99M,
                        OriginCountry = "USA",
                        SerialNumber = 1234567,
                        DisplayClearity = "1440p, 3200p HD XHDR FULL HD",
                        Size = 98,
                        LaunchDate = DateTime.Parse("2002-10-13"),
                        TvRatings = 1.0M
                    },
                    new TonyTv
                    {
                        Brand = "OXL TV",
                        Price = 999.99M,
                        OriginCountry = "China",
                        SerialNumber = 8564323,
                        DisplayClearity = "1260p HD",
                        Size = 39,
                        LaunchDate = DateTime.Parse("2022-12-13"),
                        TvRatings = 4.0M
                    },
                    new TonyTv
                    {
                        Brand = "Phillips",
                        Price = 1080.99M,
                        OriginCountry = "Canada",
                        SerialNumber = 3564767,
                        DisplayClearity = "720p HDR",
                        Size = 41,
                        LaunchDate = DateTime.Parse("2022-10-13"),
                        TvRatings = 4.5M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
