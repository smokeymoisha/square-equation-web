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
        public ActionResult Calculate(SquareEquationViewModel eqt)
        {
            eqt.Discriminant = eqt.GetDiscriminant();
            eqt.X1 = eqt.GetFirstRoot();
            eqt.X2 = eqt.GetSecondRoot();

            _manager.AddSquareEquation(eqt);

            return View("Result", eqt);
        }
    }
}