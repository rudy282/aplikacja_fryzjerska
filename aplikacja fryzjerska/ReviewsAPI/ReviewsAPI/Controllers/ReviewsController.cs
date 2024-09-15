using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ReviewsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var reviews = new[]
            {
                new Review { Author = "Wacław Domański", Description = "Świetny fryzjer, dobra robota", Stars = 5 },
                new Review { Author = "Alicja Wyszkowska", Description = "Elegancka atmosfera", Stars = 5 },
                new Review { Author = "Kuba", Description = "Pani była nie miła, ale zna się na fachu", Stars = 3 },
                new Review { Author = "Emilja Dostojewska", Description = "Ok.", Stars = 4 },
                new Review { Author = "Sara Malewska", Description = "Świetny fryzjer, tylko dla żartu mnie na rudo przemalował", Stars = 1 }
            };

            return Ok(reviews);
        }
    }
}
