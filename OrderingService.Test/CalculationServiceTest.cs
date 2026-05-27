using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OTS2023_V9.Services;
using OTS2023_V9.Services.Fakes;

namespace OrderingService.Test
{
    [TestFixture]
    internal class CalculationServiceTest
    {
        [Test]
        public void CheckCouponValidity_ShouldBeTrue_FakeImplematations()
        {
            //Arange
            FakeCouponService fakeCouponService = new FakeCouponService();
            FakeOrderService fakeOrderService = new FakeOrderService();
            CalculationService calculationService = new CalculationService(fakeOrderService, fakeCouponService, null);

            //Act
            bool result = calculationService.CheckCouponValidity(Guid.Parse("7302c847-1764-404e-b7a7-041f5255e490"), Guid.Parse("1bc36a14-0ea6-4aad-aa4f-da81003b62cb"));

            //Assert
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void ApplyCoupon_Success()
        {
            //Arange
            FakeCouponService fakeCouponService = new FakeCouponService();
            FakeOrderService fakeOrderService = new FakeOrderService();
            FakeLoggerService fakeLoggerService = new FakeLoggerService();
            CalculationService calculationService = new CalculationService(fakeOrderService, fakeCouponService, fakeLoggerService);

            //Act
            calculationService.ApplyCoupon(Guid.Parse("7302c847-1764-404e-b7a7-041f5255e490"), new Coupon);


        }

    }
}
