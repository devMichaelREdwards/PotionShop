﻿// <auto-generated />
using System;
using Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Api.Migrations
{
    [DbContext(typeof(PotionShoppeContext))]
    partial class PotionShoppeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Api.Classes.AuthUser", b =>
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

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

            modelBuilder.Entity("Api.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<int?>("CustomerStatusId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasMaxLength(1024)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1024)");

                    b.Property<string>("LastName")
                        .HasMaxLength(1024)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1024)");

                    b.HasKey("CustomerId")
                        .HasName("PK__Customer__A4AE64D8CBE501C6");

                    b.HasIndex("CustomerStatusId");

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("Api.Models.CustomerStatus", b =>
                {
                    b.Property<int>("CustomerStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerStatusId"));

                    b.Property<string>("Title")
                        .HasMaxLength(1024)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1024)");

                    b.HasKey("CustomerStatusId")
                        .HasName("PK__Customer__7981F974B86BA1EE");

                    b.ToTable("CustomerStatus", (string)null);
                });

            modelBuilder.Entity("Api.Models.Effect", b =>
                {
                    b.Property<int>("EffectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EffectId"));

                    b.Property<string>("Description")
                        .HasMaxLength(1024)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1024)");

                    b.Property<int?>("Duration")
                        .HasColumnType("int");

                    b.Property<int?>("Value")
                        .HasColumnType("int");

                    b.HasKey("EffectId")
                        .HasName("PK__Effect__6B859F23BED7B681");

                    b.ToTable("Effect", (string)null);
                });

            modelBuilder.Entity("Api.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<int?>("EmployeePositionId")
                        .HasColumnType("int");

                    b.Property<int?>("EmployeeStatusId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasMaxLength(1024)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1024)");

                    b.Property<string>("LastName")
                        .HasMaxLength(1024)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1024)");

                    b.HasKey("EmployeeId")
                        .HasName("PK__Employee__7AD04F115D99E99C");

                    b.HasIndex("EmployeePositionId");

                    b.HasIndex("EmployeeStatusId");

                    b.ToTable("Employee", (string)null);
                });

            modelBuilder.Entity("Api.Models.EmployeePosition", b =>
                {
                    b.Property<int>("EmployeePositionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeePositionId"));

                    b.Property<string>("Title")
                        .HasMaxLength(1024)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1024)");

                    b.HasKey("EmployeePositionId")
                        .HasName("PK__Employee__6FDE9060D9FF1EAD");

                    b.ToTable("EmployeePosition", (string)null);
                });

            modelBuilder.Entity("Api.Models.EmployeeStatus", b =>
                {
                    b.Property<int>("EmployeeStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeStatusId"));

                    b.Property<string>("Title")
                        .HasMaxLength(1024)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1024)");

                    b.HasKey("EmployeeStatusId")
                        .HasName("PK__Employee__3609932CB65FC2EC");

                    b.ToTable("EmployeeStatus", (string)null);
                });

            modelBuilder.Entity("Api.Models.Ingredient", b =>
                {
                    b.Property<int>("IngredientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IngredientId"));

                    b.Property<int?>("Cost")
                        .HasColumnType("int");

                    b.Property<int?>("CurrentStock")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(1024)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1024)");

                    b.Property<int?>("EffectId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasMaxLength(1024)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1024)");

                    b.Property<string>("Name")
                        .HasMaxLength(1024)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1024)");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.HasKey("IngredientId")
                        .HasName("PK__Ingredie__BEAEB25AA64D6969");

                    b.HasIndex("EffectId");

                    b.ToTable("Ingredient", (string)null);
                });

            modelBuilder.Entity("Api.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateOnly?>("DatePlaced")
                        .HasColumnType("date");

                    b.Property<string>("OrderNumber")
                        .HasMaxLength(1024)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1024)");

                    b.Property<int?>("OrderStatusId")
                        .HasColumnType("int");

                    b.Property<int?>("Total")
                        .HasColumnType("int");

                    b.HasKey("OrderId")
                        .HasName("PK__Order__C3905BCF1D790DE4");

                    b.HasIndex("CustomerId");

                    b.HasIndex("OrderStatusId");

                    b.ToTable("Order", (string)null);
                });

            modelBuilder.Entity("Api.Models.OrderIngredient", b =>
                {
                    b.Property<int>("OrderIngredientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderIngredientId"));

                    b.Property<int?>("IngredientId")
                        .HasColumnType("int");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("OrderIngredientId")
                        .HasName("PK__OrderIng__A3146CFA636D3C59");

                    b.HasIndex("IngredientId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderIngredient", (string)null);
                });

            modelBuilder.Entity("Api.Models.OrderPotion", b =>
                {
                    b.Property<int>("OrderPotionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderPotionId"));

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int?>("PotionId")
                        .HasColumnType("int");

                    b.HasKey("OrderPotionId")
                        .HasName("PK__OrderPot__49211579C8B701A8");

                    b.HasIndex("OrderId");

                    b.HasIndex("PotionId");

                    b.ToTable("OrderPotion", (string)null);
                });

            modelBuilder.Entity("Api.Models.OrderStatus", b =>
                {
                    b.Property<int>("OrderStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderStatusId"));

                    b.Property<string>("Title")
                        .HasMaxLength(1024)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1024)");

                    b.HasKey("OrderStatusId")
                        .HasName("PK__OrderSta__BC674CA1510AA2EE");

                    b.ToTable("OrderStatus", (string)null);
                });

            modelBuilder.Entity("Api.Models.Potion", b =>
                {
                    b.Property<int>("PotionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PotionId"));

                    b.Property<int?>("Cost")
                        .HasColumnType("int");

                    b.Property<int?>("CurrentStock")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(1024)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1024)");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasMaxLength(1024)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1024)");

                    b.Property<string>("Name")
                        .HasMaxLength(1024)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1024)");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.HasKey("PotionId")
                        .HasName("PK__Potion__37C41B078A21A008");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Potion", (string)null);
                });

            modelBuilder.Entity("Api.Models.PotionEffect", b =>
                {
                    b.Property<int>("PotionEffectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PotionEffectId"));

                    b.Property<int?>("EffectId")
                        .HasColumnType("int");

                    b.Property<int?>("PotionId")
                        .HasColumnType("int");

                    b.HasKey("PotionEffectId")
                        .HasName("PK__PotionEf__57036DA8465B70FF");

                    b.HasIndex("EffectId");

                    b.HasIndex("PotionId");

                    b.ToTable("PotionEffect", (string)null);
                });

            modelBuilder.Entity("Api.Models.Receipt", b =>
                {
                    b.Property<int>("ReceiptId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReceiptId"));

                    b.Property<DateOnly?>("DateFulfilled")
                        .HasColumnType("date");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("ReceiptNumber")
                        .HasMaxLength(1024)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1024)");

                    b.HasKey("ReceiptId")
                        .HasName("PK__Receipt__CC08C420FACD8524");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("OrderId");

                    b.ToTable("Receipt", (string)null);
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
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

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
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Api.Models.Customer", b =>
                {
                    b.HasOne("Api.Models.CustomerStatus", "CustomerStatus")
                        .WithMany("Customers")
                        .HasForeignKey("CustomerStatusId")
                        .HasConstraintName("FK__Customer__Custom__403A8C7D");

                    b.Navigation("CustomerStatus");
                });

            modelBuilder.Entity("Api.Models.Employee", b =>
                {
                    b.HasOne("Api.Models.EmployeePosition", "EmployeePosition")
                        .WithMany("Employees")
                        .HasForeignKey("EmployeePositionId")
                        .HasConstraintName("FK__Employee__Employ__3B75D760");

                    b.HasOne("Api.Models.EmployeeStatus", "EmployeeStatus")
                        .WithMany("Employees")
                        .HasForeignKey("EmployeeStatusId")
                        .HasConstraintName("FK__Employee__Employ__3A81B327");

                    b.Navigation("EmployeePosition");

                    b.Navigation("EmployeeStatus");
                });

            modelBuilder.Entity("Api.Models.Ingredient", b =>
                {
                    b.HasOne("Api.Models.Effect", "Effect")
                        .WithMany("Ingredients")
                        .HasForeignKey("EffectId")
                        .HasConstraintName("FK__Ingredien__Effec__44FF419A");

                    b.Navigation("Effect");
                });

            modelBuilder.Entity("Api.Models.Order", b =>
                {
                    b.HasOne("Api.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK__Order__CustomerI__49C3F6B7");

                    b.HasOne("Api.Models.OrderStatus", "OrderStatus")
                        .WithMany("Orders")
                        .HasForeignKey("OrderStatusId")
                        .HasConstraintName("FK__Order__OrderStat__4AB81AF0");

                    b.Navigation("Customer");

                    b.Navigation("OrderStatus");
                });

            modelBuilder.Entity("Api.Models.OrderIngredient", b =>
                {
                    b.HasOne("Api.Models.Ingredient", "Ingredient")
                        .WithMany("OrderIngredients")
                        .HasForeignKey("IngredientId")
                        .HasConstraintName("FK__OrderIngr__Ingre__5BE2A6F2");

                    b.HasOne("Api.Models.Order", "Order")
                        .WithMany("OrderIngredients")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK__OrderIngr__Order__5CD6CB2B");

                    b.Navigation("Ingredient");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Api.Models.OrderPotion", b =>
                {
                    b.HasOne("Api.Models.Order", "Order")
                        .WithMany("OrderPotions")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK__OrderPoti__Order__59063A47");

                    b.HasOne("Api.Models.Potion", "Potion")
                        .WithMany("OrderPotions")
                        .HasForeignKey("PotionId")
                        .HasConstraintName("FK__OrderPoti__Potio__5812160E");

                    b.Navigation("Order");

                    b.Navigation("Potion");
                });

            modelBuilder.Entity("Api.Models.Potion", b =>
                {
                    b.HasOne("Api.Models.Employee", "Employee")
                        .WithMany("Potions")
                        .HasForeignKey("EmployeeId")
                        .HasConstraintName("FK__Potion__Employee__5165187F");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Api.Models.PotionEffect", b =>
                {
                    b.HasOne("Api.Models.Effect", "Effect")
                        .WithMany("PotionEffects")
                        .HasForeignKey("EffectId")
                        .HasConstraintName("FK__PotionEff__Effec__5535A963");

                    b.HasOne("Api.Models.Potion", "Potion")
                        .WithMany("PotionEffects")
                        .HasForeignKey("PotionId")
                        .HasConstraintName("FK__PotionEff__Potio__5441852A");

                    b.Navigation("Effect");

                    b.Navigation("Potion");
                });

            modelBuilder.Entity("Api.Models.Receipt", b =>
                {
                    b.HasOne("Api.Models.Employee", "Employee")
                        .WithMany("Receipts")
                        .HasForeignKey("EmployeeId")
                        .HasConstraintName("FK__Receipt__Employe__4D94879B");

                    b.HasOne("Api.Models.Order", "Order")
                        .WithMany("Receipts")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK__Receipt__OrderId__4E88ABD4");

                    b.Navigation("Employee");

                    b.Navigation("Order");
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
                    b.HasOne("Api.Classes.AuthUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Api.Classes.AuthUser", null)
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

                    b.HasOne("Api.Classes.AuthUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Api.Classes.AuthUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Api.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Api.Models.CustomerStatus", b =>
                {
                    b.Navigation("Customers");
                });

            modelBuilder.Entity("Api.Models.Effect", b =>
                {
                    b.Navigation("Ingredients");

                    b.Navigation("PotionEffects");
                });

            modelBuilder.Entity("Api.Models.Employee", b =>
                {
                    b.Navigation("Potions");

                    b.Navigation("Receipts");
                });

            modelBuilder.Entity("Api.Models.EmployeePosition", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Api.Models.EmployeeStatus", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Api.Models.Ingredient", b =>
                {
                    b.Navigation("OrderIngredients");
                });

            modelBuilder.Entity("Api.Models.Order", b =>
                {
                    b.Navigation("OrderIngredients");

                    b.Navigation("OrderPotions");

                    b.Navigation("Receipts");
                });

            modelBuilder.Entity("Api.Models.OrderStatus", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Api.Models.Potion", b =>
                {
                    b.Navigation("OrderPotions");

                    b.Navigation("PotionEffects");
                });
#pragma warning restore 612, 618
        }
    }
}
