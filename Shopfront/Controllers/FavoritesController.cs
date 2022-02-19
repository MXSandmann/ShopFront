using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shopfront.APIResponses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopfront.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FavoritesController : ControllerBase
    {
        private readonly ILogger<FavoritesController> _logger;

        public FavoritesController(ILogger<FavoritesController> logger)
        {
            _logger = logger;
        }

        [HttpGet("get")]
        public APIResponse<IEnumerable<Favorite>> GetAllFavorites()
        {
            var rnd = new Random();
            var results = Enumerable.Range(1, 3).Select(i => new Favorite
            {
                Name = "Name_" + i.ToString(),
                Description = "Descr_" + i.ToString(),
                Count = (uint)rnd.Next(0, 9999)
            });
            return APIResponse<IEnumerable<Favorite>>.OK(results);
        }
    }
}
