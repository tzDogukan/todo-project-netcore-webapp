using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.Entities
{
    public class MyDropBox 
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


    public class MyTask  
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

    public class MyComment 
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


    public class UserNotification 
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

    public class UserAdresList 
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

    public class UserContent
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

    public class UserRegisterFile 
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
