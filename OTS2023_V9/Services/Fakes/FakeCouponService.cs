using OTS2023_V9.Models;
using OTS2023_V9.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS2023_V9.Services.Fakes
{
    public class FakeCouponService : ICouponService
    {
        // public Coupon Coupon { get; set; } moguce i tako

        public Guid CouponID { get; set; }
        public Coupon GetCouponById(Guid id)
        {
            Coupon coupon = new Coupon();
            coupon.Id = Guid.Parse("1bc36a14-0ea6-4aad-aa4f-da81003b62cb");
            coupon.Code = "Fakecode";
            coupon.Amount = 101.0;
            coupon.Used = false;
            coupon.ExpirationDate = new DateTime(2027, 1, 1);
            coupon.MinimalRequiredOrderTotal = 0;
            return coupon;
        }

        public void UseCoupon(Guid id)
        {
            CouponID = id;
        }
    }
}
