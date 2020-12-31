using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarBiding.Core
{
    public class Image
    {
        public int ID { get; set; }
        public string URL { get; set;}

        public Image(string url)
        {
            this.URL = url;
        }

        public Image()
        {

        }
    }

   
}
