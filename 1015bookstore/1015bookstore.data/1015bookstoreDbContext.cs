using _1015bookstore.model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1015bookstore.data
{
    public class _1015bookstoreDbContext : DbContext
    {
        public _1015bookstoreDbContext() : base("1015bookstoreConnection") 
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<PromotionalCode> PromotionCodes { get; set;}
        public DbSet<Review> Reviews { get; set; }
        public DbSet<TypedCategories_Promotionals> typedCategories_Promotionals { get; set; }
        public DbSet<TypedProducts_Promotionals> typedProducts_Promotionals { get; set; }
        public DbSet<TypedUsers_Promotionals> typedUsers_Promotionals { get; set; }
        public DbSet<TypedUserTypes_Promotionals> typedUserTypes_Promotionals { get; set; }
        public DbSet<TypedUsers_UserTypes> typedUsers_UserTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }
        public DbSet<UserType> UserTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
