using System;
using Excel=Microsoft.Office.Interop.Excel;

namespace Demo
{
	/// <summary>
	/// Description of ExcelFunctions.
	/// </summary>
	public static class ExcelFunctions
	{
		static ExcelFunctions()
		{
		}
		
//		public string GetExcelData(int rowno,int colno)
//		{
//			
//			Excel.Application excelFile = new Excel.ApplicationClass();
//			Excel.Workbook excelWB= excelFile.Workbooks.Open("D:\\Meridian Link\\Testdata\\Data.xlsx");
//			Excel.Worksheet excelWS=(Excel.Worksheet) excelWB.Worksheets.get_Item("LPQ TestData");
//
//			Excel.Range tmpRange=(Excel.Range)excelWS.Cells[rowno,colno];
//			string cellText=tmpRange.Text.ToString();
//			return cellText;
//			
//			
//		}
		
		
		
	}
}
