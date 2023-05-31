using ServiceTask.data;
using ServiceTask.Models;
using System.Diagnostics.Metrics;

namespace ServiceTask.Services
{
    public class ServicesService:IServicesService
    {
        TaskContext Context;

        public ServicesService(TaskContext _Context)
        {
            Context = _Context;
        }

        public List<ServiceDTO> loadall()
        {

            List<Service> li = Context.Services.ToList();

            List<ServiceDTO> ll = new List<ServiceDTO>();
            foreach (Service item in li)
            {
                ServiceDTO con = new ServiceDTO()
                {
                    Id = item.Id,
                    Name = item.Name
                   
                };
                ll.Add(con);
            }
            return ll;
        }

    }
}
