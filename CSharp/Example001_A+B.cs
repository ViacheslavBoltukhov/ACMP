using System;
class Summ {
  static void Main() {
    string[] num = Console.ReadLine().Split(' ');
    int a = int.Parse(num[0]);
    int b= int.Parse(num[1]);
    int summa = a + b;
    Console.WriteLine(summa);
  }
}