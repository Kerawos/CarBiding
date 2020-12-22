using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarBiding.Pages
{
    public class DetailModel : PageModel
    {
        public Car Car { get; set; }

        public void OnGet()
        {

        }
    }
}
