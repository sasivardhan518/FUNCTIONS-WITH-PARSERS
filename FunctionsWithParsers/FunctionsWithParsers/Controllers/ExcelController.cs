using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FunctionsWithParsers.Models;

namespace FunctionsWithParsers.Controllers
{
    public class ExcelController : Controller
    {
        // GET: Excel
        public bool Index()
        {
            CreateExcelSheet.CreateExcelSheetWithFunctions();
            CreateExcelSheet.CreateExcelSheetForDatatble();
            return true;
        }
    }
}