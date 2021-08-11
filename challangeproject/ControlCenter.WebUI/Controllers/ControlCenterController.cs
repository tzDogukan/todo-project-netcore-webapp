using ControlCenter.Identity;
using ControlCenter.WebUI.Models;
using General.Business.Abstrack;
using General.Business.Abstract;
using General.Entities;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System;
using System.Collections.Generic;

using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;


namespace ControlCenter.WebUI.Controllers
{
    [AutoValidateAntiforgeryToken]
    [Authorize]
    public class ControlCenterController : Controller
    {
        private IEmailSender _emailSender;
        private IGeneralUISettingsService _generalUISettingsService;
        private SignInManager<ApplicationUser> _signInManager;
        private UserManager<ApplicationUser> _userManager;
      

        public ControlCenterController(IGeneralUISettingsService generalUISettingsService, UserManager<ApplicationUser> userManager,SignInManager<ApplicationUser> signInManager,  IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _generalUISettingsService = generalUISettingsService;

        }

        /// <summary>
        /// Priorty 1 = NORMAL;
        /// PRIORTY 2 = YÜKSEK ÖNCELİK;
        /// PRIORTY 0 = ÖNEMSİZ;
        /// </summary>
        private void AllBadgeNotification(string userId)
        {
            var importantDos = _generalUISettingsService.GetCustomAll().Where(i => i.userId == userId && i.Priority == "2").Count();
            var complatedDos = _generalUISettingsService.GetCustomAll().Where(i => i.userId == userId && i.Status == "Complated").Count();
            var allDos = _generalUISettingsService.GetCustomAll().Where(i => i.userId == userId).Count();
            ViewData["allDos"] = allDos;
            ViewData["complatedDos"] = complatedDos;
            ViewData["importantDos"] = importantDos;

        }
        public IActionResult Index()
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            if (userId == null || userId == "")
            {
                return NotFound();

            };
            AllBadgeNotification(userId);

            return View(new userTaskModel()
            {
                userTasks = _generalUISettingsService.GetCustomAll().Where(i => (DateTime.Now - i.Date).TotalHours < 24 && i.userId == userId).ToList()
            });
        }
        public IActionResult Importants()
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            if (userId == null || userId == "")
            {
                return NotFound();

            };

            AllBadgeNotification(userId);

            return View(new userTaskModel()
            {
                userTasks = _generalUISettingsService.GetCustomAll().Where(i => i.userId == userId && i.Priority == "2").ToList()
            });
        }
        public IActionResult Complated()
        {
            var userId = _userManager.GetUserId(HttpContext.User);

            AllBadgeNotification(userId);

            return View(new userTaskModel()
            {
                userTasks = _generalUISettingsService.GetCustomAll().Where(i=> i.userId == userId && i.Status == "Complated" ).ToList()
            });
        }
        public IActionResult AllList()
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            if (userId == null || userId == "")
            {
                return NotFound();

            };
            AllBadgeNotification(userId);

            return View(new userTaskModel()
            {
                userTasks = _generalUISettingsService.GetCustomAll().Where(i => i.userId == userId).ToList()
            });
        }
        public IActionResult NewDo()
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            if (userId == null || userId == "")
            {
                return NotFound();

            };
            AllBadgeNotification(userId);

            return View(new userTaskModel());
        }

        public IActionResult EditDo(int? id)
        {
            var userId = _userManager.GetUserId(HttpContext.User);

            if (userId == null || userId == "")
            {
                return NotFound();

            };
            if (id == null)
            {
                return NotFound();
            }
            var entity = _generalUISettingsService.GetById((int)id);
            if (entity == null)
            {
                return NotFound();
            }
            var model = new userTaskModel()
            {
                Date = entity.Date,
                Content = entity.Content,
                Message = entity.Message,
                Priority = entity.Priority,
                Status = entity.Status,
                Subject = entity.Subject,
                userId = entity.userId,
                Id = entity.Id,
                fileUrl = entity.fileUrl

            };
            AllBadgeNotification(userId);

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> NewDoAsync(userTaskModel model, IFormFile file)
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            if (userId == null || userId == "")
            {
                return NotFound();

            };
            var entity = new userTask()
            {
                Date = DateTime.Now,
                Content = model.Content,
                Message = model.Message,
                Priority = model.Priority,
                Status = "Active",
                Subject = model.Subject,
                userId = userId


            };
            if (file != null)
            {
                entity.fileUrl = file.FileName;
                var deletepath1 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\doFiles", file.FileName);
                if (System.IO.File.Exists(deletepath1))
                {
                    System.IO.File.Delete(deletepath1);
                }
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\doFiles", file.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);

                }
            }
            _generalUISettingsService.Create(entity);


            AllBadgeNotification(userId);

            return RedirectToAction("AllList");
        }
        [HttpPost]
        public async Task<IActionResult> EditDoAsync(userTaskModel model, IFormFile file)
        {
            var userId = _userManager.GetUserId(HttpContext.User);

            if (userId == null || userId == "")
            {
                return NotFound();

            };
            var entity = _generalUISettingsService.GetById(model.Id);
            if (entity == null)
            {
                return NotFound();
            }
            if (userId != entity.userId)
            {
                return NotFound();
            }
            entity.Date = model.Date;
            entity.Content = model.Content;
            entity.Message = model.Message;
            entity.Priority = model.Priority;
            entity.Status = model.Status;
            entity.Subject = model.Subject;
            entity.userId = userId;
            entity.fileUrl = model.fileUrl;




            if (file != null)
            {
                entity.fileUrl = file.FileName;
                var deletepath1 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\doFiles", file.FileName);
                if (System.IO.File.Exists(deletepath1))
                {
                    System.IO.File.Delete(deletepath1);
                }
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\doFiles", file.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);

                }
            }
            _generalUISettingsService.Update(entity);


            AllBadgeNotification(userId);

            return RedirectToAction("AllList");
        }
        [HttpPost]
        public IActionResult DeleteDo(int doId)
        {
            var userId = _userManager.GetUserId(HttpContext.User);

            if (userId == null || userId == "")
            {
                return NotFound();

            };
            if (doId == 0)
            {
                return RedirectToAction("AllList");
            }
            var entity = _generalUISettingsService.GetById(doId);
            if (entity.fileUrl != "" || entity.fileUrl != null)
            {
                var path1 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\doFiles", entity.fileUrl);

                if (System.IO.File.Exists(path1))
                {
                    System.IO.File.Delete(path1);
                }
            }
            AllBadgeNotification(userId);

            _generalUISettingsService.Delete(entity);

            return RedirectToAction("AllList");
        }



    }
}
