using General.Business.Abstrack;
using General.DataAccess.Abstrack;
using General.Entities;
using System.Collections.Generic;
using System.Linq;

namespace General.Business.Concrete
{
    public class CreateUserCartManager : ICreateUserCartService
    {
        private ICreateUserCartDal _cartDal;
        public CreateUserCartManager(ICreateUserCartDal cartDal)
        {
            _cartDal = cartDal;
        }

        public CreateUserCart GetCartByUserId(string userId)
        {
            return _cartDal.GetByUserId(userId);
        }
      
        public void InitializeCart(string userId)
        {
            _cartDal.Create(new Entities.CreateUserCart()
            {
                UserId = userId
            });
        }

        public List<CreateUserCart> GetCustomAll()
        {
            return _cartDal.GetCustomAll().ToList();
        }
    }
}
