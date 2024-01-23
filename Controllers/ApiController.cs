using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.EFModels;

namespace WebApplication1.Controllers
{
    public class ApiController : Controller
    {
        private readonly myDbContext _dbContext;

        public ApiController(myDbContext context)

        {

            _dbContext = context;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cities()
        {
            var cities = _dbContext.Addresses.Select(a => a.City).Distinct();
            return Json(cities);
        }
    }
}
