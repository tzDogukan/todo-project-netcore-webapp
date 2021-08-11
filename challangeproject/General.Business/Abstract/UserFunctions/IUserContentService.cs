using General.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.Business.Abstract
{
    public interface IUserContentService
    {
        UserContent GetById(int Id);
        UserContent GetByString(string filter);
        UserContent GetDefault();
        List<UserContent> GetCustomAll();
        void Create(UserContent entity);
        void Update(UserContent entity);
        void Delete(UserContent entity);
    }
}
