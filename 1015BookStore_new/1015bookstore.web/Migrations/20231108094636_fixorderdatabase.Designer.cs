﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1015bookstore.web.Data;

#nullable disable

namespace _1015bookstore.web.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20231108094636_fixorderdatabase")]
    partial class fixorderdatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("_1015bookstore.web.Data.Entity.CartItem", b =>
                {
                    b.Property<int>("product_id")
                        .HasColumnType("int");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.Property<float>("price")
                        .HasColumnType("real");

                    b.Property<int>("productid")
                        .HasColumnType("int");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.HasKey("product_id", "user_id");

                    b.HasIndex("productid");

                    b.HasIndex("user_id");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("_1015bookstore.web.Data.Entity.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("categoryparentid")
                        .HasColumnType("int");

                    b.Property<string>("createdby")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<DateTime>("createdtime")
                        .HasColumnType("datetime2");

                    b.Property<int>("is_status")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar");

                    b.Property<string>("updatedby")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<DateTime>("updatedtime")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("_1015bookstore.web.Data.Entity.Order", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("address_id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("completedate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("createdtime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("deliverydate")
                        .HasColumnType("datetime2");

                    b.Property<int>("is_status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("paymentdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("status_order")
                        .HasColumnType("int");

                    b.Property<DateTime>("updatedtime")
                        .HasColumnType("datetime2");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("user_id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("_1015bookstore.web.Data.Entity.OrderDetail", b =>
                {
                    b.Property<int>("product_id")
                        .HasColumnType("int");

                    b.Property<int>("order_id")
                        .HasColumnType("int");

                    b.Property<float>("price")
                        .HasColumnType("real");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.HasKey("product_id", "order_id");

                    b.HasIndex("order_id");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("_1015bookstore.web.Data.Entity.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("alias")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<int>("buy_count")
                        .HasColumnType("int");

                    b.Property<int>("category_id")
                        .HasColumnType("int");

                    b.Property<string>("createdby")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<DateTime>("createdtime")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar");

                    b.Property<bool>("flashsale")
                        .HasColumnType("bit");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("is_status")
                        .HasColumnType("int");

                    b.Property<int>("like_count")
                        .HasColumnType("int");

                    b.Property<string>("more_image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar");

                    b.Property<float>("price")
                        .HasColumnType("real");

                    b.Property<int>("quanity")
                        .HasColumnType("int");

                    b.Property<int>("reviews")
                        .HasColumnType("int");

                    b.Property<float>("starts")
                        .HasColumnType("real");

                    b.Property<string>("updatedby")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<DateTime>("updatedtime")
                        .HasColumnType("datetime2");

                    b.Property<int>("view_count")
                        .HasColumnType("int");

                    b.Property<int>("waranty")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("category_id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("_1015bookstore.web.Data.Entity.ProductDetail", b =>
                {
                    b.Property<int>("product_id")
                        .HasColumnType("int");

                    b.Property<string>("author")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar");

                    b.Property<string>("brand")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar");

                    b.Property<string>("suppiler")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar");

                    b.HasKey("product_id");

                    b.ToTable("ProductDetails");
                });

            modelBuilder.Entity("_1015bookstore.web.Data.Entity.PromotionalCode", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("alias")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<string>("createdby")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<DateTime>("createdtime")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar");

                    b.Property<int>("discount_rate")
                        .HasColumnType("int");

                    b.Property<int>("is_status")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar");

                    b.Property<string>("updatedby")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<DateTime>("updatedtime")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("PromotionalCodes");
                });

            modelBuilder.Entity("_1015bookstore.web.Data.Entity.Review", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("contents")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<DateTime>("createdtime")
                        .HasColumnType("datetime2");

                    b.Property<string>("deletedby")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<DateTime>("deletedtime")
                        .HasColumnType("datetime2");

                    b.Property<int>("is_status")
                        .HasColumnType("int");

                    b.Property<int>("product_id")
                        .HasColumnType("int");

                    b.Property<int>("starts")
                        .HasColumnType("int");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("product_id");

                    b.HasIndex("user_id");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("_1015bookstore.web.Data.Entity.TypedCategories_Promotionals", b =>
                {
                    b.Property<int>("category_id")
                        .HasColumnType("int");

                    b.Property<int>("promotional_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("expirationdate")
                        .HasColumnType("datetime2");

                    b.HasKey("category_id", "promotional_id");

                    b.HasIndex("promotional_id");

                    b.ToTable("TypedCategories_Promotionals");
                });

            modelBuilder.Entity("_1015bookstore.web.Data.Entity.TypedProducts_Promotionals", b =>
                {
                    b.Property<int>("product_id")
                        .HasColumnType("int");

                    b.Property<int>("promotional_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("expirationdate")
                        .HasColumnType("datetime2");

                    b.HasKey("product_id", "promotional_id");

                    b.HasIndex("promotional_id");

                    b.ToTable("TypedProducts_Promotionals");
                });

            modelBuilder.Entity("_1015bookstore.web.Data.Entity.TypedUserTypes_Promotionals", b =>
                {
                    b.Property<int>("usertype_id")
                        .HasColumnType("int");

                    b.Property<int>("promotional_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("expirationdate")
                        .HasColumnType("datetime2");

                    b.HasKey("usertype_id", "promotional_id");

                    b.HasIndex("promotional_id");

                    b.ToTable("TypedUserTypes_Promotionals");
                });

            modelBuilder.Entity("_1015bookstore.web.Data.Entity.TypedUsers_Promotionals", b =>
                {
                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.Property<int>("promotional_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("expirationdate")
                        .HasColumnType("datetime2");

                    b.HasKey("user_id", "promotional_id");

                    b.HasIndex("promotional_id");

                    b.ToTable("TypedUsers_Promotionals");
                });

            modelBuilder.Entity("_1015bookstore.web.Data.Entity.TypedUsers_UserTypes", b =>
                {
                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.Property<int>("usertype_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("expirationdate")
                        .HasColumnType("datetime2");

                    b.HasKey("user_id", "usertype_id");

                    b.HasIndex("usertype_id");

                    b.ToTable("TypedUsers_UserTypes");
                });

            modelBuilder.Entity("_1015bookstore.web.Data.Entity.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("createdtime")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<string>("firstname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar");

                    b.Property<int>("is_status")
                        .HasColumnType("int");

                    b.Property<string>("lastname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("updatedtime")
                        .HasColumnType("datetime2");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.HasKey("id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("_1015bookstore.web.Data.Entity.UserAddress", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("address_detail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar");

                    b.Property<float>("coordinates_X")
                        .HasColumnType("real");

                    b.Property<float>("coordinates_Y")
                        .HasColumnType("real");

                    b.Property<DateTime>("createdtime")
                        .HasColumnType("datetime2");

                    b.Property<string>("district")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar");

                    b.Property<bool>("is_default")
                        .HasColumnType("bit");

                    b.Property<int>("is_status")
                        .HasColumnType("int");

                    b.Property<string>("receiver_name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar");

                    b.Property<string>("receiver_phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("sub_district")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar");

                    b.Property<DateTime>("updatedtime")
                        .HasColumnType("datetime2");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("user_id");

                    b.ToTable("UserAddresses");
                });

            modelBuilder.Entity("_1015bookstore.web.Data.Entity.UserType", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("alias")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<string>("createdby")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<DateTime>("createdtime")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar");

                    b.Property<int>("is_status")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar");

                    b.Property<string>("updatedby")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.Property<DateTime>("updatedtime")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("UserTypes");
                });

            modelBuilder.Entity("_1015bookstore.web.Data.Entity.CartItem", b =>
                {
                    b.HasOne("_1015bookstore.web.Data.Entity.Product", "product")
                        .WithMany("cartitems")
                        .HasForeignKey("productid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1015bookstore.web.Data.Entity.User", "user")
                        .WithMany("cartitems")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_CartItem_User");

                    b.Navigation("product");

                    b.Navigation("user");
                });

            modelBuilder.Entity("_1015bookstore.web.Data.Entity.Order", b =>
                {
                    b.HasOne("_1015bookstore.web.Data.Entity.User", "user")
                        .WithMany("orders")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Order_User");

                    b.Navigation("user");
                });

            modelBuilder.Entity("_1015bookstore.web.Data.Entity.OrderDetail", b =>
                {
                    b.HasOne("_1015bookstore.web.Data.Entity.Order", "order")
                        .WithMany("orderdetails")
                        .HasForeignKey("order_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Orderdetail_Order");

                    b.HasOne("_1015bookstore.web.Data.Entity.Product", "product")
                        .WithMany("orderdetails")
                        .HasForeignKey("product_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Orderdetail_Product");

                    b.Navigation("order");

                    b.Navigation("product");
                });

            modelBuilder.Entity("_1015bookstore.web.Data.Entity.Product", b =>
                {
                    b.HasOne("_1015bookstore.web.Data.Entity.Category", "category")
                        .WithMany("products")
                        .HasForeignKey("category_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Product_Category");

                    b.Navigation("category");
                });

            modelBuilder.Entity("_1015bookstore.web.Data.Entity.ProductDetail", b =>
                {
                    b.HasOne("_1015bookstore.web.Data.Entity.Product", "product")
                        .WithOne("productdetail")
                        .HasForeignKey("_1015bookstore.web.Data.Entity.ProductDetail", "product_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("product");
                });

            modelBuilder.Entity("_1015bookstore.web.Data.Entity.Review", b =>
                {
                    b.HasOne("_1015bookstore.web.Data.Entity.Product", "product")
                        .WithMany("reviews_")
                        .HasForeignKey("product_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Review_Product");

                    b.HasOne("_1015bookstore.web.Data.Entity.User", "user")
                        .WithMany("reviews")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Review_User");

                    b.Navigation("product");

                    b.Navigation("user");
                });

            modelBuilder.Entity("_1015bookstore.web.Data.Entity.TypedCategories_Promotionals", b =>
                {
                    b.HasOne("_1015bookstore.web.Data.Entity.Category", "category")
                        .WithMany("typedcategories_promotionals")
                        .HasForeignKey("category_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_TypeCategories_Promotionals_1");

                    b.HasOne("_1015bookstore.web.Data.Entity.PromotionalCode", "promotionalcodes")
                        .WithMany("typedcategories_promotionals")
                        .HasForeignKey("promotional_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_TypeCategories_Promotionals_2");

                    b.Navigation("category");

                    b.Navigation("promotionalcodes");
                });

            modelBuilder.Entity("_1015bookstore.web.Data.Entity.TypedProducts_Promotionals", b =>
                {
                    b.HasOne("_1015bookstore.web.Data.Entity.Product", "product")
                        .WithMany("typedproducts_promotionals")
                        .HasForeignKey("product_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_TypeProducts_Promotionals_1");

                    b.HasOne("_1015bookstore.web.Data.Entity.PromotionalCode", "promotionalcodes")
                        .WithMany("typedproducts_promotionals")
                        .HasForeignKey("promotional_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_TypeProducts_Promotionals_2");

                    b.Navigation("product");

                    b.Navigation("promotionalcodes");
                });

            modelBuilder.Entity("_1015bookstore.web.Data.Entity.TypedUserTypes_Promotionals", b =>
                {
                    b.HasOne("_1015bookstore.web.Data.Entity.PromotionalCode", "promotionalcodes")
                        .WithMany("typedusertypes_promotionals")
                        .HasForeignKey("promotional_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_TypeUserTypes_Promotionals_2");

                    b.HasOne("_1015bookstore.web.Data.Entity.UserType", "usertype")
                        .WithMany("typedusertypes_promotionals")
                        .HasForeignKey("usertype_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_TypeUserTypes_Promotionals_1");

                    b.Navigation("promotionalcodes");

                    b.Navigation("usertype");
                });

            modelBuilder.Entity("_1015bookstore.web.Data.Entity.TypedUsers_Promotionals", b =>
                {
                    b.HasOne("_1015bookstore.web.Data.Entity.PromotionalCode", "promotionalcodes")
                        .WithMany("typedusers_promotionals")
                        .HasForeignKey("promotional_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_TypeUsers_Promotionals_2");

                    b.HasOne("_1015bookstore.web.Data.Entity.User", "user")
                        .WithMany("typedusers_promotionals")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_TypeUsers_Promotionals_1");

                    b.Navigation("promotionalcodes");

                    b.Navigation("user");
                });

            modelBuilder.Entity("_1015bookstore.web.Data.Entity.TypedUsers_UserTypes", b =>
                {
                    b.HasOne("_1015bookstore.web.Data.Entity.User", "user")
                        .WithMany("typedusers_usertypes")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_TypeUsers_UserTypes_1");

                    b.HasOne("_1015bookstore.web.Data.Entity.UserType", "usertype")
                        .WithMany("typedusers_usertypes")
                        .HasForeignKey("usertype_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_TypeUsers_UserTypes_2");

                    b.Navigation("user");

                    b.Navigation("usertype");
                });

            modelBuilder.Entity("_1015bookstore.web.Data.Entity.UserAddress", b =>
                {
                    b.HasOne("_1015bookstore.web.Data.Entity.User", "user")
                        .WithMany("useraddresses")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_UserAddress_User");

                    b.Navigation("user");
                });

            modelBuilder.Entity("_1015bookstore.web.Data.Entity.Category", b =>
                {
                    b.Navigation("products");

                    b.Navigation("typedcategories_promotionals");
                });

            modelBuilder.Entity("_1015bookstore.web.Data.Entity.Order", b =>
                {
                    b.Navigation("orderdetails");
                });

            modelBuilder.Entity("_1015bookstore.web.Data.Entity.Product", b =>
                {
                    b.Navigation("cartitems");

                    b.Navigation("orderdetails");

                    b.Navigation("productdetail")
                        .IsRequired();

                    b.Navigation("reviews_");

                    b.Navigation("typedproducts_promotionals");
                });

            modelBuilder.Entity("_1015bookstore.web.Data.Entity.PromotionalCode", b =>
                {
                    b.Navigation("typedcategories_promotionals");

                    b.Navigation("typedproducts_promotionals");

                    b.Navigation("typedusers_promotionals");

                    b.Navigation("typedusertypes_promotionals");
                });

            modelBuilder.Entity("_1015bookstore.web.Data.Entity.User", b =>
                {
                    b.Navigation("cartitems");

                    b.Navigation("orders");

                    b.Navigation("reviews");

                    b.Navigation("typedusers_promotionals");

                    b.Navigation("typedusers_usertypes");

                    b.Navigation("useraddresses");
                });

            modelBuilder.Entity("_1015bookstore.web.Data.Entity.UserType", b =>
                {
                    b.Navigation("typedusers_usertypes");

                    b.Navigation("typedusertypes_promotionals");
                });
#pragma warning restore 612, 618
        }
    }
}
