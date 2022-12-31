using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün başarıyla eklendi";
        public static string ProductDeleted = "Ürün başarıyla silindi";
        public static string ProductUpdated = "Ürün başarıyla güncellendi";
        public static string ProductGetAll = "Ürünler Db den Başarılı bir şekilde çekilmiştir";
        public static string ProductGetById = "İdsini verdiğiniz ürün başarılı bir şekilde çekilmiştir";
        public static string ProductGetByCategoryId = "bir kategoryi id'de kaç ürün var bilgisine ulaştınız";
        public static string CategoryAdded = "Category başarıyla eklendi";
        public static string CategoryDeleted = "Category başarıyla silindi";
        public static string CategoryGetAll = "Category tablosu başarıyla çekildi";
        public static string CategoryGetById = "CategoryID ye göre başarıyla çekildi";
        public static string CategoryUpdated = "Category başarıyla güncellendi";

        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";

        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string ProductNameAlreadyExists = "Ürün ismi zaten mevcut";
        public static string FavorityAdded = "Favori tablosuna başarıyla ekleme yapıldı";
        public static string FavorityDeleted = "Favori tablosunda silme işlemi başarıyla gerçekleşti";
        public static string FavoriteUpdated = "Favori tablosu başarıyla güncellendi";

        public static string UsersFavorite = "Kullanıcının favorileri Çekilmiştir";

        public static string FavoriteGetAll = "Favori Tablosu Başarıyla çekilmiştir";
    }
}
