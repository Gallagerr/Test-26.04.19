using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
  public class User : Entity
  {
    public string Login { get; set; }

    public string Password { get; set; }

    public string Password2 { get; set; }

    public int Money { get; set; }

    public string Address { get; set; }

    public DateTime Since { get; set; }

    public virtual Subscribe Subscribe { get; set; }

    public void Registrait()
    {
      using (var context = new DataContext())
      {
        Console.WriteLine("Введите логин: ");
        Login = Console.ReadLine().ToString();

        Console.WriteLine("Введите пароль: ");
        Password = Console.ReadLine().ToString();

        Console.WriteLine("Повторите пароль: ");
        Password2 = Console.ReadLine().ToString();
        if (Password2 == Password.ToString())
        {
          Console.WriteLine("Введите ваш адрес: ");
          Address = Console.ReadLine().ToString();

          Console.WriteLine("Введите ваше количество денег: ");
          string input = Console.ReadLine();

          Console.WriteLine("Введите ваше количество денег: ");

          Console.WriteLine("Выберите и оформите подписку: ");
          Since = DateTime.Today;
        }
        else
          Console.WriteLine("Неправильно попробуйте еще раз");
      }
    }
 
  public void Entrance()
  {
    using (var context = new DataContext())
    {
      Console.WriteLine("Введите логин: ");
      Login = Console.ReadLine().ToString();

      Console.WriteLine("Введите пароль: ");
      Password = Console.ReadLine().ToString();
    }
  }

  public void Pay()
    {
      Money = Money - Subscribe.Cost;
    }

    void CancelSubscribe()
    {
      Subscribe = null;
    }
  }
}
