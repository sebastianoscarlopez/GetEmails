using GetEmails;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetEmail
{
    class ExcelHelper
    {
        public List<UrlDTO> getUrls(string path, int idxSheet, int idxColumnFrom)
        {
            using (var xlPackage = new ExcelPackage(new System.IO.FileInfo(path)))
            {
                var sheet = xlPackage.Workbook.Worksheets[idxSheet];
                var totalRows = sheet.Dimension.Rows;
                var urls = new List<UrlDTO>();
                for (int idx = 1; idx <= totalRows; idx++)
                {
                    var url = (sheet.GetValue(idx, idxColumnFrom)??"").ToString();
                    urls.Add(new UrlDTO
                    {
                        url = url,
                        idxColumn = idxColumnFrom,
                        idxRow = idx
                    });

                }
                return urls;

            }
            return null;
        }

        public string[] getSheets(string path)
        {
            try
            {
                using (var xlPackage = new ExcelPackage(new System.IO.FileInfo(path)))
                {
                    var sheets = (from w in xlPackage.Workbook.Worksheets
                                  select w.Name).ToArray();
                    return sheets;
                }
            }
            catch
            {
                return null;
            }
        }

        public string[] getColumns(string path, int idxSheet)
        {
            try
            {
                using (var xlPackage = new ExcelPackage(new System.IO.FileInfo(path)))
                {
                    var sheet = xlPackage.Workbook.Worksheets[idxSheet];
                    var totalColumns = sheet.Dimension.Columns;
                    var columns = new string[totalColumns];
                    for (var idx = 0; idx < totalColumns; idx++)
                    {
                        columns[idx] = Encoding.ASCII.GetString(new byte[]{ Convert.ToByte(idx + 65) });
                    }
                        
                    return columns;
                }
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
