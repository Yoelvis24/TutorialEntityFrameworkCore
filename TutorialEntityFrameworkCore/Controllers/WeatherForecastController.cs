using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TutorialEntityFrameworkCore.Models;

/*
 //Agregar
using (var context = new SchoolDBContext())
{
    var std = new Student()
    {
        StudentId = 1,
        FirstName = "Bill",
        LastName = "Gates",
        DateOfBirth = DateTime.Now,
        Height = (decimal)1.52,
        Weight = (decimal)110
    };
    context.Students.Add(std);

    // or
    // context.Add<Student>(std);

    context.SaveChanges();
}

//Modificar
using (var context = new SchoolDBContext())
{
    var std = context.Students.Find(1);
    std.FirstName = "Yoe";
    context.SaveChanges();
}

//Eliminar
using (var context = new SchoolDBContext())
{
    var std = context.Students.Find(0);
    context.Students.Remove(std);

    context.SaveChanges();
}
*/

namespace TutorialEntityFrameworkCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
