class Lasagna
{

  public int ExpectedMinutesInOven() => 40;
  public int RemainingMinutesInOven(int timeSpentInOven) => 40 - timeSpentInOven;
  public int PreparationTimeInMinutes(int numberOfLayers) => numberOfLayers * 2;
  public int ElapsedTimeInMinutes(int numberOfLayers, int timeSpentInOven) => numberOfLayers * 2 + timeSpentInOven;
}
