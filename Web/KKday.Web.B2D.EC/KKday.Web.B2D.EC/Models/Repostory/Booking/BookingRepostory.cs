﻿using System;
using KKday.Web.B2D.EC.Models.Model.Product;
using System.Linq;
using System.Collections.Generic;
using KKday.Web.B2D.EC.AppCode;
using KKday.Web.B2D.EC.Models.Model.Booking;
using KKday.Web.B2D.EC.Models.Model.Pmch;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace KKday.Web.B2D.EC.Models.Repostory.Booking
{
    public static class BookingRepostory
    {

        public static DataModel setDefaultBookingInfo(DataModel data ,ProductModel prod, PkgDetailModel pkg, confirmPkgInfo confirm, distributorInfo distributor)
        {
            data.productOid = confirm.prodOid;
            data.packageOid = confirm.pkgOid;
            data.contactFirstname = distributor.firstName;
            data.contactLastname = distributor.lastName;
            data.contactEmail = distributor.email;
            data.telCountryCd = distributor.areatel;
            data.contactTel = distributor.tel;
            data.contactCountryCd = distributor.countryCd;
            data.lstGoDt = confirm.selDate;
            if (confirm.pkgEvent != null) data.eventOid = confirm.pkgEvent;

            data.price1Qty = confirm.price1Qty;
            data.price2Qty = confirm.price2Qty == null ? 0 : confirm.price2Qty;
            data.price3Qty = confirm.price3Qty==null?0: confirm.price3Qty;
            data.price4Qty = confirm.price4Qty == null ? 0 : confirm.price4Qty;
            data.payMethod = "ONLINE_CITI";//這個地方接pmch要改
            data.hasRank = pkg.is_unit_pirce == "RANK" ? "Y" : "N";
            //data.productUrlOid = 
            data.productName = prod.prod_name;
            string[] citys = new string[prod.countries[0].cities.Count];

            int i = 0;
            foreach(City c in prod.countries[0].cities)
            {
                citys[i] = c.id;
                i++;
            }

            data.productCity = citys;
            data.productCountry = prod.countries[0].id;
            data.productMainCat = prod.prod_type;
            data.productOrderHandler = prod.prod_hander;
            data.payPmchOid = "1";
            data.currency = distributor.currency;
            //先接直客價!!
            data.currPriceTotal = ((pkg.price1_b2c * confirm.price1Qty)+ (pkg.price2_b2c * confirm.price2Qty) + (pkg.price3_b2c * confirm.price3Qty) + (pkg.price4_b2c * confirm.price4Qty));// 263;// (pkg.price1 * confirm.price1Qty) +(pkg.price2 * confirm.price2Qty) +(pkg.price3 * confirm.price3Qty) + (pkg.price4 * confirm.price4Qty);
            data.crtDevice = "Macintosh";
            data.crtBrowser = "Safari";
            data.crtBrowserVersion = "12.0";
            data.memberUuid = "051794b8-db2a-4fe7-939f-31ab1ee2c719";
            data.riskStatus = "01";
            data.tokenKey = "897af29c45ed180451c2e6bfa81333b6";
            data.deviceId = "3c2ab71448224d1d7148350f7972e96e";
            data.multipricePlatform = "01";
            data.sourceCode = "WEB";
            data.sourceParam1 = "";
            data.allowedCardNumberArray = new string[]{};

            //senddata
            data.modules.sendData.moduleData.receiverTel.telCountryCode = distributor.areatel;
            data.modules.sendData.moduleData.receiverTel.telNumber = distributor.tel;

            //contact
            data.modules.contactData.moduleData.contactTel.telCountryCode = distributor.areatel;

            //rendCar 寫在 js

            return data;

        }


        public static PmchSslRequest setPaymentInfo(ProductModel prod,OrderModel orderModel,string orderMid)
        {
            PmchSslRequest pmch = new PmchSslRequest();

            pmch.apiKey = "kkdayapi";
            pmch.userOid = "1";
            pmch.ver = "1.0.1";
            pmch.ipaddress = "127.0.0.1";

            CallJsonPay json = new CallJsonPay();

            json.pmchOid = orderModel.payPmchOid;
            json.is3D = "0";
            json.payCurrency = orderModel.currency;
            json.payAmount = Convert.ToDouble(orderModel.currPriceTotal) ;
            json.returnURL = "https://localhost:5001/Final/Success/"+orderMid;
            json.cancelURL = "https://localhost:5001/Final/Cancel/"+orderMid;
            json.userLocale = "zh-tw";
            json.paymentParam1 = "";
            json.paymentParam2 = "";

            PaymentSourceInfo pay = new PaymentSourceInfo();
            pay.sourceType = "KKDAY";
            pay.orderMid = orderMid;

            json.paymentSourceInfo = pay;

            CreditCardInfo credit = new CreditCardInfo();
            credit.cardHolder = "phil";
            credit.cardNo = GibberishAES.OpenSSLEncrypt("4093240835103617", "card%no$kk#@");
            credit.cardType = "VISA";
            credit.cardCvv = "143";
            credit.cardExp = "202310";

            json.creditCardInfo = credit;

            PayerInfo payer = new PayerInfo();
            payer.firstName = "ming";
            payer.lastName = "chen";
            payer.phone = "0939650222";
            payer.email = "phil.chang@kkday.com";

            json.payerInfo = payer;

            PayProductInfo prodInfo = new PayProductInfo();
            prodInfo.prodName = prod.prod_name;
            prodInfo.prodOid = prod.prod_no.ToString();

            json.productInfo = prodInfo;

            PayMember member = new PayMember();
            member.memberUuid = orderModel.memberUuid;
            member.riskStatus = "01";

            json.member = member;
            pmch.json = json;

            return pmch;// JsonConvert.SerializeObject(pmch);
        }

        //新版
        public static PmchSslRequest3 setPaymentInfo2(ProductModel prod, OrderModel orderModel, string orderMid)
        {
            PmchSslRequest3 pmch = new PmchSslRequest3();

            pmch.api_key = "kkdayapi";
            pmch.user_oid = "1";
            pmch.ver = "1.0.1";
            pmch.lang_code = "zh-tw";
            pmch.ipaddress = "127.0.0.1";

            CallJsonPay2 json = new CallJsonPay2();

            json.pmch_oid = orderModel.payPmchOid;
            json.is_3d = "0";
            json.pay_currency = orderModel.currency;
            json.pay_amount = Convert.ToDouble(orderModel.currPriceTotal);
            json.return_url = "https://localhost:5001/Final/Success/" + orderMid;
            json.cancel_url = "https://localhost:5001/Final/Cancel/" + orderMid;
            json.user_locale = "zh-tw";
            json.paymentParam1 = "";
            json.paymentParam2 = "";

            if (prod.img_list.Count > 0)
            {
                json.logo_url = "https://img.sit.kkday.com" + prod.img_list[0].img_kkday_url;
            }
            else
            {
                json.logo_url = "";
            }


            payment_source_info pay = new payment_source_info();
            pay.source_type = "KKDAY";
            pay.order_mid = orderMid;

            json.payment_source_info = pay;

            credit_card_info credit = new credit_card_info();
            credit.card_holder = "phil";
            credit.card_no = GibberishAES.OpenSSLEncrypt("4095296335832921", "card%no$kk#@");
            credit.card_type = "VISA";
            credit.card_cvv = "133";
            credit.card_exp = "202312";

            json.credit_card_info = credit;

            payer_info payer = new payer_info();
            payer.first_name = "ming";
            payer.last_name = "chen";
            payer.phone = "0939650222";
            payer.email = "phil.chang@kkday.com";

            json.payer_info = payer;

            product_info prodInfo = new product_info();
            prodInfo.prod_name = prod.prod_name;
            prodInfo.prod_oid = prod.prod_no.ToString();

            json.product_info = prodInfo;

            member member = new member();
            member.member_uuid = orderModel.memberUuid;
            member.risk_status = "01";
            member.ip = "127.0.0.1";

            json.member = member;
            pmch.json = json;

            return pmch;// JsonConvert.SerializeObject(pmch);
        }


        public static void setPayDtltoRedis(OrderModel orderModel ,string orderMid,string memUuid)
        {
            PaymentDtl payDtl = new PaymentDtl();

            payDtl.currency = orderModel.currency;
            payDtl.orderMid = orderMid;
            payDtl.payMethod = orderModel.payMethod;
            payDtl.currTotalPrice =  Convert.ToDouble(orderModel.currPriceTotal) ;
            payDtl.paymentToken =MD5Tool.GetMD5(orderMid + memUuid + "kk%$#@pay");

            string payDtlStr = JsonConvert.SerializeObject(payDtl);
            RedisHelper.SetProdInfotoRedis(payDtlStr, "b2d:ec:payDtl:" + orderMid, 60);
        }
   
        //組出booking 頁右邊顯示的內容
        public static BookingShowProdModel setBookingShowProd(ProductModel prod , PkgDetailModel pkg , confirmPkgInfo confirm,string currency,PkgEventsModel pkgEvent)
        {
            BookingShowProdModel prodShow = new BookingShowProdModel();

            prodShow.prodOid = prod.prod_no.ToString();
            prodShow.prodName = prod.prod_name;
            prodShow.currency = currency;
            prodShow.sDate = DateTimeTool.yyyy_mm_dd(confirm.selDate);
            prodShow.price1Qty = confirm.price1Qty;
            prodShow.price2Qty = confirm.price2Qty; 
            prodShow.price3Qty = confirm.price3Qty;
            prodShow.price4Qty = confirm.price4Qty;
            prodShow.price1 = pkg.price1;
            prodShow.price2 = pkg.price2;
            prodShow.price3 = pkg.price3;
            prodShow.price4 = pkg.price4;
            prodShow.eventOid = confirm.pkgEvent;
            if(prod.img_list.Count>0)
            {
                prodShow.photoUrl = "https://img.sit.kkday.com" + prod.img_list[0].img_kkday_url;
            }

            prodShow.isRank = pkg.is_unit_pirce == "RANK" ? true : false;
            prodShow.pkgOid = pkg.pkg_no;
            prodShow.pkgName = pkg.pkg_name;
            prodShow.totoalPrice = (prodShow.price1Qty * prodShow.price1) + (prodShow.price2Qty * prodShow.price2) +
                (prodShow.price3Qty * prodShow.price3) + (prodShow.price4Qty * prodShow.price4);

            prodShow.unitText = pkg.unit_txt;

            if(pkgEvent !=null)
            {
                var eTemp =pkgEvent.events.Where(x => x.day.Equals(confirm.selDate));


                foreach (Event e in eTemp)
                {
                    string[] times = e.event_times.Split(",");

                    foreach (string s in times)
                    {
                        string id = s.Split("_")[0];
                        if(id.Equals(confirm.pkgEvent))
                        {
                            prodShow.eventTime = s.Split("_")[1];
                            break;
                        }
                    }
                }
            }

            return prodShow;
        }


        //組出價格別與年齡->前端js判斷calender用
        public static CusAgeRange getCusAgeRange(confirmPkgInfo confirm, PkgDetailModel pkgsTemp)
        {
            CusAgeRange cus = new CusAgeRange();
            cus.price1Qty = 0;
            cus.price2Qty = 0;
            cus.price3Qty = 0;
            cus.price4Qty = 0;

            if (confirm.price1Qty > 0)
            {
                cus.price1Qty = confirm.price1Qty;

                cus.price1sAge = Convert.ToInt32(pkgsTemp.price1_age_range.Split('~')[0]);
                cus.price1eAge = Convert.ToInt32(pkgsTemp.price1_age_range.Split('~')[1]);
            }
            if (confirm.price2Qty > 0)
            {
                cus.price2Qty = confirm.price2Qty;

                cus.price2sAge = Convert.ToInt32(pkgsTemp.price2_age_range.Split('~')[0]);
                cus.price2eAge = Convert.ToInt32(pkgsTemp.price2_age_range.Split('~')[1]);
            }
            if (confirm.price3Qty > 0)
            {
                cus.price3Qty = confirm.price3Qty;

                cus.price3sAge = Convert.ToInt32(pkgsTemp.price3_age_range.Split('~')[0]);
                cus.price3eAge = Convert.ToInt32(pkgsTemp.price3_age_range.Split('~')[1]);
            }
            if (confirm.price4Qty > 0)
            {
                cus.price4Qty = confirm.price4Qty;

                cus.price4sAge = Convert.ToInt32(pkgsTemp.price4_age_range.Split('~')[0]);
                cus.price4eAge = Convert.ToInt32(pkgsTemp.price4_age_range.Split('~')[1]);
            }

            return cus;
        }


        //套餐日期
        public static String getPkgEventDate(PkgEventsModel pkgEvent, string inPkgOi,int? bookintQty)
        {
            //event 要有位控且位控>=訂購數
            string dayTemp = ""; 
            foreach ( Event e in  pkgEvent.events )
            {
                string[] times= e.event_times.Split(",");

                foreach ( string s in times)
                {
                    int qty = Convert.ToInt32(s.Split("_")[2]);
                    DateTime day = DateTimeTool.yyyyMMdd2DateTime(e.day);
                    if (qty >= bookintQty) dayTemp = dayTemp + day.ToString("yyyy-MM-dd") + ",";
                    break;
                }
            }

            dayTemp = dayTemp.Substring(0, dayTemp.Length - 1);
            return dayTemp;
        }

        //組出排除的餐食
        public static DataModel  exculdeFood(ProductModel prod, DataModel dataModel, ProductModuleModel module)
        {
            CusData cus = module.module_cust_data;
            List<string> excludeFood = new List<string>();

            if(cus!=null)
            {
                if(cus.is_require ==true)
                {
                    if(cus.meal.is_require==true)
                    {
                        ExcludeFood excluede = cus.meal.exclude_food;

                        foreach(CusDataInfo travelerData in dataModel.travelerData)
                        {
                            if(!string.IsNullOrEmpty(travelerData.meal.mealType) )
                            {
                                //'0002': ['0001', '0002', '0003', '0004', '0005', '0006'], //素食
                                //'0003': ['0002'], //猶太餐
                                //'0004': ['0002', '0005'] //穆斯林餐
                                if (travelerData.meal.mealType=="0002" )
                                {
                                    foreach ( MealType meal in  cus.meal.meal_list)
                                    {
                                        if(meal.is_provided ==true)
                                        {
                                            if(meal.meal_type=="0001" || meal.meal_type == "0002" || 
                                               meal.meal_type == "0003" || meal.meal_type == "0004" || meal.meal_type == "0005" || meal.meal_type == "0006")
                                            {
                                                excludeFood.Add(meal.meal_type);
                                            }
                                        }
                                    }
                                     
                                }
                                else if(travelerData.meal.mealType == "0003") 
                                {
                                    var mealType = cus.meal.meal_list.Where(x => x.meal_type.Equals("0002"));
                                    if (mealType != null)
                                    {
                                        foreach( MealType m in mealType)
                                        {
                                            excludeFood.Add(m.meal_type);
                                        }
                                    }
                                }
                                else if ( travelerData.meal.mealType == "0004")
                                {
                                    var mealType = cus.meal.meal_list.Where(x => x.meal_type.Equals("0002") || x.meal_type.Equals("0003"));
                                    if (mealType != null)
                                    {
                                        foreach (MealType m in mealType)
                                        {
                                            excludeFood.Add(m.meal_type);
                                        }
                                    }
                                }

                            }
                            travelerData.meal.excludeFoodType = excludeFood.ToArray();

                        }
                    }
                }
            }



            return dataModel;

        }


    }
}