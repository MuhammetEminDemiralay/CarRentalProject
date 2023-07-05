using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {

       

        public static string BrandListed = "Markalar listelendi";
        public static string BrandAdd = "Marka eklendi";
        public static string BrandDelete = "Marka silindi";
        public static string BrandGet = "Marka listelendi";
        public static string BrandUpdate = "Marka güncellendi";


        public static string CarListed = "Arabalar listelendi";
        public static string CarAdded = "Araba eklendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarGet = "Araba listelendi";
        public static string CarUpdate = "Araba güncellendi";
        public static string GetByBrandCategory = "Markaya göre arabalar listelendi";
        public static string CarDetailListed = "Araba ayrıntıları listelendi";

        public static string ColorListed = "Renkler listelendi";
        public static string ColorAdd = "Renk eklendi";
        public static string ColorDelete = "Renk silindi";
        public static string ColorGet = "Renk listelendi";
        public static string ColorUpdate = "Renk güncellendi";

        public static string CreditCardListed = "Kredi kartları listelendi";
        public static string CreditCardAdd = "Kredi kartı eklendi";
        public static string CreditCardDelete = "Kredi kartı silindi";
        public static string CreditCardGet = "Kredi kartı listelendi";
        public static string CreditCardUpdate = "Kredi kartı güncellendi";

        public static string CustomerAdd = "Müşteri eklendi";
        public static string CustomerDelete = "Müşteri silindi";
        public static string CustomerListed = "Müşteriler listelendi";
        public static string CustomerUpdate = "Müşteri güncellendi";

        public static string PaymentListed = "Ödemeler listelendi";
        public static string PaymentAdd = "Ödeme eklendi";
        public static string PaymentDelete = "Ödeme silindi";
        public static string PaymentGet = "Ödeme listelendi";
        public static string PaymentUpdate = "Ödeme güncellendi";

        public static string RentalListed = "Kiralamalar listelendi";
        public static string RentalAdd = "Kiralama eklendi";
        public static string RentalGet = "Kiralama listelendi"; 
        public static string RentalDelete = "Kiralama silindi";
        public static string RentalUpdate = "Kiralama Güncellendi";

        public static string ImageListed = "Resimler listelendi";
        public static string ImageAdd = "Resim eklendi";
        public static string ImageGet = "Resim listelendi";
        public static string ImageDelete = "Resim silindi";
        public static string ImageUpdate = "Resim güncellendi";
        public static string BrandHop = "Yakaladım seni İnşallah";

        public static string Addİmage = "Lütfen resim ekleyiniz";
        public static string AddedToCarImage = "Resim eklendi";
        public static string ResimEklendi = "Resim Eklendi";
        public static string GetİmagesByCarId = "Arabaya göre resim getirildi";

        public static string UserRegistered = "Kullanıcı Kayıt Edildi";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin ="Giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı zaten var";
        public static string AccessTokenCreated = "Token oluşturuldu";

        public static string UserUpdate = "Kullanıcı güncellendi";
        public static string UserDelete = "Kullanıcı silindi";
        public static string UserGet = "Kullanıcı listelend<i";
        public static string UsersListed = "Kullanıcılar listelendi";
        public static string UserAdd = "Kullanıcı eklendi";
    }
}
