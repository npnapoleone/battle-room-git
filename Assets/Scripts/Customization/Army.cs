using System.Collections.Generic;
using UnityEngine;

public class Army
{
  public enum ROLE
  {
    COMMANDER,
    TOON_LEADER,
    TOON_MEMBER
  }

  public string Name;
  public (Color, Color, Color) ColorCode;
  public HashSet<Character> Soldiers;

  public Army() {
    ColorCode = (Color.white, Color.white, Color.white);
    Soldiers = new HashSet<Character>();
  }

  public Army(string name, Color c1, Color c2, Color c3) {
    Name = name;
    ColorCode = (c1, c2, c3);
  }
}

public static class Armies
{
  public static Army Custom = new();
  public static Army Salamander = new(
    "Salamander",
    ArmyColors.GreenD,
    ArmyColors.GreenL,
    ArmyColors.Brown
  );
  public static Army Rat = new(
    "Rat",
    ArmyColors.Brown,
    ArmyColors.Brown,
    ArmyColors.Green
  );
  public static List<Army> ArmyList = new() {
    Salamander,
    Rat,
    Custom
  };
}
