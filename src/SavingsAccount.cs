using System;

static class SavingsAccount
{
  public static float InterestRate(decimal balance)
  {
    float interestRate = 2.475f;
    if (balance < 0m)
    {
      interestRate = 3.213f;
    }
    else if (balance < 1000m)
    {
      interestRate = 0.5f;
    }
    else if (balance >= 1000m && balance < 5000m)
    {
      interestRate = 1.621f;
    }

    return interestRate;
  }

  public static decimal Interest(decimal balance)
  {
    decimal interestRate = (decimal)InterestRate(balance);
    return (interestRate * balance) / 100;
  }

  public static decimal AnnualBalanceUpdate(decimal balance)
  {
    decimal interestAmount = Interest(balance);
    return balance + interestAmount;
  }

  public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
  {
    int numOfYears = 0;
    while (balance < targetBalance)
    {
      balance = AnnualBalanceUpdate(balance);
      numOfYears += 1;
    }

    return numOfYears;
  }
}
