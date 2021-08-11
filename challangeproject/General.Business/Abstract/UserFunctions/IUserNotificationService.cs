using General.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.Business.Abstract
{
    public interface IUserNotificationService
    {
        UserNotification GetById(int Id);
        UserNotification GetByString(string filter);
        UserNotification GetDefault();
        List<UserNotification> GetCustomAll();
        void Create(UserNotification entity);
        void Update(UserNotification entity);
        void Delete(UserNotification entity);
    }
}
