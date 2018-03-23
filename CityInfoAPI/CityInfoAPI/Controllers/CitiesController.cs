﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfoAPI.Controllers
{
    //[Route("api/cities")]
    [Route("api/[controller]")]
    public class CitiesController: Controller
    {
        [HttpGet()]
        public IActionResult GetCities()
        {
            //return new JsonResult(new List<Object>()
            //{
            //    new {id=1, Name="Chennai" },
            //    new {id=2, Name="Thanjavur"}
            //});

            //return new JsonResult(CitiesDataStore.Current.Cities);

            return Ok(CitiesDataStore.Current.Cities);
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {
            var cityToReturn = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);
            if(cityToReturn ==null)
            {
                return NotFound();
            }
            return Ok(cityToReturn);
        }
    }
}