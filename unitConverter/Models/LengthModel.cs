using System;
using System.Collections.Generic;

namespace unitConverter.Models
{
    public class LengthModel
    {
        public string InputFrom { get; set; }
        public string InputTo { get; set; }
        public double UserInput { get; set; }

        public double ConvertToBase { get; set; }
        public double ConvertToTarget { get; set; }
        public double Result { get; set; }

        private readonly Dictionary<string, double> unitToMeterConversion = new Dictionary<string, double>
        {
            {"meter", 1}, // Base unit
            {"millimeter", 0.001},
            {"centimeter", 0.01},
            {"kilometer", 1000},
            {"inches", 0.0254},
            {"foot", 0.3048},
            {"yard", 0.9144},
            {"mile", 1609.344}
        };

        public LengthModel(string length, string convertFrom, string convertTo)
        {
            this.UserInput = Convert.ToDouble(length);
            this.InputFrom = convertFrom.ToLower();
            this.InputTo = convertTo.ToLower();
            
            calculateBaseUnit();
            calculateTargetUnit();
            Result = ConvertToTarget;
        }

        private void calculateBaseUnit()
        {
            foreach (KeyValuePair<string, double> entry in unitToMeterConversion)
            {
                if (this.InputFrom == entry.Key)
                {
                    ConvertToBase = entry.Value * this.UserInput;
                    break;
                }
            }
        }

        private void calculateTargetUnit()
        {
            foreach (KeyValuePair<string, double> entry in unitToMeterConversion)
            {
                if (this.InputTo == entry.Key)
                {
                    ConvertToTarget = (1 / entry.Value) * ConvertToBase;
                    break;
                }
            }
        }
    }
}
