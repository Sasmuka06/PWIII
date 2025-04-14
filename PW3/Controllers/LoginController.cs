using Microsoft.AspNetCore.Mvc;
using PW3.Models;

namespace PW3.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Logar(LoginModel dados)
        {
            LoginModel model = new LoginModel();
            model.Login = "sasmuka@gmail.com";
            model.Senha = "Bomdia";
            return View();
        }
    }
}
