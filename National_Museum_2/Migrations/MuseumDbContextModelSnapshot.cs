﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using National_Museum_2.Context;

#nullable disable

namespace National_Museum_2.Migrations
{
    [DbContext(typeof(MuseumDbContext))]
    partial class MuseumDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("National_Museum_2.Model.ArtObject", b =>
                {
                    b.Property<int>("artObjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("artObjectId"));

                    b.Property<string>("artist")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("category_IdcategoryId")
                        .HasColumnType("int");

                    b.Property<string>("cost")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("creationDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("exhibition_IdexhibitionId")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("origin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("state_IdstateId")
                        .HasColumnType("int");

                    b.HasKey("artObjectId");

                    b.HasIndex("category_IdcategoryId");

                    b.HasIndex("exhibition_IdexhibitionId");

                    b.HasIndex("state_IdstateId");

                    b.ToTable("artObject");
                });

            modelBuilder.Entity("National_Museum_2.Model.ArtRoom", b =>
                {
                    b.Property<int>("artRoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("artRoomId"));

                    b.Property<int>("collection_IdcollectionId")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("location_IdlocationId")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numberExhibitions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("artRoomId");

                    b.HasIndex("collection_IdcollectionId");

                    b.HasIndex("location_IdlocationId");

                    b.ToTable("artRoom");
                });

            modelBuilder.Entity("National_Museum_2.Model.Category", b =>
                {
                    b.Property<int>("categoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("categoryId"));

                    b.Property<string>("category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("categoryId");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("National_Museum_2.Model.Collection", b =>
                {
                    b.Property<int>("collectionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("collectionId"));

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("collectionId");

                    b.ToTable("collection");
                });

            modelBuilder.Entity("National_Museum_2.Model.Contact", b =>
                {
                    b.Property<int>("contactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("contactId"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("contactType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("user_IduserId")
                        .HasColumnType("int");

                    b.HasKey("contactId");

                    b.HasIndex("user_IduserId");

                    b.ToTable("contact");
                });

            modelBuilder.Entity("National_Museum_2.Model.Employees", b =>
                {
                    b.Property<int>("employeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("employeeId"));

                    b.Property<int>("employeesXArtRoom_IdemployeesXArtRoomId")
                        .HasColumnType("int");

                    b.Property<DateTime>("hiringDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("maintenance_IdmaintenanceId")
                        .HasColumnType("int");

                    b.Property<int>("typeEmployee_IdtypeEmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("user_IduserId")
                        .HasColumnType("int");

                    b.Property<int>("workShedule_IdworkSheduleId")
                        .HasColumnType("int");

                    b.HasKey("employeeId");

                    b.HasIndex("employeesXArtRoom_IdemployeesXArtRoomId");

                    b.HasIndex("maintenance_IdmaintenanceId");

                    b.HasIndex("typeEmployee_IdtypeEmployeeId");

                    b.HasIndex("user_IduserId");

                    b.HasIndex("workShedule_IdworkSheduleId");

                    b.ToTable("employee");
                });

            modelBuilder.Entity("National_Museum_2.Model.EmployeesXArtRoom", b =>
                {
                    b.Property<int>("employeesXArtRoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("employeesXArtRoomId"));

                    b.Property<int>("artRoomId")
                        .HasColumnType("int");

                    b.Property<int>("employeeId")
                        .HasColumnType("int");

                    b.HasKey("employeesXArtRoomId");

                    b.HasIndex("artRoomId")
                        .IsUnique();

                    b.ToTable("employeesXArtRoom");
                });

            modelBuilder.Entity("National_Museum_2.Model.Exhibition", b =>
                {
                    b.Property<int>("exhibitionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("exhibitionId"));

                    b.Property<int>("artRoom_IdartRoomId")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("exhibitionId");

                    b.HasIndex("artRoom_IdartRoomId");

                    b.ToTable("exhibition");
                });

            modelBuilder.Entity("National_Museum_2.Model.Gender", b =>
                {
                    b.Property<int>("genderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("genderId"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("genderId");

                    b.ToTable("gender");
                });

            modelBuilder.Entity("National_Museum_2.Model.IdentificationType", b =>
                {
                    b.Property<int>("identificationTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("identificationTypeId"));

                    b.Property<string>("Identification_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("identificationTypeId");

                    b.ToTable("identificationType");
                });

            modelBuilder.Entity("National_Museum_2.Model.Location", b =>
                {
                    b.Property<int>("locationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("locationId"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("locationId");

                    b.ToTable("location");
                });

            modelBuilder.Entity("National_Museum_2.Model.Maintenance", b =>
                {
                    b.Property<int>("maintenanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("maintenanceId"));

                    b.Property<int>("artObject_IdartObjectId")
                        .HasColumnType("int");

                    b.Property<int>("cost")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("endDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("starDate")
                        .HasColumnType("datetime2");

                    b.HasKey("maintenanceId");

                    b.HasIndex("artObject_IdartObjectId");

                    b.ToTable("maintenance");
                });

            modelBuilder.Entity("National_Museum_2.Model.PaymentMethod", b =>
                {
                    b.Property<int>("paymentMethodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("paymentMethodId"));

                    b.Property<string>("paymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("paymentMethodId");

                    b.ToTable("paymentMethods");
                });

            modelBuilder.Entity("National_Museum_2.Model.PermissionXUserType", b =>
                {
                    b.Property<int>("permissionXUserTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("permissionXUserTypeId"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("userType_IduserTypeId")
                        .HasColumnType("int");

                    b.HasKey("permissionXUserTypeId");

                    b.HasIndex("userType_IduserTypeId");

                    b.ToTable("permissionXUserType");
                });

            modelBuilder.Entity("National_Museum_2.Model.Permissions", b =>
                {
                    b.Property<int>("permissionsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("permissionsId"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Permission")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PermissionXUserType_IdpermissionXUserTypeId")
                        .HasColumnType("int");

                    b.HasKey("permissionsId");

                    b.HasIndex("PermissionXUserType_IdpermissionXUserTypeId");

                    b.ToTable("permissions");
                });

            modelBuilder.Entity("National_Museum_2.Model.State", b =>
                {
                    b.Property<int>("stateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("stateId"));

                    b.Property<string>("state")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("stateId");

                    b.ToTable("state");
                });

            modelBuilder.Entity("National_Museum_2.Model.TicketType", b =>
                {
                    b.Property<int>("ticketTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ticketTypeId"));

                    b.Property<float>("price")
                        .HasColumnType("real");

                    b.Property<string>("ticketType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ticketTypeId");

                    b.ToTable("ticketType");
                });

            modelBuilder.Entity("National_Museum_2.Model.TicketXCollection", b =>
                {
                    b.Property<int>("ticketXCollectionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ticketXCollectionId"));

                    b.Property<int>("Ticket_Id")
                        .HasColumnType("int");

                    b.Property<int>("collection_IdcollectionId")
                        .HasColumnType("int");

                    b.HasKey("ticketXCollectionId");

                    b.HasIndex("collection_IdcollectionId");

                    b.ToTable("ticketXCollection");
                });

            modelBuilder.Entity("National_Museum_2.Model.Tickets", b =>
                {
                    b.Property<int>("ticketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ticketId"));

                    b.Property<int>("employeeId")
                        .HasColumnType("int");

                    b.Property<int>("paymentMethod_IdpaymentMethodId")
                        .HasColumnType("int");

                    b.Property<int>("ticketType_IdticketTypeId")
                        .HasColumnType("int");

                    b.Property<int>("ticketXCollection_IdticketXCollectionId")
                        .HasColumnType("int");

                    b.Property<int>("user_IduserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("visitDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ticketId");

                    b.HasIndex("paymentMethod_IdpaymentMethodId");

                    b.HasIndex("ticketType_IdticketTypeId");

                    b.HasIndex("ticketXCollection_IdticketXCollectionId");

                    b.HasIndex("user_IduserId");

                    b.ToTable("ticket");
                });

            modelBuilder.Entity("National_Museum_2.Model.TypeEmployee", b =>
                {
                    b.Property<int>("typeEmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("typeEmployeeId"));

                    b.Property<string>("typeEmployee")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("typeEmployeeId");

                    b.ToTable("typeEmployee");
                });

            modelBuilder.Entity("National_Museum_2.Model.User", b =>
                {
                    b.Property<int>("userId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("userId"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("birthDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("gender_IdgenderId")
                        .HasColumnType("int");

                    b.Property<string>("identificationNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("identificationType_IdidentificationTypeId")
                        .HasColumnType("int");

                    b.Property<string>("lastNames")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("names")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("user_Type_IduserTypeId")
                        .HasColumnType("int");

                    b.HasKey("userId");

                    b.HasIndex("gender_IdgenderId");

                    b.HasIndex("identificationType_IdidentificationTypeId");

                    b.HasIndex("user_Type_IduserTypeId");

                    b.ToTable("user");
                });

            modelBuilder.Entity("National_Museum_2.Model.UserType", b =>
                {
                    b.Property<int>("userTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("userTypeId"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("userType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("userTypeId");

                    b.ToTable("userType");
                });

            modelBuilder.Entity("National_Museum_2.Model.WorkShedule", b =>
                {
                    b.Property<int>("workSheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("workSheduleId"));

                    b.Property<string>("workShedule")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("workSheduleId");

                    b.ToTable("workShedule");
                });

            modelBuilder.Entity("National_Museum_2.Model.ArtObject", b =>
                {
                    b.HasOne("National_Museum_2.Model.Category", "category_Id")
                        .WithMany()
                        .HasForeignKey("category_IdcategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("National_Museum_2.Model.Exhibition", "exhibition_Id")
                        .WithMany()
                        .HasForeignKey("exhibition_IdexhibitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("National_Museum_2.Model.State", "state_Id")
                        .WithMany()
                        .HasForeignKey("state_IdstateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category_Id");

                    b.Navigation("exhibition_Id");

                    b.Navigation("state_Id");
                });

            modelBuilder.Entity("National_Museum_2.Model.ArtRoom", b =>
                {
                    b.HasOne("National_Museum_2.Model.Collection", "collection_Id")
                        .WithMany()
                        .HasForeignKey("collection_IdcollectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("National_Museum_2.Model.Location", "location_Id")
                        .WithMany()
                        .HasForeignKey("location_IdlocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("collection_Id");

                    b.Navigation("location_Id");
                });

            modelBuilder.Entity("National_Museum_2.Model.Contact", b =>
                {
                    b.HasOne("National_Museum_2.Model.User", "user_Id")
                        .WithMany()
                        .HasForeignKey("user_IduserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user_Id");
                });

            modelBuilder.Entity("National_Museum_2.Model.Employees", b =>
                {
                    b.HasOne("National_Museum_2.Model.EmployeesXArtRoom", "employeesXArtRoom_Id")
                        .WithMany()
                        .HasForeignKey("employeesXArtRoom_IdemployeesXArtRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("National_Museum_2.Model.Maintenance", "maintenance_Id")
                        .WithMany()
                        .HasForeignKey("maintenance_IdmaintenanceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("National_Museum_2.Model.TypeEmployee", "typeEmployee_Id")
                        .WithMany()
                        .HasForeignKey("typeEmployee_IdtypeEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("National_Museum_2.Model.User", "user_Id")
                        .WithMany()
                        .HasForeignKey("user_IduserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("National_Museum_2.Model.WorkShedule", "workShedule_Id")
                        .WithMany()
                        .HasForeignKey("workShedule_IdworkSheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("employeesXArtRoom_Id");

                    b.Navigation("maintenance_Id");

                    b.Navigation("typeEmployee_Id");

                    b.Navigation("user_Id");

                    b.Navigation("workShedule_Id");
                });

            modelBuilder.Entity("National_Museum_2.Model.EmployeesXArtRoom", b =>
                {
                    b.HasOne("National_Museum_2.Model.ArtRoom", null)
                        .WithOne("employeesXArtRoom_Id")
                        .HasForeignKey("National_Museum_2.Model.EmployeesXArtRoom", "artRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("National_Museum_2.Model.Exhibition", b =>
                {
                    b.HasOne("National_Museum_2.Model.ArtRoom", "artRoom_Id")
                        .WithMany()
                        .HasForeignKey("artRoom_IdartRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("artRoom_Id");
                });

            modelBuilder.Entity("National_Museum_2.Model.Maintenance", b =>
                {
                    b.HasOne("National_Museum_2.Model.ArtObject", "artObject_Id")
                        .WithMany()
                        .HasForeignKey("artObject_IdartObjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("artObject_Id");
                });

            modelBuilder.Entity("National_Museum_2.Model.PermissionXUserType", b =>
                {
                    b.HasOne("National_Museum_2.Model.UserType", "userType_Id")
                        .WithMany()
                        .HasForeignKey("userType_IduserTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("userType_Id");
                });

            modelBuilder.Entity("National_Museum_2.Model.Permissions", b =>
                {
                    b.HasOne("National_Museum_2.Model.PermissionXUserType", "PermissionXUserType_Id")
                        .WithMany()
                        .HasForeignKey("PermissionXUserType_IdpermissionXUserTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PermissionXUserType_Id");
                });

            modelBuilder.Entity("National_Museum_2.Model.TicketXCollection", b =>
                {
                    b.HasOne("National_Museum_2.Model.Collection", "collection_Id")
                        .WithMany()
                        .HasForeignKey("collection_IdcollectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("collection_Id");
                });

            modelBuilder.Entity("National_Museum_2.Model.Tickets", b =>
                {
                    b.HasOne("National_Museum_2.Model.PaymentMethod", "paymentMethod_Id")
                        .WithMany()
                        .HasForeignKey("paymentMethod_IdpaymentMethodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("National_Museum_2.Model.TicketType", "ticketType_Id")
                        .WithMany()
                        .HasForeignKey("ticketType_IdticketTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("National_Museum_2.Model.TicketXCollection", "ticketXCollection_Id")
                        .WithMany()
                        .HasForeignKey("ticketXCollection_IdticketXCollectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("National_Museum_2.Model.User", "user_Id")
                        .WithMany()
                        .HasForeignKey("user_IduserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("paymentMethod_Id");

                    b.Navigation("ticketType_Id");

                    b.Navigation("ticketXCollection_Id");

                    b.Navigation("user_Id");
                });

            modelBuilder.Entity("National_Museum_2.Model.User", b =>
                {
                    b.HasOne("National_Museum_2.Model.Gender", "gender_Id")
                        .WithMany()
                        .HasForeignKey("gender_IdgenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("National_Museum_2.Model.IdentificationType", "identificationType_Id")
                        .WithMany()
                        .HasForeignKey("identificationType_IdidentificationTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("National_Museum_2.Model.UserType", "user_Type_Id")
                        .WithMany()
                        .HasForeignKey("user_Type_IduserTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("gender_Id");

                    b.Navigation("identificationType_Id");

                    b.Navigation("user_Type_Id");
                });

            modelBuilder.Entity("National_Museum_2.Model.ArtRoom", b =>
                {
                    b.Navigation("employeesXArtRoom_Id")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
