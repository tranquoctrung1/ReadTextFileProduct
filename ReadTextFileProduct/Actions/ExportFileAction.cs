using ReadTextFileProduct.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ReadTextFileProduct.Actions
{
    public class ExportFileAction
    {
        public void ExportFile(List<ContentFileModel> list , string nameFile, string path)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

                if (xlApp == null)
                {
                    MessageBox.Show("Excel is not properly installed!!");
                    return;
                }


                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                xlWorkSheet.Cells[1, 1] = "Tên khách hàng";
                xlWorkSheet.Cells[1, 2] = "Tên sản phẩm";
                xlWorkSheet.Cells[1, 3] = "Số lượng";
                xlWorkSheet.Cells[1, 4] = "Đơn giá";

                int row = 1;

                foreach (ContentFileModel item in list)
                {
                    row++;

                    xlWorkSheet.Cells[row, 1] = item.Name;
                    xlWorkSheet.Cells[row, 2] = item.NameProduct;
                    xlWorkSheet.Cells[row, 3] = item.Amount;
                    xlWorkSheet.Cells[row, 4] = item.Price;
                }


                xlWorkBook.SaveAs($@"{path}{nameFile}.xls", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                MessageBox.Show("Xuất file thành công");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
