﻿// <auto-generated />
using System;
using FoodDelivery.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FoodDelivery.Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240915093051_Categories2")]
    partial class Categories2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FoodDelivery.Domain.Domain.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Flat")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("OwnerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("FoodDelivery.Domain.Domain.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9b5ac6be-5381-4ee6-a9b4-c6a5a972f1a2"),
                            Image = "../Images/italian.png",
                            Name = "Italian"
                        },
                        new
                        {
                            Id = new Guid("31f4de0d-ebcd-45c4-8f6d-2f66494adc34"),
                            Image = "../Images/chinese.png",
                            Name = "Chinese"
                        },
                        new
                        {
                            Id = new Guid("54b684ec-43ff-4a33-ab50-d3b14d23b6b8"),
                            Image = "../Images/mexican.png",
                            Name = "Mexican"
                        },
                        new
                        {
                            Id = new Guid("89587414-29cc-4652-b5be-0a8cda692f0d"),
                            Image = "../Images/indian.png",
                            Name = "Indian"
                        },
                        new
                        {
                            Id = new Guid("c393f130-7469-4e5f-a6dd-a67930a2d783"),
                            Image = "../Images/american.png",
                            Name = "American"
                        },
                        new
                        {
                            Id = new Guid("d686abc8-9347-4bcb-a049-7b186f833c99"),
                            Image = "../Images/greek.jfif",
                            Name = "Greek"
                        },
                        new
                        {
                            Id = new Guid("3c9fcc29-4c2a-4604-b4ed-6942c7d5982d"),
                            Image = "../Images/vegan.png",
                            Name = "Vegan"
                        },
                        new
                        {
                            Id = new Guid("bd04e6f4-e669-4152-83c6-4876ebdf3a8d"),
                            Image = "../Images/vegetarian.png",
                            Name = "Vegetarian"
                        },
                        new
                        {
                            Id = new Guid("06f7399c-a16e-4ea8-8ef2-6fe211f0e682"),
                            Image = "../Images/healthy.png",
                            Name = "Healthy"
                        },
                        new
                        {
                            Id = new Guid("6576b682-c71e-4e28-921b-f7b36d9047e0"),
                            Image = "../Images/asian.png",
                            Name = "Asian"
                        },
                        new
                        {
                            Id = new Guid("714ff1b1-d5c8-48fb-ac38-7a1b2b5d30b2"),
                            Image = "../Images/breakfast.png",
                            Name = "Breakfast"
                        },
                        new
                        {
                            Id = new Guid("49302a31-dc28-4814-b31d-a6e0c006b52b"),
                            Image = "../Images/desserts.png",
                            Name = "Desserts"
                        });
                });

            modelBuilder.Entity("FoodDelivery.Domain.Domain.CategoryInRestaurant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RestaurantId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("CategoryInRestaurants");
                });

            modelBuilder.Entity("FoodDelivery.Domain.Domain.Food", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("FoodCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Price")
                        .HasColumnType("float");

                    b.Property<Guid?>("RestaurantId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("FoodCategoryId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("FoodDelivery.Domain.Domain.FoodCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FoodCategories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("274202e6-e4a2-44b9-a19d-255569189574"),
                            Name = "Breakfast"
                        },
                        new
                        {
                            Id = new Guid("f0ab1c4d-e8a4-4711-9906-fbcc641cf1a0"),
                            Name = "Salads"
                        },
                        new
                        {
                            Id = new Guid("e750494c-5d80-4632-ac76-2bf68ec43386"),
                            Name = "Pasta"
                        },
                        new
                        {
                            Id = new Guid("feeba90d-ddf9-43c6-b1a2-b67f2aa3a15a"),
                            Name = "Pizza"
                        },
                        new
                        {
                            Id = new Guid("60309f06-0abc-46a8-b367-dc8848707162"),
                            Name = "Desserts"
                        },
                        new
                        {
                            Id = new Guid("65167f47-ef80-4f12-9ce8-d69fd77b810f"),
                            Name = "Alcoholic Beverages"
                        },
                        new
                        {
                            Id = new Guid("a9215ab6-d7a1-40b4-936a-532c89864fe5"),
                            Name = "Soft Drinks"
                        },
                        new
                        {
                            Id = new Guid("986ad34f-062a-4cfc-9110-9be2d0082117"),
                            Name = "Hot Drinks"
                        },
                        new
                        {
                            Id = new Guid("f6447345-aaf6-4288-8d2d-4add5aaeee07"),
                            Name = "Coffee"
                        },
                        new
                        {
                            Id = new Guid("f1507d9e-d603-41b2-8a50-3e240544d586"),
                            Name = "Main Course"
                        },
                        new
                        {
                            Id = new Guid("bd5c0dca-fb22-4d0f-bf3f-33f6c53dc6b7"),
                            Name = "Starters"
                        },
                        new
                        {
                            Id = new Guid("2874c5ed-3a9d-4070-9f30-f782d247a0b0"),
                            Name = "Brunch"
                        },
                        new
                        {
                            Id = new Guid("37e162b3-5379-4d67-a400-118ea3c05a8c"),
                            Name = "Burgers"
                        },
                        new
                        {
                            Id = new Guid("3e9b526c-62de-4bfb-8a6b-4de93fbbbfb5"),
                            Name = "Sandwiches"
                        },
                        new
                        {
                            Id = new Guid("2c194d43-dd6b-4bdd-b89b-da62f939ff16"),
                            Name = "Juices"
                        });
                });

            modelBuilder.Entity("FoodDelivery.Domain.Domain.FoodInOrder", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FoodId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FoodId");

                    b.HasIndex("OrderId");

                    b.ToTable("FoodInOrders");
                });

            modelBuilder.Entity("FoodDelivery.Domain.Domain.FoodInWishlist", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FoodId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid>("WishlistId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("FoodId");

                    b.HasIndex("WishlistId");

                    b.ToTable("FoodInWishlists");
                });

            modelBuilder.Entity("FoodDelivery.Domain.Domain.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("OwnerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("FoodDelivery.Domain.Domain.Restaurant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("DeliveryTime")
                        .HasColumnType("int");

                    b.Property<bool?>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<double?>("Latitude")
                        .HasColumnType("float");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NumOfOrders")
                        .HasColumnType("int");

                    b.Property<string>("OwnerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Rating")
                        .HasColumnType("float");

                    b.Property<string>("RestaurantImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TotalGrades")
                        .HasColumnType("int");

                    b.Property<TimeOnly?>("WorkingFrom")
                        .HasColumnType("time");

                    b.Property<TimeOnly?>("WorkingTo")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("FoodDelivery.Domain.Domain.Wishlist", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.ToTable("Wishlists");
                });

            modelBuilder.Entity("FoodDelivery.Domain.Identity.FoodDeliveryAppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("FoodDelivery.Domain.Domain.Address", b =>
                {
                    b.HasOne("FoodDelivery.Domain.Identity.FoodDeliveryAppUser", "Owner")
                        .WithMany("DeliveryAddress")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("FoodDelivery.Domain.Domain.CategoryInRestaurant", b =>
                {
                    b.HasOne("FoodDelivery.Domain.Domain.Category", "Category")
                        .WithMany("CategoryInRestaurants")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodDelivery.Domain.Domain.Restaurant", "Restaurant")
                        .WithMany("CategoryInRestaurants")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("FoodDelivery.Domain.Domain.Food", b =>
                {
                    b.HasOne("FoodDelivery.Domain.Domain.FoodCategory", "FoodCategory")
                        .WithMany()
                        .HasForeignKey("FoodCategoryId");

                    b.HasOne("FoodDelivery.Domain.Domain.Restaurant", "Restaurant")
                        .WithMany("Menu")
                        .HasForeignKey("RestaurantId");

                    b.Navigation("FoodCategory");

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("FoodDelivery.Domain.Domain.FoodInOrder", b =>
                {
                    b.HasOne("FoodDelivery.Domain.Domain.Food", "Food")
                        .WithMany()
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodDelivery.Domain.Domain.Order", "Order")
                        .WithMany("FoodsInOrder")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Food");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("FoodDelivery.Domain.Domain.FoodInWishlist", b =>
                {
                    b.HasOne("FoodDelivery.Domain.Domain.Food", "Food")
                        .WithMany()
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodDelivery.Domain.Domain.Wishlist", "Wishlist")
                        .WithMany("FoodInWishlists")
                        .HasForeignKey("WishlistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Food");

                    b.Navigation("Wishlist");
                });

            modelBuilder.Entity("FoodDelivery.Domain.Domain.Order", b =>
                {
                    b.HasOne("FoodDelivery.Domain.Identity.FoodDeliveryAppUser", "Owner")
                        .WithMany("Orders")
                        .HasForeignKey("OwnerId");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("FoodDelivery.Domain.Domain.Restaurant", b =>
                {
                    b.HasOne("FoodDelivery.Domain.Identity.FoodDeliveryAppUser", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("FoodDelivery.Domain.Domain.Wishlist", b =>
                {
                    b.HasOne("FoodDelivery.Domain.Identity.FoodDeliveryAppUser", "User")
                        .WithOne("Wishlist")
                        .HasForeignKey("FoodDelivery.Domain.Domain.Wishlist", "UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("FoodDelivery.Domain.Identity.FoodDeliveryAppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("FoodDelivery.Domain.Identity.FoodDeliveryAppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodDelivery.Domain.Identity.FoodDeliveryAppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("FoodDelivery.Domain.Identity.FoodDeliveryAppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FoodDelivery.Domain.Domain.Category", b =>
                {
                    b.Navigation("CategoryInRestaurants");
                });

            modelBuilder.Entity("FoodDelivery.Domain.Domain.Order", b =>
                {
                    b.Navigation("FoodsInOrder");
                });

            modelBuilder.Entity("FoodDelivery.Domain.Domain.Restaurant", b =>
                {
                    b.Navigation("CategoryInRestaurants");

                    b.Navigation("Menu");
                });

            modelBuilder.Entity("FoodDelivery.Domain.Domain.Wishlist", b =>
                {
                    b.Navigation("FoodInWishlists");
                });

            modelBuilder.Entity("FoodDelivery.Domain.Identity.FoodDeliveryAppUser", b =>
                {
                    b.Navigation("DeliveryAddress");

                    b.Navigation("Orders");

                    b.Navigation("Wishlist")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
