using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarBiding.DBFakeData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarBiding.Pages
{
    public class CarsModel : PageModel
    {
        private readonly ICarData carData;

        public IEnumerable<Car> Cars { get; set; }

        public CarsModel(ICarData carData)
        {
            this.carData = carData;
        }

        public void OnGet()
        {
            Cars = carData.GetAll();
        }
    }
}
