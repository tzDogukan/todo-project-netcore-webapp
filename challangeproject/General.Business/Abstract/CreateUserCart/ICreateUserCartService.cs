using General.Entities;
using System.Collections.Generic;

namespace General.Business.Abstrack
{
    public interface ICreateUserCartService
    {
        void InitializeCart(string userId);
        CreateUserCart GetCartByUserId(string userId);

        List<CreateUserCart> GetCustomAll();
    }
}
