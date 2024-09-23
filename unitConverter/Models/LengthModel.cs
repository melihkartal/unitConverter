using System.Windows.Markup;
using Microsoft.AspNetCore.SignalR;

namespace unitConverter.Models;


public class LengthModel{

   private readonly List<string> lengthUnits = new List<string>
    {
    "millimeter", "centimeter", "meter", "kilometer", "inches", "foot", "yard", "mile"
    };

    private double Millimeter { get; set; }
    private double Centimeter { get; set; }
    private double Meter{get;set;}    
    private double Kilometer { get; set; }
    private double Inches { get; set; }
    private double Foot { get; set; }
    private double Yard { get; set; }
    private double Mile{get; set; }
    private string InputFrom { get; set; }
    private string InputTo{ get; set; }
    private string UserInput{ get; set; }

    public LengthModel(){

    }
    
    public LengthModel(string length, string convertFrom, string convertTo )
    {
        this.InputFrom = convertFrom;
        this.InputTo = convertTo;
        this.UserInput = length;
    }
    

   

}