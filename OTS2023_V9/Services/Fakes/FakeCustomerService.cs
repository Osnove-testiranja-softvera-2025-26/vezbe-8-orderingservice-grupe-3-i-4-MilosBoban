using OTS2023_V9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS2023_V9.Services.Fakes
{
    internal class FakeCustomerService : ICustomerService
    {
        public Customer GetCustomerById(Guid id)
        {
            Customer customer = new Customer();
            customer.Id = Guid.Parse("170779d3-bdab-49e7-9ae1-d0b5dc660662");
            customer.FullName = "Marko Markovic";
            customer.Telephone = "065101101";
            return customer;
        }
    }
}
