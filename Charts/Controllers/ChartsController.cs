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
            string t;
            string h;
            int i = 0;
            var lstModel = new List<SimpleReportViewModel>();
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\David\Documents\mini-proj\Articles-master\Charts\Charts\Views\Charts\Temp.txt");
            System.IO.StreamReader file2 = new System.IO.StreamReader(@"C:\Users\David\Documents\mini-proj\Articles-master\Charts\Charts\Views\Charts\Humidity.txt");

            while (((t = file.ReadLine()) != null) && ((h = file2.ReadLine()) != null))
            {
                lstModel.Add(new SimpleReportViewModel
                {
                    Day = i,
                    Temp = Convert.ToInt32(t),
                    Humidity = Convert.ToInt32(h)
                });
                i++;
            }
            /*lstModel.Add( new SimpleReportViewModel
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
            } ); */
            return View( lstModel );
        }
    }
}