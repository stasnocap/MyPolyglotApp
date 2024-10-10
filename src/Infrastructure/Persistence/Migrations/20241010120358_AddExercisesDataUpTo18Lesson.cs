using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddExercisesDataUpTo18Lesson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "practice",
                table: "Exercises",
                columns: new[] { "Id", "LessonId", "RusPhrase" },
                values: new object[,]
                {
                    { new Guid("00242767-9606-4d08-b96b-7a1498a6d0c9"), new Guid("255d72a1-b6e7-4fbb-bc5a-362f2b0c4efe"), "Ты чувствуешь себя плохо целый день сегодня." },
                    { new Guid("077d1b35-28e8-411f-956a-4ac8883d27b8"), new Guid("d9dadc04-9197-4b7a-aca6-c9ce18c1fef5"), "Он никогда не видит." },
                    { new Guid("08681ed3-8ab0-4a1d-967a-2c2806b3a099"), new Guid("168e4970-41f5-441b-aedb-092556b63775"), "Я выполнил работу." },
                    { new Guid("08ed1ce8-96e5-45ff-b10f-8fa49a1af3d4"), new Guid("1d883b60-88a9-4186-a003-9939210b3fe2"), "Эта ручка не больше той." },
                    { new Guid("0919cab8-a02f-4da7-9b47-1a58351ea9c3"), new Guid("18da835a-791c-4dd7-915f-09abf79219d1"), "Он будет расти через 2 месяца?" },
                    { new Guid("0fee6686-f59a-4025-9184-858d1c0a3659"), new Guid("19e63968-9aa1-4196-af9b-020bd589103c"), "Ей хотелось забывать?" },
                    { new Guid("111b3155-8751-456a-8a77-f1c26ced8f18"), new Guid("255d72a1-b6e7-4fbb-bc5a-362f2b0c4efe"), "Ты будешь читать книгу целый день завтра." },
                    { new Guid("11af84dc-c777-46c9-ba7e-8fc836a804f0"), new Guid("d9dadc04-9197-4b7a-aca6-c9ce18c1fef5"), "Мы будем читать кому-нибудь." },
                    { new Guid("1a04722f-1b4d-4730-b1f0-4fa2f8d71bd7"), new Guid("ef710306-a1b1-4823-93eb-64d8357ed6ea"), "Мы были его историками." },
                    { new Guid("1bcbf50b-967d-49e2-84b8-aba447ac4954"), new Guid("c61b363f-290f-4ff4-8cd3-1845414c680f"), "Я не буду менеджером." },
                    { new Guid("1ce82652-e890-4a79-980a-de6a7291c4b6"), new Guid("19e63968-9aa1-4196-af9b-020bd589103c"), "Она в лифте?" },
                    { new Guid("1d31d367-6651-40f8-a82d-b6f033debac9"), new Guid("302c1e93-e339-4850-9bc9-47dd5e37decb"), "Пусть он ответит." },
                    { new Guid("2050e871-9095-4f46-8787-8f717f114ea2"), new Guid("302c1e93-e339-4850-9bc9-47dd5e37decb"), "Помни про нас." },
                    { new Guid("21983f75-6289-4334-9372-c88a81690e96"), new Guid("302c1e93-e339-4850-9bc9-47dd5e37decb"), "Беги к ней." },
                    { new Guid("2233f2a0-b9c6-4072-8ace-ea274ebf6cf4"), new Guid("168e4970-41f5-441b-aedb-092556b63775"), "Думаю, что я видел вас где-то." },
                    { new Guid("23c9e459-845c-4a74-96fa-5eda6187cb1f"), new Guid("946446db-a1da-422e-bad6-ab7972987ae4"), "Под креслом был стакан?" },
                    { new Guid("2958e0a7-9ebc-463a-9f87-5a98ab680449"), new Guid("946446db-a1da-422e-bad6-ab7972987ae4"), "Под столом есть ножи." },
                    { new Guid("2c900207-3d73-4b27-a482-f16ce64b7729"), new Guid("a26e89e2-cafd-4126-bc63-5ba53645ed6d"), "Мне холодно?" },
                    { new Guid("30da8a31-852f-4cfc-89e1-c754bd83ad25"), new Guid("1d883b60-88a9-4186-a003-9939210b3fe2"), "Этот телевизор не дорогой." },
                    { new Guid("33864b46-810c-4fad-aee0-05e42b413e6a"), new Guid("65f77c8e-3d17-419e-9529-4326811c732c"), "Ученики займут свои места до того, как начнется урок." },
                    { new Guid("35a00634-becb-46a3-bc3d-a73bb2b46ab1"), new Guid("c61b363f-290f-4ff4-8cd3-1845414c680f"), "Они работали в компании дизайнерами?" },
                    { new Guid("35e343ce-74c5-4413-a75a-48e29d6ee031"), new Guid("ef710306-a1b1-4823-93eb-64d8357ed6ea"), "Мы не будем их гидами." },
                    { new Guid("36411c85-2a47-415c-a396-ea52bcadd3e9"), new Guid("d9dadc04-9197-4b7a-aca6-c9ce18c1fef5"), "Они чувствуют везде?" },
                    { new Guid("38df6419-b7c7-4f23-ae70-6ddadf05db9f"), new Guid("18da835a-791c-4dd7-915f-09abf79219d1"), "Она была там вечером." },
                    { new Guid("3953a15c-4d98-4b8d-b5a0-a2bbe4449fe9"), new Guid("a26e89e2-cafd-4126-bc63-5ba53645ed6d"), "Ты здоров." },
                    { new Guid("43d627bb-e3ed-4a8d-81b9-8e0212a3a8a0"), new Guid("06e34fe3-489b-4fce-ba46-f9e30c63146f"), "Он взломал дверь." },
                    { new Guid("45425db5-3e53-471c-861b-007a0b2a305b"), new Guid("ef710306-a1b1-4823-93eb-64d8357ed6ea"), "Он будет её писателем." },
                    { new Guid("46eac2d6-1f33-4c2a-b420-e914de870deb"), new Guid("18da835a-791c-4dd7-915f-09abf79219d1"), "Я расскажу тебе через 6 месяцев." },
                    { new Guid("47124eb6-a2d1-4b91-9e5d-5a85169625c8"), new Guid("65f77c8e-3d17-419e-9529-4326811c732c"), "Я уже окончу эту работу до того, как вы возвратитесь." },
                    { new Guid("47294d03-3395-42a6-83d8-389d19aec14d"), new Guid("06e34fe3-489b-4fce-ba46-f9e30c63146f"), "Цены никогда не падают." },
                    { new Guid("49c84e13-c9a2-4665-b563-7c1f686c8b8d"), new Guid("946446db-a1da-422e-bad6-ab7972987ae4"), "На полу не было ручек." },
                    { new Guid("4afa32ae-daa4-45ed-92ea-f910b90116c1"), new Guid("49723cf9-e420-4608-a368-f2ffbd006242"), "В комнате не будет шкафов." },
                    { new Guid("4bfb0f3d-91d4-42c6-ad20-dd66a700d43c"), new Guid("7407b5e3-bcc3-4853-ba1c-740985bf7d52"), "Он уже написал письмо, когда ты вошел?" },
                    { new Guid("5c96d301-355b-445f-a153-07ef89786909"), new Guid("35c865ea-0c11-4a46-a5f0-d8c168f88907"), "Она не должна ответить." },
                    { new Guid("61a06c06-8603-4dd3-8fe5-92f3364e3814"), new Guid("35c865ea-0c11-4a46-a5f0-d8c168f88907"), "Мы не показали." },
                    { new Guid("67f7b904-927c-471f-8dfe-73f54adb9e03"), new Guid("49723cf9-e420-4608-a368-f2ffbd006242"), "Под столом были стаканы?" },
                    { new Guid("6b9c1472-a03e-4854-bec8-cfc8bfb8e06c"), new Guid("7407b5e3-bcc3-4853-ba1c-740985bf7d52"), "Вы вернулись домой до того, как начался дождь." },
                    { new Guid("6d0cc462-65e5-48a1-beb0-b7cdb1f04045"), new Guid("18da835a-791c-4dd7-915f-09abf79219d1"), "Она не повернула нас 6 месяцев назад." },
                    { new Guid("6e183839-2a73-44bf-b4e2-b3ab25613a5a"), new Guid("06e34fe3-489b-4fce-ba46-f9e30c63146f"), "Он сбросил вес." },
                    { new Guid("74886f2d-4d3b-40fe-b96a-7524e9fe5b09"), new Guid("18da835a-791c-4dd7-915f-09abf79219d1"), "Она любила их в выходные?" },
                    { new Guid("765b06a2-50d6-4c56-8845-143e7ee7c733"), new Guid("1d883b60-88a9-4186-a003-9939210b3fe2"), "Эта ручка длиннее той." },
                    { new Guid("768101f9-4a4b-43cd-aa34-faf712bfc940"), new Guid("65f77c8e-3d17-419e-9529-4326811c732c"), "Они не успеют выиграть три игры к концу месяца." },
                    { new Guid("791f349a-79eb-431e-8c4a-29371d6e0689"), new Guid("ef710306-a1b1-4823-93eb-64d8357ed6ea"), "Мы не их бухгалтеры." },
                    { new Guid("7ac50144-ad5f-4702-9d87-ea996e8904aa"), new Guid("d9dadc04-9197-4b7a-aca6-c9ce18c1fef5"), "Ты встречаешь везде?" },
                    { new Guid("7c07747b-ded1-4c2e-9a36-17f95fc059f7"), new Guid("7407b5e3-bcc3-4853-ba1c-740985bf7d52"), "Когда мы приехали на станцию, поезд уже ушел." },
                    { new Guid("817ce59c-2207-420c-9dd7-db822ab79b4b"), new Guid("a26e89e2-cafd-4126-bc63-5ba53645ed6d"), "Она взрослая." },
                    { new Guid("8296a1d5-c980-4187-8379-29625ee413d6"), new Guid("1d883b60-88a9-4186-a003-9939210b3fe2"), "Этот телефон дешевле того?" },
                    { new Guid("84b9001f-564e-42c5-a864-eefa2f289f3b"), new Guid("255d72a1-b6e7-4fbb-bc5a-362f2b0c4efe"), "Мы отвечали на письмо в 4 вчера." },
                    { new Guid("8650e3d8-d11f-461c-9f8a-b00e6379c348"), new Guid("d9dadc04-9197-4b7a-aca6-c9ce18c1fef5"), "Он будет знать всех?" },
                    { new Guid("865496b8-3788-4cc3-8f6a-09dfebcd2d9b"), new Guid("ef710306-a1b1-4823-93eb-64d8357ed6ea"), "Он будет их актёром?" },
                    { new Guid("8d53f533-4cdc-4e5a-a963-54f31febf8e5"), new Guid("c61b363f-290f-4ff4-8cd3-1845414c680f"), "Они учатся на гидов?" },
                    { new Guid("8de0af24-b98a-4f94-8974-aa3c51220f09"), new Guid("255d72a1-b6e7-4fbb-bc5a-362f2b0c4efe"), "Мы изучали французский целый день вчера." },
                    { new Guid("8f56c4de-e4bf-4354-8279-ea3f6aca18dc"), new Guid("1d883b60-88a9-4186-a003-9939210b3fe2"), "Эти апельсины самые маленькие?" },
                    { new Guid("90a95bc6-f20f-4e55-b3ba-469f4fa589f7"), new Guid("19e63968-9aa1-4196-af9b-020bd589103c"), "Ей не нравилось показывать." },
                    { new Guid("928acaf1-743e-4c3e-bdfa-e24d0e6ff485"), new Guid("49723cf9-e420-4608-a368-f2ffbd006242"), "Ты не выйдешь из сада." },
                    { new Guid("9d53c467-f7e8-4433-971c-5e7cb7ce6a71"), new Guid("35c865ea-0c11-4a46-a5f0-d8c168f88907"), "Мы не должны чувствовать." },
                    { new Guid("9e891766-82ec-441e-affe-b3138b7a04db"), new Guid("49723cf9-e420-4608-a368-f2ffbd006242"), "Он идёт на станцию?" },
                    { new Guid("ad46e855-9605-4d41-9eac-2c8dfa2f7c1f"), new Guid("19e63968-9aa1-4196-af9b-020bd589103c"), "Я был в музее." },
                    { new Guid("aee272ba-c84e-4fe4-a8ea-49386db26adb"), new Guid("65f77c8e-3d17-419e-9529-4326811c732c"), "Они еще не отгрузят товар, когда придет ваша телеграмма." },
                    { new Guid("b8a0d599-6575-4626-b2af-317f9e78efa4"), new Guid("168e4970-41f5-441b-aedb-092556b63775"), "Я уже написал письмо своему другу." },
                    { new Guid("bc4032b5-0b91-47da-8e6f-db283a515989"), new Guid("302c1e93-e339-4850-9bc9-47dd5e37decb"), "Не бери мой планшет." },
                    { new Guid("be20ccf4-be83-4bc4-b08f-5c2bd02dda01"), new Guid("c61b363f-290f-4ff4-8cd3-1845414c680f"), "Мы учились на менеджеров." },
                    { new Guid("bfca2c81-719c-4189-8e2d-027163421517"), new Guid("168e4970-41f5-441b-aedb-092556b63775"), "Он только что вышел." },
                    { new Guid("c4f3b91f-1c7b-44a2-b32e-32ef0b1f0b11"), new Guid("7407b5e3-bcc3-4853-ba1c-740985bf7d52"), "Я не успел закончить проект к началу той недели." },
                    { new Guid("c5406625-55a2-488f-9050-a5ab649cd3ce"), new Guid("49723cf9-e420-4608-a368-f2ffbd006242"), "На подоконнике будет чашка." },
                    { new Guid("c6453de7-f75d-49bf-ac53-4944dac3b288"), new Guid("35c865ea-0c11-4a46-a5f0-d8c168f88907"), "Нужно мне стоять?" },
                    { new Guid("cef21bb8-1373-4236-9b2b-703377c974bf"), new Guid("19e63968-9aa1-4196-af9b-020bd589103c"), "Тебе хочется пить?" },
                    { new Guid("d2a4e39d-1b0d-4584-bfd2-aa0cfbb070d6"), new Guid("302c1e93-e339-4850-9bc9-47dd5e37decb"), "Не поворачивай его тумбочку." },
                    { new Guid("d54d614b-f911-4fd8-9932-eead5f63eb74"), new Guid("06e34fe3-489b-4fce-ba46-f9e30c63146f"), "Твой сын просит выключить свет." },
                    { new Guid("d57af893-3fcf-463f-8722-03583c052ffc"), new Guid("7407b5e3-bcc3-4853-ba1c-740985bf7d52"), "Он сделал домашнее задание до того, как его родители вернулись домой?" },
                    { new Guid("dbdc7990-cb51-4e30-96cd-17e3fa20dafa"), new Guid("168e4970-41f5-441b-aedb-092556b63775"), "Он только что посетил этот супермаркет." },
                    { new Guid("dc63683b-d306-4203-9cce-452d0f828491"), new Guid("946446db-a1da-422e-bad6-ab7972987ae4"), "На столе нет ручки." },
                    { new Guid("df7940f8-70aa-4e17-9df0-2bb4a46d6d7d"), new Guid("35c865ea-0c11-4a46-a5f0-d8c168f88907"), "Мы можем закрыть." },
                    { new Guid("e2ec419b-08c9-4295-86e1-e8846488b20c"), new Guid("946446db-a1da-422e-bad6-ab7972987ae4"), "Под креслом будет мяч." },
                    { new Guid("e7ac161c-561a-4ffe-81f7-b57b37b19e52"), new Guid("06e34fe3-489b-4fce-ba46-f9e30c63146f"), "Он свалился с пневмонией." },
                    { new Guid("e89a87ca-93c7-489c-85e6-200a1192d751"), new Guid("18da835a-791c-4dd7-915f-09abf79219d1"), "Ты будешь там через 6 месяцев?" },
                    { new Guid("eaacd632-357b-4473-8bc4-e64338f16811"), new Guid("a26e89e2-cafd-4126-bc63-5ba53645ed6d"), "У меня не голубые глаза." },
                    { new Guid("ef5c8e17-28a7-4673-97d7-ab3f84d01aa3"), new Guid("c61b363f-290f-4ff4-8cd3-1845414c680f"), "Ты историк." },
                    { new Guid("f1bb33c6-6457-442a-a937-24ec243a7dcc"), new Guid("65f77c8e-3d17-419e-9529-4326811c732c"), "Я не закончу писать доклад к вечеру." },
                    { new Guid("fd21cd86-2fdd-49a9-8447-0159f7756337"), new Guid("a26e89e2-cafd-4126-bc63-5ba53645ed6d"), "Вчера было жарко." },
                    { new Guid("ffd37b6b-c0c9-4f04-a7c1-f6dffb9eec21"), new Guid("255d72a1-b6e7-4fbb-bc5a-362f2b0c4efe"), "Он читал письмо с 4 до 10 вчера." }
                });

            migrationBuilder.InsertData(
                schema: "practice",
                table: "Words",
                columns: new[] { "Id", "ExerciseId", "Number", "Text", "Type" },
                values: new object[,]
                {
                    { new Guid("0057d61f-be88-45ef-8fc5-36b4007836b4"), new Guid("74886f2d-4d3b-40fe-b96a-7524e9fe5b09"), 1, "Did", 13 },
                    { new Guid("00930476-cad8-45f0-9c94-65b0f42520ea"), new Guid("84b9001f-564e-42c5-a864-eefa2f289f3b"), 8, "yesterday.", 2 },
                    { new Guid("00b45f27-32f5-427d-a867-0bd86ca686f6"), new Guid("2c900207-3d73-4b27-a482-f16ce64b7729"), 1, "Am", 13 },
                    { new Guid("00fc0a5b-42da-4d88-a23b-204ee9da7690"), new Guid("fd21cd86-2fdd-49a9-8447-0159f7756337"), 4, "yesterday.", 2 },
                    { new Guid("01303bf0-fe08-411c-990b-a2aaf8f20761"), new Guid("865496b8-3788-4cc3-8f6a-09dfebcd2d9b"), 4, "their", 14 },
                    { new Guid("0244dfbc-7f8c-439d-b925-8f6bb16e1485"), new Guid("47124eb6-a2d1-4b91-9e5d-5a85169625c8"), 4, "finished", 16 },
                    { new Guid("02ca9313-988c-4fef-8230-cd3af412a935"), new Guid("61a06c06-8603-4dd3-8fe5-92f3364e3814"), 2, "didn't", 13 },
                    { new Guid("03074cc6-d5c2-4e6a-bd88-4a9d48442afa"), new Guid("6b9c1472-a03e-4854-bec8-cfc8bfb8e06c"), 5, "before", 12 },
                    { new Guid("035f5734-cdb5-4597-ac58-c07cf9c2eaf8"), new Guid("765b06a2-50d6-4c56-8845-143e7ee7c733"), 7, "one.", 10 },
                    { new Guid("038b26c6-d388-42fb-b495-2d7ee10e2dfe"), new Guid("e2ec419b-08c9-4295-86e1-e8846488b20c"), 6, "under", 12 },
                    { new Guid("053d4969-b803-4de7-ae16-5b4e85682122"), new Guid("dc63683b-d306-4203-9cce-452d0f828491"), 6, "the", 6 },
                    { new Guid("056f0cf0-591e-4198-9705-98c6b3fdf54f"), new Guid("67f7b904-927c-471f-8dfe-73f54adb9e03"), 1, "Were", 13 },
                    { new Guid("05c82041-90b4-4717-afad-48d6dc9a848e"), new Guid("33864b46-810c-4fad-aee0-05e42b413e6a"), 3, "will", 13 },
                    { new Guid("06dd14cd-f87d-457e-981f-da4b24a175c5"), new Guid("8de0af24-b98a-4f94-8974-aa3c51220f09"), 4, "French", 7 },
                    { new Guid("0713b7fc-088a-42aa-9418-cbe97525e442"), new Guid("9e891766-82ec-441e-affe-b3138b7a04db"), 3, "go", 16 },
                    { new Guid("07bb3b2e-6642-4d2e-9892-1b82bbfa6552"), new Guid("d2a4e39d-1b0d-4584-bfd2-aa0cfbb070d6"), 2, "turn", 16 },
                    { new Guid("08a3381a-41bf-4ed3-929b-00213f93cad3"), new Guid("8d53f533-4cdc-4e5a-a963-54f31febf8e5"), 6, "guides?", 10 },
                    { new Guid("093b5767-2c02-49ad-9411-0441b1ac3cfb"), new Guid("e89a87ca-93c7-489c-85e6-200a1192d751"), 3, "be", 13 },
                    { new Guid("0975c2ca-c98e-4cf8-89c7-858a03a70f1f"), new Guid("aee272ba-c84e-4fe4-a8ea-49386db26adb"), 9, "telegram", 10 },
                    { new Guid("09b1a15c-4b9a-4967-9da8-b8c3b72e491a"), new Guid("84b9001f-564e-42c5-a864-eefa2f289f3b"), 3, "answering", 16 },
                    { new Guid("09d1d5d8-8e04-42f0-935c-13e7af7abbc5"), new Guid("e2ec419b-08c9-4295-86e1-e8846488b20c"), 4, "a", 6 },
                    { new Guid("0a134ca9-847d-44cb-9ed3-4e501082218a"), new Guid("4afa32ae-daa4-45ed-92ea-f910b90116c1"), 2, "won't", 13 },
                    { new Guid("0a8af533-0355-4a81-9986-ab4672c21216"), new Guid("bc4032b5-0b91-47da-8e6f-db283a515989"), 3, "my", 14 },
                    { new Guid("0b45015f-a579-4a0c-b577-4602b4fcc1e2"), new Guid("8d53f533-4cdc-4e5a-a963-54f31febf8e5"), 4, "to", 12 },
                    { new Guid("0c3f8764-3fce-4185-93ca-8835c7f3943a"), new Guid("aee272ba-c84e-4fe4-a8ea-49386db26adb"), 7, "when", 15 },
                    { new Guid("0cd86ba6-a639-44c0-a3a7-52b21d8d1db8"), new Guid("2233f2a0-b9c6-4072-8ace-ea274ebf6cf4"), 1, "I", 14 },
                    { new Guid("0d46ddfa-9845-47f0-a2c4-45174cca7a6b"), new Guid("45425db5-3e53-471c-861b-007a0b2a305b"), 2, "will", 13 },
                    { new Guid("0ed11e4c-f7b3-4ebc-b1e2-62036f8343e0"), new Guid("111b3155-8751-456a-8a77-f1c26ced8f18"), 4, "reading", 16 },
                    { new Guid("0ed3f0d2-3aff-455e-b43d-5fc51d677801"), new Guid("c4f3b91f-1c7b-44a2-b32e-32ef0b1f0b11"), 11, "week.", 10 },
                    { new Guid("0f284ba6-695f-48b1-bf8d-668b78dc0695"), new Guid("ffd37b6b-c0c9-4f04-a7c1-f6dffb9eec21"), 4, "the", 6 },
                    { new Guid("0f82f4fe-9bf4-42e1-96c7-03285ce058ec"), new Guid("46eac2d6-1f33-4c2a-b420-e914de870deb"), 5, "in", 12 },
                    { new Guid("102a9309-d836-41b7-9161-7218fd2c72a7"), new Guid("e89a87ca-93c7-489c-85e6-200a1192d751"), 6, "6 months?", 11 },
                    { new Guid("106137a0-fcd2-4d3c-9e7a-ba3b5c93bd5e"), new Guid("768101f9-4a4b-43cd-aa34-faf712bfc940"), 4, "won", 16 },
                    { new Guid("109005e2-5471-468a-96c5-6625f69a47ba"), new Guid("111b3155-8751-456a-8a77-f1c26ced8f18"), 5, "the", 6 },
                    { new Guid("10c65254-1e4c-46a4-9920-d3e09585f7d2"), new Guid("768101f9-4a4b-43cd-aa34-faf712bfc940"), 5, "three", 8 },
                    { new Guid("10e8a357-88a5-45b2-b7ba-79f78a963fcd"), new Guid("8d53f533-4cdc-4e5a-a963-54f31febf8e5"), 2, "they", 14 },
                    { new Guid("10f0d3a1-38f7-4056-9a5b-e582e8b92762"), new Guid("47124eb6-a2d1-4b91-9e5d-5a85169625c8"), 5, "this", 14 },
                    { new Guid("115c85d6-1c60-425a-bb69-f057d4261682"), new Guid("dbdc7990-cb51-4e30-96cd-17e3fa20dafa"), 6, "supermarket.", 10 },
                    { new Guid("11862af5-94f7-42a5-8ba6-c844d767974e"), new Guid("7ac50144-ad5f-4702-9d87-ea996e8904aa"), 1, "Do", 13 },
                    { new Guid("126ca615-6889-42c5-b8d9-7101d1e4c332"), new Guid("f1bb33c6-6457-442a-a937-24ec243a7dcc"), 2, "will not", 13 },
                    { new Guid("12c91238-0a40-412f-a9ea-edef9f843ac2"), new Guid("6d0cc462-65e5-48a1-beb0-b7cdb1f04045"), 2, "didn't", 13 },
                    { new Guid("12d0d824-b5fa-4b8d-8850-e13c7633b236"), new Guid("d2a4e39d-1b0d-4584-bfd2-aa0cfbb070d6"), 1, "Don't", 13 },
                    { new Guid("13384cfa-cc62-45c8-81a9-19730a767842"), new Guid("47294d03-3395-42a6-83d8-389d19aec14d"), 1, "The", 6 },
                    { new Guid("14986925-f269-4656-b99c-b13ac0b92345"), new Guid("f1bb33c6-6457-442a-a937-24ec243a7dcc"), 6, "report", 10 },
                    { new Guid("16c5a294-672c-475a-9f25-861bb940bcf2"), new Guid("bfca2c81-719c-4189-8e2d-027163421517"), 5, "out.", 2 },
                    { new Guid("16e351e1-f01d-4340-b8fc-3666b3f9a7c1"), new Guid("84b9001f-564e-42c5-a864-eefa2f289f3b"), 1, "We", 14 },
                    { new Guid("16f0d865-b4b3-44d1-bfd3-98022abeffb0"), new Guid("8296a1d5-c980-4187-8379-29625ee413d6"), 5, "than", 12 },
                    { new Guid("1711493d-98bf-4a8a-b332-b3cd3b32c952"), new Guid("4afa32ae-daa4-45ed-92ea-f910b90116c1"), 4, "cupboards", 10 },
                    { new Guid("17fa35c1-0a3f-44dd-8107-da3f7fa6a4b8"), new Guid("8296a1d5-c980-4187-8379-29625ee413d6"), 7, "one?", 10 },
                    { new Guid("182778c2-4308-430a-bef1-51a864dd7dc8"), new Guid("47124eb6-a2d1-4b91-9e5d-5a85169625c8"), 1, "I", 14 },
                    { new Guid("18a82a4d-8afe-49af-b0ff-8f8521ee6776"), new Guid("8296a1d5-c980-4187-8379-29625ee413d6"), 4, "cheaper", 4 },
                    { new Guid("18ae7dc8-e658-472a-a0e8-ec70c652ba19"), new Guid("c5406625-55a2-488f-9050-a5ab649cd3ce"), 3, "be", 13 },
                    { new Guid("1a4a7b7f-d800-4e59-a3a5-eff18fd0a7b4"), new Guid("c4f3b91f-1c7b-44a2-b32e-32ef0b1f0b11"), 3, "finished", 16 },
                    { new Guid("1abb3725-60f9-450e-a554-32a4c9916434"), new Guid("768101f9-4a4b-43cd-aa34-faf712bfc940"), 8, "the", 6 },
                    { new Guid("1aed4c76-ded9-46c6-9610-c6c3afa103f2"), new Guid("dc63683b-d306-4203-9cce-452d0f828491"), 2, "isn't", 13 },
                    { new Guid("1c3bc0ab-948d-4ff3-8b5b-b379c8f17ef2"), new Guid("47294d03-3395-42a6-83d8-389d19aec14d"), 5, "down.", 12 },
                    { new Guid("1d198016-aa5a-4470-869a-b324ad4b414f"), new Guid("36411c85-2a47-415c-a396-ea52bcadd3e9"), 4, "everywhere?", 5 },
                    { new Guid("1e851c92-425b-43a5-ad28-b4b69a2619b9"), new Guid("aee272ba-c84e-4fe4-a8ea-49386db26adb"), 4, "shipped", 16 },
                    { new Guid("1eaafcba-b844-4a54-b4df-4188c0030e58"), new Guid("6b9c1472-a03e-4854-bec8-cfc8bfb8e06c"), 8, "began.", 16 },
                    { new Guid("1f0996b6-e2eb-42d9-9052-002893d9ef5e"), new Guid("6b9c1472-a03e-4854-bec8-cfc8bfb8e06c"), 3, "returned", 16 },
                    { new Guid("1f9e4303-1f37-4528-bbd8-be19237a2f12"), new Guid("5c96d301-355b-445f-a153-07ef89786909"), 1, "She", 14 },
                    { new Guid("1fb916f4-c4f3-4982-9ccf-831a2e4c7418"), new Guid("33864b46-810c-4fad-aee0-05e42b413e6a"), 4, "have", 13 },
                    { new Guid("2075c28d-c8f0-47ce-afec-6076439c2414"), new Guid("4bfb0f3d-91d4-42c6-ad20-dd66a700d43c"), 4, "a", 6 },
                    { new Guid("21224da0-d994-43bc-a255-de2196e45fe8"), new Guid("d54d614b-f911-4fd8-9932-eead5f63eb74"), 8, "light.", 10 },
                    { new Guid("21808835-84a9-4e8c-b3c2-563e6be681c4"), new Guid("2050e871-9095-4f46-8787-8f717f114ea2"), 3, "us.", 14 },
                    { new Guid("21920bdb-4390-475e-beb1-10dd28a50f6c"), new Guid("f1bb33c6-6457-442a-a937-24ec243a7dcc"), 1, "I", 14 },
                    { new Guid("2261abb1-1534-44d4-a768-8e98fe9de468"), new Guid("0fee6686-f59a-4025-9184-858d1c0a3659"), 4, "to", 12 },
                    { new Guid("23eb8ecd-e716-4206-90f0-73ad6ce37ba9"), new Guid("49c84e13-c9a2-4665-b563-7c1f686c8b8d"), 3, "pens", 10 },
                    { new Guid("24abd950-c84f-48a0-b13f-08ba1687c5b0"), new Guid("ef5c8e17-28a7-4673-97d7-ab3f84d01aa3"), 3, "a", 6 },
                    { new Guid("257f0144-0d8e-4279-a661-e9bc84cc51b9"), new Guid("768101f9-4a4b-43cd-aa34-faf712bfc940"), 1, "They", 14 },
                    { new Guid("266558c2-e7d4-4e5f-8cd3-7eafdf2011f2"), new Guid("84b9001f-564e-42c5-a864-eefa2f289f3b"), 5, "letter", 10 },
                    { new Guid("26d06311-6cdd-4c3a-8b41-de88737744d3"), new Guid("7c07747b-ded1-4c2e-9a36-17f95fc059f7"), 5, "the", 6 },
                    { new Guid("272ab11f-0596-4785-8171-da054b2b84ef"), new Guid("33864b46-810c-4fad-aee0-05e42b413e6a"), 9, "the", 6 },
                    { new Guid("27315754-f175-442f-9dd6-bd085d5671a4"), new Guid("d54d614b-f911-4fd8-9932-eead5f63eb74"), 1, "Your", 14 },
                    { new Guid("27537960-216d-4b1d-8bb4-78439eac8a60"), new Guid("00242767-9606-4d08-b96b-7a1498a6d0c9"), 4, "bad", 1 },
                    { new Guid("278c23b6-05bd-4754-b429-497912a42875"), new Guid("eaacd632-357b-4473-8bc4-e64338f16811"), 3, "have", 13 },
                    { new Guid("27c9922e-941c-4bc5-9c8b-008ce763ffbb"), new Guid("765b06a2-50d6-4c56-8845-143e7ee7c733"), 1, "This", 14 },
                    { new Guid("27f25c91-155d-47b4-8bf2-efaaa27df03d"), new Guid("c5406625-55a2-488f-9050-a5ab649cd3ce"), 5, "cup", 10 },
                    { new Guid("28ff38f3-8e64-4579-bdc5-9423e6194b78"), new Guid("e89a87ca-93c7-489c-85e6-200a1192d751"), 2, "you", 14 },
                    { new Guid("2908b049-1a88-4e33-8203-2790d07d101e"), new Guid("67f7b904-927c-471f-8dfe-73f54adb9e03"), 4, "under", 12 },
                    { new Guid("2983a4ed-7605-4137-82cc-d600463fcc26"), new Guid("765b06a2-50d6-4c56-8845-143e7ee7c733"), 3, "is", 13 },
                    { new Guid("2a76843a-a886-4207-b62f-6cbc74fc9e16"), new Guid("1ce82652-e890-4a79-980a-de6a7291c4b6"), 2, "she", 14 },
                    { new Guid("2a94b158-6bfd-4f59-8b84-c72f0e6dbfe0"), new Guid("36411c85-2a47-415c-a396-ea52bcadd3e9"), 3, "feel", 16 },
                    { new Guid("2b6efff3-438b-4fc7-adb1-c8ad320cfd3a"), new Guid("e2ec419b-08c9-4295-86e1-e8846488b20c"), 3, "be", 13 },
                    { new Guid("2b80d104-f9ae-4578-b78a-57a163208e09"), new Guid("00242767-9606-4d08-b96b-7a1498a6d0c9"), 5, "the", 6 },
                    { new Guid("2c22b82e-c48e-41c6-bbf7-9ce9e1d31304"), new Guid("7ac50144-ad5f-4702-9d87-ea996e8904aa"), 2, "you", 14 },
                    { new Guid("2cf74112-88cd-47bd-bf91-647fbb1cbd87"), new Guid("74886f2d-4d3b-40fe-b96a-7524e9fe5b09"), 3, "love", 16 },
                    { new Guid("2efb2dc7-921d-49d8-98af-316f9d06e3ef"), new Guid("4bfb0f3d-91d4-42c6-ad20-dd66a700d43c"), 1, "Had", 13 },
                    { new Guid("2f1ce64d-be27-4b2c-957d-d40f9ca1c0da"), new Guid("9e891766-82ec-441e-affe-b3138b7a04db"), 5, "the", 6 },
                    { new Guid("2f209651-2072-46c1-92c6-e3129812872e"), new Guid("fd21cd86-2fdd-49a9-8447-0159f7756337"), 2, "was", 13 },
                    { new Guid("2fe50cce-1c56-4de6-8453-8f2ed7108ec8"), new Guid("6b9c1472-a03e-4854-bec8-cfc8bfb8e06c"), 4, "home", 10 },
                    { new Guid("300297c1-390b-422f-99dc-64deb2999633"), new Guid("e89a87ca-93c7-489c-85e6-200a1192d751"), 5, "in", 12 },
                    { new Guid("308453c4-8986-4fb7-a371-ea7667bceb8f"), new Guid("791f349a-79eb-431e-8c4a-29371d6e0689"), 2, "are not", 13 },
                    { new Guid("30dff33b-5d00-4ecb-b9bf-b416c8f09d3d"), new Guid("c5406625-55a2-488f-9050-a5ab649cd3ce"), 4, "a", 6 },
                    { new Guid("321e8ffb-7d75-4576-bd68-b3e3dfca321c"), new Guid("6d0cc462-65e5-48a1-beb0-b7cdb1f04045"), 6, "months", 10 },
                    { new Guid("32491f9a-68ce-4e50-a4fa-d1c80b3b754d"), new Guid("c5406625-55a2-488f-9050-a5ab649cd3ce"), 8, "windowsill.", 10 },
                    { new Guid("32993f7b-e974-4893-8253-dcde6a20011a"), new Guid("1bcbf50b-967d-49e2-84b8-aba447ac4954"), 5, "manager.", 10 },
                    { new Guid("32b4b79c-d5c1-42a3-8ff2-cb820748ab12"), new Guid("36411c85-2a47-415c-a396-ea52bcadd3e9"), 2, "they", 14 },
                    { new Guid("331879de-0917-43c8-a806-ca25a5b7ee26"), new Guid("bfca2c81-719c-4189-8e2d-027163421517"), 3, "just", 2 },
                    { new Guid("346a689f-179a-4643-a365-cbed0d294228"), new Guid("111b3155-8751-456a-8a77-f1c26ced8f18"), 8, "whole", 1 },
                    { new Guid("34f99364-0c8d-499d-a9b1-e210c6b44403"), new Guid("00242767-9606-4d08-b96b-7a1498a6d0c9"), 2, "are", 13 },
                    { new Guid("365704b7-4690-40fa-b7b4-721945e7d168"), new Guid("90a95bc6-f20f-4e55-b3ba-469f4fa589f7"), 4, "to", 12 },
                    { new Guid("38425870-c577-4f40-a441-137a9d7aa79e"), new Guid("c4f3b91f-1c7b-44a2-b32e-32ef0b1f0b11"), 8, "beginning", 16 },
                    { new Guid("38a2fd86-16c9-41da-89a0-471e668057a2"), new Guid("46eac2d6-1f33-4c2a-b420-e914de870deb"), 1, "I", 14 },
                    { new Guid("38f47fd9-8c91-42fa-a53a-42e3f773b649"), new Guid("d57af893-3fcf-463f-8722-03583c052ffc"), 5, "homework", 10 },
                    { new Guid("397ac297-9bf8-4043-ad0d-1fe48ccbb92a"), new Guid("bc4032b5-0b91-47da-8e6f-db283a515989"), 4, "tablet.", 10 },
                    { new Guid("3a6a0336-a316-40be-a931-19f9b334d814"), new Guid("00242767-9606-4d08-b96b-7a1498a6d0c9"), 8, "today.", 2 },
                    { new Guid("3a749c16-5c5a-4643-8a51-081e6603ff93"), new Guid("8650e3d8-d11f-461c-9f8a-b00e6379c348"), 1, "Will", 13 },
                    { new Guid("3aea664c-3b78-41b2-b46d-2bab83fac782"), new Guid("e7ac161c-561a-4ffe-81f7-b57b37b19e52"), 3, "down", 12 },
                    { new Guid("3af1a8f4-d043-4560-98e0-e961f621dea5"), new Guid("67f7b904-927c-471f-8dfe-73f54adb9e03"), 6, "table?", 10 },
                    { new Guid("3ba53ff9-55ec-47a8-bda4-7b2b3bfe7eef"), new Guid("08681ed3-8ab0-4a1d-967a-2c2806b3a099"), 1, "I", 14 },
                    { new Guid("3bb4cc15-9de1-418a-a77c-eeb97022aeea"), new Guid("ffd37b6b-c0c9-4f04-a7c1-f6dffb9eec21"), 1, "He", 14 },
                    { new Guid("3bddcffb-8d45-46e9-8e31-2c7f727bc520"), new Guid("00242767-9606-4d08-b96b-7a1498a6d0c9"), 1, "You", 14 },
                    { new Guid("3cdd0d98-8009-4cb3-915f-ae60410b6179"), new Guid("0919cab8-a02f-4da7-9b47-1a58351ea9c3"), 1, "Will", 13 },
                    { new Guid("3d94a2f9-d946-4442-adcc-1853c18a2a66"), new Guid("817ce59c-2207-420c-9dd7-db822ab79b4b"), 1, "She", 14 },
                    { new Guid("3edef03f-2c5c-405d-8e66-347bc84cf25c"), new Guid("fd21cd86-2fdd-49a9-8447-0159f7756337"), 3, "hot", 1 },
                    { new Guid("3ef49176-91ae-4057-8d91-08c2204f6ca5"), new Guid("0919cab8-a02f-4da7-9b47-1a58351ea9c3"), 4, "in", 12 },
                    { new Guid("3f096855-0418-4441-b5ad-7ed25e4004a2"), new Guid("2c900207-3d73-4b27-a482-f16ce64b7729"), 3, "cold?", 1 },
                    { new Guid("3f1101d0-303f-4d6e-97df-6c7b015db54a"), new Guid("111b3155-8751-456a-8a77-f1c26ced8f18"), 3, "be", 13 },
                    { new Guid("3f9dd1fa-a471-429c-9dae-7b04978c8c01"), new Guid("6e183839-2a73-44bf-b4e2-b3ab25613a5a"), 4, "weight.", 10 },
                    { new Guid("3fc45a1d-2e7e-4c1d-a63f-8bbe23b0bdb1"), new Guid("23c9e459-845c-4a74-96fa-5eda6187cb1f"), 3, "a", 6 },
                    { new Guid("406c1a27-235a-4a65-aa5a-a67696bd2c15"), new Guid("d54d614b-f911-4fd8-9932-eead5f63eb74"), 4, "to", 12 },
                    { new Guid("40b5eeb0-a9ed-4ba4-a360-f74be0e61c9f"), new Guid("61a06c06-8603-4dd3-8fe5-92f3364e3814"), 3, "show.", 16 },
                    { new Guid("40c59511-ba4d-415a-a077-36787b60a24d"), new Guid("b8a0d599-6575-4626-b2af-317f9e78efa4"), 6, "letter", 10 },
                    { new Guid("41381c8d-ed1e-4be0-a8ce-36ed3dcd7454"), new Guid("aee272ba-c84e-4fe4-a8ea-49386db26adb"), 6, "goods", 10 },
                    { new Guid("4177d8d8-ab32-4267-8139-53e959a69a1f"), new Guid("d57af893-3fcf-463f-8722-03583c052ffc"), 2, "he", 14 },
                    { new Guid("424da8c5-d636-449e-b413-0ff958d02fb6"), new Guid("4bfb0f3d-91d4-42c6-ad20-dd66a700d43c"), 2, "he", 14 },
                    { new Guid("4281fc8f-b215-409b-a266-a457f372a658"), new Guid("8650e3d8-d11f-461c-9f8a-b00e6379c348"), 2, "he", 14 },
                    { new Guid("428e266c-7038-4760-a0c4-85412ff38c15"), new Guid("8d53f533-4cdc-4e5a-a963-54f31febf8e5"), 3, "study", 16 },
                    { new Guid("43af24e5-74d9-4583-826d-82bf37a59326"), new Guid("7c07747b-ded1-4c2e-9a36-17f95fc059f7"), 6, "station", 10 },
                    { new Guid("43c4cac2-8fdb-46e2-83ee-0b01b6fb3cfa"), new Guid("43d627bb-e3ed-4a8d-81b9-8e0212a3a8a0"), 2, "broke", 16 },
                    { new Guid("4428f056-f48c-4d8e-87fe-a5a601640dde"), new Guid("f1bb33c6-6457-442a-a937-24ec243a7dcc"), 5, "the", 6 },
                    { new Guid("45a8252a-7ff7-4723-b873-b0651fed7650"), new Guid("2958e0a7-9ebc-463a-9f87-5a98ab680449"), 1, "There", 2 },
                    { new Guid("467d7c72-6c2d-44cc-a93f-a9635cc88f96"), new Guid("aee272ba-c84e-4fe4-a8ea-49386db26adb"), 1, "They", 14 },
                    { new Guid("4696e43d-ceb4-49e6-811b-91955c83c761"), new Guid("47124eb6-a2d1-4b91-9e5d-5a85169625c8"), 8, "you", 14 },
                    { new Guid("46b64731-f69e-4a76-b4e8-a04b5463f31e"), new Guid("2233f2a0-b9c6-4072-8ace-ea274ebf6cf4"), 5, "seen", 16 },
                    { new Guid("4765e15e-c2f8-44e8-aa23-404b017ad7c8"), new Guid("e2ec419b-08c9-4295-86e1-e8846488b20c"), 2, "will", 13 },
                    { new Guid("477daf13-182d-4d0e-911c-41330e22c8ca"), new Guid("1a04722f-1b4d-4730-b1f0-4fa2f8d71bd7"), 2, "were", 13 },
                    { new Guid("47906dc4-c353-41c6-8023-db035c1cf11d"), new Guid("ad46e855-9605-4d41-9eac-2c8dfa2f7c1f"), 1, "I", 14 },
                    { new Guid("49530039-6beb-4e5a-a204-928549bde57a"), new Guid("38df6419-b7c7-4f23-ae70-6ddadf05db9f"), 5, "the", 6 },
                    { new Guid("4c16bf0f-d467-42cf-a273-7aaf35a3700c"), new Guid("865496b8-3788-4cc3-8f6a-09dfebcd2d9b"), 2, "he", 14 },
                    { new Guid("4c444550-1f40-441d-927e-8222587945de"), new Guid("cef21bb8-1373-4236-9b2b-703377c974bf"), 1, "Do", 13 },
                    { new Guid("4df4d2a6-16de-4b4c-af4d-dc2c14fe91c4"), new Guid("35a00634-becb-46a3-bc3d-a73bb2b46ab1"), 5, "a", 6 },
                    { new Guid("4e9ab62c-6b49-4c0f-b133-d29769a87875"), new Guid("2233f2a0-b9c6-4072-8ace-ea274ebf6cf4"), 4, "have", 13 },
                    { new Guid("4f282a23-c9c1-415e-bae1-b17560c205a0"), new Guid("768101f9-4a4b-43cd-aa34-faf712bfc940"), 9, "end", 10 },
                    { new Guid("5000f800-ca2c-4d13-a662-4ffea05ca8af"), new Guid("928acaf1-743e-4c3e-bdfa-e24d0e6ff485"), 6, "the", 6 },
                    { new Guid("500b7e09-ba16-408a-a3d8-a2f257c2d4ba"), new Guid("dc63683b-d306-4203-9cce-452d0f828491"), 5, "on", 12 },
                    { new Guid("5028e234-1f5d-4ba6-aa05-f1b16486aaad"), new Guid("2c900207-3d73-4b27-a482-f16ce64b7729"), 2, "I", 14 },
                    { new Guid("50ae70f4-480e-455e-a52a-5d8d70118fce"), new Guid("768101f9-4a4b-43cd-aa34-faf712bfc940"), 11, "the", 6 },
                    { new Guid("50eb0628-d989-4161-989a-5ba449cde161"), new Guid("8de0af24-b98a-4f94-8974-aa3c51220f09"), 7, "day", 10 },
                    { new Guid("51208adb-93ea-4db5-ac32-67eaea7bd131"), new Guid("ffd37b6b-c0c9-4f04-a7c1-f6dffb9eec21"), 7, "four", 8 },
                    { new Guid("51c4d966-be64-42d0-a4e3-ad4922d104ee"), new Guid("dc63683b-d306-4203-9cce-452d0f828491"), 1, "There", 2 },
                    { new Guid("51d415aa-98e5-4bd7-8c8f-c67b7f3a6947"), new Guid("30da8a31-852f-4cfc-89e1-c754bd83ad25"), 4, "expensive.", 4 },
                    { new Guid("522ec4a7-741b-4be4-92ff-e498563dd758"), new Guid("2958e0a7-9ebc-463a-9f87-5a98ab680449"), 5, "the", 6 },
                    { new Guid("52e7aad3-30ca-44fa-a8a4-2b88f61772c1"), new Guid("8de0af24-b98a-4f94-8974-aa3c51220f09"), 3, "studying", 16 },
                    { new Guid("53f5e181-64e5-43c0-9562-5cbea6811051"), new Guid("c4f3b91f-1c7b-44a2-b32e-32ef0b1f0b11"), 1, "I", 14 },
                    { new Guid("54108911-2328-445f-bf8a-2908b6222b8f"), new Guid("aee272ba-c84e-4fe4-a8ea-49386db26adb"), 2, "will not", 13 },
                    { new Guid("5472005a-376a-417e-88a3-4e0132bc1fd0"), new Guid("768101f9-4a4b-43cd-aa34-faf712bfc940"), 2, "will not", 13 },
                    { new Guid("55447a54-afdb-41e3-9c03-fb7f91923d9b"), new Guid("aee272ba-c84e-4fe4-a8ea-49386db26adb"), 10, "arrives.", 16 },
                    { new Guid("55a69679-d8fe-475f-be5a-206bb3f188dc"), new Guid("1bcbf50b-967d-49e2-84b8-aba447ac4954"), 2, "will not", 13 },
                    { new Guid("55e5d5d0-0f55-420f-b32c-ba246b59a013"), new Guid("aee272ba-c84e-4fe4-a8ea-49386db26adb"), 8, "your", 14 },
                    { new Guid("560cde4e-f0ee-421d-bfa2-4d36e66534e2"), new Guid("be20ccf4-be83-4bc4-b08f-5c2bd02dda01"), 1, "We", 14 },
                    { new Guid("567b7275-6054-4e4a-94a6-e288f8363cdf"), new Guid("c4f3b91f-1c7b-44a2-b32e-32ef0b1f0b11"), 9, "of", 12 },
                    { new Guid("569920d1-aac7-4344-b056-807b8ca638c9"), new Guid("b8a0d599-6575-4626-b2af-317f9e78efa4"), 1, "I", 14 },
                    { new Guid("56b5f97a-705c-4156-a3ef-5295d50c8e02"), new Guid("d57af893-3fcf-463f-8722-03583c052ffc"), 9, "returned", 16 },
                    { new Guid("59ca1c35-0b5a-4f84-b93d-c913790ce636"), new Guid("43d627bb-e3ed-4a8d-81b9-8e0212a3a8a0"), 1, "He", 14 },
                    { new Guid("5a1c413a-13a0-42ef-b411-032cc7e4c6bb"), new Guid("4bfb0f3d-91d4-42c6-ad20-dd66a700d43c"), 6, "when", 15 },
                    { new Guid("5a5555c5-9d2b-4b4e-a8b8-10f71072cca5"), new Guid("077d1b35-28e8-411f-956a-4ac8883d27b8"), 3, "sees.", 16 },
                    { new Guid("5b07930a-b5a9-4dc5-9b90-ccb7a9dc72d5"), new Guid("bfca2c81-719c-4189-8e2d-027163421517"), 4, "gone", 16 },
                    { new Guid("5bdc5e76-b828-4573-ace4-657774403822"), new Guid("ffd37b6b-c0c9-4f04-a7c1-f6dffb9eec21"), 5, "letter", 10 },
                    { new Guid("5c43af33-3bb9-414b-b4a5-d5f7bc2871fc"), new Guid("35a00634-becb-46a3-bc3d-a73bb2b46ab1"), 6, "company", 10 },
                    { new Guid("5c855ee6-4516-4d05-acae-d1ef64f8d529"), new Guid("111b3155-8751-456a-8a77-f1c26ced8f18"), 10, "tomorrow.", 2 },
                    { new Guid("5da1971f-eebb-426f-bb84-3169140f44af"), new Guid("928acaf1-743e-4c3e-bdfa-e24d0e6ff485"), 5, "from", 12 },
                    { new Guid("5e629c96-9013-41a6-a847-6798ece7289c"), new Guid("791f349a-79eb-431e-8c4a-29371d6e0689"), 4, "accountants.", 10 },
                    { new Guid("5f27046a-a728-449c-a755-d109b6da6305"), new Guid("dc63683b-d306-4203-9cce-452d0f828491"), 4, "pen", 10 },
                    { new Guid("5f5fdc25-89d4-4f9c-8401-c5efd998ba9b"), new Guid("1bcbf50b-967d-49e2-84b8-aba447ac4954"), 3, "be", 13 },
                    { new Guid("5f945157-896d-48b1-8e20-7a00471e08ea"), new Guid("765b06a2-50d6-4c56-8845-143e7ee7c733"), 6, "that", 14 },
                    { new Guid("627d6fbd-7f21-4ea0-abf3-3bd8a2b35dd9"), new Guid("b8a0d599-6575-4626-b2af-317f9e78efa4"), 9, "friend.", 10 },
                    { new Guid("62ac119a-e639-4f67-9f3e-55fa6d7cd5b8"), new Guid("4bfb0f3d-91d4-42c6-ad20-dd66a700d43c"), 8, "came", 16 },
                    { new Guid("63cc78de-a8c1-45a1-ab22-111912655b0f"), new Guid("077d1b35-28e8-411f-956a-4ac8883d27b8"), 1, "He", 14 },
                    { new Guid("6453673f-5504-4ab4-b8e2-7c24f203de86"), new Guid("dbdc7990-cb51-4e30-96cd-17e3fa20dafa"), 3, "just", 2 },
                    { new Guid("6460ee32-2853-4473-a201-3e2224e43e8d"), new Guid("c5406625-55a2-488f-9050-a5ab649cd3ce"), 7, "the", 6 },
                    { new Guid("6528d303-346e-445b-b136-51fd70bd6729"), new Guid("1ce82652-e890-4a79-980a-de6a7291c4b6"), 3, "in", 12 },
                    { new Guid("652c0794-6156-416c-a128-491725321eb3"), new Guid("1bcbf50b-967d-49e2-84b8-aba447ac4954"), 4, "a", 6 },
                    { new Guid("6588c771-0bb9-4f04-9bba-30f92b2cbf94"), new Guid("d57af893-3fcf-463f-8722-03583c052ffc"), 1, "Had", 13 },
                    { new Guid("6602a985-8f69-42f4-8613-b9276301aafa"), new Guid("817ce59c-2207-420c-9dd7-db822ab79b4b"), 3, "adult.", 1 },
                    { new Guid("66a08680-1bb8-4001-9dc5-043eb48751cc"), new Guid("765b06a2-50d6-4c56-8845-143e7ee7c733"), 5, "than", 12 },
                    { new Guid("66bc5768-f578-44f3-b926-b189a362362a"), new Guid("bc4032b5-0b91-47da-8e6f-db283a515989"), 2, "take", 16 },
                    { new Guid("66c731f0-af6a-4112-838a-cbf97c89107f"), new Guid("9e891766-82ec-441e-affe-b3138b7a04db"), 4, "on", 12 },
                    { new Guid("671e2459-df4e-4b0b-9da1-d800e860b8c7"), new Guid("e2ec419b-08c9-4295-86e1-e8846488b20c"), 5, "ball", 10 },
                    { new Guid("677348c2-4480-4101-8c6f-f49add7ed2d3"), new Guid("90a95bc6-f20f-4e55-b3ba-469f4fa589f7"), 2, "didn't", 13 },
                    { new Guid("67bd4bb6-259c-417c-954e-9a43a7219f69"), new Guid("dc63683b-d306-4203-9cce-452d0f828491"), 7, "table.", 10 },
                    { new Guid("68200191-b99e-4ebb-b949-04e9e04d87c5"), new Guid("47124eb6-a2d1-4b91-9e5d-5a85169625c8"), 9, "return.", 16 },
                    { new Guid("68f9e3b5-e5ce-4c11-ab67-db2691b0df64"), new Guid("7c07747b-ded1-4c2e-9a36-17f95fc059f7"), 9, "had", 13 },
                    { new Guid("69a301a0-6347-4bbe-913f-9c4207c6cf2e"), new Guid("46eac2d6-1f33-4c2a-b420-e914de870deb"), 2, "will", 13 },
                    { new Guid("69c1127c-c1b5-41f0-be18-e6d57b53e584"), new Guid("7c07747b-ded1-4c2e-9a36-17f95fc059f7"), 11, "gone.", 16 },
                    { new Guid("6a09af9a-18b7-4d87-9b51-71dc5dda39df"), new Guid("00242767-9606-4d08-b96b-7a1498a6d0c9"), 7, "day", 10 },
                    { new Guid("6b1a7094-a595-47a1-bb02-d27157f8b986"), new Guid("2233f2a0-b9c6-4072-8ace-ea274ebf6cf4"), 6, "you", 14 },
                    { new Guid("6b36c77c-1546-40c4-9d9b-a6400167e68c"), new Guid("08ed1ce8-96e5-45ff-b10f-8fa49a1af3d4"), 6, "that", 14 },
                    { new Guid("6c816a53-134a-40c2-8785-eeeb3baeeea4"), new Guid("1ce82652-e890-4a79-980a-de6a7291c4b6"), 4, "the", 6 },
                    { new Guid("6c8da8d4-8cd5-43f2-afb3-07e5f70fb6c0"), new Guid("90a95bc6-f20f-4e55-b3ba-469f4fa589f7"), 3, "like", 16 },
                    { new Guid("6d9a80c0-0c46-4c3d-b9f0-36d10f687479"), new Guid("74886f2d-4d3b-40fe-b96a-7524e9fe5b09"), 6, "the", 6 },
                    { new Guid("6dfded7a-b11c-49ef-abc8-85933c988f71"), new Guid("5c96d301-355b-445f-a153-07ef89786909"), 3, "answer.", 16 },
                    { new Guid("6e2bba52-4ff8-4d86-a0ba-1e3c4be4060a"), new Guid("fd21cd86-2fdd-49a9-8447-0159f7756337"), 1, "It", 14 },
                    { new Guid("6e38e15f-dd81-472d-ae16-9cac606d1353"), new Guid("0fee6686-f59a-4025-9184-858d1c0a3659"), 5, "forget?", 16 },
                    { new Guid("6e763f8f-89c5-4689-87af-422682c01d6c"), new Guid("c5406625-55a2-488f-9050-a5ab649cd3ce"), 2, "will", 13 },
                    { new Guid("6e9772b5-74dd-43f3-98ce-788a00e14b54"), new Guid("21983f75-6289-4334-9372-c88a81690e96"), 2, "to", 12 },
                    { new Guid("6ecd7193-0683-415a-86a8-074fffd57091"), new Guid("7c07747b-ded1-4c2e-9a36-17f95fc059f7"), 7, "the", 6 },
                    { new Guid("703a1892-9825-4098-be7b-6f84dcee99ea"), new Guid("4afa32ae-daa4-45ed-92ea-f910b90116c1"), 3, "be", 13 },
                    { new Guid("707783fe-97c0-4dba-bb21-aa2d52123af3"), new Guid("21983f75-6289-4334-9372-c88a81690e96"), 3, "her.", 14 },
                    { new Guid("708347f3-e9b7-41e4-b8b4-4138722654d4"), new Guid("c6453de7-f75d-49bf-ac53-4944dac3b288"), 1, "Should", 9 },
                    { new Guid("717bae65-4abe-413a-9732-a242710dbbbf"), new Guid("ffd37b6b-c0c9-4f04-a7c1-f6dffb9eec21"), 2, "was", 13 },
                    { new Guid("71af8e78-182c-48fe-ade6-a27017651d8a"), new Guid("eaacd632-357b-4473-8bc4-e64338f16811"), 5, "eyes.", 10 },
                    { new Guid("72640d74-b354-4ab5-9ab2-5ea03798409a"), new Guid("768101f9-4a4b-43cd-aa34-faf712bfc940"), 6, "games", 10 },
                    { new Guid("72742f65-67dd-4c57-8449-b5b5a1609764"), new Guid("43d627bb-e3ed-4a8d-81b9-8e0212a3a8a0"), 3, "down", 12 },
                    { new Guid("72752394-e545-406d-8d55-6da48c02f6c0"), new Guid("11af84dc-c777-46c9-ba7e-8fc836a804f0"), 4, "somebody.", 5 },
                    { new Guid("72fb7340-c690-4cca-a91b-25da598d5a7b"), new Guid("765b06a2-50d6-4c56-8845-143e7ee7c733"), 2, "pen", 10 },
                    { new Guid("732a3832-113c-4ba7-a746-6bb670c93ffd"), new Guid("ffd37b6b-c0c9-4f04-a7c1-f6dffb9eec21"), 10, "yesterday.", 2 },
                    { new Guid("733d0bbc-8270-4caf-a24f-963329e67456"), new Guid("df7940f8-70aa-4e17-9df0-2bb4a46d6d7d"), 1, "We", 14 },
                    { new Guid("73414b2c-a7d9-4dd3-91f6-88dc99bcb8a8"), new Guid("8de0af24-b98a-4f94-8974-aa3c51220f09"), 2, "were", 13 },
                    { new Guid("737097e9-de20-410c-bc66-27b77bd53544"), new Guid("35e343ce-74c5-4413-a75a-48e29d6ee031"), 2, "will not", 13 },
                    { new Guid("75f8a4ab-c767-4157-896c-fc84eae79a95"), new Guid("6e183839-2a73-44bf-b4e2-b3ab25613a5a"), 2, "took", 16 },
                    { new Guid("76c2297a-a2b1-456f-9d4a-5ab2682638b8"), new Guid("c6453de7-f75d-49bf-ac53-4944dac3b288"), 2, "I", 14 },
                    { new Guid("77685fed-77f1-4f1e-9588-546f7d3fb88a"), new Guid("ad46e855-9605-4d41-9eac-2c8dfa2f7c1f"), 2, "was", 13 },
                    { new Guid("77847680-fa92-4498-a05a-98136ff91d59"), new Guid("b8a0d599-6575-4626-b2af-317f9e78efa4"), 3, "already", 2 },
                    { new Guid("78d4a6b6-a0ab-4fe8-96b8-fabfc0f328cb"), new Guid("33864b46-810c-4fad-aee0-05e42b413e6a"), 1, "The", 6 },
                    { new Guid("79d81445-9365-42b8-80e5-e4908b29548d"), new Guid("111b3155-8751-456a-8a77-f1c26ced8f18"), 9, "day", 10 },
                    { new Guid("7a5d6144-892c-44f3-9923-4e6acc1942dc"), new Guid("e7ac161c-561a-4ffe-81f7-b57b37b19e52"), 2, "went", 16 },
                    { new Guid("7aa420aa-09fe-4b85-943b-3456c86785d1"), new Guid("e2ec419b-08c9-4295-86e1-e8846488b20c"), 7, "the", 6 },
                    { new Guid("7b0f7fb3-098d-4052-b082-62f49c1f524a"), new Guid("38df6419-b7c7-4f23-ae70-6ddadf05db9f"), 6, "evening.", 10 },
                    { new Guid("7bdd30d0-623f-4d51-a001-b15827933323"), new Guid("768101f9-4a4b-43cd-aa34-faf712bfc940"), 10, "of", 12 },
                    { new Guid("7be612de-5330-4659-b025-bf115ac919a7"), new Guid("be20ccf4-be83-4bc4-b08f-5c2bd02dda01"), 3, "to", 12 },
                    { new Guid("7c1524ad-d7cd-48d1-a364-56c5536d0ec1"), new Guid("47124eb6-a2d1-4b91-9e5d-5a85169625c8"), 2, "will", 13 },
                    { new Guid("7ce0bf95-5d93-40d6-a3ca-581b53aae524"), new Guid("0fee6686-f59a-4025-9184-858d1c0a3659"), 2, "she", 14 },
                    { new Guid("7d021962-57d7-4ca2-bf30-9259ee5ab868"), new Guid("74886f2d-4d3b-40fe-b96a-7524e9fe5b09"), 2, "she", 14 },
                    { new Guid("7d12de65-1ed1-4ff4-b370-48431ed33498"), new Guid("e7ac161c-561a-4ffe-81f7-b57b37b19e52"), 1, "He", 14 },
                    { new Guid("7d2989d7-5f2e-40ab-b1ea-0f702d0bc7f9"), new Guid("9e891766-82ec-441e-affe-b3138b7a04db"), 2, "he", 14 },
                    { new Guid("7d58002a-d39b-4c5e-b2fe-707333b67143"), new Guid("11af84dc-c777-46c9-ba7e-8fc836a804f0"), 2, "will", 13 },
                    { new Guid("7dcce746-1b9b-404a-bc7f-6144dd47998c"), new Guid("c4f3b91f-1c7b-44a2-b32e-32ef0b1f0b11"), 5, "project", 10 },
                    { new Guid("7df7d199-1fc6-4931-bacd-712a6c31e854"), new Guid("077d1b35-28e8-411f-956a-4ac8883d27b8"), 2, "never", 2 },
                    { new Guid("8021ff3e-eb1b-446a-9b73-adef0d0ae9d2"), new Guid("6d0cc462-65e5-48a1-beb0-b7cdb1f04045"), 7, "ago.", 12 },
                    { new Guid("81b8079b-2f6b-4063-b3e1-ba1de92ead70"), new Guid("5c96d301-355b-445f-a153-07ef89786909"), 2, "must not", 9 },
                    { new Guid("821a3374-ff1a-43a7-8424-e0acb0da3668"), new Guid("9d53c467-f7e8-4433-971c-5e7cb7ce6a71"), 1, "We", 14 },
                    { new Guid("837f7298-f17e-4889-934d-bbe3928cf78a"), new Guid("46eac2d6-1f33-4c2a-b420-e914de870deb"), 3, "tell", 16 },
                    { new Guid("83b288db-82cd-4af4-a50e-a155ea33e4d1"), new Guid("928acaf1-743e-4c3e-bdfa-e24d0e6ff485"), 1, "You", 14 },
                    { new Guid("841ee253-d742-4016-8a23-c0cf75f73d82"), new Guid("2958e0a7-9ebc-463a-9f87-5a98ab680449"), 4, "under", 12 },
                    { new Guid("85513d45-bd3f-4167-8a8b-f36285fae04e"), new Guid("30da8a31-852f-4cfc-89e1-c754bd83ad25"), 1, "This", 14 },
                    { new Guid("857e0dc5-fb65-413b-971a-ddd902925cb2"), new Guid("d54d614b-f911-4fd8-9932-eead5f63eb74"), 3, "asks", 16 },
                    { new Guid("85f93e77-bc2c-4379-9ced-204048d04d89"), new Guid("f1bb33c6-6457-442a-a937-24ec243a7dcc"), 8, "tonight.", 2 },
                    { new Guid("86b26bee-9175-40e4-8b05-a00fc03c9fc8"), new Guid("791f349a-79eb-431e-8c4a-29371d6e0689"), 3, "their", 14 },
                    { new Guid("8707ff38-f985-4c03-b1bd-c3aa5b1d1a39"), new Guid("4bfb0f3d-91d4-42c6-ad20-dd66a700d43c"), 5, "letter,", 10 },
                    { new Guid("87b5243c-e90d-412e-bb1f-3e442f84dd09"), new Guid("33864b46-810c-4fad-aee0-05e42b413e6a"), 6, "their", 14 },
                    { new Guid("882ace04-92bf-49a8-a68d-2905e2ac9bcc"), new Guid("08681ed3-8ab0-4a1d-967a-2c2806b3a099"), 2, "have", 13 },
                    { new Guid("8848d718-531f-4e71-af3a-41492049bdf5"), new Guid("35e343ce-74c5-4413-a75a-48e29d6ee031"), 1, "We", 14 },
                    { new Guid("88b94e99-be58-4865-9a81-91a69665b91a"), new Guid("47294d03-3395-42a6-83d8-389d19aec14d"), 2, "prices", 10 },
                    { new Guid("88eadca0-4df9-4cae-b62a-499308be8000"), new Guid("817ce59c-2207-420c-9dd7-db822ab79b4b"), 2, "is", 13 },
                    { new Guid("8908d843-f524-47cb-b23e-643c2ed0c3b0"), new Guid("111b3155-8751-456a-8a77-f1c26ced8f18"), 7, "the", 6 },
                    { new Guid("8a5828fa-1591-453a-9d47-3326c055cf07"), new Guid("08ed1ce8-96e5-45ff-b10f-8fa49a1af3d4"), 2, "pen", 10 },
                    { new Guid("8a85b8cb-1af7-4169-b469-4d4f44f011f0"), new Guid("38df6419-b7c7-4f23-ae70-6ddadf05db9f"), 4, "in", 12 },
                    { new Guid("8aa66574-fa04-4662-8eeb-a9da3d191e6d"), new Guid("6e183839-2a73-44bf-b4e2-b3ab25613a5a"), 3, "off", 12 },
                    { new Guid("8ab20b3e-dc0e-47c3-aa2b-3c22535b2c59"), new Guid("865496b8-3788-4cc3-8f6a-09dfebcd2d9b"), 1, "Will", 13 },
                    { new Guid("8b2b57b7-4263-497d-8717-39a153ba8868"), new Guid("bfca2c81-719c-4189-8e2d-027163421517"), 2, "has", 13 },
                    { new Guid("8b3f1810-d77e-40ed-9602-3b010393f2f7"), new Guid("6d0cc462-65e5-48a1-beb0-b7cdb1f04045"), 1, "She", 14 },
                    { new Guid("8be099e9-4c51-4a1a-bc5d-1a7d8a6ecfc9"), new Guid("928acaf1-743e-4c3e-bdfa-e24d0e6ff485"), 2, "will not", 13 },
                    { new Guid("8d193de8-5148-418e-b0f4-9178cb91c947"), new Guid("6b9c1472-a03e-4854-bec8-cfc8bfb8e06c"), 1, "You", 14 },
                    { new Guid("8d2e9dba-596e-48ed-90ee-016f252a58d9"), new Guid("35a00634-becb-46a3-bc3d-a73bb2b46ab1"), 1, "Did", 13 },
                    { new Guid("8dab255b-b429-4987-8dc8-fa76cac2947c"), new Guid("47124eb6-a2d1-4b91-9e5d-5a85169625c8"), 7, "before", 12 },
                    { new Guid("8e008156-c553-44b0-bb4b-2b871a23b084"), new Guid("0919cab8-a02f-4da7-9b47-1a58351ea9c3"), 2, "he", 14 },
                    { new Guid("8e55a6ff-fe4d-4f28-986a-918ab9cfbebd"), new Guid("3953a15c-4d98-4b8d-b5a0-a2bbe4449fe9"), 3, "healthy.", 1 },
                    { new Guid("8f3858f2-50ab-47a2-bcb1-2cc1f45066f7"), new Guid("33864b46-810c-4fad-aee0-05e42b413e6a"), 2, "pupils", 10 },
                    { new Guid("8f870d79-d57e-4f7b-ab9d-6c61ab3c64a4"), new Guid("2958e0a7-9ebc-463a-9f87-5a98ab680449"), 3, "knives", 10 },
                    { new Guid("8fe5d0ba-5fb2-416c-8df7-effe5df4a477"), new Guid("9d53c467-f7e8-4433-971c-5e7cb7ce6a71"), 3, "feel.", 16 },
                    { new Guid("9045b07b-ed8a-4095-b478-ab3be52d4aa1"), new Guid("be20ccf4-be83-4bc4-b08f-5c2bd02dda01"), 5, "managers.", 10 },
                    { new Guid("92350aae-d25e-485a-ac06-3244edd8d966"), new Guid("865496b8-3788-4cc3-8f6a-09dfebcd2d9b"), 3, "be", 13 },
                    { new Guid("92c54277-2d4f-44cc-b95b-a940909454fd"), new Guid("61a06c06-8603-4dd3-8fe5-92f3364e3814"), 1, "We", 14 },
                    { new Guid("93ab2fa6-2a8a-46c8-b5c2-7cb99abac0b0"), new Guid("ffd37b6b-c0c9-4f04-a7c1-f6dffb9eec21"), 9, "ten", 8 },
                    { new Guid("93e9e66e-ffe9-4723-a092-5223a6843f7a"), new Guid("1ce82652-e890-4a79-980a-de6a7291c4b6"), 5, "elevator?", 10 },
                    { new Guid("94d11980-9385-4eff-a913-00ffd4ed7186"), new Guid("23c9e459-845c-4a74-96fa-5eda6187cb1f"), 6, "the", 6 },
                    { new Guid("9560026b-c0da-4560-b900-1b9a98a5481b"), new Guid("2233f2a0-b9c6-4072-8ace-ea274ebf6cf4"), 2, "think", 16 },
                    { new Guid("95a730b1-31f2-4b4e-9735-87d58e052f46"), new Guid("49c84e13-c9a2-4665-b563-7c1f686c8b8d"), 1, "There", 2 },
                    { new Guid("965a710f-7c23-44b0-a714-aaa668453c9f"), new Guid("4afa32ae-daa4-45ed-92ea-f910b90116c1"), 7, "room.", 10 },
                    { new Guid("96eb6e4f-b46c-471f-ad4a-3a3412960b91"), new Guid("d57af893-3fcf-463f-8722-03583c052ffc"), 7, "his", 13 },
                    { new Guid("96eec7f3-f76c-4271-ac3c-0a34afb3afc5"), new Guid("08ed1ce8-96e5-45ff-b10f-8fa49a1af3d4"), 5, "than", 12 },
                    { new Guid("98060567-e398-4547-8a91-4240835a1865"), new Guid("49c84e13-c9a2-4665-b563-7c1f686c8b8d"), 5, "the", 6 },
                    { new Guid("986fcb90-274c-47d9-b70c-11a84413ae47"), new Guid("3953a15c-4d98-4b8d-b5a0-a2bbe4449fe9"), 2, "are", 13 },
                    { new Guid("99689641-1265-4733-8d29-e079c828d4f4"), new Guid("e89a87ca-93c7-489c-85e6-200a1192d751"), 1, "Will", 13 },
                    { new Guid("99b4410a-a72f-4859-ae70-3300d702a593"), new Guid("e2ec419b-08c9-4295-86e1-e8846488b20c"), 1, "There", 2 },
                    { new Guid("99beea68-6adb-460d-87c7-62a1f904cd39"), new Guid("6b9c1472-a03e-4854-bec8-cfc8bfb8e06c"), 7, "rain", 10 },
                    { new Guid("9b6b5072-2abd-4894-8171-d93d23fac035"), new Guid("0fee6686-f59a-4025-9184-858d1c0a3659"), 3, "want", 16 },
                    { new Guid("9cb3c19c-6e84-44c7-a01f-e963f5fa9f99"), new Guid("08681ed3-8ab0-4a1d-967a-2c2806b3a099"), 5, "work.", 16 },
                    { new Guid("9e1232c7-afe0-4b98-8611-cef575ba0287"), new Guid("4afa32ae-daa4-45ed-92ea-f910b90116c1"), 6, "the", 6 },
                    { new Guid("9e56a7d1-d998-412c-b23c-c2f9a6cfc069"), new Guid("1a04722f-1b4d-4730-b1f0-4fa2f8d71bd7"), 4, "historians.", 10 },
                    { new Guid("9ecae500-6486-4150-af21-e9342099d63d"), new Guid("928acaf1-743e-4c3e-bdfa-e24d0e6ff485"), 3, "out", 2 },
                    { new Guid("9ef2fedb-1ef1-44e4-838c-81b6b133c4d9"), new Guid("4afa32ae-daa4-45ed-92ea-f910b90116c1"), 1, "There", 2 },
                    { new Guid("9f9f764a-f436-4d49-9e69-82a005c0fef1"), new Guid("dc63683b-d306-4203-9cce-452d0f828491"), 3, "a", 6 },
                    { new Guid("9fadd129-9cfa-4d26-a8bd-1a3065174a0c"), new Guid("d57af893-3fcf-463f-8722-03583c052ffc"), 8, "parents", 10 },
                    { new Guid("a0545d9d-9f57-49ed-8df8-ee7d530a6faf"), new Guid("6d0cc462-65e5-48a1-beb0-b7cdb1f04045"), 5, "six", 8 },
                    { new Guid("a0b97346-fcf9-4317-978a-c3e0125d8c95"), new Guid("f1bb33c6-6457-442a-a937-24ec243a7dcc"), 7, "by", 12 },
                    { new Guid("a113bf16-cf4f-46bf-9994-be81e1bfb5f4"), new Guid("23c9e459-845c-4a74-96fa-5eda6187cb1f"), 2, "there", 2 },
                    { new Guid("a12a96c4-7af0-4a61-b87d-5c6ebf9e074c"), new Guid("6e183839-2a73-44bf-b4e2-b3ab25613a5a"), 1, "He", 14 },
                    { new Guid("a24f2e94-143d-4ef8-8a7e-c68df91d19db"), new Guid("ffd37b6b-c0c9-4f04-a7c1-f6dffb9eec21"), 8, "to", 12 },
                    { new Guid("a26e0aae-5201-4f4f-aecb-0adf47c74dd1"), new Guid("8de0af24-b98a-4f94-8974-aa3c51220f09"), 5, "the", 6 },
                    { new Guid("a37ac663-0ba8-4bd0-ad6c-8a994ae6ac15"), new Guid("74886f2d-4d3b-40fe-b96a-7524e9fe5b09"), 4, "them", 14 },
                    { new Guid("a411463b-be35-4a60-89b7-2495ba64aca6"), new Guid("90a95bc6-f20f-4e55-b3ba-469f4fa589f7"), 1, "She", 14 },
                    { new Guid("a5189a67-94f4-4a67-8257-ee31411406f4"), new Guid("b8a0d599-6575-4626-b2af-317f9e78efa4"), 2, "have", 13 },
                    { new Guid("a5bfb23c-14b6-4c03-a629-bacb408a0f95"), new Guid("b8a0d599-6575-4626-b2af-317f9e78efa4"), 5, "the", 6 },
                    { new Guid("a5c2b72a-de5f-4386-bff2-2b771d8faf00"), new Guid("7ac50144-ad5f-4702-9d87-ea996e8904aa"), 4, "everywhere?", 5 },
                    { new Guid("a6795bd5-a600-40f1-96f1-75495334531f"), new Guid("35a00634-becb-46a3-bc3d-a73bb2b46ab1"), 7, "as", 12 },
                    { new Guid("a69d2ffa-e2f1-4e1e-aaf1-3a624e6cfb7b"), new Guid("23c9e459-845c-4a74-96fa-5eda6187cb1f"), 4, "glass", 10 },
                    { new Guid("a6b9f574-129e-4fb5-aa39-3e34283201e7"), new Guid("84b9001f-564e-42c5-a864-eefa2f289f3b"), 6, "at", 12 },
                    { new Guid("a765dcca-5242-42a4-94f7-a654cb5dd7ef"), new Guid("00242767-9606-4d08-b96b-7a1498a6d0c9"), 6, "whole", 1 },
                    { new Guid("a77ff4af-40bb-4e4d-88f6-1d73dd3d1532"), new Guid("8296a1d5-c980-4187-8379-29625ee413d6"), 1, "Is", 13 },
                    { new Guid("a8283f88-bd52-45b9-b4a1-1c71665293c5"), new Guid("ffd37b6b-c0c9-4f04-a7c1-f6dffb9eec21"), 3, "reading", 16 },
                    { new Guid("a830e576-8447-482e-8328-27595c09233a"), new Guid("49c84e13-c9a2-4665-b563-7c1f686c8b8d"), 6, "floor.", 10 },
                    { new Guid("a9139f63-b421-48e5-b57e-9e6cbb981335"), new Guid("928acaf1-743e-4c3e-bdfa-e24d0e6ff485"), 4, "of", 12 },
                    { new Guid("a9b9a516-fb52-45e0-a505-06d4c90212d3"), new Guid("d54d614b-f911-4fd8-9932-eead5f63eb74"), 7, "the", 6 },
                    { new Guid("a9cf1323-5247-4e09-a6bb-ed6b51549d82"), new Guid("08ed1ce8-96e5-45ff-b10f-8fa49a1af3d4"), 4, "bigger", 4 },
                    { new Guid("aa6fa9b7-0efd-436a-8ac3-b895fa1f056b"), new Guid("47124eb6-a2d1-4b91-9e5d-5a85169625c8"), 6, "work,", 16 },
                    { new Guid("aa83fb9d-1490-4244-9d9d-7d8f186b304b"), new Guid("8d53f533-4cdc-4e5a-a963-54f31febf8e5"), 1, "Do", 13 },
                    { new Guid("aa95c2f3-14ae-488d-86ba-c2429d3ae115"), new Guid("c4f3b91f-1c7b-44a2-b32e-32ef0b1f0b11"), 7, "the", 6 },
                    { new Guid("ab9cf665-86e5-45a9-ba23-7b3d78b063a5"), new Guid("2958e0a7-9ebc-463a-9f87-5a98ab680449"), 2, "are", 13 },
                    { new Guid("ad29c2b0-e30c-4325-9266-8014862f73e1"), new Guid("d57af893-3fcf-463f-8722-03583c052ffc"), 6, "before", 12 },
                    { new Guid("adc35eb2-44c3-4695-b021-a86e6ecb79b6"), new Guid("768101f9-4a4b-43cd-aa34-faf712bfc940"), 3, "have", 13 },
                    { new Guid("ae5d39f5-cead-4dcf-9cb3-90ca91adb50f"), new Guid("30da8a31-852f-4cfc-89e1-c754bd83ad25"), 2, "tv", 10 },
                    { new Guid("b05d7f60-7c08-40a2-b309-bc0e54153282"), new Guid("865496b8-3788-4cc3-8f6a-09dfebcd2d9b"), 5, "actor?", 10 },
                    { new Guid("b0c1fc1f-26c9-4f2d-a5a4-486098cbffbd"), new Guid("b8a0d599-6575-4626-b2af-317f9e78efa4"), 8, "my", 14 },
                    { new Guid("b2154e46-0751-45a3-a04b-1854e5354e1f"), new Guid("df7940f8-70aa-4e17-9df0-2bb4a46d6d7d"), 2, "can", 9 },
                    { new Guid("b2422659-428f-42f3-91ec-7b631e987bfa"), new Guid("2958e0a7-9ebc-463a-9f87-5a98ab680449"), 6, "table.", 10 },
                    { new Guid("b254fddb-62ef-4a4c-b086-b809bf4a3c85"), new Guid("08ed1ce8-96e5-45ff-b10f-8fa49a1af3d4"), 3, "is not", 13 },
                    { new Guid("b26814e0-0e0b-4c6c-b93f-e2cc674be21c"), new Guid("8de0af24-b98a-4f94-8974-aa3c51220f09"), 1, "We", 14 },
                    { new Guid("b3705cbc-bf08-45f8-9065-165b04897237"), new Guid("8650e3d8-d11f-461c-9f8a-b00e6379c348"), 4, "everybody?", 5 },
                    { new Guid("b46e68ab-8087-42b0-8cbb-67c40c6cbd92"), new Guid("47294d03-3395-42a6-83d8-389d19aec14d"), 3, "never", 2 },
                    { new Guid("b50af727-cfdf-49f6-b32b-af463e8f02f3"), new Guid("be20ccf4-be83-4bc4-b08f-5c2bd02dda01"), 4, "be", 13 },
                    { new Guid("b5a1cba3-70d5-47f4-b7d0-0c66952a1483"), new Guid("8650e3d8-d11f-461c-9f8a-b00e6379c348"), 3, "know", 16 },
                    { new Guid("b5e6c77b-72df-4fb9-ab38-733d5c1cb0be"), new Guid("35a00634-becb-46a3-bc3d-a73bb2b46ab1"), 8, "designers?", 10 },
                    { new Guid("b757718e-32ba-483a-b6e0-3ad09330d603"), new Guid("8de0af24-b98a-4f94-8974-aa3c51220f09"), 8, "yesterday.", 12 },
                    { new Guid("b75d0a7f-20d2-43e8-9049-3e052074a493"), new Guid("ad46e855-9605-4d41-9eac-2c8dfa2f7c1f"), 4, "the", 6 },
                    { new Guid("b78c1f18-e22c-46cb-822e-95ed13180e1f"), new Guid("38df6419-b7c7-4f23-ae70-6ddadf05db9f"), 1, "She", 14 },
                    { new Guid("b7e12317-8c04-49bb-aae0-008104ebb230"), new Guid("33864b46-810c-4fad-aee0-05e42b413e6a"), 11, "starts.", 16 },
                    { new Guid("b7f428e2-fffc-4b63-a110-4e25b95a1391"), new Guid("d57af893-3fcf-463f-8722-03583c052ffc"), 3, "done", 16 },
                    { new Guid("b87b2423-28a2-4462-839f-317a9243a02b"), new Guid("4bfb0f3d-91d4-42c6-ad20-dd66a700d43c"), 3, "written", 16 },
                    { new Guid("b9557d81-8a3d-4c6d-b710-d691aea4cc29"), new Guid("d54d614b-f911-4fd8-9932-eead5f63eb74"), 2, "son", 10 },
                    { new Guid("b95de245-d28a-43da-97ee-2717257f5e8e"), new Guid("8f56c4de-e4bf-4354-8279-ea3f6aca18dc"), 3, "oranges", 10 },
                    { new Guid("b9df8bf4-f2d8-43d8-bf99-692fe80161a2"), new Guid("4bfb0f3d-91d4-42c6-ad20-dd66a700d43c"), 7, "you", 14 },
                    { new Guid("bab59bca-4e8b-4c2b-807a-ec596eafc734"), new Guid("2233f2a0-b9c6-4072-8ace-ea274ebf6cf4"), 7, "somewhere.", 5 },
                    { new Guid("badaab0d-8ffe-411e-9f06-88dbb625e069"), new Guid("be20ccf4-be83-4bc4-b08f-5c2bd02dda01"), 2, "studied", 16 },
                    { new Guid("bcb9deb5-bb25-4166-9c5f-5b33f3b8a908"), new Guid("45425db5-3e53-471c-861b-007a0b2a305b"), 4, "her", 14 },
                    { new Guid("bd43afaf-827c-4096-be24-ec2845221394"), new Guid("08681ed3-8ab0-4a1d-967a-2c2806b3a099"), 3, "done", 16 },
                    { new Guid("bd49617f-3d0c-4523-8dbd-8f547533bf15"), new Guid("21983f75-6289-4334-9372-c88a81690e96"), 1, "Run", 16 },
                    { new Guid("bdd1e3bd-34ed-4087-998b-672a0f7c4541"), new Guid("43d627bb-e3ed-4a8d-81b9-8e0212a3a8a0"), 5, "door.", 10 },
                    { new Guid("bde7d97d-fd52-4dbd-845c-070fe28d1eef"), new Guid("38df6419-b7c7-4f23-ae70-6ddadf05db9f"), 2, "was", 13 },
                    { new Guid("be28a592-e7b7-4872-a654-dc6c67601984"), new Guid("1d31d367-6651-40f8-a82d-b6f033debac9"), 3, "answer.", 16 },
                    { new Guid("c0056a8c-cc43-4569-b34f-9b3497b41029"), new Guid("00242767-9606-4d08-b96b-7a1498a6d0c9"), 3, "feeling", 16 },
                    { new Guid("c06e0c2f-0698-4542-9287-396df1ca1da7"), new Guid("d2a4e39d-1b0d-4584-bfd2-aa0cfbb070d6"), 3, "his", 14 },
                    { new Guid("c0a0110d-2ae2-4bb2-907e-550860f99486"), new Guid("49c84e13-c9a2-4665-b563-7c1f686c8b8d"), 2, "were not", 13 },
                    { new Guid("c0c30d04-37a1-474d-b131-34d819f65972"), new Guid("9d53c467-f7e8-4433-971c-5e7cb7ce6a71"), 2, "mustn't", 9 },
                    { new Guid("c216f101-8bf8-4a14-898c-aedd6d8950fc"), new Guid("49c84e13-c9a2-4665-b563-7c1f686c8b8d"), 4, "on", 12 },
                    { new Guid("c2b26e84-328c-4933-801c-d85561951519"), new Guid("e89a87ca-93c7-489c-85e6-200a1192d751"), 4, "there", 2 },
                    { new Guid("c2c63cbc-f682-49eb-8077-32cb297cedae"), new Guid("84b9001f-564e-42c5-a864-eefa2f289f3b"), 2, "were", 13 },
                    { new Guid("c2f8e980-d194-45ab-bcfd-1867e22aca61"), new Guid("ad46e855-9605-4d41-9eac-2c8dfa2f7c1f"), 5, "museum.", 10 },
                    { new Guid("c407b1ab-42f2-460c-8703-649d6681c158"), new Guid("30da8a31-852f-4cfc-89e1-c754bd83ad25"), 3, "is not", 13 },
                    { new Guid("c4fc906c-188c-4a35-bf5f-ea8c991d9b19"), new Guid("111b3155-8751-456a-8a77-f1c26ced8f18"), 2, "will", 13 },
                    { new Guid("c5acf82b-7cc3-4c11-9b5c-b078890b3fb9"), new Guid("791f349a-79eb-431e-8c4a-29371d6e0689"), 1, "We", 14 },
                    { new Guid("c5cf28aa-3275-4959-930c-26150b542cbb"), new Guid("23c9e459-845c-4a74-96fa-5eda6187cb1f"), 7, "armchair?", 10 },
                    { new Guid("c5e6fb2d-df80-46c2-a0f0-6bd7d2cfdd6e"), new Guid("08ed1ce8-96e5-45ff-b10f-8fa49a1af3d4"), 1, "This", 14 },
                    { new Guid("c6e79d64-6e7e-46e4-909c-23a6ad4d1a50"), new Guid("84b9001f-564e-42c5-a864-eefa2f289f3b"), 7, "four", 8 },
                    { new Guid("c72b38c0-40fd-4086-9fa7-e612e834bf7f"), new Guid("dbdc7990-cb51-4e30-96cd-17e3fa20dafa"), 5, "this", 14 },
                    { new Guid("c72e9c2a-74f6-4005-99bd-aa2b9a8bd136"), new Guid("46eac2d6-1f33-4c2a-b420-e914de870deb"), 6, "6 months.", 11 },
                    { new Guid("c7588cba-e4f0-46e4-9acf-3cff10f75a19"), new Guid("35a00634-becb-46a3-bc3d-a73bb2b46ab1"), 2, "they", 14 },
                    { new Guid("c865086b-8091-4f43-84fb-fb4aa2867564"), new Guid("8f56c4de-e4bf-4354-8279-ea3f6aca18dc"), 1, "Are", 13 },
                    { new Guid("c8e17935-e205-4d65-b086-6b476c3f5e5b"), new Guid("df7940f8-70aa-4e17-9df0-2bb4a46d6d7d"), 3, "close.", 16 },
                    { new Guid("c919c16a-3a03-4ece-b9f3-0b1232ccfc9c"), new Guid("e7ac161c-561a-4ffe-81f7-b57b37b19e52"), 4, "with", 12 },
                    { new Guid("ca243b2f-809b-48d2-85cb-9c4ea6639514"), new Guid("8296a1d5-c980-4187-8379-29625ee413d6"), 2, "this", 14 },
                    { new Guid("ca50eb3a-a2b7-4693-9182-40cd9f944763"), new Guid("23c9e459-845c-4a74-96fa-5eda6187cb1f"), 5, "under", 12 },
                    { new Guid("ca6d7868-9199-4b8a-9e77-cf64a4ba3720"), new Guid("33864b46-810c-4fad-aee0-05e42b413e6a"), 7, "seats", 10 },
                    { new Guid("ca958b36-8035-4191-b987-6a7d03621e39"), new Guid("33864b46-810c-4fad-aee0-05e42b413e6a"), 10, "lesson", 10 },
                    { new Guid("cc3002ae-73ff-4d8b-a30b-7984ff65c637"), new Guid("8f56c4de-e4bf-4354-8279-ea3f6aca18dc"), 4, "the", 6 },
                    { new Guid("cd0005da-238e-4f4d-a8bf-577145927e55"), new Guid("74886f2d-4d3b-40fe-b96a-7524e9fe5b09"), 5, "at", 12 },
                    { new Guid("cd2d0845-0303-49a1-888f-0dc5618b18bf"), new Guid("08681ed3-8ab0-4a1d-967a-2c2806b3a099"), 4, "the", 6 },
                    { new Guid("cec85e4b-aad3-4e76-b021-b116f3430e0c"), new Guid("23c9e459-845c-4a74-96fa-5eda6187cb1f"), 1, "Was", 13 },
                    { new Guid("cf050a5b-1c69-43ec-b110-0cb50866f53e"), new Guid("111b3155-8751-456a-8a77-f1c26ced8f18"), 6, "book", 10 },
                    { new Guid("cf42c0f9-f178-4ad1-a9b0-23cd3e2f6dd2"), new Guid("6d0cc462-65e5-48a1-beb0-b7cdb1f04045"), 3, "turn", 16 },
                    { new Guid("cf64bd66-8135-4db4-84c7-4b4042014171"), new Guid("11af84dc-c777-46c9-ba7e-8fc836a804f0"), 1, "We", 14 },
                    { new Guid("cfecd9cb-64fa-4eb3-b28c-de174daece9a"), new Guid("43d627bb-e3ed-4a8d-81b9-8e0212a3a8a0"), 4, "the", 6 },
                    { new Guid("d000a5a4-3acb-43a5-ae0f-13bcdb9eeabc"), new Guid("8d53f533-4cdc-4e5a-a963-54f31febf8e5"), 5, "be", 13 },
                    { new Guid("d0606c4b-b76c-4b19-a91e-19caa19e1d03"), new Guid("7c07747b-ded1-4c2e-9a36-17f95fc059f7"), 4, "to", 12 },
                    { new Guid("d0df1f36-e28c-4294-a777-a5d8cdfdccfa"), new Guid("928acaf1-743e-4c3e-bdfa-e24d0e6ff485"), 7, "garden.", 10 },
                    { new Guid("d111f79c-9d1a-4673-89fb-725b2e8ca290"), new Guid("1d31d367-6651-40f8-a82d-b6f033debac9"), 2, "him", 14 },
                    { new Guid("d1910ef9-a38c-43eb-b6da-1d8959484df4"), new Guid("7c07747b-ded1-4c2e-9a36-17f95fc059f7"), 2, "we", 14 },
                    { new Guid("d1dd51a1-7ddb-4576-99c9-11d6d4bc180d"), new Guid("8296a1d5-c980-4187-8379-29625ee413d6"), 6, "that", 14 },
                    { new Guid("d29a4daf-014f-4693-9fa8-93bddc76ca07"), new Guid("cef21bb8-1373-4236-9b2b-703377c974bf"), 4, "to", 12 },
                    { new Guid("d2cecba9-7215-435b-8f88-6bc8b92ad0ca"), new Guid("35a00634-becb-46a3-bc3d-a73bb2b46ab1"), 3, "work", 16 },
                    { new Guid("d35cd03c-752a-4e8a-8151-157206a10e04"), new Guid("d2a4e39d-1b0d-4584-bfd2-aa0cfbb070d6"), 4, "nightstand.", 10 },
                    { new Guid("d3d90704-52a5-4985-8c2d-8c0ad5fe0ae8"), new Guid("dbdc7990-cb51-4e30-96cd-17e3fa20dafa"), 4, "visited", 16 },
                    { new Guid("d674b579-98a5-4685-b5b8-57cc4ab44ecb"), new Guid("36411c85-2a47-415c-a396-ea52bcadd3e9"), 1, "Do", 13 },
                    { new Guid("d72726b6-d76e-4040-b2b1-4bf364950070"), new Guid("e2ec419b-08c9-4295-86e1-e8846488b20c"), 8, "armchair.", 10 },
                    { new Guid("d72f3aab-2c10-46a2-8651-d64fa7f5ec22"), new Guid("35e343ce-74c5-4413-a75a-48e29d6ee031"), 3, "be", 13 },
                    { new Guid("d7439311-90f3-4a2f-96fc-43601117cfdb"), new Guid("3953a15c-4d98-4b8d-b5a0-a2bbe4449fe9"), 1, "You", 14 },
                    { new Guid("d796e8d7-3a26-4aee-ae1b-9303dae5354e"), new Guid("c4f3b91f-1c7b-44a2-b32e-32ef0b1f0b11"), 4, "the", 6 },
                    { new Guid("d7b0d987-5c73-49b8-b07c-e391539f9e79"), new Guid("35a00634-becb-46a3-bc3d-a73bb2b46ab1"), 4, "in", 12 },
                    { new Guid("d8080506-7374-4594-8b1e-ea40fa568f79"), new Guid("1bcbf50b-967d-49e2-84b8-aba447ac4954"), 1, "I", 14 },
                    { new Guid("d84d576b-6a48-4fca-9052-06a5e19377f0"), new Guid("6b9c1472-a03e-4854-bec8-cfc8bfb8e06c"), 6, "the", 6 },
                    { new Guid("d8724ba4-2f9c-4fc7-80ed-5fbb6db5e1f1"), new Guid("f1bb33c6-6457-442a-a937-24ec243a7dcc"), 3, "have", 13 },
                    { new Guid("d87f1b04-50ad-4536-b024-b7354cff5924"), new Guid("9e891766-82ec-441e-affe-b3138b7a04db"), 6, "station?", 10 },
                    { new Guid("d8e6b80b-1d7a-44e3-a890-795d265aea56"), new Guid("47124eb6-a2d1-4b91-9e5d-5a85169625c8"), 3, "have", 13 },
                    { new Guid("da1a916c-9f90-436b-9b8c-896b7b952435"), new Guid("111b3155-8751-456a-8a77-f1c26ced8f18"), 1, "You", 14 },
                    { new Guid("da209dfa-7ece-45fe-a40a-58e9190f9f11"), new Guid("dbdc7990-cb51-4e30-96cd-17e3fa20dafa"), 2, "has", 13 },
                    { new Guid("da237e31-e1d7-44a9-aa15-f4cf191f3325"), new Guid("8296a1d5-c980-4187-8379-29625ee413d6"), 3, "phone", 10 },
                    { new Guid("da5738fb-e203-47a5-842b-d2ed8be5bacc"), new Guid("cef21bb8-1373-4236-9b2b-703377c974bf"), 2, "you", 14 },
                    { new Guid("db072f2c-39e5-495d-b589-58b1a2bfdfbc"), new Guid("35e343ce-74c5-4413-a75a-48e29d6ee031"), 5, "guides.", 10 },
                    { new Guid("db3c449e-a5e2-4112-8ed6-465295f60b0d"), new Guid("45425db5-3e53-471c-861b-007a0b2a305b"), 5, "writer.", 10 },
                    { new Guid("dcf30dce-4ec1-42b1-b2e1-518854731a86"), new Guid("b8a0d599-6575-4626-b2af-317f9e78efa4"), 7, "to", 12 },
                    { new Guid("dd0210f2-e619-4378-827a-b9615e1a961f"), new Guid("d54d614b-f911-4fd8-9932-eead5f63eb74"), 6, "on", 12 },
                    { new Guid("dd03b987-abe4-4fc5-a039-84acbc0d0f9d"), new Guid("47294d03-3395-42a6-83d8-389d19aec14d"), 4, "go", 16 },
                    { new Guid("dd157da3-eae6-4716-bcfc-799ab9938468"), new Guid("8f56c4de-e4bf-4354-8279-ea3f6aca18dc"), 5, "least?", 4 },
                    { new Guid("dd3b9f9f-6539-4c9c-b4b6-3beda2a91ef7"), new Guid("08ed1ce8-96e5-45ff-b10f-8fa49a1af3d4"), 7, "one.", 10 },
                    { new Guid("dd8b7e20-305d-4c58-9426-b5a8ff393a63"), new Guid("0919cab8-a02f-4da7-9b47-1a58351ea9c3"), 5, "2 months?", 11 },
                    { new Guid("de8d2200-13dc-4484-ad75-49d52d913176"), new Guid("d54d614b-f911-4fd8-9932-eead5f63eb74"), 5, "turn", 16 },
                    { new Guid("deba987f-ae57-4896-b8db-0dbb4e887bf3"), new Guid("45425db5-3e53-471c-861b-007a0b2a305b"), 3, "be", 13 },
                    { new Guid("df08a6cb-a92b-43b5-aa3b-12684a6b4713"), new Guid("4bfb0f3d-91d4-42c6-ad20-dd66a700d43c"), 9, "in?", 12 },
                    { new Guid("e02ec9b0-11ad-498c-9cba-567742ccb535"), new Guid("35e343ce-74c5-4413-a75a-48e29d6ee031"), 4, "their", 14 },
                    { new Guid("e0c89c34-cb77-4a6f-8203-e2b2423da4be"), new Guid("7ac50144-ad5f-4702-9d87-ea996e8904aa"), 3, "meet", 16 },
                    { new Guid("e148b86c-f415-4535-b29e-387e7c0bee39"), new Guid("c5406625-55a2-488f-9050-a5ab649cd3ce"), 6, "on", 12 },
                    { new Guid("e19432de-97ef-4325-a04a-0cc7fc0361df"), new Guid("768101f9-4a4b-43cd-aa34-faf712bfc940"), 7, "by", 12 },
                    { new Guid("e243f48b-051e-43d2-b040-b785a4c6a8f1"), new Guid("dbdc7990-cb51-4e30-96cd-17e3fa20dafa"), 1, "He", 14 },
                    { new Guid("e36558c1-ac77-4399-9ead-686c02901a55"), new Guid("d57af893-3fcf-463f-8722-03583c052ffc"), 4, "his", 14 },
                    { new Guid("e3c15b11-db73-44c6-9897-943353ac36cc"), new Guid("cef21bb8-1373-4236-9b2b-703377c974bf"), 5, "drink?", 16 },
                    { new Guid("e562a31e-7a9b-4350-ad1f-d0faadb9fc5c"), new Guid("7c07747b-ded1-4c2e-9a36-17f95fc059f7"), 1, "When", 15 },
                    { new Guid("e618cd1b-7e69-4a4f-81a0-5d6ef3a49ebf"), new Guid("4afa32ae-daa4-45ed-92ea-f910b90116c1"), 5, "in", 12 },
                    { new Guid("e64d9d70-de4f-464e-81f1-e582889b2bf8"), new Guid("1ce82652-e890-4a79-980a-de6a7291c4b6"), 1, "Is", 13 },
                    { new Guid("e718d0f2-f245-4dec-993f-1f4e21c93509"), new Guid("c6453de7-f75d-49bf-ac53-4944dac3b288"), 3, "stand?", 16 },
                    { new Guid("e71ff896-63a5-40da-b17d-7e2bb4f7564f"), new Guid("6b9c1472-a03e-4854-bec8-cfc8bfb8e06c"), 2, "had", 13 },
                    { new Guid("e8381a7d-cf81-46d4-a874-65a3ea8bba55"), new Guid("33864b46-810c-4fad-aee0-05e42b413e6a"), 8, "before", 12 },
                    { new Guid("e88e5c49-67bc-41c2-8468-999a0854f14d"), new Guid("cef21bb8-1373-4236-9b2b-703377c974bf"), 3, "want", 16 },
                    { new Guid("e8daa7d5-86d5-4b6d-9352-e4330224d7ed"), new Guid("d57af893-3fcf-463f-8722-03583c052ffc"), 10, "home?", 10 },
                    { new Guid("e90b0d76-c379-4c70-9e1d-278d30d2f84c"), new Guid("6d0cc462-65e5-48a1-beb0-b7cdb1f04045"), 4, "us", 14 },
                    { new Guid("eb914b69-abea-449a-b6da-94c97205dbc6"), new Guid("67f7b904-927c-471f-8dfe-73f54adb9e03"), 2, "there", 2 },
                    { new Guid("ebd4b116-4668-47ea-86f6-76221e36cdef"), new Guid("1a04722f-1b4d-4730-b1f0-4fa2f8d71bd7"), 3, "his", 14 },
                    { new Guid("ec7eee20-b872-44f3-9a95-63f4b8c57889"), new Guid("7c07747b-ded1-4c2e-9a36-17f95fc059f7"), 10, "already", 2 },
                    { new Guid("ec80556b-4ba3-4bef-affa-8e1c2677329f"), new Guid("aee272ba-c84e-4fe4-a8ea-49386db26adb"), 3, "have", 13 },
                    { new Guid("ed204a67-aea4-4846-9cce-8ed1d7515747"), new Guid("aee272ba-c84e-4fe4-a8ea-49386db26adb"), 5, "the", 6 },
                    { new Guid("ed3a4cbb-e41d-4c14-acc8-3de98d3759d1"), new Guid("c5406625-55a2-488f-9050-a5ab649cd3ce"), 1, "There", 2 },
                    { new Guid("ed84ea16-34be-408d-8f1e-095a2c28071b"), new Guid("45425db5-3e53-471c-861b-007a0b2a305b"), 1, "He", 14 },
                    { new Guid("eda93807-2914-4d73-996a-ea3da0119c8e"), new Guid("11af84dc-c777-46c9-ba7e-8fc836a804f0"), 3, "read", 16 },
                    { new Guid("ee0ebe02-9cf1-4ea8-9e3f-83de2064860e"), new Guid("c4f3b91f-1c7b-44a2-b32e-32ef0b1f0b11"), 10, "that", 14 },
                    { new Guid("ee109302-8b1c-4725-a378-5d6030d130f5"), new Guid("1a04722f-1b4d-4730-b1f0-4fa2f8d71bd7"), 1, "We", 14 },
                    { new Guid("ef0d1783-fa1a-4d30-b97e-eed3059a14cf"), new Guid("f1bb33c6-6457-442a-a937-24ec243a7dcc"), 4, "finished", 16 },
                    { new Guid("efeb3f87-7d88-4ad9-bc46-cba105941cea"), new Guid("c4f3b91f-1c7b-44a2-b32e-32ef0b1f0b11"), 2, "had not", 13 },
                    { new Guid("f07ea390-208f-4d3c-ac88-dcda683a2a4c"), new Guid("33864b46-810c-4fad-aee0-05e42b413e6a"), 5, "taken", 16 },
                    { new Guid("f15fd353-be99-43d1-8702-870ff329dede"), new Guid("67f7b904-927c-471f-8dfe-73f54adb9e03"), 3, "glasses", 10 },
                    { new Guid("f1603d30-ff76-4d55-9b6e-f88262818bef"), new Guid("ef5c8e17-28a7-4673-97d7-ab3f84d01aa3"), 4, "historian.", 10 },
                    { new Guid("f16ac678-bb42-49a9-8384-c73dfff9031b"), new Guid("2050e871-9095-4f46-8787-8f717f114ea2"), 1, "Remember", 16 },
                    { new Guid("f18fa01b-f2ab-403f-839e-b309cae77257"), new Guid("eaacd632-357b-4473-8bc4-e64338f16811"), 4, "blue", 2 },
                    { new Guid("f1bcf935-7ef2-4db6-9d04-4dcf0a065bfd"), new Guid("c4f3b91f-1c7b-44a2-b32e-32ef0b1f0b11"), 6, "by", 12 },
                    { new Guid("f269ddc9-a1b8-4dbe-aba6-4de8bac0f60e"), new Guid("46eac2d6-1f33-4c2a-b420-e914de870deb"), 4, "you", 14 },
                    { new Guid("f272d9e5-c74b-406b-8ee7-49bc219fb236"), new Guid("eaacd632-357b-4473-8bc4-e64338f16811"), 1, "I", 14 },
                    { new Guid("f2d24856-7142-4f63-a3ee-cc0075bc049d"), new Guid("eaacd632-357b-4473-8bc4-e64338f16811"), 2, "do not", 13 },
                    { new Guid("f362f83c-7246-4432-bb00-378cd85726a5"), new Guid("ef5c8e17-28a7-4673-97d7-ab3f84d01aa3"), 1, "You", 14 },
                    { new Guid("f3745df6-34fe-4893-b49e-d2df69ab9b41"), new Guid("2233f2a0-b9c6-4072-8ace-ea274ebf6cf4"), 3, "I", 14 },
                    { new Guid("f4864def-5bf0-4807-82de-0fcf4b5035cf"), new Guid("bc4032b5-0b91-47da-8e6f-db283a515989"), 1, "Don't", 13 },
                    { new Guid("f4a06801-56ae-4515-b26f-a8254f4f9138"), new Guid("0919cab8-a02f-4da7-9b47-1a58351ea9c3"), 3, "grow", 16 },
                    { new Guid("f4b2f19f-b10b-4e63-bb8a-366fab5cdf6a"), new Guid("765b06a2-50d6-4c56-8845-143e7ee7c733"), 4, "longer", 4 },
                    { new Guid("f4e343e6-4253-4feb-acbd-4b2e4696f031"), new Guid("8f56c4de-e4bf-4354-8279-ea3f6aca18dc"), 2, "these", 14 },
                    { new Guid("f520eb5d-a149-4501-b81b-b91755d8e824"), new Guid("e7ac161c-561a-4ffe-81f7-b57b37b19e52"), 5, "pneumonia.", 10 },
                    { new Guid("f5b3308f-fad0-493a-be74-a67f4b11aaf0"), new Guid("7c07747b-ded1-4c2e-9a36-17f95fc059f7"), 3, "came", 16 },
                    { new Guid("f5bea200-ec4f-4c93-b880-f976932dc1e4"), new Guid("9e891766-82ec-441e-affe-b3138b7a04db"), 1, "Does", 13 },
                    { new Guid("f6d7f159-ec7f-4e57-aebc-2e3da141113d"), new Guid("768101f9-4a4b-43cd-aa34-faf712bfc940"), 12, "month.", 10 },
                    { new Guid("f6fa9365-7360-4270-9a79-f24684e6ab84"), new Guid("7c07747b-ded1-4c2e-9a36-17f95fc059f7"), 8, "train", 10 },
                    { new Guid("f78b432e-007b-4e1d-b9eb-e663be27e11d"), new Guid("8de0af24-b98a-4f94-8974-aa3c51220f09"), 6, "whole", 1 },
                    { new Guid("f797fc83-985f-4ff3-a4ae-dfc68bf1d976"), new Guid("90a95bc6-f20f-4e55-b3ba-469f4fa589f7"), 5, "show.", 16 },
                    { new Guid("f8802137-c2ad-4612-ba4e-e4ec60429fbc"), new Guid("67f7b904-927c-471f-8dfe-73f54adb9e03"), 5, "the", 6 },
                    { new Guid("f8f80952-4821-4e6b-b803-68d7b873c0d3"), new Guid("38df6419-b7c7-4f23-ae70-6ddadf05db9f"), 3, "there", 2 },
                    { new Guid("f93241d6-78c5-4020-b05b-6653482395d9"), new Guid("bfca2c81-719c-4189-8e2d-027163421517"), 1, "He", 14 },
                    { new Guid("fac3b393-3b10-49c3-af64-9b72c2213e7e"), new Guid("ffd37b6b-c0c9-4f04-a7c1-f6dffb9eec21"), 6, "from", 12 },
                    { new Guid("fb0b9918-ce22-45c6-a897-b238a9ae752f"), new Guid("2050e871-9095-4f46-8787-8f717f114ea2"), 2, "about", 12 },
                    { new Guid("fb1a905d-8041-4c96-a90e-15351471b676"), new Guid("1d31d367-6651-40f8-a82d-b6f033debac9"), 1, "Let", 16 },
                    { new Guid("fb8a3467-0ac9-4d28-abbf-e859e6a3f379"), new Guid("74886f2d-4d3b-40fe-b96a-7524e9fe5b09"), 7, "weekend?", 10 },
                    { new Guid("fbeb86a4-bba8-46d7-8838-080c7e13a1e3"), new Guid("b8a0d599-6575-4626-b2af-317f9e78efa4"), 4, "written", 16 },
                    { new Guid("fcad16cf-d55a-4da8-bec2-bf9e3b5efdb6"), new Guid("84b9001f-564e-42c5-a864-eefa2f289f3b"), 4, "the", 6 },
                    { new Guid("fcbbbf4c-59af-417d-bf69-472fc44f1f46"), new Guid("ad46e855-9605-4d41-9eac-2c8dfa2f7c1f"), 3, "at", 12 },
                    { new Guid("ffd568cb-99c5-4013-a9dc-b6a60e9c6143"), new Guid("0fee6686-f59a-4025-9184-858d1c0a3659"), 1, "Did", 13 },
                    { new Guid("ffd5e14b-c9e3-4a8f-a1ba-32394cb192e8"), new Guid("ef5c8e17-28a7-4673-97d7-ab3f84d01aa3"), 2, "are", 13 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("0057d61f-be88-45ef-8fc5-36b4007836b4"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("00930476-cad8-45f0-9c94-65b0f42520ea"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("00b45f27-32f5-427d-a867-0bd86ca686f6"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("00fc0a5b-42da-4d88-a23b-204ee9da7690"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("01303bf0-fe08-411c-990b-a2aaf8f20761"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("0244dfbc-7f8c-439d-b925-8f6bb16e1485"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("02ca9313-988c-4fef-8230-cd3af412a935"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("03074cc6-d5c2-4e6a-bd88-4a9d48442afa"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("035f5734-cdb5-4597-ac58-c07cf9c2eaf8"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("038b26c6-d388-42fb-b495-2d7ee10e2dfe"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("053d4969-b803-4de7-ae16-5b4e85682122"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("056f0cf0-591e-4198-9705-98c6b3fdf54f"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("05c82041-90b4-4717-afad-48d6dc9a848e"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("06dd14cd-f87d-457e-981f-da4b24a175c5"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("0713b7fc-088a-42aa-9418-cbe97525e442"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("07bb3b2e-6642-4d2e-9892-1b82bbfa6552"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("08a3381a-41bf-4ed3-929b-00213f93cad3"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("093b5767-2c02-49ad-9411-0441b1ac3cfb"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("0975c2ca-c98e-4cf8-89c7-858a03a70f1f"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("09b1a15c-4b9a-4967-9da8-b8c3b72e491a"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("09d1d5d8-8e04-42f0-935c-13e7af7abbc5"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("0a134ca9-847d-44cb-9ed3-4e501082218a"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("0a8af533-0355-4a81-9986-ab4672c21216"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("0b45015f-a579-4a0c-b577-4602b4fcc1e2"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("0c3f8764-3fce-4185-93ca-8835c7f3943a"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("0cd86ba6-a639-44c0-a3a7-52b21d8d1db8"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("0d46ddfa-9845-47f0-a2c4-45174cca7a6b"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("0ed11e4c-f7b3-4ebc-b1e2-62036f8343e0"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("0ed3f0d2-3aff-455e-b43d-5fc51d677801"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("0f284ba6-695f-48b1-bf8d-668b78dc0695"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("0f82f4fe-9bf4-42e1-96c7-03285ce058ec"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("102a9309-d836-41b7-9161-7218fd2c72a7"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("106137a0-fcd2-4d3c-9e7a-ba3b5c93bd5e"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("109005e2-5471-468a-96c5-6625f69a47ba"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("10c65254-1e4c-46a4-9920-d3e09585f7d2"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("10e8a357-88a5-45b2-b7ba-79f78a963fcd"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("10f0d3a1-38f7-4056-9a5b-e582e8b92762"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("115c85d6-1c60-425a-bb69-f057d4261682"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("11862af5-94f7-42a5-8ba6-c844d767974e"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("126ca615-6889-42c5-b8d9-7101d1e4c332"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("12c91238-0a40-412f-a9ea-edef9f843ac2"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("12d0d824-b5fa-4b8d-8850-e13c7633b236"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("13384cfa-cc62-45c8-81a9-19730a767842"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("14986925-f269-4656-b99c-b13ac0b92345"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("16c5a294-672c-475a-9f25-861bb940bcf2"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("16e351e1-f01d-4340-b8fc-3666b3f9a7c1"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("16f0d865-b4b3-44d1-bfd3-98022abeffb0"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("1711493d-98bf-4a8a-b332-b3cd3b32c952"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("17fa35c1-0a3f-44dd-8107-da3f7fa6a4b8"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("182778c2-4308-430a-bef1-51a864dd7dc8"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("18a82a4d-8afe-49af-b0ff-8f8521ee6776"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("18ae7dc8-e658-472a-a0e8-ec70c652ba19"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("1a4a7b7f-d800-4e59-a3a5-eff18fd0a7b4"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("1abb3725-60f9-450e-a554-32a4c9916434"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("1aed4c76-ded9-46c6-9610-c6c3afa103f2"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("1c3bc0ab-948d-4ff3-8b5b-b379c8f17ef2"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("1d198016-aa5a-4470-869a-b324ad4b414f"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("1e851c92-425b-43a5-ad28-b4b69a2619b9"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("1eaafcba-b844-4a54-b4df-4188c0030e58"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("1f0996b6-e2eb-42d9-9052-002893d9ef5e"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("1f9e4303-1f37-4528-bbd8-be19237a2f12"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("1fb916f4-c4f3-4982-9ccf-831a2e4c7418"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("2075c28d-c8f0-47ce-afec-6076439c2414"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("21224da0-d994-43bc-a255-de2196e45fe8"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("21808835-84a9-4e8c-b3c2-563e6be681c4"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("21920bdb-4390-475e-beb1-10dd28a50f6c"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("2261abb1-1534-44d4-a768-8e98fe9de468"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("23eb8ecd-e716-4206-90f0-73ad6ce37ba9"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("24abd950-c84f-48a0-b13f-08ba1687c5b0"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("257f0144-0d8e-4279-a661-e9bc84cc51b9"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("266558c2-e7d4-4e5f-8cd3-7eafdf2011f2"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("26d06311-6cdd-4c3a-8b41-de88737744d3"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("272ab11f-0596-4785-8171-da054b2b84ef"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("27315754-f175-442f-9dd6-bd085d5671a4"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("27537960-216d-4b1d-8bb4-78439eac8a60"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("278c23b6-05bd-4754-b429-497912a42875"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("27c9922e-941c-4bc5-9c8b-008ce763ffbb"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("27f25c91-155d-47b4-8bf2-efaaa27df03d"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("28ff38f3-8e64-4579-bdc5-9423e6194b78"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("2908b049-1a88-4e33-8203-2790d07d101e"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("2983a4ed-7605-4137-82cc-d600463fcc26"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("2a76843a-a886-4207-b62f-6cbc74fc9e16"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("2a94b158-6bfd-4f59-8b84-c72f0e6dbfe0"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("2b6efff3-438b-4fc7-adb1-c8ad320cfd3a"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("2b80d104-f9ae-4578-b78a-57a163208e09"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("2c22b82e-c48e-41c6-bbf7-9ce9e1d31304"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("2cf74112-88cd-47bd-bf91-647fbb1cbd87"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("2efb2dc7-921d-49d8-98af-316f9d06e3ef"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("2f1ce64d-be27-4b2c-957d-d40f9ca1c0da"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("2f209651-2072-46c1-92c6-e3129812872e"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("2fe50cce-1c56-4de6-8453-8f2ed7108ec8"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("300297c1-390b-422f-99dc-64deb2999633"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("308453c4-8986-4fb7-a371-ea7667bceb8f"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("30dff33b-5d00-4ecb-b9bf-b416c8f09d3d"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("321e8ffb-7d75-4576-bd68-b3e3dfca321c"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("32491f9a-68ce-4e50-a4fa-d1c80b3b754d"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("32993f7b-e974-4893-8253-dcde6a20011a"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("32b4b79c-d5c1-42a3-8ff2-cb820748ab12"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("331879de-0917-43c8-a806-ca25a5b7ee26"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("346a689f-179a-4643-a365-cbed0d294228"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("34f99364-0c8d-499d-a9b1-e210c6b44403"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("365704b7-4690-40fa-b7b4-721945e7d168"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("38425870-c577-4f40-a441-137a9d7aa79e"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("38a2fd86-16c9-41da-89a0-471e668057a2"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("38f47fd9-8c91-42fa-a53a-42e3f773b649"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("397ac297-9bf8-4043-ad0d-1fe48ccbb92a"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("3a6a0336-a316-40be-a931-19f9b334d814"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("3a749c16-5c5a-4643-8a51-081e6603ff93"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("3aea664c-3b78-41b2-b46d-2bab83fac782"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("3af1a8f4-d043-4560-98e0-e961f621dea5"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("3ba53ff9-55ec-47a8-bda4-7b2b3bfe7eef"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("3bb4cc15-9de1-418a-a77c-eeb97022aeea"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("3bddcffb-8d45-46e9-8e31-2c7f727bc520"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("3cdd0d98-8009-4cb3-915f-ae60410b6179"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("3d94a2f9-d946-4442-adcc-1853c18a2a66"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("3edef03f-2c5c-405d-8e66-347bc84cf25c"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("3ef49176-91ae-4057-8d91-08c2204f6ca5"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("3f096855-0418-4441-b5ad-7ed25e4004a2"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("3f1101d0-303f-4d6e-97df-6c7b015db54a"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("3f9dd1fa-a471-429c-9dae-7b04978c8c01"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("3fc45a1d-2e7e-4c1d-a63f-8bbe23b0bdb1"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("406c1a27-235a-4a65-aa5a-a67696bd2c15"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("40b5eeb0-a9ed-4ba4-a360-f74be0e61c9f"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("40c59511-ba4d-415a-a077-36787b60a24d"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("41381c8d-ed1e-4be0-a8ce-36ed3dcd7454"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("4177d8d8-ab32-4267-8139-53e959a69a1f"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("424da8c5-d636-449e-b413-0ff958d02fb6"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("4281fc8f-b215-409b-a266-a457f372a658"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("428e266c-7038-4760-a0c4-85412ff38c15"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("43af24e5-74d9-4583-826d-82bf37a59326"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("43c4cac2-8fdb-46e2-83ee-0b01b6fb3cfa"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("4428f056-f48c-4d8e-87fe-a5a601640dde"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("45a8252a-7ff7-4723-b873-b0651fed7650"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("467d7c72-6c2d-44cc-a93f-a9635cc88f96"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("4696e43d-ceb4-49e6-811b-91955c83c761"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("46b64731-f69e-4a76-b4e8-a04b5463f31e"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("4765e15e-c2f8-44e8-aa23-404b017ad7c8"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("477daf13-182d-4d0e-911c-41330e22c8ca"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("47906dc4-c353-41c6-8023-db035c1cf11d"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("49530039-6beb-4e5a-a204-928549bde57a"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("4c16bf0f-d467-42cf-a273-7aaf35a3700c"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("4c444550-1f40-441d-927e-8222587945de"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("4df4d2a6-16de-4b4c-af4d-dc2c14fe91c4"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("4e9ab62c-6b49-4c0f-b133-d29769a87875"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("4f282a23-c9c1-415e-bae1-b17560c205a0"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("5000f800-ca2c-4d13-a662-4ffea05ca8af"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("500b7e09-ba16-408a-a3d8-a2f257c2d4ba"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("5028e234-1f5d-4ba6-aa05-f1b16486aaad"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("50ae70f4-480e-455e-a52a-5d8d70118fce"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("50eb0628-d989-4161-989a-5ba449cde161"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("51208adb-93ea-4db5-ac32-67eaea7bd131"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("51c4d966-be64-42d0-a4e3-ad4922d104ee"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("51d415aa-98e5-4bd7-8c8f-c67b7f3a6947"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("522ec4a7-741b-4be4-92ff-e498563dd758"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("52e7aad3-30ca-44fa-a8a4-2b88f61772c1"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("53f5e181-64e5-43c0-9562-5cbea6811051"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("54108911-2328-445f-bf8a-2908b6222b8f"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("5472005a-376a-417e-88a3-4e0132bc1fd0"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("55447a54-afdb-41e3-9c03-fb7f91923d9b"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("55a69679-d8fe-475f-be5a-206bb3f188dc"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("55e5d5d0-0f55-420f-b32c-ba246b59a013"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("560cde4e-f0ee-421d-bfa2-4d36e66534e2"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("567b7275-6054-4e4a-94a6-e288f8363cdf"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("569920d1-aac7-4344-b056-807b8ca638c9"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("56b5f97a-705c-4156-a3ef-5295d50c8e02"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("59ca1c35-0b5a-4f84-b93d-c913790ce636"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("5a1c413a-13a0-42ef-b411-032cc7e4c6bb"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("5a5555c5-9d2b-4b4e-a8b8-10f71072cca5"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("5b07930a-b5a9-4dc5-9b90-ccb7a9dc72d5"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("5bdc5e76-b828-4573-ace4-657774403822"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("5c43af33-3bb9-414b-b4a5-d5f7bc2871fc"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("5c855ee6-4516-4d05-acae-d1ef64f8d529"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("5da1971f-eebb-426f-bb84-3169140f44af"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("5e629c96-9013-41a6-a847-6798ece7289c"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("5f27046a-a728-449c-a755-d109b6da6305"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("5f5fdc25-89d4-4f9c-8401-c5efd998ba9b"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("5f945157-896d-48b1-8e20-7a00471e08ea"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("627d6fbd-7f21-4ea0-abf3-3bd8a2b35dd9"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("62ac119a-e639-4f67-9f3e-55fa6d7cd5b8"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("63cc78de-a8c1-45a1-ab22-111912655b0f"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("6453673f-5504-4ab4-b8e2-7c24f203de86"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("6460ee32-2853-4473-a201-3e2224e43e8d"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("6528d303-346e-445b-b136-51fd70bd6729"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("652c0794-6156-416c-a128-491725321eb3"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("6588c771-0bb9-4f04-9bba-30f92b2cbf94"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("6602a985-8f69-42f4-8613-b9276301aafa"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("66a08680-1bb8-4001-9dc5-043eb48751cc"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("66bc5768-f578-44f3-b926-b189a362362a"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("66c731f0-af6a-4112-838a-cbf97c89107f"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("671e2459-df4e-4b0b-9da1-d800e860b8c7"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("677348c2-4480-4101-8c6f-f49add7ed2d3"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("67bd4bb6-259c-417c-954e-9a43a7219f69"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("68200191-b99e-4ebb-b949-04e9e04d87c5"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("68f9e3b5-e5ce-4c11-ab67-db2691b0df64"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("69a301a0-6347-4bbe-913f-9c4207c6cf2e"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("69c1127c-c1b5-41f0-be18-e6d57b53e584"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("6a09af9a-18b7-4d87-9b51-71dc5dda39df"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("6b1a7094-a595-47a1-bb02-d27157f8b986"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("6b36c77c-1546-40c4-9d9b-a6400167e68c"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("6c816a53-134a-40c2-8785-eeeb3baeeea4"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("6c8da8d4-8cd5-43f2-afb3-07e5f70fb6c0"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("6d9a80c0-0c46-4c3d-b9f0-36d10f687479"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("6dfded7a-b11c-49ef-abc8-85933c988f71"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("6e2bba52-4ff8-4d86-a0ba-1e3c4be4060a"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("6e38e15f-dd81-472d-ae16-9cac606d1353"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("6e763f8f-89c5-4689-87af-422682c01d6c"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("6e9772b5-74dd-43f3-98ce-788a00e14b54"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("6ecd7193-0683-415a-86a8-074fffd57091"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("703a1892-9825-4098-be7b-6f84dcee99ea"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("707783fe-97c0-4dba-bb21-aa2d52123af3"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("708347f3-e9b7-41e4-b8b4-4138722654d4"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("717bae65-4abe-413a-9732-a242710dbbbf"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("71af8e78-182c-48fe-ade6-a27017651d8a"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("72640d74-b354-4ab5-9ab2-5ea03798409a"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("72742f65-67dd-4c57-8449-b5b5a1609764"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("72752394-e545-406d-8d55-6da48c02f6c0"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("72fb7340-c690-4cca-a91b-25da598d5a7b"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("732a3832-113c-4ba7-a746-6bb670c93ffd"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("733d0bbc-8270-4caf-a24f-963329e67456"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("73414b2c-a7d9-4dd3-91f6-88dc99bcb8a8"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("737097e9-de20-410c-bc66-27b77bd53544"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("75f8a4ab-c767-4157-896c-fc84eae79a95"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("76c2297a-a2b1-456f-9d4a-5ab2682638b8"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("77685fed-77f1-4f1e-9588-546f7d3fb88a"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("77847680-fa92-4498-a05a-98136ff91d59"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("78d4a6b6-a0ab-4fe8-96b8-fabfc0f328cb"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("79d81445-9365-42b8-80e5-e4908b29548d"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("7a5d6144-892c-44f3-9923-4e6acc1942dc"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("7aa420aa-09fe-4b85-943b-3456c86785d1"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("7b0f7fb3-098d-4052-b082-62f49c1f524a"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("7bdd30d0-623f-4d51-a001-b15827933323"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("7be612de-5330-4659-b025-bf115ac919a7"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("7c1524ad-d7cd-48d1-a364-56c5536d0ec1"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("7ce0bf95-5d93-40d6-a3ca-581b53aae524"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("7d021962-57d7-4ca2-bf30-9259ee5ab868"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("7d12de65-1ed1-4ff4-b370-48431ed33498"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("7d2989d7-5f2e-40ab-b1ea-0f702d0bc7f9"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("7d58002a-d39b-4c5e-b2fe-707333b67143"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("7dcce746-1b9b-404a-bc7f-6144dd47998c"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("7df7d199-1fc6-4931-bacd-712a6c31e854"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("8021ff3e-eb1b-446a-9b73-adef0d0ae9d2"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("81b8079b-2f6b-4063-b3e1-ba1de92ead70"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("821a3374-ff1a-43a7-8424-e0acb0da3668"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("837f7298-f17e-4889-934d-bbe3928cf78a"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("83b288db-82cd-4af4-a50e-a155ea33e4d1"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("841ee253-d742-4016-8a23-c0cf75f73d82"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("85513d45-bd3f-4167-8a8b-f36285fae04e"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("857e0dc5-fb65-413b-971a-ddd902925cb2"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("85f93e77-bc2c-4379-9ced-204048d04d89"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("86b26bee-9175-40e4-8b05-a00fc03c9fc8"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("8707ff38-f985-4c03-b1bd-c3aa5b1d1a39"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("87b5243c-e90d-412e-bb1f-3e442f84dd09"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("882ace04-92bf-49a8-a68d-2905e2ac9bcc"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("8848d718-531f-4e71-af3a-41492049bdf5"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("88b94e99-be58-4865-9a81-91a69665b91a"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("88eadca0-4df9-4cae-b62a-499308be8000"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("8908d843-f524-47cb-b23e-643c2ed0c3b0"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("8a5828fa-1591-453a-9d47-3326c055cf07"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("8a85b8cb-1af7-4169-b469-4d4f44f011f0"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("8aa66574-fa04-4662-8eeb-a9da3d191e6d"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("8ab20b3e-dc0e-47c3-aa2b-3c22535b2c59"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("8b2b57b7-4263-497d-8717-39a153ba8868"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("8b3f1810-d77e-40ed-9602-3b010393f2f7"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("8be099e9-4c51-4a1a-bc5d-1a7d8a6ecfc9"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("8d193de8-5148-418e-b0f4-9178cb91c947"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("8d2e9dba-596e-48ed-90ee-016f252a58d9"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("8dab255b-b429-4987-8dc8-fa76cac2947c"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("8e008156-c553-44b0-bb4b-2b871a23b084"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("8e55a6ff-fe4d-4f28-986a-918ab9cfbebd"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("8f3858f2-50ab-47a2-bcb1-2cc1f45066f7"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("8f870d79-d57e-4f7b-ab9d-6c61ab3c64a4"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("8fe5d0ba-5fb2-416c-8df7-effe5df4a477"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("9045b07b-ed8a-4095-b478-ab3be52d4aa1"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("92350aae-d25e-485a-ac06-3244edd8d966"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("92c54277-2d4f-44cc-b95b-a940909454fd"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("93ab2fa6-2a8a-46c8-b5c2-7cb99abac0b0"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("93e9e66e-ffe9-4723-a092-5223a6843f7a"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("94d11980-9385-4eff-a913-00ffd4ed7186"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("9560026b-c0da-4560-b900-1b9a98a5481b"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("95a730b1-31f2-4b4e-9735-87d58e052f46"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("965a710f-7c23-44b0-a714-aaa668453c9f"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("96eb6e4f-b46c-471f-ad4a-3a3412960b91"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("96eec7f3-f76c-4271-ac3c-0a34afb3afc5"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("98060567-e398-4547-8a91-4240835a1865"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("986fcb90-274c-47d9-b70c-11a84413ae47"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("99689641-1265-4733-8d29-e079c828d4f4"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("99b4410a-a72f-4859-ae70-3300d702a593"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("99beea68-6adb-460d-87c7-62a1f904cd39"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("9b6b5072-2abd-4894-8171-d93d23fac035"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("9cb3c19c-6e84-44c7-a01f-e963f5fa9f99"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("9e1232c7-afe0-4b98-8611-cef575ba0287"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("9e56a7d1-d998-412c-b23c-c2f9a6cfc069"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("9ecae500-6486-4150-af21-e9342099d63d"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("9ef2fedb-1ef1-44e4-838c-81b6b133c4d9"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("9f9f764a-f436-4d49-9e69-82a005c0fef1"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("9fadd129-9cfa-4d26-a8bd-1a3065174a0c"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("a0545d9d-9f57-49ed-8df8-ee7d530a6faf"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("a0b97346-fcf9-4317-978a-c3e0125d8c95"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("a113bf16-cf4f-46bf-9994-be81e1bfb5f4"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("a12a96c4-7af0-4a61-b87d-5c6ebf9e074c"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("a24f2e94-143d-4ef8-8a7e-c68df91d19db"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("a26e0aae-5201-4f4f-aecb-0adf47c74dd1"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("a37ac663-0ba8-4bd0-ad6c-8a994ae6ac15"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("a411463b-be35-4a60-89b7-2495ba64aca6"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("a5189a67-94f4-4a67-8257-ee31411406f4"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("a5bfb23c-14b6-4c03-a629-bacb408a0f95"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("a5c2b72a-de5f-4386-bff2-2b771d8faf00"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("a6795bd5-a600-40f1-96f1-75495334531f"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("a69d2ffa-e2f1-4e1e-aaf1-3a624e6cfb7b"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("a6b9f574-129e-4fb5-aa39-3e34283201e7"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("a765dcca-5242-42a4-94f7-a654cb5dd7ef"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("a77ff4af-40bb-4e4d-88f6-1d73dd3d1532"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("a8283f88-bd52-45b9-b4a1-1c71665293c5"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("a830e576-8447-482e-8328-27595c09233a"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("a9139f63-b421-48e5-b57e-9e6cbb981335"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("a9b9a516-fb52-45e0-a505-06d4c90212d3"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("a9cf1323-5247-4e09-a6bb-ed6b51549d82"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("aa6fa9b7-0efd-436a-8ac3-b895fa1f056b"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("aa83fb9d-1490-4244-9d9d-7d8f186b304b"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("aa95c2f3-14ae-488d-86ba-c2429d3ae115"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("ab9cf665-86e5-45a9-ba23-7b3d78b063a5"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("ad29c2b0-e30c-4325-9266-8014862f73e1"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("adc35eb2-44c3-4695-b021-a86e6ecb79b6"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("ae5d39f5-cead-4dcf-9cb3-90ca91adb50f"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("b05d7f60-7c08-40a2-b309-bc0e54153282"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("b0c1fc1f-26c9-4f2d-a5a4-486098cbffbd"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("b2154e46-0751-45a3-a04b-1854e5354e1f"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("b2422659-428f-42f3-91ec-7b631e987bfa"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("b254fddb-62ef-4a4c-b086-b809bf4a3c85"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("b26814e0-0e0b-4c6c-b93f-e2cc674be21c"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("b3705cbc-bf08-45f8-9065-165b04897237"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("b46e68ab-8087-42b0-8cbb-67c40c6cbd92"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("b50af727-cfdf-49f6-b32b-af463e8f02f3"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("b5a1cba3-70d5-47f4-b7d0-0c66952a1483"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("b5e6c77b-72df-4fb9-ab38-733d5c1cb0be"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("b757718e-32ba-483a-b6e0-3ad09330d603"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("b75d0a7f-20d2-43e8-9049-3e052074a493"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("b78c1f18-e22c-46cb-822e-95ed13180e1f"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("b7e12317-8c04-49bb-aae0-008104ebb230"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("b7f428e2-fffc-4b63-a110-4e25b95a1391"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("b87b2423-28a2-4462-839f-317a9243a02b"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("b9557d81-8a3d-4c6d-b710-d691aea4cc29"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("b95de245-d28a-43da-97ee-2717257f5e8e"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("b9df8bf4-f2d8-43d8-bf99-692fe80161a2"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("bab59bca-4e8b-4c2b-807a-ec596eafc734"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("badaab0d-8ffe-411e-9f06-88dbb625e069"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("bcb9deb5-bb25-4166-9c5f-5b33f3b8a908"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("bd43afaf-827c-4096-be24-ec2845221394"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("bd49617f-3d0c-4523-8dbd-8f547533bf15"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("bdd1e3bd-34ed-4087-998b-672a0f7c4541"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("bde7d97d-fd52-4dbd-845c-070fe28d1eef"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("be28a592-e7b7-4872-a654-dc6c67601984"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("c0056a8c-cc43-4569-b34f-9b3497b41029"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("c06e0c2f-0698-4542-9287-396df1ca1da7"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("c0a0110d-2ae2-4bb2-907e-550860f99486"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("c0c30d04-37a1-474d-b131-34d819f65972"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("c216f101-8bf8-4a14-898c-aedd6d8950fc"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("c2b26e84-328c-4933-801c-d85561951519"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("c2c63cbc-f682-49eb-8077-32cb297cedae"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("c2f8e980-d194-45ab-bcfd-1867e22aca61"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("c407b1ab-42f2-460c-8703-649d6681c158"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("c4fc906c-188c-4a35-bf5f-ea8c991d9b19"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("c5acf82b-7cc3-4c11-9b5c-b078890b3fb9"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("c5cf28aa-3275-4959-930c-26150b542cbb"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("c5e6fb2d-df80-46c2-a0f0-6bd7d2cfdd6e"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("c6e79d64-6e7e-46e4-909c-23a6ad4d1a50"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("c72b38c0-40fd-4086-9fa7-e612e834bf7f"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("c72e9c2a-74f6-4005-99bd-aa2b9a8bd136"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("c7588cba-e4f0-46e4-9acf-3cff10f75a19"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("c865086b-8091-4f43-84fb-fb4aa2867564"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("c8e17935-e205-4d65-b086-6b476c3f5e5b"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("c919c16a-3a03-4ece-b9f3-0b1232ccfc9c"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("ca243b2f-809b-48d2-85cb-9c4ea6639514"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("ca50eb3a-a2b7-4693-9182-40cd9f944763"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("ca6d7868-9199-4b8a-9e77-cf64a4ba3720"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("ca958b36-8035-4191-b987-6a7d03621e39"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("cc3002ae-73ff-4d8b-a30b-7984ff65c637"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("cd0005da-238e-4f4d-a8bf-577145927e55"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("cd2d0845-0303-49a1-888f-0dc5618b18bf"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("cec85e4b-aad3-4e76-b021-b116f3430e0c"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("cf050a5b-1c69-43ec-b110-0cb50866f53e"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("cf42c0f9-f178-4ad1-a9b0-23cd3e2f6dd2"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("cf64bd66-8135-4db4-84c7-4b4042014171"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("cfecd9cb-64fa-4eb3-b28c-de174daece9a"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("d000a5a4-3acb-43a5-ae0f-13bcdb9eeabc"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("d0606c4b-b76c-4b19-a91e-19caa19e1d03"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("d0df1f36-e28c-4294-a777-a5d8cdfdccfa"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("d111f79c-9d1a-4673-89fb-725b2e8ca290"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("d1910ef9-a38c-43eb-b6da-1d8959484df4"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("d1dd51a1-7ddb-4576-99c9-11d6d4bc180d"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("d29a4daf-014f-4693-9fa8-93bddc76ca07"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("d2cecba9-7215-435b-8f88-6bc8b92ad0ca"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("d35cd03c-752a-4e8a-8151-157206a10e04"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("d3d90704-52a5-4985-8c2d-8c0ad5fe0ae8"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("d674b579-98a5-4685-b5b8-57cc4ab44ecb"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("d72726b6-d76e-4040-b2b1-4bf364950070"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("d72f3aab-2c10-46a2-8651-d64fa7f5ec22"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("d7439311-90f3-4a2f-96fc-43601117cfdb"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("d796e8d7-3a26-4aee-ae1b-9303dae5354e"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("d7b0d987-5c73-49b8-b07c-e391539f9e79"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("d8080506-7374-4594-8b1e-ea40fa568f79"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("d84d576b-6a48-4fca-9052-06a5e19377f0"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("d8724ba4-2f9c-4fc7-80ed-5fbb6db5e1f1"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("d87f1b04-50ad-4536-b024-b7354cff5924"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("d8e6b80b-1d7a-44e3-a890-795d265aea56"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("da1a916c-9f90-436b-9b8c-896b7b952435"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("da209dfa-7ece-45fe-a40a-58e9190f9f11"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("da237e31-e1d7-44a9-aa15-f4cf191f3325"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("da5738fb-e203-47a5-842b-d2ed8be5bacc"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("db072f2c-39e5-495d-b589-58b1a2bfdfbc"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("db3c449e-a5e2-4112-8ed6-465295f60b0d"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("dcf30dce-4ec1-42b1-b2e1-518854731a86"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("dd0210f2-e619-4378-827a-b9615e1a961f"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("dd03b987-abe4-4fc5-a039-84acbc0d0f9d"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("dd157da3-eae6-4716-bcfc-799ab9938468"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("dd3b9f9f-6539-4c9c-b4b6-3beda2a91ef7"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("dd8b7e20-305d-4c58-9426-b5a8ff393a63"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("de8d2200-13dc-4484-ad75-49d52d913176"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("deba987f-ae57-4896-b8db-0dbb4e887bf3"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("df08a6cb-a92b-43b5-aa3b-12684a6b4713"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("e02ec9b0-11ad-498c-9cba-567742ccb535"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("e0c89c34-cb77-4a6f-8203-e2b2423da4be"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("e148b86c-f415-4535-b29e-387e7c0bee39"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("e19432de-97ef-4325-a04a-0cc7fc0361df"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("e243f48b-051e-43d2-b040-b785a4c6a8f1"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("e36558c1-ac77-4399-9ead-686c02901a55"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("e3c15b11-db73-44c6-9897-943353ac36cc"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("e562a31e-7a9b-4350-ad1f-d0faadb9fc5c"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("e618cd1b-7e69-4a4f-81a0-5d6ef3a49ebf"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("e64d9d70-de4f-464e-81f1-e582889b2bf8"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("e718d0f2-f245-4dec-993f-1f4e21c93509"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("e71ff896-63a5-40da-b17d-7e2bb4f7564f"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("e8381a7d-cf81-46d4-a874-65a3ea8bba55"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("e88e5c49-67bc-41c2-8468-999a0854f14d"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("e8daa7d5-86d5-4b6d-9352-e4330224d7ed"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("e90b0d76-c379-4c70-9e1d-278d30d2f84c"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("eb914b69-abea-449a-b6da-94c97205dbc6"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("ebd4b116-4668-47ea-86f6-76221e36cdef"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("ec7eee20-b872-44f3-9a95-63f4b8c57889"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("ec80556b-4ba3-4bef-affa-8e1c2677329f"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("ed204a67-aea4-4846-9cce-8ed1d7515747"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("ed3a4cbb-e41d-4c14-acc8-3de98d3759d1"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("ed84ea16-34be-408d-8f1e-095a2c28071b"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("eda93807-2914-4d73-996a-ea3da0119c8e"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("ee0ebe02-9cf1-4ea8-9e3f-83de2064860e"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("ee109302-8b1c-4725-a378-5d6030d130f5"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("ef0d1783-fa1a-4d30-b97e-eed3059a14cf"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("efeb3f87-7d88-4ad9-bc46-cba105941cea"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("f07ea390-208f-4d3c-ac88-dcda683a2a4c"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("f15fd353-be99-43d1-8702-870ff329dede"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("f1603d30-ff76-4d55-9b6e-f88262818bef"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("f16ac678-bb42-49a9-8384-c73dfff9031b"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("f18fa01b-f2ab-403f-839e-b309cae77257"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("f1bcf935-7ef2-4db6-9d04-4dcf0a065bfd"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("f269ddc9-a1b8-4dbe-aba6-4de8bac0f60e"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("f272d9e5-c74b-406b-8ee7-49bc219fb236"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("f2d24856-7142-4f63-a3ee-cc0075bc049d"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("f362f83c-7246-4432-bb00-378cd85726a5"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("f3745df6-34fe-4893-b49e-d2df69ab9b41"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("f4864def-5bf0-4807-82de-0fcf4b5035cf"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("f4a06801-56ae-4515-b26f-a8254f4f9138"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("f4b2f19f-b10b-4e63-bb8a-366fab5cdf6a"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("f4e343e6-4253-4feb-acbd-4b2e4696f031"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("f520eb5d-a149-4501-b81b-b91755d8e824"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("f5b3308f-fad0-493a-be74-a67f4b11aaf0"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("f5bea200-ec4f-4c93-b880-f976932dc1e4"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("f6d7f159-ec7f-4e57-aebc-2e3da141113d"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("f6fa9365-7360-4270-9a79-f24684e6ab84"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("f78b432e-007b-4e1d-b9eb-e663be27e11d"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("f797fc83-985f-4ff3-a4ae-dfc68bf1d976"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("f8802137-c2ad-4612-ba4e-e4ec60429fbc"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("f8f80952-4821-4e6b-b803-68d7b873c0d3"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("f93241d6-78c5-4020-b05b-6653482395d9"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("fac3b393-3b10-49c3-af64-9b72c2213e7e"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("fb0b9918-ce22-45c6-a897-b238a9ae752f"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("fb1a905d-8041-4c96-a90e-15351471b676"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("fb8a3467-0ac9-4d28-abbf-e859e6a3f379"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("fbeb86a4-bba8-46d7-8838-080c7e13a1e3"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("fcad16cf-d55a-4da8-bec2-bf9e3b5efdb6"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("fcbbbf4c-59af-417d-bf69-472fc44f1f46"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("ffd568cb-99c5-4013-a9dc-b6a60e9c6143"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Words",
                keyColumn: "Id",
                keyValue: new Guid("ffd5e14b-c9e3-4a8f-a1ba-32394cb192e8"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("00242767-9606-4d08-b96b-7a1498a6d0c9"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("077d1b35-28e8-411f-956a-4ac8883d27b8"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("08681ed3-8ab0-4a1d-967a-2c2806b3a099"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("08ed1ce8-96e5-45ff-b10f-8fa49a1af3d4"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0919cab8-a02f-4da7-9b47-1a58351ea9c3"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0fee6686-f59a-4025-9184-858d1c0a3659"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("111b3155-8751-456a-8a77-f1c26ced8f18"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("11af84dc-c777-46c9-ba7e-8fc836a804f0"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1a04722f-1b4d-4730-b1f0-4fa2f8d71bd7"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1bcbf50b-967d-49e2-84b8-aba447ac4954"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1ce82652-e890-4a79-980a-de6a7291c4b6"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1d31d367-6651-40f8-a82d-b6f033debac9"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2050e871-9095-4f46-8787-8f717f114ea2"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("21983f75-6289-4334-9372-c88a81690e96"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2233f2a0-b9c6-4072-8ace-ea274ebf6cf4"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("23c9e459-845c-4a74-96fa-5eda6187cb1f"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2958e0a7-9ebc-463a-9f87-5a98ab680449"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2c900207-3d73-4b27-a482-f16ce64b7729"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("30da8a31-852f-4cfc-89e1-c754bd83ad25"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("33864b46-810c-4fad-aee0-05e42b413e6a"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("35a00634-becb-46a3-bc3d-a73bb2b46ab1"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("35e343ce-74c5-4413-a75a-48e29d6ee031"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("36411c85-2a47-415c-a396-ea52bcadd3e9"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("38df6419-b7c7-4f23-ae70-6ddadf05db9f"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3953a15c-4d98-4b8d-b5a0-a2bbe4449fe9"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("43d627bb-e3ed-4a8d-81b9-8e0212a3a8a0"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("45425db5-3e53-471c-861b-007a0b2a305b"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("46eac2d6-1f33-4c2a-b420-e914de870deb"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("47124eb6-a2d1-4b91-9e5d-5a85169625c8"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("47294d03-3395-42a6-83d8-389d19aec14d"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("49c84e13-c9a2-4665-b563-7c1f686c8b8d"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4afa32ae-daa4-45ed-92ea-f910b90116c1"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4bfb0f3d-91d4-42c6-ad20-dd66a700d43c"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5c96d301-355b-445f-a153-07ef89786909"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("61a06c06-8603-4dd3-8fe5-92f3364e3814"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("67f7b904-927c-471f-8dfe-73f54adb9e03"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6b9c1472-a03e-4854-bec8-cfc8bfb8e06c"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6d0cc462-65e5-48a1-beb0-b7cdb1f04045"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("6e183839-2a73-44bf-b4e2-b3ab25613a5a"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("74886f2d-4d3b-40fe-b96a-7524e9fe5b09"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("765b06a2-50d6-4c56-8845-143e7ee7c733"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("768101f9-4a4b-43cd-aa34-faf712bfc940"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("791f349a-79eb-431e-8c4a-29371d6e0689"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7ac50144-ad5f-4702-9d87-ea996e8904aa"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7c07747b-ded1-4c2e-9a36-17f95fc059f7"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("817ce59c-2207-420c-9dd7-db822ab79b4b"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8296a1d5-c980-4187-8379-29625ee413d6"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("84b9001f-564e-42c5-a864-eefa2f289f3b"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8650e3d8-d11f-461c-9f8a-b00e6379c348"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("865496b8-3788-4cc3-8f6a-09dfebcd2d9b"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8d53f533-4cdc-4e5a-a963-54f31febf8e5"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8de0af24-b98a-4f94-8974-aa3c51220f09"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8f56c4de-e4bf-4354-8279-ea3f6aca18dc"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("90a95bc6-f20f-4e55-b3ba-469f4fa589f7"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("928acaf1-743e-4c3e-bdfa-e24d0e6ff485"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9d53c467-f7e8-4433-971c-5e7cb7ce6a71"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9e891766-82ec-441e-affe-b3138b7a04db"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ad46e855-9605-4d41-9eac-2c8dfa2f7c1f"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("aee272ba-c84e-4fe4-a8ea-49386db26adb"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b8a0d599-6575-4626-b2af-317f9e78efa4"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("bc4032b5-0b91-47da-8e6f-db283a515989"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("be20ccf4-be83-4bc4-b08f-5c2bd02dda01"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("bfca2c81-719c-4189-8e2d-027163421517"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c4f3b91f-1c7b-44a2-b32e-32ef0b1f0b11"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c5406625-55a2-488f-9050-a5ab649cd3ce"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c6453de7-f75d-49bf-ac53-4944dac3b288"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("cef21bb8-1373-4236-9b2b-703377c974bf"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d2a4e39d-1b0d-4584-bfd2-aa0cfbb070d6"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d54d614b-f911-4fd8-9932-eead5f63eb74"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d57af893-3fcf-463f-8722-03583c052ffc"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("dbdc7990-cb51-4e30-96cd-17e3fa20dafa"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("dc63683b-d306-4203-9cce-452d0f828491"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("df7940f8-70aa-4e17-9df0-2bb4a46d6d7d"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e2ec419b-08c9-4295-86e1-e8846488b20c"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e7ac161c-561a-4ffe-81f7-b57b37b19e52"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e89a87ca-93c7-489c-85e6-200a1192d751"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("eaacd632-357b-4473-8bc4-e64338f16811"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ef5c8e17-28a7-4673-97d7-ab3f84d01aa3"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f1bb33c6-6457-442a-a937-24ec243a7dcc"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("fd21cd86-2fdd-49a9-8447-0159f7756337"));

            migrationBuilder.DeleteData(
                schema: "practice",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ffd37b6b-c0c9-4f04-a7c1-f6dffb9eec21"));
        }
    }
}
