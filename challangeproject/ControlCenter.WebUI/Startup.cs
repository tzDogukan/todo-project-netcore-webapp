using ControlCenter.Identity;
using ControlCenter.WebUI.EmailServices;
using General.Business.Abstrack;
using General.Business.Abstract;
using General.Business.Concrete;
using General.DataAccess.Abstrack;
using General.DataAccess.Abstract;
using General.DataAccess.Concrete.EFCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;


namespace ControlCenter.WebUI
{
    public class Startup

    {
        public IConfiguration Configuration { get; set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddRazorPages().AddRazorRuntimeCompilation();

            services.AddDbContext<ApplicationIdentityDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("IdentityConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationIdentityDbContext>()
                .AddDefaultTokenProviders();
            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 7;
                options.Lockout.MaxFailedAccessAttempts = 10;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(90);
                options.Lockout.AllowedForNewUsers = true;
                options.User.RequireUniqueEmail = true;
                options.SignIn.RequireConfirmedEmail = true;
                options.SignIn.RequireConfirmedPhoneNumber = false;
            });

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Account/Login";
                options.LogoutPath = "/Account/Logout";
                options.AccessDeniedPath = "/Account/AccessDenied";
                options.ExpireTimeSpan = TimeSpan.FromMinutes(90);
                options.SlidingExpiration = true;

                options.Cookie = new CookieBuilder
                {
                    HttpOnly = true,
                    Name = ".ControlCenter.WebUI.Security.Cookie",
                    SameSite = SameSiteMode.None,
                    SecurePolicy = CookieSecurePolicy.Always,
                };
               
            });
            services.AddTransient<IEmailSender, EmailSender>();




            //CREATE USER CART
            services.AddScoped<ICreateUserCartDal, EFCoreCreateUserCartDal>();
            services.AddScoped<ICreateUserCartService, CreateUserCartManager>();

            // USER FUNCTIONS

            services.AddScoped<IMyCommentDal, EFCoreMyCommentDal>();
            services.AddScoped<IMyCommentService, MyCommentManager>();

            services.AddScoped<IMyTaskDal, EFCoreMyTaskDal>();
            services.AddScoped<IMyTaskService, MyTaskManager>();

            services.AddScoped<IMyDropBoxDal, EFCoreMyDropBoxDal>();
            services.AddScoped<IMyDropBoxService, MyDropBoxManager>();


            services.AddScoped<IUserAdresListDal, EFCoreUserAdresListDal>();
            services.AddScoped<IUserAdresListService, UserAdresListManager>();

            services.AddScoped<IUserContentDal, EFCoreUserContentDal>();
            services.AddScoped<IUserContentService, UserContentManager>();

            services.AddScoped<IUserNotificationDal, EFCoreUserNotificationDal>();
            services.AddScoped<IUserNotificationService, UserNotificationManager>();

            services.AddScoped<IUserRegisterFileDal, EFCoreUserRegisterFileDal>();
            services.AddScoped<IUserRegisterFileService, UserRegisterFileManager>();



            services.AddScoped<IGeneralUISettingsDal, EFCoreGeneralUISettingsDal>();
            services.AddScoped<IGeneralUISettingsService, GeneralUISettingsManager>();


            // URL ROUTING DEVRE DIÞI BIRAKAN MOPPOIND DÝSABLER KOD
            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            if (env.IsDevelopment())
            {
               app.UseDeveloperExceptionPage();
                GeneralSettingsSeedDatabase.Seed();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseMiddleware<SecurityHeadersMiddleware>();
            app.UseAuthentication();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseHttpsRedirection();
            app.UseStatusCodePagesWithReExecute("/Error/Error", "?code={0}");

            app.UseRouting();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=ControlCenter}/{action=Index}/{id?}"
                );

                ///////////////////////////////ControlCenter MAP ROUTE//////////////////////////////
                routes.MapRoute(
                name: "GeneralSeoSettings",
                template: "GeneralSeoSettings",
                defaults: new { controller = "ControlCenter", action = "GeneralSeoSettings" }
                );
                routes.MapRoute(
                name: "InterfaceSettings",
                template: "InterfaceSettings",
                defaults: new { controller = "ControlCenter", action = "InterfaceSettings" }
                );
                routes.MapRoute(
                name: "GalleryList",
                template: "GalleryList",
                defaults: new { controller = "ControlCenter", action = "GalleryList" }
                );
                routes.MapRoute(
                name: "EditGallery",
                template: "EditGallery/{Id?}",
                defaults: new { controller = "ControlCenter", action = "EditGallery" }
                );
                routes.MapRoute(
                name: "MainSliderList",
                template: "MainSliderList",
                defaults: new { controller = "ControlCenter", action = "MainSliderList" }
                );
                routes.MapRoute(
                name: "EditMainSlider",
                template: "EditMainSlider/{Id?}",
                defaults: new { controller = "ControlCenter", action = "EditMainSlider" }
                );
                routes.MapRoute(
                name: "CustomSliderList",
                template: "CustomSliderList",
                defaults: new { controller = "ControlCenter", action = "CustomSliderList" }
                );
                routes.MapRoute(
                name: "EditCustomSlider",
                template: "EditCustomSlider/{Id?}",
                defaults: new { controller = "ControlCenter", action = "EditCustomSlider" }
                );
                routes.MapRoute(
                name: "FileExplorer",
                template: "FileExplorer",
                defaults: new { controller = "ControlCenter", action = "FileExplorer" }
                );
                routes.MapRoute(
                name: "EditFileExplorer",
                template: "EditFileExplorer/{Id?}",
                defaults: new { controller = "ControlCenter", action = "EditFileExplorer" }
                );                
                routes.MapRoute(
                name: "PopUpList",
                template: "PopUpList/{LocalUrl?}",
                defaults: new { controller = "ControlCenter", action = "PopUpList" }
                );
                routes.MapRoute(
                name: "EditPopUp",
                template: "EditPopUp/{Id?}",
                defaults: new { controller = "ControlCenter", action = "EditPopUp" }
                );
                routes.MapRoute(
                name: "LandingPageList",
                template: "LandingPageList",
                defaults: new { controller = "ControlCenter", action = "LandingPageList" }
                );
                routes.MapRoute(
                name: "EditLandingPage",
                template: "EditLandingPage/{Id?}",
                defaults: new { controller = "ControlCenter", action = "EditLandingPage" }
                );
                routes.MapRoute(
                name: "MailTemplateList",
                template: "MailTemplateList",
                defaults: new { controller = "ControlCenter", action = "MailTemplateList" }
                );
                routes.MapRoute(
                name: "ContractList",
                template: "ContractList",
                defaults: new { controller = "ControlCenter", action = "ContractList" }
                );
                routes.MapRoute(
                name: "Documentary",
                template: "Documentary",
                defaults: new { controller = "ControlCenter", action = "Documentary" }
                );
                routes.MapRoute(
                name: "WpBulkMessage",
                template: "WpBulkMessage",
                defaults: new { controller = "ControlCenter", action = "WpBulkMessage" }
                );
                routes.MapRoute(
                name: "MailCreator",
                template: "MailCreator",
                defaults: new { controller = "ControlCenter", action = "MailCreator" }
                );
                routes.MapRoute(
                name: "MailDesigner",
                template: "MailDesigner",
                defaults: new { controller = "ControlCenter", action = "MailDesigner" }
                );
                routes.MapRoute(
                name: "EditMailDesigner",
                template: "EditMailDesigner/{Id?}",
                defaults: new { controller = "ControlCenter", action = "EditMailDesigner" }
                );
                routes.MapRoute(
                name: "MailSender",
                template: "MailSender/{Id?}",
                defaults: new { controller = "ControlCenter", action = "MailSender" }
                );
                routes.MapRoute(
                name: "SubscribeList",
                template: "SubscribeList",
                defaults: new { controller = "ControlCenter", action = "SubscribeList" }
                );
                routes.MapRoute(
                name: "ContactUsList",
                template: "ContactUsList",
                defaults: new { controller = "ControlCenter", action = "ContactUsList" }
                );
                routes.MapRoute(
                name: "EditContactUs",
                template: "EditContactUs/{Id?}",
                defaults: new { controller = "ControlCenter", action = "EditContactUs" }
                );        
                routes.MapRoute(
                name: "SSSList",
                template: "SSSList",
                defaults: new { controller = "ControlCenter", action = "SSSList" }
                );
                routes.MapRoute(
                name: "EditSSS",
                template: "EditSSS/{Id?}",
                defaults: new { controller = "ControlCenter", action = "EditSSS" }
                );
                routes.MapRoute(
                name: "DynamicContentList",
                template: "DynamicContentList",
                defaults: new { controller = "ControlCenter", action = "DynamicContentList" }
                );
                routes.MapRoute(
                name: "EditDynamicContent",
                template: "EditDynamicContent/{Id?}",
                defaults: new { controller = "ControlCenter", action = "EditDynamicContent" }
                );

                ///////////////////////////////BLOG MAP ROUTE//////////////////////////////
                routes.MapRoute(
                name: "CreateBlog",
                template: "CreateBlog",
                defaults: new { controller = "Blog", action = "CreateBlog" }
                );
                routes.MapRoute(
                name: "BlogList",
                template: "BlogList",
                defaults: new { controller = "Blog", action = "BlogList" }
                );
                routes.MapRoute(
                name: "EditBlog",
                template: "EditBlog/{Id?}/{BlogSeoUrl?}",
                defaults: new { controller = "Blog", action = "EditBlog" }
                );
                routes.MapRoute(
                name: "CreateBlogCategory",
                template: "CreateBlogCategory",
                defaults: new { controller = "Blog", action = "CreateBlogCategory" }
                );
                routes.MapRoute(
                name: "EditBlogCategory",
                template: "EditBlogCategory/{Id?}",
                defaults: new { controller = "Blog", action = "EditBlogCategory" }
                );
                ///////////////////////////////NOTICE MAP ROUTE//////////////////////////////
                routes.MapRoute(
                name: "CreateNotice",
                template: "CreateNotice",
                defaults: new { controller = "Notice", action = "CreateNotice" }
                );
                routes.MapRoute(
                name: "NoticeList",
                template: "NoticeList",
                defaults: new { controller = "Notice", action = "NoticeList" }
                );
                routes.MapRoute(
                name: "EditNotice",
                template: "EditNotice/{Id?}/{NoticeSeoUrl?}",
                defaults: new { controller = "Notice", action = "EditNotice" }
                );
                routes.MapRoute(
                name: "CreateNoticeCategory",
                template: "CreateNoticeCategory",
                defaults: new { controller = "Notice", action = "CreateNoticeCategory" }
                );
                routes.MapRoute(
                name: "EditNoticeCategory",
                template: "EditNoticeCategory/{Id?}",
                defaults: new { controller = "Notice", action = "EditNoticeCategory" }
                );
                ///////////////////////////////ACCOUNTS MAP ROUTE//////////////////////////////
                routes.MapRoute(
                name: "MyProfile",
                template: "MyProfile",
                 defaults: new { controller = "Account", action = "MyProfile" }
                );
                routes.MapRoute(
                name: "Login",
                template: "Login",
                defaults: new { controller = "Account", action = "Login" }
                 );
                routes.MapRoute(
                name: "Register",
                template: "Register",
                defaults: new { controller = "Account", action = "Register" }
                );
                routes.MapRoute(
                name: "ForgotPassword",
                template: "ForgotPassword",
                defaults: new { controller = "Account", action = "ForgotPassword" }
                );
                 routes.MapRoute(
                name: "ResetPassword",
                template: "ResetPassword",
                defaults: new { controller = "Account", action = "ResetPassword" }
                );
                routes.MapRoute(
                name: "CreateRole",
                template: "CreateRole",
                defaults: new { controller = "Account", action = "CreateRole" }
                );
                routes.MapRoute(
                name: "EditUser",
                template: "EditUser/{Id?}",
                defaults: new { controller = "Account", action = "EditUser" }
                );
                routes.MapRoute(
                name: "NewUsersList",
                template: "NewUsersList",
                defaults: new { controller = "Account", action = "NewUsersList" }
                );
                routes.MapRoute(
                name: "UsersList",
                template: "UsersList",
                defaults: new { controller = "Account", action = "UsersList" }
                );
                routes.MapRoute(
                name: "WaitingUsersList",
                template: "WaitingUsersList",
                defaults: new { controller = "Account", action = "WaitingUsersList" }
                );
                routes.MapRoute(
                name: "UnSubscribe",
                template: "UnSubscribe",
                defaults: new { controller = "Account", action = "UnSubscribe" }
                );
                //////////////////UserFunctions MAP ROUTE//////////////////////////////

                routes.MapRoute(
                name: "UserDashboard",
                template: "UserDashboard/{Id?}",
                defaults: new { controller = "UserFunctions", action = "UserDashboard" }
                );
                routes.MapRoute(
                name: "EditUserRegisterFile",
                template: "EditUserRegisterFile/{Id?}",
                defaults: new { controller = "UserFunctions", action = "EditUserRegisterFile" }
                );
                routes.MapRoute(
                name: "EditUserContent",
                template: "EditUserContent/{Id?}",
                defaults: new { controller = "UserFunctions", action = "EditUserContent" }
                );
                routes.MapRoute(
                name: "EditUserAdresList",
                template: "EditUserAdresList/{Id?}",
                defaults: new { controller = "UserFunctions", action = "EditUserAdresList" }
                );


            });

            SeedIdentity.Seed(userManager, roleManager, Configuration).Wait();

        }
    }
}
