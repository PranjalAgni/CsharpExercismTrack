using System;

static class Appointment
{
  public static DateTime Schedule(string appointmentDateDescription)
  {
    return DateTime.Parse(appointmentDateDescription);
  }

  public static bool HasPassed(DateTime appointmentDate)
  {
    DateTime currentDate = DateTime.Now;
    return (appointmentDate < currentDate) ? true : false;
  }

  public static bool IsAfternoonAppointment(DateTime appointmentDate)
  {
    bool isHourInAfternoon = appointmentDate.Hour >= 12 && appointmentDate.Hour <= 18;
    if (!isHourInAfternoon) return false;
    if (appointmentDate.Hour == 18) return appointmentDate.Minute < 00;
    return true;
  }

  public static string Description(DateTime appointmentDate)
  {
    return $"You have an appointment on {appointmentDate.ToString()}.";
  }

  public static DateTime AnniversaryDate()
  {
    return new DateTime(DateTime.Now.Year, 9, 15, 0, 0, 0);
  }
}
