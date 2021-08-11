using General.DataAccess.Abstract;

using General.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.DataAccess.Concrete.EFCore
{
    public class EFCoreUserContentDal : EFCoreGeneralRepository<UserContent, GeneralSettingsContext>, IUserContentDal
    {
        public UserContent GetDefault()
        {
            using (var context = new GeneralSettingsContext())
            {
                return context.UserContents
                .FirstOrDefault();
            }
        }
    }
}
