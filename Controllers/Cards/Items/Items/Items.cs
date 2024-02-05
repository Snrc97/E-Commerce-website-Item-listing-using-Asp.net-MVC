using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
/*
 Created by: Snrc97 (Github) 
 February 2024
*/
namespace GoogleCalendarSnrCiv.Controllers.Cards.Items.Items
{
    [Route("Items")]
    public class Items : Controller
    {
        private IWebHostEnvironment _webHostEnvironment;
        public Items(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public ActionResult Index()
        {
            return View("~/Views/Cards/Items/Items/Items.cshtml");
        }

        [Route("List")]
        public ActionResult List()
        {
            JsonResult jsonResult = new JsonResult(null);
            return jsonResult;
        }
    }
}