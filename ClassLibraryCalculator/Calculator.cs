using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCalculator
{
    public class Calculator
    {
        public string num_1 { get; set; } = "";
        public string num_2 { get; set; } = "";
        private double result = 0;
        public string operation { get; set; } = "";
        public double firstLimit { get; set; } = -10000;
        public double secondLimit { get; set; } = 800000;

        public void Clean()
        {
            num_1 = "";
            num_2 = "";
            result = 0;
            operation = "";
        }

        public string CalculationResult()
        {
            if(operation == "")
            {
                return "";
            }

            switch (operation)
            {
                case "+":
                    result = Convert.ToDouble(num_1) + Convert.ToDouble(num_2);
                    break;
                case "-":
                    result = Convert.ToDouble(num_1) - Convert.ToDouble(num_2);
                    break;
                case "/":
                    result = Convert.ToDouble(num_1) / Convert.ToDouble(num_2);
                    break;   
                case "*":
                    result = Convert.ToDouble(num_1) * Convert.ToDouble(num_2);
                    break;
            }

            return Convert.ToString(Math.Round(result, 3));
        }
        public double CalculatorSin(double num)
        {
            return Math.Round(Math.Sin(num * Math.PI / 180), 3);
        }
        public double CalculatorRoot(double num)
        {
            return Math.Round(Math.Sqrt(num), 3);
        }
        public double CalculatorSquare(double num)
        {
            return Math.Round(Math.Pow(num, 2), 3);
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
