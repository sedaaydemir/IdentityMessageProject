using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityMessageProject.EntityLayer.Concrete
{
    public class AppRole : IdentityRole<int>
    {
        //role tablosunun ıd strıng gelıyor bunu ınt tıpınde olmasını ıstedıgımız ıcın sadcee ekledık
        //Asp.net core Identity deki roller için özelleştirilmiş sınıf 
        //IdentityRole sınıfını genişleterek, veritabanında int ID kullanan ve istenirse yeni özellikler eklenebilen bir yapı oluşturur.Özelleştirilmiş bir kimlik sistemi kurmak için esneklik sağlar.
    }
}
