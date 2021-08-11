
using General.Business.Abstract;
using General.DataAccess.Abstract;
using General.Entities;
using System.Collections.Generic;
using System.Linq;


namespace General.Business.Concrete
{

    public class GeneralUISettingsManager : IGeneralUISettingsService
    {
        private IGeneralUISettingsDal _generalUISettingsDal;
        public GeneralUISettingsManager(IGeneralUISettingsDal generalUISettingsDal)
        {
            _generalUISettingsDal = generalUISettingsDal;
        }

        public void Create(userTask entity)
        {
            _generalUISettingsDal.Create(entity);
        }
        public void Update(userTask entity)
        {
            _generalUISettingsDal.Update(entity);
        }

        public void Delete(userTask entity)
        {
            _generalUISettingsDal.Delete(entity);
        }

        public userTask GetById(int Id)
        {
            return _generalUISettingsDal.GetById(Id);
        }

        public userTask GetByString(string filter)
        {
            return _generalUISettingsDal.GetByString(filter);
        }
        

        public List<userTask> GetCustomAll()
        {
            return _generalUISettingsDal.GetCustomAll().ToList();
        }

        public userTask GetDefault()
        {
            return _generalUISettingsDal.GetDefault();
        }


    }
  
    
}