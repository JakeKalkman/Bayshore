using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BayshoreCodingChallenges.Models;
using Challenges.Domain.Interfaces;
using System.Net;

namespace BayshoreCodingChallenges.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IExerciseManager _exerciseManager;

        public HomeController(ILogger<HomeController> logger, IExerciseManager exerciseManager)
        {
            _logger = logger;
            _exerciseManager = exerciseManager;
        }

        [HttpGet]
        public IActionResult SolveExerciseSix(string number)
        {
            int intNumber;
            if(int.TryParse(number, out intNumber) && intNumber > 0)
            {
                return Content(_exerciseManager.IsNumberPalidrome(number).ToString());
            }
            else
            {
                return BadRequest("Must be a positive integer");
            }
            
        }

        [HttpGet]
        public IActionResult SolveExerciseThree(int number)
        {
            if (number > 4)
            {
                return Content(_exerciseManager.SpiralMatrixToNumber(number));
            }
            else
            {
                return BadRequest("Must be a positive integer higher than 4");
            }

        }

        public IActionResult Index()
        {
            return View("ExerciseThree");
        }

        public IActionResult ExerciseOne()
        {
            return View();
        }

        public IActionResult ExerciseTwo()
        {
            return View();
        }

        public IActionResult ExerciseThree()
        {
            return View();
        }

        public IActionResult ExerciseFour()
        {
            return View();
        }

        public IActionResult ExerciseFive()
        {
            return View();
        }

        public IActionResult ExerciseSix()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
