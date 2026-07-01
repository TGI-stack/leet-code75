using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace Exercise.GreatestCommonDivisorofStrings;

internal class Solution
{

    public string GcdOfStrings(string str1, string str2)
    {
       if(str1 + str2 != str2 + str1)
        {
            return "";
        }

       int divisorLength = GetDivisor(str1.Length, str2.Length);

        return str1.Substring(0, divisorLength);
    }

    
    public int GetDivisor(int number1, int number2)
    {
        while (number2 != 0)
        {
            var initial = number2;
            number2 = number1 % number2;
            number1 = initial;
        }
        return number1;
    }

}


//For two strings s and t, we say "t divides s" if and only if s = t + t + t + ... + t + t(i.e., t is concatenated with itself one or more times).

//Given two strings str1 and str2, return the largest string x such that x divides both str1 and str2.



//Example 1:

//Input: str1 = "ABCABC", str2 = "ABC"

//Output: "ABC"

//Example 2:

//Input: str1 = "ABABAB", str2 = "ABAB"  ABABABABAB  ABABABABAB

//Output: "AB"

//Example 3:

//Input: str1 = "LEET", str2 = "CODE"  LEETCODE != CODELEET

//Output: ""

//Example 4:

//Input: str1 = "AAAAAB", str2 = "AAA"

//Output: ""​​​​​​​




//Constraints:

//1 <= str1.length, str2.length <= 1000
//str1 and str2 consist of English uppercase letters.