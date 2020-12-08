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

    public string triangleCheck() 
    {
      if (SideOne + SideTwo <= SideThree || SideTwo + SideThree <= SideOne || SideThree + SideOne <= SideTwo) {
        return "Not a Triangle"; 
      }
      else if (SideOne == SideTwo && SideOne == SideThree) {
        return "Equilateral";
      }
      else if (SideOne == SideTwo || SideTwo == SideThree || SideOne == SideThree) {
        return "Isoscoles";
      }
      else {
        return "Scalene";
      }
    }
  }
}