using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TecsaTestAPI.Models
{
    public class Barcode
    {
        public string status { get; set; }
        public string message { get; set; }
        public string rpo { get; set; }
        public string barcode { get; set; }
        public string bincode { get; set; }
        public string quantity { get; set; }
        public string item_no { get; set; } 
    }
}