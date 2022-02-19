using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shopfront.APIResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopfront.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ControllerBase
    {
        private readonly ILogger<ItemsController> _logger;

        public ItemsController(ILogger<ItemsController> logger)
        {
            _logger = logger;
        }

        [HttpGet("get")]
        public APIResponse<IEnumerable<Item>> GetAllItems()
        {
            var rnd = new Random();
            var results = Enumerable.Range(1, 3).Select(i => new Item
            {
                Name = "Name_" + i.ToString(),
                Description = "Descr_" + i.ToString(),
                Count = (uint)rnd.Next(0, 9999)
            });
            return APIResponse<IEnumerable<Item>>.OK(results);
        }
    }
}
