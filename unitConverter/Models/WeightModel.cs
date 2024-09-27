using System;
using System.Collections.Generic;

namespace unitConverter.Models
{
    public class WeightModel
    {
        public string InputFrom { get; set; }
        public string InputTo { get; set; }
        public double UserInput { get; set; }

        public double ConvertToBase { get; set; }
        public double ConvertToTarget { get; set; }
        public double Result { get; set; }

        private readonly Dictionary<string, double> unitToGramConversion = new Dictionary<string, double>
       {
        {"milligram", 0.001},   
        {"gram", 1},           
        {"kilogram", 1000},     
        {"ounce", 28.34952},    
        {"pound", 453.59237}
    };


        public WeightModel(string weight, string convertFrom, string convertTo)
        {
            this.UserInput = Convert.ToDouble(weight);
            this.InputFrom = convertFrom.ToLower();
            this.InputTo = convertTo.ToLower();
            
            calculateBaseUnit();
            calculateTargetUnit();
            Result = ConvertToTarget;
        }

        private void calculateBaseUnit()
        {
            foreach (KeyValuePair<string, double> entry in unitToGramConversion)
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
            foreach (KeyValuePair<string, double> entry in unitToGramConversion)
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
