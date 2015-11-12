using System;
using System.Collections.Generic;

public class P029DistinctPowers {
  private static HashSet<double> hashSet = new HashSet<double>();
  public static void Main() {
    for (int a = 2; a <= 100; a++ ) {
      for (int b = 2; b <= 100; b++ ) {
        hashSet.Add(Math.Pow(a, b));
      }
    }
    Console.WriteLine("Distinct terms in the sequence generated by a^b for 2 ≤ a ≤ 100 and 2 ≤ b ≤ 100 is {0}.", hashSet.Count);
  }
}