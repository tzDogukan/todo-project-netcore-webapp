using General.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace General.DataAccess.Abstract
{
    public interface IUserContentDal : IGeneralRepository<UserContent>
    {
        UserContent GetDefault();

    }
}
