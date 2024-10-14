using DataAcsessLayer.Abstract;
using Entitylayer.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsessLayer.Concrate
{
	public class Context : DbContext
	{


		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			//optionsBuilder.UseSqlServer("server=SEMA-PC\\SQLEXPRESS01;database=MyWebDb2 ;integrated security=true;TrustServerCertificate=Yes");
			optionsBuilder.UseSqlServer("Data Source=172.16.1.3;Initial Catalog=SeyyitMehmetDb;User ID=seyyitmehmetuser;Password=seyyit?102030;TrustServerCertificate=True");
		}
		public DbSet<deneme1> admins { get; set; }  //entitiyden alıyoruz mesrla blog'u alalım 
		public DbSet<Blog> blogs { get; set; }
		public DbSet<Menu> menus { get; set; }
        public DbSet<NavbarYonetimi> navbar { get; set; }
        public DbSet<Footer> footer { get; set; }
		public DbSet<BlogEk> blogEks { get; set; }

        public DbSet<Kullanicilar> kullanicilars { get; set; }

        public DbSet<AdminBlogaEK> adminBlogaEKs { get; set; }



    }

}
