using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using Newtonsoft.Json;
using FunctionsWithParsers.Models;

namespace FunctionsWithParsers.Controllers
{
    public class DataTableController : Controller
    {
        // GET: DataTable
        public ActionResult Index()
        {
            CreateExcelSheet.CreateExcelSheetWithFunctions();
            DataTable dt = DataTableForGrid.dt;
            var jsonString = JsonConvert.SerializeObject(dt);
            return Json(jsonString, JsonRequestBehavior.AllowGet);
        }
    }
}