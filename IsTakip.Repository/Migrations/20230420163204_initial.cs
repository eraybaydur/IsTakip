using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IsTakip.Repository.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Depolar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yetkili = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YetkiliTelefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depolar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DepoRaflar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepoRaflar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DurusTipler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DurusTipler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kalinliklar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kalinliklar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MusteriId = table.Column<int>(type: "int", nullable: true),
                    KullaniciKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullaniciSifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MailBildirim = table.Column<bool>(type: "bit", nullable: false),
                    RolTanim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MailParametreleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SmtpAdres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SmtpPort = table.Column<int>(type: "int", nullable: false),
                    SSLKullan = table.Column<bool>(type: "bit", nullable: false),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailParametreleri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MalzemeTipler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MalzemeTipler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MusteriKisitlamalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IslemAciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kisitlama = table.Column<bool>(type: "bit", nullable: false),
                    MusteriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusteriKisitlamalar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MusteriSiniflar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusteriSiniflar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MusteriTemsilciler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriId = table.Column<int>(type: "int", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefonNumarasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusteriTemsilciler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tedarikciler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tedarikciler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DepoEnvanterler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepoId = table.Column<int>(type: "int", nullable: false),
                    DepoRafId = table.Column<int>(type: "int", nullable: false),
                    MalzemeTipId = table.Column<int>(type: "int", nullable: false),
                    KalinlikId = table.Column<int>(type: "int", nullable: false),
                    En = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Boy = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Adet = table.Column<int>(type: "int", nullable: false),
                    Agirlik = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepoEnvanterler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DepoEnvanterler_Depolar_DepoId",
                        column: x => x.DepoId,
                        principalTable: "Depolar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepoEnvanterler_DepoRaflar_DepoRafId",
                        column: x => x.DepoRafId,
                        principalTable: "DepoRaflar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DepoEnvanterler_Kalinliklar_KalinlikId",
                        column: x => x.KalinlikId,
                        principalTable: "Kalinliklar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DepoEnvanterler_MalzemeTipler_MalzemeTipId",
                        column: x => x.MalzemeTipId,
                        principalTable: "MalzemeTipler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Musteriler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MusteriSinifId = table.Column<int>(type: "int", nullable: false),
                    MusteriKisitlamaId = table.Column<int>(type: "int", nullable: false),
                    MusteriTemsilcisiId = table.Column<int>(type: "int", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VergiDairesi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VergiNumarasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteriler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Musteriler_MusteriKisitlamalar_MusteriKisitlamaId",
                        column: x => x.MusteriKisitlamaId,
                        principalTable: "MusteriKisitlamalar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Musteriler_MusteriSiniflar_MusteriSinifId",
                        column: x => x.MusteriSinifId,
                        principalTable: "MusteriSiniflar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Musteriler_MusteriTemsilciler_MusteriTemsilcisiId",
                        column: x => x.MusteriTemsilcisiId,
                        principalTable: "MusteriTemsilciler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Ajandalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriId = table.Column<int>(type: "int", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ajandalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ajandalar_Musteriler_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "Musteriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Isler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriId = table.Column<int>(type: "int", nullable: false),
                    Teklifli = table.Column<bool>(type: "bit", nullable: false),
                    TeklifNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsBitimindeBildir = table.Column<bool>(type: "bit", nullable: false),
                    Termin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsOnceligi = table.Column<int>(type: "int", nullable: false),
                    MusteriSiparisNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsNotu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MalzemeTipId = table.Column<int>(type: "int", nullable: false),
                    KalinlikId = table.Column<int>(type: "int", nullable: false),
                    Iscilik = table.Column<bool>(type: "bit", nullable: false),
                    MalzemeNotu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Isler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Isler_Kalinliklar_KalinlikId",
                        column: x => x.KalinlikId,
                        principalTable: "Kalinliklar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Isler_MalzemeTipler_MalzemeTipId",
                        column: x => x.MalzemeTipId,
                        principalTable: "MalzemeTipler",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Isler_Musteriler_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "Musteriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IsDosyalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsId = table.Column<int>(type: "int", nullable: false),
                    DosyaAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsDosyalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IsDosyalar_Isler_IsId",
                        column: x => x.IsId,
                        principalTable: "Isler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UretimEmirler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsId = table.Column<int>(type: "int", nullable: false),
                    IsEmriTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToplamDurusSuresi = table.Column<int>(type: "int", nullable: true),
                    UretimBaslamaTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UretimTamamlanmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UretimDurum = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UretimEmirler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UretimEmirler_Isler_IsId",
                        column: x => x.IsId,
                        principalTable: "Isler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UretimDuruslar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UretimEmriId = table.Column<int>(type: "int", nullable: false),
                    DurusSuresi = table.Column<int>(type: "int", nullable: false),
                    DurusTipId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UretimDuruslar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UretimDuruslar_DurusTipler_DurusTipId",
                        column: x => x.DurusTipId,
                        principalTable: "DurusTipler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UretimDuruslar_UretimEmirler_UretimEmriId",
                        column: x => x.UretimEmriId,
                        principalTable: "UretimEmirler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Kullanicilar",
                columns: new[] { "Id", "Ad", "Aktif", "KullaniciKodu", "KullaniciSifre", "MailBildirim", "MusteriId", "RolTanim", "Silindi", "Soyad" },
                values: new object[] { -1, "Admin", true, "4DM1N", "123456", false, null, "Yönetici", false, "Admin" });

            migrationBuilder.CreateIndex(
                name: "IX_Ajandalar_MusteriId",
                table: "Ajandalar",
                column: "MusteriId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DepoEnvanterler_DepoId",
                table: "DepoEnvanterler",
                column: "DepoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DepoEnvanterler_DepoRafId",
                table: "DepoEnvanterler",
                column: "DepoRafId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DepoEnvanterler_KalinlikId",
                table: "DepoEnvanterler",
                column: "KalinlikId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DepoEnvanterler_MalzemeTipId",
                table: "DepoEnvanterler",
                column: "MalzemeTipId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_IsDosyalar_IsId",
                table: "IsDosyalar",
                column: "IsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Isler_KalinlikId",
                table: "Isler",
                column: "KalinlikId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Isler_MalzemeTipId",
                table: "Isler",
                column: "MalzemeTipId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Isler_MusteriId",
                table: "Isler",
                column: "MusteriId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Musteriler_MusteriKisitlamaId",
                table: "Musteriler",
                column: "MusteriKisitlamaId");

            migrationBuilder.CreateIndex(
                name: "IX_Musteriler_MusteriSinifId",
                table: "Musteriler",
                column: "MusteriSinifId");

            migrationBuilder.CreateIndex(
                name: "IX_Musteriler_MusteriTemsilcisiId",
                table: "Musteriler",
                column: "MusteriTemsilcisiId");

            migrationBuilder.CreateIndex(
                name: "IX_UretimDuruslar_DurusTipId",
                table: "UretimDuruslar",
                column: "DurusTipId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UretimDuruslar_UretimEmriId",
                table: "UretimDuruslar",
                column: "UretimEmriId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UretimEmirler_IsId",
                table: "UretimEmirler",
                column: "IsId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ajandalar");

            migrationBuilder.DropTable(
                name: "DepoEnvanterler");

            migrationBuilder.DropTable(
                name: "IsDosyalar");

            migrationBuilder.DropTable(
                name: "Kullanicilar");

            migrationBuilder.DropTable(
                name: "MailParametreleri");

            migrationBuilder.DropTable(
                name: "Tedarikciler");

            migrationBuilder.DropTable(
                name: "UretimDuruslar");

            migrationBuilder.DropTable(
                name: "Depolar");

            migrationBuilder.DropTable(
                name: "DepoRaflar");

            migrationBuilder.DropTable(
                name: "DurusTipler");

            migrationBuilder.DropTable(
                name: "UretimEmirler");

            migrationBuilder.DropTable(
                name: "Isler");

            migrationBuilder.DropTable(
                name: "Kalinliklar");

            migrationBuilder.DropTable(
                name: "MalzemeTipler");

            migrationBuilder.DropTable(
                name: "Musteriler");

            migrationBuilder.DropTable(
                name: "MusteriKisitlamalar");

            migrationBuilder.DropTable(
                name: "MusteriSiniflar");

            migrationBuilder.DropTable(
                name: "MusteriTemsilciler");
        }
    }
}
