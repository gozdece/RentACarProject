using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    static class Messages
    {
        public static string CarMaintenenceTime = "Bakım zamanı";
        public static string CarListed = "Ürünler listelendi";
        public static string Added = "Yükleme yapıldı";
        public static string CarNameInvalid = "Araba adı geçersiz";
        public static string Updated = "Güncelleme yapıldı";
        public static string Deleted = "Silme işlemi yapıldı";
        public static string Error = "İşlem başarısız.";
        public static string AuthorizationDenied = "Yetkilendirme yok";

        public static string UserRegistered = "Kayıt olundu.";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Yanlış şifre";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı zaten var";
        public static string AccessTokenCreated = "Erişim tokenı oluşturuldu";
    }
}
