using General.DataAccess.Abstract;
using General.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.DataAccess.Concrete.EFCore
{
    public class EFCoreMyDropBoxDal : EFCoreGeneralRepository<MyDropBox, GeneralSettingsContext>, IMyDropBoxDal
    {
        public MyDropBox GetDefault()
        {
            using (var context = new GeneralSettingsContext())
            {
                return context.MyDropBoxes
                .FirstOrDefault();
            }
        }
    }
}
