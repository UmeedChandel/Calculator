using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class ExtraOperations
    {
        public string Concat(string a , string b)
        {
            return a + b;
        }

        //fields read/write current state of object
        public int firstNumberField;
        public int secondNumberField;

        //properties - readonly, writeonly
        public int firstNumber { get; set; }
        public int secondNumber { get; set; }

        public string result = String.Empty;

        //constructor overloading

        //default 
        public ExtraOperations() { }

        //no. of para
        public ExtraOperations(int firstNumberField)
        {
            this.firstNumberField = firstNumberField;
        }

        public ExtraOperations(int firstNumberField, int secondNumberField)
        {
            this.firstNumberField = firstNumberField;
            this.secondNumberField = secondNumberField;
        }

        public ExtraOperations(int firstNumberField, int firstNumber, int secondNumber)
        {
            this.firstNumberField = firstNumberField;
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
        }

        public ExtraOperations(int firstNumberField, int secondNumberField, int firstNumber, int secondNumber)
        {
            this.firstNumberField = firstNumberField;
            this.secondNumberField = secondNumberField;
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
        }

        //order of para

        public ExtraOperations(int firstNumberField, string result)
        {
            this.firstNumberField = firstNumberField;
            this.result = result;
        }

        public ExtraOperations(string result, int firstNumberField)
        {
            this.firstNumberField = firstNumberField;
            this.result = result;
        }

        //type of para

        public ExtraOperations(int firstNumberField, int firstNumber, string result)
        {
            this.firstNumberField = firstNumberField;
            this.firstNumber = firstNumber;
            this.result = result;
        }

        public ExtraOperations(int firstNumberField, string result, int firstNumber)
        {
            this.firstNumberField = firstNumberField;
            this.firstNumber = firstNumber;
            this.result = result;
        }

    }
}
