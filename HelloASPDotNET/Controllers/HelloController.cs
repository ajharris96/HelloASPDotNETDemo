using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloASPDotNET.Controllers
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post' action='/helloworld'>" +
                "<input type='text' name='name' />" +
                "<select name='lang'> <option value = 'Welcome to my app, ' > Select a language </option>" +
                "<option value = 'Hello, ' > English </option>"+
                "<option value = 'Bonjour, ' > French </option>" +
                "<option value = 'Hola, ' > Spanish </option>" +
                "<option value = 'Hallo, ' > German </option>" +
                "<option value = 'Salve, ' > Latin </option>" +
                "</select>" +
                "<input type='submit' value='Greet Me!' />" +
                "</form>";

            return Content(html, "text/html");
        }

        // GET: /<controller>/welcome?name=value or GET: /<controller>/welcome/name
        // POST: /<controller>/welcome
        [HttpGet("welcome/{lang}/{name?}")]
        [HttpPost]
        public IActionResult Welcome(string lang, string name = "World")
        {
            return Content("<h1>"+ lang + name + "!</h1>", "text/html");
        }

        //old code
        //[HttpGet("welcome/{name?}")]
        //[HttpPost]
        //public IActionResult Welcome(string name = "World")
        //{
        //    return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
        //}
    }
}
