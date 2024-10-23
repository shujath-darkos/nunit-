using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.IO;
 
namespace FirstNunitTest.Drivers
{
    public class BaseTest
    {
        public IWebDriver driver;

        // Path to your Excel file
        private string excelPath = @"C:\Users\Shujath WorkSpace\Selenium\Book123.xlsx"; // Use correct path if this differs

        [SetUp]
        public void Open()
        {
            // Read the URL from Excel
            string url = GetExcelCellValue(1, 0); // Second row, second column
            string username = GetExcelCellValue(1, 3);
            string password = GetExcelCellValue(1, 4);
            string userTag = GetExcelCellValue(1, 1);
            string passwordTag = GetExcelCellValue(1, 2);
            string submitTag = GetExcelCellValue(1, 5);

            // Initialize the WebDriver and open the browser
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = url; // Use the URL read from the Excel file
            
            Thread.Sleep(10000);


            // Wait and interact with elements
            driver.FindElement(By.CssSelector(userTag)).SendKeys(username);
            driver.FindElement(By.CssSelector(passwordTag)).SendKeys(password);
            driver.FindElement(By.CssSelector(submitTag)).Click();

         }



             
        [TearDown]
        public void Close()
        {
            
            // Properly quit and dispose of the driver

            if (driver != null)
            {
                driver.Quit();    // Close browser and WebDriver session
                driver.Dispose(); // Release unmanaged resources
            }
        }

        // Helper function to read a specific cell value from the Excel file
        private string GetExcelCellValue(int row, int column)
        {
            // Open the Excel file and access the first sheet
            using var fileStream = new FileStream(excelPath, FileMode.Open, FileAccess.Read);
            IWorkbook workbook = new XSSFWorkbook(fileStream);
            ISheet sheet = workbook.GetSheetAt(0); // Assuming data is on the first sheet

            // Get the desired cell value
            IRow excelRow = sheet.GetRow(row);
            string cellValue = excelRow.GetCell(column)?.ToString() ?? string.Empty;

            return cellValue;
        }
    }
}
