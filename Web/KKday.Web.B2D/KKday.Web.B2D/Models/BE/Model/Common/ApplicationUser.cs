using System;
namespace KKday.Web.B2D.Models.BE.Model.Common
{
    public class IApplicationUser
    {
        public string UserAccount { get; set; }
        public string UserName { get; set; }
    }
     
    /////////////////

    public class KKdayUser : IApplicationUser
    {

    }
 
    /////////////////

    public class DistributorUser : IApplicationUser
    {

    }
}
