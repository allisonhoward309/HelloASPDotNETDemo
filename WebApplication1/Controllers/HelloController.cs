using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

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
                "<input type='text' name='name' />"
                    + "</h1><select name = 'language'>"
                    + "<option value = 'english'> English </option>"
                    + "<option value = 'spanish'> Spanish </option>"
                    + "<option value = 'french'> French </option>"
                    + "<option value = 'german'> German </option>"
                    + "<option value = 'greek'> Greek </option>"
                    + "</select> "
                    + "<input type='submit' value='Greet Me!' />"
                    + "</form>";

            return Content(html, "text/html");
        }

        // GET: /<controller>/welcome?name=value or GET: /<controller>/welcome/name
        // POST: /<controller>/welcome
        [HttpGet("welcome/{name?}")]
        [HttpPost]
        public IActionResult Welcome(string name = "World", string language = "English")
        {
            return Content(CreateMessage(name, language));
        }
        public static string CreateMessage (string name, string language)
        {
            if (language == "english")
            {
                return $"Hello {name}";
            }
             else if   (language == "spanish")
            {
                return $"Hola {name}";
            }
            else if (language == "french")
            {
                return $"Bonjour {name}";
            }
            else if (language == "german")
            {
                return $"Hallo  {name}";
            }
            else
            {
                return $"γεια {name}";
            }
        }
    }
}
