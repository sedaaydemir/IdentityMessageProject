using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityMessageProject.EntityLayer.Concrete
{
    public class AppUser :IdentityUser<int>
    {
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string ImageUrl { get; set; }

        //bıre cok ılıskı ıle mesaj tablosu
        public List<Message> Messages { get; set; }//bır kullanıcı bırden cok mesaj ıletebilir
        
    }
}
