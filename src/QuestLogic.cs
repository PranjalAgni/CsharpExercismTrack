// annalyns-infiltration
using System;
static class QuestLogic
{
  public static bool CanFastAttack(bool knightIsAwake)
  {
    return knightIsAwake == false;
  }
  public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
  {
    return (knightIsAwake || archerIsAwake || prisonerIsAwake);
  }
  public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
  {
    return (!archerIsAwake && prisonerIsAwake);
  }
  public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
  {
    if (petDogIsPresent)
    {
      return !archerIsAwake;
    }
    else
    {
      return (prisonerIsAwake && !knightIsAwake && !archerIsAwake);
    }
  }
}
