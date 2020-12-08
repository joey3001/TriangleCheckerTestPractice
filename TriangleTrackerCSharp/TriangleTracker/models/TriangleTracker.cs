using System;  
namespace TriangleTracker
{
  public class Triangle
  {
    public int SideOne { get; set; }
    public int SideTwo { get; set; }
    public int SideThree { get; set; }

    public Triangle(int sideOne, int sideTwo, int sideThree)
    {
      SideOne = sideOne;
      SideTwo = sideTwo;
      SideThree = sideThree;
    }

    public string triangleCheck(int sideOne, int sideTwo, int sideThree) 
    {
      if (sideOne + sideTwo < sideThree || sideTwo + sideThree < sideOne || sideThree + sideOne < sideTwo) {
        return "Not a Triangle"; 
      }
      else if (sideOne == sideTwo && sideOne == sideThree) {
        return "Equilateral";
      }
      else if (sideOne == sideTwo || sideTwo == sideThree || sideOne == sideThree) {
        return "Isoscoles";
      }
      else {
        return "Scalene";
      }
    }
  }
}