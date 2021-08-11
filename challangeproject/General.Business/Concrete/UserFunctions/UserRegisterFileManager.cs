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
    public class UserRegisterFileManager : IUserRegisterFileService
    {
        private IUserRegisterFileDal _UserRegisterFileService;
        public UserRegisterFileManager(IUserRegisterFileDal UserRegisterFileService)
        {
            _UserRegisterFileService = UserRegisterFileService;
        }

        public void Create(UserRegisterFile entity)
        {
            _UserRegisterFileService.Create(entity);
        }
        public void Update(UserRegisterFile entity)
        {
            _UserRegisterFileService.Update(entity);
        }

        public void Delete(UserRegisterFile entity)
        {
            _UserRegisterFileService.Delete(entity);
        }

        public UserRegisterFile GetById(int Id)
        {
            return _UserRegisterFileService.GetById(Id);
        }
        public UserRegisterFile GetByString(string filter)
        {
            return _UserRegisterFileService.GetByString(filter);
        }

        public List<UserRegisterFile> GetCustomAll()
        {
            return _UserRegisterFileService.GetCustomAll().ToList();
        }

        public UserRegisterFile GetDefault()
        {
            return _UserRegisterFileService.GetDefault();
        }

    }
}
