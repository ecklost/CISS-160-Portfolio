using System;

// Goal: For later uses, I want to create a car class so I can store car information
// For later retrieval.

public class Car
{
    private string year;
    private string make;
    private string model;

    private decimal mpg;
    private decimal iniPrice;
    private decimal yearlyGasTotal;

    private bool onCRList;

    // Constructor
	public Car()
    {   
        // Using my last car as a base.
        year = "1999";
        make = "Ford";
        model = "Taurus";

        // Made-up number below
        mpg = 30; // I wish my Taurus got this MPG
        iniPrice = 15000;

        onCRList = false; // Is the car on Consumer Reports list of Cars to Avoid?
        yearlyGasTotal = 0;
	}

    // A much more specific constructor
    public Car(string year, string make, string model, decimal mpg, decimal iniPrice, bool onCRList, decimal yearlyGasTotal)
    {
        year = this.year;
        make = this.make;
        model = this.model;
        mpg = this.mpg;
        iniPrice = this.iniPrice;
        onCRList = this.onCRList;
        yearlyGasTotal = this.yearlyGasTotal; 
    }

    // Getters and Setters
    public void setYear(string year)
    {
        this.year = year;
    }

    public string getYear()
    {
        return year;
    }

    public void setMake(string make)
    {
        this.make = make;
    }

    public string getMake()
    {
        return make;
    }

    public void setModel(string model)
    {
        this.model = model;
    }

    public string getModel()
    {
        return model;
    }

    public void setMPG(decimal mpg)
    {
        this.mpg = mpg;
    }

    public decimal getMPG()
    {
        return mpg;
    }

    public void setIniPrice(decimal iniPrice)
    {
        this.iniPrice = iniPrice;
    }

    public decimal getIniPrice()
    {
        return iniPrice;
    }

    public void setIsOnCRList(bool onCRList)
    {
        this.onCRList = onCRList;
    }

    public bool getIsOnCRList()
    {
        return onCRList;
    }

    public void setYearlyGasTotal(decimal yearlyGasTotal)
    {
        this.yearlyGasTotal = yearlyGasTotal;
    }

    public decimal getYearlyGasTotal()
    {
        return yearlyGasTotal;
    }
}
