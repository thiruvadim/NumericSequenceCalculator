using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericSequenceCalculator
{      
    public class Numbers
    {
        public virtual string getNumberSequence(double iNum)
        {
            var strNumbers = new StringBuilder();
            for (int num = 1; num <= iNum; num++)
                strNumbers.Append(strNumbers.Length == 0 ? num.ToString() : ", " + num.ToString());
            return strNumbers.ToString();
        }
    } 

    public class OddNumbers : Numbers
    {
        public override string getNumberSequence(double iNum)
        {
            var strNumbers = new StringBuilder();                 
            for (int num = 1; num <= iNum; num++)
            {            
                if (num % 2 == 0)
                    continue;
                strNumbers.Append(strNumbers.Length == 0 ? num.ToString() : ", " + num.ToString());
            }
            return strNumbers.ToString();
        }
    }

    public class EvenNumbers : Numbers
    {
        public override string getNumberSequence(double iNum)
        {
            var strNumbers = new StringBuilder();
            for (int num = 1; num <= iNum; num++)
            {
                if (num % 2 != 0)
                    continue;
                strNumbers.Append(strNumbers.Length == 0 ? num.ToString() : ", " + num.ToString());
            }
            return strNumbers.ToString();
        }
    }

    public class SpecialNumbers : Numbers
    {
        public override string getNumberSequence(double iNum)
        {
            var strNumbers = new StringBuilder();
            string numToAdd = string.Empty;
            for (int num = 1; num <= iNum; num++)
            {
                numToAdd = num.ToString();
                if (num % 3 == 0 && num % 5 == 0) numToAdd = "Z";
                else if (num % 3 == 0) numToAdd = "C";
                else if (num % 5 == 0) numToAdd = "E";               
                strNumbers.Append(strNumbers.Length == 0 ? numToAdd : ", " + numToAdd);
            }
            return strNumbers.ToString();
        }
    }

    public class FibonacceNumbers : Numbers
    {
        public override string getNumberSequence(double iNum)
        {
            var strNumbers = new StringBuilder();
            string numToAdd = string.Empty;
            Double numFib1 = 0;
            Double numFib2 = 1; 
            for (int num = 1; num <= iNum; num++)
            {
                if (num > 1)
                {
                    Double temp = numFib1;
                    numFib1 = numFib2;
                    numFib2 = temp + numFib2;
                    numToAdd = numFib2.ToString();
                }
                numToAdd = numFib2.ToString(); 
                strNumbers.Append(strNumbers.Length == 0 ? numToAdd : ", " + numToAdd);
            }
            return strNumbers.ToString();
        }
    }

    //public enum NumberType
    //{
    //    O, //"Odd",
    //    E, //"Even",
    //    F, //"Fibonacci",
    //    A, //"All",
    //    S //"Special"       
    //}
    // Applied SOLID open/close principle and created separated child classes.
    //public class NumericCalculator
    //{
    //    public string GetNumbersUpto(int iNum, NumberType nType)
    //    {
    //        var strNumbers = new StringBuilder();
    //        string numToAdd = string.Empty;
    //        Double numFib1 = 0;
    //        Double numFib2 = 1;         
    //        for (int num = 1; num <= iNum; num++)
    //        {
    //            numToAdd = num.ToString();
    //            if (nType == NumberType.O && num % 2 == 0)
    //                continue;
    //            else if (nType == NumberType.E && num % 2 != 0)
    //                continue;
    //            else if (nType == NumberType.S)
    //            {
    //                if (num % 3 == 0) numToAdd = "C";
    //                if (num % 5 == 0) numToAdd = "E";
    //                if (num % 3 == 0 && num % 5 == 0) numToAdd = "Z";
    //            }
    //            else if (nType == NumberType.F)
    //            {
    //                if (num > 1)
    //                {
    //                    Double temp = numFib1;
    //                    numFib1 = numFib2;
    //                    numFib2 = temp + numFib2;
    //                    numToAdd = numFib2.ToString();
    //                }
    //                numToAdd = numFib2.ToString();                                                              
    //            }
    //            strNumbers.Append(strNumbers.Length == 0 ? numToAdd : ", "+ numToAdd);              
    //        }
    //        return strNumbers.ToString();
    //    }
    //}
}
