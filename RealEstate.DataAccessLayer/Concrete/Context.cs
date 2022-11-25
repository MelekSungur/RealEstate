using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Azure.KeyVault.Models;
using Microsoft.EntityFrameworkCore;
using RealEstate.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contact = RealEstate.EntityLayer.Concrete.Contact;

namespace RealEstate.DataAccessLayer.Concrete
{
   public class Context:IdentityDbContext<AppUser,AppRole,int> //sınıftan miras almalıyım
   {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Melek;initial catalog=DbCoreRealEstate;Integrated security=True");
        }
        DbSet<Member> Members { get; set; }
        DbSet<Contact> Contacts { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<About> Abouts { get; set; }
        DbSet<Product> Products { get; set; }

    }
}
