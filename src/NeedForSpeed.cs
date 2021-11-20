using System;

class RemoteControlCarWithNitro
{
  // TODO: define the constructor for the 'RemoteControlCarWithNitro' class
  private int speed;
  private int batteryDrain;
  private int batteryPercentage;
  private int distanceDriven;

  public RemoteControlCarWithNitro(int speed, int batteryDrain)
  {
    this.speed = speed;
    this.batteryDrain = batteryDrain;
    this.batteryPercentage = 100;
    this.distanceDriven = 0;
  }

  public bool BatteryDrained()
  {
    return this.batteryPercentage < this.batteryDrain;
  }

  public int DistanceDriven()
  {
    return this.distanceDriven;
  }

  public void Drive()
  {
    if (!BatteryDrained())
    {
      this.distanceDriven += this.speed;
      this.batteryPercentage -= this.batteryDrain;
    }
  }

  public static RemoteControlCarWithNitro Nitro()
  {
    return new RemoteControlCarWithNitro(50, 4);
  }
}

class RaceTrack
{
  // TODO: define the constructor for the 'RaceTrack' class
  private int distance;

  public RaceTrack(int distance)
  {
    this.distance = distance;
  }

  public bool CarCanFinish(RemoteControlCarWithNitro car)
  {
    while (!car.BatteryDrained())
    {
      car.Drive();
      if (car.DistanceDriven() >= this.distance) return true;
    }

    return false;
  }
}
