using System;
using System.Collections.Generic;

namespace unitConverter.Models
{
    public class TemperatureModel
    {
        public string InputFrom { get; set; }
        public string InputTo { get; set; }
        public double UserInput { get; set; }

        public double ConvertToBase { get; set; }
        public double ConvertToTarget { get; set; }
        public double Result { get; set; }

        private readonly Dictionary<string, Func<double, double>> unitToCelsiusConversion = new Dictionary<string, Func<double, double>>
        {
            {"celsius", c => c},  // No conversion needed
            {"fahrenheit", f => (f - 32) * 5 / 9},  // Fahrenheit to Celsius formula
            {"kelvin", k => k - 273.15}  // Kelvin to Celsius formula
        };

        private readonly Dictionary<string, Func<double, double>> celsiusToUnitConversion = new Dictionary<string, Func<double, double>>
        {
            {"celsius", c => c},  // No conversion needed
            {"fahrenheit", c => c * 9 / 5 + 32},  // Celsius to Fahrenheit formula
            {"kelvin", c => c + 273.15}  // Celsius to Kelvin formula
        };

        public TemperatureModel(string temperature, string convertFrom, string convertTo)
        {
            this.UserInput = Convert.ToDouble(temperature);
            this.InputFrom = convertFrom.ToLower();
            this.InputTo = convertTo.ToLower();
            
            calculateBaseUnit();
            calculateTargetUnit();
            Result = ConvertToTarget;
        }

        private void calculateBaseUnit()
        {
            if (unitToCelsiusConversion.TryGetValue(InputFrom, out var conversionFunc))
            {
                ConvertToBase = conversionFunc(UserInput);
            }
            else
            {
                throw new ArgumentException("Unsupported input unit", nameof(InputFrom));
            }
        }

        private void calculateTargetUnit()
        {
            if (celsiusToUnitConversion.TryGetValue(InputTo, out var conversionFunc))
            {
                ConvertToTarget = conversionFunc(ConvertToBase);
            }
            else
            {
                throw new ArgumentException("Unsupported output unit", nameof(InputTo));
            }
        }
    }
}
