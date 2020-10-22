using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarineLife.Services;
using MarineLife.Services.HttpClients;
using MarineLife.Services.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MarineLife.Web.Controllers
{
    [ApiController]
    [Route("fish/info")]
    public class FishInfoController : ControllerBase
    {
        private readonly IFishHttpClient _fishHttpClient;
        public FishInfoController(IFishHttpClient fishHttpClient)
        {
            _fishHttpClient = fishHttpClient;
        }

        [HttpGet]
        public IActionResult GetFishInfo([FromQuery]string species, string genus)
        {
            var fish =  _fishHttpClient.GetFishInfo(species, genus);
            
            var marineLifeFish = new MarineLifeFish()
            {
                CommonName = fish.Data.FirstOrDefault().FBname,
                Genus = fish.Data.FirstOrDefault().Genus,
                Species = fish.Data.FirstOrDefault().Species,
                ImageUrl =  fish.Data.FirstOrDefault().Image.ToString()
            };
            
            return Ok(marineLifeFish);
        }
    }
}