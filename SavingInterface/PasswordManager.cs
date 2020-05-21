using System;

namespace SavingInterface
{
  class PasswordManager : IDisplayable
  {
    private string Password
    { get; set; }

    public bool Hidden
    { get; private set; }

    public string HeaderSymbol
    { get{ return "-------------------";} }

    public PasswordManager(string password, bool hidden)
    {
      Password = password;
      Hidden = hidden;
    }

    public void Display()
    {
      Console.WriteLine("Password:");
      Console.WriteLine(HeaderSymbol);
      if (Hidden is false)
      {
        Console.WriteLine(Password);
      }else
      {
        for (int i = 0; i<Password.Length; i++)
        {
          Console.Write("*");
        }
        Console.WriteLine("");
      }
    }
    public void Reset()
    {
      Password = "";
      Hidden = false;
    }
  }
}