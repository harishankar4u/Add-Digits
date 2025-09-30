using System;

class Program
{
    public static void Main(string[] args)
    {
        // Test cases for AddDigits method
        Console.WriteLine(AddDigits(0));        // Output: 0  → because input is 0
        Console.WriteLine(AddDigits(9));        // Output: 9  → 9 is divisible by 9, so result = 9
        Console.WriteLine(AddDigits(234566666));// Output: 8  → digital root of 234566666 is 8
        Console.WriteLine(AddDigits(1111111));  // Output: 7  → digital root of 1111111 is 7
        Console.WriteLine(AddDigits(18));       // Output: 9  → sum of digits (1+8=9)
        Console.WriteLine(AddDigits(22));       // Output: 4  → sum of digits (2+2=4)
        Console.WriteLine(AddDigits(30));       // Output: 3  → sum of digits (3+0=3)
    }

    /// <summary>
    /// Returns the "digital root" of a number using modulo 9 logic.
    /// Digital root is the single-digit value obtained by repeatedly summing the digits of a number.
    /// Examples:
    ///     38 → (3+8=11) → (1+1=2) → Result = 2
    ///     18 → (1+8=9) → Result = 9
    /// 
    /// Formula: 
    /// - If number is 0 → result = 0
    /// - Else if number is divisible by 9 → result = 9
    /// - Else → result = number % 9
    /// </summary>
    /// <param name="nums">Input integer</param>
    /// <returns>Digital root as an integer</returns>
    public static int AddDigits(int nums)
    {
        // Remainder when divided by 9
        int digit = nums % 9;

        if (nums == 0)
        {
            return 0; // Special case: digital root of 0 is 0
        }
        else if (digit == 0)
        {
            return 9; // If divisible by 9, digital root is 9
        }
        else
        {
            return digit; // Otherwise, digital root is remainder
        }
    }
}
