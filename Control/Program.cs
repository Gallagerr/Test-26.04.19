using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Здравствуйте позвольте узнать кто вы?");
      Console.WriteLine("1.Пользователь");
      Console.WriteLine("2.Админ");

      int choice = int.Parse(Console.ReadLine());
           if (choice == 1)
      {
        User newUser= new User();
        newUser.Registrait();
      }
      if (choice == 2)
      {
        User newAdmin = new User();
        newAdmin.Entrance();
      }
    }
  }
}
