// Surprisingly there are only three numbers that can be written as the sum of fourth powers of their digits:
// 1634 = 1^4 + 6^4 + 3^4 + 4^4
// 8208 = 8^4 + 2^4 + 0^4 + 8^4
// 9474 = 9^4 + 4^4 + 7^4 + 4^4
// As 1 = 1^4 is not a sum it is not included.
// The sum of these numbers is 1634 + 8208 + 9474 = 19316.
// Find the sum of all the numbers that can be written as the sum of fifth powers of their digits.

using System;

public class P030DigitFifthPowers {
  private static int sumDigits(int digits) {
    double sum = 0;
    while(digits > 0) {
      sum += Math.Pow(digits % 10, 5);
      digits /= 10;
    }
    return (int) sum;
  }

  public static void Main() {
    int end = (int) Math.Pow(9, 5) * 5;
    int answer = 0;
    int sum = 0;

    for(int number = 2; number < end; number++) {
      sum = sumDigits(number);
      if(sum == number) {
        answer += number;
      }
    }
    Console.WriteLine("The sum of all the numbers that can be written as the sum of fifth powers of their digits is {0}.", answer);
  }
}
