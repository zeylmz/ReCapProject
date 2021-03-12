using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç ekleme işlemi başarılı";
        public static string CarNameInvalid = "Araç ismi hatalı";
        public static string CarDailyPriceInvalid = "Araç fiyatlandırması hatalı";
        public static string CarsListed = "Araçlar başarıyla listelendi";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string BrandsListed = "Markalar başarıyla listelendi";
        public static string BrandNameInvalid = "Marka ismi hatalı";
        public static string BrandAdded = "Marka ekleme işlemi başarılı";
        public static string ColorNameInvalid = "Renk ismi hatalı";
        public static string ColorAdded = "Renk ekleme işlemi başarılı";
        public static string ColorsListed = "Renkler listelendi";
        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UsersListed = "Kullanıcılar Listelendi";
        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomersListed = "Müşteriler Listelendi";
        public static string RentalAdded = "Kiralama Eklendi";
        public static string RentalsListed = "Kiralamalar Listelendi";
        public static string CarImageAdded = "Araç Resmi Eklendi";
        public static string CarImageListed = "Araç Resimleri Listelendi";
        public static string CarImageLimitExceeded = "Araç için görsel sayısı aşıldı.";
        public static string CarImageNotFound = "Aracın bir resmi yok";
        public static string AuthorizationDenied = "Bu işlem için yetkiniz bulunmamaktadır.";
        public static string UserRegistered = "Kayıt Tamamlandı";
        public static string UserNotFound = "Böyle bir kullanıcı bulunamadı";
        public static string PasswordError = "Parola Yanlış";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı sistemde mevcut";
        public static string AccessTokenCreated = "Token Oluşturuldu";
    }
}
