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

    public class UserNotificationManager : IUserNotificationService
    {
        private IUserNotificationDal _UserNotificationService;
        public UserNotificationManager(IUserNotificationDal UserNotificationService)
        {
            _UserNotificationService = UserNotificationService;
        }

        public void Create(UserNotification entity)
        {
            _UserNotificationService.Create(entity);
        }
        public void Update(UserNotification entity)
        {
            _UserNotificationService.Update(entity);
        }

        public void Delete(UserNotification entity)
        {
            _UserNotificationService.Delete(entity);
        }

        public UserNotification GetById(int Id)
        {
            return _UserNotificationService.GetById(Id);
        }
        public UserNotification GetByString(string filter)
        {
            return _UserNotificationService.GetByString(filter);
        }

        public List<UserNotification> GetCustomAll()
        {
            return _UserNotificationService.GetCustomAll().ToList();
        }

        public UserNotification GetDefault()
        {
            return _UserNotificationService.GetDefault();
        }

    }
}
