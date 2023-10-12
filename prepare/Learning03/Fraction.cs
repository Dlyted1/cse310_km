 using System;
 public class Fraction
    {
        private int _top;
        private int _bottom;

    public Fraction()
    {
        //First Constructor that has no parameters that initializes the number to 1/1
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        //Second Constructor that has one parameter for the top and that initializes the denominatorto 1. So that if you pass in the number 5, the fraction would be initialized to 5/1
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        //Third Constructor that has two parameters, one for the top and one for the bottom
         _top = top;
         _bottom = bottom;

    }

    //Create getters and setters for both the top and the bottom values. Using setters to change the values and then getters to retrieve these new values andthen display them to the console.
    public string GetFractionString()
    {
        //a temporary, local variable that will be recomputed each time this is called - not a stored member variable
        string text = $"{_top}/{_bottom}";
        return text;
    }
    public double GetDecimalValue()
        {
        //will be recomputed each time this is called - not a stored member variable
        return (double)_top / _bottom;
        
        }
      }
 
