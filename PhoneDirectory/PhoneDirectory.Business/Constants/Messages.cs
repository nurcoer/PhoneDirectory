using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneDirectory.Business.Constants
{
    public static class General
    {
        public static string ValidationError( bool isLanguage = false)
        {
            return isLanguage ? $"One or more validation errors were encountered." : $"Bir veya daha fazla validasyon hatası ile karşılaşıldı.";
        }
    }
    public static class PhoneDirectoryMessage
    {
        public static string PhoneDirectoryAdd( bool isLanguage = false)
        {
            return isLanguage ? "added phonebook" : "telefon rehberi oluşturuldu.";
        }
        public static string PhoneDirectoryUpdate(bool isLanguage = false)
        {
            return isLanguage ? "updated  phonebook." : "telefon rehberi güncellendi.";
        }
        public static string PhoneDirectoryDelete(bool isLanguage = false)
        {
            return isLanguage ? "phonebook deleted." : "telefon rehberi silindi.";
        }
        public static string PhoneDirectoryNotFound(bool isLanguage = false)
        {
            return isLanguage ? "phonebook not found " : "rehber bulunamadı";
        }
        public static string Exist(bool isLanguage=false)
        {
            return isLanguage ? "the phonebook already exists in your directory. Do you want to update." : "Bu telefon rehberi zaten bulunuyor. Güncellemek istermisiniz.";
        }

    }

    public static class PersonMessage
    {
        public static string PersonAdd(string personName, bool isLanguage = false)
        {
            return isLanguage ? $"{personName.ToUpper()} added to phonebook." : $"{personName.ToUpper()}  rehberine eklendi.";
        }
        public static string PersonUpdate(string personName, bool isLanguage = false)
        {
            return isLanguage ? $"{personName.ToUpper()} updated to phonebook." : $"{personName.ToUpper()} kişisi güncellendi.";
        }
        public static string PersonDelete(string personName, bool isLanguage = false)
        {
            return isLanguage ? $"{personName.ToUpper()} deleted from phonebook." : $"{personName.ToUpper()} rehberden silindi.";
        }
        public static string PersonNotFound(string personName, bool isLanguage = false)
        {
            return isLanguage ? $"{ personName.ToUpper()} person not found " : $"{personName.ToUpper()} kişisi bulunamadı";
        }
        public static string Exist(bool isLanguage = false)
        {
            return isLanguage ? "the contact already exists in your directory. Do you want to update." : "Kişi rehberinizde zaten bulunuyor. Güncellemek istermisiniz.";
        }

    }
}
