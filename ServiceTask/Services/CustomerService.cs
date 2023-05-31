using ServiceTask.data;
using ServiceTask.Models;
using System.Diagnostics.Metrics;

namespace ServiceTask.Services
{
    public class CustomerService:ICustomerService
    {
        TaskContext Context;

        public CustomerService(TaskContext _Context)
        {
           Context = _Context;
        }
        public void insert(CustomerDTO customerDTO)
        {
            Customer customer = new Customer()
            {
                Name = customerDTO.Name,
                Email = customerDTO.Email,
                Phone = customerDTO.Phone
            };
            Context.Customers.Add(customer);
            Context.SaveChanges();

        }
        

    }
}
