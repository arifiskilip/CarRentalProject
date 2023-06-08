using System.Runtime.Serialization;

namespace Business.Constants
{
    public static class Messages
    {
        // Car
        public static string CarAdded = "Araç eklendi.";
        public static string NotCarAdded = "Araç eklenemedi.";
        public static string CarListed = "Araç listelendi.";
        public static string CarDeleted = "Araç silindi.";
        public static string CarUpdated = "Araç Güncellendi.";
        public static string CarNameInvalid = "Geçersiz araç ismi.";
        public static string CarListedByBrand = "Markaya göre araçlar listelendi.";
        public static string CarListedByColor = "Renge göre araçlar listelendi.";
        // Rental
        public static string RentalDeleted = "Araç başarılı bir şekilde silindi.";
        public static string RentalListed = "Araçlar listelendi.";
        public static string RentalUpdated = "Araç başarılı bir şekilde güncellendi.";
        public static string RentalListById = "Seçilen araç listelendi.";
        public static string RentalAdded = "Araç başarılı bir şekilde kiralandı.";
        public static string RentalInvalid = "Geçersiz kiralama.";
        public static string RentalNotFound = "Kiralanan araç bulunamadı.";
        //Brand
        public static string BrandAdded = "Marka eklendi.";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka güncellendi.";
        public static string BrandLited = "Markalar listelendi.";
        public static string BrandListById = "Seçilen markalı araçlar listelendi.";
        //Customer
        public static string CustomerAdded = "Müşteri eklendi.";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri güncellendi.";
        public static string CustomerLited = "Müşteriler listelendi.";
        public static string CustomerListById = "Seçilen Müşteri listelendi.";
        //User
        public static string UserAdded = "Kullanıcı eklendi.";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı güncellendi.";
        public static string UserLited = "Kullanıcılar listelendi.";
        public static string UserListById = "Seçilen Kullanıcı listelendi.";

        //System Message
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";

        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string ProductNameAlreadyExists = "Ürün ismi zaten mevcut";
    }
}
