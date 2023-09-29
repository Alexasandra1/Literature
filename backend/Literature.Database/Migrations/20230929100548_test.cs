using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Literature.Database.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            //migrationBuilder.CreateTable(
            //    name: "Books",
            //    schema: "dbo",
            //    columns: table => new
            //    {
            //        BookId = table.Column<int>(type: "integer", nullable: false)
            //            .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            //        TitleBook = table.Column<string>(type: "text", nullable: false),
            //        DescriptionBook = table.Column<string>(type: "text", nullable: true),
            //        NumberOfChapter = table.Column<int>(type: "integer", nullable: true),
            //        Type = table.Column<string>(type: "text", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Books", x => x.BookId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Genres",
            //    schema: "dbo",
            //    columns: table => new
            //    {
            //        GenreId = table.Column<int>(type: "integer", nullable: false)
            //            .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            //        GenreName = table.Column<string>(type: "text", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Genres", x => x.GenreId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "RoleClaims",
            //    schema: "dbo",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "integer", nullable: false)
            //            .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            //        RoleId = table.Column<string>(type: "text", nullable: true),
            //        ClaimType = table.Column<string>(type: "text", nullable: true),
            //        ClaimValue = table.Column<string>(type: "text", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_RoleClaims", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Roles",
            //    schema: "dbo",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(type: "text", nullable: false),
            //        Name = table.Column<string>(type: "text", nullable: true),
            //        NormalizedName = table.Column<string>(type: "text", nullable: true),
            //        ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Roles", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "UserClaims",
            //    schema: "dbo",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "integer", nullable: false)
            //            .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            //        UserId = table.Column<string>(type: "text", nullable: true),
            //        ClaimType = table.Column<string>(type: "text", nullable: true),
            //        ClaimValue = table.Column<string>(type: "text", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_UserClaims", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "UserLogins",
            //    schema: "dbo",
            //    columns: table => new
            //    {
            //        UserId = table.Column<string>(type: "text", nullable: false),
            //        LoginProvider = table.Column<string>(type: "text", nullable: false),
            //        ProviderKey = table.Column<string>(type: "text", nullable: false),
            //        ProviderDisplayName = table.Column<string>(type: "text", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_UserLogins", x => x.UserId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Users",
            //    schema: "dbo",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(type: "text", nullable: false),
            //        FirstName = table.Column<string>(type: "text", nullable: false),
            //        UserName = table.Column<string>(type: "text", nullable: true),
            //        NormalizedUserName = table.Column<string>(type: "text", nullable: true),
            //        Email = table.Column<string>(type: "text", nullable: true),
            //        NormalizedEmail = table.Column<string>(type: "text", nullable: true),
            //        EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
            //        PasswordHash = table.Column<string>(type: "text", nullable: true),
            //        SecurityStamp = table.Column<string>(type: "text", nullable: true),
            //        ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
            //        PhoneNumber = table.Column<string>(type: "text", nullable: true),
            //        PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
            //        TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
            //        LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
            //        LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
            //        AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Users", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "UserTokens",
            //    schema: "dbo",
            //    columns: table => new
            //    {
            //        UserId = table.Column<string>(type: "text", nullable: false),
            //        LoginProvider = table.Column<string>(type: "text", nullable: false),
            //        Name = table.Column<string>(type: "text", nullable: false),
            //        Value = table.Column<string>(type: "text", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_UserTokens", x => x.UserId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "BookGenre",
            //    schema: "dbo",
            //    columns: table => new
            //    {
            //        BooksBookId = table.Column<int>(type: "integer", nullable: false),
            //        GenresGenreId = table.Column<int>(type: "integer", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_BookGenre", x => new { x.BooksBookId, x.GenresGenreId });
            //        table.ForeignKey(
            //            name: "FK_BookGenre_Books_BooksBookId",
            //            column: x => x.BooksBookId,
            //            principalSchema: "dbo",
            //            principalTable: "Books",
            //            principalColumn: "BookId",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_BookGenre_Genres_GenresGenreId",
            //            column: x => x.GenresGenreId,
            //            principalSchema: "dbo",
            //            principalTable: "Genres",
            //            principalColumn: "GenreId",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "BookUser",
            //    schema: "dbo",
            //    columns: table => new
            //    {
            //        BooksBookId = table.Column<int>(type: "integer", nullable: false),
            //        UsersId = table.Column<string>(type: "text", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_BookUser", x => new { x.BooksBookId, x.UsersId });
            //        table.ForeignKey(
            //            name: "FK_BookUser_Books_BooksBookId",
            //            column: x => x.BooksBookId,
            //            principalSchema: "dbo",
            //            principalTable: "Books",
            //            principalColumn: "BookId",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_BookUser_Users_UsersId",
            //            column: x => x.UsersId,
            //            principalSchema: "dbo",
            //            principalTable: "Users",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Comments",
            //    schema: "dbo",
            //    columns: table => new
            //    {
            //        CommentId = table.Column<int>(type: "integer", nullable: false)
            //            .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            //        DateOfComment = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
            //        TextComment = table.Column<string>(type: "text", nullable: false),
            //        UserId = table.Column<string>(type: "text", nullable: false),
            //        BookId = table.Column<int>(type: "integer", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Comments", x => x.CommentId);
            //        table.ForeignKey(
            //            name: "FK_Comments_Books_BookId",
            //            column: x => x.BookId,
            //            principalSchema: "dbo",
            //            principalTable: "Books",
            //            principalColumn: "BookId",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_Comments_Users_UserId",
            //            column: x => x.UserId,
            //            principalSchema: "dbo",
            //            principalTable: "Users",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Discussions",
            //    schema: "dbo",
            //    columns: table => new
            //    {
            //        DiscussionId = table.Column<int>(type: "integer", nullable: false)
            //            .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            //        DateOfDiscussion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
            //        Topic = table.Column<string>(type: "text", nullable: false),
            //        TextDiscussion = table.Column<string>(type: "text", nullable: true),
            //        UserId = table.Column<string>(type: "text", nullable: false),
            //        BookId = table.Column<int>(type: "integer", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Discussions", x => x.DiscussionId);
            //        table.ForeignKey(
            //            name: "FK_Discussions_Books_BookId",
            //            column: x => x.BookId,
            //            principalSchema: "dbo",
            //            principalTable: "Books",
            //            principalColumn: "BookId");
            //        table.ForeignKey(
            //            name: "FK_Discussions_Users_UserId",
            //            column: x => x.UserId,
            //            principalSchema: "dbo",
            //            principalTable: "Users",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "News",
            //    schema: "dbo",
            //    columns: table => new
            //    {
            //        NewId = table.Column<int>(type: "integer", nullable: false)
            //            .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            //        DateOfNew = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
            //        NameOfNew = table.Column<string>(type: "text", nullable: false),
            //        NewDescription = table.Column<string>(type: "text", nullable: false),
            //        UserId = table.Column<string>(type: "text", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_News", x => x.NewId);
            //        table.ForeignKey(
            //            name: "FK_News_Users_UserId",
            //            column: x => x.UserId,
            //            principalSchema: "dbo",
            //            principalTable: "Users",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "UserRoles",
            //    schema: "dbo",
            //    columns: table => new
            //    {
            //        UserId = table.Column<string>(type: "text", nullable: false),
            //        RoleId = table.Column<string>(type: "text", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
            //        table.ForeignKey(
            //            name: "FK_UserRoles_Roles_RoleId",
            //            column: x => x.RoleId,
            //            principalSchema: "dbo",
            //            principalTable: "Roles",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_UserRoles_Users_UserId",
            //            column: x => x.UserId,
            //            principalSchema: "dbo",
            //            principalTable: "Users",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Answers",
            //    schema: "dbo",
            //    columns: table => new
            //    {
            //        AnswerId = table.Column<int>(type: "integer", nullable: false)
            //            .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            //        AnswerText = table.Column<string>(type: "text", nullable: false),
            //        DateOfAnswer = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
            //        UserId = table.Column<string>(type: "text", nullable: false),
            //        DiscussionId = table.Column<int>(type: "integer", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Answers", x => x.AnswerId);
            //        table.ForeignKey(
            //            name: "FK_Answers_Discussions_DiscussionId",
            //            column: x => x.DiscussionId,
            //            principalSchema: "dbo",
            //            principalTable: "Discussions",
            //            principalColumn: "DiscussionId",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_Answers_Users_UserId",
            //            column: x => x.UserId,
            //            principalSchema: "dbo",
            //            principalTable: "Users",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Answers_DiscussionId",
            //    schema: "dbo",
            //    table: "Answers",
            //    column: "DiscussionId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Answers_UserId",
            //    schema: "dbo",
            //    table: "Answers",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_BookGenre_GenresGenreId",
            //    schema: "dbo",
            //    table: "BookGenre",
            //    column: "GenresGenreId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_BookUser_UsersId",
            //    schema: "dbo",
            //    table: "BookUser",
            //    column: "UsersId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Comments_BookId",
            //    schema: "dbo",
            //    table: "Comments",
            //    column: "BookId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Comments_UserId",
            //    schema: "dbo",
            //    table: "Comments",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Discussions_BookId",
            //    schema: "dbo",
            //    table: "Discussions",
            //    column: "BookId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Discussions_UserId",
            //    schema: "dbo",
            //    table: "Discussions",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_News_UserId",
            //    schema: "dbo",
            //    table: "News",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_UserRoles_RoleId",
            //    schema: "dbo",
            //    table: "UserRoles",
            //    column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "BookGenre",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "BookUser",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Comments",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "News",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "RoleClaims",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "UserClaims",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "UserLogins",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "UserRoles",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "UserTokens",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Discussions",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Genres",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Roles",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Books",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "dbo");
        }
    }
}
