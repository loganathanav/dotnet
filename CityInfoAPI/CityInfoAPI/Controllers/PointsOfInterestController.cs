﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfoAPI.Controllers
{
    [Route("api/cities")]
    public class PointsOfInterestController:Controller
    {
        [HttpGet("{cityId}/pointsofinterest")]
        public IActionResult GetPointsOfInterests(int cityId)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);

            if(city == null)
            {
                return NotFound();
            }

            return Ok(city.PointsOfInterest);

        }

        [HttpGet("{cityId}/pointsofinterest/{id}")]
        public IActionResult GetPointOfInterest(int cityId, int id)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);

            if (city == null)
            {
                return NotFound();
            }

            var poi = city.PointsOfInterest.FirstOrDefault(c => c.Id == id);

            if (poi == null)
            {
                return NotFound();
            }

            return Ok(poi);
        }
    }
}
