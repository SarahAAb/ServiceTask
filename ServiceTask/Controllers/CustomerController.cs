
using Microsoft.AspNetCore.Mvc;
using ServiceTask.Models;
using ServiceTask.Services;

namespace ServiceTask.Controllers
{
    public class CustomerController : Controller
    {
       ICustomerService customerService;
       IServicesService servicesService;
       IInterstedService interstedService;
         IEmailSender emailSender;

        public CustomerController(ICustomerService _customerService,IServicesService _servicesService,IInterstedService _interstedService,IEmailSender _emailSender)
        {
            customerService = _customerService;
            servicesService = _servicesService;
            interstedService = _interstedService;
            emailSender = _emailSender;
        } 
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Save(CustomerDTO customerDTO)
        {
            customerService.insert(customerDTO);
            return Content("Success");
        }
        public IActionResult LoadService()
        {
         List<ServiceDTO> servicelist=servicesService.loadall();
            return Json(servicelist);
        }
        public IActionResult LoadOffers()
        {
            List<IntrestedDTO> list = interstedService.loadall();
            return Json(list);
        }
        public async Task<IActionResult> sendmail(UserInfo userInfo)
        {
            await emailSender.SendEmailAsync(userInfo);
            return Content("Success");
        }
    }
}
