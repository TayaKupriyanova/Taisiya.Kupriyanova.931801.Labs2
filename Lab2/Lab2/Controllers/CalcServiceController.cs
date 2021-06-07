using System;
using lab2.Models;
using Microsoft.AspNetCore.Mvc;



namespace lab2.Controllers {
    public class CalcServiceController : Controller {

        public IActionResult Index() {
            return View();
        }



        public IActionResult ManualParsingSingle() {
            if (Request.Method == "POST")
            {
                try
                {
                    var calc = new CalcModel
                    {
                        X = Int32.Parse(HttpContext.Request.Form["x"]),
                        Operation = HttpContext.Request.Form["operation"],
                        Y = Int32.Parse(HttpContext.Request.Form["y"])
                    };

                    ViewBag.Result = calc.Calc();
                }
                catch
                {
                    ViewBag.Result = "Invalid input";
                }

                return View("Result");
            }
            return View("Okoshko");
        }



        [HttpGet]
        [ActionName("ManualParsingSeparate")]
        public IActionResult ManualParsingSeparateGet()
        {
            return View("Okoshko");
        }
        [HttpPost]
        [ActionName("ManualParsingSeparate")]
        public IActionResult ManualParsingSeparatePost() {
            try
            {
                var calc = new CalcModel
                {
                    X = Int32.Parse(HttpContext.Request.Form["x"]),
                    Operation = HttpContext.Request.Form["operation"],
                    Y = Int32.Parse(HttpContext.Request.Form["y"])
                };

                ViewBag.Result = calc.Calc();
            }
            catch
            {
                ViewBag.Result = "Invalid input";
            }

            return View("Result");
        }



        [HttpGet]
        public IActionResult ModelBindingParameters()
        {
            return View("Okoshko");
        }
        [HttpPost]
        public IActionResult ModelBindingParameters(int x, string operation, int y)
        {
            if (ModelState.IsValid)
            {
                var calc = new CalcModel
                {
                    X = x,
                    Operation = operation,
                    Y = y
                };
                ViewBag.Result = calc.Calc();
            }
            else
            {
                ViewBag.Result = "Invalid input";
            }

            return View("Result");
        }



        [HttpGet]
        public IActionResult ModelBindingSeparate()
        {
            return View("Okoshko");
        }
        [HttpPost]
        public IActionResult ModelBindingSeparate(CalcModel model)
        {
            ViewBag.Result = ModelState.IsValid
                ? model.Calc()
                : "Invalid input";

            return View("Result");
        }
    }
}
