using PizzaStore.Models;
using System;
using System.Web.Mvc;

namespace PizzaStore.Controllers
{
    public class PizzaController : Controller
    {
        // GET: Pizza
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CalculatePizzas(PizzaViewModel model)
        {
            try
            {
                var result = model.TotalSlices / model.SlicesPerPizza;
            }
            catch(Exception ex)
            {
                // log & swallow
            }

            model.PizzaCount = ProcessCalculation(model.TotalSlices, model.SlicesPerPizza);
            return View("Index", model);
        }

        //[HttpPost]
        //public ActionResult CalculatePizzas(PizzaViewModel model)
        //{
        //    try
        //    {
        //        model.PizzaCount = ProcessCalculation(model.TotalSlices, model.SlicesPerPizza);
        //    }
        //    catch (Exception ex)
        //    {
        //        // log something

        //        throw ex;
        //    }

        //    return View("Index", model);
        //}

        //private decimal ProcessCalculation(int totalSlices, int slicesPerPizza)
        //{
        //    return (decimal)totalSlices / (decimal)slicesPerPizza;
        //}

        //private decimal ProcessCalculation(int totalSlices, int slicesPerPizza)
        //{
        //    try
        //    {
        //        return (decimal)totalSlices / (decimal)slicesPerPizza;
        //    }
        //    catch(Exception ex)
        //    {
        //        // log something
        //        throw;
        //    }            
        //}

        private decimal ProcessCalculation(int totalSlices, int slicesPerPizza)
        {
            if (slicesPerPizza < 1)
            {
                throw new ArgumentException("Slices Per Pizza Can Not Be Less Than One.");
            }

            return (decimal)totalSlices / (decimal)slicesPerPizza;
        }
    }
}
