using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NumericSequenceCalculator_UI.Models;
using NumericSequenceCalculator;

namespace NumericSequenceCalculator_UI.Controllers
{
    public class NumericSequenceController : Controller
    {
        //NumericCalculator numCal = new NumericCalculator();
        private Numbers numCal;
        //
        // GET: /NumericSequence/
        public ActionResult NumericSequenceIndex()
        {
            return View();
        }

        public ActionResult NumericSequenceResult(int num)
        {
            var model = new NumericSequence();
            numCal = new Numbers();
            model.AllNumbers = numCal.getNumberSequence(num);
            numCal = new OddNumbers();
            model.OddNumbers = numCal.getNumberSequence(num);
            numCal = new EvenNumbers();
            model.EvenNumbers = numCal.getNumberSequence(num);
            numCal = new SpecialNumbers();
            model.SpecialNumbers = numCal.getNumberSequence(num);
            numCal = new FibonacceNumbers();
            model.FibonacciNumbers = numCal.getNumberSequence(num);
            return PartialView("NumericSequenceResult", model);
        }
	}
}