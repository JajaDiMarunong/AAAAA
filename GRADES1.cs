using System;
class GradeCalculator {
  static void Main() {
    Console.WriteLine("Student Grade Application");
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.WriteLine("-------------------------");
    Console.Write("English: ");
    double english = Convert.ToDouble(Console.ReadLine());
    Console.Write("History: ");
    double history = Convert.ToDouble(Console.ReadLine());
    Console.Write("Science: ");
    double science = Convert.ToDouble(Console.ReadLine());
    Console.Write("Filipino: ");
    double filipino = Convert.ToDouble(Console.ReadLine());
    Console.Write("Math: ");
    double math = Convert.ToDouble(Console.ReadLine());
    

    double sum = (english + math + science + filipino + history) / 5;
    Console.WriteLine("-------------------------");
    Console.WriteLine("Your final average is: " + sum);
    if (sum >= 75)
    {
        Console.WriteLine("The passing grade is 75");
        Console.WriteLine("Congratulations, " + name + " you Passed!");
    }
    else
    {
        Console.WriteLine("The passing grade is 75");
        Console.WriteLine("Sorry, " + name + " you failed!");
    }

  }
}