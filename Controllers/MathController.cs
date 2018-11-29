using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MidTermTwo.Models;

namespace MidTermTwo.Controllers
{
    public class MathController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DoCalculation()
        {
            MathOperation model = new MathOperation();

            //ViewData["Message"] = "Sent from DoCalc()";
            return View(model);
        }

        [HttpPost]
        public IActionResult ShowCalculationResults(MathOperation model)
        {
            switch(model.Operator)
            {
                case "+":
                model.Result = model.LeftOperand + model.RightOperand;
                break;

                case "-":
                model.Result = model.LeftOperand - model.RightOperand;
                break;

                case "*":
                model.Result = model.LeftOperand * model.RightOperand;
                break;

                case "/":
                model.Result = model.LeftOperand / model.RightOperand;
                break;

                default:
                ViewData["Message"] = "Incorrect Operator";
                break;
            }
            return View(model);
        }


    }
}