
using General.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlCenter.WebUI.Models
{
    public class LoginModel
    {
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Lütfen E-Mail adresinizi giriniz.")]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Lütfen Parolanızı giriniz.")]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string NormalizedUserName { get; set; }
        public string ReferanceNumber { get; set; }

        public string NameSurname { get; set; }
        public string BirthDate { get; set; }
        public string RegisterDate { get; set; }
        public string UserProfilePicture { get; set; }
        public string ContractStatus { get; set; }
        public string AdminActivated { get; set; }

        //SOCIAL MEDIA ADRESS//
        public string Instagram { get; set; }
        public string Facebook { get; set; }
        public string Linkedin { get; set; }
        public string Twitter { get; set; }
        public string Youtube { get; set; }
        public string WhatsApp { get; set; }
        public string Telegram { get; set; }
    }
    public class ResultMessages
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public string Css { get; set; }
    }
    public class ResetPasswordModel
    {
        [Required]
        public string Token { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Lütfen E-Mail adresinizi giriniz.")]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Lütfen Parolanızı giriniz.")]
        public string Password { get; set; }
    }

    public class CreateRole
    {
        [Required]
        public string RoleName { get; set; }
    }

    public class EditUser
    {
        public EditUser()
        {
            Roles = new List<string>();

        }
        public string Id { get; set; }

        [Required]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string ReferanceNumber { get; set; }

        public string NameSurname { get; set; }
        public string BirthDate { get; set; }
        public string RegisterDate { get; set; }
        public string UserProfilePicture { get; set; }
        public string ContractStatus { get; set; }
        public string AdminActivated { get; set; }

        //SOCIAL MEDIA ADRESS//
        public string Instagram { get; set; }
        public string Facebook { get; set; }
        public string Linkedin { get; set; }
        public string Twitter { get; set; }
        public string Youtube { get; set; }
        public string WhatsApp { get; set; }
        public string Telegram { get; set; }
        public IList<string> Roles { get; set; }

        public List<UserAdresList> ListUserAdresList { get; set; }
        public UserAdresList UserAdresList { get; set; }

        public List<UserContent> ListUserContent { get; set; }
        public UserContent UserContent { get; set; }

        public List<UserRegisterFile> ListUserRegisterFile { get; set; }
        public UserRegisterFile UserRegisterFile { get; set; }

        public List<UserNotification> ListUserNotifications { get; set; }
        public UserNotification UserNotification { get; set; }

        public List<MyComment> ListMyComment { get; set; }
        public MyComment MyComment { get; set; }

        public List<MyTask> ListMyTask { get; set; }
        public MyTask MyTask { get; set; }

        public List<MyDropBox> ListMyDropBox { get; set; }
        public MyDropBox MyDropBox { get; set; }

        

    }

    public class UserRoles
    {
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public bool IsSelected { get; set; }
    }

}