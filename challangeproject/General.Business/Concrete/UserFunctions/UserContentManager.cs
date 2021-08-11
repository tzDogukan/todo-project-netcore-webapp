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
    public class UserContentManager : IUserContentService
    {
        private IUserContentDal _UserContentService;
        public UserContentManager(IUserContentDal UserContentService)
        {
            _UserContentService = UserContentService;
        }

        public void Create(UserContent entity)
        {
            _UserContentService.Create(entity);
        }
        public void Update(UserContent entity)
        {
            _UserContentService.Update(entity);
        }

        public void Delete(UserContent entity)
        {
            _UserContentService.Delete(entity);
        }

        public UserContent GetById(int Id)
        {
            return _UserContentService.GetById(Id);
        }
        public UserContent GetByString(string filter)
        {
            return _UserContentService.GetByString(filter);
        }

        public List<UserContent> GetCustomAll()
        {
            return _UserContentService.GetCustomAll().ToList();
        }

        public UserContent GetDefault()
        {
            return _UserContentService.GetDefault();
        }

    }
}
