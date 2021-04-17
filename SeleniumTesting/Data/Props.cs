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
        public static string DbConnectionString = @"Data Source=GREMLIN-HP\SQLEXPRESS;Initial Catalog=CraigslistSelenium;Integrated Security=True";


        public static decimal Price { get; set; }
        public static string Ad { get; set; }

        // Database
        public static int NumberOfSearchItems { get; set; }
        public static List<int> SearchId { get; set; }
        public static List<string> SearchTerm { get; set; }
        public static List<bool> SearchHasImage { get; set; }
        public static List<bool> SearchPostedToday { get; set; }
        public static List<bool> SearchIncludeNearby { get; set; }
        public static List<decimal> SearchMinPrice { get; set; }
        public static List<decimal> SearchMaxPrice { get; set; }


        //public static string  { get; set; }
        //public static string  { get; set; }
        //public static string  { get; set; }
        //public static string  { get; set; }
        //public static string  { get; set; }
        //public static string  { get; set; }
        //public static string  { get; set; }
        //public static string  { get; set; }
        //public static string  { get; set; }




    }
}
