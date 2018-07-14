using FizzBuzz.Models;
using FizzBuzz.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FizzBuzz.Model;

namespace FizzBuzz.Controllers
{
    public class FizzBuzzController : Controller
    {
        // GET: FizzBuzz
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetResult(FizzBuzzVM fizzBuzzEntity)
        {
            FizzBuzzService fizzBuzzService = new FizzBuzzService();
            List<FizzBuzzEntity> lstData = fizzBuzzService.GetData(fizzBuzzEntity.EnterNumber);
            fizzBuzzEntity.FizzBuzzEntitys = lstData;
            return View("Index", fizzBuzzEntity);
        }
    }
}