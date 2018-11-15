﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KKday.Web.B2D.EC.AppCode;
using KKday.Web.B2D.EC.Models;
using KKday.Web.B2D.EC.Models.Model.Booking;
using KKday.Web.B2D.EC.Models.Model.Product;
using KKday.Web.B2D.EC.Models.Repostory.Booking;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KKday.Web.B2D.EC.Controllers
{
    public class ErrorController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(ErrorViewModel errorModel)
        {
            distributorInfo fakeContact = DataSettingRepostory.fakeContact();

            //取挖字
            Dictionary<string, string> uikey = RedisHelper.getuiKey(fakeContact.lang);

            ProdTitleModel title = JsonConvert.DeserializeObject<ProdTitleModel>(JsonConvert.SerializeObject(uikey));

            switch(errorModel.ErrorType)
            {
                case ErrorType.Invalid_Market:
                    ViewBag.invalid_info = title.common_invalid_market_title;
                    break;
                case ErrorType.Order_Fail:
                    ViewBag.invalid_info = title.common_invalid_order;
                    break;
                default:
                    ViewBag.invalid_info = title.common_invalid_info;
                    break;
            }
            
            ViewBag.invalid_title = title.common_invalid_title;
            ViewBag.common_more_experiences = title.common_more_experiences;

            return View();
        }
    }
}