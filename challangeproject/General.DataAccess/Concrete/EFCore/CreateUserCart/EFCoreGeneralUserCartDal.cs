using General.DataAccess.Abstrack;
using General.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace General.DataAccess.Concrete.EFCore
{
    public class EFCoreCreateUserCartDal : EFCoreGeneralRepository<CreateUserCart, GeneralSettingsContext>, ICreateUserCartDal
    {
        public CreateUserCart GetByUserId(string userId)
        {
            using (var context = new GeneralSettingsContext())
            {
                return context
                    .CreateUserCarts
                    .FirstOrDefault(i => i.UserId == userId);
            }
        }
    }
}
