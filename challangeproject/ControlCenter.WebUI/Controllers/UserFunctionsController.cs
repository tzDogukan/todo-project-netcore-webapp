using ControlCenter.Identity;
using ControlCenter.WebUI.Models;
using ControlCenter.WebUI.SeoUrlHelper;
using General.Business.Abstrack;
using General.Business.Abstract;
using General.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ControlCenter.WebUI.Controllers
{
    [AutoValidateAntiforgeryToken]
    [Authorize]

    public class UserFunctionsController : Controller
    {
        private SignInManager<ApplicationUser> _signInManager;
        private UserManager<ApplicationUser> _userManager;
        private IEmailSender _emailSender;
        private RoleManager<IdentityRole> _roleManager;
        private ICreateUserCartService _cartService;
        private IMyCommentService _myCommentService;
        private IMyTaskService _myTaskService;
        private IMyDropBoxService _myDropBoxService;
        private IUserAdresListService _userAdresListService;
        private IUserContentService _userContentService;
        private IUserNotificationService _userNotificationService;
        private IUserRegisterFileService _userRegisterFileService;




        public UserFunctionsController(UserManager<ApplicationUser> userManager,  SignInManager<ApplicationUser> signInManager, IMyCommentService myCommentService, IUserAdresListService userAdresListService, IMyDropBoxService myDropBoxService, IMyTaskService myTaskService, IUserContentService userContentService, IUserNotificationService userNotificationService, IUserRegisterFileService userRegisterFileService, ICreateUserCartService cartService, IEmailSender emailSender, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _roleManager = roleManager;
            _cartService = cartService;
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

        public async Task<IActionResult> UserDashboard(string Id)
        {
            AllBadgeNotification();

            // OTURUM AÇAN KİŞİNİN CART ID SİNİ BULAN KOD!    
            var LoginUserCartId = _cartService.GetCartByUserId(_userManager.GetUserId(HttpContext.User));
            var user = await _userManager.FindByIdAsync(_userManager.GetUserId(HttpContext.User));

            if (Id != null && Id != "")
                {
                LoginUserCartId = _cartService.GetCartByUserId(Id);

                user = await _userManager.FindByIdAsync(Id);
            };

            return View(new UserFunctionMasterModel()
            {
                appUser = user,

            // USER E AİT KİSİSEL TABLOLARI CEKİYORUZ. OTURUM AÇAN KİŞİNİN ID SİNDEN KARTINA AİT İ BULUP ORADAN FİLTRELİYORUZ.

            MyDropBoxes = _myDropBoxService.GetCustomAll().Where(i => i.CreateUserCartId == LoginUserCartId.Id).ToList(),

                //Dışarıdan - MAİLLE YADA SİSTEM TARAFINDAN YAZILAN BİR YORUM ÖNCE ADMİNE DÜŞÜCEK!
                MyComments = _myCommentService.GetCustomAll().Where(i => i.CreateUserCartId == LoginUserCartId.Id).ToList(),

                // KİŞİSEL - USERE AİT - GÖREV LİSTESİ ADMİN ROLE DE GÖREV VEREBİLİCEK - ÖDEV KULLANICI KENDİDE OLUSTURABİLİCEK AJANDA GİBİ
                MyTasks = _myTaskService.GetCustomAll().Where(i => i.CreateUserCartId == LoginUserCartId.Id).ToList(),

                // TRENDYOL GİBİ BİR USERE İAT HAZIR ADRES KARTLARI OLUSTURULACAK
                UserAdresLists = _userAdresListService.GetCustomAll().Where(i => i.CreateUserCartId == LoginUserCartId.Id).ToList(),

                // USERLERE BİLDİİRM GÖNDERİLİCEK ALAN - ROLE GÖRE TOPLU YADA TEKLİ BİLDİRİM YOLLANICAK
                UserNotifications = _userNotificationService.GetCustomAll().Where(i => i.CreateUserCartId == LoginUserCartId.Id).ToList(),


                // bir kullanıcıdan istenen dolu belgeleri admin bu kullanıcının dosya listesine yüklicek yada kullanıcı yüklicek.
                UserRegisterFiles = _userRegisterFileService.GetCustomAll().Where(i => i.CreateUserCartId == LoginUserCartId.Id).ToList(),

                // EĞİTMEN YADA USER İÇİN KİŞİSEL VERİ ALANI PROFİL OLUR İNFORMATINS OLUR VERİLEN ÖDEV OLUR CARTID YE GÖRE DOLDURULUCAK.
                UserContents = _userContentService.GetCustomAll().Where(i => i.CreateUserCartId == LoginUserCartId.Id).ToList(),


                /*MyDropBoxes = _myDropBoxService.GetCustomAll().OrderByDescending(i => i.CreateUserCartId == LoginUserCartId.Id).Take(15).ToList(), // LAST 15*/

            });
        }


        [HttpPost]
        public async Task<IActionResult> CreateUserRegisterFile(IFormFile file1, IFormFile file2, IFormFile file3, IFormFile file4, string Id)
        {
            var usrcartid = 0;
            // OTURUM AÇAN KİŞİNİN CART ID SİNİ BULAN KOD!    
            var UserCartId = _cartService.GetCartByUserId(_userManager.GetUserId(HttpContext.User));




            if (Id != null && Id != "")
            {
                UserCartId = _cartService.GetCartByUserId(Id);
            };


            if (file1 != null)
            {
                if (UserCartId != null)
                {
                    usrcartid = UserCartId.Id;
                }
                else if (UserCartId == null)
                {
                    usrcartid = 1;
                }

                var usernamefind = _userManager.FindByIdAsync(UserCartId.UserId).Result;

                var username = usernamefind.NormalizedUserName;

                var entity = new UserRegisterFile();
                {

                    entity.Date = DateTime.UtcNow.ToString("yyyy-MM-dd");
                    entity.CreateUserCartId = usrcartid;
                    if (file1 != null)
                    {
                        var filename1 = SeoUrlHelperMethod.SeoUrlHelpers(username) + Guid.NewGuid().ToString() + Path.GetExtension(file1.FileName);
                        entity.File1 = filename1;
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwportal\\file\\registerfile", filename1);
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await file1.CopyToAsync(stream);
                        }
                    }
                    else
                    {
                        entity.File1 = "default.pdf";
                    }
                    if (file2 != null)
                    {
                        var filename2 = SeoUrlHelperMethod.SeoUrlHelpers(username) + Guid.NewGuid().ToString() + Path.GetExtension(file2.FileName);
                        entity.File2 = filename2;
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwportal\\file\\registerfile", filename2);
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await file2.CopyToAsync(stream);
                        }
                    }
                    else
                    {
                        entity.File2 = "default.pdf";
                    }
                    if (file3 != null)
                    {
                        var filename3 = SeoUrlHelperMethod.SeoUrlHelpers(username) + Guid.NewGuid().ToString() + Path.GetExtension(file3.FileName);
                        entity.File3 = filename3;
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwportal\\file\\registerfile", filename3);
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await file3.CopyToAsync(stream);
                        }
                    }
                    else
                    {
                        entity.File3 = "default.pdf";
                    }
                    if (file2 != null)
                    {
                        var filename4 = SeoUrlHelperMethod.SeoUrlHelpers(username) + Guid.NewGuid().ToString() + Path.GetExtension(file4.FileName);
                        entity.File4 = filename4;
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwportal\\file\\registerfile", filename4);
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await file4.CopyToAsync(stream);
                        }
                    }
                    else
                    {
                        entity.File4 = "default.pdf";
                    }


                };
                _userRegisterFileService.Create(entity);

                _userRegisterFileService.Update(entity);

                if(Id != null)
                { 
                if (Id != null && Id != "")
                {
                    var user = await _userManager.FindByIdAsync(Id);
                if (user == null)
                {
                    return RedirectToAction("Index", "ControlCenter"); // CONTROLLER HOME OLUCAK!
                }

                user.AdminActivated = "waiting";
                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    TempData["UserRegisterFileSuccess"] = " ";
                    return RedirectToAction("UserDashboard");
                }
                    }
                }
                TempData["UserRegisterFileSuccess"] = " ";
                return RedirectToAction("UserDashboard");
            }
            return View();
        }

        public IActionResult EditUserRegisterFile(int? id)
        {
            AllBadgeNotification();
            if (id == null)
            {
                return NotFound();
            }
            var entity = _userRegisterFileService.GetById((int)id);
            if (entity == null)
            {
                return NotFound();
            }
            var model = new UserRegisterFileModel()
            {
                Id = entity.Id,
                File1 = entity.File1,
                File2 = entity.File2,
                File3 = entity.File3,
                File4 = entity.File4,
                Date = entity.Date,
                CreateUserCartId = entity.CreateUserCartId,

            };

            return View(model);
        }

        [HttpPost]
        [RequestFormLimits(MultipartBodyLengthLimit = 209715200)]
        public async Task<IActionResult> EditUserRegisterFile(UserRegisterFileModel model, IFormFile file1, IFormFile file2, IFormFile file3, IFormFile file4)
        {

            var entity = _userRegisterFileService.GetById(model.Id);
            if (entity == null)
            {
                return NotFound();
            }
            entity.Date = DateTime.UtcNow.ToString("yyyy-MM-dd");
            if (file1 != null)
            {
                string File1 = entity.File1;
                var deletepath1 = Path.Combine(Directory.GetCurrentDirectory(), "wwwportal\\file\\registerfile", File1);
                if (System.IO.File.Exists(deletepath1))
                {
                    System.IO.File.Delete(deletepath1);
                }


                var filename1 = File1 + Path.GetExtension(file1.FileName);
                entity.File1 = filename1;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwportal\\file\\registerfile", filename1);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file1.CopyToAsync(stream);
                }


            }
            if (file2 != null)
            {
                string File2 = entity.File2;
                var deletepath2 = Path.Combine(Directory.GetCurrentDirectory(), "wwwportal\\file\\registerfile", File2);
                if (System.IO.File.Exists(deletepath2))
                {
                    System.IO.File.Delete(deletepath2);
                }
                var filename2 = File2 + Path.GetExtension(file2.FileName);
                entity.File2 = filename2;
                var path2 = Path.Combine(Directory.GetCurrentDirectory(), "wwwportal\\file\\registerfile", filename2);
                using (var stream = new FileStream(path2, FileMode.Create))
                {
                    await file2.CopyToAsync(stream);
                }

            }
            if (file3 != null)
            {
                string File3 = entity.File3;
                var deletepath3 = Path.Combine(Directory.GetCurrentDirectory(), "wwwportal\\file\\registerfile", File3);
                if (System.IO.File.Exists(deletepath3))
                {
                    System.IO.File.Delete(deletepath3);
                }
                var filename3 = File3 + Path.GetExtension(file3.FileName);
                entity.File3 = filename3;
                var path3 = Path.Combine(Directory.GetCurrentDirectory(), "wwwportal\\file\\registerfile", filename3);
                using (var stream = new FileStream(path3, FileMode.Create))
                {
                    await file3.CopyToAsync(stream);
                }

            }
            if (file4 != null)
            {
                string File4 = entity.File4;
                var deletepath4 = Path.Combine(Directory.GetCurrentDirectory(), "wwwportal\\file\\registerfile", File4);
                if (System.IO.File.Exists(deletepath4))
                {
                    System.IO.File.Delete(deletepath4);
                }
                var filename4 = File4 + Path.GetExtension(file4.FileName);
                entity.File4 = filename4;
                var path4 = Path.Combine(Directory.GetCurrentDirectory(), "wwwportal\\file\\registerfile", filename4);
                using (var stream = new FileStream(path4, FileMode.Create))
                {
                    await file4.CopyToAsync(stream);
                }
            }

            _userRegisterFileService.Update(entity);
            TempData["UserRegisterFileSuccess"] = " ";
            return RedirectToAction("UserDashboard");
        }

        [HttpPost]
        public IActionResult DeleteUserRegisterFile(int[] Id)
        {
            if (Id.Length == 0)
            {
                TempData["UserRegisterFileSuccess"] = " ";
                return RedirectToAction("UserDashboard");
            }
            foreach (var Model in Id)
            {

                var entity = _userRegisterFileService.GetById(Model);
                _userRegisterFileService.Delete(entity);


                string File1 = entity.File1;
                string File2 = entity.File2;
                string File3 = entity.File3;
                string File4 = entity.File4;
                var path1 = Path.Combine(Directory.GetCurrentDirectory(), "wwwportal\\file\\registerfile", File1);
                var path2 = Path.Combine(Directory.GetCurrentDirectory(), "wwwportal\\file\\registerfile", File2);
                var path3 = Path.Combine(Directory.GetCurrentDirectory(), "wwwportal\\file\\registerfile", File3);
                var path4 = Path.Combine(Directory.GetCurrentDirectory(), "wwwportal\\file\\registerfile", File4);
                if (System.IO.File.Exists(path1))
                {
                    System.IO.File.Delete(path1);
                }
                if (System.IO.File.Exists(path2))
                {
                    System.IO.File.Delete(path2);
                }
                if (System.IO.File.Exists(path3))
                {
                    System.IO.File.Delete(path3);
                }
                if (System.IO.File.Exists(path4))
                {
                    System.IO.File.Delete(path4);
                }


            }

            TempData["UserRegisterFileSuccess"] = " ";
            return RedirectToAction("UserDashboard");
        }


        [HttpPost]
        public IActionResult CreateUserContent(string Id, string Content2, string Content3, string Content4, string Content5, string Content6, string Content7, string Content8, string Content9, string Content10)
        {
            var usrcartid = 0;
            // OTURUM AÇAN KİŞİNİN CART ID SİNİ BULAN KOD!    
            var UserCartId = _cartService.GetCartByUserId(_userManager.GetUserId(HttpContext.User));

            var finuserpictures = _userManager.GetUserAsync(HttpContext.User);

            var findprofilepic = finuserpictures.Result.UserProfilePicture;


            if (Id != null && Id != "")
            {
                finuserpictures = _userManager.GetUserAsync(HttpContext.User);
                findprofilepic = finuserpictures.Result.UserProfilePicture;
            };



            if (Id != null && Id != "")
            {
                UserCartId = _cartService.GetCartByUserId(Id);
            };


            if (Id != null)
            {
                if (UserCartId != null)
                {
                    usrcartid = UserCartId.Id;
                }
                else if (UserCartId == null)
                {
                    usrcartid = 1;
                }

                var entity = new UserContent();
                {

                    entity.Date = DateTime.UtcNow.ToString("yyyy-MM-dd");
                    entity.CreateUserCartId = usrcartid;
                    entity.Content1 = findprofilepic;
                    entity.Content2 = Content2;
                    entity.Content3 = Content3;
                    entity.Content4 = Content4;
                    entity.Content5 = Content5;
                    entity.Content6 = Content6;
                    entity.Content7 = Content7;
                    entity.Content8 = Content8;
                    entity.Content9 = Content9;
                    entity.Content10 = Content10;


                };
                _userContentService.Create(entity);

                _userContentService.Update(entity);

                TempData["UserContentSuccess"] = " ";
                return RedirectToAction("UserDashboard");
            }
            return View();
        }


        public IActionResult EditUserContent(int? id)
        {
            AllBadgeNotification();
            if (id == null)
            {
                return NotFound();
            }
            var entity = _userContentService.GetById((int)id);
            if (entity == null)
            {
                return NotFound();
            }
            var model = new UserContentModel()
            {
                Id = entity.Id,
                Content1 = entity.Content1,
                Content2 = entity.Content2,
                Content3 = entity.Content3,
                Content4 = entity.Content4,
                Content5 = entity.Content5,
                Content6 = entity.Content6,
                Content7 = entity.Content7,
                Content8 = entity.Content8,
                Content9 = entity.Content9,
                Content10 = entity.Content10,
                Date = entity.Date,
                CreateUserCartId = entity.CreateUserCartId,

            };

            return View(model);
        }

        [HttpPost]
        public IActionResult EditUserContent(UserContentModel model)
        {

            var entity = _userContentService.GetById(model.Id);
            if (entity == null)
            {
                return NotFound();
            }
            entity.Date = DateTime.UtcNow.ToString("yyyy-MM-dd");
            entity.Content2 = model.Content2;
            entity.Content3 = model.Content3;
            entity.Content4 = model.Content4;
            entity.Content5 = model.Content5;
            entity.Content6 = model.Content6;
            entity.Content7 = model.Content7;
            entity.Content8 = model.Content8;
            entity.Content9 = model.Content9;
            entity.Content10 = model.Content10;

            _userContentService.Update(entity);
            TempData["UserContentSuccess"] = " ";
            return RedirectToAction("UserDashboard");
        }



        [HttpPost]
        public IActionResult DeleteUserContent(int[] Id)
        {
            if (Id.Length == 0)
            {
                TempData["UserContentSuccess"] = " ";
                return RedirectToAction("UserDashboard");
            }
            foreach (var Model in Id)
            {

                var entity = _userContentService.GetById(Model);
                _userContentService.Delete(entity);
            }

            TempData["UserContentSuccess"] = " ";
            return RedirectToAction("UserDashboard");
        }



        [HttpPost]
        public IActionResult CreateUserAdresList(string Id, string AdresTuru, string Phone, string Adres, string Email, string Ulke, string Sehir, string Semt, string Mahalle, string PostaKodu, string AcikAdres, string ActiveStatus)
        {
            var usrcartid = 0;
            // OTURUM AÇAN KİŞİNİN CART ID SİNİ BULAN KOD!    
            var UserCartId = _cartService.GetCartByUserId(_userManager.GetUserId(HttpContext.User));

            var finuserpictures = _userManager.GetUserAsync(HttpContext.User);

            var findprofilepic = finuserpictures.Result.UserProfilePicture;


            if (Id != null && Id != "")
            {
                finuserpictures = _userManager.GetUserAsync(HttpContext.User);
                findprofilepic = finuserpictures.Result.UserProfilePicture;
            };



            if (Id != null && Id != "")
            {
                UserCartId = _cartService.GetCartByUserId(Id);
            };


            if (Id != null)
            {
                if (UserCartId != null)
                {
                    usrcartid = UserCartId.Id;
                }
                else if (UserCartId == null)
                {
                    usrcartid = 1;
                }

                var entity = new UserAdresList();
                {
                    entity.CreateUserCartId = usrcartid;
                    entity.AdresTuru = AdresTuru;
                    entity.Phone = Phone;
                    entity.Adres = Adres;
                    entity.Email = Email;
                    entity.Ulke = Ulke;
                    entity.Sehir = Sehir;
                    entity.Semt = Semt;
                    entity.Mahalle = Mahalle;
                    entity.PostaKodu = PostaKodu;
                    entity.AcikAdres = AcikAdres;
                    entity.ActiveStatus = ActiveStatus;


                };
                _userAdresListService.Create(entity);

                _userAdresListService.Update(entity);

                TempData["UserContentSuccess"] = " ";
                return RedirectToAction("UserDashboard");
            }
            return View();
        }


        public IActionResult EditUserAdresList(int? id)
        {
            AllBadgeNotification();
            if (id == null)
            {
                return NotFound();
            }
            var entity = _userAdresListService.GetById((int)id);
            if (entity == null)
            {
                return NotFound();
            }
            var model = new UserAdresListModel()
            {
                Id = entity.Id,
                AdresTuru = entity.AdresTuru,
                Phone = entity.Phone,
                Adres = entity.Adres,
                Email = entity.Email,
                Ulke = entity.Ulke,
                Sehir = entity.Sehir,
                Semt = entity.Semt,
                Mahalle = entity.Mahalle,
                PostaKodu = entity.PostaKodu,
                AcikAdres = entity.AcikAdres,
                ActiveStatus = entity.ActiveStatus,
                CreateUserCartId = entity.CreateUserCartId,

            };

            return View(model);
        }

        [HttpPost]
        public IActionResult EditUserAdresList(UserAdresListModel model)
        {

            var entity = _userAdresListService.GetById(model.Id);
            if (entity == null)
            {
                return NotFound();
            }
            entity.AdresTuru = model.AdresTuru;
            entity.Phone = model.Phone;
            entity.Adres = model.Adres;
            entity.Email = model.Email;
            entity.Ulke = model.Ulke;
            entity.Sehir = model.Sehir;
            entity.Semt = model.Semt;
            entity.Mahalle = model.Mahalle;
            entity.PostaKodu = model.PostaKodu;
            entity.AcikAdres = model.AcikAdres;
            entity.ActiveStatus = model.ActiveStatus;

            _userAdresListService.Update(entity);
            TempData["UserContentSuccess"] = " ";
            return RedirectToAction("UserDashboard");
        }



        [HttpPost]
        public IActionResult DeleteUserAdresList(int[] Id)
        {
            if (Id.Length == 0)
            {
                TempData["UserContentSuccess"] = " ";
                return RedirectToAction("UserDashboard");
            }
            foreach (var Model in Id)
            {

                var entity = _userAdresListService.GetById(Model);
                _userAdresListService.Delete(entity);
            }

            TempData["UserContentSuccess"] = " ";
            return RedirectToAction("UserDashboard");
        }


    }
}
