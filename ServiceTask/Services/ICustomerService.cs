using ServiceTask.Models;

namespace ServiceTask.Services
{
    public interface ICustomerService
    {
        void insert(CustomerDTO customerDTO);
    }
}
