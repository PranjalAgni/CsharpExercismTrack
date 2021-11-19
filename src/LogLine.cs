using System;

static class LogLine
{
  public static string[] GetMessageList(string logLine)
  {
    string[] messageList = logLine.Split(':');
    return messageList;
  }

  public static string Message(string logLine)
  {
    string[] messageList = GetMessageList(logLine);
    string message = messageList[1].Trim();
    return message;
  }

  public static string LogLevel(string logLine)
  {
    string[] messageList = GetMessageList(logLine);
    int length = messageList[0].Length;
    string logLevel = messageList[0].Substring(1, length - 2).ToLower();
    return logLevel;
  }

  public static string Reformat(string logLine)
  {
    string message = Message(logLine);
    string logLevel = LogLevel(logLine);
    return $"{message} ({logLevel})";
  }
}
