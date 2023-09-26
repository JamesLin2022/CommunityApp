using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommunityApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CommunityApp.Data
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Province>().HasData(
                GetProvinces()
            );
            modelBuilder.Entity<City>().HasData(
                GetCities()
            );
        }
        public static List<Province> GetProvinces()
        {
            List<Province> provinces = new List<Province>() {
            new Province() {    // 1
                ProvinceCode="BC",
                ProvinceName="British Columbia",
            },
            new Province() {    // 2
                ProvinceCode="ON",
                ProvinceName="Ontario",
            },
            new Province() {    // 3
                ProvinceCode="QC",
                ProvinceName="Quebec",
            }
        };

            return provinces;
        }

        public static List<City> GetCities()
        {
            List<City> cities = new List<City>() {
            new City {
                CityId = 1,
                CityName = "Vancouver",
                Population = 100000,
                ProvinceCode = "BC",
            },
            new City {
                CityId = 2,
                CityName = "Victoria",
                Population = 10000,
                ProvinceCode = "BC",
            },
            new City {
                CityId = 3,
                CityName = "Kelowna",
                Population = 1000,
                ProvinceCode = "BC",
            },
            new City {
                CityId = 4,
                CityName = "Toronto",
                Population = 100000,
                ProvinceCode = "ON",
            },
            new City {
                CityId = 5,
                CityName = "Hamilton",
                Population = 10000,
                ProvinceCode = "ON",
            },
            new City {
                CityId = 6,
                CityName = "Kitchener",
                Population = 1000,
                ProvinceCode = "ON",
            },
            new City {
                CityId = 7,
                CityName = "Montreal",
                Population = 100000,
                ProvinceCode = "QC",
            },
            new City {
                CityId = 8,
                CityName = "Quebec City",
                Population = 10000,
                ProvinceCode = "QC",
            },
            new City {
                CityId = 9,
                CityName = "Gatineau",
                Population = 1000,
                ProvinceCode = "QC",
            }
        };

            return cities;
        }
    }
}