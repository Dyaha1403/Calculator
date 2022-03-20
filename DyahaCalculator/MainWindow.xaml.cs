using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;
using ClassLibraryCalculator;

namespace DyahaCalculator
{
    public partial class MainWindow : Window
    {

        Calculator Calculator = new Calculator();
        bool ButtonRangeOnClick = false;

        public MainWindow()
        {
            InitializeComponent();
            InputBox.Text = "0";
            TextBoxFirstLimit.Text = Calculator.firstLimit.ToString();
            TextBoxSecondLimit.Text = Calculator.secondLimit.ToString();
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void ButtonClean_Click(object sender, RoutedEventArgs e)
        {
            if (InputBox.Text == "На ноль делить нельзя" || InputBox.Text == "Ошибка ввода" || InputBox.Text == "Переполнение")
            {
                InputBox.FontSize = 30;
                ButtonOperationGrid.IsEnabled = true;
                ButtonChangeSign.IsEnabled = true;
            }

            InputBox.Text = "0";
            ResultText.Content = "";
            Calculator.Clean();
        }
        private void ButtonErase_Click(object sender, RoutedEventArgs e)
        {
            if (InputBox.Text == "На ноль делить нельзя" || InputBox.Text == "Ошибка ввода" || InputBox.Text == "Переполнение")
            {
                InputBox.FontSize = 30;
                InputBox.Text = "0";
                Calculator.Clean();
                ResultText.Content = "";
                ButtonOperationGrid.IsEnabled = true;
                ButtonChangeSign.IsEnabled = true;
            }

            string ChangedText = InputBox.Text.Remove(InputBox.Text.Length - 1);

            if(Convert.ToString(ResultText.Content).IndexOf("=") != -1)
            {
                ResultText.Content = "";
            }

            if (ChangedText == "")
            {
                ChangedText = "0";
            }
            
            if(ChangedText[ChangedText.Length - 1] == ',')
            {
                ChangedText = ChangedText.Remove(ChangedText.Length - 1);
            }

            InputBox.Text = ChangedText;
        }
        private void ButtonNum_Click(object sender, RoutedEventArgs e)
        {
            Button Num = (Button)sender;

            if (InputBox.Text == "На ноль делить нельзя" || InputBox.Text == "Ошибка ввода" || InputBox.Text == "Переполнение")
            {
                InputBox.FontSize = 30;
                InputBox.Text = "0";             
                ButtonOperationGrid.IsEnabled = true;
                ButtonChangeSign.IsEnabled = true;
                ResultText.Content = "";
                Calculator.Clean();
            }
            
            if (!Calculator.InputNum(InputBox.Text, Num.Content.ToString()))
            {
                return;
            }
            
            if (InputBox.Text == "0")
            {
                InputBox.Text = "";
            }
            
            if (Convert.ToString(ResultText.Content).IndexOf("=") != -1)
            {
                ResultText.Content = "";
            }

            InputBox.Text += Num.Content.ToString();
        }
        private void ButtonDefaultOperation_Click(object sender, RoutedEventArgs e)
        {
            Button Operation = (Button)sender;

            if (Calculator.operation == "/" && InputBox.Text == "0")
            {
                ResultText.Content += InputBox.Text;
                InputBox.FontSize = 23;
                InputBox.Text = "На ноль делить нельзя";
                ButtonOperationGrid.IsEnabled = false;
                ButtonChangeSign.IsEnabled = false;
                Calculator.Clean();
                ResultText.Content += Operation.Content.ToString();
                return;
            }

            if (Calculator.operation == "")
            {
                Calculator.num_1 = InputBox.Text;
                InputOperation(Operation.Content.ToString());
                return;
            }

            if (ResultText.Content.ToString().IndexOf("=") == -1)
            {
                Calculator.num_2 = InputBox.Text;
                Calculator.num_1 = Calculator.CalculationResult();
            }
            else
            {
                Calculator.num_1 = InputBox.Text;
                Calculator.num_2 = "";
            }

            InputOperation(Operation.Content.ToString());
        }
        private void ButtonSin_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToString(ResultText.Content).IndexOf("=") != -1)
            {
                ResultText.Content = "";
                Calculator.num_2 = "";
            }

            InputBox.Text = Convert.ToString(Calculator.CalculatorSin(Convert.ToDouble(InputBox.Text)));
        }
        private void ButtonRoot_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToString(ResultText.Content).IndexOf("=") != -1)
            {
                ResultText.Content = "";
                Calculator.num_2 = "";
            }

            if(Calculator.CalculatorRoot(Convert.ToDouble(InputBox.Text)) == -1)
            {
                InputBox.Text = "Ошибка ввода";
                ResultText.Content = "";
                Calculator.num_1 = "";
                ButtonOperationGrid.IsEnabled = false;
                ButtonChangeSign.IsEnabled = false;
                return;
            }

            InputBox.Text = Convert.ToString(Calculator.CalculatorRoot(Convert.ToDouble(InputBox.Text)));
        }
        private void ButtonSquare_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToString(ResultText.Content).IndexOf("=") != -1)
            {
                ResultText.Content = "";
                Calculator.num_2 = "";
            }

            string num= Convert.ToString(Calculator.CalculatorSquare(Convert.ToDouble(InputBox.Text)));

            if (num == "-1")
            {
                InputBox.Text = "Переполнение";
                ResultText.Content = "";
                Calculator.num_1 = "";
                ButtonOperationGrid.IsEnabled = false;
                ButtonChangeSign.IsEnabled = false;
                return;
            }

            InputBox.Text = num;
        }
        private void ButtonChangeSign_Click(object sender, RoutedEventArgs e)
        {
            if(InputBox.Text == "0" || !Calculator.CheckRange((Convert.ToDouble(InputBox.Text) * -1).ToString()))
            {
                return;
            }

            if (Convert.ToString(ResultText.Content).IndexOf("=") != -1)
            {
                ResultText.Content = "";
                Calculator.num_2 = "";
            }

            InputBox.Text = (Convert.ToDouble(InputBox.Text) * -1).ToString();

            if (Convert.ToString(ResultText.Content) == "")
            {
                Calculator.num_1 = InputBox.Text;
                return;
            }

            Calculator.num_2 = InputBox.Text;
        }
        private void ButtonResult_Click(object sender, RoutedEventArgs e)
        {
            if (InputBox.Text == "На ноль делить нельзя" || InputBox.Text == "Ошибка ввода" || InputBox.Text == "Переполнение")
            {
                Calculator.Clean();
                InputBox.FontSize = 30;
                InputBox.Text = "0";
                ResultText.Content = "";
                ButtonOperationGrid.IsEnabled = true;
                ButtonChangeSign.IsEnabled = true;
                return;
            }

            if (Convert.ToString(ResultText.Content) == "" || ResultText.Content.ToString().IndexOf("=") != -1)
            {
                return;
            }

            Calculator.num_2 = InputBox.Text;

            if(Convert.ToDouble(Calculator.num_2) < 0)
            {
                ResultText.Content += "(" + Calculator.num_2 + ")" + "=";
            }
            else
            {
                ResultText.Content += Calculator.num_2 + "=";
            }

            InputBox.Text = Calculator.CalculationResult();
            Calculator.num_1 = InputBox.Text;
            Calculator.num_2 = "";
            Calculator.operation = "";

            if (InputBox.Text == "На ноль делить нельзя")
            {
                InputBox.FontSize = 23;
                Calculator.num_1 = "";
                ButtonOperationGrid.IsEnabled = false;
                ButtonChangeSign.IsEnabled = false;
            }
        }
        private void ButtonRange_Click(object sender, RoutedEventArgs e)
        {
            if (!ButtonRangeOnClick)
            {
                CalculatorWindow.Height = 500;
                ButtonGrid.IsEnabled = false;
                ButtonRangeOnClick = true;
                return;
            }

            if (!InputRange())
            {
                return;
            }

            ButtonGrid.IsEnabled = true;
            CalculatorWindow.Height = 395;
            ButtonRangeOnClick = false;
        }
        private void TextBoxLimit_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
           if(!Char.IsDigit(e.Text, 0) && e.Text != "-")
           {
               e.Handled = true;
           }
        }
        private void ButtonGrid_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (!ButtonGrid.IsEnabled)
            {
                ButtonGrid.Opacity = 0.5;
            }
            else
            {
                ButtonGrid.Opacity = 1;
            }
        }
        private void ButtonOperationGrid_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (!ButtonOperationGrid.IsEnabled)
            {
                ButtonOperationGrid.Opacity = 0.5;
                ButtonChangeSign.Opacity = 0.5;
            }
            else
            {
                ButtonOperationGrid.Opacity = 1;
                ButtonChangeSign.Opacity = 1;
            }
        }
        private void Button_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Button Num = (Button)sender;

            DoubleAnimation buttonAnimationStart = new DoubleAnimation();
            buttonAnimationStart.From = Num.FontSize;
            buttonAnimationStart.To = 16;
            buttonAnimationStart.Duration = TimeSpan.FromSeconds(0.1);
            Num.BeginAnimation(Button.FontSizeProperty, buttonAnimationStart);
        }
        private void Button_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Button Num = (Button)sender;

            DoubleAnimation buttonAnimationEnd = new DoubleAnimation();
            buttonAnimationEnd.From = 16;
            buttonAnimationEnd.To = 20;
            buttonAnimationEnd.Duration = TimeSpan.FromSeconds(0.1);
            Num.BeginAnimation(Button.FontSizeProperty, buttonAnimationEnd);
        }
        public void InputOperation(string Operation)
        {
            ResultText.Content = Calculator.num_1;
            ResultText.Content += Operation;
            Calculator.operation = Operation;
            InputBox.Text = "0";
        }
        public bool InputRange()
        {
            if(TextBoxFirstLimit.Text.LastIndexOf("-") != 0 && TextBoxFirstLimit.Text.LastIndexOf("-") != -1)
            {
                MessageBox.Show("Первая граница не является числом",
                                "Ошибка ввода",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error
                                );
                return false;
            }

            if(TextBoxSecondLimit.Text.LastIndexOf("-") != 0 && TextBoxSecondLimit.Text.LastIndexOf("-") != -1)
            {
                MessageBox.Show("Вторая граница не является числом",
                                "Ошибка ввода",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error
                                );
                return false;
            }
            
            if(TextBoxFirstLimit.Text == "" || TextBoxSecondLimit.Text == "")
            {
                MessageBox.Show("Вы не ввели число",
               "Ошибка ввода",
               MessageBoxButton.OK,
               MessageBoxImage.Error
               );
               return false;
            }

            if(Convert.ToDouble(TextBoxFirstLimit.Text) > Convert.ToDouble(TextBoxSecondLimit.Text))
            {
                MessageBox.Show("Первая граница не может быть больше второй",
                "Ошибка ввода",
                MessageBoxButton.OK,
                MessageBoxImage.Error
                );
                return false;
            }

            Calculator.firstLimit = Convert.ToDouble(TextBoxFirstLimit.Text);
            Calculator.secondLimit = Convert.ToDouble(TextBoxSecondLimit.Text);

            return true;
        }
    }
}
