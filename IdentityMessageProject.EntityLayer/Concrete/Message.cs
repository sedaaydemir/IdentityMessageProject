using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityMessageProject.EntityLayer.Concrete
{
    public class Message
    {
        public int MessageId { get; set; }
        public string SendMessage { get; set; }
        public string ReceiveMessage { get; set; }
        public string SubjectMessage { get; set; }
        public string ContentMessage { get; set; }
        public DateTime CreatedDate { get; set; }


        public int AppUserId { get; set; } //user sınıfıyla ilişkisi
        public AppUser AppUser { get; set; }
        public int CategoryId { get; set; }//kategorı sınıfıyla ılıskısı
        public Category Category { get; set; }
    }
}
