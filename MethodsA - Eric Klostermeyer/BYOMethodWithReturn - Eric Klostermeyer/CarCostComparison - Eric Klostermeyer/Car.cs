using System;

// Goal: For later uses, I want to create a car class so I can store car information
// For later retrieval.

public class Car
{
    string year;
    string make;
    string model;
    decimal mpg;
    decimal iniPrice;
    bool onCRList;

    // Constructor
	public Car()
    {   
        // Using my last car as a base.
        string year = "1999";
        string make = "Ford";
        string model = "Taurus";

        // Made-up number below
        decimal mpg = 30; // I wish my Taurus got this MPG
        decimal iniPrice = 15000;

        bool onCRList = false; // Is the car on Consumer Reports list of Cars to Avoid?
	}

    // A much more specific constructor
    public Car(decimal mpg, decimal iniPrice, string year, string make, string model, bool onCRList)
    {
        year = this.year;
        make = this.make;
        model = this.model;
        mpg = this.mpg;
        iniPrice = this.iniPrice;
        onCRList = this.onCRList; 
    }

    // Getters and Setters
    public void setYear(string year)
    {
        year = this.year;
    }

    public string getYear()
    {
        return year;
    }

    public void setMake(string make)
    {
        make = this.make;
    }

    public string getMake()
    {
        return make;
    }

    public void setModel(string model)
    {
        model = this.model;
    }

    public string getModel()
    {
        return model;
    }

    public void setMPG(decimal mpg)
    {
        mpg = this.mpg;
    }

    public decimal getMPG()
    {
        return mpg;
    }

    public void setIniPrice(decimal iniPrice)
    {
        iniPrice = this.iniPrice;
    }

    public decimal getIniPrice()
    {
        return iniPrice;
    }

    public void setIsOnCRList(bool onCRList)
    {
        onCRList = this.onCRList;
    }

    public bool getIsOnCRList()
    {
        return onCRList;
    }
}
