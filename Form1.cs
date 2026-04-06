using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        private double? _accumulator;
        private string _pendingOperator;
        private bool _isNewEntry = true;
        private bool _hasError;
        private double _memoryValue;
        private bool _isDarkMode;

        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            ApplyTheme();
            UpdateDisplay("0");
        }

        private void DigitButton_Click(object sender, EventArgs e)
        {
            if (_hasError)
            {
                ClearAll();
            }

            var digit = ((Button)sender).Text;
            if (_isNewEntry || displayTextBox.Text == "0")
            {
                UpdateDisplay(digit);
                _isNewEntry = false;
                return;
            }

            UpdateDisplay(displayTextBox.Text + digit);
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            if (_hasError)
            {
                ClearAll();
            }

            if (_isNewEntry)
            {
                UpdateDisplay("0.");
                _isNewEntry = false;
                return;
            }

            if (!displayTextBox.Text.Contains("."))
            {
                UpdateDisplay(displayTextBox.Text + ".");
            }
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            if (_hasError)
            {
                return;
            }

            var op = ((Button)sender).Text;
            var current = GetCurrentDisplayValue();

            if (_accumulator.HasValue && !_isNewEntry)
            {
                if (!TryEvaluate(_accumulator.Value, current, _pendingOperator, out var result))
                {
                    ShowError();
                    return;
                }

                _accumulator = result;
                UpdateDisplay(FormatNumber(result));
            }
            else
            {
                _accumulator = current;
            }

            _pendingOperator = op;
            _isNewEntry = true;
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            if (_hasError || !_accumulator.HasValue || string.IsNullOrWhiteSpace(_pendingOperator))
            {
                return;
            }

            var current = GetCurrentDisplayValue();
            if (!TryEvaluate(_accumulator.Value, current, _pendingOperator, out var result))
            {
                ShowError();
                return;
            }

            UpdateDisplay(FormatNumber(result));
            _accumulator = null;
            _pendingOperator = null;
            _isNewEntry = true;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void BackspaceButton_Click(object sender, EventArgs e)
        {
            if (_hasError)
            {
                ClearAll();
                return;
            }

            if (_isNewEntry)
            {
                return;
            }

            if (displayTextBox.Text.Length <= 1)
            {
                UpdateDisplay("0");
                _isNewEntry = true;
                return;
            }

            UpdateDisplay(displayTextBox.Text.Substring(0, displayTextBox.Text.Length - 1));
        }

        private void PercentButton_Click(object sender, EventArgs e)
        {
            if (_hasError)
            {
                return;
            }

            var current = GetCurrentDisplayValue();
            var result = _accumulator.HasValue ? (_accumulator.Value * current) / 100.0 : current / 100.0;
            UpdateDisplay(FormatNumber(result));
            _isNewEntry = true;
        }

        private void SqrtButton_Click(object sender, EventArgs e)
        {
            if (_hasError)
            {
                return;
            }

            var current = GetCurrentDisplayValue();
            if (current < 0)
            {
                ShowError();
                return;
            }

            UpdateDisplay(FormatNumber(Math.Sqrt(current)));
            _isNewEntry = true;
        }

        private void MemoryClearButton_Click(object sender, EventArgs e)
        {
            _memoryValue = 0;
        }

        private void MemoryRecallButton_Click(object sender, EventArgs e)
        {
            UpdateDisplay(FormatNumber(_memoryValue));
            _isNewEntry = true;
        }

        private void MemoryPlusButton_Click(object sender, EventArgs e)
        {
            _memoryValue += GetCurrentDisplayValue();
            _isNewEntry = true;
        }

        private void MemoryMinusButton_Click(object sender, EventArgs e)
        {
            _memoryValue -= GetCurrentDisplayValue();
            _isNewEntry = true;
        }

        private void DarkModeButton_Click(object sender, EventArgs e)
        {
            _isDarkMode = !_isDarkMode;
            ApplyTheme();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                PerformClickByText(((char)e.KeyCode).ToString());
                e.Handled = true;
                return;
            }

            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                PerformClickByText(((int)e.KeyCode - (int)Keys.NumPad0).ToString());
                e.Handled = true;
                return;
            }

            switch (e.KeyCode)
            {
                case Keys.Add:
                case Keys.Oemplus when e.Shift:
                    PerformClickByText("+");
                    break;
                case Keys.Subtract:
                case Keys.OemMinus:
                    PerformClickByText("-");
                    break;
                case Keys.Multiply:
                    PerformClickByText("*");
                    break;
                case Keys.Divide:
                case Keys.OemQuestion:
                    PerformClickByText("/");
                    break;
                case Keys.Decimal:
                case Keys.OemPeriod:
                case Keys.Oemcomma:
                    decimalButton.PerformClick();
                    break;
                case Keys.Enter:
                    equalsButton.PerformClick();
                    break;
                case Keys.Back:
                    backspaceButton.PerformClick();
                    break;
                case Keys.Escape:
                    clearButton.PerformClick();
                    break;
                default:
                    return;
            }

            e.Handled = true;
        }

        private void PerformClickByText(string text)
        {
            foreach (Control control in Controls)
            {
                if (control is Button button && button.Text == text)
                {
                    button.PerformClick();
                    return;
                }
            }
        }

        private bool TryEvaluate(double left, double right, string op, out double result)
        {
            switch (op)
            {
                case "+":
                    result = left + right;
                    return true;
                case "-":
                    result = left - right;
                    return true;
                case "*":
                    result = left * right;
                    return true;
                case "/":
                    if (Math.Abs(right) < double.Epsilon)
                    {
                        result = 0;
                        return false;
                    }

                    result = left / right;
                    return true;
                default:
                    result = right;
                    return true;
            }
        }

        private void ClearAll()
        {
            _accumulator = null;
            _pendingOperator = null;
            _isNewEntry = true;
            _hasError = false;
            UpdateDisplay("0");
        }

        private void ShowError()
        {
            _hasError = true;
            _accumulator = null;
            _pendingOperator = null;
            _isNewEntry = true;
            UpdateDisplay("Cannot divide by zero");
        }

        private double GetCurrentDisplayValue()
        {
            if (double.TryParse(
                    displayTextBox.Text.Replace(',', '.'),
                    NumberStyles.Float,
                    CultureInfo.InvariantCulture,
                    out var value))
            {
                return value;
            }

            return 0;
        }

        private string FormatNumber(double value)
        {
            return value.ToString("G15", CultureInfo.InvariantCulture);
        }

        private void UpdateDisplay(string value)
        {
            displayTextBox.Text = value;
        }

        private void ApplyTheme()
        {
            var background = _isDarkMode ? Color.FromArgb(35, 35, 35) : Color.WhiteSmoke;
            var foreground = _isDarkMode ? Color.Gainsboro : Color.Black;
            var buttonBack = _isDarkMode ? Color.FromArgb(55, 55, 55) : Color.White;
            var accent = _isDarkMode ? Color.FromArgb(85, 120, 240) : Color.RoyalBlue;

            BackColor = background;
            displayTextBox.BackColor = _isDarkMode ? Color.FromArgb(22, 22, 22) : Color.White;
            displayTextBox.ForeColor = foreground;

            foreach (Control control in Controls)
            {
                if (!(control is Button button))
                {
                    continue;
                }

                button.BackColor = buttonBack;
                button.ForeColor = foreground;
                button.FlatAppearance.BorderColor = _isDarkMode ? Color.DimGray : Color.Silver;

                if (button.Tag != null && button.Tag.ToString() == "accent")
                {
                    button.BackColor = accent;
                    button.ForeColor = Color.White;
                }
            }
        }
    }
}
