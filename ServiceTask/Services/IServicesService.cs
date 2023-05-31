using ServiceTask.Models;

namespace ServiceTask.Services
{
    public interface IServicesService
    {
        List<ServiceDTO> loadall();
    }
}
