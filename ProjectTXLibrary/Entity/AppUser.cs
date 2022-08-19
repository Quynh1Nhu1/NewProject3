using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ProjectTXServer.Entity
{
    public class AppUser :IdentityUser
    {
        public string UserFirstName { set; get; }
        public string UserLastName { set; get; }
        public DateTime UserDoB { set; get; }
        //public string UserState { set; get; }
        public string UserPhoneNumber { set; get; }
        //public string UserProfileImage { set; get; }
        public byte[] PasswordHashs { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string RefreshToken { get; set; } = string.Empty;
        public DateTime TokenCreated { get; set; }
        public DateTime TokenExpires { get; set; }
        //public string bill_Country { set; get; }
        //public string bill_CompanyName { set; get; }
        //public string bill_City { set; get; }
        //public string bill_State { set; get; }
        //public string bill_PostalCode { set; get; }
        //public string bill_PhoneNumber { set; get; }
        //public string bill_Address1 { set; get; }
        //public string bill_Address2 { set; get; }
        //public List<SubReview> SubReviewSR { get; set; }

        //public List<Bills> BillsAU { get; set; }
        //public List<Reviews> ReviewsU { get; set; }
        //public List<Cart> CartU { get; set; }





    }
}
