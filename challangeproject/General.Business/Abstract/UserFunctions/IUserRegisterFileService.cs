using General.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.Business.Abstract
{
   public interface IUserRegisterFileService
    {
        UserRegisterFile GetById(int Id);
        UserRegisterFile GetByString(string filter);
        UserRegisterFile GetDefault();
        List<UserRegisterFile> GetCustomAll();
        void Create(UserRegisterFile entity);
        void Update(UserRegisterFile entity);
        void Delete(UserRegisterFile entity);
    }
}
