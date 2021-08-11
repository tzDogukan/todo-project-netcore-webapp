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
    public class MyDropBoxManager : IMyDropBoxService
    {
        private IMyDropBoxDal _MyDropBoxService;
        public MyDropBoxManager(IMyDropBoxDal MyDropBoxService)
        {
            _MyDropBoxService = MyDropBoxService;
        }

        public void Create(MyDropBox entity)
        {
            _MyDropBoxService.Create(entity);
        }
        public void Update(MyDropBox entity)
        {
            _MyDropBoxService.Update(entity);
        }

        public void Delete(MyDropBox entity)
        {
            _MyDropBoxService.Delete(entity);
        }

        public MyDropBox GetById(int Id)
        {
            return _MyDropBoxService.GetById(Id);
        }
        public MyDropBox GetByString(string filter)
        {
            return _MyDropBoxService.GetByString(filter);
        }
        public List<MyDropBox> GetCustomAll()
        {
            return _MyDropBoxService.GetCustomAll().ToList();
        }

        public MyDropBox GetDefault()
        {
            return _MyDropBoxService.GetDefault();
        }

    }
}
