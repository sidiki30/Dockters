using DocktersApi.Models;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using WebAPI.Models;
using System.Text;
using System.Linq;
using System.Globalization;

namespace DocktersApi.Controllers
{
    public class HomeController : Controller
    {

        private readonly IPatientRepository _repository;

        public HomeController(IPatientRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            IEnumerable<PatientDataItem> patients =  _repository.AllItems;

            //var a = "";
            //foreach (var patient in patients)
            //{
            //    a += patient.Name + ", ";
            //}

            //ViewBag.Message = a;

            ViewBag.Measurements = patients.First().Measurements;

            return View(patients);
        }
    }
}