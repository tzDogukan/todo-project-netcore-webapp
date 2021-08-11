using General.Entities;
namespace General.DataAccess.Abstract
{
    public interface IGeneralUISettingsDal : IGeneralRepository<userTask>
    {
        userTask GetDefault();

    }
  
}
