
using ControlCenter.Identity;
using General.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCenter.WebUI.Models
{

    public class UserFunctionMasterModel // USER E AİT DROPBOX KİŞİSEL 
    {
        public ApplicationUser appUser { get; set; }

        // USER E AİT EDİT OLANLAR 

        public MyDropBox MyDropBox { get; set; }
        public MyTask MyTask { get; set; }
        public MyComment MyComment { get; set; }

        public UserNotification UserNotification { get; set; }
        public UserAdresList UserAdresList { get; set; }
        public UserContent UserContent { get; set; }

        public UserRegisterFile UserRegisterFile { get; set; }


        // USER E AİT LİST OLANLAR


        public List<MyDropBox> MyDropBoxes { get; set; }
        public List<MyTask> MyTasks { get; set; }
        public List<MyComment> MyComments { get; set; }

        public List<UserNotification> UserNotifications { get; set; }
        public List<UserAdresList> UserAdresLists { get; set; }
        public List<UserContent> UserContents { get; set; }

        public List<UserRegisterFile> UserRegisterFiles { get; set; }
    }




    public class MyDropBoxModel // USER E AİT DROPBOX KİŞİSEL 
    {
        public int Id { get; set; }
        public string DropItemName { get; set; }
        public string Date { get; set; }
        public string IpAdress { get; set; }
        public string DropItemFile { get; set; }
        public string DataLimits { get; set; }
        public string ActiveStatus { get; set; }

        public int CreateUserCartId { get; set; }
        public CreateUserCart CreateUserCart { get; set; }


    }

    public class MyTaskModel  // USER E AİT YAPILACAKLAR LİSTESİ" KİŞİSEL AJANDA " "MY TASK LIST"
    {
        public int Id { get; set; }
        public string Task { get; set; }
        public string Color { get; set; }
        public string Date { get; set; }
        public string Status { get; set; }
        public string ActiveStatus { get; set; }
		
	 public int CreateUserCartId { get; set; }
        public CreateUserCart CreateUserCart { get; set; }

    }

    public class MyCommentModel // USER E AİT YORUMLAR
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Comments { get; set; }
        public string BackLink { get; set; }
        public string Img { get; set; }
        public string Star { get; set; }
        public string Date { get; set; }
        public string Status { get; set; }
        public string ActiveStatus { get; set; }

        public int CreateUserCartId { get; set; }
        public CreateUserCart CreateUserCart { get; set; }
    }

    public class UserNotificationModel // USER E AİT BİLDİRİMLER
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public string Date { get; set; }
        public string Subject { get; set; }
        public string Descriptions { get; set; }
        public string Status { get; set; }
        public string ActiveStatus { get; set; }

        public int CreateUserCartId { get; set; }
        public CreateUserCart CreateUserCart { get; set; }
    }

    public class UserAdresListModel // USER E AİT ADRESLER LİSTESİ
    {
        public int Id { get; set; }
        public string AdresTuru { get; set; }
        public string Phone { get; set; }
        public string Adres { get; set; }
        public string Email { get; set; }
        public string Ulke { get; set; }
        public string Sehir { get; set; }
        public string Semt { get; set; }
        public string Mahalle { get; set; }
        public string PostaKodu { get; set; }
        public string AcikAdres { get; set; }
        public string ActiveStatus { get; set; }


        public int CreateUserCartId { get; set; }
        public CreateUserCart CreateUserCart { get; set; }
    }

    public class UserContentModel// USER E AİT ADMİN TARAFINDAN EKLENEN ÖDEV YADA BİLGİ YADA VERİLER OLABİLİR
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Content1 { get; set; }
        public string Content2 { get; set; }
        public string Content3 { get; set; }
        public string Content4 { get; set; }
        public string Content5 { get; set; }
        public string Content6 { get; set; }
        public string Content7 { get; set; }
        public string Content8 { get; set; }
        public string Content9 { get; set; }
        public string Content10 { get; set; }

        public int CreateUserCartId { get; set; }
        public CreateUserCart CreateUserCart { get; set; }
    }

    public class UserRegisterFileModel // USER E AİT kayıt için gönderilicek evraklar
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string File1 { get; set; }
        public string File2 { get; set; }
        public string File3 { get; set; }
        public string File4 { get; set; }
        public string File5 { get; set; }
		
		public int CreateUserCartId { get; set; }
        public CreateUserCart CreateUserCart { get; set; }
    }
}
