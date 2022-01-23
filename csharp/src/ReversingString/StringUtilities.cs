using System.Text;

namespace CodingChallenge.ReversingString;

public class StringUtilities
{
    /// <summary>
    ///  This method reverse the given string and returns the reversed string as an output.
    ///  To Do: Add try catch 
    /// </summary>
    /// <param name="s"> it is a string input</param>
    /// <returns>It returns the reversed string passed as an input</returns>
    public static string Reverse(string s)
    {
        // Return blank if string is null or empty.
        if (String.IsNullOrEmpty(s))
            return "";

        // Convert the input to char array to iterate over each character.
        char[] inputStrArr = s.ToCharArray();
        StringBuilder sbToHoldReversedStr = new StringBuilder(); 

        for (int i = inputStrArr.Length - 1; i >=0 ; i--)
        {
            // appends the character in string builder starting from the last element of the array initialized.
            sbToHoldReversedStr.Append(inputStrArr[i]);
        }
        return sbToHoldReversedStr.ToString();
    }

    /// <summary>
    /// This method also returns the input string in reverse manner.
    /// This method executes faster as it only travers half of string as we are swapping the char in a loop itself.
    /// To Do: Add try catch
    /// </summary>
    /// <param name="s">it is a string input</param>
    /// <returns>It returns the reversed string passed as an input</returns>
    public static string OptimizedReverse(string s)
    {

        // Return blank if string is null or empty.
        if (String.IsNullOrEmpty(s))
            return "";

        // Convert the input to char array to iterate over each character.
        char[] inputArr = s.ToCharArray();
        int strLength = inputArr.Length;

        for (int i = 0, j = strLength -1 ; i < j; i++,j--)
        {
            char c = inputArr[i];
            inputArr[i] = inputArr[j];
            inputArr[j] = c;
        }

        return string.Join("",inputArr);
    }


}
