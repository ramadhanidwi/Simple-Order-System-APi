﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Simple_Order_System_APi.Contexts;

#nullable disable

namespace Simple_Order_System_APi.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Simple_Order_System_APi.Models.Account", b =>
                {
                    b.Property<string>("EmployeeId")
                        .HasColumnType("nchar(5)")
                        .HasColumnName("employee_id");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("password");

                    b.HasKey("EmployeeId");

                    b.ToTable("tb_m_accounts");
                });

            modelBuilder.Entity("Simple_Order_System_APi.Models.AccountRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AccountId")
                        .IsRequired()
                        .HasColumnType("nchar(5)")
                        .HasColumnName("account_id");

                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("role_id");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("RoleId");

                    b.ToTable("tb_tr_account_roles");
                });

            modelBuilder.Entity("Simple_Order_System_APi.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address1")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("address1");

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("address2");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("city");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("country");

                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasColumnType("nchar(5)")
                        .HasColumnName("employee_id");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("last_name");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("phone");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("postal_code");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("state");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("tb_m_customers");
                });

            modelBuilder.Entity("Simple_Order_System_APi.Models.Employee", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nchar(5)")
                        .HasColumnName("id");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("first_name");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("job_title");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("last_name");

                    b.Property<int>("OfficeCode")
                        .HasColumnType("int")
                        .HasColumnName("office_code");

                    b.Property<string>("ReportsTo")
                        .HasColumnType("nchar(5)")
                        .HasColumnName("reports_to");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("OfficeCode");

                    b.HasIndex("ReportsTo");

                    b.ToTable("tb_m_employees");
                });

            modelBuilder.Entity("Simple_Order_System_APi.Models.Office", b =>
                {
                    b.Property<int>("Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("code");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Code"));

                    b.Property<string>("Address1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("address1");

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("address2");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("city");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("country");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("phone");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("postal_code");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("state");

                    b.HasKey("Code");

                    b.ToTable("tb_m_offices");
                });

            modelBuilder.Entity("Simple_Order_System_APi.Models.Order", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nchar(11)")
                        .HasColumnName("id");

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("comments");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("customer_id");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("order_date");

                    b.Property<DateTime>("ShippedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("shipped_date");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("tb_m_orders");
                });

            modelBuilder.Entity("Simple_Order_System_APi.Models.OrderProduct", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nchar(11)")
                        .HasColumnName("id");

                    b.Property<string>("OrderId")
                        .IsRequired()
                        .HasColumnType("nchar(11)")
                        .HasColumnName("order_id");

                    b.Property<int>("PriceEach")
                        .HasColumnType("int")
                        .HasColumnName("price_each");

                    b.Property<int>("ProductCode")
                        .HasColumnType("int")
                        .HasColumnName("product_code");

                    b.Property<int>("Qty")
                        .HasColumnType("int")
                        .HasColumnName("qty");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductCode");

                    b.ToTable("tb_tr_order_products");
                });

            modelBuilder.Entity("Simple_Order_System_APi.Models.Payment", b =>
                {
                    b.Property<string>("CheckNum")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("check_num");

                    b.Property<int>("Amount")
                        .HasColumnType("int")
                        .HasColumnName("amount");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("customer_id");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("payment_date");

                    b.HasKey("CheckNum");

                    b.HasIndex("CustomerId");

                    b.ToTable("tb_m_payments");
                });

            modelBuilder.Entity("Simple_Order_System_APi.Models.Product", b =>
                {
                    b.Property<int>("Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("code");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Code"));

                    b.Property<int>("BuyPrice")
                        .HasColumnType("int")
                        .HasColumnName("buy_price");

                    b.Property<string>("MSRP")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("msrp");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("name");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("pdt_description");

                    b.Property<int>("ProductlineId")
                        .HasColumnType("int")
                        .HasColumnName("productline_id");

                    b.Property<int>("QtyInStock")
                        .HasColumnType("int")
                        .HasColumnName("qty_in_stock");

                    b.Property<int>("Scale")
                        .HasColumnType("int")
                        .HasColumnName("scale");

                    b.Property<string>("Vendor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("vendor");

                    b.HasKey("Code");

                    b.HasIndex("ProductlineId");

                    b.ToTable("tb_m_products");
                });

            modelBuilder.Entity("Simple_Order_System_APi.Models.ProductLine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("tb_m_productlines");
                });

            modelBuilder.Entity("Simple_Order_System_APi.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("tb_m_role");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "User"
                        });
                });

            modelBuilder.Entity("Simple_Order_System_APi.Models.Account", b =>
                {
                    b.HasOne("Simple_Order_System_APi.Models.Employee", "Employee")
                        .WithOne("Account")
                        .HasForeignKey("Simple_Order_System_APi.Models.Account", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Simple_Order_System_APi.Models.AccountRole", b =>
                {
                    b.HasOne("Simple_Order_System_APi.Models.Account", "Account")
                        .WithMany("AccountRoles")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Simple_Order_System_APi.Models.Role", "Role")
                        .WithMany("AccountRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Simple_Order_System_APi.Models.Customer", b =>
                {
                    b.HasOne("Simple_Order_System_APi.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Simple_Order_System_APi.Models.Employee", b =>
                {
                    b.HasOne("Simple_Order_System_APi.Models.Office", "Office")
                        .WithMany("Employees")
                        .HasForeignKey("OfficeCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Simple_Order_System_APi.Models.Employee", "ReportTo")
                        .WithMany("Employees")
                        .HasForeignKey("ReportsTo")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Office");

                    b.Navigation("ReportTo");
                });

            modelBuilder.Entity("Simple_Order_System_APi.Models.Order", b =>
                {
                    b.HasOne("Simple_Order_System_APi.Models.Customer", "customer")
                        .WithMany("orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("customer");
                });

            modelBuilder.Entity("Simple_Order_System_APi.Models.OrderProduct", b =>
                {
                    b.HasOne("Simple_Order_System_APi.Models.Order", "order")
                        .WithMany("orderProducts")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Simple_Order_System_APi.Models.Product", "product")
                        .WithMany()
                        .HasForeignKey("ProductCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("order");

                    b.Navigation("product");
                });

            modelBuilder.Entity("Simple_Order_System_APi.Models.Payment", b =>
                {
                    b.HasOne("Simple_Order_System_APi.Models.Customer", "customer")
                        .WithMany("payments")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("customer");
                });

            modelBuilder.Entity("Simple_Order_System_APi.Models.Product", b =>
                {
                    b.HasOne("Simple_Order_System_APi.Models.ProductLine", "ProductLine")
                        .WithMany("Products")
                        .HasForeignKey("ProductlineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductLine");
                });

            modelBuilder.Entity("Simple_Order_System_APi.Models.Account", b =>
                {
                    b.Navigation("AccountRoles");
                });

            modelBuilder.Entity("Simple_Order_System_APi.Models.Customer", b =>
                {
                    b.Navigation("orders");

                    b.Navigation("payments");
                });

            modelBuilder.Entity("Simple_Order_System_APi.Models.Employee", b =>
                {
                    b.Navigation("Account");

                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Simple_Order_System_APi.Models.Office", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Simple_Order_System_APi.Models.Order", b =>
                {
                    b.Navigation("orderProducts");
                });

            modelBuilder.Entity("Simple_Order_System_APi.Models.ProductLine", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Simple_Order_System_APi.Models.Role", b =>
                {
                    b.Navigation("AccountRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
