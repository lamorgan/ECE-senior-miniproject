using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Charts.Models;
using Microsoft.AspNetCore.Mvc;

namespace Charts.Controllers
{
    public class ChartsController : Controller
    {
        private Random rnd = new Random();

        public IActionResult Line()
        {
            var lstModel = new List<SimpleReportViewModel>();
           lstModel.Add( new SimpleReportViewModel
            {
                Day = 1,
                Temp = 87,
                Humidity = 30
            } );
            lstModel.Add( new SimpleReportViewModel
            {
                Day = 2,
                Temp = 72,
                Humidity = 10
            } );
            lstModel.Add( new SimpleReportViewModel
            {
                Day = 3,
                Temp = 98,
                Humidity = 70
            } );
            lstModel.Add( new SimpleReportViewModel
            {
                Day = 4,
                Temp = 80,
                Humidity = 30
            } );
            lstModel.Add( new SimpleReportViewModel
            {
                Day = 5,
                Temp = 62,
                Humidity = 20
            } );
            lstModel.Add( new SimpleReportViewModel
            {
                Day = 6,
                Temp = 89,
                Humidity = 80
            } );
            return View( lstModel );
        }
    }
}