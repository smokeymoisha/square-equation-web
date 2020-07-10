using SquareEquation_ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;

namespace SquareEquation_ASP.Controllers
{
    public class SquareEquationController : Controller
    {
        private SquareEquationPresentationManager _manager;

        public SquareEquationController()
        {
            _manager = new SquareEquationPresentationManager();
        }

        // GET: SquareEquation
        public ActionResult Index()
        {
            var equations = _manager.GetAllSquareEquations();

            return View(equations);
        }

        [HttpGet]
        public ActionResult Calculate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Calculate(double a, double b, double c)
        {
            var equation = new SquareEquationViewModel(a, b, c);

            _manager.AddSquareEquation(equation);

            return RedirectToAction("Index");
        }
    }
}