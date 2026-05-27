using OTS2023_V9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS2023_V9.Services.Fakes
{
    public class FakeOrderService : IOrderService
    {
        public double TotalDifference { get; set; }

        public Order GetOrderById(Guid id)
        {
            return new Order
            {
                Id = Guid.Parse("7302c847-1764-404e-b7a7-041f5255e490"),
                OrderCreatedDate = new DateTime(2000, 1, 1),
                OrderDeadlineDate = new DateTime(2000, 5, 5),
                Total = 1000,
                Status = Status.Delivered,
            };
        }

        public List<Order> GetUserOrdersWithDeadlineBetween(Guid userId, DateTime monthBefore, DateTime now)
        {
            Order order = new Order
            {
                Id = Guid.Parse("7302c847-1764-404e-b7a7-041f5255e490"),
                OrderCreatedDate = new DateTime(2000, 1, 1),
                OrderDeadlineDate = new DateTime(2000, 5, 5),
                Total = 1000,
                Status = Status.Delivered,
            };
            return new List<Order> { order };
        }

        public void UpdateTotal(double difference)
        {
            TotalDifference = difference;
        }
    }
}
