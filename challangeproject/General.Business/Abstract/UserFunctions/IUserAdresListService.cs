using General.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.Business.Abstract
{
    public interface IUserAdresListService
    {
        UserAdresList GetById(int Id);
        UserAdresList GetByString(string filter);
        UserAdresList GetDefault();
        List<UserAdresList> GetCustomAll();
        void Create(UserAdresList entity);
        void Update(UserAdresList entity);
        void Delete(UserAdresList entity);
    }
}
