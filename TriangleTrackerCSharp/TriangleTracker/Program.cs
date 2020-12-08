using System;
using System.Collections.Generic;
using TriangleTracker;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Enter the 1st length for your triangle:");
    string Input = Console.ReadLine(); 
    int firstLength = int.Parse(Input);

    Console.WriteLine("Enter the 2nd length for your triangle:");
    Input = Console.ReadLine(); 
    int secondLength = int.Parse(Input);

    Console.WriteLine("Enter the 3rd length for your triangle:");
    Input = Console.ReadLine(); 
    int thirdLength = int.Parse(Input);

    Triangle newTriangle = new Triangle(1,1,2); 
    string result = ""; 
    result = newTriangle.triangleCheck(firstLength ,secondLength, thirdLength);
    Console.WriteLine(result);
  }
}
