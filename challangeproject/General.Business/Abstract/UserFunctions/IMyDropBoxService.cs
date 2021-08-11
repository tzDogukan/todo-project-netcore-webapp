using General.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.Business.Abstract
{
    public interface IMyDropBoxService
    {
        MyDropBox GetById(int Id);
        MyDropBox GetByString(string filter);
        MyDropBox GetDefault();
        List<MyDropBox> GetCustomAll();
        void Create(MyDropBox entity);
        void Update(MyDropBox entity);
        void Delete(MyDropBox entity);
    }
}
