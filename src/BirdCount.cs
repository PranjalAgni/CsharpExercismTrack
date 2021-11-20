using System;

class BirdCount
{
  private int[] birdsPerDay;

  public BirdCount(int[] birdsPerDay)
  {
    this.birdsPerDay = birdsPerDay;
  }


  public static int[] LastWeek()
  {
    return new int[] { 0, 2, 5, 3, 7, 8, 4 };
  }

  public int GetTodayIndex()
  {
    return birdsPerDay.Length - 1;
  }

  public int Today()
  {
    return birdsPerDay[GetTodayIndex()];
  }

  public void IncrementTodaysCount()
  {
    birdsPerDay[GetTodayIndex()] = Today() + 1;
  }

  public bool HasDayWithoutBirds()
  {
    for (int idx = 0; idx <= GetTodayIndex(); idx++)
    {
      if (birdsPerDay[idx] == 0) return true;
    }

    return false;
  }

  public int CountForFirstDays(int numberOfDays)
  {
    int count = 0;
    for (int idx = 0; idx < numberOfDays; idx++)
    {
      count += birdsPerDay[idx];
    }

    return count;
  }

  public int BusyDays()
  {
    int busyDays = 0;
    for (int idx = 0; idx <= GetTodayIndex(); idx++)
    {
      busyDays += (birdsPerDay[idx] >= 5) ? 1 : 0;
    }

    return busyDays;
  }
}
