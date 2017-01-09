using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Tip
/// </summary>
public class Tip
{
    //fields: class level variables that describe the class
    public double MealAmount { set; get; }//set allows you to see it and get allows you to change it
    public double TipPercent { set; get; }// double is float, meaning decimal places
    private const double TAXPERCENT = .09;
    public Tip()
    {
        //
        // Constructor does not have return type
        //
        MealAmount = 0;
        TipPercent = 0;
    }
    public Tip(double meal, double percent)
    {
        MealAmount = meal;
        TipPercent = percent;
        
    }
    public double CalculateTax()
    {
        return MealAmount * TAXPERCENT;
            }

    public double CalculateTip()
    {
        return MealAmount * TipPercent;
    }

    public double CalculateTotal()
    {
        return MealAmount + CalculateTax() + CalculateTip();
    }
}