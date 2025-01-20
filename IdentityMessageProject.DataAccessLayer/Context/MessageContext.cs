using IdentityMessageProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityMessageProject.DataAccessLayer.Context
{
    public class MessageContext : IdentityDbContext<AppUser, AppRole, int>
    {
        //db server namze --- DESKTOP-BIP870C
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-BIP870C;initial catalog=MessageDb;integrated security=true; TrustServerCertificate=true");
        }

        //veritabanına yansıtmak ıstedıgımız tabloların ısmını yazıyoruz
        public DbSet<Category> Categories { get; set; }
        public DbSet<Message> Messages { get; set; }
    }

}
