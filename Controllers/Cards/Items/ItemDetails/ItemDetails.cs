using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using GoogleCalendarSnrCiv.Models;
/*
 Created by: Snrc97 (Github) 
 February 2024
*/
namespace GoogleCalendarSnrCiv.Controllers.Cards.Items
{
    [Route("Items/Details")]
    public class ItemDetails : Controller
    {
        private IWebHostEnvironment _webHostEnvironment;
        public ItemDetails(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        [Route("{id:int}")]
        public ActionResult Index(int id)
        {
            return View("~/Views/Cards/Items/ItemDetails/ItemDetails.cshtml", new ItemParamViewModel { Id = id });
        }

        [Route("List")]
        public ActionResult List()
        {
            JsonResult jsonResult = new JsonResult(null);
            return jsonResult;
        }
    }
}