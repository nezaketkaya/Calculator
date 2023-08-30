using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class BarbieCalculator : Form
    {

        private char _operation;
        bool _clearScreen;
        int _number1;
        int _result;
        int _tempResult;
        public BarbieCalculator()
        {
            InitializeComponent();
        }
    
    private void num1Button_Click(object sender, EventArgs e)
    {
        if (_clearScreen) { screenLabel.Text = ""; _clearScreen = false; }
        if (screenLabel.Text == "0") { screenLabel.Text = ""; }
        screenLabel.Text += "1";
    }

        private void num2Button_Click(object sender, EventArgs e)
        {
            if (_clearScreen) { screenLabel.Text = ""; _clearScreen = false; }
            if (screenLabel.Text == "0") { screenLabel.Text = ""; }
            screenLabel.Text += "2";
        }
        private void num3Button_Click(object sender, EventArgs e)
        {
            if (_clearScreen) { screenLabel.Text = ""; _clearScreen = false; }
            if (screenLabel.Text == "0") { screenLabel.Text = ""; }
            screenLabel.Text += "3";
        }
    
        private void num4Button_Click(object sender, EventArgs e)
        {
            if (_clearScreen) { screenLabel.Text = ""; _clearScreen = false; }
            if (screenLabel.Text == "0") { screenLabel.Text = ""; }
            screenLabel.Text += "4";
        }

        private void num5Button_Click(object sender, EventArgs e)
        {
            if (_clearScreen) { screenLabel.Text = ""; _clearScreen = false; }
            if (screenLabel.Text == "0") { screenLabel.Text = ""; }
            screenLabel.Text += "5";
        }

        private void num6Button_Click(object sender, EventArgs e)
        {
            if (_clearScreen) { screenLabel.Text = ""; _clearScreen = false; }
            if (screenLabel.Text == "0") { screenLabel.Text = ""; }
            screenLabel.Text += "6";
        }

        private void num7Button_Click(object sender, EventArgs e)
        {
            if (_clearScreen) { screenLabel.Text = ""; _clearScreen = false; }
            if (screenLabel.Text == "0") { screenLabel.Text = ""; }
            screenLabel.Text += "7";
        }

        private void num8Button_Click(object sender, EventArgs e)
        {
            if (_clearScreen) { screenLabel.Text = ""; _clearScreen = false; }
            if (screenLabel.Text == "0") { screenLabel.Text = ""; }
            screenLabel.Text += "8";
        }

        private void num9Button_Click(object sender, EventArgs e)
        {
            if (_clearScreen) { screenLabel.Text = ""; _clearScreen = false; }
            if (screenLabel.Text == "0") { screenLabel.Text = ""; }
            screenLabel.Text += "9";
        }
    
        private void num0Button_Click(object sender, EventArgs e)
        {
            if (_clearScreen) { screenLabel.Text = ""; _clearScreen = false; }
            if (screenLabel.Text == "0") { screenLabel.Text = ""; }
            screenLabel.Text += "0";
        }

        private void addition_Click(object sender, EventArgs e)
        {
            _operation = '+';

            _number1 = Convert.ToInt32(screenLabel.Text);
            _result += _number1;
            _clearScreen = true;
        }
        private void subtraction_Click(object sender, EventArgs e)
        {
            _operation = '-'; 
            _number1 = 0;
            _number1 = Convert.ToInt32(screenLabel.Text);
            
            if (_result == 0)
            {
                _result = _number1;
            }
            else
            {
                _result -= _number1;
            }
           
            _clearScreen = true;
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            _operation = '*';
            _number1 = 0;
            _number1 = Convert.ToInt32(screenLabel.Text);
            if (_result == 0)
            {
                _result = _number1;
            }
            else
            {
               _result = _result * _number1;
            }
            
            _clearScreen = true;
        }
        private void division_Click(object sender, EventArgs e)
        {
            _operation = '/';
            _number1 = 0;
            _number1 = Convert.ToInt32(screenLabel.Text);
            if (_result == 0)
            {
                _result = _number1;
            }
            else
            {
                _result = _result / _number1;
            }
            _clearScreen = true;
        }

        private void power_Click(object sender, EventArgs e)
        {
            _operation = '^';
            _result = Convert.ToInt32(screenLabel.Text);
            _tempResult = _result;
            _clearScreen = true;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            screenLabel.Text = "0";
        }

        private void clearEndNum_Click(object sender, EventArgs e)
        {
            _result = Convert.ToInt32(screenLabel.Text);
            if (_result != 0)
            {
                _result = _result / 10;
                screenLabel.Text = Convert.ToString(_result);
            }
        }

        private void equals_Click(object sender, EventArgs e)
        {
            switch (_operation)
            {
                case ('+'):
                    _number1 = Convert.ToInt32(screenLabel.Text);
                    _result += _number1;
                    screenLabel.Text = Convert.ToString(_result);
                    break;
                    
                case ('-'):
                    _number1 = 0;
                    _number1 = Convert.ToInt32(screenLabel.Text);
                    _result -= _number1;
                    screenLabel.Text = Convert.ToString(_result);
                    break;

                case ('*'):
                    _number1 = 0;
                    _number1 = Convert.ToInt32(screenLabel.Text);
                    _result = _result * _number1;
                    screenLabel.Text = Convert.ToString(_result);
                    break;

                case ('/'):
                    _number1 = 0;
                    _number1 = Convert.ToInt32(screenLabel.Text);
                    _result = _result / _number1;
                    screenLabel.Text = Convert.ToString(_result);
                    break;

                case ('^'):
                    _number1 = Convert.ToInt32(screenLabel.Text);
                    for (int i = 1; i < _number1; i++)
                    {
                        _result *= _tempResult;
                    }
                    screenLabel.Text = Convert.ToString(_result);
                    break;

                default:
                    break;
            }    
        }
    }
}