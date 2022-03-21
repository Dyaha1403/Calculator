using System;

namespace ClassLibraryCalculator
{
    public class Calculator
    {
        public string num_1 { get; set; } = "";
        public string num_2 { get; set; } = "";
        private string result = "0";
        public string operation { get; set; } = "";
        public double firstLimit { get; set; } = -10000;
        public double secondLimit { get; set; } = 800000;

        public void Clean()
        {
            num_1 = "";
            num_2 = "";
            result = "0";
            operation = "";
        }

        public string CalculationResult()
        {
            if(operation == "")
            {
                return "";
            }

            if (operation == "/" && num_2 == "0")
            {
                return "На ноль делить нельзя";
            }

            switch (operation)
            {
                case "+":
                    result = Convert.ToString(Convert.ToDouble(num_1) + Convert.ToDouble(num_2));
                    break;
                case "-":
                    result = Convert.ToString(Convert.ToDouble(num_1) - Convert.ToDouble(num_2));
                    break;
                case "/":
                    result = Convert.ToString(Convert.ToDouble(num_1) / Convert.ToDouble(num_2));
                    break;   
                case "*":
                    result = Convert.ToString(Convert.ToDouble(num_1) * Convert.ToDouble(num_2));
                    break;
            }

            result = Convert.ToString(Math.Round(Convert.ToDouble(result), 3));

            if (result == "-0")
            {
                result = "0";
            }

            return result;
        }
        public double CalculatorSin(double num)
        {
            num = Math.Round(Math.Sin(num * Math.PI / 180), 3);

            if(Convert.ToString(num) == "-0")
            {
                num = 0;
            }

            return num;
        }
        public double CalculatorRoot(double num)
        {
            if(num < 0)
            {
                return -1;
            }

            num = Math.Round(Math.Sqrt(num), 3);

            if (Convert.ToString(num) == "-0")
            {
                num = 0;
            }

            return num;
        }
        public double CalculatorSquare(double num)
        {
            num = Math.Round(Math.Pow(num, 2), 3);

            if (Convert.ToString(num) == "-0")
            {
                num = 0;
            }

            if(num == Double.PositiveInfinity)
            {
                num = -1;
            }

            return num;
        }
        public bool InputNum(string text, string num)
        {
            if (!CheckCountDecimalNum(text) || !CheckRange(text + num))
            {
                return false;
            }

            return true;
        }
        private bool CheckCountDecimalNum(string text)
        {
            if (text.IndexOf(",") != -1)
            {
                int index = text.IndexOf(",");

                if (text.Length - (index + 1) >= 3)
                {
                    return false;
                }
            }

            return true;
        }
        public bool CheckRange(string text)
        {
            if(Convert.ToDouble(text) < firstLimit 
            || Convert.ToDouble(text) > secondLimit)
            {
                return false;
            }

            return true;
        }
    }
}
