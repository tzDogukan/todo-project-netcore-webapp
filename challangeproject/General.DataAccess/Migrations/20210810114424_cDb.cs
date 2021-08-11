using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace General.DataAccess.Migrations
{
    public partial class cDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CreateUserCarts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreateUserCarts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "userTask",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Priority = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fileUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userTask", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MyComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BackLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Star = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActiveStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateUserCartId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MyComments_CreateUserCarts_CreateUserCartId",
                        column: x => x.CreateUserCartId,
                        principalTable: "CreateUserCarts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MyDropBoxes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DropItemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IpAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DropItemFile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataLimits = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActiveStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateUserCartId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyDropBoxes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MyDropBoxes_CreateUserCarts_CreateUserCartId",
                        column: x => x.CreateUserCartId,
                        principalTable: "CreateUserCarts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MyTasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Task = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActiveStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateUserCartId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MyTasks_CreateUserCarts_CreateUserCartId",
                        column: x => x.CreateUserCartId,
                        principalTable: "CreateUserCarts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAdresLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdresTuru = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ulke = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sehir = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Semt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mahalle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostaKodu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcikAdres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActiveStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateUserCartId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAdresLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAdresLists_CreateUserCarts_CreateUserCartId",
                        column: x => x.CreateUserCartId,
                        principalTable: "CreateUserCarts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserContents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateUserCartId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserContents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserContents_CreateUserCarts_CreateUserCartId",
                        column: x => x.CreateUserCartId,
                        principalTable: "CreateUserCarts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserNotifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descriptions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActiveStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateUserCartId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserNotifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserNotifications_CreateUserCarts_CreateUserCartId",
                        column: x => x.CreateUserCartId,
                        principalTable: "CreateUserCarts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRegisterFiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    File1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    File2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    File3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    File4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    File5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateUserCartId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRegisterFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRegisterFiles_CreateUserCarts_CreateUserCartId",
                        column: x => x.CreateUserCartId,
                        principalTable: "CreateUserCarts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MyComments_CreateUserCartId",
                table: "MyComments",
                column: "CreateUserCartId");

            migrationBuilder.CreateIndex(
                name: "IX_MyDropBoxes_CreateUserCartId",
                table: "MyDropBoxes",
                column: "CreateUserCartId");

            migrationBuilder.CreateIndex(
                name: "IX_MyTasks_CreateUserCartId",
                table: "MyTasks",
                column: "CreateUserCartId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAdresLists_CreateUserCartId",
                table: "UserAdresLists",
                column: "CreateUserCartId");

            migrationBuilder.CreateIndex(
                name: "IX_UserContents_CreateUserCartId",
                table: "UserContents",
                column: "CreateUserCartId");

            migrationBuilder.CreateIndex(
                name: "IX_UserNotifications_CreateUserCartId",
                table: "UserNotifications",
                column: "CreateUserCartId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRegisterFiles_CreateUserCartId",
                table: "UserRegisterFiles",
                column: "CreateUserCartId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyComments");

            migrationBuilder.DropTable(
                name: "MyDropBoxes");

            migrationBuilder.DropTable(
                name: "MyTasks");

            migrationBuilder.DropTable(
                name: "UserAdresLists");

            migrationBuilder.DropTable(
                name: "UserContents");

            migrationBuilder.DropTable(
                name: "UserNotifications");

            migrationBuilder.DropTable(
                name: "UserRegisterFiles");

            migrationBuilder.DropTable(
                name: "userTask");

            migrationBuilder.DropTable(
                name: "CreateUserCarts");
        }
    }
}
