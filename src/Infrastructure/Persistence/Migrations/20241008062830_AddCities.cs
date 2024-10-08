using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddCities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                schema: "practice",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "practice",
                table: "Cities",
                columns: new[] { "Id", "Text" },
                values: new object[,]
                {
                    { new Guid("004e1489-47fc-42d5-b64b-973d22792703"), "shenzhen" },
                    { new Guid("00d87649-e848-45b1-87d7-7a8caa57bef7"), "honolulu" },
                    { new Guid("00fba333-8a13-4180-937e-34accb4c96d2"), "heraklion" },
                    { new Guid("0217ca8b-a9d6-4ea1-b13a-2e905616bd8d"), "quito" },
                    { new Guid("02db7066-6020-4097-bd0b-06153a4b9d9f"), "kolkata" },
                    { new Guid("02ffe2cf-76e8-434d-8978-0531086da81d"), "auckland" },
                    { new Guid("0458e481-64d6-4446-bab0-0b255b87f14c"), "jeju" },
                    { new Guid("04a0a5cb-3f3f-4ce1-8130-dab87a736116"), "istanbul" },
                    { new Guid("09006d2d-30a7-4f1c-be93-e0e8df119635"), "durban" },
                    { new Guid("0cfe4419-a010-448b-a074-aa44f1019dcf"), "rome" },
                    { new Guid("0f0bf4d4-91e3-4613-8ba9-e378d8e722da"), "athens" },
                    { new Guid("1239dfd2-a03c-4e29-b5ea-c5a6667e751f"), "bangalore" },
                    { new Guid("12aae4af-77fc-40ef-9586-0ced382f4737"), "berlin" },
                    { new Guid("147e1912-38db-4a44-9905-20d1e8787bbe"), "denpasar" },
                    { new Guid("16e13ea0-3614-4068-b583-b0c19ed91856"), "hurghada" },
                    { new Guid("1cd0f9dd-a6ec-41f8-968e-59984671001d"), "chicago" },
                    { new Guid("211f4b1d-f082-472d-af62-096ebd07af03"), "osaka" },
                    { new Guid("217c5228-554d-40e5-ba7a-3c4aa44f72b6"), "dammam" },
                    { new Guid("2197793b-0ac2-4cdf-a594-cd6408f6a257"), "pattaya" },
                    { new Guid("237775bd-b5cf-4565-8d60-255b01c8c82c"), "geneva" },
                    { new Guid("288e3e2e-85b1-4fc0-8962-31385368f62e"), "stockholm" },
                    { new Guid("299f8056-6ff8-413d-8547-99861911b5b2"), "cairo" },
                    { new Guid("2b91063b-1dae-4fc8-8b36-3043b56a44e7"), "jaipur" },
                    { new Guid("2c54f958-f8b8-4d2a-874c-25127b9c55cd"), "agra" },
                    { new Guid("2c74f26c-ccd6-4464-b843-26ca5fef0801"), "san francisco" },
                    { new Guid("2d11b8c4-0565-4fd8-ae98-616c03f51d85"), "dublin" },
                    { new Guid("2e808832-8c5b-4d33-8952-4857221651d8"), "kyoto" },
                    { new Guid("2eb4968e-6094-4863-af50-f8b3f963bae8"), "bangkok" },
                    { new Guid("31a79e07-e061-463d-9ade-623e7d3e710f"), "saint petersburg" },
                    { new Guid("31f6225d-bedd-4c21-bce5-f27866e06001"), "sofia" },
                    { new Guid("32076951-2dca-4f5f-8b80-4cbc51b7048f"), "fukuoka" },
                    { new Guid("324cbf57-43a1-45b8-80b8-438a43a87f49"), "pune" },
                    { new Guid("334a7510-0bd7-44bb-84e4-0930ede3bf71"), "beirut" },
                    { new Guid("397454c6-3a76-4b73-b6c1-3c0056641c9c"), "cape town" },
                    { new Guid("3c13e5a2-2e26-46c4-af1c-cf380274a8a6"), "hong kong" },
                    { new Guid("3c51135c-c844-41fc-abab-5f1095cf953a"), "prague" },
                    { new Guid("3dc60e53-c9c4-40ad-8126-90015cc2fe59"), "hangzhou" },
                    { new Guid("3e2bc2f9-54d3-40fb-8bb3-552a2e524822"), "milan" },
                    { new Guid("3f50f11c-a1cd-457e-a8b9-5e537f639645"), "lima" },
                    { new Guid("3fd58a75-d3d5-4be7-8234-8ab14a25d4d9"), "riyadh" },
                    { new Guid("442aa21f-09ec-4127-a086-b4e4046a75a1"), "washington" },
                    { new Guid("454d2a0c-7e06-4bbd-8e9f-9b1b7b9e7f3e"), "antalya" },
                    { new Guid("46a88740-0bfa-40c2-b55b-6d791f9107eb"), "mexico city" },
                    { new Guid("47d98f58-4e3c-4753-ae50-99f5b973bd97"), "chiang mai" },
                    { new Guid("4a16e73a-5ef4-4eb4-add4-610760a774b0"), "dalian" },
                    { new Guid("4a2c2179-2087-4506-bb26-1a8f23a823d2"), "johor bahru" },
                    { new Guid("4deb9131-1686-4530-ae84-4baabddfbb89"), "paris" },
                    { new Guid("4e79b4b8-c155-4c9a-aec8-78ca8e11b67a"), "moscow" },
                    { new Guid("4f5a3efb-cb57-4b1b-b996-8270775dbbb1"), "ho chi minh city" },
                    { new Guid("51596f2e-d716-44c2-879b-62cd4cd22aed"), "chiba" },
                    { new Guid("52384405-f92a-4621-9121-c542463dfa52"), "singapore" },
                    { new Guid("54cab79a-3904-4e41-996e-262ba04cf25c"), "jerusalem" },
                    { new Guid("5543b786-84d3-4bbe-85e2-3d9bcd3a0104"), "dallas" },
                    { new Guid("57313435-831d-4922-ab82-76b256ecf11b"), "frankfurt am main" },
                    { new Guid("583e37d6-8519-4990-bbc3-f40752b64bf0"), "da nang" },
                    { new Guid("59f0fdee-a284-4ebd-9097-edc9ff623d81"), "brussels" },
                    { new Guid("5d56c3d8-baff-4f34-9780-ea0005a23f2c"), "qingdao" },
                    { new Guid("60b6abbb-01be-41e7-b619-b1ac1a1cc7a8"), "vienna" },
                    { new Guid("610fd267-5d9f-4c94-bfa8-61c33fcb5337"), "mecca" },
                    { new Guid("6117189b-1123-4bd4-a1c7-2aab6e2749b7"), "dubai" },
                    { new Guid("625b3f03-f8cf-43f7-be27-c46bdb449b16"), "atlanta" },
                    { new Guid("6547f467-d4b2-4434-988d-1a1beca40e40"), "kuala lumpur" },
                    { new Guid("67cc3cd9-722e-4a1a-967d-844e30cb7432"), "jakarta" },
                    { new Guid("69e72711-1514-4a92-a9b3-efaf1c0579e3"), "manila" },
                    { new Guid("6aa5f8d9-986f-45c9-b3d2-670f068651ba"), "houston" },
                    { new Guid("6b2e6086-ccc7-418e-bddd-3cb4e22ca84c"), "rio de janeiro" },
                    { new Guid("6d84a430-e682-4bcf-a374-a20f08163362"), "melbourne" },
                    { new Guid("6e03ee8c-bf54-458b-be1d-1526ec5d34ad"), "munich" },
                    { new Guid("6e8c591e-8ebf-4593-8cae-9d887936b441"), "marrakesh" },
                    { new Guid("6eff63a1-f1fd-41a3-a5c0-ddad077711ea"), "los angeles" },
                    { new Guid("70d83a46-5373-4ea8-97b4-2157a82bb319"), "amman" },
                    { new Guid("71f4bd84-ea1d-4bf4-ae68-005d3102ae1e"), "macau" },
                    { new Guid("74dd48a4-3eaa-4ad8-a1e3-bfdfff4fa07c"), "tokyo" },
                    { new Guid("76c96e30-678c-4eff-bd06-cedd5eb17471"), "orlando" },
                    { new Guid("77c06ec9-1099-4f81-afe0-71793a907636"), "abu dhabi" },
                    { new Guid("7814d421-cc69-4d17-a59f-d0bf13eaf30c"), "dusseldorf" },
                    { new Guid("7b1c5db4-a002-4d21-ac61-1139daa3f062"), "penang island" },
                    { new Guid("7bf5a42c-2859-460e-ba9d-4b698192b094"), "sao paulo" },
                    { new Guid("7d78c2c6-a6c8-4c72-be61-5e501234080c"), "san jose" },
                    { new Guid("7dc58758-f757-4c4e-9cef-f112be31930b"), "batam" },
                    { new Guid("86e837b1-21c0-4f2c-a803-78e3f060074e"), "guilin" },
                    { new Guid("8a63f2dc-87cc-4777-b767-8888a9611401"), "madrid" },
                    { new Guid("8f830b09-9b1a-440d-bdad-304c1a6f0839"), "lagos" },
                    { new Guid("909cf9b8-2db0-4643-8bd3-c27cce4a0247"), "punta cana" },
                    { new Guid("91b2ea5a-a5f6-4c96-820a-160035220d6a"), "phuket" },
                    { new Guid("943c7df3-b164-4fa0-9dfa-138e82f326ef"), "guangzhou" },
                    { new Guid("951ab533-4c68-4641-b930-644817b887de"), "cancun" },
                    { new Guid("957089f4-d3e3-4d0b-b36f-154ec06a60d1"), "taipei" },
                    { new Guid("9676472d-30fe-4b59-874b-db284b941ee7"), "zurich" },
                    { new Guid("984fdcaa-c922-42c1-a92e-15cc7b64d9f7"), "miami" },
                    { new Guid("99715af8-9b96-462b-904b-18142d608c2f"), "seoul" },
                    { new Guid("9b86c86b-c601-4c2a-b411-84b4f682bcef"), "hanoi" },
                    { new Guid("9d975109-24b7-4830-8d46-bafee5215980"), "copenhagen" },
                    { new Guid("9e1a1e3b-1ba4-40ee-8e86-bce4c7b62695"), "porto" },
                    { new Guid("9e44cc96-1cd2-4fbf-a9bf-f33c1976d41e"), "montevideo" },
                    { new Guid("9e4e14b5-cbab-4997-99e8-42059b1ee58c"), "ha long" },
                    { new Guid("a04d9cea-3071-4d69-8475-43be05d62d4d"), "tehran" },
                    { new Guid("a08bac8e-26e8-4d10-9284-a7552592b76a"), "johannesburg" },
                    { new Guid("a29062ff-06b4-4195-a6f0-065c53bbb1d4"), "chengdu" },
                    { new Guid("a2aab779-e37c-4355-8210-6b36f33cf570"), "edinburgh" },
                    { new Guid("a45c1999-c0c9-4b9b-a880-8a3a1987902b"), "delhi" },
                    { new Guid("a6bdba2c-600b-44b9-9c42-20ee3cbe817e"), "mugla" },
                    { new Guid("a7a8747a-8b0d-49d5-816f-2a1534f0cf63"), "buenos aires" },
                    { new Guid("aa672cc4-af1e-4191-a4f2-51c5269a4833"), "casablanca" },
                    { new Guid("ab4fd608-c983-4c55-9a56-9f0b14c3c8dd"), "cebu city" },
                    { new Guid("ac524206-43a4-41f7-94eb-62b58f4b1fe9"), "amsterdam" },
                    { new Guid("ac831b02-f212-402d-afcd-db8ca45a5628"), "beijing" },
                    { new Guid("ade16c64-1dd7-4a8f-9922-62165c7938e4"), "vancouver" },
                    { new Guid("afdf6e98-7e6a-454e-8c76-42413f45e3ea"), "lisbon" },
                    { new Guid("b11315b8-0ad3-4a55-a394-87a9db87d4a4"), "tel aviv" },
                    { new Guid("b290112a-c08b-440f-a207-97153fe17c34"), "bogota" },
                    { new Guid("b36f9dd4-9bf0-4aff-9fd9-48d826cf85bc"), "philadelphia" },
                    { new Guid("b4b5ded2-3056-43d8-82c9-4016206fb801"), "montreal" },
                    { new Guid("b4ddff71-34fe-4c62-a72f-283aedfb2384"), "sydney" },
                    { new Guid("b4e1e648-ac52-4af9-8aff-c2e63a2ca706"), "krabi" },
                    { new Guid("bbdb61a5-0609-49ca-a8d2-4a03b73015d7"), "las vegas" },
                    { new Guid("bd14f206-55ab-4787-9a12-f6d378bd724b"), "bucharest" },
                    { new Guid("c029ae46-040d-40a6-a0ed-abc90d4e082a"), "new york city" },
                    { new Guid("c243e28a-ef15-49aa-b681-735dba0d44e6"), "krakow" },
                    { new Guid("c7965ec1-a12a-4537-a5f2-ce8fbe20fcff"), "rhodes" },
                    { new Guid("cab88083-48e9-4f93-bade-6ec2617f42c5"), "toronto" },
                    { new Guid("cae872e9-9f82-4b58-8774-757d28164901"), "warsaw" },
                    { new Guid("caf3fde6-d053-4a21-ac1c-699775806ac5"), "zhuhai" },
                    { new Guid("cb7bda95-575f-4085-989e-fc35fff05756"), "boston" },
                    { new Guid("d3aef908-7852-4ea3-857a-29edf0273a5b"), "xiamen" },
                    { new Guid("d8061e66-6f1b-49a6-803a-4b1ec261a5a0"), "chennai" },
                    { new Guid("d8261afa-a0c4-4e3a-9594-d45d8166e50c"), "venice" },
                    { new Guid("de6d2828-1689-473d-a338-b4991d2cfc98"), "colombo" },
                    { new Guid("df18d59f-262f-4c3d-9e9a-d3b6fd27414b"), "barcelona" },
                    { new Guid("dfe1f1b0-b204-4fdb-a12e-9d25011ece3d"), "accra" },
                    { new Guid("e4618222-8af5-4e83-a108-499a6fc7ec1e"), "hamburg" },
                    { new Guid("e744d5f8-cbb3-4e6c-bb0a-073ba6e10617"), "budapest" },
                    { new Guid("e864a2fc-ee08-40b5-8b16-c511f4b06cc6"), "shanghai" },
                    { new Guid("ecec291b-bf10-4e56-b249-f31d80361187"), "london" },
                    { new Guid("f0225d18-cdd3-471d-bcb3-2ff288061d1d"), "mumbai" },
                    { new Guid("f2ec18b5-c484-409e-85f6-7bde52bbb416"), "tianjin" },
                    { new Guid("f649e87f-c026-4fb1-b251-15c98fd8492c"), "medina" },
                    { new Guid("fb365a07-c256-4ec0-9fb0-17716b60195e"), "florence" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities",
                schema: "practice");
        }
    }
}
