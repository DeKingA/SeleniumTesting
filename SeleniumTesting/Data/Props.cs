using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTesting.Data
{
    public static class Props
    {
        // app.config has been depricated
        public static string CraigslistUrl = "https://bellingham.craigslist.org/";

        public static decimal Price { get; set; }
        public static string Ad { get; set; }


    }
}
