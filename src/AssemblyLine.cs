using System;

static class AssemblyLine
{
  public static double CalculatePercentage(double value)
  {
    double percentage = value / 100;
    return percentage;
  }

  public static double SuccessRate(int speed)
  {
    if (speed == 0)
    {
      return CalculatePercentage(0);
    }
    else if (speed >= 1 && speed <= 4)
    {
      return CalculatePercentage(100);
    }
    else if (speed >= 5 && speed <= 8)
    {
      return CalculatePercentage(90);
    }
    else if (speed == 9)
    {
      return CalculatePercentage(80);
    }
    else
    {
      return CalculatePercentage(77);
    }
  }

  public static double ProductionRatePerHour(int speed)
  {
    return SuccessRate(speed) * (speed * 221);
  }

  public static int WorkingItemsPerMinute(int speed)
  {
    double workingItemsPerHour = ProductionRatePerHour(speed);
    int workingItemsPerMinute = (int)(workingItemsPerHour / 60);
    return workingItemsPerMinute;
  }
}
