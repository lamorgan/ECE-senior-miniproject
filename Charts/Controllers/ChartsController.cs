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
            return View( lstModel );
        }
    }
}