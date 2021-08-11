using General.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.Business.Abstract
{
    public interface IMyCommentService
    {
        MyComment GetById(int Id);
        MyComment GetByString(string filter);
        MyComment GetDefault();
        List<MyComment> GetCustomAll();
        void Create(MyComment entity);
        void Update(MyComment entity);
        void Delete(MyComment entity);
    }
}
