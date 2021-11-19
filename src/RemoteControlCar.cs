using System;

class RemoteControlCar
{
  private int batteryPercentage = 100;
  private int distanceDriven = 0;
  public static RemoteControlCar Buy()
  {
    return new RemoteControlCar();
  }

  public string DistanceDisplay()
  {
    return $"Driven {distanceDriven} meters";
  }

  public string BatteryDisplay()
  {
    if (batteryPercentage > 0) return $"Battery at {batteryPercentage}%";
    return "Battery empty";
  }

  public void Drive()
  {
    if (batteryPercentage > 0)
    {
      batteryPercentage -= 1;
      distanceDriven += 20;
    }
  }
}
