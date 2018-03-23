using CityInfoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfoAPI
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public List<CityDto> Cities { get; set; }
        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id=1,
                    Name="Chennai",
                    Description="Tamilnadu's capital city",
                    PointsOfInterest =new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id=1,
                            Name="Merina",
                            Description="Merina is largest beach in asia"
                        },
                        new PointOfInterestDto()
                        {
                            Id=2,
                            Name="St. George Fort",
                            Description="Secretariat"
                        }
                    }
                },
                new CityDto()
                {
                    Id=2,
                    Name="Thanjavur",
                    Description="My native city"
                },
                new CityDto()
                {
                    Id=3,
                    Name="Pudukkottai",
                    Description="Nearby city"
                }
            };
        }
    }
}
