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
        
        [BindProperty (SupportsGet = true)]
        public string SearchTerm { get; set;}

        public CarsModel(ICarData carData)
        {
            this.carData = carData;
        }

        public void OnGet()
        {
            //if (string.IsNullOrEmpty(searchTerm))
            //Cars = carData.GetAll();
            Cars = carData.GetAllByName(SearchTerm);
        }
    }
}
