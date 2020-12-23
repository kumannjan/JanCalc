using System;
using System.Windows.Forms;

namespace JanCalc
{
    public partial class Form1 : Form
    {
        public char PreviousKey=(char)0;
        public Form1()
        {
            InitializeComponent();
            textBox1.SelectionLength = 0;
        }

        private void Clear(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void One(object sender, EventArgs e)
        {
            DisplayDigit('1');
        }

        private void Two(object sender, EventArgs e)
        {
            DisplayDigit('2');
        }

        private void Three(object sender, EventArgs e)
        {
            DisplayDigit('3');
        }

        private void Four(object sender, EventArgs e)
        {
            DisplayDigit('4');
        }

        private void Five(object sender, EventArgs e)
        {
            DisplayDigit('5');
        }

        private void Six(object sender, EventArgs e)
        {
            DisplayDigit('6');
        }

        private void Seven(object sender, EventArgs e)
        {
            DisplayDigit('7');
        }

        private void Eigth(object sender, EventArgs e)
        {
            DisplayDigit('8');
        }

        private void Nine(object sender, EventArgs e)
        {
            DisplayDigit('9');
        }

        private void Zero(object sender, EventArgs e)
        {
            DisplayDigit('0');
        }

        private void Plus(object sender, EventArgs e)
        {
            DisplayDigit('+');
        }

        private void Minus(object sender, EventArgs e)
        {
            DisplayDigit('-');
        }

        private void Times(object sender, EventArgs e)
        {
            DisplayDigit('X');
        }

        private void Divide(object sender, EventArgs e)
        {
            DisplayDigit(':');
        }

        private void Comma(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(",")) {
                if (textBox1.Text.Contains("+") || textBox1.Text.Contains("-") || textBox1.Text.Contains("*") || textBox1.Text.Contains(":")) {
                    DisplayDigit(',');
                    return;
                }
            }
            if (textBox1.Text[textBox1.TextLength - 1] != ',')
            {
                if (textBox1.Text.Length <= 1)
                    DisplayDigit('0');
            }
            DisplayDigit(',');
        }
        private void Equals(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 2)
            {
                int i;
                double a,b,c;
                if (textBox1.Text.Contains("+"))
                {
                    i = textBox1.Text.IndexOf('+');
                    a = double.Parse(textBox1.Text.Substring(0, i));

                    b = double.Parse(textBox1.Text.Substring(i, textBox1.Text.Length - i));
                    c = a + b;
                    textBox1.Text = "= " + c;
                }
                else if (textBox1.Text.Contains("-"))
                {
                    i = textBox1.Text.IndexOf('-');
                    a = float.Parse(textBox1.Text.Substring(0, i));
                    b = float.Parse(textBox1.Text.Substring(i + 1, textBox1.Text.Length - i - 1));
                    c = a - b;
                    textBox1.Text = "= " + c;
                }
                else if (textBox1.Text.Contains("X"))
                {
                    i = textBox1.Text.IndexOf('X');
                    a = float.Parse(textBox1.Text.Substring(0, i));
                    b = float.Parse(textBox1.Text.Substring(i + 1, textBox1.Text.Length - i - 1));
                    c = a * b;
                    textBox1.Text = "= " + c;
                }
                else if (textBox1.Text.Contains(":"))
                {
                    i = textBox1.Text.IndexOf(':');
                    a = float.Parse(textBox1.Text.Substring(0, i));
                    b = float.Parse(textBox1.Text.Substring(i + 1, textBox1.Text.Length - i - 1));
                    if (b == 0)
                    {
                        textBox1.Text = "ERR";
                    }
                    else
                    {
                        c = a / b;
                        textBox1.Text = "= " + c;
                    }
                }
            }
        }

        public void DisplayDigit(char d)
        {
            if (textBox1.Text.Length < textBox1.MaxLength)
            {
                if (textBox1.Text.Contains("=") || textBox1.Text.Contains("ERR"))
                    textBox1.Text = "0";
                if (d >= '0' && d <= '9')
                {
                    if (textBox1.Text.Length == 1 && textBox1.Text == "0")
                    {
                        textBox1.Text = d.ToString();
                    }
                    else
                        textBox1.Text += d.ToString();
                }
                else
                {
                    if (textBox1.Text.Length > 1)
                    {
                        textBox1.Text += d.ToString();
                    }
                    else if (textBox1.Text != "0")
                    {
                        textBox1.Text += d.ToString();
                    }
                }
                PreviousKey = d;
            }
        }

        private void Backspace(object sender, EventArgs e)
        {
            if(textBox1.TextLength > 1)
            {
                if (textBox1.Text.Contains("=") || textBox1.Text.Contains("ERR"))
                    textBox1.Text = "0";
                else
                    textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1);
            }
            else if (textBox1.TextLength == 1)
            {
                textBox1.Text = "0";
            }
        }

        private void KeyboardKeyPressed(object sender, KeyPressEventArgs e)
        {
           switch (e.KeyChar)
            {
                case (char)48:
                    Zero(sender, e);
                    break;
                case (char)49:
                    One(sender, e);
                    break;
                case (char)50:
                    Two(sender, e);
                    break;
                case (char)51:
                    Three(sender, e);
                    break;
                case (char)52:
                    Four(sender, e);
                    break;
                case (char)53:
                    Five(sender, e);
                    break;
                case (char)54:
                    Six(sender, e);
                    break;
                case (char)55:
                    Seven(sender, e);
                    break;
                case (char)56:
                    Eigth(sender, e);
                    break;
                case (char)57:
                    Nine(sender, e);
                    break;
                case 'X':
                    Times(sender, e);
                    break;
                case 'x':
                    Times(sender, e);
                    break;
                case '*':
                    Times(sender, e);
                    break;
                case ':':
                    Divide(sender, e);
                    break;
                case '/':
                    Divide(sender, e);
                    break;
                case '+':
                    Plus(sender, e);
                    break;
                case '-':
                    Minus(sender, e);
                    break;
                case ',':
                    Comma(sender, e);
                    break;
                case 'c':
                    Clear(sender, e);
                    break;
                case 'C':
                    Clear(sender, e);
                    break;
                case (char)13:
                    Equals(sender, e);
                    break;
                case (char)8:
                    Backspace(sender, e);
                    break;
            }
            e.Handled = true;
            return;
        }
    }
}
