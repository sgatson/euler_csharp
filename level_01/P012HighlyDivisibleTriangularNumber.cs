// The sequence of triangle numbers is generated by adding the natural numbers.
// So the 7th triangle number would be 1 + 2 + 3 + 4 + 5 + 6 + 7 = 28.
// The first ten terms would be: 1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...
// 28 is the first triangle number to have over five divisors.
// What is the value of the first triangle number to have over five hundred divisors?

using System;

class P012HighlyDivisibleTriangularNumber {
  public static void Main(String[] args) {
    int divisors = 500;
    int i = 1;

    while(true) {
      int triangle = 0;

      for(int j = 1; j <= i; j++) {
        triangle = triangle + j;
      }

      if(numOfDivisors(triangle) >= divisors) {
        Console.WriteLine("{0} is the first triangle number to have over {1} divisors.\n", triangle, divisors);
        break;
      }
      i++;
    }
  }

  public static int numOfDivisors(int number) {
    int count = 0;
    int max = (int) number / 2;
    for(int i = 2; i <= max; i++) {
      if (number % i == 0) {
        count += 2;
        max = (number / i) - 1;
      }
    }
    return count;
  }
}
