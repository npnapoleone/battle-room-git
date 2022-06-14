using System.Collections.Generic;

public class Character
{
  public enum APPEARANCE
  {
    MALE,
    FEMALE
  }

  public string FirstName;
  public string LastName;
  public string Nickname;

  public APPEARANCE Appearance;
  public int Height;
  public int Size;

  public Army.ROLE Role;
}

public static class Characters
{
  public static Character Custom = new();
  public static Character Rosen = new() {
    FirstName = "Rosen",
    Nickname = "Rose The Nose",
    Appearance = Character.APPEARANCE.MALE,
    Height = 4,
    Size = 2,
    Role = Army.ROLE.COMMANDER
  };
  public static Character Bonzo = new() {
    FirstName = "Bonito",
    LastName = "de Madrid",
    Nickname = "Bonzo",
    Appearance = Character.APPEARANCE.MALE,
    Height = 2,
    Size = 2,
    Role = Army.ROLE.COMMANDER
  };
  public static List<Character> CharacterList = new() {
    Rosen,
    Bonzo,
    Custom
  };
}
