using System;

public class Player
{
  public int RollDie()
  {
    Random random = new Random();
    return random.Next(1, 19);
  }

  public double GenerateSpellStrength()
  {
    Random random = new Random();
    return 100.0 * random.NextDouble();
  }
}
