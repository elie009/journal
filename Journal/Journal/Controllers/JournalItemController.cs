using Journal.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Journal.Controllers
{
    public class JournalItemController : Controller
    {
        // GET: JournalItem
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddItem() {

            var webClient = new WebClient();
            var jsonString = webClient.DownloadString(@"D:\project\C#\git\config\Voucher Type.json");
            var voucher = JsonConvert.DeserializeObject<Vouchers>(jsonString);

            return View(voucher);
        }
    }
}