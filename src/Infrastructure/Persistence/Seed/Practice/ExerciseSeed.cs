using Domain.Common.ValueObjects;
using Domain.Practice.Exercises;
using Domain.Practice.Exercises.Entities;
using Domain.Practice.Exercises.ValueObjects;

namespace Infrastructure.Persistence.Seed.Practice;

public static class ExerciseSeed
{
    #region Lesson 1

    public static readonly Guid GuidForExerciseId1 = Guid.Parse("6ed88863-0c5d-45cd-b361-3071bf62a907");
    public static readonly ExerciseId ExerciseId1 = ExerciseId.Create(GuidForExerciseId1);

    public static readonly Guid GuidForExerciseId2 = Guid.Parse("ec6ea7e1-3dbb-45a7-801c-3441c6ef962f");
    public static readonly ExerciseId ExerciseId2 = ExerciseId.Create(GuidForExerciseId2);

    public static readonly Guid GuidForExerciseId3 = Guid.Parse("dacb0b73-7bb2-491f-9bf6-adb1f3e2f50f");
    public static readonly ExerciseId ExerciseId3 = ExerciseId.Create(GuidForExerciseId3);

    public static readonly Guid GuidForExerciseId4 = Guid.Parse("f8d8fcb2-4df3-4321-9538-fe576ef04c2d");
    public static readonly ExerciseId ExerciseId4 = ExerciseId.Create(GuidForExerciseId4);

    public static readonly Guid GuidForExerciseId5 = Guid.Parse("69dfc0ba-ac95-44bb-b412-b36b2a45f6bb");
    public static readonly ExerciseId ExerciseId5 = ExerciseId.Create(GuidForExerciseId5);

    #endregion

    #region Lesson 2

    public static readonly Guid GuidForExerciseId6 = Guid.Parse("8cb2fa8b-6886-4fcd-a596-ecc8f15b406c");
    public static readonly ExerciseId ExerciseId6 = ExerciseId.Create(GuidForExerciseId6);

    public static readonly Guid GuidForExerciseId7 = Guid.Parse("7f44ae6d-6b28-47aa-9d9b-500a632303ef");
    public static readonly ExerciseId ExerciseId7 = ExerciseId.Create(GuidForExerciseId7);

    public static readonly Guid GuidForExerciseId8 = Guid.Parse("05882a8b-9897-4793-8a1e-dd0cf841c95b");
    public static readonly ExerciseId ExerciseId8 = ExerciseId.Create(GuidForExerciseId8);

    public static readonly Guid GuidForExerciseId9 = Guid.Parse("7fafec3f-f7fe-46d7-962d-79d62dc13f66");
    public static readonly ExerciseId ExerciseId9 = ExerciseId.Create(GuidForExerciseId9);

    public static readonly Guid GuidForExerciseId10 = Guid.Parse("24de4efb-c76c-4d7c-ab9d-914a272962f7");
    public static readonly ExerciseId ExerciseId10 = ExerciseId.Create(GuidForExerciseId10);

    #endregion

    #region Lesson 3

    public static readonly Guid GuidForExerciseId11 = Guid.Parse("cef21bb8-1373-4236-9b2b-703377c974bf");
    public static readonly ExerciseId ExerciseId11 = ExerciseId.Create(GuidForExerciseId11);

    public static readonly Guid GuidForExerciseId12 = Guid.Parse("0fee6686-f59a-4025-9184-858d1c0a3659");
    public static readonly ExerciseId ExerciseId12 = ExerciseId.Create(GuidForExerciseId12);

    public static readonly Guid GuidForExerciseId13 = Guid.Parse("ad46e855-9605-4d41-9eac-2c8dfa2f7c1f");
    public static readonly ExerciseId ExerciseId13 = ExerciseId.Create(GuidForExerciseId13);

    public static readonly Guid GuidForExerciseId14 = Guid.Parse("90a95bc6-f20f-4e55-b3ba-469f4fa589f7");
    public static readonly ExerciseId ExerciseId14 = ExerciseId.Create(GuidForExerciseId14);

    public static readonly Guid GuidForExerciseId15 = Guid.Parse("1ce82652-e890-4a79-980a-de6a7291c4b6");
    public static readonly ExerciseId ExerciseId15 = ExerciseId.Create(GuidForExerciseId15);

    #endregion

    #region Lesson 4

    public static readonly Guid GuidForExerciseId16 = Guid.Parse("865496b8-3788-4cc3-8f6a-09dfebcd2d9b");
    public static readonly ExerciseId ExerciseId16 = ExerciseId.Create(GuidForExerciseId16);

    public static readonly Guid GuidForExerciseId17 = Guid.Parse("791f349a-79eb-431e-8c4a-29371d6e0689");
    public static readonly ExerciseId ExerciseId17 = ExerciseId.Create(GuidForExerciseId17);

    public static readonly Guid GuidForExerciseId18 = Guid.Parse("1a04722f-1b4d-4730-b1f0-4fa2f8d71bd7");
    public static readonly ExerciseId ExerciseId18 = ExerciseId.Create(GuidForExerciseId18);

    public static readonly Guid GuidForExerciseId19 = Guid.Parse("45425db5-3e53-471c-861b-007a0b2a305b");
    public static readonly ExerciseId ExerciseId19 = ExerciseId.Create(GuidForExerciseId19);

    public static readonly Guid GuidForExerciseId20 = Guid.Parse("35e343ce-74c5-4413-a75a-48e29d6ee031");
    public static readonly ExerciseId ExerciseId20 = ExerciseId.Create(GuidForExerciseId20);

    #endregion

    #region Lesson 5

    public static readonly Guid GuidForExerciseId21 = Guid.Parse("8d53f533-4cdc-4e5a-a963-54f31febf8e5");
    public static readonly ExerciseId ExerciseId21 = ExerciseId.Create(GuidForExerciseId21);

    public static readonly Guid GuidForExerciseId22 = Guid.Parse("1bcbf50b-967d-49e2-84b8-aba447ac4954");
    public static readonly ExerciseId ExerciseId22 = ExerciseId.Create(GuidForExerciseId22);

    public static readonly Guid GuidForExerciseId23 = Guid.Parse("be20ccf4-be83-4bc4-b08f-5c2bd02dda01");
    public static readonly ExerciseId ExerciseId23 = ExerciseId.Create(GuidForExerciseId23);

    public static readonly Guid GuidForExerciseId24 = Guid.Parse("35a00634-becb-46a3-bc3d-a73bb2b46ab1");
    public static readonly ExerciseId ExerciseId24 = ExerciseId.Create(GuidForExerciseId24);

    public static readonly Guid GuidForExerciseId25 = Guid.Parse("ef5c8e17-28a7-4673-97d7-ab3f84d01aa3");
    public static readonly ExerciseId ExerciseId25 = ExerciseId.Create(GuidForExerciseId25);

    #endregion

    #region Lesson 6

    public static readonly Guid GuidForExerciseId26 = Guid.Parse("08ed1ce8-96e5-45ff-b10f-8fa49a1af3d4");
    public static readonly ExerciseId ExerciseId26 = ExerciseId.Create(GuidForExerciseId26);

    public static readonly Guid GuidForExerciseId27 = Guid.Parse("30da8a31-852f-4cfc-89e1-c754bd83ad25");
    public static readonly ExerciseId ExerciseId27 = ExerciseId.Create(GuidForExerciseId27);

    public static readonly Guid GuidForExerciseId28 = Guid.Parse("8296a1d5-c980-4187-8379-29625ee413d6");
    public static readonly ExerciseId ExerciseId28 = ExerciseId.Create(GuidForExerciseId28);

    public static readonly Guid GuidForExerciseId29 = Guid.Parse("765b06a2-50d6-4c56-8845-143e7ee7c733");
    public static readonly ExerciseId ExerciseId29 = ExerciseId.Create(GuidForExerciseId29);

    public static readonly Guid GuidForExerciseId30 = Guid.Parse("8f56c4de-e4bf-4354-8279-ea3f6aca18dc");
    public static readonly ExerciseId ExerciseId30 = ExerciseId.Create(GuidForExerciseId30);

    #endregion

    #region Lesson 7

    public static readonly Guid GuidForExerciseId31 = Guid.Parse("11af84dc-c777-46c9-ba7e-8fc836a804f0");
    public static readonly ExerciseId ExerciseId31 = ExerciseId.Create(GuidForExerciseId31);

    public static readonly Guid GuidForExerciseId32 = Guid.Parse("36411c85-2a47-415c-a396-ea52bcadd3e9");
    public static readonly ExerciseId ExerciseId32 = ExerciseId.Create(GuidForExerciseId32);

    public static readonly Guid GuidForExerciseId33 = Guid.Parse("7ac50144-ad5f-4702-9d87-ea996e8904aa");
    public static readonly ExerciseId ExerciseId33 = ExerciseId.Create(GuidForExerciseId33);

    public static readonly Guid GuidForExerciseId34 = Guid.Parse("8650e3d8-d11f-461c-9f8a-b00e6379c348");
    public static readonly ExerciseId ExerciseId34 = ExerciseId.Create(GuidForExerciseId34);

    public static readonly Guid GuidForExerciseId35 = Guid.Parse("077d1b35-28e8-411f-956a-4ac8883d27b8");
    public static readonly ExerciseId ExerciseId35 = ExerciseId.Create(GuidForExerciseId35);

    #endregion

    #region Lesson 8

    public static readonly Guid GuidForExerciseId36 = Guid.Parse("6d0cc462-65e5-48a1-beb0-b7cdb1f04045");
    public static readonly ExerciseId ExerciseId36 = ExerciseId.Create(GuidForExerciseId36);

    public static readonly Guid GuidForExerciseId37 = Guid.Parse("0919cab8-a02f-4da7-9b47-1a58351ea9c3");
    public static readonly ExerciseId ExerciseId37 = ExerciseId.Create(GuidForExerciseId37);

    public static readonly Guid GuidForExerciseId38 = Guid.Parse("46eac2d6-1f33-4c2a-b420-e914de870deb");
    public static readonly ExerciseId ExerciseId38 = ExerciseId.Create(GuidForExerciseId38);

    public static readonly Guid GuidForExerciseId39 = Guid.Parse("e89a87ca-93c7-489c-85e6-200a1192d751");
    public static readonly ExerciseId ExerciseId39 = ExerciseId.Create(GuidForExerciseId39);

    public static readonly Guid GuidForExerciseId40 = Guid.Parse("74886f2d-4d3b-40fe-b96a-7524e9fe5b09");
    public static readonly ExerciseId ExerciseId40 = ExerciseId.Create(GuidForExerciseId40);

    #endregion

    #region Lesson 9

    public static readonly Guid GuidForExerciseId41 = Guid.Parse("38df6419-b7c7-4f23-ae70-6ddadf05db9f");
    public static readonly ExerciseId ExerciseId41 = ExerciseId.Create(GuidForExerciseId41);

    public static readonly Guid GuidForExerciseId42 = Guid.Parse("49c84e13-c9a2-4665-b563-7c1f686c8b8d");
    public static readonly ExerciseId ExerciseId42 = ExerciseId.Create(GuidForExerciseId42);

    public static readonly Guid GuidForExerciseId43 = Guid.Parse("2958e0a7-9ebc-463a-9f87-5a98ab680449");
    public static readonly ExerciseId ExerciseId43 = ExerciseId.Create(GuidForExerciseId43);

    public static readonly Guid GuidForExerciseId44 = Guid.Parse("e2ec419b-08c9-4295-86e1-e8846488b20c");
    public static readonly ExerciseId ExerciseId44 = ExerciseId.Create(GuidForExerciseId44);

    public static readonly Guid GuidForExerciseId45 = Guid.Parse("dc63683b-d306-4203-9cce-452d0f828491");
    public static readonly ExerciseId ExerciseId45 = ExerciseId.Create(GuidForExerciseId45);

    #endregion

    #region Lesson 10

    public static readonly Guid GuidForExerciseId46 = Guid.Parse("23c9e459-845c-4a74-96fa-5eda6187cb1f");
    public static readonly ExerciseId ExerciseId46 = ExerciseId.Create(GuidForExerciseId46);

    public static readonly Guid GuidForExerciseId47 = Guid.Parse("9e891766-82ec-441e-affe-b3138b7a04db");
    public static readonly ExerciseId ExerciseId47 = ExerciseId.Create(GuidForExerciseId47);

    public static readonly Guid GuidForExerciseId48 = Guid.Parse("928acaf1-743e-4c3e-bdfa-e24d0e6ff485");
    public static readonly ExerciseId ExerciseId48 = ExerciseId.Create(GuidForExerciseId48);

    public static readonly Guid GuidForExerciseId49 = Guid.Parse("4afa32ae-daa4-45ed-92ea-f910b90116c1");
    public static readonly ExerciseId ExerciseId49 = ExerciseId.Create(GuidForExerciseId49);

    public static readonly Guid GuidForExerciseId50 = Guid.Parse("c5406625-55a2-488f-9050-a5ab649cd3ce");
    public static readonly ExerciseId ExerciseId50 = ExerciseId.Create(GuidForExerciseId50);

    #endregion

    #region Lesson 11

    public static readonly Guid GuidForExerciseId51 = Guid.Parse("67f7b904-927c-471f-8dfe-73f54adb9e03");
    public static readonly ExerciseId ExerciseId51 = ExerciseId.Create(GuidForExerciseId51);

    public static readonly Guid GuidForExerciseId52 = Guid.Parse("9d53c467-f7e8-4433-971c-5e7cb7ce6a71");
    public static readonly ExerciseId ExerciseId52 = ExerciseId.Create(GuidForExerciseId52);

    public static readonly Guid GuidForExerciseId53 = Guid.Parse("c6453de7-f75d-49bf-ac53-4944dac3b288");
    public static readonly ExerciseId ExerciseId53 = ExerciseId.Create(GuidForExerciseId53);

    public static readonly Guid GuidForExerciseId54 = Guid.Parse("df7940f8-70aa-4e17-9df0-2bb4a46d6d7d");
    public static readonly ExerciseId ExerciseId54 = ExerciseId.Create(GuidForExerciseId54);

    public static readonly Guid GuidForExerciseId55 = Guid.Parse("61a06c06-8603-4dd3-8fe5-92f3364e3814");
    public static readonly ExerciseId ExerciseId55 = ExerciseId.Create(GuidForExerciseId55);

    #endregion

    #region Lesson 12

    public static readonly Guid GuidForExerciseId56 = Guid.Parse("5c96d301-355b-445f-a153-07ef89786909");
    public static readonly ExerciseId ExerciseId56 = ExerciseId.Create(GuidForExerciseId56);

    public static readonly Guid GuidForExerciseId57 = Guid.Parse("ffd37b6b-c0c9-4f04-a7c1-f6dffb9eec21");
    public static readonly ExerciseId ExerciseId57 = ExerciseId.Create(GuidForExerciseId57);

    public static readonly Guid GuidForExerciseId58 = Guid.Parse("84b9001f-564e-42c5-a864-eefa2f289f3b");
    public static readonly ExerciseId ExerciseId58 = ExerciseId.Create(GuidForExerciseId58);

    public static readonly Guid GuidForExerciseId59 = Guid.Parse("00242767-9606-4d08-b96b-7a1498a6d0c9");
    public static readonly ExerciseId ExerciseId59 = ExerciseId.Create(GuidForExerciseId59);

    public static readonly Guid GuidForExerciseId60 = Guid.Parse("8de0af24-b98a-4f94-8974-aa3c51220f09");
    public static readonly ExerciseId ExerciseId60 = ExerciseId.Create(GuidForExerciseId60);

    #endregion

    #region Lesson 13

    public static readonly Guid GuidForExerciseId61 = Guid.Parse("111b3155-8751-456a-8a77-f1c26ced8f18");
    public static readonly ExerciseId ExerciseId61 = ExerciseId.Create(GuidForExerciseId61);

    public static readonly Guid GuidForExerciseId62 = Guid.Parse("2c900207-3d73-4b27-a482-f16ce64b7729");
    public static readonly ExerciseId ExerciseId62 = ExerciseId.Create(GuidForExerciseId62);

    public static readonly Guid GuidForExerciseId63 = Guid.Parse("eaacd632-357b-4473-8bc4-e64338f16811");
    public static readonly ExerciseId ExerciseId63 = ExerciseId.Create(GuidForExerciseId63);

    public static readonly Guid GuidForExerciseId64 = Guid.Parse("3953a15c-4d98-4b8d-b5a0-a2bbe4449fe9");
    public static readonly ExerciseId ExerciseId64 = ExerciseId.Create(GuidForExerciseId64);

    public static readonly Guid GuidForExerciseId65 = Guid.Parse("fd21cd86-2fdd-49a9-8447-0159f7756337");
    public static readonly ExerciseId ExerciseId65 = ExerciseId.Create(GuidForExerciseId65);

    #endregion

    #region Lesson 14

    public static readonly Guid GuidForExerciseId66 = Guid.Parse("817ce59c-2207-420c-9dd7-db822ab79b4b");
    public static readonly ExerciseId ExerciseId66 = ExerciseId.Create(GuidForExerciseId66);

    public static readonly Guid GuidForExerciseId67 = Guid.Parse("21983f75-6289-4334-9372-c88a81690e96");
    public static readonly ExerciseId ExerciseId67 = ExerciseId.Create(GuidForExerciseId67);

    public static readonly Guid GuidForExerciseId68 = Guid.Parse("d2a4e39d-1b0d-4584-bfd2-aa0cfbb070d6");
    public static readonly ExerciseId ExerciseId68 = ExerciseId.Create(GuidForExerciseId68);

    public static readonly Guid GuidForExerciseId69 = Guid.Parse("bc4032b5-0b91-47da-8e6f-db283a515989");
    public static readonly ExerciseId ExerciseId69 = ExerciseId.Create(GuidForExerciseId69);

    public static readonly Guid GuidForExerciseId70 = Guid.Parse("2050e871-9095-4f46-8787-8f717f114ea2");
    public static readonly ExerciseId ExerciseId70 = ExerciseId.Create(GuidForExerciseId70);

    #endregion

    #region Lesson 15

    public static readonly Guid GuidForExerciseId71 = Guid.Parse("1d31d367-6651-40f8-a82d-b6f033debac9");
    public static readonly ExerciseId ExerciseId71 = ExerciseId.Create(GuidForExerciseId71);

    public static readonly Guid GuidForExerciseId72 = Guid.Parse("6e183839-2a73-44bf-b4e2-b3ab25613a5a");
    public static readonly ExerciseId ExerciseId72 = ExerciseId.Create(GuidForExerciseId72);

    public static readonly Guid GuidForExerciseId73 = Guid.Parse("d54d614b-f911-4fd8-9932-eead5f63eb74");
    public static readonly ExerciseId ExerciseId73 = ExerciseId.Create(GuidForExerciseId73);

    public static readonly Guid GuidForExerciseId74 = Guid.Parse("e7ac161c-561a-4ffe-81f7-b57b37b19e52");
    public static readonly ExerciseId ExerciseId74 = ExerciseId.Create(GuidForExerciseId74);

    public static readonly Guid GuidForExerciseId75 = Guid.Parse("43d627bb-e3ed-4a8d-81b9-8e0212a3a8a0");
    public static readonly ExerciseId ExerciseId75 = ExerciseId.Create(GuidForExerciseId75);

    #endregion

    #region Lesson 16

    public static readonly Guid GuidForExerciseId76 = Guid.Parse("47294d03-3395-42a6-83d8-389d19aec14d");
    public static readonly ExerciseId ExerciseId76 = ExerciseId.Create(GuidForExerciseId76);

    public static readonly Guid GuidForExerciseId77 = Guid.Parse("bfca2c81-719c-4189-8e2d-027163421517");
    public static readonly ExerciseId ExerciseId77 = ExerciseId.Create(GuidForExerciseId77);

    public static readonly Guid GuidForExerciseId78 = Guid.Parse("2233f2a0-b9c6-4072-8ace-ea274ebf6cf4");
    public static readonly ExerciseId ExerciseId78 = ExerciseId.Create(GuidForExerciseId78);

    public static readonly Guid GuidForExerciseId79 = Guid.Parse("08681ed3-8ab0-4a1d-967a-2c2806b3a099");
    public static readonly ExerciseId ExerciseId79 = ExerciseId.Create(GuidForExerciseId79);

    public static readonly Guid GuidForExerciseId80 = Guid.Parse("b8a0d599-6575-4626-b2af-317f9e78efa4");
    public static readonly ExerciseId ExerciseId80 = ExerciseId.Create(GuidForExerciseId80);

    #endregion

    #region Lesson 17

    public static readonly Guid GuidForExerciseId81 = Guid.Parse("dbdc7990-cb51-4e30-96cd-17e3fa20dafa");
    public static readonly ExerciseId ExerciseId81 = ExerciseId.Create(GuidForExerciseId81);

    public static readonly Guid GuidForExerciseId82 = Guid.Parse("c4f3b91f-1c7b-44a2-b32e-32ef0b1f0b11");
    public static readonly ExerciseId ExerciseId82 = ExerciseId.Create(GuidForExerciseId82);

    public static readonly Guid GuidForExerciseId83 = Guid.Parse("d57af893-3fcf-463f-8722-03583c052ffc");
    public static readonly ExerciseId ExerciseId83 = ExerciseId.Create(GuidForExerciseId83);

    public static readonly Guid GuidForExerciseId84 = Guid.Parse("4bfb0f3d-91d4-42c6-ad20-dd66a700d43c");
    public static readonly ExerciseId ExerciseId84 = ExerciseId.Create(GuidForExerciseId84);

    public static readonly Guid GuidForExerciseId85 = Guid.Parse("6b9c1472-a03e-4854-bec8-cfc8bfb8e06c");
    public static readonly ExerciseId ExerciseId85 = ExerciseId.Create(GuidForExerciseId85);

    #endregion

    #region Lesson 18

    public static readonly Guid GuidForExerciseId86 = Guid.Parse("7c07747b-ded1-4c2e-9a36-17f95fc059f7");
    public static readonly ExerciseId ExerciseId86 = ExerciseId.Create(GuidForExerciseId86);

    public static readonly Guid GuidForExerciseId87 = Guid.Parse("33864b46-810c-4fad-aee0-05e42b413e6a");
    public static readonly ExerciseId ExerciseId87 = ExerciseId.Create(GuidForExerciseId87);

    public static readonly Guid GuidForExerciseId88 = Guid.Parse("768101f9-4a4b-43cd-aa34-faf712bfc940");
    public static readonly ExerciseId ExerciseId88 = ExerciseId.Create(GuidForExerciseId88);

    public static readonly Guid GuidForExerciseId89 = Guid.Parse("47124eb6-a2d1-4b91-9e5d-5a85169625c8");
    public static readonly ExerciseId ExerciseId89 = ExerciseId.Create(GuidForExerciseId89);

    public static readonly Guid GuidForExerciseId90 = Guid.Parse("aee272ba-c84e-4fe4-a8ea-49386db26adb");
    public static readonly ExerciseId ExerciseId90 = ExerciseId.Create(GuidForExerciseId90);

    #endregion

    #region Lesson 19

    public static readonly Guid GuidForExerciseId91 = Guid.Parse("f1bb33c6-6457-442a-a937-24ec243a7dcc");
    public static readonly ExerciseId ExerciseId91 = ExerciseId.Create(GuidForExerciseId91);

    public static readonly Guid GuidForExerciseId92 = Guid.Parse("d1b02f04-0cd3-44e8-9f49-453b3c68b286");
    public static readonly ExerciseId ExerciseId92 = ExerciseId.Create(GuidForExerciseId92);

    public static readonly Guid GuidForExerciseId93 = Guid.Parse("70ad6e5a-8f06-4463-af4c-1338eb9ee9c7");
    public static readonly ExerciseId ExerciseId93 = ExerciseId.Create(GuidForExerciseId93);

    public static readonly Guid GuidForExerciseId94 = Guid.Parse("fba08a09-5612-4e29-a69e-6dd670e09007");
    public static readonly ExerciseId ExerciseId94 = ExerciseId.Create(GuidForExerciseId94);

    public static readonly Guid GuidForExerciseId95 = Guid.Parse("04512419-5612-46c0-a804-51eab5dbe465");
    public static readonly ExerciseId ExerciseId95 = ExerciseId.Create(GuidForExerciseId95);

    #endregion

    #region Lesson 20

    public static readonly Guid GuidForExerciseId96 = Guid.Parse("01257b25-0f71-4d69-8dfd-05090ad780cc");
    public static readonly ExerciseId ExerciseId96 = ExerciseId.Create(GuidForExerciseId96);

    public static readonly Guid GuidForExerciseId97 = Guid.Parse("15c3b21e-974c-4b2a-a366-081c042076fe");
    public static readonly ExerciseId ExerciseId97 = ExerciseId.Create(GuidForExerciseId97);

    public static readonly Guid GuidForExerciseId98 = Guid.Parse("f562eb05-e5eb-4aa3-a0e7-475643e0098e");
    public static readonly ExerciseId ExerciseId98 = ExerciseId.Create(GuidForExerciseId98);

    public static readonly Guid GuidForExerciseId99 = Guid.Parse("64728c0a-630e-49a2-b929-943eede1a19f");
    public static readonly ExerciseId ExerciseId99 = ExerciseId.Create(GuidForExerciseId99);

    public static readonly Guid GuidForExerciseId100 = Guid.Parse("e634310c-c6f4-40fa-9e79-f010be5b2d01");
    public static readonly ExerciseId ExerciseId100 = ExerciseId.Create(GuidForExerciseId100);

    #endregion

    #region Lesson 21

    public static readonly Guid GuidForExerciseId101 = Guid.Parse("25db1596-587d-4e70-8aa5-a632820305f5");
    public static readonly ExerciseId ExerciseId101 = ExerciseId.Create(GuidForExerciseId101);

    public static readonly Guid GuidForExerciseId102 = Guid.Parse("7402f1ec-b698-47d4-8d59-23cb2799d3de");
    public static readonly ExerciseId ExerciseId102 = ExerciseId.Create(GuidForExerciseId102);

    public static readonly Guid GuidForExerciseId103 = Guid.Parse("c43591f9-31a4-4fb3-96ba-98be24894590");
    public static readonly ExerciseId ExerciseId103 = ExerciseId.Create(GuidForExerciseId103);

    public static readonly Guid GuidForExerciseId104 = Guid.Parse("f95e222d-5d5d-4cca-bfb9-5ec6e46691b8");
    public static readonly ExerciseId ExerciseId104 = ExerciseId.Create(GuidForExerciseId104);

    public static readonly Guid GuidForExerciseId105 = Guid.Parse("b96741a5-2c09-4ad9-b19e-55d16b8a27db");
    public static readonly ExerciseId ExerciseId105 = ExerciseId.Create(GuidForExerciseId105);

    #endregion

    #region Lesson 22

    public static readonly Guid GuidForExerciseId106 = Guid.Parse("803d8512-4613-49d8-b27f-dbd9c7ccafdf");
    public static readonly ExerciseId ExerciseId106 = ExerciseId.Create(GuidForExerciseId106);

    public static readonly Guid GuidForExerciseId107 = Guid.Parse("07dbad0c-ce70-4c48-bf85-65b15efe6506");
    public static readonly ExerciseId ExerciseId107 = ExerciseId.Create(GuidForExerciseId107);

    public static readonly Guid GuidForExerciseId108 = Guid.Parse("a414365c-4e85-475b-96b8-b97854e0ecb1");
    public static readonly ExerciseId ExerciseId108 = ExerciseId.Create(GuidForExerciseId108);

    public static readonly Guid GuidForExerciseId109 = Guid.Parse("74bd1a5c-c068-436b-be42-de5b69294a3a");
    public static readonly ExerciseId ExerciseId109 = ExerciseId.Create(GuidForExerciseId109);

    public static readonly Guid GuidForExerciseId110 = Guid.Parse("b2972cad-61ba-405a-bf08-fe89c1ad4299");
    public static readonly ExerciseId ExerciseId110 = ExerciseId.Create(GuidForExerciseId110);

    #endregion

    #region Lesson 23

    public static readonly Guid GuidForExerciseId111 = Guid.Parse("f5e123f1-207a-4228-8c55-bcfb0c52cfca");
    public static readonly ExerciseId ExerciseId111 = ExerciseId.Create(GuidForExerciseId111);

    public static readonly Guid GuidForExerciseId112 = Guid.Parse("90bf605c-1c9a-41cf-b6c8-2ec9f415c72b");
    public static readonly ExerciseId ExerciseId112 = ExerciseId.Create(GuidForExerciseId112);

    public static readonly Guid GuidForExerciseId113 = Guid.Parse("4fa64e02-e813-479a-84cb-01420659e688");
    public static readonly ExerciseId ExerciseId113 = ExerciseId.Create(GuidForExerciseId113);

    public static readonly Guid GuidForExerciseId114 = Guid.Parse("3a398c7f-5c08-4737-8d2f-657d2bbcb33a");
    public static readonly ExerciseId ExerciseId114 = ExerciseId.Create(GuidForExerciseId114);

    public static readonly Guid GuidForExerciseId115 = Guid.Parse("11980c86-9b2a-4591-9a62-5ba71df01cac");
    public static readonly ExerciseId ExerciseId115 = ExerciseId.Create(GuidForExerciseId115);

    #endregion

    #region Lesson 24

    public static readonly Guid GuidForExerciseId116 = Guid.Parse("e4c3a5b2-277b-47ac-85ab-a74be22dbfa8");
    public static readonly ExerciseId ExerciseId116 = ExerciseId.Create(GuidForExerciseId116);

    public static readonly Guid GuidForExerciseId117 = Guid.Parse("2196d9d5-72a0-4eab-9cb4-8daad8fb79b1");
    public static readonly ExerciseId ExerciseId117 = ExerciseId.Create(GuidForExerciseId117);

    public static readonly Guid GuidForExerciseId118 = Guid.Parse("7c4a664e-4f32-45fd-8ec1-8a9b10ae0c0a");
    public static readonly ExerciseId ExerciseId118 = ExerciseId.Create(GuidForExerciseId118);

    public static readonly Guid GuidForExerciseId119 = Guid.Parse("30dbc5f4-9e76-4673-bed6-593d154ba6e2");
    public static readonly ExerciseId ExerciseId119 = ExerciseId.Create(GuidForExerciseId119);

    public static readonly Guid GuidForExerciseId120 = Guid.Parse("b590a52f-6002-45ff-af5d-80e65167f2b2");
    public static readonly ExerciseId ExerciseId120 = ExerciseId.Create(GuidForExerciseId120);

    #endregion

    #region Lesson 25

    public static readonly Guid GuidForExerciseId121 = Guid.Parse("81f6577a-ebce-4b30-be76-d20eacba0acd");
    public static readonly ExerciseId ExerciseId121 = ExerciseId.Create(GuidForExerciseId121);

    public static readonly Guid GuidForExerciseId122 = Guid.Parse("b303e394-cc78-415f-b3d8-ad79ec0817e4");
    public static readonly ExerciseId ExerciseId122 = ExerciseId.Create(GuidForExerciseId122);

    public static readonly Guid GuidForExerciseId123 = Guid.Parse("e4eb5043-e1b9-4060-b15d-71913eb267d6");
    public static readonly ExerciseId ExerciseId123 = ExerciseId.Create(GuidForExerciseId123);

    public static readonly Guid GuidForExerciseId124 = Guid.Parse("87e89338-39fb-4d26-b866-e9dbb7bc74bf");
    public static readonly ExerciseId ExerciseId124 = ExerciseId.Create(GuidForExerciseId124);

    public static readonly Guid GuidForExerciseId125 = Guid.Parse("81b35b80-3e72-4577-9e84-59d995dd7d22");
    public static readonly ExerciseId ExerciseId125 = ExerciseId.Create(GuidForExerciseId125);

    #endregion

    #region Lesson 26

    public static readonly Guid GuidForExerciseId126 = Guid.Parse("5bc31dd7-2fef-4e92-b169-1191562d80b7");
    public static readonly ExerciseId ExerciseId126 = ExerciseId.Create(GuidForExerciseId126);

    public static readonly Guid GuidForExerciseId127 = Guid.Parse("f946095e-1f69-48e2-b289-a818b5776242");
    public static readonly ExerciseId ExerciseId127 = ExerciseId.Create(GuidForExerciseId127);

    public static readonly Guid GuidForExerciseId128 = Guid.Parse("ae29c207-5f54-4148-9303-eb27058fe19a");
    public static readonly ExerciseId ExerciseId128 = ExerciseId.Create(GuidForExerciseId128);

    public static readonly Guid GuidForExerciseId129 = Guid.Parse("6d30f362-a2a8-4d1e-9488-c12fbb850bad");
    public static readonly ExerciseId ExerciseId129 = ExerciseId.Create(GuidForExerciseId129);

    public static readonly Guid GuidForExerciseId130 = Guid.Parse("d39eb9f3-82a8-405c-9648-9af628fac4e8");
    public static readonly ExerciseId ExerciseId130 = ExerciseId.Create(GuidForExerciseId130);

    #endregion

    #region Lesson 27

    public static readonly Guid GuidForExerciseId131 = Guid.Parse("81da5d60-eb0e-457e-8283-3023153a2fe3");
    public static readonly ExerciseId ExerciseId131 = ExerciseId.Create(GuidForExerciseId131);

    public static readonly Guid GuidForExerciseId132 = Guid.Parse("2382d676-536f-4047-980a-1a666b1647ae");
    public static readonly ExerciseId ExerciseId132 = ExerciseId.Create(GuidForExerciseId132);

    public static readonly Guid GuidForExerciseId133 = Guid.Parse("e7ea33c2-c539-4547-89d4-659e8d40ce69");
    public static readonly ExerciseId ExerciseId133 = ExerciseId.Create(GuidForExerciseId133);

    public static readonly Guid GuidForExerciseId134 = Guid.Parse("97f6a94c-7043-44f3-a9ff-e16ce67a8e2b");
    public static readonly ExerciseId ExerciseId134 = ExerciseId.Create(GuidForExerciseId134);

    public static readonly Guid GuidForExerciseId135 = Guid.Parse("00d6da68-208e-4c43-9b3d-480b1e40f6d9");
    public static readonly ExerciseId ExerciseId135 = ExerciseId.Create(GuidForExerciseId135);

    #endregion

    #region Lesson 28

    public static readonly Guid GuidForExerciseId136 = Guid.Parse("a4f233d5-6b80-4f78-8138-c7cd9c9afe61");
    public static readonly ExerciseId ExerciseId136 = ExerciseId.Create(GuidForExerciseId136);

    public static readonly Guid GuidForExerciseId137 = Guid.Parse("b99c1112-f602-4ae1-8306-25a883c86d45");
    public static readonly ExerciseId ExerciseId137 = ExerciseId.Create(GuidForExerciseId137);

    public static readonly Guid GuidForExerciseId138 = Guid.Parse("87a6cc3a-e01f-4f37-8c28-27e0d24b8d31");
    public static readonly ExerciseId ExerciseId138 = ExerciseId.Create(GuidForExerciseId138);

    public static readonly Guid GuidForExerciseId139 = Guid.Parse("a6109397-6055-48e8-803d-0f23275be39d");
    public static readonly ExerciseId ExerciseId139 = ExerciseId.Create(GuidForExerciseId139);

    public static readonly Guid GuidForExerciseId140 = Guid.Parse("33e5cfd4-d696-4861-a396-59c72b1133f4");
    public static readonly ExerciseId ExerciseId140 = ExerciseId.Create(GuidForExerciseId140);

    #endregion

    #region Lesson 29

    public static readonly Guid GuidForExerciseId141 = Guid.Parse("74fd8c58-8910-43ec-bd17-ccbed652c4f0");
    public static readonly ExerciseId ExerciseId141 = ExerciseId.Create(GuidForExerciseId141);

    public static readonly Guid GuidForExerciseId142 = Guid.Parse("b1d1d05c-9bc1-4cb5-8e0b-ca12d7c7a4e4");
    public static readonly ExerciseId ExerciseId142 = ExerciseId.Create(GuidForExerciseId142);

    public static readonly Guid GuidForExerciseId143 = Guid.Parse("a07b1d30-81c7-4de2-9412-dcf4f0204e3b");
    public static readonly ExerciseId ExerciseId143 = ExerciseId.Create(GuidForExerciseId143);

    public static readonly Guid GuidForExerciseId144 = Guid.Parse("764fc7bc-e1d4-4a31-aeee-b8667e68389d");
    public static readonly ExerciseId ExerciseId144 = ExerciseId.Create(GuidForExerciseId144);

    public static readonly Guid GuidForExerciseId145 = Guid.Parse("ba2662a2-ec2e-4f0e-96bb-11e4e0f6e514");
    public static readonly ExerciseId ExerciseId145 = ExerciseId.Create(GuidForExerciseId145);

    #endregion

    #region Lesson 30

    public static readonly Guid GuidForExerciseId146 = Guid.Parse("9325d238-1000-4e8c-ab2b-f563ac0cbeb0");
    public static readonly ExerciseId ExerciseId146 = ExerciseId.Create(GuidForExerciseId146);

    public static readonly Guid GuidForExerciseId147 = Guid.Parse("0bbdff59-a524-4354-b723-65cb3bea295d");
    public static readonly ExerciseId ExerciseId147 = ExerciseId.Create(GuidForExerciseId147);

    public static readonly Guid GuidForExerciseId148 = Guid.Parse("12c9ca99-9484-4dc4-b174-b00c490c1558");
    public static readonly ExerciseId ExerciseId148 = ExerciseId.Create(GuidForExerciseId148);

    public static readonly Guid GuidForExerciseId149 = Guid.Parse("3de2b59c-b670-4a19-9836-8662a4e84eb2");
    public static readonly ExerciseId ExerciseId149 = ExerciseId.Create(GuidForExerciseId149);

    public static readonly Guid GuidForExerciseId150 = Guid.Parse("d8d7789b-c75c-4bf0-88a0-f11bcabdd566");
    public static readonly ExerciseId ExerciseId150 = ExerciseId.Create(GuidForExerciseId150);

    #endregion

    #region Lesson 31

    public static readonly Guid GuidForExerciseId151 = Guid.Parse("fc9acc6f-8713-4ca3-87a4-311b02ca6f54");
    public static readonly ExerciseId ExerciseId151 = ExerciseId.Create(GuidForExerciseId151);

    public static readonly Guid GuidForExerciseId152 = Guid.Parse("93220cba-cab5-4431-8514-93c4c834af07");
    public static readonly ExerciseId ExerciseId152 = ExerciseId.Create(GuidForExerciseId152);

    public static readonly Guid GuidForExerciseId153 = Guid.Parse("7ec29333-ba4e-4638-920f-f90bd4fbcba6");
    public static readonly ExerciseId ExerciseId153 = ExerciseId.Create(GuidForExerciseId153);

    public static readonly Guid GuidForExerciseId154 = Guid.Parse("5d5aa0b7-ee86-4886-8167-0b4878f58d6d");
    public static readonly ExerciseId ExerciseId154 = ExerciseId.Create(GuidForExerciseId154);

    public static readonly Guid GuidForExerciseId155 = Guid.Parse("a9b68062-a9e9-4a71-b6e7-014ee35c3e4b");
    public static readonly ExerciseId ExerciseId155 = ExerciseId.Create(GuidForExerciseId155);

    #endregion

    public static IReadOnlyList<Exercise> GetExercisesForLessons()
    {
        return
        [
            #region Lesson 1

            Exercise.Create(ExerciseId1, LessonSeed.LessonId1, RusPhrase.Create("Ты не увидишь.").Value).Value,
            Exercise.Create(ExerciseId2, LessonSeed.LessonId1, RusPhrase.Create("Мы покажем?").Value).Value,
            Exercise.Create(ExerciseId3, LessonSeed.LessonId1, RusPhrase.Create("Она работала.").Value).Value,
            Exercise.Create(ExerciseId4, LessonSeed.LessonId1, RusPhrase.Create("Ты не думал.").Value).Value,
            Exercise.Create(ExerciseId5, LessonSeed.LessonId1, RusPhrase.Create("Я посмотрю?").Value).Value,

            #endregion

            #region Lesson 2

            Exercise.Create(ExerciseId6, LessonSeed.LessonId2, RusPhrase.Create("Мы не оставили его.").Value).Value,
            Exercise.Create(ExerciseId7, LessonSeed.LessonId2, RusPhrase.Create("Он поймёт тебя.").Value).Value,
            Exercise.Create(ExerciseId8, LessonSeed.LessonId2, RusPhrase.Create("Ты открываешь ей.").Value).Value,
            Exercise.Create(ExerciseId9, LessonSeed.LessonId2, RusPhrase.Create("Я сломаю?").Value).Value,
            Exercise.Create(ExerciseId10, LessonSeed.LessonId2, RusPhrase.Create("Я показал им?").Value).Value,

            #endregion

            #region Lesson 3

            Exercise.Create(ExerciseId11, LessonSeed.LessonId3, RusPhrase.Create("Тебе хочется пить?").Value).Value,
            Exercise.Create(ExerciseId12, LessonSeed.LessonId3, RusPhrase.Create("Ей хотелось забывать?").Value).Value,
            Exercise.Create(ExerciseId13, LessonSeed.LessonId3, RusPhrase.Create("Я был в музее.").Value).Value,
            Exercise.Create(ExerciseId14, LessonSeed.LessonId3, RusPhrase.Create("Ей не нравилось показывать.").Value).Value,
            Exercise.Create(ExerciseId15, LessonSeed.LessonId3, RusPhrase.Create("Она в лифте?").Value).Value,

            #endregion

            #region Lesson 4

            Exercise.Create(ExerciseId16, LessonSeed.LessonId4, RusPhrase.Create("Он будет их актёром?").Value).Value,
            Exercise.Create(ExerciseId17, LessonSeed.LessonId4, RusPhrase.Create("Мы не их бухгалтеры.").Value).Value,
            Exercise.Create(ExerciseId18, LessonSeed.LessonId4, RusPhrase.Create("Мы были его историками.").Value).Value,
            Exercise.Create(ExerciseId19, LessonSeed.LessonId4, RusPhrase.Create("Он будет её писателем.").Value).Value,
            Exercise.Create(ExerciseId20, LessonSeed.LessonId4, RusPhrase.Create("Мы не будем их гидами.").Value).Value,

            #endregion

            #region Lesson 5

            Exercise.Create(ExerciseId21, LessonSeed.LessonId5, RusPhrase.Create("Они учатся на гидов?").Value).Value,
            Exercise.Create(ExerciseId22, LessonSeed.LessonId5, RusPhrase.Create("Я не буду менеджером.").Value).Value,
            Exercise.Create(ExerciseId23, LessonSeed.LessonId5, RusPhrase.Create("Мы учились на менеджеров.").Value).Value,
            Exercise.Create(ExerciseId24, LessonSeed.LessonId5, RusPhrase.Create("Они работали в компании дизайнерами?").Value).Value,
            Exercise.Create(ExerciseId25, LessonSeed.LessonId5, RusPhrase.Create("Ты историк.").Value).Value,

            #endregion

            #region Lesson 6

            Exercise.Create(ExerciseId26, LessonSeed.LessonId6, RusPhrase.Create("Эта ручка не больше той.").Value).Value,
            Exercise.Create(ExerciseId27, LessonSeed.LessonId6, RusPhrase.Create("Этот телевизор не дорогой.").Value).Value,
            Exercise.Create(ExerciseId28, LessonSeed.LessonId6, RusPhrase.Create("Этот телефон дешевле того?").Value).Value,
            Exercise.Create(ExerciseId29, LessonSeed.LessonId6, RusPhrase.Create("Эта ручка длиннее той.").Value).Value,
            Exercise.Create(ExerciseId30, LessonSeed.LessonId6, RusPhrase.Create("Эти апельсины самые маленькие?").Value).Value,

            #endregion

            #region Lesson 7

            Exercise.Create(ExerciseId31, LessonSeed.LessonId7, RusPhrase.Create("Мы будем читать кому-нибудь.").Value).Value,
            Exercise.Create(ExerciseId32, LessonSeed.LessonId7, RusPhrase.Create("Они чувствуют везде?").Value).Value,
            Exercise.Create(ExerciseId33, LessonSeed.LessonId7, RusPhrase.Create("Ты встречаешь везде?").Value).Value,
            Exercise.Create(ExerciseId34, LessonSeed.LessonId7, RusPhrase.Create("Он будет знать всех?").Value).Value,
            Exercise.Create(ExerciseId35, LessonSeed.LessonId7, RusPhrase.Create("Он никогда не видит.").Value).Value,

            #endregion

            #region Lesson 8

            Exercise.Create(ExerciseId36, LessonSeed.LessonId8, RusPhrase.Create("Она не повернула нас 6 месяцев назад.").Value).Value,
            Exercise.Create(ExerciseId37, LessonSeed.LessonId8, RusPhrase.Create("Он будет расти через 2 месяца?").Value).Value,
            Exercise.Create(ExerciseId38, LessonSeed.LessonId8, RusPhrase.Create("Я расскажу тебе через 6 месяцев.").Value).Value,
            Exercise.Create(ExerciseId39, LessonSeed.LessonId8, RusPhrase.Create("Ты будешь там через 6 месяцев?").Value).Value,
            Exercise.Create(ExerciseId40, LessonSeed.LessonId8, RusPhrase.Create("Она любила их в выходные?").Value).Value,
            Exercise.Create(ExerciseId41, LessonSeed.LessonId8, RusPhrase.Create("Она была там вечером.").Value).Value,

            #endregion

            #region Lesson 9

            Exercise.Create(ExerciseId42, LessonSeed.LessonId9, RusPhrase.Create("На полу не было ручек.").Value).Value,
            Exercise.Create(ExerciseId43, LessonSeed.LessonId9, RusPhrase.Create("Под столом есть ножи.").Value).Value,
            Exercise.Create(ExerciseId44, LessonSeed.LessonId9, RusPhrase.Create("Под креслом будет мяч.").Value).Value,
            Exercise.Create(ExerciseId45, LessonSeed.LessonId9, RusPhrase.Create("На столе нет ручки.").Value).Value,
            Exercise.Create(ExerciseId46, LessonSeed.LessonId9, RusPhrase.Create("Под креслом был стакан?").Value).Value,

            #endregion

            #region Lesson 10

            Exercise.Create(ExerciseId47, LessonSeed.LessonId10, RusPhrase.Create("Он идёт на станцию?").Value).Value,
            Exercise.Create(ExerciseId48, LessonSeed.LessonId10, RusPhrase.Create("Ты не выйдешь из сада.").Value).Value,
            Exercise.Create(ExerciseId49, LessonSeed.LessonId10, RusPhrase.Create("В комнате не будет шкафов.").Value).Value,
            Exercise.Create(ExerciseId50, LessonSeed.LessonId10, RusPhrase.Create("На подоконнике будет чашка.").Value).Value,
            Exercise.Create(ExerciseId51, LessonSeed.LessonId10, RusPhrase.Create("Под столом были стаканы?").Value).Value,

            #endregion

            #region Lesson 11

            Exercise.Create(ExerciseId52, LessonSeed.LessonId11, RusPhrase.Create("Мы не должны чувствовать.").Value).Value,
            Exercise.Create(ExerciseId53, LessonSeed.LessonId11, RusPhrase.Create("Нужно мне стоять?").Value).Value,
            Exercise.Create(ExerciseId54, LessonSeed.LessonId11, RusPhrase.Create("Мы можем закрыть.").Value).Value,
            Exercise.Create(ExerciseId55, LessonSeed.LessonId11, RusPhrase.Create("Мы не показали.").Value).Value,
            Exercise.Create(ExerciseId56, LessonSeed.LessonId11, RusPhrase.Create("Она не должна ответить.").Value).Value,

            #endregion

            #region Lesson 12

            Exercise.Create(ExerciseId57, LessonSeed.LessonId12, RusPhrase.Create("Он читал письмо с 4 до 10 вчера.").Value).Value,
            Exercise.Create(ExerciseId58, LessonSeed.LessonId12, RusPhrase.Create("Мы отвечали на письмо в 4 вчера.").Value).Value,
            Exercise.Create(ExerciseId59, LessonSeed.LessonId12, RusPhrase.Create("Ты чувствуешь себя плохо целый день сегодня.").Value).Value,
            Exercise.Create(ExerciseId60, LessonSeed.LessonId12, RusPhrase.Create("Мы изучали французский целый день вчера.").Value).Value,
            Exercise.Create(ExerciseId61, LessonSeed.LessonId12, RusPhrase.Create("Ты будешь читать книгу целый день завтра.").Value).Value,

            #endregion

            #region Lesson 13

            Exercise.Create(ExerciseId62, LessonSeed.LessonId13, RusPhrase.Create("Мне холодно?").Value).Value,
            Exercise.Create(ExerciseId63, LessonSeed.LessonId13, RusPhrase.Create("У меня не голубые глаза.").Value).Value,
            Exercise.Create(ExerciseId64, LessonSeed.LessonId13, RusPhrase.Create("Ты здоров.").Value).Value,
            Exercise.Create(ExerciseId65, LessonSeed.LessonId13, RusPhrase.Create("Вчера было жарко.").Value).Value,
            Exercise.Create(ExerciseId66, LessonSeed.LessonId13, RusPhrase.Create("Она взрослая.").Value).Value,

            #endregion

            #region Lesson 14

            Exercise.Create(ExerciseId67, LessonSeed.LessonId14, RusPhrase.Create("Беги к ней.").Value).Value,
            Exercise.Create(ExerciseId68, LessonSeed.LessonId14, RusPhrase.Create("Не поворачивай его тумбочку.").Value).Value,
            Exercise.Create(ExerciseId69, LessonSeed.LessonId14, RusPhrase.Create("Не бери мой планшет.").Value).Value,
            Exercise.Create(ExerciseId70, LessonSeed.LessonId14, RusPhrase.Create("Помни про нас.").Value).Value,
            Exercise.Create(ExerciseId71, LessonSeed.LessonId14, RusPhrase.Create("Пусть он ответит.").Value).Value,

            #endregion

            #region Lesson 15

            Exercise.Create(ExerciseId72, LessonSeed.LessonId15, RusPhrase.Create("Он сбросил вес.").Value).Value,
            Exercise.Create(ExerciseId73, LessonSeed.LessonId15, RusPhrase.Create("Твой сын просит выключить свет.").Value).Value,
            Exercise.Create(ExerciseId74, LessonSeed.LessonId15, RusPhrase.Create("Он свалился с пневмонией.").Value).Value,
            Exercise.Create(ExerciseId75, LessonSeed.LessonId15, RusPhrase.Create("Он взломал дверь.").Value).Value,
            Exercise.Create(ExerciseId76, LessonSeed.LessonId15, RusPhrase.Create("Цены никогда не падают.").Value).Value,

            #endregion

            #region Lesson 16

            Exercise.Create(ExerciseId77, LessonSeed.LessonId16, RusPhrase.Create("Он только что вышел.").Value).Value,
            Exercise.Create(ExerciseId78, LessonSeed.LessonId16, RusPhrase.Create("Думаю, что я видел вас где-то.").Value).Value,
            Exercise.Create(ExerciseId79, LessonSeed.LessonId16, RusPhrase.Create("Я выполнил работу.").Value).Value,
            Exercise.Create(ExerciseId80, LessonSeed.LessonId16, RusPhrase.Create("Я уже написал письмо своему другу.").Value).Value,
            Exercise.Create(ExerciseId81, LessonSeed.LessonId16, RusPhrase.Create("Он только что посетил этот супермаркет.").Value).Value,

            #endregion

            #region Lesson 17

            Exercise.Create(ExerciseId82, LessonSeed.LessonId17, RusPhrase.Create("Я не успел закончить проект к началу той недели.").Value).Value,
            Exercise.Create(ExerciseId83, LessonSeed.LessonId17, RusPhrase.Create("Он сделал домашнее задание до того, как его родители вернулись домой?").Value).Value,
            Exercise.Create(ExerciseId84, LessonSeed.LessonId17, RusPhrase.Create("Он уже написал письмо, когда ты вошел?").Value).Value,
            Exercise.Create(ExerciseId85, LessonSeed.LessonId17, RusPhrase.Create("Вы вернулись домой до того, как начался дождь.").Value).Value,
            Exercise.Create(ExerciseId86, LessonSeed.LessonId17, RusPhrase.Create("Когда мы приехали на станцию, поезд уже ушел.").Value).Value,

            #endregion

            #region Lesson 18

            Exercise.Create(ExerciseId87, LessonSeed.LessonId18, RusPhrase.Create("Ученики займут свои места до того, как начнется урок.").Value).Value,
            Exercise.Create(ExerciseId88, LessonSeed.LessonId18, RusPhrase.Create("Они не успеют выиграть три игры к концу месяца.").Value).Value,
            Exercise.Create(ExerciseId89, LessonSeed.LessonId18, RusPhrase.Create("Я уже окончу эту работу до того, как вы возвратитесь.").Value).Value,
            Exercise.Create(ExerciseId90, LessonSeed.LessonId18, RusPhrase.Create("Они еще не отгрузят товар, когда придет ваша телеграмма.").Value).Value,
            Exercise.Create(ExerciseId91, LessonSeed.LessonId18, RusPhrase.Create("Я не закончу писать доклад к вечеру.").Value).Value,

            #endregion
        ];
    }

    public static IReadOnlyList<Word> GetWordsForLessons()
    {
        return
        [
            #region Lesson 1

            Word.Create(WordId.Create(Guid.Parse("03e9797f-ab16-4422-bfd9-bf76ca33f436")), ExerciseId1, WordNumber.Create(1).Value, Text.Create("You").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("c02b1a8b-0138-47d6-873b-16e084831444")), ExerciseId1, WordNumber.Create(2).Value, Text.Create("will not").Value, WordType.ModalVerb),
            Word.Create(WordId.Create(Guid.Parse("1deab725-e374-4ad7-a169-45a4e77d58f5")), ExerciseId1, WordNumber.Create(3).Value, Text.Create("see.").Value, WordType.Verb),

            Word.Create(WordId.Create(Guid.Parse("16738012-8d9a-4790-810e-bbf91672cdf6")), ExerciseId2, WordNumber.Create(1).Value, Text.Create("Will").Value, WordType.ModalVerb),
            Word.Create(WordId.Create(Guid.Parse("a5915abb-95f9-425d-a054-5ee27997b634")), ExerciseId2, WordNumber.Create(2).Value, Text.Create("we").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("4da38ea9-9eb1-4463-928b-5d38bea9c17b")), ExerciseId2, WordNumber.Create(3).Value, Text.Create("show?").Value, WordType.Verb),

            Word.Create(WordId.Create(Guid.Parse("d74bcb9b-36d6-4ec0-8cf8-b1a8be9624af")), ExerciseId3, WordNumber.Create(1).Value, Text.Create("She").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("9215550e-7cfd-4e41-a946-90e09def9e39")), ExerciseId3, WordNumber.Create(2).Value, Text.Create("worked?").Value, WordType.Verb),

            Word.Create(WordId.Create(Guid.Parse("862f83cd-d378-410e-88d6-27b01a06a2dc")), ExerciseId4, WordNumber.Create(1).Value, Text.Create("You").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("e86dff93-aeb8-476b-bfe0-ded0dc21e2de")), ExerciseId4, WordNumber.Create(2).Value, Text.Create("didn't").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("ee70e409-d59e-4c23-86eb-1f2878181e1b")), ExerciseId4, WordNumber.Create(3).Value, Text.Create("think.").Value, WordType.Verb),

            Word.Create(WordId.Create(Guid.Parse("ccac4b45-c615-438b-aeb4-2ec52947e9c4")), ExerciseId5, WordNumber.Create(1).Value, Text.Create("Will").Value, WordType.ModalVerb),
            Word.Create(WordId.Create(Guid.Parse("dfd01a72-3ec6-47b1-8a40-32c3a32ad2da")), ExerciseId5, WordNumber.Create(2).Value, Text.Create("I").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("37b924c3-3886-49a1-8c0a-07a718957e92")), ExerciseId5, WordNumber.Create(3).Value, Text.Create("look?").Value, WordType.Verb),

            #endregion

            #region Lesson 2

            Word.Create(WordId.Create(Guid.Parse("dbb5722c-0428-41b5-8de8-281036a10116")), ExerciseId6, WordNumber.Create(1).Value, Text.Create("We").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("6ff589b9-3040-4f64-a428-8627bc337907")), ExerciseId6, WordNumber.Create(2).Value, Text.Create("didn't").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("09eab928-69c6-4ff3-ac10-a26d66bef69a")), ExerciseId6, WordNumber.Create(3).Value, Text.Create("leave").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("7b4a0424-5599-4ad4-9609-059205257ae7")), ExerciseId6, WordNumber.Create(4).Value, Text.Create("him.").Value, WordType.Pronoun),

            Word.Create(WordId.Create(Guid.Parse("49defb22-e6eb-4690-94e7-f801c8a8d14a")), ExerciseId7, WordNumber.Create(1).Value, Text.Create("He").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("d3362e8e-2991-4333-a43b-6872b98f4867")), ExerciseId7, WordNumber.Create(2).Value, Text.Create("will").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("e17c03b2-dcb5-4b43-ba00-c4e98b800fc9")), ExerciseId7, WordNumber.Create(3).Value, Text.Create("understand").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("0343e0cf-6886-4dff-a5f5-3465c15de0ca")), ExerciseId7, WordNumber.Create(4).Value, Text.Create("you.").Value, WordType.Pronoun),

            Word.Create(WordId.Create(Guid.Parse("da4ec215-746b-4fe6-9676-4e8070e16097")), ExerciseId8, WordNumber.Create(1).Value, Text.Create("You").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("90293e3d-2b54-41ce-a778-505d4957e7dc")), ExerciseId8, WordNumber.Create(2).Value, Text.Create("open").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("c94b4187-1a22-419a-8ba4-4b83f42e133b")), ExerciseId8, WordNumber.Create(3).Value, Text.Create("her.").Value, WordType.Pronoun),

            Word.Create(WordId.Create(Guid.Parse("bc701d83-279f-4912-83ca-d194e0c47c04")), ExerciseId9, WordNumber.Create(1).Value, Text.Create("Will").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("9127d763-820f-4a77-8019-2ff8742fa03b")), ExerciseId9, WordNumber.Create(2).Value, Text.Create("i").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("7da2bb0a-474c-4631-ab65-16301dff24d1")), ExerciseId9, WordNumber.Create(3).Value, Text.Create("break?").Value, WordType.Verb),

            Word.Create(WordId.Create(Guid.Parse("cad3b0f3-cbe2-4388-8498-1373966c8f80")), ExerciseId10, WordNumber.Create(1).Value, Text.Create("Did").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("67d10373-c942-46de-87ad-c8c746bd4394")), ExerciseId10, WordNumber.Create(2).Value, Text.Create("i").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("5554f1d6-d563-42fa-85a0-dda3d3d32e64")), ExerciseId10, WordNumber.Create(3).Value, Text.Create("show").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("f9f305a2-e2c8-4cca-a69c-1c1a28f92361")), ExerciseId10, WordNumber.Create(4).Value, Text.Create("them?").Value, WordType.Pronoun),

            #endregion

            #region Lesson 3

            Word.Create(WordId.Create(Guid.Parse("4c444550-1f40-441d-927e-8222587945de")), ExerciseId11, WordNumber.Create(1).Value, Text.Create("Do").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("da5738fb-e203-47a5-842b-d2ed8be5bacc")), ExerciseId11, WordNumber.Create(2).Value, Text.Create("you").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("e88e5c49-67bc-41c2-8468-999a0854f14d")), ExerciseId11, WordNumber.Create(3).Value, Text.Create("want").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("d29a4daf-014f-4693-9fa8-93bddc76ca07")), ExerciseId11, WordNumber.Create(4).Value, Text.Create("to").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("e3c15b11-db73-44c6-9897-943353ac36cc")), ExerciseId11, WordNumber.Create(5).Value, Text.Create("drink?").Value, WordType.Verb),

            Word.Create(WordId.Create(Guid.Parse("ffd568cb-99c5-4013-a9dc-b6a60e9c6143")), ExerciseId12, WordNumber.Create(1).Value, Text.Create("Did").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("7ce0bf95-5d93-40d6-a3ca-581b53aae524")), ExerciseId12, WordNumber.Create(2).Value, Text.Create("she").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("9b6b5072-2abd-4894-8171-d93d23fac035")), ExerciseId12, WordNumber.Create(3).Value, Text.Create("want").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("2261abb1-1534-44d4-a768-8e98fe9de468")), ExerciseId12, WordNumber.Create(4).Value, Text.Create("to").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("6e38e15f-dd81-472d-ae16-9cac606d1353")), ExerciseId12, WordNumber.Create(5).Value, Text.Create("forget?").Value, WordType.Verb),

            Word.Create(WordId.Create(Guid.Parse("47906dc4-c353-41c6-8023-db035c1cf11d")), ExerciseId13, WordNumber.Create(1).Value, Text.Create("I").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("77685fed-77f1-4f1e-9588-546f7d3fb88a")), ExerciseId13, WordNumber.Create(2).Value, Text.Create("was").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("fcbbbf4c-59af-417d-bf69-472fc44f1f46")), ExerciseId13, WordNumber.Create(3).Value, Text.Create("at").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("b75d0a7f-20d2-43e8-9049-3e052074a493")), ExerciseId13, WordNumber.Create(4).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("c2f8e980-d194-45ab-bcfd-1867e22aca61")), ExerciseId13, WordNumber.Create(5).Value, Text.Create("museum.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("a411463b-be35-4a60-89b7-2495ba64aca6")), ExerciseId14, WordNumber.Create(1).Value, Text.Create("She").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("677348c2-4480-4101-8c6f-f49add7ed2d3")), ExerciseId14, WordNumber.Create(2).Value, Text.Create("didn't").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("6c8da8d4-8cd5-43f2-afb3-07e5f70fb6c0")), ExerciseId14, WordNumber.Create(3).Value, Text.Create("like").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("365704b7-4690-40fa-b7b4-721945e7d168")), ExerciseId14, WordNumber.Create(4).Value, Text.Create("to").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("f797fc83-985f-4ff3-a4ae-dfc68bf1d976")), ExerciseId14, WordNumber.Create(5).Value, Text.Create("show.").Value, WordType.Verb),

            Word.Create(WordId.Create(Guid.Parse("e64d9d70-de4f-464e-81f1-e582889b2bf8")), ExerciseId15, WordNumber.Create(1).Value, Text.Create("Is").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("2a76843a-a886-4207-b62f-6cbc74fc9e16")), ExerciseId15, WordNumber.Create(2).Value, Text.Create("she").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("6528d303-346e-445b-b136-51fd70bd6729")), ExerciseId15, WordNumber.Create(3).Value, Text.Create("in").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("6c816a53-134a-40c2-8785-eeeb3baeeea4")), ExerciseId15, WordNumber.Create(4).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("93e9e66e-ffe9-4723-a092-5223a6843f7a")), ExerciseId15, WordNumber.Create(5).Value, Text.Create("elevator?").Value, WordType.Noun),

            #endregion

            #region Lesson 4

            Word.Create(WordId.Create(Guid.Parse("8ab20b3e-dc0e-47c3-aa2b-3c22535b2c59")), ExerciseId16, WordNumber.Create(1).Value, Text.Create("Will").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("4c16bf0f-d467-42cf-a273-7aaf35a3700c")), ExerciseId16, WordNumber.Create(2).Value, Text.Create("he").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("92350aae-d25e-485a-ac06-3244edd8d966")), ExerciseId16, WordNumber.Create(3).Value, Text.Create("be").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("01303bf0-fe08-411c-990b-a2aaf8f20761")), ExerciseId16, WordNumber.Create(4).Value, Text.Create("their").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("b05d7f60-7c08-40a2-b309-bc0e54153282")), ExerciseId16, WordNumber.Create(5).Value, Text.Create("actor?").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("c5acf82b-7cc3-4c11-9b5c-b078890b3fb9")), ExerciseId17, WordNumber.Create(1).Value, Text.Create("We").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("308453c4-8986-4fb7-a371-ea7667bceb8f")), ExerciseId17, WordNumber.Create(2).Value, Text.Create("are not").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("86b26bee-9175-40e4-8b05-a00fc03c9fc8")), ExerciseId17, WordNumber.Create(3).Value, Text.Create("their").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("5e629c96-9013-41a6-a847-6798ece7289c")), ExerciseId17, WordNumber.Create(4).Value, Text.Create("accountants.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("ee109302-8b1c-4725-a378-5d6030d130f5")), ExerciseId18, WordNumber.Create(1).Value, Text.Create("We").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("477daf13-182d-4d0e-911c-41330e22c8ca")), ExerciseId18, WordNumber.Create(2).Value, Text.Create("were").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("ebd4b116-4668-47ea-86f6-76221e36cdef")), ExerciseId18, WordNumber.Create(3).Value, Text.Create("his").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("9e56a7d1-d998-412c-b23c-c2f9a6cfc069")), ExerciseId18, WordNumber.Create(4).Value, Text.Create("historians.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("ed84ea16-34be-408d-8f1e-095a2c28071b")), ExerciseId19, WordNumber.Create(1).Value, Text.Create("He").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("0d46ddfa-9845-47f0-a2c4-45174cca7a6b")), ExerciseId19, WordNumber.Create(2).Value, Text.Create("will").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("deba987f-ae57-4896-b8db-0dbb4e887bf3")), ExerciseId19, WordNumber.Create(3).Value, Text.Create("be").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("bcb9deb5-bb25-4166-9c5f-5b33f3b8a908")), ExerciseId19, WordNumber.Create(4).Value, Text.Create("her").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("db3c449e-a5e2-4112-8ed6-465295f60b0d")), ExerciseId19, WordNumber.Create(5).Value, Text.Create("writer.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("8848d718-531f-4e71-af3a-41492049bdf5")), ExerciseId20, WordNumber.Create(1).Value, Text.Create("We").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("737097e9-de20-410c-bc66-27b77bd53544")), ExerciseId20, WordNumber.Create(2).Value, Text.Create("will not").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("d72f3aab-2c10-46a2-8651-d64fa7f5ec22")), ExerciseId20, WordNumber.Create(3).Value, Text.Create("be").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("e02ec9b0-11ad-498c-9cba-567742ccb535")), ExerciseId20, WordNumber.Create(4).Value, Text.Create("their").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("db072f2c-39e5-495d-b589-58b1a2bfdfbc")), ExerciseId20, WordNumber.Create(5).Value, Text.Create("guides.").Value, WordType.Noun),

            #endregion

            #region Lesson 5

            Word.Create(WordId.Create(Guid.Parse("aa83fb9d-1490-4244-9d9d-7d8f186b304b")), ExerciseId21, WordNumber.Create(1).Value, Text.Create("Do").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("10e8a357-88a5-45b2-b7ba-79f78a963fcd")), ExerciseId21, WordNumber.Create(2).Value, Text.Create("they").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("428e266c-7038-4760-a0c4-85412ff38c15")), ExerciseId21, WordNumber.Create(3).Value, Text.Create("study").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("0b45015f-a579-4a0c-b577-4602b4fcc1e2")), ExerciseId21, WordNumber.Create(4).Value, Text.Create("to").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("d000a5a4-3acb-43a5-ae0f-13bcdb9eeabc")), ExerciseId21, WordNumber.Create(5).Value, Text.Create("be").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("08a3381a-41bf-4ed3-929b-00213f93cad3")), ExerciseId21, WordNumber.Create(6).Value, Text.Create("guides?").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("d8080506-7374-4594-8b1e-ea40fa568f79")), ExerciseId22, WordNumber.Create(1).Value, Text.Create("I").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("55a69679-d8fe-475f-be5a-206bb3f188dc")), ExerciseId22, WordNumber.Create(2).Value, Text.Create("will not").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("5f5fdc25-89d4-4f9c-8401-c5efd998ba9b")), ExerciseId22, WordNumber.Create(3).Value, Text.Create("be").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("652c0794-6156-416c-a128-491725321eb3")), ExerciseId22, WordNumber.Create(4).Value, Text.Create("a").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("32993f7b-e974-4893-8253-dcde6a20011a")), ExerciseId22, WordNumber.Create(5).Value, Text.Create("manager.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("560cde4e-f0ee-421d-bfa2-4d36e66534e2")), ExerciseId23, WordNumber.Create(1).Value, Text.Create("We").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("badaab0d-8ffe-411e-9f06-88dbb625e069")), ExerciseId23, WordNumber.Create(2).Value, Text.Create("studied").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("7be612de-5330-4659-b025-bf115ac919a7")), ExerciseId23, WordNumber.Create(3).Value, Text.Create("to").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("b50af727-cfdf-49f6-b32b-af463e8f02f3")), ExerciseId23, WordNumber.Create(4).Value, Text.Create("be").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("9045b07b-ed8a-4095-b478-ab3be52d4aa1")), ExerciseId23, WordNumber.Create(5).Value, Text.Create("managers.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("8d2e9dba-596e-48ed-90ee-016f252a58d9")), ExerciseId24, WordNumber.Create(1).Value, Text.Create("Did").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("c7588cba-e4f0-46e4-9acf-3cff10f75a19")), ExerciseId24, WordNumber.Create(2).Value, Text.Create("they").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("d2cecba9-7215-435b-8f88-6bc8b92ad0ca")), ExerciseId24, WordNumber.Create(3).Value, Text.Create("work").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("d7b0d987-5c73-49b8-b07c-e391539f9e79")), ExerciseId24, WordNumber.Create(4).Value, Text.Create("in").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("4df4d2a6-16de-4b4c-af4d-dc2c14fe91c4")), ExerciseId24, WordNumber.Create(5).Value, Text.Create("a").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("5c43af33-3bb9-414b-b4a5-d5f7bc2871fc")), ExerciseId24, WordNumber.Create(6).Value, Text.Create("company").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("a6795bd5-a600-40f1-96f1-75495334531f")), ExerciseId24, WordNumber.Create(7).Value, Text.Create("as").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("b5e6c77b-72df-4fb9-ab38-733d5c1cb0be")), ExerciseId24, WordNumber.Create(8).Value, Text.Create("designers?").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("f362f83c-7246-4432-bb00-378cd85726a5")), ExerciseId25, WordNumber.Create(1).Value, Text.Create("You").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("ffd5e14b-c9e3-4a8f-a1ba-32394cb192e8")), ExerciseId25, WordNumber.Create(2).Value, Text.Create("are").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("24abd950-c84f-48a0-b13f-08ba1687c5b0")), ExerciseId25, WordNumber.Create(3).Value, Text.Create("a").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("f1603d30-ff76-4d55-9b6e-f88262818bef")), ExerciseId25, WordNumber.Create(4).Value, Text.Create("historian.").Value, WordType.Noun),

            #endregion

            #region Lesson 6

            Word.Create(WordId.Create(Guid.Parse("c5e6fb2d-df80-46c2-a0f0-6bd7d2cfdd6e")), ExerciseId26, WordNumber.Create(1).Value, Text.Create("This").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("8a5828fa-1591-453a-9d47-3326c055cf07")), ExerciseId26, WordNumber.Create(2).Value, Text.Create("pen").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("b254fddb-62ef-4a4c-b086-b809bf4a3c85")), ExerciseId26, WordNumber.Create(3).Value, Text.Create("is not").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("a9cf1323-5247-4e09-a6bb-ed6b51549d82")), ExerciseId26, WordNumber.Create(4).Value, Text.Create("bigger").Value, WordType.ComparisonAdjective),
            Word.Create(WordId.Create(Guid.Parse("96eec7f3-f76c-4271-ac3c-0a34afb3afc5")), ExerciseId26, WordNumber.Create(5).Value, Text.Create("than").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("6b36c77c-1546-40c4-9d9b-a6400167e68c")), ExerciseId26, WordNumber.Create(6).Value, Text.Create("that").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("dd3b9f9f-6539-4c9c-b4b6-3beda2a91ef7")), ExerciseId26, WordNumber.Create(7).Value, Text.Create("one.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("85513d45-bd3f-4167-8a8b-f36285fae04e")), ExerciseId27, WordNumber.Create(1).Value, Text.Create("This").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("ae5d39f5-cead-4dcf-9cb3-90ca91adb50f")), ExerciseId27, WordNumber.Create(2).Value, Text.Create("tv").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("c407b1ab-42f2-460c-8703-649d6681c158")), ExerciseId27, WordNumber.Create(3).Value, Text.Create("is not").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("51d415aa-98e5-4bd7-8c8f-c67b7f3a6947")), ExerciseId27, WordNumber.Create(4).Value, Text.Create("expensive.").Value, WordType.ComparisonAdjective),

            Word.Create(WordId.Create(Guid.Parse("a77ff4af-40bb-4e4d-88f6-1d73dd3d1532")), ExerciseId28, WordNumber.Create(1).Value, Text.Create("Is").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("ca243b2f-809b-48d2-85cb-9c4ea6639514")), ExerciseId28, WordNumber.Create(2).Value, Text.Create("this").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("da237e31-e1d7-44a9-aa15-f4cf191f3325")), ExerciseId28, WordNumber.Create(3).Value, Text.Create("phone").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("18a82a4d-8afe-49af-b0ff-8f8521ee6776")), ExerciseId28, WordNumber.Create(4).Value, Text.Create("cheaper").Value, WordType.ComparisonAdjective),
            Word.Create(WordId.Create(Guid.Parse("16f0d865-b4b3-44d1-bfd3-98022abeffb0")), ExerciseId28, WordNumber.Create(5).Value, Text.Create("than").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("d1dd51a1-7ddb-4576-99c9-11d6d4bc180d")), ExerciseId28, WordNumber.Create(6).Value, Text.Create("that").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("17fa35c1-0a3f-44dd-8107-da3f7fa6a4b8")), ExerciseId28, WordNumber.Create(7).Value, Text.Create("one?").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("27c9922e-941c-4bc5-9c8b-008ce763ffbb")), ExerciseId29, WordNumber.Create(1).Value, Text.Create("This").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("72fb7340-c690-4cca-a91b-25da598d5a7b")), ExerciseId29, WordNumber.Create(2).Value, Text.Create("pen").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("2983a4ed-7605-4137-82cc-d600463fcc26")), ExerciseId29, WordNumber.Create(3).Value, Text.Create("is").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("f4b2f19f-b10b-4e63-bb8a-366fab5cdf6a")), ExerciseId29, WordNumber.Create(4).Value, Text.Create("longer").Value, WordType.ComparisonAdjective),
            Word.Create(WordId.Create(Guid.Parse("66a08680-1bb8-4001-9dc5-043eb48751cc")), ExerciseId29, WordNumber.Create(5).Value, Text.Create("than").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("5f945157-896d-48b1-8e20-7a00471e08ea")), ExerciseId29, WordNumber.Create(6).Value, Text.Create("that").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("035f5734-cdb5-4597-ac58-c07cf9c2eaf8")), ExerciseId29, WordNumber.Create(7).Value, Text.Create("one.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("c865086b-8091-4f43-84fb-fb4aa2867564")), ExerciseId30, WordNumber.Create(1).Value, Text.Create("Are").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("f4e343e6-4253-4feb-acbd-4b2e4696f031")), ExerciseId30, WordNumber.Create(2).Value, Text.Create("these").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("b95de245-d28a-43da-97ee-2717257f5e8e")), ExerciseId30, WordNumber.Create(3).Value, Text.Create("oranges").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("cc3002ae-73ff-4d8b-a30b-7984ff65c637")), ExerciseId30, WordNumber.Create(4).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("dd157da3-eae6-4716-bcfc-799ab9938468")), ExerciseId30, WordNumber.Create(5).Value, Text.Create("least?").Value, WordType.ComparisonAdjective),

            #endregion

            #region Lesson 7

            Word.Create(WordId.Create(Guid.Parse("cf64bd66-8135-4db4-84c7-4b4042014171")), ExerciseId31, WordNumber.Create(1).Value, Text.Create("We").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("7d58002a-d39b-4c5e-b2fe-707333b67143")), ExerciseId31, WordNumber.Create(2).Value, Text.Create("will").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("eda93807-2914-4d73-996a-ea3da0119c8e")), ExerciseId31, WordNumber.Create(3).Value, Text.Create("read").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("72752394-e545-406d-8d55-6da48c02f6c0")), ExerciseId31, WordNumber.Create(4).Value, Text.Create("somebody.").Value, WordType.Compound),

            Word.Create(WordId.Create(Guid.Parse("d674b579-98a5-4685-b5b8-57cc4ab44ecb")), ExerciseId32, WordNumber.Create(1).Value, Text.Create("Do").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("32b4b79c-d5c1-42a3-8ff2-cb820748ab12")), ExerciseId32, WordNumber.Create(2).Value, Text.Create("they").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("2a94b158-6bfd-4f59-8b84-c72f0e6dbfe0")), ExerciseId32, WordNumber.Create(3).Value, Text.Create("feel").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("1d198016-aa5a-4470-869a-b324ad4b414f")), ExerciseId32, WordNumber.Create(4).Value, Text.Create("everywhere?").Value, WordType.Compound),

            Word.Create(WordId.Create(Guid.Parse("11862af5-94f7-42a5-8ba6-c844d767974e")), ExerciseId33, WordNumber.Create(1).Value, Text.Create("Do").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("2c22b82e-c48e-41c6-bbf7-9ce9e1d31304")), ExerciseId33, WordNumber.Create(2).Value, Text.Create("you").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("e0c89c34-cb77-4a6f-8203-e2b2423da4be")), ExerciseId33, WordNumber.Create(3).Value, Text.Create("meet").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("a5c2b72a-de5f-4386-bff2-2b771d8faf00")), ExerciseId33, WordNumber.Create(4).Value, Text.Create("everywhere?").Value, WordType.Compound),

            Word.Create(WordId.Create(Guid.Parse("3a749c16-5c5a-4643-8a51-081e6603ff93")), ExerciseId34, WordNumber.Create(1).Value, Text.Create("Will").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("4281fc8f-b215-409b-a266-a457f372a658")), ExerciseId34, WordNumber.Create(2).Value, Text.Create("he").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("b5a1cba3-70d5-47f4-b7d0-0c66952a1483")), ExerciseId34, WordNumber.Create(3).Value, Text.Create("know").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("b3705cbc-bf08-45f8-9065-165b04897237")), ExerciseId34, WordNumber.Create(4).Value, Text.Create("everybody?").Value, WordType.Compound),

            Word.Create(WordId.Create(Guid.Parse("63cc78de-a8c1-45a1-ab22-111912655b0f")), ExerciseId35, WordNumber.Create(1).Value, Text.Create("He").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("7df7d199-1fc6-4931-bacd-712a6c31e854")), ExerciseId35, WordNumber.Create(2).Value, Text.Create("never").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("5a5555c5-9d2b-4b4e-a8b8-10f71072cca5")), ExerciseId35, WordNumber.Create(3).Value, Text.Create("sees.").Value, WordType.Verb),

            #endregion

            #region Lesson 8

            Word.Create(WordId.Create(Guid.Parse("8b3f1810-d77e-40ed-9602-3b010393f2f7")), ExerciseId36, WordNumber.Create(1).Value, Text.Create("She").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("12c91238-0a40-412f-a9ea-edef9f843ac2")), ExerciseId36, WordNumber.Create(2).Value, Text.Create("didn't").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("cf42c0f9-f178-4ad1-a9b0-23cd3e2f6dd2")), ExerciseId36, WordNumber.Create(3).Value, Text.Create("turn").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("e90b0d76-c379-4c70-9e1d-278d30d2f84c")), ExerciseId36, WordNumber.Create(4).Value, Text.Create("us").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("a0545d9d-9f57-49ed-8df8-ee7d530a6faf")), ExerciseId36, WordNumber.Create(5).Value, Text.Create("six").Value, WordType.LetterNumber),
            Word.Create(WordId.Create(Guid.Parse("321e8ffb-7d75-4576-bd68-b3e3dfca321c")), ExerciseId36, WordNumber.Create(6).Value, Text.Create("months").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("8021ff3e-eb1b-446a-9b73-adef0d0ae9d2")), ExerciseId36, WordNumber.Create(7).Value, Text.Create("ago.").Value, WordType.Preposition),

            Word.Create(WordId.Create(Guid.Parse("3cdd0d98-8009-4cb3-915f-ae60410b6179")), ExerciseId37, WordNumber.Create(1).Value, Text.Create("Will").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("8e008156-c553-44b0-bb4b-2b871a23b084")), ExerciseId37, WordNumber.Create(2).Value, Text.Create("he").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("f4a06801-56ae-4515-b26f-a8254f4f9138")), ExerciseId37, WordNumber.Create(3).Value, Text.Create("grow").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("3ef49176-91ae-4057-8d91-08c2204f6ca5")), ExerciseId37, WordNumber.Create(4).Value, Text.Create("in").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("dd8b7e20-305d-4c58-9426-b5a8ff393a63")), ExerciseId37, WordNumber.Create(5).Value, Text.Create("2 months?").Value, WordType.NumberWithNoun),

            Word.Create(WordId.Create(Guid.Parse("38a2fd86-16c9-41da-89a0-471e668057a2")), ExerciseId38, WordNumber.Create(1).Value, Text.Create("I").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("69a301a0-6347-4bbe-913f-9c4207c6cf2e")), ExerciseId38, WordNumber.Create(2).Value, Text.Create("will").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("837f7298-f17e-4889-934d-bbe3928cf78a")), ExerciseId38, WordNumber.Create(3).Value, Text.Create("tell").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("f269ddc9-a1b8-4dbe-aba6-4de8bac0f60e")), ExerciseId38, WordNumber.Create(4).Value, Text.Create("you").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("0f82f4fe-9bf4-42e1-96c7-03285ce058ec")), ExerciseId38, WordNumber.Create(5).Value, Text.Create("in").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("c72e9c2a-74f6-4005-99bd-aa2b9a8bd136")), ExerciseId38, WordNumber.Create(6).Value, Text.Create("6 months.").Value, WordType.NumberWithNoun),

            Word.Create(WordId.Create(Guid.Parse("99689641-1265-4733-8d29-e079c828d4f4")), ExerciseId39, WordNumber.Create(1).Value, Text.Create("Will").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("28ff38f3-8e64-4579-bdc5-9423e6194b78")), ExerciseId39, WordNumber.Create(2).Value, Text.Create("you").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("093b5767-2c02-49ad-9411-0441b1ac3cfb")), ExerciseId39, WordNumber.Create(3).Value, Text.Create("be").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("c2b26e84-328c-4933-801c-d85561951519")), ExerciseId39, WordNumber.Create(4).Value, Text.Create("there").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("300297c1-390b-422f-99dc-64deb2999633")), ExerciseId39, WordNumber.Create(5).Value, Text.Create("in").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("102a9309-d836-41b7-9161-7218fd2c72a7")), ExerciseId39, WordNumber.Create(6).Value, Text.Create("6 months?").Value, WordType.NumberWithNoun),

            Word.Create(WordId.Create(Guid.Parse("0057d61f-be88-45ef-8fc5-36b4007836b4")), ExerciseId40, WordNumber.Create(1).Value, Text.Create("Did").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("7d021962-57d7-4ca2-bf30-9259ee5ab868")), ExerciseId40, WordNumber.Create(2).Value, Text.Create("she").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("2cf74112-88cd-47bd-bf91-647fbb1cbd87")), ExerciseId40, WordNumber.Create(3).Value, Text.Create("love").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("a37ac663-0ba8-4bd0-ad6c-8a994ae6ac15")), ExerciseId40, WordNumber.Create(4).Value, Text.Create("them").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("cd0005da-238e-4f4d-a8bf-577145927e55")), ExerciseId40, WordNumber.Create(5).Value, Text.Create("at").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("6d9a80c0-0c46-4c3d-b9f0-36d10f687479")), ExerciseId40, WordNumber.Create(6).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("fb8a3467-0ac9-4d28-abbf-e859e6a3f379")), ExerciseId40, WordNumber.Create(7).Value, Text.Create("weekend?").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("b78c1f18-e22c-46cb-822e-95ed13180e1f")), ExerciseId41, WordNumber.Create(1).Value, Text.Create("She").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("bde7d97d-fd52-4dbd-845c-070fe28d1eef")), ExerciseId41, WordNumber.Create(2).Value, Text.Create("was").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("f8f80952-4821-4e6b-b803-68d7b873c0d3")), ExerciseId41, WordNumber.Create(3).Value, Text.Create("there").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("8a85b8cb-1af7-4169-b469-4d4f44f011f0")), ExerciseId41, WordNumber.Create(4).Value, Text.Create("in").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("49530039-6beb-4e5a-a204-928549bde57a")), ExerciseId41, WordNumber.Create(5).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("7b0f7fb3-098d-4052-b082-62f49c1f524a")), ExerciseId41, WordNumber.Create(6).Value, Text.Create("evening.").Value, WordType.Noun),

            #endregion

            #region Lesson9

            Word.Create(WordId.Create(Guid.Parse("95a730b1-31f2-4b4e-9735-87d58e052f46")), ExerciseId42, WordNumber.Create(1).Value, Text.Create("There").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("c0a0110d-2ae2-4bb2-907e-550860f99486")), ExerciseId42, WordNumber.Create(2).Value, Text.Create("were not").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("23eb8ecd-e716-4206-90f0-73ad6ce37ba9")), ExerciseId42, WordNumber.Create(3).Value, Text.Create("pens").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("c216f101-8bf8-4a14-898c-aedd6d8950fc")), ExerciseId42, WordNumber.Create(4).Value, Text.Create("on").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("98060567-e398-4547-8a91-4240835a1865")), ExerciseId42, WordNumber.Create(5).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("a830e576-8447-482e-8328-27595c09233a")), ExerciseId42, WordNumber.Create(6).Value, Text.Create("floor.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("45a8252a-7ff7-4723-b873-b0651fed7650")), ExerciseId43, WordNumber.Create(1).Value, Text.Create("There").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("ab9cf665-86e5-45a9-ba23-7b3d78b063a5")), ExerciseId43, WordNumber.Create(2).Value, Text.Create("are").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("8f870d79-d57e-4f7b-ab9d-6c61ab3c64a4")), ExerciseId43, WordNumber.Create(3).Value, Text.Create("knives").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("841ee253-d742-4016-8a23-c0cf75f73d82")), ExerciseId43, WordNumber.Create(4).Value, Text.Create("under").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("522ec4a7-741b-4be4-92ff-e498563dd758")), ExerciseId43, WordNumber.Create(5).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("b2422659-428f-42f3-91ec-7b631e987bfa")), ExerciseId43, WordNumber.Create(6).Value, Text.Create("table.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("99b4410a-a72f-4859-ae70-3300d702a593")), ExerciseId44, WordNumber.Create(1).Value, Text.Create("There").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("4765e15e-c2f8-44e8-aa23-404b017ad7c8")), ExerciseId44, WordNumber.Create(2).Value, Text.Create("will").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("2b6efff3-438b-4fc7-adb1-c8ad320cfd3a")), ExerciseId44, WordNumber.Create(3).Value, Text.Create("be").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("09d1d5d8-8e04-42f0-935c-13e7af7abbc5")), ExerciseId44, WordNumber.Create(4).Value, Text.Create("a").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("671e2459-df4e-4b0b-9da1-d800e860b8c7")), ExerciseId44, WordNumber.Create(5).Value, Text.Create("ball").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("038b26c6-d388-42fb-b495-2d7ee10e2dfe")), ExerciseId44, WordNumber.Create(6).Value, Text.Create("under").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("7aa420aa-09fe-4b85-943b-3456c86785d1")), ExerciseId44, WordNumber.Create(7).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("d72726b6-d76e-4040-b2b1-4bf364950070")), ExerciseId44, WordNumber.Create(8).Value, Text.Create("armchair.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("51c4d966-be64-42d0-a4e3-ad4922d104ee")), ExerciseId45, WordNumber.Create(1).Value, Text.Create("There").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("1aed4c76-ded9-46c6-9610-c6c3afa103f2")), ExerciseId45, WordNumber.Create(2).Value, Text.Create("isn't").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("9f9f764a-f436-4d49-9e69-82a005c0fef1")), ExerciseId45, WordNumber.Create(3).Value, Text.Create("a").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("5f27046a-a728-449c-a755-d109b6da6305")), ExerciseId45, WordNumber.Create(4).Value, Text.Create("pen").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("500b7e09-ba16-408a-a3d8-a2f257c2d4ba")), ExerciseId45, WordNumber.Create(5).Value, Text.Create("on").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("053d4969-b803-4de7-ae16-5b4e85682122")), ExerciseId45, WordNumber.Create(6).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("67bd4bb6-259c-417c-954e-9a43a7219f69")), ExerciseId45, WordNumber.Create(7).Value, Text.Create("table.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("cec85e4b-aad3-4e76-b021-b116f3430e0c")), ExerciseId46, WordNumber.Create(1).Value, Text.Create("Was").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("a113bf16-cf4f-46bf-9994-be81e1bfb5f4")), ExerciseId46, WordNumber.Create(2).Value, Text.Create("there").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("3fc45a1d-2e7e-4c1d-a63f-8bbe23b0bdb1")), ExerciseId46, WordNumber.Create(3).Value, Text.Create("a").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("a69d2ffa-e2f1-4e1e-aaf1-3a624e6cfb7b")), ExerciseId46, WordNumber.Create(4).Value, Text.Create("glass").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("ca50eb3a-a2b7-4693-9182-40cd9f944763")), ExerciseId46, WordNumber.Create(5).Value, Text.Create("under").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("94d11980-9385-4eff-a913-00ffd4ed7186")), ExerciseId46, WordNumber.Create(6).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("c5cf28aa-3275-4959-930c-26150b542cbb")), ExerciseId46, WordNumber.Create(7).Value, Text.Create("armchair?").Value, WordType.Noun),

            #endregion

            #region Lesson 10

            Word.Create(WordId.Create(Guid.Parse("f5bea200-ec4f-4c93-b880-f976932dc1e4")), ExerciseId47, WordNumber.Create(1).Value, Text.Create("Does").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("7d2989d7-5f2e-40ab-b1ea-0f702d0bc7f9")), ExerciseId47, WordNumber.Create(2).Value, Text.Create("he").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("0713b7fc-088a-42aa-9418-cbe97525e442")), ExerciseId47, WordNumber.Create(3).Value, Text.Create("go").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("66c731f0-af6a-4112-838a-cbf97c89107f")), ExerciseId47, WordNumber.Create(4).Value, Text.Create("on").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("2f1ce64d-be27-4b2c-957d-d40f9ca1c0da")), ExerciseId47, WordNumber.Create(5).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("d87f1b04-50ad-4536-b024-b7354cff5924")), ExerciseId47, WordNumber.Create(6).Value, Text.Create("station?").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("83b288db-82cd-4af4-a50e-a155ea33e4d1")), ExerciseId48, WordNumber.Create(1).Value, Text.Create("You").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("8be099e9-4c51-4a1a-bc5d-1a7d8a6ecfc9")), ExerciseId48, WordNumber.Create(2).Value, Text.Create("will not").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("9ecae500-6486-4150-af21-e9342099d63d")), ExerciseId48, WordNumber.Create(3).Value, Text.Create("out").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("a9139f63-b421-48e5-b57e-9e6cbb981335")), ExerciseId48, WordNumber.Create(4).Value, Text.Create("of").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("5da1971f-eebb-426f-bb84-3169140f44af")), ExerciseId48, WordNumber.Create(5).Value, Text.Create("from").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("5000f800-ca2c-4d13-a662-4ffea05ca8af")), ExerciseId48, WordNumber.Create(6).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("d0df1f36-e28c-4294-a777-a5d8cdfdccfa")), ExerciseId48, WordNumber.Create(7).Value, Text.Create("garden.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("9ef2fedb-1ef1-44e4-838c-81b6b133c4d9")), ExerciseId49, WordNumber.Create(1).Value, Text.Create("There").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("0a134ca9-847d-44cb-9ed3-4e501082218a")), ExerciseId49, WordNumber.Create(2).Value, Text.Create("won't").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("703a1892-9825-4098-be7b-6f84dcee99ea")), ExerciseId49, WordNumber.Create(3).Value, Text.Create("be").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("1711493d-98bf-4a8a-b332-b3cd3b32c952")), ExerciseId49, WordNumber.Create(4).Value, Text.Create("cupboards").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("e618cd1b-7e69-4a4f-81a0-5d6ef3a49ebf")), ExerciseId49, WordNumber.Create(5).Value, Text.Create("in").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("9e1232c7-afe0-4b98-8611-cef575ba0287")), ExerciseId49, WordNumber.Create(6).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("965a710f-7c23-44b0-a714-aaa668453c9f")), ExerciseId49, WordNumber.Create(7).Value, Text.Create("room.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("ed3a4cbb-e41d-4c14-acc8-3de98d3759d1")), ExerciseId50, WordNumber.Create(1).Value, Text.Create("There").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("6e763f8f-89c5-4689-87af-422682c01d6c")), ExerciseId50, WordNumber.Create(2).Value, Text.Create("will").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("18ae7dc8-e658-472a-a0e8-ec70c652ba19")), ExerciseId50, WordNumber.Create(3).Value, Text.Create("be").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("30dff33b-5d00-4ecb-b9bf-b416c8f09d3d")), ExerciseId50, WordNumber.Create(4).Value, Text.Create("a").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("27f25c91-155d-47b4-8bf2-efaaa27df03d")), ExerciseId50, WordNumber.Create(5).Value, Text.Create("cup").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("e148b86c-f415-4535-b29e-387e7c0bee39")), ExerciseId50, WordNumber.Create(6).Value, Text.Create("on").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("6460ee32-2853-4473-a201-3e2224e43e8d")), ExerciseId50, WordNumber.Create(7).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("32491f9a-68ce-4e50-a4fa-d1c80b3b754d")), ExerciseId50, WordNumber.Create(8).Value, Text.Create("windowsill.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("056f0cf0-591e-4198-9705-98c6b3fdf54f")), ExerciseId51, WordNumber.Create(1).Value, Text.Create("Were").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("eb914b69-abea-449a-b6da-94c97205dbc6")), ExerciseId51, WordNumber.Create(2).Value, Text.Create("there").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("f15fd353-be99-43d1-8702-870ff329dede")), ExerciseId51, WordNumber.Create(3).Value, Text.Create("glasses").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("2908b049-1a88-4e33-8203-2790d07d101e")), ExerciseId51, WordNumber.Create(4).Value, Text.Create("under").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("f8802137-c2ad-4612-ba4e-e4ec60429fbc")), ExerciseId51, WordNumber.Create(5).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("3af1a8f4-d043-4560-98e0-e961f621dea5")), ExerciseId51, WordNumber.Create(6).Value, Text.Create("table?").Value, WordType.Noun),

            #endregion

            #region Lesson 11

            Word.Create(WordId.Create(Guid.Parse("821a3374-ff1a-43a7-8424-e0acb0da3668")), ExerciseId52, WordNumber.Create(1).Value, Text.Create("We").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("c0c30d04-37a1-474d-b131-34d819f65972")), ExerciseId52, WordNumber.Create(2).Value, Text.Create("mustn't").Value, WordType.ModalVerb),
            Word.Create(WordId.Create(Guid.Parse("8fe5d0ba-5fb2-416c-8df7-effe5df4a477")), ExerciseId52, WordNumber.Create(3).Value, Text.Create("feel.").Value, WordType.Verb),

            Word.Create(WordId.Create(Guid.Parse("708347f3-e9b7-41e4-b8b4-4138722654d4")), ExerciseId53, WordNumber.Create(1).Value, Text.Create("Should").Value, WordType.ModalVerb),
            Word.Create(WordId.Create(Guid.Parse("76c2297a-a2b1-456f-9d4a-5ab2682638b8")), ExerciseId53, WordNumber.Create(2).Value, Text.Create("I").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("e718d0f2-f245-4dec-993f-1f4e21c93509")), ExerciseId53, WordNumber.Create(3).Value, Text.Create("stand?").Value, WordType.Verb),

            Word.Create(WordId.Create(Guid.Parse("733d0bbc-8270-4caf-a24f-963329e67456")), ExerciseId54, WordNumber.Create(1).Value, Text.Create("We").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("b2154e46-0751-45a3-a04b-1854e5354e1f")), ExerciseId54, WordNumber.Create(2).Value, Text.Create("can").Value, WordType.ModalVerb),
            Word.Create(WordId.Create(Guid.Parse("c8e17935-e205-4d65-b086-6b476c3f5e5b")), ExerciseId54, WordNumber.Create(3).Value, Text.Create("close.").Value, WordType.Verb),

            Word.Create(WordId.Create(Guid.Parse("92c54277-2d4f-44cc-b95b-a940909454fd")), ExerciseId55, WordNumber.Create(1).Value, Text.Create("We").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("02ca9313-988c-4fef-8230-cd3af412a935")), ExerciseId55, WordNumber.Create(2).Value, Text.Create("didn't").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("40b5eeb0-a9ed-4ba4-a360-f74be0e61c9f")), ExerciseId55, WordNumber.Create(3).Value, Text.Create("show.").Value, WordType.Verb),

            Word.Create(WordId.Create(Guid.Parse("1f9e4303-1f37-4528-bbd8-be19237a2f12")), ExerciseId56, WordNumber.Create(1).Value, Text.Create("She").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("81b8079b-2f6b-4063-b3e1-ba1de92ead70")), ExerciseId56, WordNumber.Create(2).Value, Text.Create("must not").Value, WordType.ModalVerb),
            Word.Create(WordId.Create(Guid.Parse("6dfded7a-b11c-49ef-abc8-85933c988f71")), ExerciseId56, WordNumber.Create(3).Value, Text.Create("answer.").Value, WordType.Verb),

            #endregion

            #region Lesson 12

            Word.Create(WordId.Create(Guid.Parse("3bb4cc15-9de1-418a-a77c-eeb97022aeea")), ExerciseId57, WordNumber.Create(1).Value, Text.Create("He").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("717bae65-4abe-413a-9732-a242710dbbbf")), ExerciseId57, WordNumber.Create(2).Value, Text.Create("was").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("a8283f88-bd52-45b9-b4a1-1c71665293c5")), ExerciseId57, WordNumber.Create(3).Value, Text.Create("reading").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("0f284ba6-695f-48b1-bf8d-668b78dc0695")), ExerciseId57, WordNumber.Create(4).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("5bdc5e76-b828-4573-ace4-657774403822")), ExerciseId57, WordNumber.Create(5).Value, Text.Create("letter").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("fac3b393-3b10-49c3-af64-9b72c2213e7e")), ExerciseId57, WordNumber.Create(6).Value, Text.Create("from").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("51208adb-93ea-4db5-ac32-67eaea7bd131")), ExerciseId57, WordNumber.Create(7).Value, Text.Create("four").Value, WordType.LetterNumber),
            Word.Create(WordId.Create(Guid.Parse("a24f2e94-143d-4ef8-8a7e-c68df91d19db")), ExerciseId57, WordNumber.Create(8).Value, Text.Create("to").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("93ab2fa6-2a8a-46c8-b5c2-7cb99abac0b0")), ExerciseId57, WordNumber.Create(9).Value, Text.Create("ten").Value, WordType.LetterNumber),
            Word.Create(WordId.Create(Guid.Parse("732a3832-113c-4ba7-a746-6bb670c93ffd")), ExerciseId57, WordNumber.Create(10).Value, Text.Create("yesterday.").Value, WordType.Adverb),

            Word.Create(WordId.Create(Guid.Parse("16e351e1-f01d-4340-b8fc-3666b3f9a7c1")), ExerciseId58, WordNumber.Create(1).Value, Text.Create("We").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("c2c63cbc-f682-49eb-8077-32cb297cedae")), ExerciseId58, WordNumber.Create(2).Value, Text.Create("were").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("09b1a15c-4b9a-4967-9da8-b8c3b72e491a")), ExerciseId58, WordNumber.Create(3).Value, Text.Create("answering").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("fcad16cf-d55a-4da8-bec2-bf9e3b5efdb6")), ExerciseId58, WordNumber.Create(4).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("266558c2-e7d4-4e5f-8cd3-7eafdf2011f2")), ExerciseId58, WordNumber.Create(5).Value, Text.Create("letter").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("a6b9f574-129e-4fb5-aa39-3e34283201e7")), ExerciseId58, WordNumber.Create(6).Value, Text.Create("at").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("c6e79d64-6e7e-46e4-909c-23a6ad4d1a50")), ExerciseId58, WordNumber.Create(7).Value, Text.Create("four").Value, WordType.LetterNumber),
            Word.Create(WordId.Create(Guid.Parse("00930476-cad8-45f0-9c94-65b0f42520ea")), ExerciseId58, WordNumber.Create(8).Value, Text.Create("yesterday.").Value, WordType.Adverb),

            Word.Create(WordId.Create(Guid.Parse("3bddcffb-8d45-46e9-8e31-2c7f727bc520")), ExerciseId59, WordNumber.Create(1).Value, Text.Create("You").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("34f99364-0c8d-499d-a9b1-e210c6b44403")), ExerciseId59, WordNumber.Create(2).Value, Text.Create("are").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("c0056a8c-cc43-4569-b34f-9b3497b41029")), ExerciseId59, WordNumber.Create(3).Value, Text.Create("feeling").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("27537960-216d-4b1d-8bb4-78439eac8a60")), ExerciseId59, WordNumber.Create(4).Value, Text.Create("bad").Value, WordType.Adjective),
            Word.Create(WordId.Create(Guid.Parse("2b80d104-f9ae-4578-b78a-57a163208e09")), ExerciseId59, WordNumber.Create(5).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("a765dcca-5242-42a4-94f7-a654cb5dd7ef")), ExerciseId59, WordNumber.Create(6).Value, Text.Create("whole").Value, WordType.Adjective),
            Word.Create(WordId.Create(Guid.Parse("6a09af9a-18b7-4d87-9b51-71dc5dda39df")), ExerciseId59, WordNumber.Create(7).Value, Text.Create("day").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("3a6a0336-a316-40be-a931-19f9b334d814")), ExerciseId59, WordNumber.Create(8).Value, Text.Create("today.").Value, WordType.Adverb),

            Word.Create(WordId.Create(Guid.Parse("b26814e0-0e0b-4c6c-b93f-e2cc674be21c")), ExerciseId60, WordNumber.Create(1).Value, Text.Create("We").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("73414b2c-a7d9-4dd3-91f6-88dc99bcb8a8")), ExerciseId60, WordNumber.Create(2).Value, Text.Create("were").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("52e7aad3-30ca-44fa-a8a4-2b88f61772c1")), ExerciseId60, WordNumber.Create(3).Value, Text.Create("studying").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("06dd14cd-f87d-457e-981f-da4b24a175c5")), ExerciseId60, WordNumber.Create(4).Value, Text.Create("French").Value, WordType.Language),
            Word.Create(WordId.Create(Guid.Parse("a26e0aae-5201-4f4f-aecb-0adf47c74dd1")), ExerciseId60, WordNumber.Create(5).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("f78b432e-007b-4e1d-b9eb-e663be27e11d")), ExerciseId60, WordNumber.Create(6).Value, Text.Create("whole").Value, WordType.Adjective),
            Word.Create(WordId.Create(Guid.Parse("50eb0628-d989-4161-989a-5ba449cde161")), ExerciseId60, WordNumber.Create(7).Value, Text.Create("day").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("b757718e-32ba-483a-b6e0-3ad09330d603")), ExerciseId60, WordNumber.Create(8).Value, Text.Create("yesterday.").Value, WordType.Preposition),

            Word.Create(WordId.Create(Guid.Parse("da1a916c-9f90-436b-9b8c-896b7b952435")), ExerciseId61, WordNumber.Create(1).Value, Text.Create("You").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("c4fc906c-188c-4a35-bf5f-ea8c991d9b19")), ExerciseId61, WordNumber.Create(2).Value, Text.Create("will").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("3f1101d0-303f-4d6e-97df-6c7b015db54a")), ExerciseId61, WordNumber.Create(3).Value, Text.Create("be").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("0ed11e4c-f7b3-4ebc-b1e2-62036f8343e0")), ExerciseId61, WordNumber.Create(4).Value, Text.Create("reading").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("109005e2-5471-468a-96c5-6625f69a47ba")), ExerciseId61, WordNumber.Create(5).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("cf050a5b-1c69-43ec-b110-0cb50866f53e")), ExerciseId61, WordNumber.Create(6).Value, Text.Create("book").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("8908d843-f524-47cb-b23e-643c2ed0c3b0")), ExerciseId61, WordNumber.Create(7).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("346a689f-179a-4643-a365-cbed0d294228")), ExerciseId61, WordNumber.Create(8).Value, Text.Create("whole").Value, WordType.Adjective),
            Word.Create(WordId.Create(Guid.Parse("79d81445-9365-42b8-80e5-e4908b29548d")), ExerciseId61, WordNumber.Create(9).Value, Text.Create("day").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("5c855ee6-4516-4d05-acae-d1ef64f8d529")), ExerciseId61, WordNumber.Create(10).Value, Text.Create("tomorrow.").Value, WordType.Adverb),

            #endregion

            #region Lesson 13

            Word.Create(WordId.Create(Guid.Parse("00b45f27-32f5-427d-a867-0bd86ca686f6")), ExerciseId62, WordNumber.Create(1).Value, Text.Create("Am").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("5028e234-1f5d-4ba6-aa05-f1b16486aaad")), ExerciseId62, WordNumber.Create(2).Value, Text.Create("I").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("3f096855-0418-4441-b5ad-7ed25e4004a2")), ExerciseId62, WordNumber.Create(3).Value, Text.Create("cold?").Value, WordType.Adjective),

            Word.Create(WordId.Create(Guid.Parse("f272d9e5-c74b-406b-8ee7-49bc219fb236")), ExerciseId63, WordNumber.Create(1).Value, Text.Create("I").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("f2d24856-7142-4f63-a3ee-cc0075bc049d")), ExerciseId63, WordNumber.Create(2).Value, Text.Create("do not").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("278c23b6-05bd-4754-b429-497912a42875")), ExerciseId63, WordNumber.Create(3).Value, Text.Create("have").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("f18fa01b-f2ab-403f-839e-b309cae77257")), ExerciseId63, WordNumber.Create(4).Value, Text.Create("blue").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("71af8e78-182c-48fe-ade6-a27017651d8a")), ExerciseId63, WordNumber.Create(5).Value, Text.Create("eyes.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("d7439311-90f3-4a2f-96fc-43601117cfdb")), ExerciseId64, WordNumber.Create(1).Value, Text.Create("You").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("986fcb90-274c-47d9-b70c-11a84413ae47")), ExerciseId64, WordNumber.Create(2).Value, Text.Create("are").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("8e55a6ff-fe4d-4f28-986a-918ab9cfbebd")), ExerciseId64, WordNumber.Create(3).Value, Text.Create("healthy.").Value, WordType.Adjective),

            Word.Create(WordId.Create(Guid.Parse("6e2bba52-4ff8-4d86-a0ba-1e3c4be4060a")), ExerciseId65, WordNumber.Create(1).Value, Text.Create("It").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("2f209651-2072-46c1-92c6-e3129812872e")), ExerciseId65, WordNumber.Create(2).Value, Text.Create("was").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("3edef03f-2c5c-405d-8e66-347bc84cf25c")), ExerciseId65, WordNumber.Create(3).Value, Text.Create("hot").Value, WordType.Adjective),
            Word.Create(WordId.Create(Guid.Parse("00fc0a5b-42da-4d88-a23b-204ee9da7690")), ExerciseId65, WordNumber.Create(4).Value, Text.Create("yesterday.").Value, WordType.Adverb),

            Word.Create(WordId.Create(Guid.Parse("3d94a2f9-d946-4442-adcc-1853c18a2a66")), ExerciseId66, WordNumber.Create(1).Value, Text.Create("She").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("88eadca0-4df9-4cae-b62a-499308be8000")), ExerciseId66, WordNumber.Create(2).Value, Text.Create("is").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("6602a985-8f69-42f4-8613-b9276301aafa")), ExerciseId66, WordNumber.Create(3).Value, Text.Create("adult.").Value, WordType.Adjective),

            #endregion

            #region Lesson 14

            Word.Create(WordId.Create(Guid.Parse("bd49617f-3d0c-4523-8dbd-8f547533bf15")), ExerciseId67, WordNumber.Create(1).Value, Text.Create("Run").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("6e9772b5-74dd-43f3-98ce-788a00e14b54")), ExerciseId67, WordNumber.Create(2).Value, Text.Create("to").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("707783fe-97c0-4dba-bb21-aa2d52123af3")), ExerciseId67, WordNumber.Create(3).Value, Text.Create("her.").Value, WordType.Pronoun),

            Word.Create(WordId.Create(Guid.Parse("12d0d824-b5fa-4b8d-8850-e13c7633b236")), ExerciseId68, WordNumber.Create(1).Value, Text.Create("Don't").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("07bb3b2e-6642-4d2e-9892-1b82bbfa6552")), ExerciseId68, WordNumber.Create(2).Value, Text.Create("turn").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("c06e0c2f-0698-4542-9287-396df1ca1da7")), ExerciseId68, WordNumber.Create(3).Value, Text.Create("his").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("d35cd03c-752a-4e8a-8151-157206a10e04")), ExerciseId68, WordNumber.Create(4).Value, Text.Create("nightstand.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("f4864def-5bf0-4807-82de-0fcf4b5035cf")), ExerciseId69, WordNumber.Create(1).Value, Text.Create("Don't").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("66bc5768-f578-44f3-b926-b189a362362a")), ExerciseId69, WordNumber.Create(2).Value, Text.Create("take").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("0a8af533-0355-4a81-9986-ab4672c21216")), ExerciseId69, WordNumber.Create(3).Value, Text.Create("my").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("397ac297-9bf8-4043-ad0d-1fe48ccbb92a")), ExerciseId69, WordNumber.Create(4).Value, Text.Create("tablet.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("f16ac678-bb42-49a9-8384-c73dfff9031b")), ExerciseId70, WordNumber.Create(1).Value, Text.Create("Remember").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("fb0b9918-ce22-45c6-a897-b238a9ae752f")), ExerciseId70, WordNumber.Create(2).Value, Text.Create("about").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("21808835-84a9-4e8c-b3c2-563e6be681c4")), ExerciseId70, WordNumber.Create(3).Value, Text.Create("us.").Value, WordType.Pronoun),

            Word.Create(WordId.Create(Guid.Parse("fb1a905d-8041-4c96-a90e-15351471b676")), ExerciseId71, WordNumber.Create(1).Value, Text.Create("Let").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("d111f79c-9d1a-4673-89fb-725b2e8ca290")), ExerciseId71, WordNumber.Create(2).Value, Text.Create("him").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("be28a592-e7b7-4872-a654-dc6c67601984")), ExerciseId71, WordNumber.Create(3).Value, Text.Create("answer.").Value, WordType.Verb),

            #endregion

            #region Lesson 15

            Word.Create(WordId.Create(Guid.Parse("a12a96c4-7af0-4a61-b87d-5c6ebf9e074c")), ExerciseId72, WordNumber.Create(1).Value, Text.Create("He").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("75f8a4ab-c767-4157-896c-fc84eae79a95")), ExerciseId72, WordNumber.Create(2).Value, Text.Create("took").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("8aa66574-fa04-4662-8eeb-a9da3d191e6d")), ExerciseId72, WordNumber.Create(3).Value, Text.Create("off").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("3f9dd1fa-a471-429c-9dae-7b04978c8c01")), ExerciseId72, WordNumber.Create(4).Value, Text.Create("weight.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("27315754-f175-442f-9dd6-bd085d5671a4")), ExerciseId73, WordNumber.Create(1).Value, Text.Create("Your").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("b9557d81-8a3d-4c6d-b710-d691aea4cc29")), ExerciseId73, WordNumber.Create(2).Value, Text.Create("son").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("857e0dc5-fb65-413b-971a-ddd902925cb2")), ExerciseId73, WordNumber.Create(3).Value, Text.Create("asks").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("406c1a27-235a-4a65-aa5a-a67696bd2c15")), ExerciseId73, WordNumber.Create(4).Value, Text.Create("to").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("de8d2200-13dc-4484-ad75-49d52d913176")), ExerciseId73, WordNumber.Create(5).Value, Text.Create("turn").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("dd0210f2-e619-4378-827a-b9615e1a961f")), ExerciseId73, WordNumber.Create(6).Value, Text.Create("on").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("a9b9a516-fb52-45e0-a505-06d4c90212d3")), ExerciseId73, WordNumber.Create(7).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("21224da0-d994-43bc-a255-de2196e45fe8")), ExerciseId73, WordNumber.Create(8).Value, Text.Create("light.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("7d12de65-1ed1-4ff4-b370-48431ed33498")), ExerciseId74, WordNumber.Create(1).Value, Text.Create("He").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("7a5d6144-892c-44f3-9923-4e6acc1942dc")), ExerciseId74, WordNumber.Create(2).Value, Text.Create("went").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("3aea664c-3b78-41b2-b46d-2bab83fac782")), ExerciseId74, WordNumber.Create(3).Value, Text.Create("down").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("c919c16a-3a03-4ece-b9f3-0b1232ccfc9c")), ExerciseId74, WordNumber.Create(4).Value, Text.Create("with").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("f520eb5d-a149-4501-b81b-b91755d8e824")), ExerciseId74, WordNumber.Create(5).Value, Text.Create("pneumonia.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("59ca1c35-0b5a-4f84-b93d-c913790ce636")), ExerciseId75, WordNumber.Create(1).Value, Text.Create("He").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("43c4cac2-8fdb-46e2-83ee-0b01b6fb3cfa")), ExerciseId75, WordNumber.Create(2).Value, Text.Create("broke").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("72742f65-67dd-4c57-8449-b5b5a1609764")), ExerciseId75, WordNumber.Create(3).Value, Text.Create("down").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("cfecd9cb-64fa-4eb3-b28c-de174daece9a")), ExerciseId75, WordNumber.Create(4).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("bdd1e3bd-34ed-4087-998b-672a0f7c4541")), ExerciseId75, WordNumber.Create(5).Value, Text.Create("door.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("13384cfa-cc62-45c8-81a9-19730a767842")), ExerciseId76, WordNumber.Create(1).Value, Text.Create("The").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("88b94e99-be58-4865-9a81-91a69665b91a")), ExerciseId76, WordNumber.Create(2).Value, Text.Create("prices").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("b46e68ab-8087-42b0-8cbb-67c40c6cbd92")), ExerciseId76, WordNumber.Create(3).Value, Text.Create("never").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("dd03b987-abe4-4fc5-a039-84acbc0d0f9d")), ExerciseId76, WordNumber.Create(4).Value, Text.Create("go").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("1c3bc0ab-948d-4ff3-8b5b-b379c8f17ef2")), ExerciseId76, WordNumber.Create(5).Value, Text.Create("down.").Value, WordType.Preposition),

            #endregion

            #region Lesson 16

            Word.Create(WordId.Create(Guid.Parse("f93241d6-78c5-4020-b05b-6653482395d9")), ExerciseId77, WordNumber.Create(1).Value, Text.Create("He").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("8b2b57b7-4263-497d-8717-39a153ba8868")), ExerciseId77, WordNumber.Create(2).Value, Text.Create("has").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("331879de-0917-43c8-a806-ca25a5b7ee26")), ExerciseId77, WordNumber.Create(3).Value, Text.Create("just").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("5b07930a-b5a9-4dc5-9b90-ccb7a9dc72d5")), ExerciseId77, WordNumber.Create(4).Value, Text.Create("gone").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("16c5a294-672c-475a-9f25-861bb940bcf2")), ExerciseId77, WordNumber.Create(5).Value, Text.Create("out.").Value, WordType.Adverb),

            Word.Create(WordId.Create(Guid.Parse("0cd86ba6-a639-44c0-a3a7-52b21d8d1db8")), ExerciseId78, WordNumber.Create(1).Value, Text.Create("I").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("9560026b-c0da-4560-b900-1b9a98a5481b")), ExerciseId78, WordNumber.Create(2).Value, Text.Create("think").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("f3745df6-34fe-4893-b49e-d2df69ab9b41")), ExerciseId78, WordNumber.Create(3).Value, Text.Create("I").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("4e9ab62c-6b49-4c0f-b133-d29769a87875")), ExerciseId78, WordNumber.Create(4).Value, Text.Create("have").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("46b64731-f69e-4a76-b4e8-a04b5463f31e")), ExerciseId78, WordNumber.Create(5).Value, Text.Create("seen").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("6b1a7094-a595-47a1-bb02-d27157f8b986")), ExerciseId78, WordNumber.Create(6).Value, Text.Create("you").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("bab59bca-4e8b-4c2b-807a-ec596eafc734")), ExerciseId78, WordNumber.Create(7).Value, Text.Create("somewhere.").Value, WordType.Compound),

            Word.Create(WordId.Create(Guid.Parse("3ba53ff9-55ec-47a8-bda4-7b2b3bfe7eef")), ExerciseId79, WordNumber.Create(1).Value, Text.Create("I").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("882ace04-92bf-49a8-a68d-2905e2ac9bcc")), ExerciseId79, WordNumber.Create(2).Value, Text.Create("have").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("bd43afaf-827c-4096-be24-ec2845221394")), ExerciseId79, WordNumber.Create(3).Value, Text.Create("done").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("cd2d0845-0303-49a1-888f-0dc5618b18bf")), ExerciseId79, WordNumber.Create(4).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("9cb3c19c-6e84-44c7-a01f-e963f5fa9f99")), ExerciseId79, WordNumber.Create(5).Value, Text.Create("work.").Value, WordType.Verb),

            Word.Create(WordId.Create(Guid.Parse("569920d1-aac7-4344-b056-807b8ca638c9")), ExerciseId80, WordNumber.Create(1).Value, Text.Create("I").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("a5189a67-94f4-4a67-8257-ee31411406f4")), ExerciseId80, WordNumber.Create(2).Value, Text.Create("have").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("77847680-fa92-4498-a05a-98136ff91d59")), ExerciseId80, WordNumber.Create(3).Value, Text.Create("already").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("fbeb86a4-bba8-46d7-8838-080c7e13a1e3")), ExerciseId80, WordNumber.Create(4).Value, Text.Create("written").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("a5bfb23c-14b6-4c03-a629-bacb408a0f95")), ExerciseId80, WordNumber.Create(5).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("40c59511-ba4d-415a-a077-36787b60a24d")), ExerciseId80, WordNumber.Create(6).Value, Text.Create("letter").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("dcf30dce-4ec1-42b1-b2e1-518854731a86")), ExerciseId80, WordNumber.Create(7).Value, Text.Create("to").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("b0c1fc1f-26c9-4f2d-a5a4-486098cbffbd")), ExerciseId80, WordNumber.Create(8).Value, Text.Create("my").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("627d6fbd-7f21-4ea0-abf3-3bd8a2b35dd9")), ExerciseId80, WordNumber.Create(9).Value, Text.Create("friend.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("e243f48b-051e-43d2-b040-b785a4c6a8f1")), ExerciseId81, WordNumber.Create(1).Value, Text.Create("He").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("da209dfa-7ece-45fe-a40a-58e9190f9f11")), ExerciseId81, WordNumber.Create(2).Value, Text.Create("has").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("6453673f-5504-4ab4-b8e2-7c24f203de86")), ExerciseId81, WordNumber.Create(3).Value, Text.Create("just").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("d3d90704-52a5-4985-8c2d-8c0ad5fe0ae8")), ExerciseId81, WordNumber.Create(4).Value, Text.Create("visited").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("c72b38c0-40fd-4086-9fa7-e612e834bf7f")), ExerciseId81, WordNumber.Create(5).Value, Text.Create("this").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("115c85d6-1c60-425a-bb69-f057d4261682")), ExerciseId81, WordNumber.Create(6).Value, Text.Create("supermarket.").Value, WordType.Noun),

            #endregion

            #region Lesson 17

            Word.Create(WordId.Create(Guid.Parse("53f5e181-64e5-43c0-9562-5cbea6811051")), ExerciseId82, WordNumber.Create(1).Value, Text.Create("I").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("efeb3f87-7d88-4ad9-bc46-cba105941cea")), ExerciseId82, WordNumber.Create(2).Value, Text.Create("had not").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("1a4a7b7f-d800-4e59-a3a5-eff18fd0a7b4")), ExerciseId82, WordNumber.Create(3).Value, Text.Create("finished").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("d796e8d7-3a26-4aee-ae1b-9303dae5354e")), ExerciseId82, WordNumber.Create(4).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("7dcce746-1b9b-404a-bc7f-6144dd47998c")), ExerciseId82, WordNumber.Create(5).Value, Text.Create("project").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("f1bcf935-7ef2-4db6-9d04-4dcf0a065bfd")), ExerciseId82, WordNumber.Create(6).Value, Text.Create("by").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("aa95c2f3-14ae-488d-86ba-c2429d3ae115")), ExerciseId82, WordNumber.Create(7).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("38425870-c577-4f40-a441-137a9d7aa79e")), ExerciseId82, WordNumber.Create(8).Value, Text.Create("beginning").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("567b7275-6054-4e4a-94a6-e288f8363cdf")), ExerciseId82, WordNumber.Create(9).Value, Text.Create("of").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("ee0ebe02-9cf1-4ea8-9e3f-83de2064860e")), ExerciseId82, WordNumber.Create(10).Value, Text.Create("that").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("0ed3f0d2-3aff-455e-b43d-5fc51d677801")), ExerciseId82, WordNumber.Create(11).Value, Text.Create("week.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("6588c771-0bb9-4f04-9bba-30f92b2cbf94")), ExerciseId83, WordNumber.Create(1).Value, Text.Create("Had").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("4177d8d8-ab32-4267-8139-53e959a69a1f")), ExerciseId83, WordNumber.Create(2).Value, Text.Create("he").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("b7f428e2-fffc-4b63-a110-4e25b95a1391")), ExerciseId83, WordNumber.Create(3).Value, Text.Create("done").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("e36558c1-ac77-4399-9ead-686c02901a55")), ExerciseId83, WordNumber.Create(4).Value, Text.Create("his").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("38f47fd9-8c91-42fa-a53a-42e3f773b649")), ExerciseId83, WordNumber.Create(5).Value, Text.Create("homework").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("ad29c2b0-e30c-4325-9266-8014862f73e1")), ExerciseId83, WordNumber.Create(6).Value, Text.Create("before").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("96eb6e4f-b46c-471f-ad4a-3a3412960b91")), ExerciseId83, WordNumber.Create(7).Value, Text.Create("his").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("9fadd129-9cfa-4d26-a8bd-1a3065174a0c")), ExerciseId83, WordNumber.Create(8).Value, Text.Create("parents").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("56b5f97a-705c-4156-a3ef-5295d50c8e02")), ExerciseId83, WordNumber.Create(9).Value, Text.Create("returned").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("e8daa7d5-86d5-4b6d-9352-e4330224d7ed")), ExerciseId83, WordNumber.Create(10).Value, Text.Create("home?").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("2efb2dc7-921d-49d8-98af-316f9d06e3ef")), ExerciseId84, WordNumber.Create(1).Value, Text.Create("Had").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("424da8c5-d636-449e-b413-0ff958d02fb6")), ExerciseId84, WordNumber.Create(2).Value, Text.Create("he").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("b87b2423-28a2-4462-839f-317a9243a02b")), ExerciseId84, WordNumber.Create(3).Value, Text.Create("written").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("2075c28d-c8f0-47ce-afec-6076439c2414")), ExerciseId84, WordNumber.Create(4).Value, Text.Create("a").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("8707ff38-f985-4c03-b1bd-c3aa5b1d1a39")), ExerciseId84, WordNumber.Create(5).Value, Text.Create("letter,").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("5a1c413a-13a0-42ef-b411-032cc7e4c6bb")), ExerciseId84, WordNumber.Create(6).Value, Text.Create("when").Value, WordType.QuestionWord),
            Word.Create(WordId.Create(Guid.Parse("b9df8bf4-f2d8-43d8-bf99-692fe80161a2")), ExerciseId84, WordNumber.Create(7).Value, Text.Create("you").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("62ac119a-e639-4f67-9f3e-55fa6d7cd5b8")), ExerciseId84, WordNumber.Create(8).Value, Text.Create("came").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("df08a6cb-a92b-43b5-aa3b-12684a6b4713")), ExerciseId84, WordNumber.Create(9).Value, Text.Create("in?").Value, WordType.Preposition),

            Word.Create(WordId.Create(Guid.Parse("8d193de8-5148-418e-b0f4-9178cb91c947")), ExerciseId85, WordNumber.Create(1).Value, Text.Create("You").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("e71ff896-63a5-40da-b17d-7e2bb4f7564f")), ExerciseId85, WordNumber.Create(2).Value, Text.Create("had").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("1f0996b6-e2eb-42d9-9052-002893d9ef5e")), ExerciseId85, WordNumber.Create(3).Value, Text.Create("returned").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("2fe50cce-1c56-4de6-8453-8f2ed7108ec8")), ExerciseId85, WordNumber.Create(4).Value, Text.Create("home").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("03074cc6-d5c2-4e6a-bd88-4a9d48442afa")), ExerciseId85, WordNumber.Create(5).Value, Text.Create("before").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("d84d576b-6a48-4fca-9052-06a5e19377f0")), ExerciseId85, WordNumber.Create(6).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("99beea68-6adb-460d-87c7-62a1f904cd39")), ExerciseId85, WordNumber.Create(7).Value, Text.Create("rain").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("1eaafcba-b844-4a54-b4df-4188c0030e58")), ExerciseId85, WordNumber.Create(8).Value, Text.Create("began.").Value, WordType.Verb),

            Word.Create(WordId.Create(Guid.Parse("e562a31e-7a9b-4350-ad1f-d0faadb9fc5c")), ExerciseId86, WordNumber.Create(1).Value, Text.Create("When").Value, WordType.QuestionWord),
            Word.Create(WordId.Create(Guid.Parse("d1910ef9-a38c-43eb-b6da-1d8959484df4")), ExerciseId86, WordNumber.Create(2).Value, Text.Create("we").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("f5b3308f-fad0-493a-be74-a67f4b11aaf0")), ExerciseId86, WordNumber.Create(3).Value, Text.Create("came").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("d0606c4b-b76c-4b19-a91e-19caa19e1d03")), ExerciseId86, WordNumber.Create(4).Value, Text.Create("to").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("26d06311-6cdd-4c3a-8b41-de88737744d3")), ExerciseId86, WordNumber.Create(5).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("43af24e5-74d9-4583-826d-82bf37a59326")), ExerciseId86, WordNumber.Create(6).Value, Text.Create("station").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("6ecd7193-0683-415a-86a8-074fffd57091")), ExerciseId86, WordNumber.Create(7).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("f6fa9365-7360-4270-9a79-f24684e6ab84")), ExerciseId86, WordNumber.Create(8).Value, Text.Create("train").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("68f9e3b5-e5ce-4c11-ab67-db2691b0df64")), ExerciseId86, WordNumber.Create(9).Value, Text.Create("had").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("ec7eee20-b872-44f3-9a95-63f4b8c57889")), ExerciseId86, WordNumber.Create(10).Value, Text.Create("already").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("69c1127c-c1b5-41f0-be18-e6d57b53e584")), ExerciseId86, WordNumber.Create(11).Value, Text.Create("gone.").Value, WordType.Verb),

            #endregion

            #region Lesson 18

            Word.Create(WordId.Create(Guid.Parse("78d4a6b6-a0ab-4fe8-96b8-fabfc0f328cb")), ExerciseId87, WordNumber.Create(1).Value, Text.Create("The").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("8f3858f2-50ab-47a2-bcb1-2cc1f45066f7")), ExerciseId87, WordNumber.Create(2).Value, Text.Create("pupils").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("05c82041-90b4-4717-afad-48d6dc9a848e")), ExerciseId87, WordNumber.Create(3).Value, Text.Create("will").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("1fb916f4-c4f3-4982-9ccf-831a2e4c7418")), ExerciseId87, WordNumber.Create(4).Value, Text.Create("have").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("f07ea390-208f-4d3c-ac88-dcda683a2a4c")), ExerciseId87, WordNumber.Create(5).Value, Text.Create("taken").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("87b5243c-e90d-412e-bb1f-3e442f84dd09")), ExerciseId87, WordNumber.Create(6).Value, Text.Create("their").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("ca6d7868-9199-4b8a-9e77-cf64a4ba3720")), ExerciseId87, WordNumber.Create(7).Value, Text.Create("seats").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("e8381a7d-cf81-46d4-a874-65a3ea8bba55")), ExerciseId87, WordNumber.Create(8).Value, Text.Create("before").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("272ab11f-0596-4785-8171-da054b2b84ef")), ExerciseId87, WordNumber.Create(9).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("ca958b36-8035-4191-b987-6a7d03621e39")), ExerciseId87, WordNumber.Create(10).Value, Text.Create("lesson").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("b7e12317-8c04-49bb-aae0-008104ebb230")), ExerciseId87, WordNumber.Create(11).Value, Text.Create("starts.").Value, WordType.Verb),

            Word.Create(WordId.Create(Guid.Parse("257f0144-0d8e-4279-a661-e9bc84cc51b9")), ExerciseId88, WordNumber.Create(1).Value, Text.Create("They").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("5472005a-376a-417e-88a3-4e0132bc1fd0")), ExerciseId88, WordNumber.Create(2).Value, Text.Create("will not").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("adc35eb2-44c3-4695-b021-a86e6ecb79b6")), ExerciseId88, WordNumber.Create(3).Value, Text.Create("have").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("106137a0-fcd2-4d3c-9e7a-ba3b5c93bd5e")), ExerciseId88, WordNumber.Create(4).Value, Text.Create("won").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("10c65254-1e4c-46a4-9920-d3e09585f7d2")), ExerciseId88, WordNumber.Create(5).Value, Text.Create("three").Value, WordType.LetterNumber),
            Word.Create(WordId.Create(Guid.Parse("72640d74-b354-4ab5-9ab2-5ea03798409a")), ExerciseId88, WordNumber.Create(6).Value, Text.Create("games").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("e19432de-97ef-4325-a04a-0cc7fc0361df")), ExerciseId88, WordNumber.Create(7).Value, Text.Create("by").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("1abb3725-60f9-450e-a554-32a4c9916434")), ExerciseId88, WordNumber.Create(8).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("4f282a23-c9c1-415e-bae1-b17560c205a0")), ExerciseId88, WordNumber.Create(9).Value, Text.Create("end").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("7bdd30d0-623f-4d51-a001-b15827933323")), ExerciseId88, WordNumber.Create(10).Value, Text.Create("of").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("50ae70f4-480e-455e-a52a-5d8d70118fce")), ExerciseId88, WordNumber.Create(11).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("f6d7f159-ec7f-4e57-aebc-2e3da141113d")), ExerciseId88, WordNumber.Create(12).Value, Text.Create("month.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("182778c2-4308-430a-bef1-51a864dd7dc8")), ExerciseId89, WordNumber.Create(1).Value, Text.Create("I").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("7c1524ad-d7cd-48d1-a364-56c5536d0ec1")), ExerciseId89, WordNumber.Create(2).Value, Text.Create("will").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("d8e6b80b-1d7a-44e3-a890-795d265aea56")), ExerciseId89, WordNumber.Create(3).Value, Text.Create("have").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("0244dfbc-7f8c-439d-b925-8f6bb16e1485")), ExerciseId89, WordNumber.Create(4).Value, Text.Create("finished").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("10f0d3a1-38f7-4056-9a5b-e582e8b92762")), ExerciseId89, WordNumber.Create(5).Value, Text.Create("this").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("aa6fa9b7-0efd-436a-8ac3-b895fa1f056b")), ExerciseId89, WordNumber.Create(6).Value, Text.Create("work,").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("8dab255b-b429-4987-8dc8-fa76cac2947c")), ExerciseId89, WordNumber.Create(7).Value, Text.Create("before").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("4696e43d-ceb4-49e6-811b-91955c83c761")), ExerciseId89, WordNumber.Create(8).Value, Text.Create("you").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("68200191-b99e-4ebb-b949-04e9e04d87c5")), ExerciseId89, WordNumber.Create(9).Value, Text.Create("return.").Value, WordType.Verb),

            Word.Create(WordId.Create(Guid.Parse("467d7c72-6c2d-44cc-a93f-a9635cc88f96")), ExerciseId90, WordNumber.Create(1).Value, Text.Create("They").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("54108911-2328-445f-bf8a-2908b6222b8f")), ExerciseId90, WordNumber.Create(2).Value, Text.Create("will not").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("ec80556b-4ba3-4bef-affa-8e1c2677329f")), ExerciseId90, WordNumber.Create(3).Value, Text.Create("have").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("1e851c92-425b-43a5-ad28-b4b69a2619b9")), ExerciseId90, WordNumber.Create(4).Value, Text.Create("shipped").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("ed204a67-aea4-4846-9cce-8ed1d7515747")), ExerciseId90, WordNumber.Create(5).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("41381c8d-ed1e-4be0-a8ce-36ed3dcd7454")), ExerciseId90, WordNumber.Create(6).Value, Text.Create("goods").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("0c3f8764-3fce-4185-93ca-8835c7f3943a")), ExerciseId90, WordNumber.Create(7).Value, Text.Create("when").Value, WordType.QuestionWord),
            Word.Create(WordId.Create(Guid.Parse("55e5d5d0-0f55-420f-b32c-ba246b59a013")), ExerciseId90, WordNumber.Create(8).Value, Text.Create("your").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("0975c2ca-c98e-4cf8-89c7-858a03a70f1f")), ExerciseId90, WordNumber.Create(9).Value, Text.Create("telegram").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("55447a54-afdb-41e3-9c03-fb7f91923d9b")), ExerciseId90, WordNumber.Create(10).Value, Text.Create("arrives.").Value, WordType.Verb),

            Word.Create(WordId.Create(Guid.Parse("21920bdb-4390-475e-beb1-10dd28a50f6c")), ExerciseId91, WordNumber.Create(1).Value, Text.Create("I").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("126ca615-6889-42c5-b8d9-7101d1e4c332")), ExerciseId91, WordNumber.Create(2).Value, Text.Create("will not").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("d8724ba4-2f9c-4fc7-80ed-5fbb6db5e1f1")), ExerciseId91, WordNumber.Create(3).Value, Text.Create("have").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("ef0d1783-fa1a-4d30-b97e-eed3059a14cf")), ExerciseId91, WordNumber.Create(4).Value, Text.Create("finished").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("4428f056-f48c-4d8e-87fe-a5a601640dde")), ExerciseId91, WordNumber.Create(5).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("14986925-f269-4656-b99c-b13ac0b92345")), ExerciseId91, WordNumber.Create(6).Value, Text.Create("report").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("a0b97346-fcf9-4317-978a-c3e0125d8c95")), ExerciseId91, WordNumber.Create(7).Value, Text.Create("by").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("85f93e77-bc2c-4379-9ced-204048d04d89")), ExerciseId91, WordNumber.Create(8).Value, Text.Create("tonight.").Value, WordType.Adverb),

            #endregion
        ];
    }
}