using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculater
{
    public class ResultEventArgs : EventArgs
    {
        public string Result { get; }

        public ResultEventArgs(string result)
        {
            Result = result;
        }
    }

    public partial class Calculator : Form
    {

        public event EventHandler<ResultEventArgs> ResultCalculated;

        enum Operators
        {
            None,
            Add,
            Subtract,
            Multiply,
            Divide,
            Result
        }

        Operators currentOperator = Operators.None;
        Boolean operatorChangeFlag = false;
        double firstOperand = 0;
        double secondOperand = 0;
        double setButton = 0;

        public string Res { get; set; }
        public Calculator()
        {
            InitializeComponent();
        }

        private void calcNum(Operators oper)
        {
            firstOperand = double.Parse(Display.Text);
            currentOperator = oper;
            operatorChangeFlag = true;
        }

        private void ButtonCalc_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            switch(button.Text)
            {
                case "+":
                    calcNum(Operators.Add);
                    break;
                case "-":
                    calcNum(Operators.Subtract);
                    break;
                case "*":
                    calcNum(Operators.Multiply);
                    break;
                case "/":
                    calcNum(Operators.Divide);
                    break;
                default:
                    calcNum(Operators.None);
                    break;

            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonAllCleaar_Click(object sender, EventArgs e)
        {
            firstOperand = 0;
            secondOperand = 0;
            currentOperator = Operators.None;
            Display.Text = string.Empty;
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            OnResultCalculated(new ResultEventArgs(Res));
            this.Close();
        }

        protected virtual void OnResultCalculated(ResultEventArgs e)
        {
            ResultCalculated?.Invoke(this, e); // 이벤트 호출
        }

        private void ButtonResult_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == false)
            {
                secondOperand = double.Parse(Display.Text);
                operatorChangeFlag = true;
            }

            switch(currentOperator)
            {
                case Operators.None:
                    break;
                case Operators.Multiply:
                    firstOperand *= secondOperand;
                    Display.Text = firstOperand.ToString();
                    break;
                case Operators.Subtract:
                    firstOperand -= secondOperand;
                    Display.Text = firstOperand.ToString();
                    break;
                case Operators.Add:
                    firstOperand += secondOperand;
                    Display.Text = firstOperand.ToString();
                    break;
                case Operators.Divide:
                    if (secondOperand == 0)
                    {
                        Display.Text = "0으로 나눌 수 없습니다.";
                    }
                    else
                    {
                        firstOperand /= secondOperand;
                        Display.Text = firstOperand.ToString();
                    }
                    break;
                default:
                    break;

            }
            Res = Display.Text;
        }
        
        private void ButtonDat_Click(object sender, EventArgs e)
        {
            if (!Display.Text.Contains("."))
            {
                // 소수점 추가
                Display.Text += ".";
            }
        }

        private void AppendNumber(int number)
        {
            if (operatorChangeFlag == true)
            {
                Display.Text = "";
                operatorChangeFlag = false;
            }
            if (Display.Text == "0") 
            {
                Display.Text = "";
            }
            setButton = Int32.Parse(number.ToString());
            Display.Text += setButton.ToString();
        }

        private void ButtonNum_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            switch (button.Text)
            {
                case "0":
                    if (Display.Text == "0")
                    {
                        currentOperator = Operators.None;
                    }
                    else
                    {
                        AppendNumber(0);
                    }
                    break;
                case "1":
                    AppendNumber(1);
                    break;
                case "2":
                    AppendNumber(2);
                    break;
                case "3":
                    AppendNumber(3);
                    break;
                case "4":
                    AppendNumber(4);
                    break;
                case "5":
                    AppendNumber(5);
                    break;
                case "6":
                    AppendNumber(6);
                    break;
                case "7":
                    AppendNumber(7);
                    break;
                case "8":
                    AppendNumber(8);
                    break;
                case "9":
                    AppendNumber(9);
                    break;

                default:
                    break;
                  
            }
        }

    }
}
