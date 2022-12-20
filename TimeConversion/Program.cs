using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {

        string hour = "";

        if (((s.Substring(8, 2) == "PM") && (s.Substring(0, 2) != "12")) || ((s.Substring(8, 2) == "AM") && (s.Substring(0, 2) == "12")))
        {
            hour = s.Substring(0, 2);
        }

        if (hour != "")
        {
            switch (hour)
            {
                case "01":
                    hour = "13";
                    break;
                case "02":
                    hour = "14";
                    break;
                case "03":
                    hour = "15";
                    break;
                case "04":
                    hour = "16";
                    break;
                case "05":
                    hour = "17";
                    break;
                case "06":
                    hour = "18";
                    break;
                case "07":
                    hour = "19";
                    break;
                case "08":
                    hour = "20";
                    break;
                case "09":
                    hour = "21";
                    break;
                case "10":
                    hour = "22";
                    break;
                case "11":
                    hour = "23";
                    break;
                case "12":
                    hour = "00";
                    break;
            }

            return $"{hour}{s.Substring(2, 6)}";
        }
        else
        {
            return $"{s.Substring(0, 8)}";
        }


    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        Console.WriteLine(result);

    }
}
