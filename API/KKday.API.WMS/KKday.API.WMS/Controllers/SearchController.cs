﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KKday.API.WMS.Models.DataModel.Search;
using KKday.API.WMS.Models.Search;
using Microsoft.AspNetCore.Mvc;
using KKday.API.WMS.Models.Repository;
using KKday.API.WMS.Models.DataModel.Product;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KKday.API.WMS.Controllers {

    [Produces("application/json")]
    [Route("api/[controller]")]
    public class SearchController : Controller {

        [HttpPost]
        public List<ProductBaseModel> GetProd([FromBody]SearchRQModel list_rq) {
            var prod_list = new List<ProductBaseModel>();
            prod_list = ProdRepository.GetProdList(list_rq);

            return prod_list;
<<<<<<< HEAD
        // GET: /<controller>/
        public IActionResult Index() {
            return View();

=======
>>>>>>> nancy_branch
        }

      
    }
}
