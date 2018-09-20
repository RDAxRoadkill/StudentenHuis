using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudHuis.Models;
using Microsoft.AspNetCore.Authorization;

namespace StudHuis.Controllers
{
    public class MealController : Controller
    {
        private IMealRepository repository;

        public MealController(IMealRepository repo)
        {
            repository = repo;
        }

        public ViewResult List() => View(repository.Meals);

        [Authorize]
        public ViewResult JoinMeal()
        {
            return View();
        }
    }
}