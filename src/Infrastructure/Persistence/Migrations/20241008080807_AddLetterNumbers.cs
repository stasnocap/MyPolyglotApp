using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddLetterNumbers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LetterNumbers",
                schema: "practice",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Number = table.Column<int>(type: "integer", nullable: false),
                    Text = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LetterNumbers", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "practice",
                table: "LetterNumbers",
                columns: new[] { "Id", "Number", "Text" },
                values: new object[,]
                {
                    { new Guid("007e1cc4-4403-4c5c-8a6d-d6b62b964b1d"), 39, "thirty-nine" },
                    { new Guid("01046733-a412-4c24-815c-2a68dee2cf20"), 30, "thirty" },
                    { new Guid("01d35dd1-71d8-4a14-99ce-a48ecbebf689"), 61, "sixty-one" },
                    { new Guid("0255269d-6498-43d9-8aae-3ab1110fd028"), 52, "fifty-two" },
                    { new Guid("02f6a04b-8ed7-4b05-9a3d-564b81edf7ed"), 6, "six" },
                    { new Guid("03e8727d-68ae-425c-990e-9d4896b4d451"), 42, "forty-two" },
                    { new Guid("04b42253-9ef9-48ee-acc8-5734fde1ff70"), 11, "eleven" },
                    { new Guid("08111950-4e88-467a-8c28-3dc848d78f8e"), 32, "thirty-two" },
                    { new Guid("0868f9fa-0038-4292-9bf1-d924519310c4"), 70, "seventy" },
                    { new Guid("0b078125-628b-4352-8e89-620c85f2b03d"), 24, "twenty-four" },
                    { new Guid("0e1bffde-e29f-451e-ab86-a289fb036fc3"), 86, "eighty-six" },
                    { new Guid("0f3c2978-043e-471c-926c-f1e57b56a810"), 80, "eighty" },
                    { new Guid("1107d8c7-61e4-45f2-a17f-3186852a51fd"), 29, "twenty-nine" },
                    { new Guid("11c740ab-5b7b-49b9-9211-fe0befb8a4aa"), 26, "twenty-six" },
                    { new Guid("11caac34-9fa4-469d-aa02-549edcfe39d6"), 65, "sixty-five" },
                    { new Guid("135736d0-8177-4328-9ca3-86712e973f0e"), 36, "thirty-six" },
                    { new Guid("15353a5d-f508-4248-b5a8-abf3b01932d1"), 16, "sixteen" },
                    { new Guid("1b01ce84-b2f1-442d-8a14-52f598653d43"), 46, "forty-six" },
                    { new Guid("1dce1bfe-29f7-4617-aa28-763e0ed98037"), 66, "sixty-six" },
                    { new Guid("1eaab961-feb8-4a6a-a23f-2b77a577b3f6"), 8, "eight" },
                    { new Guid("1f82d796-520c-4527-98ec-84ea883d5b1a"), 95, "ninety-five" },
                    { new Guid("22052436-99b3-49d0-8e70-1a84c654ed0e"), 83, "eighty-three" },
                    { new Guid("2454aea7-4a69-49ac-9433-629d7c881573"), 50, "fifty" },
                    { new Guid("25fc39d2-0ac8-41b0-9a64-f786282252d0"), 53, "fifty-three" },
                    { new Guid("269baed0-35f9-4609-982e-3fe12aa9ab53"), 48, "forty-eight" },
                    { new Guid("2757998a-de32-437a-892c-d9415f071ef3"), 69, "sixty-nine" },
                    { new Guid("2b18ad8e-9f6c-450b-847e-0aafb398dd2a"), 73, "seventy-three" },
                    { new Guid("34c74263-c160-4960-bc8b-0903d225481c"), 55, "fifty-five" },
                    { new Guid("35cf48bb-6018-4cd8-83c6-618b678a3c80"), 40, "forty" },
                    { new Guid("37626cac-43ea-49fa-85d4-9d4dd4c376d8"), 89, "eighty-nine" },
                    { new Guid("39b0f634-0de8-43db-8d50-650109f1341d"), 3, "three" },
                    { new Guid("3a905451-6596-4c9a-ae48-0b2e4ca6bac9"), 78, "seventy-eight" },
                    { new Guid("3e70c5de-cf66-415c-a09e-c968d4f3a9a5"), 68, "sixty-eight" },
                    { new Guid("3ee0734b-2893-4018-8727-bf42ef307120"), 97, "ninety-seven" },
                    { new Guid("3f417c1d-b53c-42a1-8fa0-8d7d5733570f"), 23, "twenty-three" },
                    { new Guid("40ef9508-9b6d-480f-8b8f-ee0f9a85f252"), 47, "forty-seven" },
                    { new Guid("421029dc-7a27-436d-ab00-c235ac380e4a"), 21, "twenty-one" },
                    { new Guid("42cff7d8-51c4-4aed-b4c9-9da6829b8bf2"), 5, "five" },
                    { new Guid("4860b06c-6dd7-4f6a-9ca1-0d4f9a007576"), 67, "sixty-seven" },
                    { new Guid("4a0da1f4-b538-4227-93b5-c631d9de651a"), 10, "ten" },
                    { new Guid("4cf2f685-ac7f-4bc3-8939-9b594cbde698"), 9, "nine" },
                    { new Guid("4dcbc5ff-80c6-469e-b307-007194ceb16d"), 82, "eighty-two" },
                    { new Guid("4ebfa152-e905-4f41-9378-3e8620115ba3"), 81, "eighty-one" },
                    { new Guid("4f0bfbac-3c80-425c-8b4f-857a6c8fecd1"), 33, "thirty-three" },
                    { new Guid("553b5338-715f-4950-afc8-e7954e39c5d3"), 96, "ninety-six" },
                    { new Guid("55e71bb3-b2cb-43d1-9ee8-f22ccc38f548"), 34, "thirty-four" },
                    { new Guid("572f7ff0-fedd-489b-92d7-dc0bc227463c"), 98, "ninety-eight" },
                    { new Guid("5c91a43f-8cee-482f-bf73-a4a7c4f62ec8"), 43, "forty-three" },
                    { new Guid("5d9b8aeb-e17e-4ba9-a373-753332c93ffc"), 87, "eighty-seven" },
                    { new Guid("60692ba5-80f6-4940-aceb-962e398ea161"), 37, "thirty-seven" },
                    { new Guid("61281bcd-4e84-4a5d-a002-394a4b3cf303"), 94, "ninety-four" },
                    { new Guid("617cae68-ce4d-4d69-bcbd-d9618d6fc449"), 76, "seventy-six" },
                    { new Guid("639a3054-40bf-4c07-adb1-73269f1e021d"), 59, "fifty-nine" },
                    { new Guid("669879fa-9081-4c08-b54e-64bce8ab0f79"), 72, "seventy-two" },
                    { new Guid("684fd478-6f63-4ee2-bd45-9c11fb1cc736"), 19, "nineteen" },
                    { new Guid("68c7c1d4-b663-4cb7-8725-97c3d3d94bc2"), 85, "eighty-five" },
                    { new Guid("6b09d505-80c6-4186-aa53-710320abb10f"), 1, "one" },
                    { new Guid("729ba1f8-52b1-4b6a-bf38-9cf51996c0e9"), 28, "twenty-eight" },
                    { new Guid("78211122-72b5-4ca0-a42b-a4801ef54db3"), 45, "forty-five" },
                    { new Guid("80060c39-93d8-491e-be01-f2953dad6789"), 60, "sixty" },
                    { new Guid("834314e8-14bb-41fa-acb5-73afa141c4cf"), 18, "eighteen" },
                    { new Guid("83fa51b9-5bcb-463d-9db4-9e1a5da28ef5"), 71, "seventy-one" },
                    { new Guid("8435914c-28f3-4df1-b561-0d99011cb85c"), 75, "seventy-five" },
                    { new Guid("8551febd-fd92-4c57-9e19-1f3d0ab86712"), 93, "ninety-three" },
                    { new Guid("8589ecea-2987-4ea1-a301-f5b2541b5e76"), 84, "eighty-four" },
                    { new Guid("8757fac7-89fd-4032-a444-1f2cd87718cd"), 57, "fifty-seven" },
                    { new Guid("896e0ff6-667a-4128-ba04-f26e98f5fc75"), 20, "twenty" },
                    { new Guid("8a498a60-30a0-4f79-b777-137a2a0b691c"), 79, "seventy-nine" },
                    { new Guid("8fba2cb3-307e-407d-8eec-f80aebb2bfcd"), 17, "seventeen" },
                    { new Guid("93dc9095-495f-4b6e-8039-066890870a0c"), 62, "sixty-two" },
                    { new Guid("94de0b1c-52b5-4085-98b7-653e62e1f975"), 7, "seven" },
                    { new Guid("9a29c102-a93d-47a9-98d8-6336b1ff17ff"), 27, "twenty-seven" },
                    { new Guid("a6fa3fce-9967-4a97-b11d-331c1b1e9dc4"), 63, "sixty-three" },
                    { new Guid("ac0950de-887f-4435-9f7d-1ef57956556b"), 54, "fifty-four" },
                    { new Guid("b8b02125-232f-4b11-b7e0-591b0403aa9b"), 4, "four" },
                    { new Guid("b917daf0-33ea-41ba-abd5-ecff4d5b0d31"), 64, "sixty-four" },
                    { new Guid("ba67dc5b-4d46-4594-bd01-7c93c7f75426"), 15, "fifteen" },
                    { new Guid("c046da85-260e-4957-9386-450f8e61559c"), 38, "thirty-eight" },
                    { new Guid("c07f3eec-b8d6-4a1e-9718-af39c6c13ae8"), 92, "ninety-two" },
                    { new Guid("ca09d016-14c5-453a-8bf4-bf9740206cdf"), 49, "forty-nine" },
                    { new Guid("cf423234-f663-4210-aaa9-b0aae93ba656"), 14, "fourteen" },
                    { new Guid("cfc00c0a-8caa-47fc-bc82-3538ed003c37"), 58, "fifty-eight" },
                    { new Guid("d0e65ed5-a4eb-49dc-8252-efb269fb3b9b"), 12, "twelve" },
                    { new Guid("d4718aef-13ba-4e92-a194-afce949975e9"), 41, "forty-one" },
                    { new Guid("d5df26d6-7436-4536-8242-0140182dc075"), 25, "twenty-five" },
                    { new Guid("da00dbd2-04af-479a-9c8b-6bce0fc10e08"), 88, "eighty-eight" },
                    { new Guid("dc6bf804-430c-44c3-86eb-5fa260394800"), 51, "fifty-one" },
                    { new Guid("de13aaf7-26de-49c9-a85d-30f75b33b31f"), 22, "twenty-two" },
                    { new Guid("df39a80b-4cbe-4b43-b577-7d0b588eac5e"), 74, "seventy-four" },
                    { new Guid("e0a48aaa-2a6e-42c9-9b18-2eed32bbcac3"), 99, "ninety-nine" },
                    { new Guid("e0b9229e-af33-415a-91e3-3efdca665c19"), 90, "ninety" },
                    { new Guid("ec005fcd-89a1-40f4-a4ba-de08e226ee55"), 35, "thirty-five" },
                    { new Guid("ec6fbb46-bfef-490a-afd0-f677b303c0f3"), 91, "ninety-one" },
                    { new Guid("eeda83b1-4243-419e-95c8-4a652616019f"), 31, "thirty-one" },
                    { new Guid("f1f0fe79-ec14-4513-9d70-c12d29f75f28"), 13, "thirteen" },
                    { new Guid("f2ec932a-5cbc-47d6-b194-6f351f465a93"), 44, "forty-four" },
                    { new Guid("f45f2ec4-6080-4a1a-a401-1e7da8d83138"), 56, "fifty-six" },
                    { new Guid("f948b80e-cb25-47d3-8f6f-0dc6461dbdd8"), 77, "seventy-seven" },
                    { new Guid("fa968d49-9ca7-45d0-aff8-9d89ed0772b8"), 2, "two" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LetterNumbers",
                schema: "practice");
        }
    }
}
