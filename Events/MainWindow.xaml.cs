using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace Events
{
    public partial class MainWindow : Window
    {
        private TimerWrapper _timer;

        private int _secondsPassed;

        private double _first, _second, result;

        TextBox textBox;

        public MainWindow()
        {
            InitializeComponent();

            _timer = new TimerWrapper(new DispatcherTimer(), TimerTick);
        }
        
        //1
        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {
            _timer.Start();
        }

        private void ButtonStop_Click(object sender, RoutedEventArgs e)
        {
            _timer.Stop();
        }

        private void ButtonReset_Click(object sender, RoutedEventArgs e)
        {
            _timer.Stop();
            _secondsPassed = 0;
            LabelTimer.Content = "00:00:00";
        }

        private void TimerTick(object sender, EventArgs e)
        {
            _secondsPassed++;
            LabelTimer.Content = TimePassed();
        }

        private string TimePassed()
        {
            return TimeSpan.FromSeconds(_secondsPassed).ToString();
        }

        //2
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            result = _first + _second;
            CalculationResult(result);
        }

        private void Sub_Click(object sender, RoutedEventArgs e)
        {
            result = _first - _second;
            CalculationResult(result);
        }

        private void Mul_Click(object sender, RoutedEventArgs e)
        {
            result = _first * _second;
            CalculationResult(result);
        }

        private void Div_Click(object sender, RoutedEventArgs e)
        {
            result = _first / _second;
            CalculationResult(result);
        }

        private void FirstNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            textBox = sender as TextBox;
            AssignmentOperands(textBox.Text, ref _first);
        }

        private void SecondNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            textBox = sender as TextBox;
            AssignmentOperands(textBox.Text, ref _second);
        }

        private void CalculationResult(double result)
        {
            Result.Text = result.ToString();
        }

        private void AssignmentOperands(string input, ref double operand)
        {
            bool result = Double.TryParse(input, out double num);
            if (result)
            {
                operand = num;
            }
        }
    }
}
