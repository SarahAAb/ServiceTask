using ServiceTask.data;
using ServiceTask.Models;

namespace ServiceTask.Services
{
    public class InterstedService:IInterstedService
    {
        TaskContext Context;

        public InterstedService(TaskContext _Context)
        {
            Context = _Context;
        }

        public List<IntrestedDTO> loadall()
        {

            List<Intrested> li = Context.Intrested.ToList();

            List<IntrestedDTO> ll = new List<IntrestedDTO>();
            foreach (Intrested item in li)
            {
                IntrestedDTO con = new IntrestedDTO()
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
