using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Contants
{
    public static class Messages
    {
        public static string MessageListed = "------Bilgiler Listelendi-------";

        public static string CarAdded = "Sisteme yeni araba bilgisi eklendi.";
        public static string CarDeleted = "Sistemden mevcut araba bilgisi silindi.";
        public static string CarUpdated = "Sistemdeki mevcut araba bilgisi güncellendi";
        public static string CarNameInvalid = "Böyle bir kayıt bulunamadı.";
        public static string MaintenanceTime = "Sistem şuan bakım saatleri içerisinde";
        public static string CarNameAlreadyExists = "Bu isimde bir araba mevcut.";
        public static string CarsListed = "Mevcut araba bilgileri listelendi";

        public static string UserAdded = "Kullanıcı bilgisi başarıyla eklendi.";
        public static string UserDeleted = "Mevcut kullanıcı bilgisi silindi.";
        public static string UserUpdated = "Kullanıcı bilgisi başarıyla güncellendi.";
        public static string UserNameInvalid = "Böyle bir kullanıcı bulunamadı.";

        public static string CustomerAdded = "Müşteri bilgisi başarıyla eklendi.";
        public static string CustomerDeleted = "Mevcut müşteri bilgisi silindi.";
        public static string CustomerUpdated = "Müşteri bilgisi başarıyla güncellendi.";
        public static string CustomerNameInvalid = "Böyle bir müşteri bulunamadı.";
        
        public static string RentalAdded = "Kiralanmış araba bilgisi sisteme eklendi.";
        public static string RentalDeleted = "Kiralanmış araba bilgisi sistemden silindi.";
        public static string RentalUpdated = "Kiralanmış araba bilgisi güncellendi.";
        public static string RentalNameInvalid = "Böyle bir kiralanma kaydı bulunamadı.";
        public static string UndeliveredCar = "Araç teslim edilmedi.";
        public static string NotAvailable = "Kiralama işlemi gerçekleştirilemiyor.";

        public static string BrandAdded = "Yeni marka kaydı sisteme eklendi.";
        public static string BrandDeleted = "Marka kaydı sistemden silindi.";
        public static string BrandUpdated = "Marka kaydı bilgisi güncellendi.";

        public static string ColorAdded = "Yeni renk kaydı sisteme eklendi.";
        public static string ColorDeleted = "Renk kaydı sistemden silindi.";
        public static string ColorUpdated = "Renk kaydı bilgisi güncellendi.";

        public static string ImageAdded = "Fotoğraf sisteme eklendi.";
        public static string ImageUpdated = "Fotoğraf bilgisi güncellendi.";
        public static string ImageDeleted = "Fotoğraf sistemden silindi.";
        public static string LimitIsUp = "Fotoğraf sayısı maksimum sayıya ulaştı.";

        public static string AuthorizationDenied = "Yetkiniz bulunmamaktadır.";
        public static string AccessTokenCreated = "Yetkilendime oluşturuldu.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Hatalı parola.";
        public static string SuccessLogin = "Giriş başarılı.";
        public static string UserRegistered = "Kullanıcı kaydı başarılı.";
        public static string UserAlreadyExists = "Böyle bir kullanıcı mevcut.";



    }
}
