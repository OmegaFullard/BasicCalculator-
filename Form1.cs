using System;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BasicCalculator
{
    /// <summary>
    /// A basic calculator
    /// </summary>
    public partial class Form1 : Form
    {
        private object operation;
        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Clearing Method
        /// <summary>
        /// Clears the user input text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void CEButton_Click(object sender, EventArgs e)
        {
            // Clears the text from the user input text box
            this.UserInputText.Text = String.Empty;
            // Focus the user input text
            FocusInputText();
        }

        private void CButton_Click(object sender, EventArgs e)
        {
            this.UserInputText.Clear();
            this.UserInputText.SelectionLength = 0;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // Delete the value after the selected position
            DeleteTextValue();


            // Focus the user input text
            FocusInputText();

        }

        #endregion
        #region Operator Methods

        /// <summary>
        /// Adds Divide character to the text at the current selection position 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DivideButton_Click(object sender, EventArgs e)
        {
            // Insert the value in the user input box at the currently selected position 
            InsertTextValue("/");
            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Adds Times character to the text at the current selection position 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimesButton_Click(object sender, EventArgs e)
        {
            // Insert the value in the user input box at the currently selected position 
            InsertTextValue("*");
            // Focus the user input text
            FocusInputText();
        }
        /// <summary>
        /// Adds Minus character to the text at the current selection position 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinusButton_Click(object sender, EventArgs e)
        {
            // Insert the value in the user input box at the currently selected position 
            InsertTextValue("-");
            // Focus the user input text
            FocusInputText();
        }
        /// <summary>
        /// Adds Plus character to the text at the current selection position 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlusButton_Click(object sender, EventArgs e)
        {
            // Insert the value in the user input box at the currently selected position 
            InsertTextValue("+");
            // Focus the user input text
            FocusInputText();
        }
        /// <summary>
        /// Calculates the given equation in the user input text 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EqualsButton_Click(object sender, EventArgs e)
        {
            // Calculates the equation 
            CalculateEquation();
            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        ///Adds Percent character to the text at the current selection position 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PercentButton_Click(object sender, EventArgs e)
        {
            // Insert the value in the user input box at the currently selected position 
            //InsertTextValue("%");
            // Focus the user input text
           // FocusInputText();
        }
        #endregion
        #region Number Methods

        /// <summary>
        /// Adds 0 character to the text at the current selection position 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZeroButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");
            // Focus the user input text
            FocusInputText();
        }
        /// <summary>
        ///Adds 1 character to the text at the current selection position 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void OneButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("1");
            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Adds 2 character to the text at the current selection position 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TwoButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");
            // Focus the user input text
            FocusInputText();
        }
        /// <summary>
        /// Adds 3 character to the text at the current selection position 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThreeButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");
            // Focus the user input text
            FocusInputText();

        }
        /// <summary>
        /// Adds 4 character to the text at the current selection position 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FourButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");
            // Focus the user input text
            FocusInputText();
        }
        /// <summary>
        /// Adds 5 character to the text at the current selection position 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FiveButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");
            // Focus the user input text
            FocusInputText();
        }
        /// <summary>
        /// Adds 6 character to the text at the current selection position 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SixButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");
            // Focus the user input text
            FocusInputText();
        }
        /// <summary>
        /// Adds 7 character to the text at the current selection position 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SevenButton_Click(object sender, EventArgs e)
        {

            InsertTextValue("7");
            // Focus the user input text
            FocusInputText();
        }
        /// <summary>
        /// Adds 8 character to the text at the current selection position 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EightButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");
            // Focus the user input text
            FocusInputText();
        }
        /// <summary>
        /// Adds 9 character to the text at the current selection position 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NineButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("9");
            // Focus the user input text
            FocusInputText();
        }
        /// <summary>
        /// Adds . character to the text at the current selection position 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DotButton_Click(object sender, EventArgs e)
        {
            InsertTextValue(".");
            // Focus the user input text
            FocusInputText();
        }
        #endregion

        #region Private Helpers

        /// <summary>
        /// Focuses the user input text
        /// </summary>
        private void FocusInputText()
        {
            this.UserInputText.Focus();

        }
        /// <summary>
        /// Inserts the given text into the user input text box
        /// </summary>
        /// <param name="value">The value to insert</param>
        private void InsertTextValue(string value)
        {
            // Remember selection start
            var SelectionStart = this.UserInputText.SelectionStart;

            // Set new text 
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, value);

            // Restore the selection start
            this.UserInputText.SelectionStart = SelectionStart + value.Length;

            // Set selection length to zero
            this.UserInputText.SelectionLength = 0;

        }


        /// <summary>
        /// Deletes the character to the right of the selection start of the user input text box 
        /// </summary>

        private void DeleteTextValue()
        {
            // If we do not have a value to delete, return
            if (this.UserInputText.Text.Length < this.UserInputText.SelectionStart + 1)
                return;

            // Remember selection start
            var SelectionStart = this.UserInputText.SelectionStart;

            // Delete the character to the right of the selection

            this.UserInputText.Text = this.UserInputText.Text.Remove(this.UserInputText.SelectionStart, 1);


            // Restore the selection start
            this.UserInputText.SelectionStart = SelectionStart;

            // Set selection length to zero
            this.UserInputText.SelectionLength = 0;

        }


        /// <summary>
        /// Calculates the given equation and outputs the answer to the user label
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void CalculateEquation()
        {


            this.CalculationResultText.Text = ParseOperation();


            // Focus the user input text
            FocusInputText();

        }
        /// <summary>
        /// Parses the users equation and calculates the result 
        /// </summary>
        /// <returns></returns>

        private string ParseOperation()
        {
            try
            {
                // Get the users equation input 
                var input = this.UserInputText.Text;

                //Remove all spaces
                input = input.Replace(" ", "");

                // Create a new top-level operation
                var Operation = new Operation();
                var Leftside = true;

                // Loop through each character of the input
                // starting from the left working to the right
                for (int i = 0; i < input.Length; i++)
                {
                    // TODO: Handle order priority
                    //    4 + 5 * 3
                    //    It should calculate 5 * 3 first, then 4 + result (so 4 + 15)

                    // Check if the character is a number
                    var myString = "0123456789.";
                    if (myString.Any(c => input[i] == c))
                    {
                        if (Leftside)
                            Operation.Leftside = AddNumberPart(Operation.Leftside, input[i]);
                        else
                            Operation.Rightside = AddNumberPart(Operation.Rightside, input[i]);

                    }
                    // If it is an operator ( + = * / ) set the operator type
                    else if ("+-*/.".Any(c => input[i] == c))
                    {
                        // If we are on the right side already, we now need to calculate our current operation
                        // and set the result to the left side of the next operation
                        if (!Leftside)
                        {
                            // Get the operator type
                            var operatorType = GetOperationType(input[i]);

                            // Check if we actually have a right side number
                            if (Operation.Rightside.Length == 0)
                            {
                                // Check the operator is not minus (as they could be creating a negative number)
                                if (operatorType != OperationType.Minus)
                                    throw new InvalidOperationException($"Operator (+ * / or more than one -) specified without an right side number");

                                // If we got here, the operator type is minus, and there is no lef
                                Operation.Rightside += input[i];
                            }
                            else
                            {
                                // Calculate previous equation and set to the left side
                                Operation.Leftside = CalculateOperation(Operation);

                                // Set new operator
                                Operation.OperationType = operatorType;

                                // Clear the previous right number
                                Operation.Rightside = string.Empty;

                            }

                        }
                        else
                        {

                            // Get the operator type
                            var operatorType = GetOperationType(input[i]);

                            // Check if we actually have a left side number
                            if (Operation.Leftside.Length == 0)
                            {

                                // Check the operator is not a minus (as they could be creating a negative number)
                                if (operatorType != OperationType.Minus)
                                    throw new InvalidOperationException($"Operator (+ * / or more than one -) specified without an left side number");

                                // If we got here, the operator is a minus, and there is no left number currently, so add the minus to the number
                                Operation.Leftside += input[i];
                            }
                            else
                            {
                                // If we get here, we have a left number and now an operator, so we want to move to the right side

                                // Set the operation type
                                Operation.OperationType = operatorType;

                                // Mobe to the right side
                                Leftside = false;   

                            }

                        }

                    }
                }

                // If we are done parsing, and there were no exceptions
                // Calculate the current operation
                return CalculateOperation(Operation);

            }
            catch (Exception ex)
            {
                return $"Invalid equation. {ex.Message}";
            }
        }
        /// <summary>
        /// Calculates an <see cref="Operation"/> and returns the result
        /// </summary>
        /// <param name="Operation">The operation to calculate</param>
        
        private string CalculateOperation(Operation Operation)
        {
            // Store the number value of the string representations
            decimal left = 0;
            decimal right = 0;

            // Check if we have a valid left side number
            if (string.IsNullOrEmpty(Operation.Leftside) || !decimal.TryParse(Operation.Leftside, out left))
                throw new InvalidOperationException($"Left side of the operation was not a number. {Operation.Leftside}");

            // Check if we have a valid right side number
            if (string.IsNullOrEmpty(Operation.Rightside) || !decimal.TryParse(Operation.Rightside, out right))
                throw new InvalidOperationException($"Right side of the operation was not a number. {Operation.Rightside}");

            try
            {
                switch (Operation.OperationType)
                {
                    case OperationType.Add:
                        return (left + right).ToString();
                    case OperationType.Minus:
                        return (left - right).ToString();
                    case OperationType.Divide:  
                        return (left / right).ToString();   
                    case OperationType.Multiply:
                        return (left * right).ToString();
                        
                    default:
                        throw new InvalidOperationException($"Unknown operator type when calculating operation. {Operation.OperationType }");


                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to calculate operation {Operation.Leftside} {Operation.OperationType}{Operation.Rightside}. {ex.Message}");
                
            }    
            
        }

        /// <summary>
        /// Accepts a character and returns the known <see cref="OperationType"/>
        /// </summary>
        /// <param name="character">The Character to parse</param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        private OperationType GetOperationType(char character)

        {
            switch (character)
            {
                case '+':
                    return OperationType.Add;

                case '-':
                    return OperationType.Minus;
                case '*':
                    return OperationType.Multiply;
                case '/':
                    return OperationType.Divide;
                default:
                    throw new InvalidOperationException($"Unknown operator type {character}");

            }


        

        }

        /// <summary>
        /// Attempts to add a new character to the current number, checking for valid characters as it goes
        /// </summary>
        /// <param name="currentNumber">The current number string</param>
        /// <param name="newCharacter">The new character to append to the string</param>
        /// <returns></returns>
        
        private string AddNumberPart(string currentNumber, char newCharacter)
        {
            // Check if there is already a . in the number
            if (newCharacter == '.' && currentNumber.Contains('.'))
                throw new InvalidOperationException($"Number {currentNumber} already contains a . and another cannot be added");
           
            return currentNumber + newCharacter;
    }

        private void CalculationResultText_Click(object sender, EventArgs e)
        {

        }
    }

    



        #endregion


   
}
