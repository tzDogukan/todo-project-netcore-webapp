using General.DataAccess.Abstract;
using General.Entities;
using System.Linq;


namespace General.DataAccess.Concrete.EFCore
{

    public class EFCoreGeneralUISettingsDal : EFCoreGeneralRepository<userTask, GeneralSettingsContext>, IGeneralUISettingsDal
    {
        public userTask GetDefault()
        {
            using (var context = new GeneralSettingsContext())
            {
                return context.userTask
                .FirstOrDefault();
            }
        }
    }
  
}
