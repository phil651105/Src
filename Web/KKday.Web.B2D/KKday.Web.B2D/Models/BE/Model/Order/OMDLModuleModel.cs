using System;
namespace KKday.Web.B2D.Models.BE.Model.Order
{
    public class OMDLModuleModel
    {
        public OMDL_CUST_DATA ORDER_CUS { get; set; }         //原 PMDL_CUST_DATA
        public OMDL_CONTACT_DATA ORDER_CONTACT { get; set; }  //原 PMDL_CONTACT_DATA
        public OMDL_SEND_DATA ORDER_SEND { get; set; }        //原 PMDL_SEND_DATA
        public OMDL_SHUTTLE ORDER_SHUTTLE { get; set; }       //原 PMDL_VENUE + PMDL_RENT_CAR
        public OMDL_RENT_CAR ORDER_RENTCAR { get; set; }      //原 PMDL_RENT_CAR
        public OMDL_PSGR_DATA ORDER_PSG { get; set; }         //原 PMDL_CAR_PSGR
        public OMDL_FLIGHT_INFO ORDER_FLY { get; set; }       //原 PMDL_FLIGHT_INFO
        public OMDL_OTHER_DATA ORDER_OTHERS { get; set; }     //原 PMDL_SIM_WIFI + PMDL_EXCHANGE
    }

    #region OMDL_CUST_DATA 旅客資料
    public class OMDL_CUST_DATA
    {
        public string englishName { get; set; }              //護照姓名
        public string gender { get; set; }                   //性別
        public string meal { get; set; }                   //餐食
        public nationalityInfo nationality { get; set; }     //國籍資料
        public string birthday { get; set; }                 //出生年月日
        public passportInfo passport { get; set; }           //護照資訊
        public string localName { get; set; }                //本國姓名
        public string height { get; set; }                   //身高
        public string weight { get; set; }                   //體重
        public string shoeSize { get; set; }                 //鞋碼
        public double? glassDiopter { get; set; }            //眼鏡度數
    }

    public class mealInfo
    {
        public string mealName { get; set; }                 //餐食類別
        public string[] excludeFoodType { get; set; }        //排除食物
        public foodAllergyInfo foodAllergy { get; set; }     //過敏食物
    }
    public class foodAllergyInfo
    {
        public Boolean? isFoodAllergy { get; set; }
        public string allergenList { get; set; }             //過敏食物列表
    }
    public class nationalityInfo
    {
        public string nationalityCode { get; set; }          //國家代碼
        public string TWIdentity_number { get; set; }        //台灣身分證字號
        public string HKMOIdentityNumber { get; set; }       //港澳身分證字號
        public string MTPNumber { get; set; }                //台胞證號
    }
    public class passportInfo
    {
        public string passportNo { get; set; }               //護照號碼
        public string passportExpDate { get; set; }          //護照效期
    }
    #endregion

    #region OMDL_CONTACT_DATA 聯絡資料
    public class OMDL_CONTACT_DATA
    {
        public string contactName { get; set; }         //聯絡人姓名
        public string contactTel { get; set; }          //聯絡人電話
        public contactAppInfo contactApp { get; set; }  //APP聯絡方式
    }

    public class contactAppInfo
    {
        public Boolean? haveApp { get; set; }  //是否有APP聯絡方式
        public string appName { get; set; }    //APP型別
        public string appAccount { get; set; } //APP帳號
    }
    #endregion

    #region OMDL_SEND_DATA 寄送資料
    public class OMDL_SEND_DATA
    {
        public string receiverName { get; set; }               //收件人姓名
        public string receiverTel { get; set; }                //收件人電話
        public receiveAddressInfo sendToCountry { get; set; }  //寄送國家
        public sendToHotelInfo sendToHotel { get; set; }       //寄送飯店
        public shipInfoInfo shipInfo { get; set; }             //寄送資料(僅供 Be2 使用)
    }

    public class receiveAddressInfo
    {
        public string countryName { get; set; }              //國碼
        public string cityName { get; set; }                 //城市代碼
        public string zipCode { get; set; }                  //郵遞區號
        public string address { get; set; }                  //地址

    }
    public class sendToHotelInfo
    {
        public string hotelName { get; set; }                //飯店名稱
        public string hotelAddress { get; set; }             //飯店地址
        public string hotelTel { get; set; }                 //飯店電話
        public string buyerPassportEnglishName { get; set; } //訂房人護照英文姓名
        public string buyerLocalName { get; set; }           //訂房人本國籍姓名

        public string bookingOrderNo { get; set; }           //訂房編號
        public string bookingWebsite { get; set; }           //訂房網站
        public string checkInDate { get; set; }              //入住日期
        public string checkOutDate { get; set; }             //退房日期
    }
    public class shipInfoInfo
    {
        public string shipDate { get; set; }                 //Be2 使用
        public string trackingNumber { get; set; }           //Be2 使用
    }
    #endregion

    #region OMDL_SHUTTLE 租車接送資料
    public class OMDL_SHUTTLE
    {
        public string shuttleDate { get; set; }
        public designatedLocationInfo designatedLocation { get; set; }      //指定接駁車可接送地點
        public designatedByCustomerInfo designatedByCustomer { get; set; }  //指定接駁車可接送範圍（客人自行輸入上下車地址
        public charterRouteInfo charterRoute { get; set; }                  //包車路線
    }

    public class designatedLocationInfo 
    {
        public string locationName { get; set; }    //接送地名稱
        public string locationAddress { get; set; } //接送地地址
        public string imageUrl { get; set; }
        public string timeRangeStart { get; set; }
        public string timeRangeEnd { get; set; }
    }
    public class designatedByCustomerInfo
    {
        public pickUpInfo pickUp { get; set; }     //上車資料
        public string dropOff { get; set; }        //下車資料
    }
    public class pickUpInfo
    {
        public string location { get; set; }       //地點
        public string time { get; set; }           //接送時間  isCustom=true>>time false>>orderProdSetting
    }
    public class charterRouteInfo 
    {
        public Boolean? isCustom { get; set; }     //旅客是否自訂行程
        public string[] customRoutes { get; set; } //地點陣列,[“北門”,”東門”,“西門”]
        public string routeLocal { get; set; }     //路線 在地語系
    }
    #endregion

    #region OMDL_RENT_CAR 租車資料
    public class OMDL_RENT_CAR
    {
        public pickUpInfo_forCar pickUp { get; set; }   //取車營業所
        public dropOffInfo_forCar dropOff { get; set; } //還車營業所
        public Boolean isNeedFreeWiFi { get; set; }     //免費wifi
        public Boolean isNeedFreeGPS { get; set; }      //免費GPS
    }

    public class pickUpInfo_forCar
    {
        public string officeID { get; set; }     //取車營業所ID
        public string officeName { get; set; }   //取車營業所ID
        public string addressEng { get; set; }   //取車營業所ID
        public string addressLocal { get; set; } //取車營業所ID
        public string datetime { get; set; }     //取車時間
    }
    public class dropOffInfo_forCar
    {
        public string officeID { get; set; }     //還車營業所ID
        public string officeName { get; set; }   //還車營業所ID
        public string addressEng { get; set; }   //還車營業所ID
        public string addressLocal { get; set; } //還車營業所ID
        public string datetime { get; set; }     //還車時間
    }
    #endregion

    #region OMDL_PSGR_DATA 車輛乘客資料
    public class OMDL_PSGR_DATA
    {
        public int? qtyAdult { get; set; }                    //成人數量
        public int? qtyChild { get; set; }                    //孩童數量
        public int? qtyInfant { get; set; }                   //嬰兒數量
        public int? qtyCarryLuggage { get; set; }             //手提行李
        public int? qtyCheckedLuggage { get; set; }           //托運行李
        public qtyChildSeatInfo qtyChildSeat { get; set; }    //兒童座椅
        public qtyInfantSeatInfo qtyInfantSeat { get; set; }  //嬰兒座椅
    }

    public class qtyChildSeatInfo 
    {
        public int? supplierProvided { get; set; } //廠商提供數量
        public int? selfProvided { get; set; }     //自備數量
    }
    public class qtyInfantSeatInfo 
    {
        public int? supplierProvided { get; set; } //廠商提供數量
        public int? selfProvided { get; set; }     //自備數量
    }
    #endregion

    #region OMDL_FLIGHT_INFO 航班資料
    public class OMDL_FLIGHT_INFO
    {
        public arrivalInfo arrival { get; set; }         //出發航班資訊
        public departureInfo departure { get; set; }     //抵達航班資訊
    }

    public class arrivalInfo
    {
        public string flightType { get; set; }            //航班類別
        public string airport { get; set; }               //抵達機場
        public string terminalNo { get; set; }            //航廈
        public string airline { get; set; }               //航空公司
        public string flightNo { get; set; }              //航班編號
        public string arrivalDatetime { get; set; }       //抵達時間
        public Boolean? isNeedToApplyVisa { get; set; }   //是否辦理落地簽
    }
    public class departureInfo
    {
        public string flightType { get; set; }            //航班類別
        public string airport { get; set; }               //出發機場
        public string terminalNo { get; set; }            //航廈
        public string airline { get; set; }               //航空公司
        public string flightNo { get; set; }              //航班編號
        public string departureDatetime { get; set; }     //出發時間
        public Boolean? haveBeenInCountry { get; set; }   //已在商品所在國家
    }
    #endregion

    #region OMDL_OTHER_DATA 網卡WIFI機等其他資料
    public class OMDL_OTHER_DATA
    {
        public string mobileModelNumber { get; set; }             //手機型號
        public string mobileIMEI { get; set; }                    //手機IMEI號
        public string activationDate { get; set; }                //啟用日期

        public string exchangeLocationName { get; set; }          //領取名字
        public string exchangeLocationAddress { get; set; }       //領取地點
        public string exchangeLocationNote { get; set; }          //領取備註
        public string exchangeLocationBusinessHours { get; set; } //營業時間 Wed, Fri, Sun 21:00 ~ 23:30
    }
    #endregion
}