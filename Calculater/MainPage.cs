using System;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Calculater
{
    public partial class MainPage : Form
    {
        private string connectionString = "Server=MariaDB;Database=test;User Id=root;Password=admin;";
        string res;
        Calculator nav;
        public MainPage()
        {
            InitializeComponent();
        }

        private void NavCalc(object sender, EventArgs e)
        {
            nav = new Calculator();

            nav.Show();

            nav.ResultCalculated += ResultMap;

            nav.ResultCalculated += Text_Click;

            nav.ResultCalculated += Excel_Click;



        }


        private void ResultMap(object sender, ResultEventArgs e)
        {
            res = e.Result;
            ResultValue.Text = "결과값 : " + res;

        }

        private void Text_Click(object sender, ResultEventArgs e)
        {
            string filePath = "output.txt"; // 출력할 파일 경로
            string dataToWrite = e.Result;

            try
            {
                // 파일이 이미 존재하는지 확인
                bool fileExists = File.Exists(filePath);

                // StreamWriter를 사용하여 파일에 텍스트를 추가 또는 쓰기
                using (StreamWriter writer = new StreamWriter(filePath, fileExists))
                {
                    // 파일이 이미 존재하는 경우 새로운 줄로 추가
                    if (fileExists)
                    {
                        writer.WriteLine(dataToWrite);
                        Console.WriteLine("Text Write new line");
                    }
                    // 파일이 존재하지 않는 경우 새로운 파일을 생성하고 데이터를 씀
                    else
                    {
                        writer.Write(dataToWrite);
                        Console.WriteLine("Create a new File");
                    }
                }

                Console.WriteLine("Text has been written to the file successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        private void DataBase_Click(object sender, EventArgs e)
        {

        }

        private void Excel_Click(object sender, ResultEventArgs e)
        {
            string filePath = "C:\\Users\\gimjinhwan\\source\\repos\\Calculater\\output.xlsx"; // 출력할 파일 경로
            string dataToWrite = e.Result;

            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = null;
            Excel.Worksheet worksheet = null;

            try
            {
                bool fileExists = File.Exists(filePath);

                if (fileExists)
                {
                    workbook = excelApp.Workbooks.Open(filePath);
                    worksheet = workbook.Sheets[1];
                    int lastRow = worksheet.Cells[worksheet.Rows.Count, 1].End[Microsoft.Office.Interop.Excel.XlDirection.xlUp].Row + 1;
                    worksheet.Cells[lastRow, 1] = dataToWrite;
                    Console.WriteLine("is True");
                }
                else
                {
                    workbook = excelApp.Workbooks.Add();
                    worksheet = workbook.Sheets[1];
                    worksheet.Cells[1, 1] = dataToWrite;
                    Console.WriteLine("is False");
                }

                workbook.SaveAs(filePath);
                workbook.Close();
                excelApp.Quit();

                Console.WriteLine("Data has been written to the Excel file successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                excelApp.Quit();
            }
        }
    }
}
