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
    public class MyTaskManager : IMyTaskService
    {
        private IMyTaskDal _MyTaskService;
        public MyTaskManager(IMyTaskDal MyTaskService)
        {
            _MyTaskService = MyTaskService;
        }

        public void Create(MyTask entity)
        {
            _MyTaskService.Create(entity);
        }
        public void Update(MyTask entity)
        {
            _MyTaskService.Update(entity);
        }

        public void Delete(MyTask entity)
        {
            _MyTaskService.Delete(entity);
        }

        public MyTask GetById(int Id)
        {
            return _MyTaskService.GetById(Id);
        }
        public MyTask GetByString(string filter)
        {
            return _MyTaskService.GetByString(filter);
        }

        public List<MyTask> GetCustomAll()
        {
            return _MyTaskService.GetCustomAll().ToList();
        }

        public MyTask GetDefault()
        {
            return _MyTaskService.GetDefault();
        }

    }
}
