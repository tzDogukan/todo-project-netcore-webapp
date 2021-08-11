using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ControlCenter.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using ControlCenter.WebUI.Models;
using ControlCenter.WebUI.Extensions;
using General.Business.Abstract;
using General.Business.Abstrack;
using Microsoft.AspNetCore.Http;
using System.IO;


namespace Account.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class AccountController : Controller
    {
        private SignInManager<ApplicationUser> _signInManager;
        private UserManager<ApplicationUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;
        private IEmailSender _emailSender;
        private ICreateUserCartService _cartService;






        // USERR FUNCTIONS

        private IMyCommentService _myCommentService;
        private IMyTaskService _myTaskService;
        private IMyDropBoxService _myDropBoxService;
        private IUserAdresListService _userAdresListService;
        private IUserContentService _userContentService;
        private IUserNotificationService _userNotificationService;
        private IUserRegisterFileService _userRegisterFileService;

        public AccountController(UserManager<ApplicationUser> userManager,  IMyCommentService myCommentService, IUserAdresListService userAdresListService, IMyDropBoxService myDropBoxService, IMyTaskService myTaskService, IUserContentService userContentService, IUserNotificationService userNotificationService, IUserRegisterFileService userRegisterFileService, SignInManager<ApplicationUser> signInManager, IEmailSender emailSender,  ICreateUserCartService cartService, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _cartService = cartService;





            // USER FUNCTIONS 

            _myCommentService = myCommentService;
            _myTaskService = myTaskService;
            _myDropBoxService = myDropBoxService;
            _userAdresListService = userAdresListService;
            _userContentService = userContentService;
            _userNotificationService = userNotificationService;
            _userRegisterFileService = userRegisterFileService;
        }

        private void AllBadgeNotification()
        {

            var yenikullanıcı = _userManager.Users.Where(i => i.AdminActivated == "new").Count();
            var onaybekleyenkullanıcı = _userManager.Users.Where(i => i.AdminActivated == "waiting").Count();
            var onaylıkullanıcı = _userManager.Users.Where(i => i.AdminActivated == "true").Count();

            ViewData["NewUser"] = yenikullanıcı;
            ViewData["WaitingUser"] = onaybekleyenkullanıcı;
            ViewData["UserList"] = onaylıkullanıcı;
        }




        public IActionResult MyProfile()
        {
            AllBadgeNotification();
            var userid = _userManager.GetUserId(HttpContext.User);


            var UserCartId = _cartService.GetCartByUserId(_userManager.GetUserId(HttpContext.User));
            var cartid = UserCartId.Id;

            var usermodel = new UserFunctionMasterModel
            {

                MyDropBoxes = _myDropBoxService.GetCustomAll().Where(i => i.CreateUserCartId == cartid).ToList(),
                MyComments = _myCommentService.GetCustomAll().Where(i => i.CreateUserCartId == cartid).ToList(),
                MyTasks = _myTaskService.GetCustomAll().Where(i => i.CreateUserCartId == cartid).ToList(),
                UserNotifications = _userNotificationService.GetCustomAll().Where(i => i.CreateUserCartId == cartid).ToList(),


                UserAdresLists = _userAdresListService.GetCustomAll().Where(i => i.CreateUserCartId == cartid).ToList(),
                UserRegisterFiles = _userRegisterFileService.GetCustomAll().Where(i => i.CreateUserCartId == cartid).ToList(),
                UserContents = _userContentService.GetCustomAll().Where(i => i.CreateUserCartId == cartid).ToList(),

            };

            if (usermodel.MyDropBoxes.Count() == 0)
            {
                ViewBag.MyDropBoxes = "false";
            }
            else
            {
                ViewBag.MyDropBoxes = "true";
            };

            if (usermodel.MyComments.Count() == 0)
            {
                ViewBag.MyComments = "false";
            }
            else
            {
                ViewBag.MyComments = "true";
            };

            if (usermodel.MyTasks.Count() == 0)
            {
                ViewBag.MyTasks = "false";
            }
            else
            {
                ViewBag.MyTasks = "true";
            };
            if (usermodel.UserNotifications.Count() == 0)
            {
                ViewBag.UserNotifications = "false";
            }
            else
            {
                ViewBag.UserNotifications = "true";
            };
            if (usermodel.UserAdresLists.Count() == 0)
            {
                ViewBag.UserAdresLists = "false";
            }
            else
            {
                ViewBag.UserAdresLists = "true";
            };
            if (usermodel.UserRegisterFiles.Count() == 0)
            {
                ViewBag.UserRegisterFiles = "false";
            }
            else
            {
                ViewBag.UserRegisterFiles = "true";
            };
            if (usermodel.UserContents.Count() == 0)
            {
                ViewBag.UserContents = "false";
            }
            else
            {
                ViewBag.UserContents = "true";
            };

            if (userid == null)
            {
                return RedirectToAction("Login", "Account");
            }
            else
            {
                ApplicationUser user = _userManager.FindByIdAsync(userid).Result;
                return View(user);
            }
        }
        public IActionResult CreateRole()
        {
            AllBadgeNotification();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRoleAsync(CreateRole model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            IdentityRole identityRole = new IdentityRole
            {
                Name = model.RoleName
            };
            IdentityResult result = await _roleManager.CreateAsync(identityRole);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "ControlCenter");
            }
            foreach (IdentityError error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            TempData["CreateRoleSuccess"] = " ";
            return View(model);
        }

        public IActionResult UsersList()
        {
            AllBadgeNotification();
            var users = _userManager.Users;
            return View(users.Where(x => x.AdminActivated == "true").Where(x => x.UserName != "admin"));

        }


        public async Task<IActionResult> StudentListAsync()
        {
            AllBadgeNotification();
            List<ApplicationUser> students = new List<ApplicationUser>();
            var users = await _userManager.GetUsersInRoleAsync("ogrenci");
            foreach (var user in users)
            {
                students.Add(new ApplicationUser { Id = user.Id, Email = user.Email, AccessFailedCount = user.AccessFailedCount, UserName = user.UserName, BirthDate = user.BirthDate, AdminActivated = user.AdminActivated, UserProfilePicture = user.UserProfilePicture, PhoneNumber = user.PhoneNumber, RegisterDate = user.RegisterDate, });
            }

            return View(students);
        }

        public IActionResult WaitingUsersList()
        {
            AllBadgeNotification();
            var users = _userManager.Users;
            return View(users.Where(x => x.AdminActivated == "waiting").Where(x => x.UserName != "admin"));
        }

        public IActionResult NewUsersList()
        {
            AllBadgeNotification();
            var users = _userManager.Users;
            return View(users.Where(x => x.AdminActivated == "new" || x.AdminActivated == null).Where(x => x.UserName != "admin"));
        }

        public async Task<IActionResult> YonetimKullanıcıları()
        {
            AllBadgeNotification();
            List<ApplicationUser> managers = new List<ApplicationUser>();
            var admins = await _userManager.GetUsersInRoleAsync("admin");
            var coachs = await _userManager.GetUsersInRoleAsync("coach");





            foreach (var user in admins)
            {
                if (user.UserName != "admin")
                {

                    managers.Add(new ApplicationUser { Id = user.Id, Email = user.Email, UserName = user.UserName, NameSurname = user.NameSurname, ReferanceNumber = user.ReferanceNumber, AdminActivated = user.AdminActivated, UserProfilePicture = user.UserProfilePicture, PhoneNumber = user.PhoneNumber, RegisterDate = user.RegisterDate, });
                }
                }
            foreach (var user in coachs)
            {
                if (user.UserName != "admin")
                {
                    bool containsItem = managers.Any(item => item.Id == user.Id);
                    if (containsItem == false)
                    {
                        managers.Add(new ApplicationUser { Id = user.Id, Email = user.Email, UserName = user.UserName, NameSurname = user.NameSurname, ReferanceNumber = user.ReferanceNumber, AdminActivated = user.AdminActivated, UserProfilePicture = user.UserProfilePicture, PhoneNumber = user.PhoneNumber, RegisterDate = user.RegisterDate, });

                    }
                }
            }

            return View(managers);
        }

        public async Task<IActionResult> EditUser(string id)
        {
            AllBadgeNotification();

            var user = await _userManager.FindByIdAsync(id);


            var UserCartId = _cartService.GetCartByUserId(user.Id);
            var cartid = UserCartId.Id;

            var usermodel = new UserFunctionMasterModel
            {

                MyDropBoxes = _myDropBoxService.GetCustomAll().Where(i => i.CreateUserCartId == cartid).ToList(),
                MyComments = _myCommentService.GetCustomAll().Where(i => i.CreateUserCartId == cartid).ToList(),
                MyTasks = _myTaskService.GetCustomAll().Where(i => i.CreateUserCartId == cartid).ToList(),
                UserNotifications = _userNotificationService.GetCustomAll().Where(i => i.CreateUserCartId == cartid).ToList(),


                UserAdresLists = _userAdresListService.GetCustomAll().Where(i => i.CreateUserCartId == cartid).ToList(),
                UserRegisterFiles = _userRegisterFileService.GetCustomAll().Where(i => i.CreateUserCartId == cartid).ToList(),
                UserContents = _userContentService.GetCustomAll().Where(i => i.CreateUserCartId == cartid).ToList(),

            };

            if (usermodel.MyDropBoxes.Count() == 0)
            {
                ViewBag.MyDropBoxes = "false";
            }
            else
            {
                ViewBag.MyDropBoxes = "true";
            };

            if (usermodel.MyComments.Count() == 0)
            {
                ViewBag.MyComments = "false";
            }
            else
            {
                ViewBag.MyComments = "true";
            };

            if (usermodel.MyTasks.Count() == 0)
            {
                ViewBag.MyTasks = "false";
            }
            else
            {
                ViewBag.MyTasks = "true";
            };
            if (usermodel.UserNotifications.Count() == 0)
            {
                ViewBag.UserNotifications = "false";
            }
            else
            {
                ViewBag.UserNotifications = "true";
            };
            if (usermodel.UserAdresLists.Count() == 0)
            {
                ViewBag.UserAdresLists = "false";
            }
            else
            {
                ViewBag.UserAdresLists = "true";
            };
            if (usermodel.UserRegisterFiles.Count() == 0)
            {
                ViewBag.UserRegisterFiles = "false";
            }
            else
            {
                ViewBag.UserRegisterFiles = "true";
            };
            if (usermodel.UserContents.Count() == 0)
            {
                ViewBag.UserContents = "false";
            }
            else
            {
                ViewBag.UserContents = "true";
            };

            if (user == null)
            {
                return RedirectToAction("Index", "ControlCenter");
            }
            var userRoles = await _userManager.GetRolesAsync(user);

            var model = new EditUser
            {
                Id = user.Id,
                Email = user.Email,
                UserName = user.UserName,
                PhoneNumber = user.PhoneNumber,
                ReferanceNumber = user.ReferanceNumber,
                BirthDate = user.BirthDate,
                RegisterDate = user.RegisterDate,
                UserProfilePicture = user.UserProfilePicture,
                ContractStatus = user.ContractStatus,
                AdminActivated = user.AdminActivated,
                Youtube = user.Youtube,
                WhatsApp = user.WhatsApp,
                Facebook = user.Facebook,
                Telegram = user.Telegram,
                Instagram = user.Instagram,
                Linkedin = user.Linkedin,
                Twitter = user.Twitter,
                Roles = userRoles,
                NameSurname = user.NameSurname,

            };
            TempData["EditUserSuccess"] = " ";
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditMySocialAdress(EditUser model, string SelectedUserId)
        {

            if (model.Id != null)
            {
                var user = await _userManager.FindByIdAsync(model.Id);


                if (user == null)
                {
                    return RedirectToAction("Index", "ControlCenter");
                }
                user.WhatsApp = model.WhatsApp;
                user.Instagram = model.Instagram;
                user.Facebook = model.Facebook;
                user.Linkedin = model.Linkedin;
                user.Twitter = model.Twitter;
                user.Youtube = model.Youtube;
                user.WhatsApp = model.WhatsApp;
                user.Telegram = model.Telegram;

                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "ControlCenter");
                }
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            else
            {
                var userid = _userManager.GetUserId(HttpContext.User);
                var user = await _userManager.FindByIdAsync(userid);


                if (user == null)
                {
                    return RedirectToAction("Index", "ControlCenter");
                }
                user.WhatsApp = model.WhatsApp;
                user.Instagram = model.Instagram;
                user.Facebook = model.Facebook;
                user.Linkedin = model.Linkedin;
                user.Twitter = model.Twitter;
                user.Youtube = model.Youtube;
                user.WhatsApp = model.WhatsApp;
                user.Telegram = model.Telegram;

                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "ControlCenter");
                }
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            TempData["EditUserSuccess"] = " ";
            return View(model);

        }


        [HttpPost]
        public async Task<IActionResult> EditMyProfile(EditUser model, IFormFile file)
        {
            var userid = _userManager.GetUserId(HttpContext.User);
            var user = await _userManager.FindByIdAsync(userid);

            if (user == null)
            {
                return RedirectToAction("Index", "ControlCenter");
            }
            user.Email = model.Email;
            user.UserName = model.UserName;
            user.PhoneNumber = model.PhoneNumber;
            user.BirthDate = model.BirthDate;
            user.NameSurname = model.NameSurname;
            if (file != null)
            {
                user.UserProfilePicture = file.FileName;
                var deletepath1 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\profile", file.FileName);
                if (System.IO.File.Exists(deletepath1))
                {
                    System.IO.File.Delete(deletepath1);
                }
                var filename1 = Guid.NewGuid().ToString() + ".jpeg";
                user.UserProfilePicture = filename1;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\profile", filename1);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);

                }
            }
            else
            {
                user.UserProfilePicture = "user.jpg";
            }


            var result = await _userManager.UpdateAsync(user);



            if (result.Succeeded)
            {



                return RedirectToAction("MyProfile", "Account");
            }
            foreach (IdentityError error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            TempData["EditUserSuccess"] = " ";
            return RedirectToAction("MyProfile", "Account");

        }

        [HttpPost]
        public async Task<IActionResult> EditUser(EditUser model, string AdminActivated)
        {
            var user = await _userManager.FindByIdAsync(model.Id);
            if (user == null)
            {
                return RedirectToAction("Index", "ControlCenter");
            }
            user.Email = model.Email;
            user.UserName = model.UserName;
            user.PhoneNumber = model.PhoneNumber;
            user.ReferanceNumber = model.ReferanceNumber;
            user.BirthDate = model.BirthDate;
            user.RegisterDate = model.RegisterDate;
            user.AdminActivated = AdminActivated;
            user.NameSurname = model.NameSurname;

            var Subject = "HESABINIZ ONAYLANDI!";
            var EmailBody = "Hesabınız başarıyla onaylanmıştır.Sisteme giriş yapabilirsiniz";


            if (AdminActivated == "true")
            {
                await _emailSender.SendEmailAsync(user.Email, Subject, $"{EmailBody}");
            }

            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "ControlCenter");
            }
            foreach (IdentityError error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
            TempData["EditUserSuccess"] = " ";
            return View(model);

        }

        public IActionResult UyelikSozlesmeleri()
        {
            AllBadgeNotification();
            return View();
        }

        public async Task<IActionResult> ManageUserRoles(string userId)
        {
            AllBadgeNotification();
            ViewBag.userId = userId;

            var user = await _userManager.FindByIdAsync(userId);



            if (user == null)
            {
                return RedirectToAction("Index", "ControlCenter");
            }

            var model = new List<UserRoles>();

            foreach (var role in _roleManager.Roles)
            {
                var userRolesViewModel = new UserRoles
                {
                    RoleId = role.Id,
                    RoleName = role.Name
                };
                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    userRolesViewModel.IsSelected = true;
                }
                else
                {
                    userRolesViewModel.IsSelected = false;
                }
                model.Add(userRolesViewModel);
            }

            return View(model);
        }




        [HttpPost]
        public async Task<IActionResult> ManageUserRoles(List<UserRoles> model, string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);

            // create "rolepaymentclass" "rolepayment" "rolepaymenthistory"
            var findusercart = _cartService.GetCartByUserId(userId); // user id sine ait cart id yi çeker
            var CreateUserCarRoletId = findusercart.Id;


            //
            if (user == null)
            {
                return RedirectToAction("Index", "ControlCenter");
            }

            var roles = await _userManager.GetRolesAsync(user);
            var result = await _userManager.RemoveFromRolesAsync(user, roles);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot remove user existing roles");
                return View(model);
            }

            result = await _userManager.AddToRolesAsync(user,
                model.Where(x => x.IsSelected).Select(y => y.RoleName));

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot add selected roles to user");
                return View(model);
            }
            TempData["EditUserSuccess"] = " ";
            return RedirectToAction("EditUser", new { Id = userId });
        }


        public IActionResult Login(string ReturnUrl = null)
        {


            return View(new LoginModel()
            {
                ReturnUrl = ReturnUrl
            });
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {

            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user == null)
            {
                ModelState.AddModelError("", "Böyle bir E-posta adresi bulunamadı");
                return View(model);
            }



            if (!await _userManager.IsEmailConfirmedAsync(user))
            {
                ModelState.AddModelError("", "Lütfen hesabınızı E-posta adresiniz ile onaylayınız");
                return View(model);
            }

            var admins = await _userManager.GetUsersInRoleAsync("admin");
            var coachs = await _userManager.GetUsersInRoleAsync("coach");
            var match = admins.Contains(user);
            var match2 = coachs.Contains(user);

               
                // kullanıcı admin yada coach ise aDMİN PANELİNE GİRİCEK!
                var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);

                if (result.Succeeded)
                {
                    return Redirect(model.ReturnUrl ?? "~/");

                }            

            

            ModelState.AddModelError("", "E-posta adresiniz veya Parolanız yanlış");

            return View(model);

        }



        public async Task<IActionResult> Logout()
        {

            await _signInManager.SignOutAsync();
            return Redirect("~/");
        }
        public IActionResult AccessDenied()
        {
            return RedirectToAction("Login", "Account");
        }




        public IActionResult Register()
        {
            return View(new LoginModel());
        }

        [HttpPost]
        public async Task<IActionResult> Register(LoginModel model, string RoleUserCardId, string NameSurname)
        {
            var EmailDogrulama = "Mail Adresinizi Lütfen Doğrulayınız.";

            var randreferance = new Random().Next(111111, 999999).ToString();

            var users = _userManager.Users.ToList();

            if (users.Where(i => i.Email == model.Email) == null)
            {
                ModelState.AddModelError("", "Böyle bir E-posta adresi bulunmaktadır!");

                return View(model);
            }

            if (users.Where(i => i.UserName == model.UserName) == null)
            {
                ModelState.AddModelError("", "Böyle bir Kullanıcı Adı bulunmaktadır!");

                return View(model);
            }

            if (users.Where(i => i.PhoneNumber == model.PhoneNumber) == null)
            {
                ModelState.AddModelError("", "Böyle bir Numara bulunmaktadır!");

                return View(model);
            }

            for (int i = 0; i < users.Count; i++)
            {
                if (randreferance == users[i].ReferanceNumber)
                {
                    randreferance = new Random().Next(111111, 999999).ToString();
                    i = 0;
                }

            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = new ApplicationUser
            {
                NameSurname = NameSurname,
                UserName = model.UserName,
                Email = model.Email,
                UserProfilePicture = "user.jpg",
                ReferanceNumber = randreferance,
                BirthDate = model.BirthDate,
                PhoneNumber = model.PhoneNumber,
                AdminActivated = "new",
                ContractStatus = "true",
                RegisterDate = DateTime.UtcNow.ToString("yyyy-MM-dd")

            };



            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {

                if (RoleUserCardId == null)
                {
                    RoleUserCardId = "0";
                }

                // generate token
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var callbackUrl = Url.Action("ConfirmEmail", "Account", new
                {

                    userId = user.Id,
                    token = code,
                    RoleUserCardId = RoleUserCardId
                });

                // send mail
                await _emailSender.SendEmailAsync(model.Email, "HESABIMI DOĞRULA", $"{EmailDogrulama}<a href='http://localhost:5000{callbackUrl}'>Hesabımı Doğrula!</a></h2><br>");

                TempData.Put("message", new ResultMessages()
                {
                    Title = "Account Confirmation",
                    Message = "Please check your e-mail and confirm your account",
                    Css = "warning"
                });

                return RedirectToAction("Login", "Account");
            }
            ModelState.AddModelError("", "Bilinmeyen bir hata oluştu lütfen tekrar deneyiniz");
            return View(model);

        }
        public async Task<IActionResult> ConfirmEmail(List<UserRoles> model, string userId, string token, string RoleUserCardId)

        {
            if (userId == null || token == null)
            {
                TempData.Put("message", new ResultMessages()
                {
                    Title = "Account Confirmation",
                    Message = "Your information for account approval is wrong",
                    Css = "danger"
                });
                return Redirect("~/");
            }
            var user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, token);

                if (result.Succeeded)
                {
                    // create cart object
                    _cartService.InitializeCart(user.Id); // emaili doğrulayan herkese bir cart olusturur

                    TempData.Put("message", new ResultMessages()
                    {
                        Title = "Account Confirmation",
                        Message = "Hesabınız başarıyla doğrulandı!",
                        Css = "success"
                    });
                    return RedirectToAction("Login");
                }

            }

            TempData.Put("message", new ResultMessages()
            {
                Title = "Account Confirmation",
                Message = "Hesabınız doğrulanamadı!",
                Css = "danger"
            });

            return View();

        }


        public IActionResult ForgotPassword()
        {
            string username = _userManager.GetUserName(User);
            if (username != "admin")
            {
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string Email)
        {
            var ResetPassword = "Lütfen şifrenizi sıfırlayın";

            if (string.IsNullOrEmpty(Email))
            {
                ModelState.AddModelError("", "Lütfen bir E-posta adresi giriniz");
                return View();
            }
            var user = await _userManager.FindByEmailAsync(Email);

            if (user == null)
            {
                ModelState.AddModelError("", "Böyle bir E-posta adresi bulunamadı");
                return View();
            }

            var code = await _userManager.GeneratePasswordResetTokenAsync(user);
            var callbackUrl = Url.Action("ResetPassword", "Account", new
            {
                token = code
            });
            // send mail
            await _emailSender.SendEmailAsync(Email, "PAROLAMI UNUTTUM", $"{ResetPassword}<a href='http://localhost:5000{callbackUrl}'>Parolamı Sıfırla!</a></h2>");

            ModelState.AddModelError("", "Parolanızı sıfırlamak için E-posta adresinize bir bağlantı gönderildi");

            return View();

        }

        public IActionResult ResetPassword(string token)
        {
            if (token == null)
            {
                return RedirectToAction("ForgotPassword", "Account");
            }
            var model = new ResetPasswordModel { Token = token };
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Parola sıfırlama bağlantınız geçersizdir");
                return View(model);
            }
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                ModelState.AddModelError("", "Böyle bir E-posta adresi bulunamadı");
                return View();
            }
            var result = await _userManager.ResetPasswordAsync(user, model.Token, model.Password);

            if (result.Succeeded)
            {
                return RedirectToAction("Login", "Account");
            }


            return View();
        }



        [HttpPost]
        public async Task<IActionResult> ResetPasswordPro(string Password, string repeat_password, string SelectedUserId)
        {
            if (SelectedUserId != null)
            {

                var userid = SelectedUserId;

                ApplicationUser useremailfind = _userManager.FindByIdAsync(userid).Result;

                if (!ModelState.IsValid)
                {
                    return View(Password);
                }
                var user = await _userManager.FindByEmailAsync(useremailfind.Email);
                if (user == null)
                {
                    ModelState.AddModelError("", "Böyle bir E-posta adresi bulunamadı");
                    return View();
                }
                var code = await _userManager.GeneratePasswordResetTokenAsync(user);
                if (Password == repeat_password)
                {
                    var result = await _userManager.ResetPasswordAsync(user, code, Password);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Login", "Account");
                    }
                }


            }
            else if (SelectedUserId == null)
            {
                var userid = _userManager.GetUserId(HttpContext.User);

                ApplicationUser useremailfind = _userManager.FindByIdAsync(userid).Result;


                if (!ModelState.IsValid)
                {
                    return View(Password);
                }
                var user = await _userManager.FindByEmailAsync(useremailfind.Email);
                if (user == null)
                {
                    ModelState.AddModelError("", "Böyle bir E-posta adresi bulunamadı");
                    return View();
                }
                var code = await _userManager.GeneratePasswordResetTokenAsync(user);
                if (Password == repeat_password)
                {
                    var result = await _userManager.ResetPasswordAsync(user, code, Password);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Login", "Account");
                    }
                }

            }
            TempData["EditUserSuccess"] = " ";
            return View();
        }
    }
}
