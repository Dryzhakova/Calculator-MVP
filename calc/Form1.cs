//Dryzhakova Kateryna grupa 1/2 

using System.Diagnostics.Eventing.Reader;

//если добавляем ноль то должна появится  запятая
//-05 не может біть должно следующее идти число
//если добавляем запятую то в начале должен біть 0
//заменить вівод  при делении на ноль и при делении на 0,



namespace calc
{
    public partial class Form1 : Form
    {
        Double result = 0.0;
        string operation = string.Empty;
        string frstNum, secNum;
        int IsDigit = 0;
        bool enterValue = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Error_Click()
        {
            if (textdisplay1.Text.Contains("E"))
            {
                textdisplay1.Text = "0"; result = 0.0;
            }
            else if (textdisplay1.Text == "Can't divide by 0") textdisplay1.Text = "0";
        }

        private void ButNumbers_Click(object sender, EventArgs e)
        {
            enterValue = false;
            Button button = (Button)sender;
            //если одим 0, проверка на ввод только 1 нуля
            //проверка если после вводим число 0 уходит 
            //если вводим число то переход на проверку запятой и потом вывод
            Error_Click();
            // if (textdisplay1.Text.Contains("-") && textdisplay1.Text.IndexOf('0') == 0 && !textdisplay1.Text.Contains(",")) { textdisplay1.Clear(); textdisplay1.Text += "-" + button.Text; }
            if (textdisplay1.Text.IndexOf('0') == 0 && button.Text == "0")
            {
                if (!textdisplay1.Text.Contains(",")) textdisplay1.Text += ",";
                else textdisplay1.Text += button.Text;
            }
            else if (textdisplay1.Text == "0" && button.Text != ",") { textdisplay1.Clear(); textdisplay1.Text += button.Text; }
            else
            {
                if (button.Text == ",")
                {
                    if (!textdisplay1.Text.Contains(",") && textdisplay1.Text.Length == 0) textdisplay1.Text = "0,";
                    else if (!textdisplay1.Text.Contains(",") && textdisplay1.Text.Length >= 1) textdisplay1.Text += button.Text;
                }
                //else if(button.Text == "+" || button.Text == "-" || button.Text == "*" || button.Text == "/") buttonEqual.PerformClick();
                else textdisplay1.Text += button.Text;//buttonEqual.PerformClick();}
            }
            //&& textdisplay1.Text.Length == 3
        }

        private void ButtonMathOperation(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            enterValue = true;

            if (result != 0.0)
            {
                // buttonEqual.PerformClick()
                if (button.Text == operation) textdisplay1.Text += button.Text;
                else buttonEqual.PerformClick();
            }
            else result = Double.Parse(textdisplay1.Text);

            if (textdisplay1.Text != "0")
            {
                textdisplay2.Text = frstNum = $"{result}{operation}";
                textdisplay1.Text = string.Empty;
            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            secNum = textdisplay1.Text;
            textdisplay2.Text = $"{textdisplay2.Text}{textdisplay1.Text}=";
            if (textdisplay1.Text == "0") textdisplay2.Text = string.Empty;
            switch (operation)
            {
                case "+":
                    Error_Click();
                    textdisplay1.Text = (result + Double.Parse(textdisplay1.Text)).ToString(); break;
                case "-":
                    Error_Click();
                    textdisplay1.Text = (result - Double.Parse(textdisplay1.Text)).ToString(); break;
                case "/":
                    Error_Click();
                    if (textdisplay1.Text == "0" || textdisplay1.Text == "0,")
                    {
                        textdisplay2.Text = "Can't divide by 0"; textdisplay1.Text = "Can't divide by 0";
                    }
                    else textdisplay1.Text = (result / Double.Parse(textdisplay1.Text)).ToString(); break;
                case "*":
                    Error_Click();
                    textdisplay1.Text = (result * Double.Parse(textdisplay1.Text)).ToString(); break;
                default: textdisplay2.Text = $"{textdisplay1.Text}"; break;
            }
            if (textdisplay1.Text == "Can't divide by 0") { }
            else
            {
                result = Double.Parse(textdisplay1.Text);
                operation = string.Empty;
            }

        }

        private void buttonDelLast_Click(object sender, EventArgs e)
        {
            Error_Click();
            if (textdisplay1.Text.Length == 1) textdisplay1.Text = "0";
            else if ((textdisplay1.Text.IndexOf(',') == 1 || textdisplay1.Text.IndexOf('-') == 0) && textdisplay1.Text.Length == 2) textdisplay1.Text = "0";
            else textdisplay1.Text = textdisplay1.Text.Remove(textdisplay1.Text.Length - 1, 1);

        }

        private void buttoncClearAll_Click(object sender, EventArgs e)
        {
            textdisplay1.Text = string.Empty;
            textdisplay2.Text = string.Empty;
            result = 0.0;
        }

        private void buttonAddSubsc_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;

            if (operation == "+/-") textdisplay1.Text = Convert.ToString(-1 * Convert.ToDouble(textdisplay1.Text));
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textdisplay1.Text = string.Empty;
        }
    }
}