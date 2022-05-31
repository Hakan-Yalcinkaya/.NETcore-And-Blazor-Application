using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Contants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Başarı ile Eklendi";
        public static string ProductDeleted = "Ürün Başarı ile Silindi";
        public static string ProductUpdated = "Ürün Başarı ile Güncellendi";

        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Şifre Hatalı";

        public static string SuccessfulLogin = "Sisteme Giriş Başarılı";
        public static string UserAlreadyExist = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarı ile kaydedildi";
        public static string AccessTokenCreated = "Access Token başarı ile oluşturuldu";
    }
}