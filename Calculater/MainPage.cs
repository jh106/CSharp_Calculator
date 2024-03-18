using System;
using System.IO;
using System.Windows.Forms;

namespace Calculater
{
    public partial class MainPage : Form
    {
        string res;
        public MainPage()
        {
            InitializeComponent();
        }

        private void NavCalc(object sender, EventArgs e)
        {
            Calculator nav = new Calculator();
            nav.Show();

            nav.ResultCalculated += ResultMap;
            nav.ResultCalculated += Text_Click;

        }

        private void ResultMap(object sender, ResultEventArgs e)
        {
            res = e.Result;
            ResultValue.Text =  "결과값 : " + res;
        }

        private void Text_Click(object sender, ResultEventArgs e)
        {
            string filePath = "output.txt"; // 출력할 파일 경로
            string dataToWrite = e.Result;

            try
            {
                // StreamWriter를 사용하여 파일에 텍스트를 쓰기
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(dataToWrite);
                }

                Console.WriteLine("Text has been written to the file successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        private void Exel_Click(object sender, EventArgs e)
        {

        }

        private void DataBase_Click(object sender, EventArgs e)
        {

        }
    }
}
