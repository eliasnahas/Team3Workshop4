using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team3Workshop4
{
    /// <summary>
    /// a repository of validation methods
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// tests if a textbox contains non-empty string
        /// </summary>
        /// <param name="textBox">text box to check</param>
        /// <returns>true is valid and false if not</returns>
        public static bool IsPresent(TextBox textBox)
        {
            bool isValid = true; //"innocent until proven guilty"
            if(textBox.Text == "")
            {
                isValid = false;
                MessageBox.Show($"{textBox.Tag} is required");
                textBox.Focus(); 
            }
            return isValid;
        }

        /// <summary>
        /// tests if a text box contains int that is >= 0
        /// </summary>
        /// <param name="textBox">text box to check</param>
        /// <returns>true is valid and false if not</returns>
        public static bool IsNonNegativeInt(TextBox textBox)
        {
            bool isValid = true;
            int value; // parsed value if successful
            if(!Int32.TryParse(textBox.Text, out value)) // not an int
            {
                isValid = false;
                MessageBox.Show($"{textBox.Tag} must be a whole number");
                textBox.SelectAll();
                textBox.Focus();
            }
            else if (value < 0) // an int, but negative
            {
                isValid = false;
                MessageBox.Show($"{textBox.Tag} must be positive or zero");
                textBox.SelectAll();
                textBox.Focus();
            }
            return isValid;
        }

        /// <summary>
        /// tests if the text box contains non-negative double value
        /// </summary>
        /// <param name="textBox">text box to check</param>
        /// <returns>true if valid and false if not</returns>       
        public static bool IsNonNegativeDouble(TextBox textBox)
        {
            bool isValid = true;
            double value; // parsed value if successful
            if (!Double.TryParse(textBox.Text, out value)) // not a double
            {
                isValid = false;
                MessageBox.Show($"{textBox.Tag} must be a number");
                textBox.SelectAll();
                textBox.Focus();
            }
            else if (value < 0) // a double, but negative
            {
                isValid = false;
                MessageBox.Show($"{textBox.Tag} must be positive or zero");
                textBox.SelectAll();
                textBox.Focus();
            }
            return isValid;
        }
        /// <summary>
        /// tests if the text box contains non-negative decimal value
        /// </summary>
        /// <param name="textBox">text box to check</param>
        /// <returns>true if valid and false if not</returns>       
        public static bool IsNonNegativeDecimal(TextBox textBox)
        {
            bool isValid = true;
            decimal value; // parsed value if successful
            if (!Decimal.TryParse(textBox.Text, out value) && (textBox.Text != "")) // not a decimal and is not empty
            {
                isValid = false;
                MessageBox.Show($"{textBox.Tag} must be a number");
                textBox.SelectAll();
                textBox.Focus();
            }
            else if (value < 0) // a decimal, but negative
            {
                isValid = false;
                MessageBox.Show($"{textBox.Tag} must be positive or zero");
                textBox.SelectAll();
                textBox.Focus();
            }
            return isValid;
        }

        /// <summary>
        /// tests if the text box contains a decimal value within range
        /// </summary>
        /// <param name="textBox">text box to check</param>
        /// <param name="minValue">minimum value for the range</param>
        /// <param name="maxValue">maximum value for the range</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsDecimalInRange(TextBox textBox,
            decimal minValue, decimal maxValue)
        {
            bool isValid = true;
            decimal value; // parsed value if successful
            if (!Decimal.TryParse(textBox.Text, out value)) // not a decimal
            {
                isValid = false;
                MessageBox.Show($"{textBox.Tag} must be a number");
                textBox.SelectAll();
                textBox.Focus();
            }
            else if (value < minValue || value > maxValue) // a decimal, but out of range
            {
                isValid = false;
                MessageBox.Show($"{textBox.Tag} must be between {minValue} and {maxValue}");
                textBox.SelectAll();
                textBox.Focus();
            }
            return isValid;
        }

        /// <summary>
        /// tests if the text box contains a decimal value with the correct length and precision
        /// </summary>
        /// <param name="textBox">text box to check</param>
        /// <param name="length">length of entire decimal including trailing numbers</param>
        /// <param name="precision">precision of decimal</param>
        /// <returns></returns>
        public static bool IsDecimalMaxPrecision(TextBox textBox, int length, int precision)
        {
            bool isValid = true;
            decimal value;
            string valueString;
            string[] valueParts;
            if (!Decimal.TryParse(textBox.Text, out value)) // not a decimal
            {
                isValid = false;
                MessageBox.Show($"{textBox.Tag} must be a number");
                textBox.SelectAll();
                textBox.Focus();
            }
            else 
            {
                // trailing zeros solution: https://www.blackwasp.co.uk/DecimalTrailingZeroes.aspx
                valueString = value.ToString("0.############################"); // gets rid of trailing zeros
                valueParts = valueString.Split('.'); // splits decimal string into its parts
                if (valueParts.Length == 1) // does not contain a decimal
                {
                    if (valueString.Length > (length - precision)) // is too long
                    {
                        isValid = false;
                        MessageBox.Show($"{textBox.Tag} must be {length} digit(s) long including {precision} digit(s) after the decimal");
                        textBox.SelectAll();
                        textBox.Focus();
                    }
                }
                else if ((valueParts[0].Length + valueParts[1].Length) > length) // has decimal and is too long
                {
                    isValid = false;
                    MessageBox.Show($"{textBox.Tag} must be {length} digit(s) long including {precision} digit(s) after the decimal");
                    textBox.SelectAll();
                    textBox.Focus();
                }
                else if (valueParts[1].Length > precision) // contains too many values after decimal
                {
                    isValid = false;
                    MessageBox.Show($"{textBox.Tag} cannot have more than {precision} digit(s) after the decimal");
                    textBox.SelectAll();
                    textBox.Focus();
                }

            }
            return isValid;
        }

        /// <summary>
        /// tests if teh text box contains an integer value within range
        /// </summary>
        /// <param name="textBox">text box to check</param>
        /// <param name="minValue">minimum value for the range</param>
        /// <param name="maxValue">maximum value for the range</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsIntInRange(TextBox textBox, int minValue, int maxValue)
        {
            bool isValid = true;
            int value; // parsed value if successful
            if (!Int32.TryParse(textBox.Text, out value)) // not an int
            {
                isValid = false;
                MessageBox.Show($"{textBox.Tag} must be a number");
                textBox.SelectAll();
                textBox.Focus();
            }
            else if (value < minValue || value > maxValue) // an int, but out of range
            {
                isValid = false;
                MessageBox.Show($"{textBox.Tag} must be between {minValue} and {maxValue}");
                textBox.SelectAll();
                textBox.Focus();
            }
            return isValid;
        }

        /// <summary>
        /// tests if the text box contains a double value within range
        /// </summary>
        /// <param name="textBox"> text box to check</param>
        /// <param name="minValue">minimum value for the range</param>
        /// <param name="maxValue">maximum value for the range</param>
        /// <returns></returns>
        public static bool IsDoubleInRange(TextBox textBox,
            double minValue, double maxValue)
        {
            bool isValid = true;
            double value; // parsed value if successful
            if (!Double.TryParse(textBox.Text, out value)) // not a double
            {
                isValid = false;
                MessageBox.Show($"{textBox.Tag} must be a number");
                textBox.SelectAll();
                textBox.Focus();
            }
            else if (value < minValue || value > maxValue) // a double, but out of range
            {
                isValid = false;
                MessageBox.Show($"{textBox.Tag} must be between {minValue} and {maxValue}");
                textBox.SelectAll();
                textBox.Focus();
            }
            return isValid;
        }

        /// <summary>
        /// test if an item in the list box is selected
        /// </summary>
        /// <param name="listBox">list box to check</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsSelected(ListBox listBox)
        {
            bool isValid = true;
            if (listBox.SelectedIndex == -1) // not selected
            {
                isValid = false;
                MessageBox.Show($"{listBox.Tag} must be selected");
                listBox.Focus();
            }
            return isValid;
        }

        /// <summary>
        /// test if an item in the combo box is selected
        /// </summary>
        /// <param name="comboBox">combo box to check</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsSelected(ComboBox comboBox)
        {
            bool isValid = true;
            if (comboBox.SelectedIndex == -1)
            {
                isValid = false;
                MessageBox.Show($"{comboBox.Tag} must be selected");
                comboBox.Focus();
            }
            return isValid;
        }

        /// <summary>
        /// test if a date occurs before another date
        /// </summary>
        /// <param name="dateEarlier">earlier date to test</param>
        /// <param name="dateLater"></param>
        /// <returns></returns>
        public static bool IsValidDateRange(DateTimePicker? dateEarlier, DateTimePicker? dateLater)
        {
            bool isValid = true;
            DateTime? valueEarlier; // parsed value if successful
            DateTime? valueLater;
            if (dateEarlier.Value != null && dateLater.Value != null)
            {
                valueEarlier = dateEarlier.Value;
                valueLater = dateLater.Value;

                if (valueEarlier > valueLater)
                {
                    isValid = false;
                    MessageBox.Show($"{dateEarlier.Tag} must be earlier than {dateLater.Tag}");
                }
            }
            return isValid;
        }

    } // class
} // namespace
