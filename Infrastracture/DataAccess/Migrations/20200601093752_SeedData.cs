using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastracture.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "BlogId", "Rating" },
                values: new object[] { 1, 5 });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "BlogId", "Content", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Some scientific title 1" },
                    { 2, 1, "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).", "Some scientific title 2" },
                    { 3, 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed eu turpis vitae felis mattis finibus. Duis a erat ac elit iaculis pellentesque quis congue justo. Nam ut velit vitae orci ullamcorper consequat. Pellentesque eget velit non tellus lobortis tempus. Curabitur egestas libero vitae lacus ullamcorper maximus. Suspendisse nisl justo, sollicitudin sit amet quam id, rhoncus pellentesque arcu. Pellentesque at magna mi. Maecenas a maximus orci. Proin a ipsum eu ante accumsan interdum ut at lacus. Nam nibh tellus, tincidunt imperdiet arcu sed, venenatis sollicitudin sem. Curabitur quis facilisis velit. Curabitur ornare ultricies mauris, a blandit quam ultricies quis. Donec lobortis, diam ac pulvinar facilisis, ipsum velit interdum nisi, sit amet laoreet est eros elementum justo. In hac habitasse platea dictumst.", "Some scientific title 3" },
                    { 4, 1, "Vestibulum ut tellus vulputate, pretium nunc ac, ultrices diam. Vivamus non egestas lectus, ac ultricies quam. Pellentesque ac ex in magna pellentesque volutpat quis scelerisque elit. Aliquam erat volutpat. Aliquam ac consequat neque. Nulla eros urna, egestas nec metus id, aliquet consectetur urna. Maecenas tempor nibh et convallis congue. Donec eu mi fermentum, congue sapien nec, malesuada leo. Praesent nec nunc hendrerit quam malesuada semper sit amet eget augue. Ut laoreet rutrum nunc, quis lacinia lacus pellentesque gravida. Vivamus luctus magna in mauris interdum, vitae rhoncus lacus ornare. Cras sagittis cursus magna, quis mattis orci lacinia a.", "Some scientific title 4" },
                    { 5, 1, "Maecenas dapibus turpis ut risus tincidunt placerat ut sit amet dui. Vivamus eget elit non quam efficitur tristique nec id velit. Nunc in rhoncus libero. Proin nec ante nunc. Donec ac erat elit. Nunc blandit diam tortor, accumsan elementum sem facilisis vel. Donec nec consequat neque. Integer ultrices pulvinar lacus. Nam id dignissim turpis, ac iaculis ex. Donec sit amet pulvinar nunc. Vivamus hendrerit, ligula a pharetra dapibus, mauris tortor condimentum eros, nec lacinia odio ante malesuada elit. Nunc eleifend fringilla odio, sit amet posuere urna aliquet vel. Quisque in eros in mauris suscipit cursus. Proin ligula erat, luctus a viverra sit amet, finibus vel quam. Fusce egestas luctus leo, ut dictum sapien.", "Some scientific title 5" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "BlogId",
                keyValue: 1);
        }
    }
}
