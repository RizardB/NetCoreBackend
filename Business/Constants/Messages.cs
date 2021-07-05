using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi.";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz.";
        public static string MaintenanceTime = "Belirlenen zamanların dışındasınız!";
        public static string ProductsListed = "Ürünler Listelendi";
        internal static string ProductNameAlreadyExits = "Bu isimde başka bir ürün bulunmakta.";
        internal static string CategoryLimitExceded = "Category sayısı çok fazla.";
        public static string AuthorizationDenied = "Erişim engellendi.";

        public static string UserRegistered = "Kayıt başarılı";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string AccessTokenCreated = "Token oluşturuldu";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string ProductUpdated = "Ürün güncellendi";
    }
}
