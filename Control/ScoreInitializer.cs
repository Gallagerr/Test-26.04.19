using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
  public class ScoreInitializer : CreateDatabaseIfNotExists<DataContext>
  {
    protected override void Seed(DataContext context)
    {
      context.Subscribes.AddRange(new List<Subscribe>
      {
         new Subscribe
         {
            Cost = 12000,
            Duration_Month ="12 Month"
         },
          new Subscribe
         {
            Cost = 240000,
            Duration_Month = "24 Month"
         },
           new Subscribe
         {
            Cost = 36000,
            Duration_Month = "36 Month"
         },
      });
      context.SaveChanges();
    }
  }
}
