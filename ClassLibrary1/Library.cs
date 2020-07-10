

















































using System;

namespace ClassLibrary1
{
  public class Library
  {
    public static string GetName(string name)
    {
      return $"{DateTime.Now} Hello, {name}"; 
    }
  }
}
