using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ProductsListed="Ürünler listelendi";

        public static string MaintenanceTime="Sistem Bakımda";
        public static string CategoriesListed = "Kategoriler listelendi";
        public static string UnitPriceInvalid = "Fiyat geçersiz";

        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExist = "Aynı isimde ürün eklenemez";
        public static string CategoryLimitExceded = "Kategori sayısı 15 i geçemez, yeni ürün eklenemez";

        public static string AuthorizationDenied="Yetkiniz Yok";

        public static string UserRegistered="Kullanıcı Başarıyla Kaydedildi";
        public static string UserNotFound ="Kullanıcı Bulunamadı";
        public static string PasswordError="Parola Hatası";
        public static string SuccessfulLogin="Başarılı Giriş";
        public static string UserAlreadyExists="Kullanıcı Mevcut";
        public static string AccessTokenCreated="Token oluşturuldu";
    }
}
