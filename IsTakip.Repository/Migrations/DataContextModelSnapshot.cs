﻿// <auto-generated />
using System;
using IsTakip.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IsTakip.Repository.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("IsTakip.Core.Classes.DepoClasses.Depo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Aktif")
                        .HasColumnType("bit");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("GuncelleyenKullaniciId")
                        .HasColumnType("int");

                    b.Property<int?>("OlusturanKullaniciId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Silindi")
                        .HasColumnType("bit");

                    b.Property<string>("Tanim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Yetkili")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YetkiliTelefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Depolar");
                });

            modelBuilder.Entity("IsTakip.Core.Classes.DepoClasses.DepoEnvanter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Adet")
                        .HasColumnType("int");

                    b.Property<decimal>("Agirlik")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Boy")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("DepoId")
                        .HasColumnType("int");

                    b.Property<int>("DepoRafId")
                        .HasColumnType("int");

                    b.Property<decimal>("En")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("KalinlikId")
                        .HasColumnType("int");

                    b.Property<int>("MalzemeTipId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepoId")
                        .IsUnique();

                    b.HasIndex("DepoRafId")
                        .IsUnique();

                    b.HasIndex("KalinlikId")
                        .IsUnique();

                    b.HasIndex("MalzemeTipId")
                        .IsUnique();

                    b.ToTable("DepoEnvanterler");
                });

            modelBuilder.Entity("IsTakip.Core.Classes.DepoClasses.DepoRaf", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tanim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DepoRaflar");
                });

            modelBuilder.Entity("IsTakip.Core.Classes.DepoClasses.Kalinlik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tanim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kalinliklar");
                });

            modelBuilder.Entity("IsTakip.Core.Classes.DepoClasses.MalzemeTip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tanim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MalzemeTipler");
                });

            modelBuilder.Entity("IsTakip.Core.Classes.IsClasses.Is", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Aktif")
                        .HasColumnType("bit");

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("GuncelleyenKullaniciId")
                        .HasColumnType("int");

                    b.Property<bool>("IsBitimindeBildir")
                        .HasColumnType("bit");

                    b.Property<string>("IsNotu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IsOnceligi")
                        .HasColumnType("int");

                    b.Property<bool>("Iscilik")
                        .HasColumnType("bit");

                    b.Property<int>("KalinlikId")
                        .HasColumnType("int");

                    b.Property<string>("MalzemeNotu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MalzemeTipId")
                        .HasColumnType("int");

                    b.Property<int>("MusteriId")
                        .HasColumnType("int");

                    b.Property<string>("MusteriSiparisNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OlusturanKullaniciId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Silindi")
                        .HasColumnType("bit");

                    b.Property<string>("TeklifNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Teklifli")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Termin")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("KalinlikId")
                        .IsUnique();

                    b.HasIndex("MalzemeTipId")
                        .IsUnique();

                    b.HasIndex("MusteriId")
                        .IsUnique();

                    b.ToTable("Isler");
                });

            modelBuilder.Entity("IsTakip.Core.Classes.IsClasses.IsDosya", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DosyaAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IsId")
                        .IsUnique();

                    b.ToTable("IsDosyalar");
                });

            modelBuilder.Entity("IsTakip.Core.Classes.KullaniciClasses.Kullanici", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Aktif")
                        .HasColumnType("bit");

                    b.Property<string>("KullaniciKodu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KullaniciSifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MailBildirim")
                        .HasColumnType("bit");

                    b.Property<int?>("MusteriId")
                        .HasColumnType("int");

                    b.Property<string>("RolTanim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Silindi")
                        .HasColumnType("bit");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kullanicilar");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Ad = "Admin",
                            Aktif = true,
                            KullaniciKodu = "4DM1N",
                            KullaniciSifre = "123456",
                            MailBildirim = false,
                            RolTanim = "Yönetici",
                            Silindi = false,
                            Soyad = "Admin"
                        });
                });

            modelBuilder.Entity("IsTakip.Core.Classes.Mail.MailParametre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Aktif")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("GuncelleyenKullaniciId")
                        .HasColumnType("int");

                    b.Property<int?>("OlusturanKullaniciId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SSLKullan")
                        .HasColumnType("bit");

                    b.Property<string>("SenderName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Silindi")
                        .HasColumnType("bit");

                    b.Property<string>("SmtpAdres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SmtpPort")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MailParametreleri");
                });

            modelBuilder.Entity("IsTakip.Core.Classes.MusteriClasses.Ajanda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Aktif")
                        .HasColumnType("bit");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("GuncelleyenKullaniciId")
                        .HasColumnType("int");

                    b.Property<int>("MusteriId")
                        .HasColumnType("int");

                    b.Property<DateTime>("NotTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int?>("OlusturanKullaniciId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Silindi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("MusteriId")
                        .IsUnique();

                    b.ToTable("Ajandalar");
                });

            modelBuilder.Entity("IsTakip.Core.Classes.MusteriClasses.Musteri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Aktif")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("GuncelleyenKullaniciId")
                        .HasColumnType("int");

                    b.Property<int>("MusteriKisitlamaId")
                        .HasColumnType("int");

                    b.Property<int>("MusteriSinifId")
                        .HasColumnType("int");

                    b.Property<int>("MusteriTemsilcisiId")
                        .HasColumnType("int");

                    b.Property<int?>("OlusturanKullaniciId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Silindi")
                        .HasColumnType("bit");

                    b.Property<string>("Tanim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VergiDairesi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VergiNumarasi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MusteriSinifId");

                    b.HasIndex("MusteriTemsilcisiId");

                    b.ToTable("Musteriler");
                });

            modelBuilder.Entity("IsTakip.Core.Classes.MusteriClasses.MusteriKisitlama", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("IslemAciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Kisitlama")
                        .HasColumnType("bit");

                    b.Property<int>("MusteriId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MusteriId")
                        .IsUnique();

                    b.ToTable("MusteriKisitlamalar");
                });

            modelBuilder.Entity("IsTakip.Core.Classes.MusteriClasses.MusteriSinif", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Aktif")
                        .HasColumnType("bit");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("GuncelleyenKullaniciId")
                        .HasColumnType("int");

                    b.Property<int?>("OlusturanKullaniciId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Silindi")
                        .HasColumnType("bit");

                    b.Property<string>("Tanim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MusteriSiniflar");
                });

            modelBuilder.Entity("IsTakip.Core.Classes.MusteriClasses.MusteriTemsilcisi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Aktif")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("GuncelleyenKullaniciId")
                        .HasColumnType("int");

                    b.Property<int?>("OlusturanKullaniciId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Silindi")
                        .HasColumnType("bit");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelefonNumarasi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MusteriTemsilciler");
                });

            modelBuilder.Entity("IsTakip.Core.Classes.TedarikciClasses.Tedarikci", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Aktif")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("GuncelleyenKullaniciId")
                        .HasColumnType("int");

                    b.Property<int?>("OlusturanKullaniciId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Silindi")
                        .HasColumnType("bit");

                    b.Property<string>("Tanim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tedarikciler");
                });

            modelBuilder.Entity("IsTakip.Core.Classes.UretimClasses.DurusTip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tanim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DurusTipler");
                });

            modelBuilder.Entity("IsTakip.Core.Classes.UretimClasses.UretimDurus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Aktif")
                        .HasColumnType("bit");

                    b.Property<int>("DurusSuresi")
                        .HasColumnType("int");

                    b.Property<int>("DurusTipId")
                        .HasColumnType("int");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("GuncelleyenKullaniciId")
                        .HasColumnType("int");

                    b.Property<int?>("OlusturanKullaniciId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Silindi")
                        .HasColumnType("bit");

                    b.Property<int>("UretimEmriId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DurusTipId")
                        .IsUnique();

                    b.HasIndex("UretimEmriId")
                        .IsUnique();

                    b.ToTable("UretimDuruslar");
                });

            modelBuilder.Entity("IsTakip.Core.Classes.UretimClasses.UretimEmri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Aktif")
                        .HasColumnType("bit");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("GuncelleyenKullaniciId")
                        .HasColumnType("int");

                    b.Property<DateTime>("IsEmriTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsId")
                        .HasColumnType("int");

                    b.Property<int?>("OlusturanKullaniciId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Silindi")
                        .HasColumnType("bit");

                    b.Property<int?>("ToplamDurusSuresi")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UretimBaslamaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("UretimDurum")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UretimTamamlanmaTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IsId")
                        .IsUnique();

                    b.ToTable("UretimEmirler");
                });

            modelBuilder.Entity("IsTakip.Core.Classes.DepoClasses.DepoEnvanter", b =>
                {
                    b.HasOne("IsTakip.Core.Classes.DepoClasses.Depo", "Depo")
                        .WithOne("DepoEnvanter")
                        .HasForeignKey("IsTakip.Core.Classes.DepoClasses.DepoEnvanter", "DepoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IsTakip.Core.Classes.DepoClasses.DepoRaf", "DepoRaf")
                        .WithOne("DepoEnvanter")
                        .HasForeignKey("IsTakip.Core.Classes.DepoClasses.DepoEnvanter", "DepoRafId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("IsTakip.Core.Classes.DepoClasses.Kalinlik", "Kalinlik")
                        .WithOne("DepoEnvanter")
                        .HasForeignKey("IsTakip.Core.Classes.DepoClasses.DepoEnvanter", "KalinlikId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("IsTakip.Core.Classes.DepoClasses.MalzemeTip", "MalzemeTip")
                        .WithOne("DepoEnvanter")
                        .HasForeignKey("IsTakip.Core.Classes.DepoClasses.DepoEnvanter", "MalzemeTipId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Depo");

                    b.Navigation("DepoRaf");

                    b.Navigation("Kalinlik");

                    b.Navigation("MalzemeTip");
                });

            modelBuilder.Entity("IsTakip.Core.Classes.IsClasses.Is", b =>
                {
                    b.HasOne("IsTakip.Core.Classes.DepoClasses.Kalinlik", "Kalinlik")
                        .WithOne("Is")
                        .HasForeignKey("IsTakip.Core.Classes.IsClasses.Is", "KalinlikId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("IsTakip.Core.Classes.DepoClasses.MalzemeTip", "MalzemeTip")
                        .WithOne("Is")
                        .HasForeignKey("IsTakip.Core.Classes.IsClasses.Is", "MalzemeTipId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("IsTakip.Core.Classes.MusteriClasses.Musteri", "Musteri")
                        .WithOne("Is")
                        .HasForeignKey("IsTakip.Core.Classes.IsClasses.Is", "MusteriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kalinlik");

                    b.Navigation("MalzemeTip");

                    b.Navigation("Musteri");
                });

            modelBuilder.Entity("IsTakip.Core.Classes.IsClasses.IsDosya", b =>
                {
                    b.HasOne("IsTakip.Core.Classes.IsClasses.Is", "Is")
                        .WithOne("IsDosya")
                        .HasForeignKey("IsTakip.Core.Classes.IsClasses.IsDosya", "IsId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Is");
                });

            modelBuilder.Entity("IsTakip.Core.Classes.MusteriClasses.Ajanda", b =>
                {
                    b.HasOne("IsTakip.Core.Classes.MusteriClasses.Musteri", "Musteri")
                        .WithOne("Ajanda")
                        .HasForeignKey("IsTakip.Core.Classes.MusteriClasses.Ajanda", "MusteriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Musteri");
                });

            modelBuilder.Entity("IsTakip.Core.Classes.MusteriClasses.Musteri", b =>
                {
                    b.HasOne("IsTakip.Core.Classes.MusteriClasses.MusteriSinif", "MusteriSinif")
                        .WithMany("Musteriler")
                        .HasForeignKey("MusteriSinifId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("IsTakip.Core.Classes.MusteriClasses.MusteriTemsilcisi", "MusteriTemsilcisi")
                        .WithMany("Musteriler")
                        .HasForeignKey("MusteriTemsilcisiId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("MusteriSinif");

                    b.Navigation("MusteriTemsilcisi");
                });

            modelBuilder.Entity("IsTakip.Core.Classes.MusteriClasses.MusteriKisitlama", b =>
                {
                    b.HasOne("IsTakip.Core.Classes.MusteriClasses.Musteri", "Musteri")
                        .WithOne("MusteriKisitlama")
                        .HasForeignKey("IsTakip.Core.Classes.MusteriClasses.MusteriKisitlama", "MusteriId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Musteri");
                });

            modelBuilder.Entity("IsTakip.Core.Classes.UretimClasses.UretimDurus", b =>
                {
                    b.HasOne("IsTakip.Core.Classes.UretimClasses.DurusTip", "DurusTip")
                        .WithOne("UretimDurus")
                        .HasForeignKey("IsTakip.Core.Classes.UretimClasses.UretimDurus", "DurusTipId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IsTakip.Core.Classes.UretimClasses.UretimEmri", "UretimEmri")
                        .WithOne("UretimDurus")
                        .HasForeignKey("IsTakip.Core.Classes.UretimClasses.UretimDurus", "UretimEmriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DurusTip");

                    b.Navigation("UretimEmri");
                });

            modelBuilder.Entity("IsTakip.Core.Classes.UretimClasses.UretimEmri", b =>
                {
                    b.HasOne("IsTakip.Core.Classes.IsClasses.Is", "Is")
                        .WithOne("UretimEmri")
                        .HasForeignKey("IsTakip.Core.Classes.UretimClasses.UretimEmri", "IsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Is");
                });

            modelBuilder.Entity("IsTakip.Core.Classes.DepoClasses.Depo", b =>
                {
                    b.Navigation("DepoEnvanter");
                });

            modelBuilder.Entity("IsTakip.Core.Classes.DepoClasses.DepoRaf", b =>
                {
                    b.Navigation("DepoEnvanter");
                });

            modelBuilder.Entity("IsTakip.Core.Classes.DepoClasses.Kalinlik", b =>
                {
                    b.Navigation("DepoEnvanter");

                    b.Navigation("Is");
                });

            modelBuilder.Entity("IsTakip.Core.Classes.DepoClasses.MalzemeTip", b =>
                {
                    b.Navigation("DepoEnvanter");

                    b.Navigation("Is");
                });

            modelBuilder.Entity("IsTakip.Core.Classes.IsClasses.Is", b =>
                {
                    b.Navigation("IsDosya");

                    b.Navigation("UretimEmri");
                });

            modelBuilder.Entity("IsTakip.Core.Classes.MusteriClasses.Musteri", b =>
                {
                    b.Navigation("Ajanda");

                    b.Navigation("Is");

                    b.Navigation("MusteriKisitlama");
                });

            modelBuilder.Entity("IsTakip.Core.Classes.MusteriClasses.MusteriSinif", b =>
                {
                    b.Navigation("Musteriler");
                });

            modelBuilder.Entity("IsTakip.Core.Classes.MusteriClasses.MusteriTemsilcisi", b =>
                {
                    b.Navigation("Musteriler");
                });

            modelBuilder.Entity("IsTakip.Core.Classes.UretimClasses.DurusTip", b =>
                {
                    b.Navigation("UretimDurus");
                });

            modelBuilder.Entity("IsTakip.Core.Classes.UretimClasses.UretimEmri", b =>
                {
                    b.Navigation("UretimDurus");
                });
#pragma warning restore 612, 618
        }
    }
}
