using Microsoft.EntityFrameworkCore.Migrations;

namespace TestMvcApp.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "BannerUrl", "Description", "Name", "Slug" },
                values: new object[,]
                {
                    { 1, "610eac01-ed19-4f6f-a513-f4e5faca1cb2_banner1.jpg", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam quod labore asperiores minima corporis possimus accusantium odit eveniet quia itaque voluptatem voluptate sequi, officia quos praesentium placeat similique iusto iure.", "Sample Post 2", "sample-post-1" },
                    { 2, "610eac01-ed19-4f6f-a513-f4e5faca1cb2_banner1.jpg", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam quod labore asperiores minima corporis possimus accusantium odit eveniet quia itaque voluptatem voluptate sequi, officia quos praesentium placeat similique iusto iure.", "Sample Post 1", "sample-post-1" },
                    { 3, "610eac01-ed19-4f6f-a513-f4e5faca1cb2_banner1.jpg", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam quod labore asperiores minima corporis possimus accusantium odit eveniet quia itaque voluptatem voluptate sequi, officia quos praesentium placeat similique iusto iure.", "Sample Post 3", "sample-post-1" },
                    { 4, "610eac01-ed19-4f6f-a513-f4e5faca1cb2_banner1.jpg", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam quod labore asperiores minima corporis possimus accusantium odit eveniet quia itaque voluptatem voluptate sequi, officia quos praesentium placeat similique iusto iure.", "Sample Post 4", "sample-post-1" },
                    { 5, "610eac01-ed19-4f6f-a513-f4e5faca1cb2_banner1.jpg", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam quod labore asperiores minima corporis possimus accusantium odit eveniet quia itaque voluptatem voluptate sequi, officia quos praesentium placeat similique iusto iure.", "Sample Post 5", "sample-post-1" },
                    { 6, "610eac01-ed19-4f6f-a513-f4e5faca1cb2_banner1.jpg", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam quod labore asperiores minima corporis possimus accusantium odit eveniet quia itaque voluptatem voluptate sequi, officia quos praesentium placeat similique iusto iure.", "Sample Post 6", "sample-post-1" },
                    { 7, "610eac01-ed19-4f6f-a513-f4e5faca1cb2_banner1.jpg", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam quod labore asperiores minima corporis possimus accusantium odit eveniet quia itaque voluptatem voluptate sequi, officia quos praesentium placeat similique iusto iure.", "Sample Post 7", "sample-post-1" },
                    { 8, "610eac01-ed19-4f6f-a513-f4e5faca1cb2_banner1.jpg", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam quod labore asperiores minima corporis possimus accusantium odit eveniet quia itaque voluptatem voluptate sequi, officia quos praesentium placeat similique iusto iure.", "Sample Post 8", "sample-post-1" },
                    { 9, "610eac01-ed19-4f6f-a513-f4e5faca1cb2_banner1.jpg", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam quod labore asperiores minima corporis possimus accusantium odit eveniet quia itaque voluptatem voluptate sequi, officia quos praesentium placeat similique iusto iure.", "Sample Post 9", "sample-post-1" },
                    { 10, "610eac01-ed19-4f6f-a513-f4e5faca1cb2_banner1.jpg", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam quod labore asperiores minima corporis possimus accusantium odit eveniet quia itaque voluptatem voluptate sequi, officia quos praesentium placeat similique iusto iure.", "Sample Post 10", "sample-post-1" },
                    { 11, "610eac01-ed19-4f6f-a513-f4e5faca1cb2_banner1.jpg", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam quod labore asperiores minima corporis possimus accusantium odit eveniet quia itaque voluptatem voluptate sequi, officia quos praesentium placeat similique iusto iure.", "Sample Post 11", "sample-post-1" },
                    { 12, "610eac01-ed19-4f6f-a513-f4e5faca1cb2_banner1.jpg", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam quod labore asperiores minima corporis possimus accusantium odit eveniet quia itaque voluptatem voluptate sequi, officia quos praesentium placeat similique iusto iure.", "Sample Post 12", "sample-post-1" },
                    { 13, "610eac01-ed19-4f6f-a513-f4e5faca1cb2_banner1.jpg", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam quod labore asperiores minima corporis possimus accusantium odit eveniet quia itaque voluptatem voluptate sequi, officia quos praesentium placeat similique iusto iure.", "Sample Post 14", "sample-post-1" },
                    { 14, "610eac01-ed19-4f6f-a513-f4e5faca1cb2_banner1.jpg", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam quod labore asperiores minima corporis possimus accusantium odit eveniet quia itaque voluptatem voluptate sequi, officia quos praesentium placeat similique iusto iure.", "Sample Post 14", "sample-post-1" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14);
        }
    }
}
