// A perfect number is a number for which the sum of its proper divisors is exactly equal to the number. For example, the sum of the proper divisors of 28 would be 1 + 2 + 4 + 7 + 14 = 28, which means that 28 is a perfect number.
// A number n is called deficient if the sum of its proper divisors is less than n and it is called abundant if this sum exceeds n.
// As 12 is the smallest abundant number, 1 + 2 + 3 + 4 + 6 = 16, the smallest number that can be written as the sum of two abundant numbers is 24. By mathematical analysis, it can be shown that all integers greater than 28123 can be written as the sum of two abundant numbers. However, this upper limit cannot be reduced any further by analysis even though it is known that the greatest number that cannot be expressed as the sum of two abundant numbers is less than this limit.
// Find the sum of all the positive integers which cannot be written as the sum of two abundant numbers.

using System;

public class P023NonAbundantSums {
  private static int LIMIT = 28123;
  private static bool[] abundantArray = new bool[LIMIT + 1];

  public static void Main() {
    for (int i = 1; i < abundantArray.Length; i++) {
			abundantArray[i] = isAbundant(i);
    }

    int sum = 0;
		for (int i = 1; i <= LIMIT; i++) {
			if (!isSumOfAbundants(i)) {
        Console.WriteLine(i);
				sum += i;
      }
		}
    Console.WriteLine(sum);
  }

  public static bool isAbundant(int number) {
    if(number > sumOfDivisors(number))
      return true;

    return false;
  }

  public static int sumOfDivisors(int number) {
    int sum = 0;
    for(int i = 1; i < number; i++) {
      if(number % i == 0) {
        sum += i;
      }
    }
    return sum;
  }

  private static bool isSumOfAbundants(int n) {
		for (int i = 0; i <= n; i++) {
			if (abundantArray[i] && abundantArray[n - i])
				return true;
		}
		return false;
	}
}
