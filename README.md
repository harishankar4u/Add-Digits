 **<summary>**
 
/// Returns the "digital root" of a number using modulo 9 logic.

/// Digital root is the single-digit value obtained by repeatedly summing the digits of a number.

/// Examples:
///     38 → (3+8=11) → (1+1=2) → Result = 2
///     18 → (1+8=9) → Result = 9
/// 
**Formula:**
/// - If number is 0 → result = 0
/// - Else if number is divisible by 9 → result = 9
/// - Else → result = number % 9
/// </summary>
/// <param name="nums">Input integer</param>
/// <returns>Digital root as an integer</returns>

**Example 1:**
Input: num = 38
Output: 2
Explanation: The process is
38 --> 3 + 8 --> 11
11 --> 1 + 1 --> 2 
Since 2 has only one digit, return it.

**Example 2:**

Input: num = 0
Output: 0
 
**Constraints:**

0 <= num <= 231 - 1
