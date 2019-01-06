using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableHome.Utilities
{
    public static class TableUtility
    {
        static List<TableDataCollection> tableDataCollection = new List<TableDataCollection>();
        //private static int count;

        public static void ReadTable(IWebElement table)
        {
            var rows = table.FindElements(By.TagName("tr"));
            var columns = table.FindElements(By.TagName("th"));

            int rowIndex = 0;

            foreach (var row in rows)
            {
                int columnIndex = 0;
                var columnValues = row.FindElements(By.TagName("td"));

                foreach (var columnValue  in columnValues)
                {
                    tableDataCollection.Add(new TableDataCollection
                    {
                        RowNumber = rowIndex,
                        ColumnName = columns[columnIndex].Text,
                        ColumnValue = columnValue.Text
                    });

                    columnIndex++;
                }
                rowIndex++;
            }            
            //return (rows.Count, columns.Count, (tableDataCollection.Last(x => x != null).ColumnValue));
        }

        public static string ReadCell(string columnName, int rowNumber)
        {
            var value = (from e in tableDataCollection
                         where e.ColumnName == columnName && e.RowNumber == rowNumber
                         select e.ColumnValue).SingleOrDefault();
            //count = tableDataCollection.Count;
            return value;
        }        
    }

    class TableDataCollection
    {
        public int RowNumber { get; set; }
        public string ColumnName { get; set; }
        public string ColumnValue { get; set; }
    }
}
