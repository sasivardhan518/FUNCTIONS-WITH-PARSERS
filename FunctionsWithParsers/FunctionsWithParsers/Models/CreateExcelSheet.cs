using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using OfficeOpenXml.Packaging;
using Zirpl.CalcEngine;
using System.Data;

namespace FunctionsWithParsers.Models
{
    public static class CreateExcelSheet
    {
        public static void CreateExcelSheetForDatatble()
        {
            var path = @"D:/ExcelFiles1/";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            var fileName =  path+"Datatable.xls";
            var file = new FileInfo(fileName);

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            var package = new OfficeOpenXml.ExcelPackage(file);
            var worksheet = package.Workbook.Worksheets.Add("GridData");
            worksheet.Cells["A1"].LoadFromDataTable(DataTableForGrid.dt, true);
            package.Save();

        }
        public static void CreateExcelSheetWithFunctions()
        {
            var ce = new CalculationEngine();
            var exp = "stdev(metric1,metric3)";
            var dt = DataTableForGrid.dt;
            if(!dt.Columns.Contains("STDEV"))
            dt.Columns.Add("STDEV", typeof(double));
            var columns = dt.Columns;
            foreach(DataRow row in dt.Rows)
            {
                var exprsn = exp;
                exprsn = exprsn.Replace("metric1", row["Metric1"].ToString());
                exprsn = exprsn.Replace("metric3", row["Metric3"].ToString());
                row["STDEV"] = ce.Evaluate(exprsn);
            }
        }
    }
}