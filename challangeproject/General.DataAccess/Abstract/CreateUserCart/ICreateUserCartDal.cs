using General.DataAccess.Abstract;
using General.Entities;

namespace General.DataAccess.Abstrack
{
    public interface ICreateUserCartDal : IGeneralRepository<CreateUserCart>
    {
        CreateUserCart GetByUserId(string userId);
    }
}
