using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.ViewModels;

namespace Web.Controllers
{
    public class ConverterController : Controller
    {
        // GET: Converter
        public ActionResult Index()
        {
            var viewModel = new Web.ViewModels.Converter.IndexViewModel ();
            //initialize view model drop down item selected
            viewModel.ViewConvertSelect = "Temperature";
            return View(viewModel);
        }

        // GET: Converter/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Converter/Create
        public ActionResult Create()
        {
            return View();
        }

        // I added this Action Method on Index Post
        // POST: Converter
        [HttpPost]
        public ActionResult Index(Web.ViewModels.Converter.IndexViewModel model)
        {
            //if (!ModelState.IsValid)
            //{
        
            //    return View(model); // returns the view with errors
            //}
            //if (!String.IsNullOrEmpty(model.InputCelcius))
            try
            {
                var results = new Converter.Conversions();

                if (model.ViewConvertDirection == "LeftToRight")
                    
                //if (model.ViewConvertFrom > 0)
                {
                    switch (model.ViewConvertSelect)
                    {
                        case "Temperature":
                            model.ViewConvertTo = results.getFahrenheitFromCelcius(model.ViewConvertFrom);
                            break;
                        case "Volume":
                            model.ViewConvertTo = results.getGallonsFromLiters(model.ViewConvertFrom);
                            break;
                        case "Weight":
                            model.ViewConvertTo = results.getPoundsFromKilograms(model.ViewConvertFrom);
                            break;
                        default:
                            break;
                    }
                }
                else
                //if (model.ViewConvertTo > 0)
                if (model.ViewConvertDirection == "RightToLeft")
                    {

                    switch (model.ViewConvertSelect)
                    {
                        case "Temperature":
                            model.ViewConvertFrom = results.getCelciusFromFahrenheit(model.ViewConvertTo);
                            break;
                        case "Volume":
                            model.ViewConvertFrom = results.getLitersFromGallons(model.ViewConvertTo);
                            break;
                        case "Weight":
                            model.ViewConvertFrom = results.getKilogramsFromPounds(model.ViewConvertTo);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch
            {
                return View(model);
            }
            finally
            {
                
            }

            //the next statement makes sure you post new information to the view
            ModelState.Clear();

            return View(model);
        }

        // POST: Converter/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Converter/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Converter/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Converter/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Converter/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
