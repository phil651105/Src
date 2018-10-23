﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KKday.Web.B2D.BE.App_Code;
using KKday.Web.B2D.BE.Areas.KKday.Models.DataModel.Account;
using KKday.Web.B2D.BE.Filters;
using KKday.Web.B2D.BE.Models.Model.Account;
using KKday.Web.B2D.BE.Models.Model.Common;
using KKday.Web.B2D.BE.Models.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Resources;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KKday.Web.B2D.BE.Areas.KKday.Controllers
{
    [Area("KKday")]
    [Authorize(Policy = "KKdayOnly")]
    [TypeFilter(typeof(CultureFilter))]
    public class AccountController : Controller
    {
        const int PAGE_SIZE = 1;

        readonly ILocalizer _localizer;

        public AccountController(ILocalizer localizer)
        {
            _localizer = localizer;
        }

        // GET: /<controller>/
        public IActionResult Index(string query)
        { 
            var acctB2dRepos = HttpContext.RequestServices.GetService<B2dAccountRepository>();
            QueryParamsModel queryParams = null;

            if (!string.IsNullOrEmpty(query))
            {
                query = System.Web.HttpUtility.UrlDecode(query).Replace("&quot;", "\"");
                queryParams = JsonConvert.DeserializeObject<QueryParamsModel>(query);
            }
            else
            {
                queryParams = acctB2dRepos.GetQueryParamModel(string.Empty, string.Empty, PAGE_SIZE, 1);
            }

            ViewData["QUERY_PARAMS"] = queryParams;
            ViewData["QUERY_PARAMS_JSON"] = JsonConvert.SerializeObject(queryParams);

            var skip = (queryParams.Paging.current_page - 1) * queryParams.Paging.page_size;
            var _accounts = acctB2dRepos.GetAccounts(queryParams.Filter, skip, queryParams.Paging.page_size, queryParams.Sorting);
             
            return View(_accounts);
        }

        [HttpPost]
        public async System.Threading.Tasks.Task<IActionResult> Refresh([FromBody]QueryParamsModel queryParams)
        {
            Dictionary<string, object> jsonData = new Dictionary<string, object>();

            try
            {
                var acctB2dRepos = (B2dAccountRepository)HttpContext.RequestServices.GetService<B2dAccountRepository>();
                //更新分頁資料
                queryParams = acctB2dRepos.GetQueryParamModel(queryParams.Filter, queryParams.Sorting, PAGE_SIZE, queryParams.Paging.current_page);
                ViewData["QUERY_PARAMS"] = queryParams;

                var skip = (queryParams.Paging.current_page - 1) * queryParams.Paging.page_size;
                var _accounts = acctB2dRepos.GetAccounts(queryParams.Filter, skip, queryParams.Paging.page_size, queryParams.Sorting);
                 
                jsonData["query_params"] = JsonConvert.SerializeObject(queryParams);
                jsonData["content"] = await this.RenderViewAsync<List<B2dAccount>>("AccountList", _accounts, true);
                jsonData["status"] = "OK";
            }
            catch (Exception ex)
            {
                jsonData.Clear();
                jsonData.Add("status", "FAIL");
                jsonData.Add("msg", ex.Message);
            }

            return Json(jsonData);
        }

        public IActionResult Edit(Int64 id)
        {  
            try
            {
                var queryArgc = System.Web.HttpUtility.UrlEncode(this.Request.Query["query"].ToString());
                var acctRepos = HttpContext.RequestServices.GetService<B2dAccountRepository>();
                // var countryRepos = HttpContext.RequestServices.GetService<CountryRepository>();
                B2dAccount _account = acctRepos.GetAccount(id);

                ViewData["QueryParams"] = queryArgc;

                return View(_account);
            }
            catch (Exception ex)
            {
                Website.Instance.logger.FatalFormat("{0},{1}", ex.Message, ex.StackTrace);
                throw ex;
            } 
        }

        [HttpPost]
        public IActionResult Update([FromBody]B2dAccoutUpdModel account)
        {
            Dictionary<string, object> jsonData = new Dictionary<string, object>();

            try
            {
                var acctRepos = HttpContext.RequestServices.GetService<AccountRepository>();
                var upd_user = User.Identities.SelectMany(i => i.Claims.Where(c => c.Type == "Account").Select(c => c.Value)).FirstOrDefault();

                //更新分銷商公司資料
                acctRepos.Update(account, upd_user);
                jsonData["status"] = "OK";
            }
            catch (Exception ex)
            {
                jsonData.Clear();
                jsonData.Add("status", "FAIL");
                jsonData.Add("msg", ex.Message);
            }

            return Json(jsonData);
        }

        /////////////////////////


        #region API User

        // API 使用者
        public IActionResult ApiUser()
        {
            return View();
        }

        #endregion API User

    }
}
