using General.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace General.DataAccess.Concrete.EFCore
{
    public class GeneralSettingsSeedDatabase
    {
        public static void Seed()
        {
            var context = new GeneralSettingsContext();

            if (context.Database.GetPendingMigrations().Count() == 0)
            {


                context.SaveChanges();
            }
        }



    }

}
