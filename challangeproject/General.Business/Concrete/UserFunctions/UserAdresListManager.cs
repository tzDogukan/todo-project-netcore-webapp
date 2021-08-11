using General.Business.Abstract;

using General.DataAccess.Abstract;

using General.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.Business.Concrete
{

    public class UserAdresListManager : IUserAdresListService
    {
        private IUserAdresListDal _userAdresListService;
        public UserAdresListManager(IUserAdresListDal userAdresListService)
        {
            _userAdresListService = userAdresListService;
        }

        public void Create(UserAdresList entity)
        {
            _userAdresListService.Create(entity);
        }
        public void Update(UserAdresList entity)
        {
            _userAdresListService.Update(entity);
        }

        public void Delete(UserAdresList entity)
        {
            _userAdresListService.Delete(entity);
        }

        public UserAdresList GetById(int Id)
        {
            return _userAdresListService.GetById(Id);
        }
        public UserAdresList GetByString(string filter)
        {
            return _userAdresListService.GetByString(filter);
        }

        public List<UserAdresList> GetCustomAll()
        {
            return _userAdresListService.GetCustomAll().ToList();
        }

        public UserAdresList GetDefault()
        {
            return _userAdresListService.GetDefault();
        }

    }
}
