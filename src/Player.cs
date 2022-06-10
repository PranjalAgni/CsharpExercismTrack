using System;

public class Player
{
  public int RollDie()
  {
    Random random = new Random();
    return random.Next(1, 18);
  }

  public double GenerateSpellStrength()
  {
    throw new NotImplementedException("Please implement the Player.GenerateSpellStrength() method");
  }
}
