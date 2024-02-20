namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Disable the ability to resize and maximize the form
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Hide the label that displays the numbers
            numbers.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Set the numbers label to 1
            appendNumber("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Set the numbers label to 2
            appendNumber("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Set the numbers label to 3
            appendNumber("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Set the numbers label to 4
            appendNumber("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Set the numbers label to 5
            appendNumber("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Set the numbers label to 6
            appendNumber("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Set the numbers label to 7
            appendNumber("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Set the numbers label to 8
            appendNumber("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Set the numbers label to 9
            appendNumber("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Set the numbers label to 0
            appendNumber("0");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Set the numbers label to a dot
            appendNumber(".");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Set the numbers label to a division operator as ÷
            appendNumber("÷");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // Set the numbers label to a multiplication operator as ×
            appendNumber("×");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // Set the numbers label to a subtraction operator as -
            appendNumber("-");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // Set the numbers label to an addition operator as +
            appendNumber("+");
        }

        private void acButton_Click(object sender, EventArgs e)
        {
            // Set the numbers label to an empty string
            numbers.Text = "";

            // Hide the numbers label and show the displayPlaceholder label
            numbers.Visible = false;
            displayPlaceholder.Visible = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Remove the last character from the numbers label
            if (numbers.Text.Length > 0)
            {
                numbers.Text = numbers.Text.Remove(numbers.Text.Length - 1);

                // Show the displayPlaceholder label if the numbers label is empty
                if (numbers.Text.Length == 0)
                {
                    numbers.Visible = false;
                    displayPlaceholder.Visible = true;
                }
            }
            else
            {
                // Hide the numbers label and show the displayPlaceholder label
                numbers.Visible = false;
                displayPlaceholder.Visible = true;
            }
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            // Check if there's an operator present, excluding the case where a negative sign is directly at the start
            if (!numbers.Text.Substring(1).Any(c => "+-×÷".Contains(c)))
            {
                // If only a negative sign is at the start without any operator, do nothing
                return;
            }

            // Create a new instance of the Calculator class
            Calculator calculator = new Calculator();

            // Prepare the numbers label for calculation by ensuring it does not end with an incomplete operation or a dot
            string calculationText = numbers.Text.TrimEnd('.', '+', '-', '×', '÷');

            // Ensure the text is not empty or just a negative sign
            if (!string.IsNullOrWhiteSpace(calculationText) && calculationText != "-")
            {
                string[] numbersArray = calculationText.Split(new string[] { "+", "-", "×", "÷" }, StringSplitOptions.RemoveEmptyEntries);

                // Edge case handling: if after trimming and splitting there are no elements, return
                if (numbersArray.Length == 0)
                {
                    return;
                }

                double firstNumber = 0, secondNumber = 0;
                // Attempt to parse the first number, defaulting to 0 on failure
                if (numbersArray.Length > 0 && !double.TryParse(numbersArray[0], out firstNumber))
                {
                    firstNumber = 0; // Default to 0 if parsing fails
                }

                // Attempt to parse the second number if it exists
                if (numbersArray.Length > 1 && !double.TryParse(numbersArray[1], out secondNumber))
                {
                    secondNumber = 0; // Default to 0 if parsing fails
                }

                calculator.firstNumber = firstNumber;
                calculator.secondNumber = secondNumber;

                // Determine the operator type
                if (calculationText.Contains("+"))
                {
                    calculator.operatorType = "+";
                }
                else if (calculationText.Contains("-"))
                {
                    calculator.operatorType = "-";
                }
                else if (calculationText.Contains("×"))
                {
                    calculator.operatorType = "×";
                }
                else if (calculationText.Contains("÷"))
                {
                    calculator.operatorType = "÷";
                }

                // Execute the calculation and set the result
                numbers.Text = calculator.calculate(calculator.firstNumber, calculator.secondNumber, calculator.operatorType).ToString();
            }
        }

        private void appendNumber(string number)
        {
            // Define operators as chars for direct comparisons and splitting
            char[] operators = { '+', '-', '×', '÷' };

            // Determine if the current text ends with an operator, considering them as strings for comparison
            bool endsWithOperator = numbers.Text.Length > 0 && operators.Any(op => numbers.Text.EndsWith(op.ToString()));

            // Check if the input is an operator or a dot
            bool isOperator = "+-×÷".Contains(number); // Directly check if the input string is one of the operators
            bool isDot = number == ".";

            // Use a more compatible way to count numbers separated by operators
            string[] numbersArray = numbers.Text.Split(operators, StringSplitOptions.RemoveEmptyEntries);

            // Prevent adding more than two numbers with operators
            if (isOperator && numbersArray.Length >= 2 && !endsWithOperator)
            {
                return; // Exit if trying to add a third number
            }

            if (isDot)
            {
                if (numbers.Text == "" || endsWithOperator)
                {
                    numbers.Text += "0.";
                }
                else if (!numbers.Text.Contains(".") || numbers.Text.LastIndexOfAny(operators) > numbers.Text.LastIndexOf('.'))
                {
                    numbers.Text += number;
                }
            }
            else
            {
                if (isOperator)
                {
                    if (!endsWithOperator || (number == "-" && numbersArray.Length < 2))
                    {
                        numbers.Text += number;
                    }
                }
                else
                {
                    numbers.Text += number;
                }
            }

            // Show the numbers label and hide the displayPlaceholder label
            numbers.Visible = true;
            displayPlaceholder.Visible = false;
        }
    }
}
