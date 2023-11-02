using AzureWebLearningTool.Models;
using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace AzureWebLearningTool.Controllers
{
    public class PaperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult emailCode(string email)
        {
            User user = new User
            {
                email = email,
                ipAddress = HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString()
            };

            string ip = HttpContext.Connection.RemoteIpAddress.ToString();

            if (!HttpContext.Request.Cookies.ContainsKey("email"))
            {
                HttpContext.Response.Cookies.Append("email", email);
                return View(user);
            }
            else
            {
                return View(user);
            }
        }
    }
}
