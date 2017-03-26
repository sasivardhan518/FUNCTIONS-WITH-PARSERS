using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace FunctionsWithParsers.Models
{
    public static class DataTableForGrid
    {
        public static DataTable dt;
        static DataTableForGrid()
        {
            dt = new DataTable();
            dt.Columns.Add("Field", typeof(string));
            dt.Columns.Add("Metric1", typeof(double));
            dt.Columns.Add("Metric2", typeof(double));
            dt.Columns.Add("Metric3", typeof(double));
            dt.Rows.Add("fld1", 123, 145, 1365);
            dt.Rows.Add("fld2", 542, 254, 135);
            dt.Rows.Add("fld3", 5454, 1455, 2365);
            dt.Rows.Add("fld4", 522, 1445, 1385);
            dt.Rows.Add("fld5", 1543, 1145, 1165);
            dt.Rows.Add("fld6", 1283, 1245, 1336);
            dt.Rows.Add("fld7", 6123, 145, 1155);
            dt.Rows.Add("fld8", 1423, 14545, 1395);
            dt.Rows.Add("fld9", 7123, 1454, 1314);
        }
    }
}