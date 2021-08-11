using General.DataAccess.Abstract;
using General.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.DataAccess.Concrete.EFCore
{
    public class EFCoreUserAdresListDal : EFCoreGeneralRepository<UserAdresList, GeneralSettingsContext>, IUserAdresListDal
    {
        public UserAdresList GetDefault()
        {
            using (var context = new GeneralSettingsContext())
            {
                return context.UserAdresLists
                .FirstOrDefault();
            }
        }
    }
}
