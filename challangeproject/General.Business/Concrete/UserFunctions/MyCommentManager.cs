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
    public class MyCommentManager : IMyCommentService
    {
        private IMyCommentDal _myCommentService;
        public MyCommentManager(IMyCommentDal myCommentService)
        {
            _myCommentService = myCommentService;
        }

        public void Create(MyComment entity)
        {
            _myCommentService.Create(entity);
        }
        public void Update(MyComment entity)
        {
            _myCommentService.Update(entity);
        }

        public void Delete(MyComment entity)
        {
            _myCommentService.Delete(entity);
        }

        public MyComment GetById(int Id)
        {
            return _myCommentService.GetById(Id);
        }
        public MyComment GetByString(string filter)
        {
            return _myCommentService.GetByString(filter);
        }

        public List<MyComment> GetCustomAll()
        {
            return _myCommentService.GetCustomAll().ToList();
        }

        public MyComment GetDefault()
        {
            return _myCommentService.GetDefault();
        }

    }
}
