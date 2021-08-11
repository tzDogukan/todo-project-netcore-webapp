using General.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlCenter.WebUI.Models
{
    public class MyClassesMasterModel
    {
        // SYSTEM PAYMENTS

        //EDİT İÇİN KULLANILAN



        //LİST OLARAK ÇEKİLEN 


        // ROLE PAYMENTS

        //EDİT İÇİN KULLANILAN



        //LİST OLARAK ÇEKİLEN 

    }


    // User Ödeme Ekranına gidince çekilecek ücret == TotalPaid olucak ve user öderse userin == pay kısmı
    // bu ücreti alıcak currency kısmı da aynı olucak ve status true olucak sayfa sonunda
    // 1 aY SONUNDA ADMİNE 
    public class SystemPaymentModel  //Bu Metot 1 Kez Oluşucak Ancak Güncellenebilicek Hoca Tarafından bu sayede loginlerde statü kontrolü yapılacak.
    {
        public int Id { get; set; }
        public string Status { get; set; } // Free sınıftaysa hep Active - Diğer Paketlerde DeActive
        public string Date { get; set; } // Ödeme yapılan tarih otomatik çekicek.
        public string Pay { get; set; } // Ödeme Yapılan Miktar. == Sınıf totalpaid ine eşit ise statü Active Olcuak.
        public string PaymentCurrency { get; set; } // Hangi sınıfa ait ise o sınıfın currency si olucak 
        public int CreateUserCartId { get; set; } // User e ait cardId
        public CreateUserCart CreateUserCart { get; set; }

    }


    // Ödeme Ekranındaki metot true dönerse bunlarıda aynı stringlerle history olarak doldurucak usere ait

    // Bu sayede user ödeme geçmişine göz atabilicek.
    public class SystemPaymentHistoryModel // Her ay başarılı ödeme sonrası log olarak tutulacak.
    {
        public int Id { get; set; }
        public string Date { get; set; } // Ödeme yapılan tarih otomatik çekicek.
        public string Pay { get; set; } // Ödeme Yapılan Miktar. == Sınıf totalpaid ine eşit ise statü Active Olcuak.
        public string PaymentCurrency { get; set; } // Hangi sınıfa ait ise o sınıfın currency si olucak 
        public int CreateUserCartId { get; set; } // User e ait cardId
        public CreateUserCart CreateUserCart { get; set; }
    }

    public class SystemPaymentClassModel // ADMİNLER NORMAL USERLER İÇİN BU SINIF LİSTESİNİ OLUŞTURUCAK.
    {
        public int Id { get; set; }
        public string SystemClassName { get; set; } // free user - 1 aylık üye - 3 aylık üye vs
        public string SystemClassCurrency { get; set; } // tr- usd- bitcoin - vb
        public string SystemClassTıme { get; set; } // Kaç Aylık Üye olduğunu belirten paket " Örnek = 1 Aylık ise 1 yazıcak ve 1 ay sonunda yani 30 gün sonunda admine mail yada notification vs düşürücek 1 aylık üyeliklerin ödemeleri doldu diye ve üyelikleri deaktif edicek
        public string TotalPaid { get; set; } // Free üye = 0 - 1 aylık = 150 vb
        public string DefaultKey { get; set; } // ilk üye direk bu keye ait tabloya dahil olsun örnek // FREE USER LİST

    }

    public class SystemPaymentClassWithSystemPaymentModel // ÖDEMENİN VE SINIFIN OLDUĞU ORTAK TABLO
    {
        public int Id { get; set; }
        public int SystemPaymentClassId { get; set; }
        public int SystemPaymentId { get; set; }

    }




    public class RolePaymentModel // Bu Metot 1 Kez Oluşucak Ancak Güncellenebilicek Hoca Tarafından bu sayede loginlerde statü kontrolü yapılacak.
    {
        public int Id { get; set; }
        public string RoleStatus { get; set; } // Free sınıftaysa hep Active - Diğer Paketlerde DeActive
        public string RoleDate { get; set; } // Ödeme yapılan tarih otomatik çekicek.
        public string RolePay { get; set; } // Ödeme Yapılan Miktar. == Sınıf totalpaid ine eşit ise statü Active Olcuak.
        public string RolePaymentCurrency { get; set; } // Hangi sınıfa ait ise o sınıfın currency si olucak 
        public int CreateUserCartId { get; set; } // User e ait cardId
        public CreateUserCart CreateUserCart { get; set; }

    }


    // Ödeme Ekranındaki metot true dönerse bunlarıda aynı stringlerle history olarak doldurucak usere ait

    // Bu sayede user ödeme geçmişine göz atabilicek.
    public class RolePaymentHistoryModel // Her ay başarılı ödeme sonrası log olarak tutulacak.
    {
        public int Id { get; set; }
        public string RoleDate { get; set; } // Ödeme yapılan tarih otomatik çekicek.
        public string RolePay { get; set; } // Ödeme Yapılan Miktar. == Sınıf totalpaid ine eşit ise statü Active Olcuak.
        public string RolePaymentCurrency { get; set; } // Hangi sınıfa ait ise o sınıfın currency si olucak 
        public int CreateUserCartId { get; set; } // User e ait cardId
        public CreateUserCart CreateUserCart { get; set; }
    }

    public class RolePaymentClassModel // Eğitmenler  Öğrenci USERLER İÇİN BU SINIF LİSTESİNİ OLUŞTURUCAK.
    {
        public int Id { get; set; }
        public string RoleClassName { get; set; } // free user - 1 aylık üye - 3 aylık üye vs
        public string RoleClassCurrency { get; set; } // tr- usd- bitcoin - vb
        public string RoleClassTıme { get; set; } // Kaç Aylık Üye olduğunu belirten paket " Örnek = 1 Aylık ise 1 yazıcak ve 1 ay sonunda yani 30 gün sonunda admine mail yada notification vs düşürücek 1 aylık üyeliklerin ödemeleri doldu diye ve üyelikleri deaktif edicek
        public string TotalPaid { get; set; } // Free üye = 0 - 1 aylık = 150 vb
        public int CreateUserCartId { get; set; } // Eğitmene "User" e ait cardId
        public CreateUserCart CreateUserCart { get; set; }

    }

    public class RolePaymentClassWithRolePaymentModel // ÖDEMENİN VE SINIFIN OLDUĞU ORTAK TABLO
    {
        public int Id { get; set; }
        public int RolePaymentClassId { get; set; }
        public int RolePaymentId { get; set; }

    }
}
