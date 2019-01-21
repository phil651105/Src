using System;
using System.Collections.Generic;

namespace KKday.Web.B2D.Models.BE.Model.Order
{
    public class OrderListModel
    {
        //分頁用
        public int COUNTS { get; set; }         //總筆數order_qty
        public int CURRENT_PAGE { get; set; }   //目前頁數current_page
        public int PAGES { get; set; }          //我的訂單總分頁數

        public List<OrderModel> ORDERS { get; set; } //訂單列表
    }

    public class OrderModel
    {
        public string ORDER_NO { get; set; }       //訂單編號orderNo
        public string ORDER_MID { get; set; }      //18KK訂單編號orderMid
        public string ORDER_OID { get; set; }      //KK訂單編號orderOid
        public string ORDER_DATE { get; set; }     //訂購日期userCrtDt/userCrtDtGMTNm
        public string PROD_SDATE { get; set; }     //出發日begLstGoDt/begLstGoDtGMT/begLstGoDtGMTNm
        public string ORDER_STATUS { get; set; }   //訂單狀態說明orderStatusTxt
        public string PROD_NAME { get; set; }      //產品名稱productName
        public string PKG_NAME { get; set; }       //套餐名稱packageName
        public string QTY { get; set; }            //數量qtyTotal
    }

    public class OrderInfoModel
    {
        public string PROD_NAME { get; set; }
        public string PKG_NAME { get; set; }
        public string EVENT { get; set; }
        public string ORDER_SDATE { get; set; }
        public string ADT_QTY { get; set; }
        public string CHD_QTY { get; set; }
        public string INF_QTY { get; set; }
        public string OLD_QTY { get; set; }
        public string ADT_PRICE { get; set; }
        public string CHD_PRICE { get; set; }
        public string INF_PRICE { get; set; }
        public string OLD_PRICE { get; set; }
        public string TOTALPRICE { get; set; }
        public string TOTALPAY { get; set; }
        public string CANCELFEE { get; set; }
        public string REFUNDPRICE { get; set; }
        public string ORDER_MID { get; set; }
        public string CONN_NAME { get; set; }
        public string CONN_EMAIL { get; set; }
        public string CONN_TEL { get; set; }
        public string CRT_DATE { get; set; }
    }
}