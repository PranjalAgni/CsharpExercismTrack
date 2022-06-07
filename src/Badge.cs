using System;
#nullable enable

static class Badge
{
  public static string Print(int? id, string name, string? department)
  {
    string formattedEmployeeBadge = "";
    if (id != null)
    {
      formattedEmployeeBadge += $"[{id}] - ";
    }

    formattedEmployeeBadge += name;

    department = department ?? "OWNER";
    formattedEmployeeBadge += $" - {department?.ToUpper()}";
    return formattedEmployeeBadge;
  }
}
