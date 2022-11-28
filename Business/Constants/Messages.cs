using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductUpdated = "Ürün güncellendi.";
        public static string ProductListed = "Ürünler listelendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Sistem bakımda.";

        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 15 ürün olabilir.";
        public static string ProductNameAlreadyExists = "Bir kategoride en fazla 10 ürün olabilir.";
        public static string CategoryLimitExceded = "Kategori limiti aşıldı Max: 15";

        public static string AuthorizationDenied = "Erişim Reddedildi. (Yetkiniz yok)";
        public static string UserRegistered = "Kayıt başarılı.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Şifre yanlış.";
        public static string SuccessfulLogin = "Giriş başarılı.";
        public static string UserAlreadyExists = "Böyle bir kullanıcı zaten var.";
        public static string AccessTokenCreated = "Token oluşturuldu.";
    }
}
