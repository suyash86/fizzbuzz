using FizzBuzz.Models;
using System.Collections.Generic;
using System.Web.Mvc;
using FizzBuzz.Model;
using FizzBuzz.Service.Interface;

namespace FizzBuzz.Controllers
{
    public class FizzBuzzController : Controller
    {
        private readonly IFizzBuzzService _fizzBuzzService;

        public FizzBuzzController(IFizzBuzzService fizzBuzzService)
        {
            _fizzBuzzService = fizzBuzzService;
        }

        // GET: FizzBuzz
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetResult(FizzBuzzVM fizzBuzzEntity)
        {
            List<FizzBuzzEntity> lstData = _fizzBuzzService.GetData(fizzBuzzEntity.EnterNumber);
            fizzBuzzEntity.FizzBuzzEntitys = lstData;
            return View("Index", fizzBuzzEntity);
        }
    }
}