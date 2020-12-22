using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarBiding.DBFakeData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarBiding.Pages
{
    public class DetailModel : PageModel
    {
        public Car Car { get; set; }
        private readonly ICarData CarData;

        public DetailModel(ICarData carData)
        {
            CarData = carData;
        }

        public void OnGet(int carID)
        {
            Car = CarData.GetByID(carID);
        }
    }
}
