using General.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.Business.Abstract
{
    public interface IMyTaskService
    {
        MyTask GetById(int Id);
        MyTask GetByString(string filter);
        MyTask GetDefault();
        List<MyTask> GetCustomAll();
        void Create(MyTask entity);
        void Update(MyTask entity);
        void Delete(MyTask entity);
    }
}
