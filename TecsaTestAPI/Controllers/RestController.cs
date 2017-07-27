using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TecsaTestAPI.Models;

namespace TecsaTestAPI.Controllers
{
    public class RestController : Controller
    {

        [HttpGet]
        public JsonResult userLogin(String userName, String userPassword)
        {
            //IF Username & Password WRONG
            UserLogin failed = new UserLogin()
            {
                status = "failed",
                message = "Username or Password Wrong"

            };

            //IF Username & Password CORRECT
            UserLogin success = new UserLogin()
            {
                status = "success",
                message = "Login Successfully",
                username = userName

            };

            return Json(success, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult barcodeAuthentication(String barcode)
        {
            //IF Barcode WRONG
            Barcode failed = new Barcode()
            {
                status = "failed",
                message = "Barcode is Wrong"

            };

            //IF Barcode CORRECT
            Barcode success = new Barcode()
            {
                status = "success",
                message = "Barcode Available",
                rpo = "rpo",
                barcode = "barcode",
                bincode = "bincode",
                quantity= "quantity",
                item_no = "item_no",
            };

            return Json(success, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public JsonResult updateMobileData(String barcode, String newBinCode, String quantity, String rpo)
        {
            //IF Not Updated
            Barcode failed = new Barcode()
            {
                status = "failed",
                message = "Not Updated"

            };

            //IF Updated
            Barcode success = new Barcode()
            {
                status = "success",
                message = "Updated Successfully",
            };

            return Json(success, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult getBinList()
        {
            //IF Bin code not available in table
            Bincode failed = new Bincode()
            {
                status = "failed",
                message = "Barcode is Wrong"

            };

            //IF Bin code available in table
            var binList = new List<BinData>  
            {  
                new BinData  
                {  
                    bin_id = "1",  
                    bincode = "bincode1",  
                },  
                new BinData  
                {  
                    bin_id = "2",  
                    bincode = "bincode1",  
                },   
                new BinData  
                {  
                    bin_id = "3",  
                    bincode = "bincode1",  
                },  
            };

            return Json(binList, JsonRequestBehavior.AllowGet);
        }

    }
}