using General.Entities;
using System.Collections.Generic;

namespace General.Business.Abstract
{
    public interface IGeneralUISettingsService
    {
        userTask  GetById(int Id);
        userTask GetByString(string filter);
        userTask GetDefault();
        List<userTask> GetCustomAll();
        void Create(userTask entity);
        void Update(userTask entity);
        void Delete(userTask entity);
    }
  
}
