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

    public static IReadOnlyList<Exercise> GetExercisesForLessons()
    {
        return
        [
            #region Lesson 1

            Exercise.Create(ExerciseId1, RusPhrase.Create("Ты не увидишь.").Value).Value,
            Exercise.Create(ExerciseId2, RusPhrase.Create("Мы покажем?").Value).Value,
            Exercise.Create(ExerciseId3, RusPhrase.Create("Она работала.").Value).Value,
            Exercise.Create(ExerciseId4, RusPhrase.Create("Ты не думал.").Value).Value,
            Exercise.Create(ExerciseId5, RusPhrase.Create("Я посмотрю?").Value).Value,

            #endregion

            #region Lesson 2

            Exercise.Create(ExerciseId6, RusPhrase.Create("Мы не оставили его.").Value).Value,
            Exercise.Create(ExerciseId7, RusPhrase.Create("Он поймёт тебя.").Value).Value,
            Exercise.Create(ExerciseId8, RusPhrase.Create("Ты открываешь ей.").Value).Value,
            Exercise.Create(ExerciseId9, RusPhrase.Create("Я сломаю?").Value).Value,
            Exercise.Create(ExerciseId10, RusPhrase.Create("Я показал им?").Value).Value,

            #endregion

            #region Lesson 3

            Exercise.Create(ExerciseId11, RusPhrase.Create("Тебе хочется пить?").Value).Value,
            Exercise.Create(ExerciseId12, RusPhrase.Create("Ей хотелось забывать?").Value).Value,
            Exercise.Create(ExerciseId13, RusPhrase.Create("Я был в музее.").Value).Value,
            Exercise.Create(ExerciseId14, RusPhrase.Create("Ей не нравилось показывать.").Value).Value,
            Exercise.Create(ExerciseId15, RusPhrase.Create("Она в лифте?").Value).Value,

            #endregion

            #region Lesson 4

            Exercise.Create(ExerciseId16, RusPhrase.Create("Он будет их актёром?").Value).Value,
            Exercise.Create(ExerciseId17, RusPhrase.Create("Мы не их бухгалтеры.").Value).Value,
            Exercise.Create(ExerciseId18, RusPhrase.Create("Мы были его историками.").Value).Value,
            Exercise.Create(ExerciseId19, RusPhrase.Create("Он будет её писателем.").Value).Value,
            Exercise.Create(ExerciseId20, RusPhrase.Create("Мы не будем их гидами.").Value).Value,

            #endregion

            #region Lesson 5

            Exercise.Create(ExerciseId21, RusPhrase.Create("Они учатся на гидов?").Value).Value,
            Exercise.Create(ExerciseId22, RusPhrase.Create("Я не буду менеджером.").Value).Value,
            Exercise.Create(ExerciseId23, RusPhrase.Create("Мы учились на менеджеров.").Value).Value,
            Exercise.Create(ExerciseId24, RusPhrase.Create("Они работали в компании дизайнерами?").Value).Value,
            Exercise.Create(ExerciseId25, RusPhrase.Create("Ты историк.").Value).Value,

            #endregion

            #region Lesson 6

            Exercise.Create(ExerciseId26, RusPhrase.Create("Эта ручка не больше той.").Value).Value,
            Exercise.Create(ExerciseId27, RusPhrase.Create("Этот телевизор не дорогой.").Value).Value,
            Exercise.Create(ExerciseId28, RusPhrase.Create("Этот телефон дешевле того?").Value).Value,
            Exercise.Create(ExerciseId29, RusPhrase.Create("Эта ручка длиннее той.").Value).Value,
            Exercise.Create(ExerciseId30, RusPhrase.Create("Эти апельсины самые маленькие?").Value).Value,

            #endregion

            #region Lesson 7

            Exercise.Create(ExerciseId31, RusPhrase.Create("Мы будем читать кому-нибудь.").Value).Value,
            Exercise.Create(ExerciseId32, RusPhrase.Create("Они чувствуют везде?").Value).Value,
            Exercise.Create(ExerciseId33, RusPhrase.Create("Ты встречаешь везде?").Value).Value,
            Exercise.Create(ExerciseId34, RusPhrase.Create("Он будет знать всех?").Value).Value,
            Exercise.Create(ExerciseId35, RusPhrase.Create("Он никогда не видит.").Value).Value,

            #endregion

            #region Lesson 8

            Exercise.Create(ExerciseId36, RusPhrase.Create("Она не повернула нас 6 месяцев назад.").Value).Value,
            Exercise.Create(ExerciseId37, RusPhrase.Create("Он будет расти через 2 месяца?").Value).Value,
            Exercise.Create(ExerciseId38, RusPhrase.Create("Я расскажу тебе через 6 месяцев.").Value).Value,
            Exercise.Create(ExerciseId39, RusPhrase.Create("Ты будешь там через 6 месяцев?").Value).Value,
            Exercise.Create(ExerciseId40, RusPhrase.Create("Она любила их в выходные?").Value).Value,

            #endregion

            #region Lesson 9

            Exercise.Create(ExerciseId41, RusPhrase.Create("На полу не было ручек.").Value).Value,
            Exercise.Create(ExerciseId42, RusPhrase.Create("Под столом есть ножи.").Value).Value,
            Exercise.Create(ExerciseId43, RusPhrase.Create("Под креслом будет мяч.").Value).Value,
            Exercise.Create(ExerciseId44, RusPhrase.Create("На столе нет ручки.").Value).Value,
            Exercise.Create(ExerciseId45, RusPhrase.Create("Под креслом был стакан?").Value).Value,

            #endregion

            #region Lesson 10

            Exercise.Create(ExerciseId46, RusPhrase.Create("Он идёт на станцию?").Value).Value,
            Exercise.Create(ExerciseId47, RusPhrase.Create("Ты не выйдешь из сада.").Value).Value,
            Exercise.Create(ExerciseId48, RusPhrase.Create("В комнате не будет шкафов.").Value).Value,
            Exercise.Create(ExerciseId49, RusPhrase.Create("На подоконнике будет чашка.").Value).Value,
            Exercise.Create(ExerciseId50, RusPhrase.Create("Под столом были стаканы?").Value).Value,

            #endregion

            #region Lesson 11

            Exercise.Create(ExerciseId51, RusPhrase.Create("Мы не должны чувствовать.").Value).Value,
            Exercise.Create(ExerciseId52, RusPhrase.Create("Нужно мне стоять?").Value).Value,
            Exercise.Create(ExerciseId53, RusPhrase.Create("Мы можем закрыть.").Value).Value,
            Exercise.Create(ExerciseId54, RusPhrase.Create("Мы не показали.").Value).Value,
            Exercise.Create(ExerciseId55, RusPhrase.Create("Она не должна ответить.").Value).Value,

            #endregion

            #region Lesson 12

            Exercise.Create(ExerciseId56, RusPhrase.Create("Он читал письмо с 4 до 10 вчера.").Value).Value,
            Exercise.Create(ExerciseId57, RusPhrase.Create("Мы отвечали на письмо в 4 вчера.").Value).Value,
            Exercise.Create(ExerciseId58, RusPhrase.Create("Ты чувствуешь себя плохо целый день сегодня.").Value).Value,
            Exercise.Create(ExerciseId59, RusPhrase.Create("Мы изучали французский целый день вчера.").Value).Value,
            Exercise.Create(ExerciseId60, RusPhrase.Create("Ты будешь читать книгу целый день завтра.").Value).Value,

            #endregion

            #region Lesson 13

            Exercise.Create(ExerciseId61, RusPhrase.Create("Мне холодно?").Value).Value,
            Exercise.Create(ExerciseId62, RusPhrase.Create("У меня не голубые глаза.").Value).Value,
            Exercise.Create(ExerciseId63, RusPhrase.Create("Ты здоров.").Value).Value,
            Exercise.Create(ExerciseId64, RusPhrase.Create("Вчера было жарко.").Value).Value,
            Exercise.Create(ExerciseId65, RusPhrase.Create("Она взрослая.").Value).Value,

            #endregion

            #region Lesson 14

            Exercise.Create(ExerciseId66, RusPhrase.Create("Беги к ней.").Value).Value,
            Exercise.Create(ExerciseId67, RusPhrase.Create("Не поворачивай его тумбочку.").Value).Value,
            Exercise.Create(ExerciseId68, RusPhrase.Create("Не бери мой планшет.").Value).Value,
            Exercise.Create(ExerciseId69, RusPhrase.Create("Помни про нас.").Value).Value,
            Exercise.Create(ExerciseId70, RusPhrase.Create("Пусть он ответит.").Value).Value,

            #endregion

            #region Lesson 15

            Exercise.Create(ExerciseId71, RusPhrase.Create("Он сбросил вес.").Value).Value,
            Exercise.Create(ExerciseId72, RusPhrase.Create("Твой сын просит выключить свет.").Value).Value,
            Exercise.Create(ExerciseId73, RusPhrase.Create("Он свалился с пневмонией.").Value).Value,
            Exercise.Create(ExerciseId74, RusPhrase.Create("Он взломал дверь.").Value).Value,
            Exercise.Create(ExerciseId75, RusPhrase.Create("Цены никогда не падают.").Value).Value,

            #endregion

            #region Lesson 16

            Exercise.Create(ExerciseId76, RusPhrase.Create("Он только что вышел.").Value).Value,
            Exercise.Create(ExerciseId77, RusPhrase.Create("Думаю, что я видел вас где-то.").Value).Value,
            Exercise.Create(ExerciseId78, RusPhrase.Create("Я выполнил работу.").Value).Value,
            Exercise.Create(ExerciseId79, RusPhrase.Create("Я уже написал письмо своему другу.").Value).Value,
            Exercise.Create(ExerciseId80, RusPhrase.Create("Он только что посетил этот супермаркет.").Value).Value,

            #endregion

            #region Lesson 17

            Exercise.Create(ExerciseId81, RusPhrase.Create("Я не успел закончить проект к началу той недели.").Value).Value,
            Exercise.Create(ExerciseId82, RusPhrase.Create("Он сделал домашнее задание до того, как его родители вернулись домой?").Value).Value,
            Exercise.Create(ExerciseId83, RusPhrase.Create("Он уже написал письмо, когда ты вошел?").Value).Value,
            Exercise.Create(ExerciseId84, RusPhrase.Create("Вы вернулись домой до того, как начался дождь.").Value).Value,
            Exercise.Create(ExerciseId85, RusPhrase.Create("Когда мы приехали на станцию, поезд уже ушел.").Value).Value,

            #endregion

            #region Lesson 18

            Exercise.Create(ExerciseId86, RusPhrase.Create("Ученики займут свои места до того, как начнется урок.").Value).Value,
            Exercise.Create(ExerciseId87, RusPhrase.Create("Они не успеют выиграть три игры к концу месяца.").Value).Value,
            Exercise.Create(ExerciseId88, RusPhrase.Create("Я уже окончу эту работу до того, как вы возвратитесь.").Value).Value,
            Exercise.Create(ExerciseId89, RusPhrase.Create("Они еще не отгрузят товар, когда придет ваша телеграмма.").Value).Value,
            Exercise.Create(ExerciseId90, RusPhrase.Create("Я не закончу писать доклад к вечеру.").Value).Value,

            #endregion

            #region Lesson 20

            Exercise.Create(ExerciseId96, RusPhrase.Create("Она готовит ужин уже три часа.").Value).Value,
            Exercise.Create(ExerciseId97, RusPhrase.Create("Я пекла этот пирог с самого утра.").Value).Value,
            Exercise.Create(ExerciseId98, RusPhrase.Create("Рабочие пытаются сдвинуть наш шкаф с места вот уже полчаса.").Value).Value,
            Exercise.Create(ExerciseId99, RusPhrase.Create("Я читаю этот журнал с тех пор, как купил его неделю назад.").Value).Value,
            Exercise.Create(ExerciseId100, RusPhrase.Create("Я жду свою маму уже давно.").Value).Value,

            #endregion

            #region Lesson 21

            Exercise.Create(ExerciseId101, RusPhrase.Create("С теп пор показатель быстро рос.").Value).Value,
            Exercise.Create(ExerciseId102, RusPhrase.Create("Его руки были грязные, он копал.").Value).Value,
            Exercise.Create(ExerciseId103, RusPhrase.Create("Они разговаривали больше часа, до того, как он пришел.").Value).Value,
            Exercise.Create(ExerciseId104, RusPhrase.Create("Был час ночи, а соседская собака лаяла уже 2 часа.").Value).Value,
            Exercise.Create(ExerciseId105, RusPhrase.Create("Моя собака играла уже полчаса перед тем, как мы пошли гулять.").Value).Value,

            #endregion

            #region Lesson 22

            Exercise.Create(ExerciseId106, RusPhrase.Create("Они будут разговаривать уже свыше часа, к тому моменту, когда приедет он.").Value).Value,
            Exercise.Create(ExerciseId107, RusPhrase.Create("К первому июня он будет работать на этом заводе уже двадцать лет.").Value).Value,
            Exercise.Create(ExerciseId108, RusPhrase.Create("К следующему рождеству я уже буду преподавать 10 лет.").Value).Value,
            Exercise.Create(ExerciseId109, RusPhrase.Create("Ты будешь ждать свыше двух часов, прежде чем ее самолет, наконец, приземлится?").Value).Value,
            Exercise.Create(ExerciseId110, RusPhrase.Create("В следующем месяце мы будем жить вместе уже 15 лет.").Value).Value,

            #endregion

            #region Lesson 24

            Exercise.Create(ExerciseId116, RusPhrase.Create("Они будут разговаривать уже свыше часа, к тому моменту, когда приедет он.").Value).Value,
            Exercise.Create(ExerciseId117, RusPhrase.Create("К первому июня он будет работать на этом заводе уже двадцать лет.").Value).Value,
            Exercise.Create(ExerciseId118, RusPhrase.Create("К следующему рождеству я уже буду преподавать 10 лет.").Value).Value,
            Exercise.Create(ExerciseId119, RusPhrase.Create("Ты будешь ждать свыше двух часов, прежде чем ее самолет, наконец, приземлится?").Value).Value,
            Exercise.Create(ExerciseId120, RusPhrase.Create("В следующем месяце мы будем жить вместе уже 15 лет.").Value).Value,

            #endregion

            #region Lesson 25

            Exercise.Create(ExerciseId121, RusPhrase.Create("Я был разочарован услышать, что все больше и больше людей теряют свою работу.").Value).Value,
            Exercise.Create(ExerciseId122, RusPhrase.Create("Измученный, он провалился в сон.").Value).Value,
            Exercise.Create(ExerciseId123, RusPhrase.Create("Прибор, купленный в специализированном магазине, имеет гарантию.").Value).Value,
            Exercise.Create(ExerciseId124, RusPhrase.Create("Они не смогли оправиться от проигранной войны.").Value).Value,
            Exercise.Create(ExerciseId125, RusPhrase.Create("После компьютерного сбоя мы не смогли восстановить потерянные данные.").Value).Value,

            #endregion

            #region Lesson 26

            Exercise.Create(ExerciseId126, RusPhrase.Create("Купив немного новой одежды, она почувствовала себя намного лучше.").Value).Value,
            Exercise.Create(ExerciseId127, RusPhrase.Create("Посмотрев много журналов и газет, он начал писать свой доклад.").Value).Value,
            Exercise.Create(ExerciseId128, RusPhrase.Create("Приняв мой совет, она последовала ему.").Value).Value,
            Exercise.Create(ExerciseId129, RusPhrase.Create("Заплатив штраф, он больше не нарушал закон.").Value).Value,
            Exercise.Create(ExerciseId130, RusPhrase.Create("Обыскав квартиру, они не не нашли никаких доказательств.").Value).Value,

            #endregion

            #region Lesson 28

            Exercise.Create(ExerciseId136, RusPhrase.Create("Офис убирают каждый день?").Value).Value,
            Exercise.Create(ExerciseId137, RusPhrase.Create("Я приглашён на вечеринку.").Value).Value,
            Exercise.Create(ExerciseId138, RusPhrase.Create("Ему предложили хорошую работу в большой строительной компании.").Value).Value,
            Exercise.Create(ExerciseId139, RusPhrase.Create("Ужин подается после семи.").Value).Value,
            Exercise.Create(ExerciseId140, RusPhrase.Create("Его преследовала полиция.").Value).Value,

            #endregion

            #region Lesson 29

            Exercise.Create(ExerciseId141, RusPhrase.Create("Вопрос обсуждался в семь часов?").Value).Value,
            Exercise.Create(ExerciseId142, RusPhrase.Create("Комнату в этот момент моют.").Value).Value,
            Exercise.Create(ExerciseId143, RusPhrase.Create("Его осматривает доктор в настоящий момент.").Value).Value,
            Exercise.Create(ExerciseId144, RusPhrase.Create("Его не преследует полиция в данный момент.").Value).Value,
            Exercise.Create(ExerciseId145, RusPhrase.Create("Его дом строится сейчас?").Value).Value,

            #endregion

            #region Lesson 30

            Exercise.Create(ExerciseId146, RusPhrase.Create("Эта книга уже будет прочитана завтра к 2 часам?").Value).Value,
            Exercise.Create(ExerciseId147, RusPhrase.Create("Эта книга уже прочитана.").Value).Value,
            Exercise.Create(ExerciseId148, RusPhrase.Create("Сообщение еще не было прочитано к двум часам.").Value).Value,
            Exercise.Create(ExerciseId149, RusPhrase.Create("Ее уже пригласили в ресторан.").Value).Value,
            Exercise.Create(ExerciseId150, RusPhrase.Create("Книги уже распроданы?").Value).Value,

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

            #endregion

            #region Lesson9

            Word.Create(WordId.Create(Guid.Parse("95a730b1-31f2-4b4e-9735-87d58e052f46")), ExerciseId41, WordNumber.Create(1).Value, Text.Create("There").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("c0a0110d-2ae2-4bb2-907e-550860f99486")), ExerciseId41, WordNumber.Create(2).Value, Text.Create("were not").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("23eb8ecd-e716-4206-90f0-73ad6ce37ba9")), ExerciseId41, WordNumber.Create(3).Value, Text.Create("pens").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("c216f101-8bf8-4a14-898c-aedd6d8950fc")), ExerciseId41, WordNumber.Create(4).Value, Text.Create("on").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("98060567-e398-4547-8a91-4240835a1865")), ExerciseId41, WordNumber.Create(5).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("a830e576-8447-482e-8328-27595c09233a")), ExerciseId41, WordNumber.Create(6).Value, Text.Create("floor.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("45a8252a-7ff7-4723-b873-b0651fed7650")), ExerciseId42, WordNumber.Create(1).Value, Text.Create("There").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("ab9cf665-86e5-45a9-ba23-7b3d78b063a5")), ExerciseId42, WordNumber.Create(2).Value, Text.Create("are").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("8f870d79-d57e-4f7b-ab9d-6c61ab3c64a4")), ExerciseId42, WordNumber.Create(3).Value, Text.Create("knives").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("841ee253-d742-4016-8a23-c0cf75f73d82")), ExerciseId42, WordNumber.Create(4).Value, Text.Create("under").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("522ec4a7-741b-4be4-92ff-e498563dd758")), ExerciseId42, WordNumber.Create(5).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("b2422659-428f-42f3-91ec-7b631e987bfa")), ExerciseId42, WordNumber.Create(6).Value, Text.Create("table.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("99b4410a-a72f-4859-ae70-3300d702a593")), ExerciseId43, WordNumber.Create(1).Value, Text.Create("There").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("4765e15e-c2f8-44e8-aa23-404b017ad7c8")), ExerciseId43, WordNumber.Create(2).Value, Text.Create("will").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("2b6efff3-438b-4fc7-adb1-c8ad320cfd3a")), ExerciseId43, WordNumber.Create(3).Value, Text.Create("be").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("09d1d5d8-8e04-42f0-935c-13e7af7abbc5")), ExerciseId43, WordNumber.Create(4).Value, Text.Create("a").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("671e2459-df4e-4b0b-9da1-d800e860b8c7")), ExerciseId43, WordNumber.Create(5).Value, Text.Create("ball").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("038b26c6-d388-42fb-b495-2d7ee10e2dfe")), ExerciseId43, WordNumber.Create(6).Value, Text.Create("under").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("7aa420aa-09fe-4b85-943b-3456c86785d1")), ExerciseId43, WordNumber.Create(7).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("d72726b6-d76e-4040-b2b1-4bf364950070")), ExerciseId43, WordNumber.Create(8).Value, Text.Create("armchair.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("51c4d966-be64-42d0-a4e3-ad4922d104ee")), ExerciseId44, WordNumber.Create(1).Value, Text.Create("There").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("1aed4c76-ded9-46c6-9610-c6c3afa103f2")), ExerciseId44, WordNumber.Create(2).Value, Text.Create("isn't").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("9f9f764a-f436-4d49-9e69-82a005c0fef1")), ExerciseId44, WordNumber.Create(3).Value, Text.Create("a").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("5f27046a-a728-449c-a755-d109b6da6305")), ExerciseId44, WordNumber.Create(4).Value, Text.Create("pen").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("500b7e09-ba16-408a-a3d8-a2f257c2d4ba")), ExerciseId44, WordNumber.Create(5).Value, Text.Create("on").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("053d4969-b803-4de7-ae16-5b4e85682122")), ExerciseId44, WordNumber.Create(6).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("67bd4bb6-259c-417c-954e-9a43a7219f69")), ExerciseId44, WordNumber.Create(7).Value, Text.Create("table.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("cec85e4b-aad3-4e76-b021-b116f3430e0c")), ExerciseId45, WordNumber.Create(1).Value, Text.Create("Was").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("a113bf16-cf4f-46bf-9994-be81e1bfb5f4")), ExerciseId45, WordNumber.Create(2).Value, Text.Create("there").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("3fc45a1d-2e7e-4c1d-a63f-8bbe23b0bdb1")), ExerciseId45, WordNumber.Create(3).Value, Text.Create("a").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("a69d2ffa-e2f1-4e1e-aaf1-3a624e6cfb7b")), ExerciseId45, WordNumber.Create(4).Value, Text.Create("glass").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("ca50eb3a-a2b7-4693-9182-40cd9f944763")), ExerciseId45, WordNumber.Create(5).Value, Text.Create("under").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("94d11980-9385-4eff-a913-00ffd4ed7186")), ExerciseId45, WordNumber.Create(6).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("c5cf28aa-3275-4959-930c-26150b542cbb")), ExerciseId45, WordNumber.Create(7).Value, Text.Create("armchair?").Value, WordType.Noun),

            #endregion

            #region Lesson 10

            Word.Create(WordId.Create(Guid.Parse("f5bea200-ec4f-4c93-b880-f976932dc1e4")), ExerciseId46, WordNumber.Create(1).Value, Text.Create("Does").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("7d2989d7-5f2e-40ab-b1ea-0f702d0bc7f9")), ExerciseId46, WordNumber.Create(2).Value, Text.Create("he").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("0713b7fc-088a-42aa-9418-cbe97525e442")), ExerciseId46, WordNumber.Create(3).Value, Text.Create("go").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("66c731f0-af6a-4112-838a-cbf97c89107f")), ExerciseId46, WordNumber.Create(4).Value, Text.Create("on").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("2f1ce64d-be27-4b2c-957d-d40f9ca1c0da")), ExerciseId46, WordNumber.Create(5).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("d87f1b04-50ad-4536-b024-b7354cff5924")), ExerciseId46, WordNumber.Create(6).Value, Text.Create("station?").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("83b288db-82cd-4af4-a50e-a155ea33e4d1")), ExerciseId47, WordNumber.Create(1).Value, Text.Create("You").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("8be099e9-4c51-4a1a-bc5d-1a7d8a6ecfc9")), ExerciseId47, WordNumber.Create(2).Value, Text.Create("will not").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("9ecae500-6486-4150-af21-e9342099d63d")), ExerciseId47, WordNumber.Create(3).Value, Text.Create("out").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("a9139f63-b421-48e5-b57e-9e6cbb981335")), ExerciseId47, WordNumber.Create(4).Value, Text.Create("of").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("5da1971f-eebb-426f-bb84-3169140f44af")), ExerciseId47, WordNumber.Create(5).Value, Text.Create("from").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("5000f800-ca2c-4d13-a662-4ffea05ca8af")), ExerciseId47, WordNumber.Create(6).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("d0df1f36-e28c-4294-a777-a5d8cdfdccfa")), ExerciseId47, WordNumber.Create(7).Value, Text.Create("garden.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("9ef2fedb-1ef1-44e4-838c-81b6b133c4d9")), ExerciseId48, WordNumber.Create(1).Value, Text.Create("There").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("0a134ca9-847d-44cb-9ed3-4e501082218a")), ExerciseId48, WordNumber.Create(2).Value, Text.Create("won't").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("703a1892-9825-4098-be7b-6f84dcee99ea")), ExerciseId48, WordNumber.Create(3).Value, Text.Create("be").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("1711493d-98bf-4a8a-b332-b3cd3b32c952")), ExerciseId48, WordNumber.Create(4).Value, Text.Create("cupboards").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("e618cd1b-7e69-4a4f-81a0-5d6ef3a49ebf")), ExerciseId48, WordNumber.Create(5).Value, Text.Create("in").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("9e1232c7-afe0-4b98-8611-cef575ba0287")), ExerciseId48, WordNumber.Create(6).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("965a710f-7c23-44b0-a714-aaa668453c9f")), ExerciseId48, WordNumber.Create(7).Value, Text.Create("room.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("ed3a4cbb-e41d-4c14-acc8-3de98d3759d1")), ExerciseId49, WordNumber.Create(1).Value, Text.Create("There").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("6e763f8f-89c5-4689-87af-422682c01d6c")), ExerciseId49, WordNumber.Create(2).Value, Text.Create("will").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("18ae7dc8-e658-472a-a0e8-ec70c652ba19")), ExerciseId49, WordNumber.Create(3).Value, Text.Create("be").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("30dff33b-5d00-4ecb-b9bf-b416c8f09d3d")), ExerciseId49, WordNumber.Create(4).Value, Text.Create("a").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("27f25c91-155d-47b4-8bf2-efaaa27df03d")), ExerciseId49, WordNumber.Create(5).Value, Text.Create("cup").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("e148b86c-f415-4535-b29e-387e7c0bee39")), ExerciseId49, WordNumber.Create(6).Value, Text.Create("on").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("6460ee32-2853-4473-a201-3e2224e43e8d")), ExerciseId49, WordNumber.Create(7).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("32491f9a-68ce-4e50-a4fa-d1c80b3b754d")), ExerciseId49, WordNumber.Create(8).Value, Text.Create("windowsill.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("056f0cf0-591e-4198-9705-98c6b3fdf54f")), ExerciseId50, WordNumber.Create(1).Value, Text.Create("Were").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("eb914b69-abea-449a-b6da-94c97205dbc6")), ExerciseId50, WordNumber.Create(2).Value, Text.Create("there").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("f15fd353-be99-43d1-8702-870ff329dede")), ExerciseId50, WordNumber.Create(3).Value, Text.Create("glasses").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("2908b049-1a88-4e33-8203-2790d07d101e")), ExerciseId50, WordNumber.Create(4).Value, Text.Create("under").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("f8802137-c2ad-4612-ba4e-e4ec60429fbc")), ExerciseId50, WordNumber.Create(5).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("3af1a8f4-d043-4560-98e0-e961f621dea5")), ExerciseId50, WordNumber.Create(6).Value, Text.Create("table?").Value, WordType.Noun),

            #endregion

            #region Lesson 11

            Word.Create(WordId.Create(Guid.Parse("821a3374-ff1a-43a7-8424-e0acb0da3668")), ExerciseId51, WordNumber.Create(1).Value, Text.Create("We").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("c0c30d04-37a1-474d-b131-34d819f65972")), ExerciseId51, WordNumber.Create(2).Value, Text.Create("mustn't").Value, WordType.ModalVerb),
            Word.Create(WordId.Create(Guid.Parse("8fe5d0ba-5fb2-416c-8df7-effe5df4a477")), ExerciseId51, WordNumber.Create(3).Value, Text.Create("feel.").Value, WordType.Verb),

            Word.Create(WordId.Create(Guid.Parse("708347f3-e9b7-41e4-b8b4-4138722654d4")), ExerciseId52, WordNumber.Create(1).Value, Text.Create("Should").Value, WordType.ModalVerb),
            Word.Create(WordId.Create(Guid.Parse("76c2297a-a2b1-456f-9d4a-5ab2682638b8")), ExerciseId52, WordNumber.Create(2).Value, Text.Create("I").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("e718d0f2-f245-4dec-993f-1f4e21c93509")), ExerciseId52, WordNumber.Create(3).Value, Text.Create("stand?").Value, WordType.Verb),

            Word.Create(WordId.Create(Guid.Parse("733d0bbc-8270-4caf-a24f-963329e67456")), ExerciseId53, WordNumber.Create(1).Value, Text.Create("We").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("b2154e46-0751-45a3-a04b-1854e5354e1f")), ExerciseId53, WordNumber.Create(2).Value, Text.Create("can").Value, WordType.ModalVerb),
            Word.Create(WordId.Create(Guid.Parse("c8e17935-e205-4d65-b086-6b476c3f5e5b")), ExerciseId53, WordNumber.Create(3).Value, Text.Create("close.").Value, WordType.Verb),

            Word.Create(WordId.Create(Guid.Parse("92c54277-2d4f-44cc-b95b-a940909454fd")), ExerciseId54, WordNumber.Create(1).Value, Text.Create("We").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("02ca9313-988c-4fef-8230-cd3af412a935")), ExerciseId54, WordNumber.Create(2).Value, Text.Create("didn't").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("40b5eeb0-a9ed-4ba4-a360-f74be0e61c9f")), ExerciseId54, WordNumber.Create(3).Value, Text.Create("show.").Value, WordType.Verb),

            Word.Create(WordId.Create(Guid.Parse("1f9e4303-1f37-4528-bbd8-be19237a2f12")), ExerciseId55, WordNumber.Create(1).Value, Text.Create("She").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("81b8079b-2f6b-4063-b3e1-ba1de92ead70")), ExerciseId55, WordNumber.Create(2).Value, Text.Create("must not").Value, WordType.ModalVerb),
            Word.Create(WordId.Create(Guid.Parse("6dfded7a-b11c-49ef-abc8-85933c988f71")), ExerciseId55, WordNumber.Create(3).Value, Text.Create("answer.").Value, WordType.Verb),

            #endregion

            #region Lesson 12

            Word.Create(WordId.Create(Guid.Parse("3bb4cc15-9de1-418a-a77c-eeb97022aeea")), ExerciseId56, WordNumber.Create(1).Value, Text.Create("He").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("717bae65-4abe-413a-9732-a242710dbbbf")), ExerciseId56, WordNumber.Create(2).Value, Text.Create("was").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("a8283f88-bd52-45b9-b4a1-1c71665293c5")), ExerciseId56, WordNumber.Create(3).Value, Text.Create("reading").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("0f284ba6-695f-48b1-bf8d-668b78dc0695")), ExerciseId56, WordNumber.Create(4).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("5bdc5e76-b828-4573-ace4-657774403822")), ExerciseId56, WordNumber.Create(5).Value, Text.Create("letter").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("fac3b393-3b10-49c3-af64-9b72c2213e7e")), ExerciseId56, WordNumber.Create(6).Value, Text.Create("from").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("51208adb-93ea-4db5-ac32-67eaea7bd131")), ExerciseId56, WordNumber.Create(7).Value, Text.Create("four").Value, WordType.LetterNumber),
            Word.Create(WordId.Create(Guid.Parse("a24f2e94-143d-4ef8-8a7e-c68df91d19db")), ExerciseId56, WordNumber.Create(8).Value, Text.Create("to").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("93ab2fa6-2a8a-46c8-b5c2-7cb99abac0b0")), ExerciseId56, WordNumber.Create(9).Value, Text.Create("ten").Value, WordType.LetterNumber),
            Word.Create(WordId.Create(Guid.Parse("732a3832-113c-4ba7-a746-6bb670c93ffd")), ExerciseId56, WordNumber.Create(10).Value, Text.Create("yesterday.").Value, WordType.Adverb),

            Word.Create(WordId.Create(Guid.Parse("16e351e1-f01d-4340-b8fc-3666b3f9a7c1")), ExerciseId57, WordNumber.Create(1).Value, Text.Create("We").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("c2c63cbc-f682-49eb-8077-32cb297cedae")), ExerciseId57, WordNumber.Create(2).Value, Text.Create("were").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("09b1a15c-4b9a-4967-9da8-b8c3b72e491a")), ExerciseId57, WordNumber.Create(3).Value, Text.Create("answering").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("fcad16cf-d55a-4da8-bec2-bf9e3b5efdb6")), ExerciseId57, WordNumber.Create(4).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("266558c2-e7d4-4e5f-8cd3-7eafdf2011f2")), ExerciseId57, WordNumber.Create(5).Value, Text.Create("letter").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("a6b9f574-129e-4fb5-aa39-3e34283201e7")), ExerciseId57, WordNumber.Create(6).Value, Text.Create("at").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("c6e79d64-6e7e-46e4-909c-23a6ad4d1a50")), ExerciseId57, WordNumber.Create(7).Value, Text.Create("four").Value, WordType.LetterNumber),
            Word.Create(WordId.Create(Guid.Parse("00930476-cad8-45f0-9c94-65b0f42520ea")), ExerciseId57, WordNumber.Create(8).Value, Text.Create("yesterday.").Value, WordType.Adverb),

            Word.Create(WordId.Create(Guid.Parse("3bddcffb-8d45-46e9-8e31-2c7f727bc520")), ExerciseId58, WordNumber.Create(1).Value, Text.Create("You").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("34f99364-0c8d-499d-a9b1-e210c6b44403")), ExerciseId58, WordNumber.Create(2).Value, Text.Create("are").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("c0056a8c-cc43-4569-b34f-9b3497b41029")), ExerciseId58, WordNumber.Create(3).Value, Text.Create("feeling").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("27537960-216d-4b1d-8bb4-78439eac8a60")), ExerciseId58, WordNumber.Create(4).Value, Text.Create("bad").Value, WordType.Adjective),
            Word.Create(WordId.Create(Guid.Parse("2b80d104-f9ae-4578-b78a-57a163208e09")), ExerciseId58, WordNumber.Create(5).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("a765dcca-5242-42a4-94f7-a654cb5dd7ef")), ExerciseId58, WordNumber.Create(6).Value, Text.Create("whole").Value, WordType.Adjective),
            Word.Create(WordId.Create(Guid.Parse("6a09af9a-18b7-4d87-9b51-71dc5dda39df")), ExerciseId58, WordNumber.Create(7).Value, Text.Create("day").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("3a6a0336-a316-40be-a931-19f9b334d814")), ExerciseId58, WordNumber.Create(8).Value, Text.Create("today.").Value, WordType.Adverb),

            Word.Create(WordId.Create(Guid.Parse("b26814e0-0e0b-4c6c-b93f-e2cc674be21c")), ExerciseId59, WordNumber.Create(1).Value, Text.Create("We").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("73414b2c-a7d9-4dd3-91f6-88dc99bcb8a8")), ExerciseId59, WordNumber.Create(2).Value, Text.Create("were").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("52e7aad3-30ca-44fa-a8a4-2b88f61772c1")), ExerciseId59, WordNumber.Create(3).Value, Text.Create("studying").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("06dd14cd-f87d-457e-981f-da4b24a175c5")), ExerciseId59, WordNumber.Create(4).Value, Text.Create("French").Value, WordType.Language),
            Word.Create(WordId.Create(Guid.Parse("a26e0aae-5201-4f4f-aecb-0adf47c74dd1")), ExerciseId59, WordNumber.Create(5).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("f78b432e-007b-4e1d-b9eb-e663be27e11d")), ExerciseId59, WordNumber.Create(6).Value, Text.Create("whole").Value, WordType.Adjective),
            Word.Create(WordId.Create(Guid.Parse("50eb0628-d989-4161-989a-5ba449cde161")), ExerciseId59, WordNumber.Create(7).Value, Text.Create("day").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("b757718e-32ba-483a-b6e0-3ad09330d603")), ExerciseId59, WordNumber.Create(8).Value, Text.Create("yesterday.").Value, WordType.Preposition),

            Word.Create(WordId.Create(Guid.Parse("da1a916c-9f90-436b-9b8c-896b7b952435")), ExerciseId60, WordNumber.Create(1).Value, Text.Create("You").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("c4fc906c-188c-4a35-bf5f-ea8c991d9b19")), ExerciseId60, WordNumber.Create(2).Value, Text.Create("will").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("3f1101d0-303f-4d6e-97df-6c7b015db54a")), ExerciseId60, WordNumber.Create(3).Value, Text.Create("be").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("0ed11e4c-f7b3-4ebc-b1e2-62036f8343e0")), ExerciseId60, WordNumber.Create(4).Value, Text.Create("reading").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("109005e2-5471-468a-96c5-6625f69a47ba")), ExerciseId60, WordNumber.Create(5).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("cf050a5b-1c69-43ec-b110-0cb50866f53e")), ExerciseId60, WordNumber.Create(6).Value, Text.Create("book").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("8908d843-f524-47cb-b23e-643c2ed0c3b0")), ExerciseId60, WordNumber.Create(7).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("346a689f-179a-4643-a365-cbed0d294228")), ExerciseId60, WordNumber.Create(8).Value, Text.Create("whole").Value, WordType.Adjective),
            Word.Create(WordId.Create(Guid.Parse("79d81445-9365-42b8-80e5-e4908b29548d")), ExerciseId60, WordNumber.Create(9).Value, Text.Create("day").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("5c855ee6-4516-4d05-acae-d1ef64f8d529")), ExerciseId60, WordNumber.Create(10).Value, Text.Create("tomorrow.").Value, WordType.Adverb),

            #endregion

            #region Lesson 13

            Word.Create(WordId.Create(Guid.Parse("00b45f27-32f5-427d-a867-0bd86ca686f6")), ExerciseId61, WordNumber.Create(1).Value, Text.Create("Am").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("5028e234-1f5d-4ba6-aa05-f1b16486aaad")), ExerciseId61, WordNumber.Create(2).Value, Text.Create("I").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("3f096855-0418-4441-b5ad-7ed25e4004a2")), ExerciseId61, WordNumber.Create(3).Value, Text.Create("cold?").Value, WordType.Adjective),

            Word.Create(WordId.Create(Guid.Parse("f272d9e5-c74b-406b-8ee7-49bc219fb236")), ExerciseId62, WordNumber.Create(1).Value, Text.Create("I").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("f2d24856-7142-4f63-a3ee-cc0075bc049d")), ExerciseId62, WordNumber.Create(2).Value, Text.Create("do not").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("278c23b6-05bd-4754-b429-497912a42875")), ExerciseId62, WordNumber.Create(3).Value, Text.Create("have").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("f18fa01b-f2ab-403f-839e-b309cae77257")), ExerciseId62, WordNumber.Create(4).Value, Text.Create("blue").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("71af8e78-182c-48fe-ade6-a27017651d8a")), ExerciseId62, WordNumber.Create(5).Value, Text.Create("eyes.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("d7439311-90f3-4a2f-96fc-43601117cfdb")), ExerciseId63, WordNumber.Create(1).Value, Text.Create("You").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("986fcb90-274c-47d9-b70c-11a84413ae47")), ExerciseId63, WordNumber.Create(2).Value, Text.Create("are").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("8e55a6ff-fe4d-4f28-986a-918ab9cfbebd")), ExerciseId63, WordNumber.Create(3).Value, Text.Create("healthy.").Value, WordType.Adjective),

            Word.Create(WordId.Create(Guid.Parse("6e2bba52-4ff8-4d86-a0ba-1e3c4be4060a")), ExerciseId64, WordNumber.Create(1).Value, Text.Create("It").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("2f209651-2072-46c1-92c6-e3129812872e")), ExerciseId64, WordNumber.Create(2).Value, Text.Create("was").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("3edef03f-2c5c-405d-8e66-347bc84cf25c")), ExerciseId64, WordNumber.Create(3).Value, Text.Create("hot").Value, WordType.Adjective),
            Word.Create(WordId.Create(Guid.Parse("00fc0a5b-42da-4d88-a23b-204ee9da7690")), ExerciseId64, WordNumber.Create(4).Value, Text.Create("yesterday.").Value, WordType.Adverb),

            Word.Create(WordId.Create(Guid.Parse("3d94a2f9-d946-4442-adcc-1853c18a2a66")), ExerciseId65, WordNumber.Create(1).Value, Text.Create("She").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("88eadca0-4df9-4cae-b62a-499308be8000")), ExerciseId65, WordNumber.Create(2).Value, Text.Create("is").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("6602a985-8f69-42f4-8613-b9276301aafa")), ExerciseId65, WordNumber.Create(3).Value, Text.Create("adult.").Value, WordType.Adjective),

            #endregion

            #region Lesson 14

            Word.Create(WordId.Create(Guid.Parse("bd49617f-3d0c-4523-8dbd-8f547533bf15")), ExerciseId66, WordNumber.Create(1).Value, Text.Create("Run").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("6e9772b5-74dd-43f3-98ce-788a00e14b54")), ExerciseId66, WordNumber.Create(2).Value, Text.Create("to").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("707783fe-97c0-4dba-bb21-aa2d52123af3")), ExerciseId66, WordNumber.Create(3).Value, Text.Create("her.").Value, WordType.Pronoun),

            Word.Create(WordId.Create(Guid.Parse("12d0d824-b5fa-4b8d-8850-e13c7633b236")), ExerciseId67, WordNumber.Create(1).Value, Text.Create("Don't").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("07bb3b2e-6642-4d2e-9892-1b82bbfa6552")), ExerciseId67, WordNumber.Create(2).Value, Text.Create("turn").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("c06e0c2f-0698-4542-9287-396df1ca1da7")), ExerciseId67, WordNumber.Create(3).Value, Text.Create("his").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("d35cd03c-752a-4e8a-8151-157206a10e04")), ExerciseId67, WordNumber.Create(4).Value, Text.Create("nightstand.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("f4864def-5bf0-4807-82de-0fcf4b5035cf")), ExerciseId68, WordNumber.Create(1).Value, Text.Create("Don't").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("66bc5768-f578-44f3-b926-b189a362362a")), ExerciseId68, WordNumber.Create(2).Value, Text.Create("take").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("0a8af533-0355-4a81-9986-ab4672c21216")), ExerciseId68, WordNumber.Create(3).Value, Text.Create("my").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("397ac297-9bf8-4043-ad0d-1fe48ccbb92a")), ExerciseId68, WordNumber.Create(4).Value, Text.Create("tablet.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("f16ac678-bb42-49a9-8384-c73dfff9031b")), ExerciseId69, WordNumber.Create(1).Value, Text.Create("Remember").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("fb0b9918-ce22-45c6-a897-b238a9ae752f")), ExerciseId69, WordNumber.Create(2).Value, Text.Create("about").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("21808835-84a9-4e8c-b3c2-563e6be681c4")), ExerciseId69, WordNumber.Create(3).Value, Text.Create("us.").Value, WordType.Pronoun),

            Word.Create(WordId.Create(Guid.Parse("fb1a905d-8041-4c96-a90e-15351471b676")), ExerciseId70, WordNumber.Create(1).Value, Text.Create("Let").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("d111f79c-9d1a-4673-89fb-725b2e8ca290")), ExerciseId70, WordNumber.Create(2).Value, Text.Create("him").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("be28a592-e7b7-4872-a654-dc6c67601984")), ExerciseId70, WordNumber.Create(3).Value, Text.Create("answer.").Value, WordType.Verb),

            #endregion

            #region Lesson 15

            Word.Create(WordId.Create(Guid.Parse("a12a96c4-7af0-4a61-b87d-5c6ebf9e074c")), ExerciseId71, WordNumber.Create(1).Value, Text.Create("He").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("75f8a4ab-c767-4157-896c-fc84eae79a95")), ExerciseId71, WordNumber.Create(2).Value, Text.Create("took").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("8aa66574-fa04-4662-8eeb-a9da3d191e6d")), ExerciseId71, WordNumber.Create(3).Value, Text.Create("off").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("3f9dd1fa-a471-429c-9dae-7b04978c8c01")), ExerciseId71, WordNumber.Create(4).Value, Text.Create("weight.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("27315754-f175-442f-9dd6-bd085d5671a4")), ExerciseId72, WordNumber.Create(1).Value, Text.Create("Your").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("b9557d81-8a3d-4c6d-b710-d691aea4cc29")), ExerciseId72, WordNumber.Create(2).Value, Text.Create("son").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("857e0dc5-fb65-413b-971a-ddd902925cb2")), ExerciseId72, WordNumber.Create(3).Value, Text.Create("asks").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("406c1a27-235a-4a65-aa5a-a67696bd2c15")), ExerciseId72, WordNumber.Create(4).Value, Text.Create("to").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("de8d2200-13dc-4484-ad75-49d52d913176")), ExerciseId72, WordNumber.Create(5).Value, Text.Create("turn").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("dd0210f2-e619-4378-827a-b9615e1a961f")), ExerciseId72, WordNumber.Create(6).Value, Text.Create("on").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("a9b9a516-fb52-45e0-a505-06d4c90212d3")), ExerciseId72, WordNumber.Create(7).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("21224da0-d994-43bc-a255-de2196e45fe8")), ExerciseId72, WordNumber.Create(8).Value, Text.Create("light.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("7d12de65-1ed1-4ff4-b370-48431ed33498")), ExerciseId73, WordNumber.Create(1).Value, Text.Create("He").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("7a5d6144-892c-44f3-9923-4e6acc1942dc")), ExerciseId73, WordNumber.Create(2).Value, Text.Create("went").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("3aea664c-3b78-41b2-b46d-2bab83fac782")), ExerciseId73, WordNumber.Create(3).Value, Text.Create("down").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("c919c16a-3a03-4ece-b9f3-0b1232ccfc9c")), ExerciseId73, WordNumber.Create(4).Value, Text.Create("with").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("f520eb5d-a149-4501-b81b-b91755d8e824")), ExerciseId73, WordNumber.Create(5).Value, Text.Create("pneumonia.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("59ca1c35-0b5a-4f84-b93d-c913790ce636")), ExerciseId74, WordNumber.Create(1).Value, Text.Create("He").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("43c4cac2-8fdb-46e2-83ee-0b01b6fb3cfa")), ExerciseId74, WordNumber.Create(2).Value, Text.Create("broke").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("72742f65-67dd-4c57-8449-b5b5a1609764")), ExerciseId74, WordNumber.Create(3).Value, Text.Create("down").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("cfecd9cb-64fa-4eb3-b28c-de174daece9a")), ExerciseId74, WordNumber.Create(4).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("bdd1e3bd-34ed-4087-998b-672a0f7c4541")), ExerciseId74, WordNumber.Create(5).Value, Text.Create("door.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("13384cfa-cc62-45c8-81a9-19730a767842")), ExerciseId75, WordNumber.Create(1).Value, Text.Create("The").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("88b94e99-be58-4865-9a81-91a69665b91a")), ExerciseId75, WordNumber.Create(2).Value, Text.Create("prices").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("b46e68ab-8087-42b0-8cbb-67c40c6cbd92")), ExerciseId75, WordNumber.Create(3).Value, Text.Create("never").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("dd03b987-abe4-4fc5-a039-84acbc0d0f9d")), ExerciseId75, WordNumber.Create(4).Value, Text.Create("go").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("1c3bc0ab-948d-4ff3-8b5b-b379c8f17ef2")), ExerciseId75, WordNumber.Create(5).Value, Text.Create("down.").Value, WordType.Preposition),

            #endregion

            #region Lesson 16

            Word.Create(WordId.Create(Guid.Parse("f93241d6-78c5-4020-b05b-6653482395d9")), ExerciseId76, WordNumber.Create(1).Value, Text.Create("He").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("8b2b57b7-4263-497d-8717-39a153ba8868")), ExerciseId76, WordNumber.Create(2).Value, Text.Create("has").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("331879de-0917-43c8-a806-ca25a5b7ee26")), ExerciseId76, WordNumber.Create(3).Value, Text.Create("just").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("5b07930a-b5a9-4dc5-9b90-ccb7a9dc72d5")), ExerciseId76, WordNumber.Create(4).Value, Text.Create("gone").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("16c5a294-672c-475a-9f25-861bb940bcf2")), ExerciseId76, WordNumber.Create(5).Value, Text.Create("out.").Value, WordType.Adverb),

            Word.Create(WordId.Create(Guid.Parse("0cd86ba6-a639-44c0-a3a7-52b21d8d1db8")), ExerciseId77, WordNumber.Create(1).Value, Text.Create("I").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("9560026b-c0da-4560-b900-1b9a98a5481b")), ExerciseId77, WordNumber.Create(2).Value, Text.Create("think").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("f3745df6-34fe-4893-b49e-d2df69ab9b41")), ExerciseId77, WordNumber.Create(3).Value, Text.Create("I").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("4e9ab62c-6b49-4c0f-b133-d29769a87875")), ExerciseId77, WordNumber.Create(4).Value, Text.Create("have").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("46b64731-f69e-4a76-b4e8-a04b5463f31e")), ExerciseId77, WordNumber.Create(5).Value, Text.Create("seen").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("6b1a7094-a595-47a1-bb02-d27157f8b986")), ExerciseId77, WordNumber.Create(6).Value, Text.Create("you").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("bab59bca-4e8b-4c2b-807a-ec596eafc734")), ExerciseId77, WordNumber.Create(7).Value, Text.Create("somewhere.").Value, WordType.Compound),

            Word.Create(WordId.Create(Guid.Parse("3ba53ff9-55ec-47a8-bda4-7b2b3bfe7eef")), ExerciseId78, WordNumber.Create(1).Value, Text.Create("I").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("882ace04-92bf-49a8-a68d-2905e2ac9bcc")), ExerciseId78, WordNumber.Create(2).Value, Text.Create("have").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("bd43afaf-827c-4096-be24-ec2845221394")), ExerciseId78, WordNumber.Create(3).Value, Text.Create("done").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("cd2d0845-0303-49a1-888f-0dc5618b18bf")), ExerciseId78, WordNumber.Create(4).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("9cb3c19c-6e84-44c7-a01f-e963f5fa9f99")), ExerciseId78, WordNumber.Create(5).Value, Text.Create("work.").Value, WordType.Verb),

            Word.Create(WordId.Create(Guid.Parse("569920d1-aac7-4344-b056-807b8ca638c9")), ExerciseId79, WordNumber.Create(1).Value, Text.Create("I").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("a5189a67-94f4-4a67-8257-ee31411406f4")), ExerciseId79, WordNumber.Create(2).Value, Text.Create("have").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("77847680-fa92-4498-a05a-98136ff91d59")), ExerciseId79, WordNumber.Create(3).Value, Text.Create("already").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("fbeb86a4-bba8-46d7-8838-080c7e13a1e3")), ExerciseId79, WordNumber.Create(4).Value, Text.Create("written").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("a5bfb23c-14b6-4c03-a629-bacb408a0f95")), ExerciseId79, WordNumber.Create(5).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("40c59511-ba4d-415a-a077-36787b60a24d")), ExerciseId79, WordNumber.Create(6).Value, Text.Create("letter").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("dcf30dce-4ec1-42b1-b2e1-518854731a86")), ExerciseId79, WordNumber.Create(7).Value, Text.Create("to").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("b0c1fc1f-26c9-4f2d-a5a4-486098cbffbd")), ExerciseId79, WordNumber.Create(8).Value, Text.Create("my").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("627d6fbd-7f21-4ea0-abf3-3bd8a2b35dd9")), ExerciseId79, WordNumber.Create(9).Value, Text.Create("friend.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("e243f48b-051e-43d2-b040-b785a4c6a8f1")), ExerciseId80, WordNumber.Create(1).Value, Text.Create("He").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("da209dfa-7ece-45fe-a40a-58e9190f9f11")), ExerciseId80, WordNumber.Create(2).Value, Text.Create("has").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("6453673f-5504-4ab4-b8e2-7c24f203de86")), ExerciseId80, WordNumber.Create(3).Value, Text.Create("just").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("d3d90704-52a5-4985-8c2d-8c0ad5fe0ae8")), ExerciseId80, WordNumber.Create(4).Value, Text.Create("visited").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("c72b38c0-40fd-4086-9fa7-e612e834bf7f")), ExerciseId80, WordNumber.Create(5).Value, Text.Create("this").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("115c85d6-1c60-425a-bb69-f057d4261682")), ExerciseId80, WordNumber.Create(6).Value, Text.Create("supermarket.").Value, WordType.Noun),

            #endregion

            #region Lesson 17

            Word.Create(WordId.Create(Guid.Parse("53f5e181-64e5-43c0-9562-5cbea6811051")), ExerciseId81, WordNumber.Create(1).Value, Text.Create("I").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("efeb3f87-7d88-4ad9-bc46-cba105941cea")), ExerciseId81, WordNumber.Create(2).Value, Text.Create("had not").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("1a4a7b7f-d800-4e59-a3a5-eff18fd0a7b4")), ExerciseId81, WordNumber.Create(3).Value, Text.Create("finished").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("d796e8d7-3a26-4aee-ae1b-9303dae5354e")), ExerciseId81, WordNumber.Create(4).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("7dcce746-1b9b-404a-bc7f-6144dd47998c")), ExerciseId81, WordNumber.Create(5).Value, Text.Create("project").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("f1bcf935-7ef2-4db6-9d04-4dcf0a065bfd")), ExerciseId81, WordNumber.Create(6).Value, Text.Create("by").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("aa95c2f3-14ae-488d-86ba-c2429d3ae115")), ExerciseId81, WordNumber.Create(7).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("38425870-c577-4f40-a441-137a9d7aa79e")), ExerciseId81, WordNumber.Create(8).Value, Text.Create("beginning").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("567b7275-6054-4e4a-94a6-e288f8363cdf")), ExerciseId81, WordNumber.Create(9).Value, Text.Create("of").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("ee0ebe02-9cf1-4ea8-9e3f-83de2064860e")), ExerciseId81, WordNumber.Create(10).Value, Text.Create("that").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("0ed3f0d2-3aff-455e-b43d-5fc51d677801")), ExerciseId81, WordNumber.Create(11).Value, Text.Create("week.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("6588c771-0bb9-4f04-9bba-30f92b2cbf94")), ExerciseId82, WordNumber.Create(1).Value, Text.Create("Had").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("4177d8d8-ab32-4267-8139-53e959a69a1f")), ExerciseId82, WordNumber.Create(2).Value, Text.Create("he").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("b7f428e2-fffc-4b63-a110-4e25b95a1391")), ExerciseId82, WordNumber.Create(3).Value, Text.Create("done").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("e36558c1-ac77-4399-9ead-686c02901a55")), ExerciseId82, WordNumber.Create(4).Value, Text.Create("his").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("38f47fd9-8c91-42fa-a53a-42e3f773b649")), ExerciseId82, WordNumber.Create(5).Value, Text.Create("homework").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("ad29c2b0-e30c-4325-9266-8014862f73e1")), ExerciseId82, WordNumber.Create(6).Value, Text.Create("before").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("96eb6e4f-b46c-471f-ad4a-3a3412960b91")), ExerciseId82, WordNumber.Create(7).Value, Text.Create("his").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("9fadd129-9cfa-4d26-a8bd-1a3065174a0c")), ExerciseId82, WordNumber.Create(8).Value, Text.Create("parents").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("56b5f97a-705c-4156-a3ef-5295d50c8e02")), ExerciseId82, WordNumber.Create(9).Value, Text.Create("returned").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("e8daa7d5-86d5-4b6d-9352-e4330224d7ed")), ExerciseId82, WordNumber.Create(10).Value, Text.Create("home?").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("2efb2dc7-921d-49d8-98af-316f9d06e3ef")), ExerciseId83, WordNumber.Create(1).Value, Text.Create("Had").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("424da8c5-d636-449e-b413-0ff958d02fb6")), ExerciseId83, WordNumber.Create(2).Value, Text.Create("he").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("b87b2423-28a2-4462-839f-317a9243a02b")), ExerciseId83, WordNumber.Create(3).Value, Text.Create("written").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("2075c28d-c8f0-47ce-afec-6076439c2414")), ExerciseId83, WordNumber.Create(4).Value, Text.Create("a").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("8707ff38-f985-4c03-b1bd-c3aa5b1d1a39")), ExerciseId83, WordNumber.Create(5).Value, Text.Create("letter,").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("5a1c413a-13a0-42ef-b411-032cc7e4c6bb")), ExerciseId83, WordNumber.Create(6).Value, Text.Create("when").Value, WordType.QuestionWord),
            Word.Create(WordId.Create(Guid.Parse("b9df8bf4-f2d8-43d8-bf99-692fe80161a2")), ExerciseId83, WordNumber.Create(7).Value, Text.Create("you").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("62ac119a-e639-4f67-9f3e-55fa6d7cd5b8")), ExerciseId83, WordNumber.Create(8).Value, Text.Create("came").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("df08a6cb-a92b-43b5-aa3b-12684a6b4713")), ExerciseId83, WordNumber.Create(9).Value, Text.Create("in?").Value, WordType.Preposition),

            Word.Create(WordId.Create(Guid.Parse("8d193de8-5148-418e-b0f4-9178cb91c947")), ExerciseId84, WordNumber.Create(1).Value, Text.Create("You").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("e71ff896-63a5-40da-b17d-7e2bb4f7564f")), ExerciseId84, WordNumber.Create(2).Value, Text.Create("had").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("1f0996b6-e2eb-42d9-9052-002893d9ef5e")), ExerciseId84, WordNumber.Create(3).Value, Text.Create("returned").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("2fe50cce-1c56-4de6-8453-8f2ed7108ec8")), ExerciseId84, WordNumber.Create(4).Value, Text.Create("home").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("03074cc6-d5c2-4e6a-bd88-4a9d48442afa")), ExerciseId84, WordNumber.Create(5).Value, Text.Create("before").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("d84d576b-6a48-4fca-9052-06a5e19377f0")), ExerciseId84, WordNumber.Create(6).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("99beea68-6adb-460d-87c7-62a1f904cd39")), ExerciseId84, WordNumber.Create(7).Value, Text.Create("rain").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("1eaafcba-b844-4a54-b4df-4188c0030e58")), ExerciseId84, WordNumber.Create(8).Value, Text.Create("began.").Value, WordType.Verb),

            Word.Create(WordId.Create(Guid.Parse("e562a31e-7a9b-4350-ad1f-d0faadb9fc5c")), ExerciseId85, WordNumber.Create(1).Value, Text.Create("When").Value, WordType.QuestionWord),
            Word.Create(WordId.Create(Guid.Parse("d1910ef9-a38c-43eb-b6da-1d8959484df4")), ExerciseId85, WordNumber.Create(2).Value, Text.Create("we").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("f5b3308f-fad0-493a-be74-a67f4b11aaf0")), ExerciseId85, WordNumber.Create(3).Value, Text.Create("came").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("d0606c4b-b76c-4b19-a91e-19caa19e1d03")), ExerciseId85, WordNumber.Create(4).Value, Text.Create("to").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("26d06311-6cdd-4c3a-8b41-de88737744d3")), ExerciseId85, WordNumber.Create(5).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("43af24e5-74d9-4583-826d-82bf37a59326")), ExerciseId85, WordNumber.Create(6).Value, Text.Create("station").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("6ecd7193-0683-415a-86a8-074fffd57091")), ExerciseId85, WordNumber.Create(7).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("f6fa9365-7360-4270-9a79-f24684e6ab84")), ExerciseId85, WordNumber.Create(8).Value, Text.Create("train").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("68f9e3b5-e5ce-4c11-ab67-db2691b0df64")), ExerciseId85, WordNumber.Create(9).Value, Text.Create("had").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("ec7eee20-b872-44f3-9a95-63f4b8c57889")), ExerciseId85, WordNumber.Create(10).Value, Text.Create("already").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("69c1127c-c1b5-41f0-be18-e6d57b53e584")), ExerciseId85, WordNumber.Create(11).Value, Text.Create("gone.").Value, WordType.Verb),

            #endregion

            #region Lesson 18

            Word.Create(WordId.Create(Guid.Parse("78d4a6b6-a0ab-4fe8-96b8-fabfc0f328cb")), ExerciseId86, WordNumber.Create(1).Value, Text.Create("The").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("8f3858f2-50ab-47a2-bcb1-2cc1f45066f7")), ExerciseId86, WordNumber.Create(2).Value, Text.Create("pupils").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("05c82041-90b4-4717-afad-48d6dc9a848e")), ExerciseId86, WordNumber.Create(3).Value, Text.Create("will").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("1fb916f4-c4f3-4982-9ccf-831a2e4c7418")), ExerciseId86, WordNumber.Create(4).Value, Text.Create("have").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("f07ea390-208f-4d3c-ac88-dcda683a2a4c")), ExerciseId86, WordNumber.Create(5).Value, Text.Create("taken").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("87b5243c-e90d-412e-bb1f-3e442f84dd09")), ExerciseId86, WordNumber.Create(6).Value, Text.Create("their").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("ca6d7868-9199-4b8a-9e77-cf64a4ba3720")), ExerciseId86, WordNumber.Create(7).Value, Text.Create("seats").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("e8381a7d-cf81-46d4-a874-65a3ea8bba55")), ExerciseId86, WordNumber.Create(8).Value, Text.Create("before").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("272ab11f-0596-4785-8171-da054b2b84ef")), ExerciseId86, WordNumber.Create(9).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("ca958b36-8035-4191-b987-6a7d03621e39")), ExerciseId86, WordNumber.Create(10).Value, Text.Create("lesson").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("b7e12317-8c04-49bb-aae0-008104ebb230")), ExerciseId86, WordNumber.Create(11).Value, Text.Create("starts.").Value, WordType.Verb),

            Word.Create(WordId.Create(Guid.Parse("257f0144-0d8e-4279-a661-e9bc84cc51b9")), ExerciseId87, WordNumber.Create(1).Value, Text.Create("They").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("5472005a-376a-417e-88a3-4e0132bc1fd0")), ExerciseId87, WordNumber.Create(2).Value, Text.Create("will not").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("adc35eb2-44c3-4695-b021-a86e6ecb79b6")), ExerciseId87, WordNumber.Create(3).Value, Text.Create("have").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("106137a0-fcd2-4d3c-9e7a-ba3b5c93bd5e")), ExerciseId87, WordNumber.Create(4).Value, Text.Create("won").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("10c65254-1e4c-46a4-9920-d3e09585f7d2")), ExerciseId87, WordNumber.Create(5).Value, Text.Create("three").Value, WordType.LetterNumber),
            Word.Create(WordId.Create(Guid.Parse("72640d74-b354-4ab5-9ab2-5ea03798409a")), ExerciseId87, WordNumber.Create(6).Value, Text.Create("games").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("e19432de-97ef-4325-a04a-0cc7fc0361df")), ExerciseId87, WordNumber.Create(7).Value, Text.Create("by").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("1abb3725-60f9-450e-a554-32a4c9916434")), ExerciseId87, WordNumber.Create(8).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("4f282a23-c9c1-415e-bae1-b17560c205a0")), ExerciseId87, WordNumber.Create(9).Value, Text.Create("end").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("7bdd30d0-623f-4d51-a001-b15827933323")), ExerciseId87, WordNumber.Create(10).Value, Text.Create("of").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("50ae70f4-480e-455e-a52a-5d8d70118fce")), ExerciseId87, WordNumber.Create(11).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("f6d7f159-ec7f-4e57-aebc-2e3da141113d")), ExerciseId87, WordNumber.Create(12).Value, Text.Create("month.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("182778c2-4308-430a-bef1-51a864dd7dc8")), ExerciseId88, WordNumber.Create(1).Value, Text.Create("I").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("7c1524ad-d7cd-48d1-a364-56c5536d0ec1")), ExerciseId88, WordNumber.Create(2).Value, Text.Create("will").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("d8e6b80b-1d7a-44e3-a890-795d265aea56")), ExerciseId88, WordNumber.Create(3).Value, Text.Create("have").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("0244dfbc-7f8c-439d-b925-8f6bb16e1485")), ExerciseId88, WordNumber.Create(4).Value, Text.Create("finished").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("10f0d3a1-38f7-4056-9a5b-e582e8b92762")), ExerciseId88, WordNumber.Create(5).Value, Text.Create("this").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("aa6fa9b7-0efd-436a-8ac3-b895fa1f056b")), ExerciseId88, WordNumber.Create(6).Value, Text.Create("work,").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("8dab255b-b429-4987-8dc8-fa76cac2947c")), ExerciseId88, WordNumber.Create(7).Value, Text.Create("before").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("4696e43d-ceb4-49e6-811b-91955c83c761")), ExerciseId88, WordNumber.Create(8).Value, Text.Create("you").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("68200191-b99e-4ebb-b949-04e9e04d87c5")), ExerciseId88, WordNumber.Create(9).Value, Text.Create("return.").Value, WordType.Verb),

            Word.Create(WordId.Create(Guid.Parse("467d7c72-6c2d-44cc-a93f-a9635cc88f96")), ExerciseId89, WordNumber.Create(1).Value, Text.Create("They").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("54108911-2328-445f-bf8a-2908b6222b8f")), ExerciseId89, WordNumber.Create(2).Value, Text.Create("will not").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("ec80556b-4ba3-4bef-affa-8e1c2677329f")), ExerciseId89, WordNumber.Create(3).Value, Text.Create("have").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("1e851c92-425b-43a5-ad28-b4b69a2619b9")), ExerciseId89, WordNumber.Create(4).Value, Text.Create("shipped").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("ed204a67-aea4-4846-9cce-8ed1d7515747")), ExerciseId89, WordNumber.Create(5).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("41381c8d-ed1e-4be0-a8ce-36ed3dcd7454")), ExerciseId89, WordNumber.Create(6).Value, Text.Create("goods").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("0c3f8764-3fce-4185-93ca-8835c7f3943a")), ExerciseId89, WordNumber.Create(7).Value, Text.Create("when").Value, WordType.QuestionWord),
            Word.Create(WordId.Create(Guid.Parse("55e5d5d0-0f55-420f-b32c-ba246b59a013")), ExerciseId89, WordNumber.Create(8).Value, Text.Create("your").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("0975c2ca-c98e-4cf8-89c7-858a03a70f1f")), ExerciseId89, WordNumber.Create(9).Value, Text.Create("telegram").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("55447a54-afdb-41e3-9c03-fb7f91923d9b")), ExerciseId89, WordNumber.Create(10).Value, Text.Create("arrives.").Value, WordType.Verb),

            Word.Create(WordId.Create(Guid.Parse("21920bdb-4390-475e-beb1-10dd28a50f6c")), ExerciseId90, WordNumber.Create(1).Value, Text.Create("I").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("126ca615-6889-42c5-b8d9-7101d1e4c332")), ExerciseId90, WordNumber.Create(2).Value, Text.Create("will not").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("d8724ba4-2f9c-4fc7-80ed-5fbb6db5e1f1")), ExerciseId90, WordNumber.Create(3).Value, Text.Create("have").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("ef0d1783-fa1a-4d30-b97e-eed3059a14cf")), ExerciseId90, WordNumber.Create(4).Value, Text.Create("finished").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("4428f056-f48c-4d8e-87fe-a5a601640dde")), ExerciseId90, WordNumber.Create(5).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("14986925-f269-4656-b99c-b13ac0b92345")), ExerciseId90, WordNumber.Create(6).Value, Text.Create("report").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("a0b97346-fcf9-4317-978a-c3e0125d8c95")), ExerciseId90, WordNumber.Create(7).Value, Text.Create("by").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("85f93e77-bc2c-4379-9ced-204048d04d89")), ExerciseId90, WordNumber.Create(8).Value, Text.Create("tonight.").Value, WordType.Adverb),

            #endregion

            #region Lesson 20

            Word.Create(WordId.Create(Guid.Parse("80cbbe60-8b57-4265-910d-f593d3d1e1e1")), ExerciseId96, WordNumber.Create(1).Value, Text.Create("She").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("6cb19725-8547-41be-b0cf-224b73d08962")), ExerciseId96, WordNumber.Create(2).Value, Text.Create("has").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("6f57b3d5-f418-4a0f-8d32-75c7ff93cca1")), ExerciseId96, WordNumber.Create(3).Value, Text.Create("been").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("b17c596a-cb01-45b3-ae7c-f1d914780038")), ExerciseId96, WordNumber.Create(4).Value, Text.Create("cooking").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("94520c87-b603-4da3-b8f1-bd298c8b71a3")), ExerciseId96, WordNumber.Create(5).Value, Text.Create("dinner").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("1dad2db5-9bbc-40a6-81d5-c975797691a4")), ExerciseId96, WordNumber.Create(6).Value, Text.Create("for").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("571bd59f-17a1-42af-b60d-fd015c6b71ff")), ExerciseId96, WordNumber.Create(7).Value, Text.Create("three").Value, WordType.LetterNumber),
            Word.Create(WordId.Create(Guid.Parse("d0ee649e-bb55-45d3-894e-c2e582a67dea")), ExerciseId96, WordNumber.Create(8).Value, Text.Create("hours.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("6e9a17b3-f585-4e2c-961f-7c9453ae6eb4")), ExerciseId97, WordNumber.Create(1).Value, Text.Create("I").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("0e2adf7e-5718-4131-9769-d27eb4132832")), ExerciseId97, WordNumber.Create(2).Value, Text.Create("have").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("c5e07348-dd8e-43a6-a918-7c4da6552349")), ExerciseId97, WordNumber.Create(3).Value, Text.Create("been").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("511b4844-a417-4e7f-8dc8-18c0c2a0aa50")), ExerciseId97, WordNumber.Create(4).Value, Text.Create("baking").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("af1bc252-b150-436c-a999-069a6d0ce56e")), ExerciseId97, WordNumber.Create(5).Value, Text.Create("this").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("7c4ff47f-bac7-4490-a9b8-e530a849295b")), ExerciseId97, WordNumber.Create(6).Value, Text.Create("cake").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("418f3539-b893-4cd7-ab83-1721bd09765f")), ExerciseId97, WordNumber.Create(7).Value, Text.Create("since").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("3fa109ac-c089-4631-840d-73e0dcb27fd6")), ExerciseId97, WordNumber.Create(8).Value, Text.Create("morning.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("a71d423a-4fab-4c85-8281-0c5d03eddbd1")), ExerciseId98, WordNumber.Create(1).Value, Text.Create("The").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("205a6797-08eb-4236-af23-d9c857f8bcaa")), ExerciseId98, WordNumber.Create(2).Value, Text.Create("workers").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("25140edf-13da-495a-8c9b-bfb693d36745")), ExerciseId98, WordNumber.Create(3).Value, Text.Create("have").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("f674b880-f111-4d81-aee6-e94432f24516")), ExerciseId98, WordNumber.Create(4).Value, Text.Create("been").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("17f976fd-d7ae-44bf-90fb-240bcebc07fe")), ExerciseId98, WordNumber.Create(5).Value, Text.Create("trying").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("e91cb33e-ce06-4941-ae96-523641a27088")), ExerciseId98, WordNumber.Create(6).Value, Text.Create("to").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("f0930cf7-ec7a-4c12-a007-84c5c40afa6c")), ExerciseId98, WordNumber.Create(7).Value, Text.Create("move").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("6ba1385a-f3ef-41de-b908-39a24c86e928")), ExerciseId98, WordNumber.Create(8).Value, Text.Create("our").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("8c02c3a2-ab9b-4f50-ab11-26fcbd616ffe")), ExerciseId98, WordNumber.Create(9).Value, Text.Create("cupboard").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("99056037-c8eb-4816-8fbe-3bce4a94227e")), ExerciseId98, WordNumber.Create(10).Value, Text.Create("for").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("5e0175c1-46a1-4613-a086-5338af58b7f4")), ExerciseId98, WordNumber.Create(11).Value, Text.Create("half").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("63b7bbc3-1d51-4a74-a5d1-28264bd68e25")), ExerciseId98, WordNumber.Create(12).Value, Text.Create("an").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("7fddc484-40fe-4088-9d8d-ccb7b56d6c3a")), ExerciseId98, WordNumber.Create(13).Value, Text.Create("hour.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("88984c2a-c62d-45fe-acd7-65f2cc52d285")), ExerciseId99, WordNumber.Create(1).Value, Text.Create("I").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("325d1b77-7ca8-4d0b-93ab-2d3c2290a2e3")), ExerciseId99, WordNumber.Create(2).Value, Text.Create("have").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("7f960ca5-a42c-4c56-b719-14773543ff24")), ExerciseId99, WordNumber.Create(3).Value, Text.Create("been").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("9362d0c4-613d-40d9-8d73-51d207822a6b")), ExerciseId99, WordNumber.Create(4).Value, Text.Create("reading").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("1aa1ea46-0a6e-42cb-a02e-d595398f3571")), ExerciseId99, WordNumber.Create(5).Value, Text.Create("this").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("fd6787ae-6a52-4c29-a71b-96706a5c5dbf")), ExerciseId99, WordNumber.Create(6).Value, Text.Create("magazine").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("e781bc5a-7c2b-4407-ba9e-4eed611574bc")), ExerciseId99, WordNumber.Create(7).Value, Text.Create("since").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("64a67a58-9b09-49b6-8b2c-61bada1641a1")), ExerciseId99, WordNumber.Create(8).Value, Text.Create("I").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("077d4e4b-8096-421e-8b3b-c395ad102cee")), ExerciseId99, WordNumber.Create(9).Value, Text.Create("bought").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("8a2b49df-2961-44be-9418-da77ac0976c5")), ExerciseId99, WordNumber.Create(10).Value, Text.Create("it").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("06ab13f4-2d02-4900-87c0-0928f5f51360")), ExerciseId99, WordNumber.Create(11).Value, Text.Create("a").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("f82ffa17-fed3-4cd0-ae83-3e38551e802e")), ExerciseId99, WordNumber.Create(12).Value, Text.Create("week").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("3951278c-2862-4a8c-a2e2-dd5b977944b8")), ExerciseId99, WordNumber.Create(13).Value, Text.Create("ago.").Value, WordType.Preposition),

            Word.Create(WordId.Create(Guid.Parse("15d2b642-0e86-4abd-8047-9c2070d48ec8")), ExerciseId100, WordNumber.Create(1).Value, Text.Create("I").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("0b487945-2511-4009-b5a1-44016b67c9c3")), ExerciseId100, WordNumber.Create(2).Value, Text.Create("have").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("45e763fd-9698-4cda-8e3a-0c846f20469c")), ExerciseId100, WordNumber.Create(3).Value, Text.Create("been").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("1994f4a9-d226-43b3-843d-45b13238a8d0")), ExerciseId100, WordNumber.Create(4).Value, Text.Create("waiting").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("cbcdf1ab-5918-4c3b-89b6-354292fbebe8")), ExerciseId100, WordNumber.Create(5).Value, Text.Create("for").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("614b6550-a2e6-4a27-9893-befcc9ef8dd3")), ExerciseId100, WordNumber.Create(6).Value, Text.Create("my").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("69118498-84f0-4e60-8e13-afbbf9af39f9")), ExerciseId100, WordNumber.Create(7).Value, Text.Create("mother").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("d67d2ca6-78d8-4c78-bf4e-c65d0ada2985")), ExerciseId100, WordNumber.Create(8).Value, Text.Create("for").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("344d9f9b-d021-45c9-a03f-73330601251a")), ExerciseId100, WordNumber.Create(9).Value, Text.Create("a").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("48a95de2-b52a-4d9d-a7e8-c169ed174b50")), ExerciseId100, WordNumber.Create(10).Value, Text.Create("long").Value, WordType.Adjective),
            Word.Create(WordId.Create(Guid.Parse("2ab4b732-207e-48dd-8f0b-ee7f1ecc788c")), ExerciseId100, WordNumber.Create(11).Value, Text.Create("time.").Value, WordType.Noun),

            #endregion

            #region Lesson 21

            Word.Create(WordId.Create(Guid.Parse("85206950-44c8-475a-87af-20bbfca0e7e8")), ExerciseId101, WordNumber.Create(1).Value, Text.Create("Since").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("6caa6c3a-197c-4dcf-9c83-941852f9cba9")), ExerciseId101, WordNumber.Create(2).Value, Text.Create("then").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("b711a9d2-b56e-4a0d-98a9-6aabd414d0c3")), ExerciseId101, WordNumber.Create(3).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("de0f19dc-b5c1-4952-9284-321288837cce")), ExerciseId101, WordNumber.Create(4).Value, Text.Create("index").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("15657f6f-356e-4369-8f86-8a63358e97cb")), ExerciseId101, WordNumber.Create(5).Value, Text.Create("had").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("fc2e7517-5bd8-48e0-9c94-79fd701586fa")), ExerciseId101, WordNumber.Create(6).Value, Text.Create("been").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("8a685d1f-4ac9-48a4-bbbc-73c7b5c75e07")), ExerciseId101, WordNumber.Create(7).Value, Text.Create("rising").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("a96cd797-1c19-48fb-b547-69ea21f51b36")), ExerciseId101, WordNumber.Create(8).Value, Text.Create("fast.").Value, WordType.Adjective),

            Word.Create(WordId.Create(Guid.Parse("98d994bc-6c61-4157-bf4d-47133fac5c9b")), ExerciseId102, WordNumber.Create(1).Value, Text.Create("His").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("c453e726-c4ec-4ea1-861d-23dcb224c859")), ExerciseId102, WordNumber.Create(2).Value, Text.Create("hands").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("64b3816e-3673-46ee-91f6-0331646c9546")), ExerciseId102, WordNumber.Create(3).Value, Text.Create("were").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("47200ce2-ffd8-46b6-a126-d4d6619177e7")), ExerciseId102, WordNumber.Create(4).Value, Text.Create("dirty").Value, WordType.Adjective),
            Word.Create(WordId.Create(Guid.Parse("84c544bc-ef3b-49c1-b1ee-669b7409a242")), ExerciseId102, WordNumber.Create(5).Value, Text.Create("he").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("b910d92e-6cae-49f2-972e-b44c58b5254e")), ExerciseId102, WordNumber.Create(6).Value, Text.Create("had").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("bb4f3c70-1642-4d39-b3b4-901f6ee4aec4")), ExerciseId102, WordNumber.Create(7).Value, Text.Create("been").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("ad09eb50-8aa4-4052-8a7d-a1bf6a08ae0f")), ExerciseId102, WordNumber.Create(8).Value, Text.Create("digging.").Value, WordType.Verb),

            Word.Create(WordId.Create(Guid.Parse("7a89f0c0-4726-4fcc-b6ac-696d33a3b828")), ExerciseId103, WordNumber.Create(1).Value, Text.Create("They").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("9ecd8936-e412-4209-932e-29c4de1f6c73")), ExerciseId103, WordNumber.Create(2).Value, Text.Create("had").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("9364bf87-1c5c-4793-bfc9-c87d6ab93ac8")), ExerciseId103, WordNumber.Create(3).Value, Text.Create("been").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("282982d0-fa78-4d3d-b29b-cf4799a52629")), ExerciseId103, WordNumber.Create(4).Value, Text.Create("talking").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("c9de0e54-534b-4f03-a81c-874765f03514")), ExerciseId103, WordNumber.Create(5).Value, Text.Create("for").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("8a3301c2-50a5-4f74-ad99-ca48147293cb")), ExerciseId103, WordNumber.Create(6).Value, Text.Create("over").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("f2588784-903f-40be-a28a-83369abd6123")), ExerciseId103, WordNumber.Create(7).Value, Text.Create("an").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("aa95e8ff-cef0-4ddf-8470-f5da97cad1b6")), ExerciseId103, WordNumber.Create(8).Value, Text.Create("hour").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("0eb62f88-0d7e-4803-963e-c2384ea3e552")), ExerciseId103, WordNumber.Create(9).Value, Text.Create("before").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("755394d9-f30c-41d0-99f6-e6ee0cd7e64e")), ExerciseId103, WordNumber.Create(10).Value, Text.Create("he").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("105bbabd-2af9-4184-a4e1-04ec730d25ea")), ExerciseId103, WordNumber.Create(11).Value, Text.Create("arrived.").Value, WordType.Verb),

            Word.Create(WordId.Create(Guid.Parse("b342ac15-5b6c-48b7-9266-3ead153aaa12")), ExerciseId104, WordNumber.Create(1).Value, Text.Create("It").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("992eae82-0d76-446e-b3d5-54731d3824f8")), ExerciseId104, WordNumber.Create(2).Value, Text.Create("was").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("ec31880f-5fa7-4a59-886b-7f8c80341ad2")), ExerciseId104, WordNumber.Create(3).Value, Text.Create("one").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("6df46f7b-73a0-46c0-b9c6-2ad48a92b844")), ExerciseId104, WordNumber.Create(4).Value, Text.Create("o'clock").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("90dc8279-fff4-495b-91b1-1de83057e7c1")), ExerciseId104, WordNumber.Create(5).Value, Text.Create("and").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("6c93df96-c64e-47e5-9191-13d7a1c81c6a")), ExerciseId104, WordNumber.Create(6).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("2979814b-0445-4a11-b2f4-dcda1a7ee205")), ExerciseId104, WordNumber.Create(7).Value, Text.Create("dog").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("50d3f6b4-56ce-4544-a2db-6631a955f71e")), ExerciseId104, WordNumber.Create(8).Value, Text.Create("from").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("b47ca54c-3f96-436c-a26e-60a9bf49687e")), ExerciseId104, WordNumber.Create(9).Value, Text.Create("next").Value, WordType.Adjective),
            Word.Create(WordId.Create(Guid.Parse("93c9e9e2-2677-4860-9668-107c0833903b")), ExerciseId104, WordNumber.Create(10).Value, Text.Create("door").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("c62c0652-32d8-4f33-a678-6b979d60f449")), ExerciseId104, WordNumber.Create(11).Value, Text.Create("had").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("636edcb7-5ef1-4e45-b53d-0b31d5b96b69")), ExerciseId104, WordNumber.Create(12).Value, Text.Create("been").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("e6670a20-bcf1-4ec8-ac8a-f5786d4922b0")), ExerciseId104, WordNumber.Create(13).Value, Text.Create("barking").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("5989bdbc-c800-4c4b-8ad9-a0d748721055")), ExerciseId104, WordNumber.Create(14).Value, Text.Create("for").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("cc3f69ba-1d7b-4ee4-8730-a06a78e1d719")), ExerciseId104, WordNumber.Create(15).Value, Text.Create("two").Value, WordType.LetterNumber),
            Word.Create(WordId.Create(Guid.Parse("d99492d8-4b48-4efa-bacc-1616d69fd09f")), ExerciseId104, WordNumber.Create(16).Value, Text.Create("hours.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("b774642d-ff7c-45b7-9766-7012c2ec9110")), ExerciseId105, WordNumber.Create(1).Value, Text.Create("My").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("2ecc0edb-8923-4f0b-b3bc-fc7fea0cac17")), ExerciseId105, WordNumber.Create(2).Value, Text.Create("dog").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("779c0fa8-2745-44c6-acf0-96c93480887f")), ExerciseId105, WordNumber.Create(3).Value, Text.Create("had").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("b31eb2a5-3fa2-45bb-afdf-41cd2379ea1e")), ExerciseId105, WordNumber.Create(4).Value, Text.Create("been").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("fecc6d37-9da7-47bb-937d-bef369bd0227")), ExerciseId105, WordNumber.Create(5).Value, Text.Create("playing").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("0e56e811-2ab8-4a2c-833a-e5069b6cfd64")), ExerciseId105, WordNumber.Create(6).Value, Text.Create("for").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("3b7b1661-d85e-4670-a76b-6853ddca56f2")), ExerciseId105, WordNumber.Create(7).Value, Text.Create("half").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("d37a56a5-49ec-47f3-a865-62c38647df35")), ExerciseId105, WordNumber.Create(8).Value, Text.Create("an").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("c61c2104-9696-4445-aebb-e68b3f7d144b")), ExerciseId105, WordNumber.Create(9).Value, Text.Create("hour").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("335b8f90-a40a-487e-823b-24c6842875e4")), ExerciseId105, WordNumber.Create(10).Value, Text.Create("before").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("f19ee4a0-3f57-4763-9632-6c717208bc74")), ExerciseId105, WordNumber.Create(11).Value, Text.Create("we").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("19624bb5-3a51-499b-818d-ea6b2ca05df4")), ExerciseId105, WordNumber.Create(12).Value, Text.Create("went").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("d39d7e50-2845-408b-9709-a41a1f9f57db")), ExerciseId105, WordNumber.Create(13).Value, Text.Create("for").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("6e1c3e6f-0f1a-457e-aa9c-fb4dad48aeb2")), ExerciseId105, WordNumber.Create(14).Value, Text.Create("a").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("44de66bc-3c75-420c-b966-e0ac24760eab")), ExerciseId105, WordNumber.Create(15).Value, Text.Create("walk.").Value, WordType.Verb),

            #endregion

            #region Lesson 22

            Word.Create(WordId.Create(Guid.Parse("a4ecff29-e16c-4f92-8a06-4b9b0a36a92d")), ExerciseId106, WordNumber.Create(1).Value, Text.Create("They").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("b7333d09-b6a1-4ba7-b2dd-d610c4a3d4f5")), ExerciseId106, WordNumber.Create(2).Value, Text.Create("will").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("8c395f24-a827-4fe8-9a3f-2c01d0de99aa")), ExerciseId106, WordNumber.Create(3).Value, Text.Create("have").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("2f565b09-70ce-4d28-85fb-e892fcc6abec")), ExerciseId106, WordNumber.Create(4).Value, Text.Create("been").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("8fb50236-4857-4084-83e3-05b5cb415ae1")), ExerciseId106, WordNumber.Create(5).Value, Text.Create("talking").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("8e3f99b0-4a82-443f-a95d-8c437f3937da")), ExerciseId106, WordNumber.Create(6).Value, Text.Create("for").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("4f6a8d5c-a166-4232-a9db-ab4f47bf08c6")), ExerciseId106, WordNumber.Create(7).Value, Text.Create("over").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("5447f753-695d-4a15-8ae2-94eb510a965f")), ExerciseId106, WordNumber.Create(8).Value, Text.Create("an").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("261c9f32-5833-4df1-a585-64b8c27a4791")), ExerciseId106, WordNumber.Create(9).Value, Text.Create("hour,").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("4beea04a-465f-49fb-b46c-414ddabe7fb1")), ExerciseId106, WordNumber.Create(10).Value, Text.Create("by").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("5be87677-9b3e-4adb-bc91-7a0c7567083e")), ExerciseId106, WordNumber.Create(11).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("550fa897-6f65-4c39-ac46-705959fa78bc")), ExerciseId106, WordNumber.Create(12).Value, Text.Create("time,").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("5ab56984-f2b5-46bc-875c-8c4725e346cc")), ExerciseId106, WordNumber.Create(13).Value, Text.Create("he").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("3b51f0f8-40d5-45b1-9498-0c46c26ea8c1")), ExerciseId106, WordNumber.Create(14).Value, Text.Create("arrives.").Value, WordType.Verb),

            Word.Create(WordId.Create(Guid.Parse("c96419ff-27bf-438a-94b7-cb409e4e896b")), ExerciseId107, WordNumber.Create(1).Value, Text.Create("By").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("2ac012bc-46d3-4593-bb1c-f38920294a09")), ExerciseId107, WordNumber.Create(2).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("8ee77c3f-37c7-4789-87d3-704723cbf80f")), ExerciseId107, WordNumber.Create(3).Value, Text.Create("first").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("c046b022-8f13-40b5-8b9a-1fa20de8728f")), ExerciseId107, WordNumber.Create(4).Value, Text.Create("of").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("fcca8715-9556-4f28-97ef-20fb1a5a3976")), ExerciseId107, WordNumber.Create(5).Value, Text.Create("June").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("a9c60bf9-882e-44ef-b5f6-3b4d1ff4e457")), ExerciseId107, WordNumber.Create(6).Value, Text.Create("he").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("98815fec-3e1a-4a1e-8f32-5ee33f7a5945")), ExerciseId107, WordNumber.Create(7).Value, Text.Create("will").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("f9a73f0a-ddb6-4247-b56c-d33c1f681a29")), ExerciseId107, WordNumber.Create(8).Value, Text.Create("have").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("ef35f52c-741d-4dc9-98a2-0981f9883a14")), ExerciseId107, WordNumber.Create(9).Value, Text.Create("been").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("b24d40e1-459c-479a-975d-5b7e0b0df66f")), ExerciseId107, WordNumber.Create(10).Value, Text.Create("working").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("e9100d0f-6889-4d7f-9757-ae8ed782543e")), ExerciseId107, WordNumber.Create(11).Value, Text.Create("at").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("58c595c0-4897-4df4-a5f4-d630b29f21d9")), ExerciseId107, WordNumber.Create(12).Value, Text.Create("this").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("57fd9806-110d-4f77-8be2-cb610a0613b0")), ExerciseId107, WordNumber.Create(13).Value, Text.Create("plant").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("78da7158-ad48-469a-875d-70deba00b633")), ExerciseId107, WordNumber.Create(14).Value, Text.Create("for").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("1fbe955a-9b34-4615-9e5c-d4a26ebd9d65")), ExerciseId107, WordNumber.Create(15).Value, Text.Create("twenty").Value, WordType.LetterNumber),
            Word.Create(WordId.Create(Guid.Parse("c1ec98b3-48eb-41bd-85ca-4680b83e931d")), ExerciseId107, WordNumber.Create(16).Value, Text.Create("years.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("5a4d3130-44b3-476c-b2da-80caa428b0da")), ExerciseId108, WordNumber.Create(1).Value, Text.Create("Next").Value, WordType.Adjective),
            Word.Create(WordId.Create(Guid.Parse("f84548d3-7f7a-47c0-a4f5-0482364b15d1")), ExerciseId108, WordNumber.Create(2).Value, Text.Create("Christmas").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("bb6b1261-c761-4be3-8f41-b784ca78dba2")), ExerciseId108, WordNumber.Create(3).Value, Text.Create("I").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("c0513785-33fc-4fe9-bae6-63affaeefde3")), ExerciseId108, WordNumber.Create(4).Value, Text.Create("will").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("61e684fd-a6f4-4848-a6d6-c5325c1814a2")), ExerciseId108, WordNumber.Create(5).Value, Text.Create("have").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("63212974-900c-4ae7-8dcb-8ff03c41ae80")), ExerciseId108, WordNumber.Create(6).Value, Text.Create("been").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("9b911e25-a8fe-4532-8890-761a058f2a1b")), ExerciseId108, WordNumber.Create(7).Value, Text.Create("teaching").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("92da0685-a98a-4c5e-8477-4d7bda8385bd")), ExerciseId108, WordNumber.Create(8).Value, Text.Create("for").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("4e9bbdb5-4cae-4f7f-a863-320eeec96d14")), ExerciseId108, WordNumber.Create(9).Value, Text.Create("ten").Value, WordType.LetterNumber),
            Word.Create(WordId.Create(Guid.Parse("d5ac16e0-db2a-419f-9eeb-ed381a5e8074")), ExerciseId108, WordNumber.Create(10).Value, Text.Create("years.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("be9ba7dd-1431-4c16-8d22-248d7c642567")), ExerciseId109, WordNumber.Create(1).Value, Text.Create("Will").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("f140d7c4-3950-468d-aa4f-f0ca66d83262")), ExerciseId109, WordNumber.Create(2).Value, Text.Create("you").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("0a9bcc4b-f8bb-4b4d-99e9-563e94245abb")), ExerciseId109, WordNumber.Create(3).Value, Text.Create("have").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("c9a10e8d-8db8-4a5f-9592-eede1d64ea21")), ExerciseId109, WordNumber.Create(4).Value, Text.Create("been").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("2b501b0c-6ba7-4b59-9db5-898273e1a184")), ExerciseId109, WordNumber.Create(5).Value, Text.Create("waiting").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("f9c4f641-2cb6-449d-a872-36004c8631e5")), ExerciseId109, WordNumber.Create(6).Value, Text.Create("for").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("7bdae047-4684-4d0d-9eaf-012c781a5ee4")), ExerciseId109, WordNumber.Create(7).Value, Text.Create("more").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("dd659416-5497-4df8-ad81-c06cb31d50b4")), ExerciseId109, WordNumber.Create(8).Value, Text.Create("than").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("de4dda31-6a76-4dc2-a433-757096d5b3a1")), ExerciseId109, WordNumber.Create(9).Value, Text.Create("two").Value, WordType.LetterNumber),
            Word.Create(WordId.Create(Guid.Parse("724d1264-1753-4978-90a2-0e454bfdd00f")), ExerciseId109, WordNumber.Create(10).Value, Text.Create("hours,").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("657b21d6-8ab0-4bef-baf3-d967db3f89f9")), ExerciseId109, WordNumber.Create(11).Value, Text.Create("when").Value, WordType.QuestionWord),
            Word.Create(WordId.Create(Guid.Parse("56d2d388-8bcb-41fb-a109-754ae942b407")), ExerciseId109, WordNumber.Create(12).Value, Text.Create("her").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("4085ded2-6725-48fb-89fc-ddfa4a0962fd")), ExerciseId109, WordNumber.Create(13).Value, Text.Create("plane").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("ce512073-2559-4326-aa62-058cbfa40b98")), ExerciseId109, WordNumber.Create(14).Value, Text.Create("finally").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("b6917e37-87f3-41cd-b946-57be550525a2")), ExerciseId109, WordNumber.Create(15).Value, Text.Create("arrives?").Value, WordType.Verb),

            Word.Create(WordId.Create(Guid.Parse("087884e3-bad4-41d5-a2f6-88fa739eaa34")), ExerciseId110, WordNumber.Create(1).Value, Text.Create("Next").Value, WordType.Adjective),
            Word.Create(WordId.Create(Guid.Parse("34aaed56-6941-4aad-a2c7-4fa8b56e7c22")), ExerciseId110, WordNumber.Create(2).Value, Text.Create("month").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("bada65a9-8591-49c7-aa99-6b0d8da7ee9e")), ExerciseId110, WordNumber.Create(3).Value, Text.Create("we").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("9436947c-b8c1-423d-8caa-73b1965a6cc5")), ExerciseId110, WordNumber.Create(4).Value, Text.Create("will").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("4789b951-49f4-435c-838a-9ece93c7519c")), ExerciseId110, WordNumber.Create(5).Value, Text.Create("have").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("6ce15fa5-1f7e-4d9d-8bf0-eec5dd863d50")), ExerciseId110, WordNumber.Create(6).Value, Text.Create("been").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("ff2691e1-b6ae-4405-8bfa-6ce1b9cfaf43")), ExerciseId110, WordNumber.Create(7).Value, Text.Create("living").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("d8cb4fcf-744b-43da-91fb-6bb5612b3ce8")), ExerciseId110, WordNumber.Create(8).Value, Text.Create("together").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("15510e64-d9db-4305-8c60-e76888d457cd")), ExerciseId110, WordNumber.Create(9).Value, Text.Create("for").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("9a5906de-9cec-4f59-8b45-07b0a2bec4ee")), ExerciseId110, WordNumber.Create(10).Value, Text.Create("fifteen").Value, WordType.LetterNumber),
            Word.Create(WordId.Create(Guid.Parse("4193a0e2-c4a5-4e80-8ca1-84aa1a36e4c7")), ExerciseId110, WordNumber.Create(11).Value, Text.Create("years.").Value, WordType.Noun),

            #endregion

            #region Lesson 24

            Word.Create(WordId.Create(Guid.Parse("7d9d2e03-6997-4be0-8642-49e38120b284")), ExerciseId116, WordNumber.Create(1).Value, Text.Create("They").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("6fdc0546-476e-4d7a-af6b-3e2177ed6fda")), ExerciseId116, WordNumber.Create(2).Value, Text.Create("will").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("5750559e-cea2-4f1e-96d9-448854878802")), ExerciseId116, WordNumber.Create(3).Value, Text.Create("have").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("3cdf96a0-e27f-465f-91c4-968883243c1d")), ExerciseId116, WordNumber.Create(4).Value, Text.Create("been").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("09462e4d-9cd9-4187-83ed-8576c9121792")), ExerciseId116, WordNumber.Create(5).Value, Text.Create("talking").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("fb351a4c-b780-4a1f-9b67-3764b51b7fc0")), ExerciseId116, WordNumber.Create(6).Value, Text.Create("for").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("428b6024-efb3-4d07-b1f1-f20ac8647450")), ExerciseId116, WordNumber.Create(7).Value, Text.Create("over").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("88cda76b-e6db-4d6e-bbce-db8e381e6e64")), ExerciseId116, WordNumber.Create(8).Value, Text.Create("an").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("3d7aa4fe-a51d-4051-9a7e-cdbbc20a8936")), ExerciseId116, WordNumber.Create(9).Value, Text.Create("hour,").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("51bc4c12-2708-4c5d-be2a-f769ed341c37")), ExerciseId116, WordNumber.Create(10).Value, Text.Create("by").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("8d25be11-36a8-4b1c-ac47-dfae1f2cf9aa")), ExerciseId116, WordNumber.Create(11).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("16e5f357-208b-4e63-bb32-408f743dbee6")), ExerciseId116, WordNumber.Create(12).Value, Text.Create("time,").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("65a7b6a6-37f1-453c-8735-a2a1cf9bfcc2")), ExerciseId116, WordNumber.Create(13).Value, Text.Create("he").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("882d48bd-e21d-4443-8606-d7d617485c43")), ExerciseId116, WordNumber.Create(14).Value, Text.Create("arrives.").Value, WordType.Verb),

            Word.Create(WordId.Create(Guid.Parse("de5c83a1-4dc8-4af6-a455-72486154ad24")), ExerciseId117, WordNumber.Create(1).Value, Text.Create("By").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("fa1eae36-75e6-4dcc-a783-98303de918c0")), ExerciseId117, WordNumber.Create(2).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("17bc8895-0082-4757-8b11-5bf0a7f1faa1")), ExerciseId117, WordNumber.Create(3).Value, Text.Create("first").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("4f0be523-f21a-4d09-b844-e695985019fc")), ExerciseId117, WordNumber.Create(4).Value, Text.Create("of").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("fa1cb1cb-fce7-4708-8489-5a1b1b2e979a")), ExerciseId117, WordNumber.Create(5).Value, Text.Create("June").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("0b2e8be1-5a99-429c-a57b-c2552c4835be")), ExerciseId117, WordNumber.Create(6).Value, Text.Create("he").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("6db598fd-909c-4ac6-b55e-3462f9fd34d1")), ExerciseId117, WordNumber.Create(7).Value, Text.Create("will").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("5d74940e-9c31-4f3e-b06a-6818deb1d32f")), ExerciseId117, WordNumber.Create(8).Value, Text.Create("have").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("4c127042-4710-477b-9516-b1583a0248e4")), ExerciseId117, WordNumber.Create(9).Value, Text.Create("been").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("59e58a18-2c70-4f4a-96ff-a4cc05f91622")), ExerciseId117, WordNumber.Create(10).Value, Text.Create("working").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("ba7b75a6-2892-4a0c-9da3-67422ff7e15c")), ExerciseId117, WordNumber.Create(11).Value, Text.Create("at").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("e00ca079-1718-4da8-9b29-21794b425bd3")), ExerciseId117, WordNumber.Create(12).Value, Text.Create("this").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("414eb0c8-7eb0-4e44-b317-63ad94e1f5e9")), ExerciseId117, WordNumber.Create(13).Value, Text.Create("plant").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("7bd2c09f-cf98-476c-a3fe-d81aeac76f8f")), ExerciseId117, WordNumber.Create(14).Value, Text.Create("for").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("b4575448-dadc-4f28-aa4b-e9b5576a09eb")), ExerciseId117, WordNumber.Create(15).Value, Text.Create("twenty").Value, WordType.LetterNumber),
            Word.Create(WordId.Create(Guid.Parse("4cec7222-879b-4e60-83f2-973385f0f3bb")), ExerciseId117, WordNumber.Create(16).Value, Text.Create("years.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("470b60af-3e30-4aaf-b85c-ccb4823a5911")), ExerciseId118, WordNumber.Create(1).Value, Text.Create("Next").Value, WordType.Adjective),
            Word.Create(WordId.Create(Guid.Parse("4d68c119-928e-4d1b-85cb-91704ac64a61")), ExerciseId118, WordNumber.Create(2).Value, Text.Create("Christmas").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("d79b1bc9-cdb3-4711-ab02-f30636052ea9")), ExerciseId118, WordNumber.Create(3).Value, Text.Create("I").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("de11d157-a69c-4bb1-84d7-749392f75b83")), ExerciseId118, WordNumber.Create(4).Value, Text.Create("will").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("5661d0ec-0382-4454-806d-78721f1bbef2")), ExerciseId118, WordNumber.Create(5).Value, Text.Create("have").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("7a1746fe-7f1a-4596-8255-28ca658b6108")), ExerciseId118, WordNumber.Create(6).Value, Text.Create("been").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("dbdfc509-aec6-4ba7-a566-8f3dbd58f878")), ExerciseId118, WordNumber.Create(7).Value, Text.Create("teaching").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("501a2bad-e398-4860-9cfe-7690edcfaa84")), ExerciseId118, WordNumber.Create(8).Value, Text.Create("for").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("3bc2ffe5-9efa-47ac-ae26-8cc30a7093cf")), ExerciseId118, WordNumber.Create(9).Value, Text.Create("ten").Value, WordType.LetterNumber),
            Word.Create(WordId.Create(Guid.Parse("35c9ca01-c05e-4cf6-ac9a-8582ba213621")), ExerciseId118, WordNumber.Create(10).Value, Text.Create("years.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("5c5eaa18-2295-4f0f-add1-d781c68f6923")), ExerciseId119, WordNumber.Create(1).Value, Text.Create("Will").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("36f61c0f-2736-413d-aca4-54ace54aa298")), ExerciseId119, WordNumber.Create(2).Value, Text.Create("you").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("0591aa8e-77d9-4a2a-b7d7-636bab85f873")), ExerciseId119, WordNumber.Create(3).Value, Text.Create("have").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("3b385d4f-ee75-4718-bb7e-2c1eb9fe11e9")), ExerciseId119, WordNumber.Create(4).Value, Text.Create("been").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("170b2ea0-ae70-481e-8ca1-6740d43c3331")), ExerciseId119, WordNumber.Create(5).Value, Text.Create("waiting").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("110fff27-eb90-459e-a7cf-2eb715810ae6")), ExerciseId119, WordNumber.Create(6).Value, Text.Create("for").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("4d3469b3-3c1b-41a4-9da3-9d9b6bd2e6c3")), ExerciseId119, WordNumber.Create(7).Value, Text.Create("more").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("62f7a253-5cb9-4b9a-8f57-9498fe8d2818")), ExerciseId119, WordNumber.Create(8).Value, Text.Create("than").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("f0f5bd0d-8a14-4f85-ab1f-23301898c7e6")), ExerciseId119, WordNumber.Create(9).Value, Text.Create("two").Value, WordType.LetterNumber),
            Word.Create(WordId.Create(Guid.Parse("7cdbf7e8-71ae-4484-8357-a3056eea24d7")), ExerciseId119, WordNumber.Create(10).Value, Text.Create("hours,").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("eb4674eb-753e-40f1-b0ac-9d69f3267ba3")), ExerciseId119, WordNumber.Create(11).Value, Text.Create("when").Value, WordType.QuestionWord),
            Word.Create(WordId.Create(Guid.Parse("139b124d-3d78-4f7f-b469-44def318b060")), ExerciseId119, WordNumber.Create(12).Value, Text.Create("her").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("c4622d8f-b9ca-4d04-b4bb-810356ab8828")), ExerciseId119, WordNumber.Create(13).Value, Text.Create("plane").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("8dcbed3f-7868-4188-8393-a915022ddc91")), ExerciseId119, WordNumber.Create(14).Value, Text.Create("finally").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("413c75b0-3bee-4403-8bf0-0278a69de06c")), ExerciseId119, WordNumber.Create(15).Value, Text.Create("arrives?").Value, WordType.Verb),

            Word.Create(WordId.Create(Guid.Parse("7908ea9c-c57f-4ea3-a985-5d9b08759ad6")), ExerciseId120, WordNumber.Create(1).Value, Text.Create("Next").Value, WordType.Adjective),
            Word.Create(WordId.Create(Guid.Parse("358ca068-6241-4866-a612-b959dbb269d8")), ExerciseId120, WordNumber.Create(2).Value, Text.Create("month").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("595bd959-577e-4361-a3b2-0b9a40120578")), ExerciseId120, WordNumber.Create(3).Value, Text.Create("we").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("c69ff84c-6070-4e4f-95d3-c5fe4d5a5b70")), ExerciseId120, WordNumber.Create(4).Value, Text.Create("will").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("4ce6ed92-277e-46c7-a27f-c0717c169db4")), ExerciseId120, WordNumber.Create(5).Value, Text.Create("have").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("f3e6f5b2-1da1-4090-b7ef-3b80ff875330")), ExerciseId120, WordNumber.Create(6).Value, Text.Create("been").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("e487ab07-d16b-4aff-9032-4f7818d070cc")), ExerciseId120, WordNumber.Create(7).Value, Text.Create("living").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("ea99d50a-058f-4698-8d2d-67b50ceff107")), ExerciseId120, WordNumber.Create(8).Value, Text.Create("together").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("b4d7f324-10dc-4644-9113-c216423b48f1")), ExerciseId120, WordNumber.Create(9).Value, Text.Create("for").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("d2b35eec-c9eb-4157-bdb1-a252738cd3cb")), ExerciseId120, WordNumber.Create(10).Value, Text.Create("fifteen").Value, WordType.LetterNumber),
            Word.Create(WordId.Create(Guid.Parse("e074467c-c2fe-4861-b9b6-b4c125e56437")), ExerciseId120, WordNumber.Create(11).Value, Text.Create("years.").Value, WordType.Noun),

            #endregion

            #region Lesson 25

            Word.Create(WordId.Create(Guid.Parse("d5fe2cdc-2018-4a2d-b71c-b44924dda76a")), ExerciseId121, WordNumber.Create(1).Value, Text.Create("I").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("62f5457b-f889-4e1b-8186-702d363e964d")), ExerciseId121, WordNumber.Create(2).Value, Text.Create("was").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("bac3fbc4-2a99-4563-9cad-1a16bc0a946a")), ExerciseId121, WordNumber.Create(3).Value, Text.Create("disappointed").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("3cf7f5ad-e46d-4a6d-9222-4376ffac0a77")), ExerciseId121, WordNumber.Create(4).Value, Text.Create("to").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("0c340523-4e58-4507-a006-7b5c8b3061f7")), ExerciseId121, WordNumber.Create(5).Value, Text.Create("hear").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("a79b88c8-7ea5-4d1a-bb8a-464a956d30d9")), ExerciseId121, WordNumber.Create(6).Value, Text.Create("that").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("2c4e3658-60ea-4c73-aea9-ac9a61472ade")), ExerciseId121, WordNumber.Create(7).Value, Text.Create("more").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("1a2aeddb-4e88-4f74-8d86-4558ea8b6f4b")), ExerciseId121, WordNumber.Create(8).Value, Text.Create("and").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("a0a2e7a0-8598-4f8e-b1bd-cdf5fb176791")), ExerciseId121, WordNumber.Create(9).Value, Text.Create("more").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("c41c1ad9-6d6c-4551-aeda-ff5b4e57b859")), ExerciseId121, WordNumber.Create(10).Value, Text.Create("people").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("f6a3f754-4600-4585-818f-69062f80eb58")), ExerciseId121, WordNumber.Create(11).Value, Text.Create("lose").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("9f5d9bcd-d538-43b9-9f5c-0794a378e36f")), ExerciseId121, WordNumber.Create(12).Value, Text.Create("their").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("4a30cadb-97c8-496a-995f-0127e5c46f13")), ExerciseId121, WordNumber.Create(13).Value, Text.Create("jobs.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("70db7f0b-fb19-4be0-990e-bc3daebbdeb8")), ExerciseId122, WordNumber.Create(1).Value, Text.Create("Exhausted,").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("9fe350ab-bd80-4ef5-bb85-4b5d2f253160")), ExerciseId122, WordNumber.Create(2).Value, Text.Create("he").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("8d3f37fa-7a0e-40fd-97b7-18caed78852b")), ExerciseId122, WordNumber.Create(3).Value, Text.Create("fell").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("aef41115-d547-4f42-b03a-d4ba1a2de3fb")), ExerciseId122, WordNumber.Create(4).Value, Text.Create("asleep.").Value, WordType.Adjective),

            Word.Create(WordId.Create(Guid.Parse("5f76180b-5a60-4f54-87a7-3092aeecfc6c")), ExerciseId123, WordNumber.Create(1).Value, Text.Create("The").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("afc1d469-cb34-4e7b-93fe-e1a061a7ceec")), ExerciseId123, WordNumber.Create(2).Value, Text.Create("appliance").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("c0aeeec7-8b0a-4775-8707-db547b94d17b")), ExerciseId123, WordNumber.Create(3).Value, Text.Create("bought").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("d831548b-456d-457c-9ff5-b362f29f54e2")), ExerciseId123, WordNumber.Create(4).Value, Text.Create("from").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("4d36a97c-1c38-44c0-9428-483d3f2a69e0")), ExerciseId123, WordNumber.Create(5).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("15928a83-abd7-4c51-9da6-ebdf94a12297")), ExerciseId123, WordNumber.Create(6).Value, Text.Create("specialized").Value, WordType.Adjective),
            Word.Create(WordId.Create(Guid.Parse("adb10946-e6fb-4d04-8a05-9adaaa972ae4")), ExerciseId123, WordNumber.Create(7).Value, Text.Create("shop").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("7c7d4e4b-122a-4a9f-a336-5634f4e480a3")), ExerciseId123, WordNumber.Create(8).Value, Text.Create("has").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("f9249d61-225c-413e-9022-158df4bdbd3e")), ExerciseId123, WordNumber.Create(9).Value, Text.Create("a").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("f5d3783c-a926-48ad-9402-b3a260991440")), ExerciseId123, WordNumber.Create(10).Value, Text.Create("guarantee.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("d9d293cc-004d-4495-aad9-e8343e0e64bd")), ExerciseId124, WordNumber.Create(1).Value, Text.Create("They").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("5da72418-e630-40b9-a824-fdea02bb1b0c")), ExerciseId124, WordNumber.Create(2).Value, Text.Create("could not").Value, WordType.ModalVerb),
            Word.Create(WordId.Create(Guid.Parse("3d0a17ec-35d8-4651-b584-01fd209fa6b6")), ExerciseId124, WordNumber.Create(3).Value, Text.Create("recover").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("78417487-0b05-403f-bb8d-83cfe605648a")), ExerciseId124, WordNumber.Create(4).Value, Text.Create("from").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("04751a58-b9f3-43cd-a023-b88b481a6917")), ExerciseId124, WordNumber.Create(5).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("5a669e64-3215-409f-a3e3-b788080877ac")), ExerciseId124, WordNumber.Create(6).Value, Text.Create("lost").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("ce247e88-681f-4a42-936c-07bca626fe2f")), ExerciseId124, WordNumber.Create(7).Value, Text.Create("war.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("db277491-379c-497c-9fa7-d6c3f0c4abf7")), ExerciseId125, WordNumber.Create(1).Value, Text.Create("After").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("1021da63-af09-44e9-8aa3-9b83fe7561c4")), ExerciseId125, WordNumber.Create(2).Value, Text.Create("computer").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("1cbe2fe7-6153-42e1-a021-47a031a6c968")), ExerciseId125, WordNumber.Create(3).Value, Text.Create("breaking").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("b26549a9-87cb-4468-aed7-a428be138e39")), ExerciseId125, WordNumber.Create(4).Value, Text.Create("down").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("6f6466b7-328f-4d41-8a66-0f92fd9029b6")), ExerciseId125, WordNumber.Create(5).Value, Text.Create("we").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("dafe0435-60ac-4686-8db3-8b2e83c5c425")), ExerciseId125, WordNumber.Create(6).Value, Text.Create("could not").Value, WordType.ModalVerb),
            Word.Create(WordId.Create(Guid.Parse("e371abc4-bcf4-4704-81a6-96ad5a6a5620")), ExerciseId125, WordNumber.Create(7).Value, Text.Create("restore").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("53429ec9-3331-4ada-858f-835fbbc84792")), ExerciseId125, WordNumber.Create(8).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("d663db1d-d0ba-45b7-a89a-01b150e34fdc")), ExerciseId125, WordNumber.Create(9).Value, Text.Create("lost").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("de691c93-d09d-497f-a8e6-2f1340910016")), ExerciseId125, WordNumber.Create(10).Value, Text.Create("data.").Value, WordType.Noun),

            #endregion

            #region Lesson 26

            Word.Create(WordId.Create(Guid.Parse("11608fd2-2393-4703-99fd-d9d45112bf49")), ExerciseId126, WordNumber.Create(1).Value, Text.Create("Having").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("8d1bcd5f-f774-4a12-8208-109eb1518dd8")), ExerciseId126, WordNumber.Create(2).Value, Text.Create("bought").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("bac1ee8d-6ec3-4051-8983-0fce4450345c")), ExerciseId126, WordNumber.Create(3).Value, Text.Create("some").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("bd9997e5-021c-4975-bb7b-0a374a4bdd1d")), ExerciseId126, WordNumber.Create(4).Value, Text.Create("new").Value, WordType.Adjective),
            Word.Create(WordId.Create(Guid.Parse("aba7e704-57c2-41ea-9a31-610fd97d0468")), ExerciseId126, WordNumber.Create(5).Value, Text.Create("clothes").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("decaaa23-6107-48e1-a7f3-3de219cb962c")), ExerciseId126, WordNumber.Create(6).Value, Text.Create("she").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("f7d3f2a8-3eb2-4ae2-98e1-892adc3b686e")), ExerciseId126, WordNumber.Create(7).Value, Text.Create("felt").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("e5528c75-ffd2-4233-8de8-a301c9097242")), ExerciseId126, WordNumber.Create(8).Value, Text.Create("much").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("3da4a79a-9a3a-415b-9978-1a57cb57cd88")), ExerciseId126, WordNumber.Create(9).Value, Text.Create("better.").Value, WordType.ComparisonAdjective),

            Word.Create(WordId.Create(Guid.Parse("d97810ab-df61-4e0d-9583-7f012ca00eea")), ExerciseId127, WordNumber.Create(1).Value, Text.Create("Having").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("8e044ef7-c07f-4864-a293-3b1e5a43cb1e")), ExerciseId127, WordNumber.Create(2).Value, Text.Create("looked").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("8f30e6dd-bd53-4754-91dc-3ca1399a5456")), ExerciseId127, WordNumber.Create(3).Value, Text.Create("through").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("c79c13ff-e68d-40b5-8b52-add9c2ef6f5f")), ExerciseId127, WordNumber.Create(4).Value, Text.Create("a").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("4012ad76-0db9-4467-8e09-1e384735293b")), ExerciseId127, WordNumber.Create(5).Value, Text.Create("lot").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("ab3e9cbf-2691-4e7d-82cb-c3bc272d6dcb")), ExerciseId127, WordNumber.Create(6).Value, Text.Create("of").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("15ec8614-5571-469f-8e1d-66e6ac73e296")), ExerciseId127, WordNumber.Create(7).Value, Text.Create("journals").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("6274d4e1-e1bc-40f4-8d7d-379fef285a32")), ExerciseId127, WordNumber.Create(8).Value, Text.Create("and").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("557541a1-e926-4276-bffe-1f871440886a")), ExerciseId127, WordNumber.Create(9).Value, Text.Create("papers").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("f840846d-acd7-42e8-82c6-324ac869ccac")), ExerciseId127, WordNumber.Create(10).Value, Text.Create("he").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("d106c8b5-7ebc-4857-a17b-94c29c3f8a25")), ExerciseId127, WordNumber.Create(11).Value, Text.Create("began").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("4884249a-cf5b-4457-8fa1-4613844f404f")), ExerciseId127, WordNumber.Create(12).Value, Text.Create("to").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("d36f9569-269b-4aed-84fc-f6e812c4d2ef")), ExerciseId127, WordNumber.Create(13).Value, Text.Create("write").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("d3dd0671-a525-491d-b5fa-050642f78cc8")), ExerciseId127, WordNumber.Create(14).Value, Text.Create("his").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("23da724f-912f-49f1-b517-54b5fccd4df4")), ExerciseId127, WordNumber.Create(15).Value, Text.Create("report.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("4b78f3c6-4b6d-4450-82e8-4b4bc232ddb3")), ExerciseId128, WordNumber.Create(1).Value, Text.Create("Having").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("1da2ffda-c597-4ee1-bd88-4d177f6cbe79")), ExerciseId128, WordNumber.Create(2).Value, Text.Create("taken").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("260c4769-8449-4737-8b76-7b2138702c5c")), ExerciseId128, WordNumber.Create(3).Value, Text.Create("my").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("c217ac54-e1e9-4ca3-8736-bcd035bf62f7")), ExerciseId128, WordNumber.Create(4).Value, Text.Create("advice").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("97e3692d-b259-43bf-a1fb-d7a75c7c74f8")), ExerciseId128, WordNumber.Create(5).Value, Text.Create("she").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("4a0aca3f-fea1-4310-b2ce-b3b6eaff58be")), ExerciseId128, WordNumber.Create(6).Value, Text.Create("followed").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("cb133a53-554e-45b2-8715-3d29b4a7d172")), ExerciseId128, WordNumber.Create(7).Value, Text.Create("it.").Value, WordType.Pronoun),

            Word.Create(WordId.Create(Guid.Parse("774b2414-70b2-4f1f-a926-1174e14f28cf")), ExerciseId129, WordNumber.Create(1).Value, Text.Create("Having").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("60d5a741-8b35-40fe-94b1-bc616206f0c0")), ExerciseId129, WordNumber.Create(2).Value, Text.Create("paid").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("5991b345-8267-4875-b21f-c202ef9c6bcf")), ExerciseId129, WordNumber.Create(3).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("f14ded7e-f59f-4641-b579-cdcfcd68cb99")), ExerciseId129, WordNumber.Create(4).Value, Text.Create("fine").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("025311a8-f4ff-483e-baae-5562ca199661")), ExerciseId129, WordNumber.Create(5).Value, Text.Create("he").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("37cde562-4c75-4627-9b77-2b8223f73b18")), ExerciseId129, WordNumber.Create(6).Value, Text.Create("did not").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("844ede82-4948-40fc-9390-4731aee8fb4b")), ExerciseId129, WordNumber.Create(7).Value, Text.Create("break").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("3021f10b-098c-4ca1-b7db-b6b55fc388e3")), ExerciseId129, WordNumber.Create(8).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("75274ac9-d5d1-4d6f-920d-2921a5c7f593")), ExerciseId129, WordNumber.Create(9).Value, Text.Create("law").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("41870c26-2294-4932-9aa6-9905c806a927")), ExerciseId129, WordNumber.Create(10).Value, Text.Create("again.").Value, WordType.Adverb),

            Word.Create(WordId.Create(Guid.Parse("c625bd6d-8e33-428c-94fa-c3083da4dfd7")), ExerciseId130, WordNumber.Create(1).Value, Text.Create("Having").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("0d1b0f64-6201-43c3-a350-5af3a148e401")), ExerciseId130, WordNumber.Create(2).Value, Text.Create("sought").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("10acb058-b37b-487c-b995-259009fb64a4")), ExerciseId130, WordNumber.Create(3).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("58d77854-b92c-4d7a-bed6-b8e3a6b223f0")), ExerciseId130, WordNumber.Create(4).Value, Text.Create("flat").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("f45b5b29-83fa-44fa-9fee-fb8702dee6d6")), ExerciseId130, WordNumber.Create(5).Value, Text.Create("they").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("07ff82d6-00ad-474c-9997-437c89d0ceef")), ExerciseId130, WordNumber.Create(6).Value, Text.Create("found").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("ce392acf-e6d9-4873-9c78-1d6ea33447de")), ExerciseId130, WordNumber.Create(7).Value, Text.Create("no").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("213e7ec8-ecb1-40ac-b672-a455146519f1")), ExerciseId130, WordNumber.Create(8).Value, Text.Create("evidence.").Value, WordType.Noun),

            #endregion

            #region Lesson 28

            Word.Create(WordId.Create(Guid.Parse("f696ae98-191d-442c-92ba-4987a3a63a6b")), ExerciseId136, WordNumber.Create(1).Value, Text.Create("Is").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("6c2dece9-f1be-49bd-84f5-9a4d2aebafa5")), ExerciseId136, WordNumber.Create(2).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("5751f9e4-2cf2-48c0-9f8f-3c611f126c33")), ExerciseId136, WordNumber.Create(3).Value, Text.Create("office").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("5af5ea08-0054-4774-bd04-0d76dfffaa4c")), ExerciseId136, WordNumber.Create(4).Value, Text.Create("cleaned").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("287a8bb7-6b34-4639-b443-c2544faab9f6")), ExerciseId136, WordNumber.Create(5).Value, Text.Create("every").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("b0c037f0-87e6-4739-95a4-f9a19ea5fea8")), ExerciseId136, WordNumber.Create(6).Value, Text.Create("day?").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("2ee5b8ac-1873-4faa-80e0-37a8d11186a4")), ExerciseId137, WordNumber.Create(1).Value, Text.Create("I").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("34ba9b7d-7c5a-47ac-9c0f-c30e6206c593")), ExerciseId137, WordNumber.Create(2).Value, Text.Create("am").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("3985850b-8475-4462-9a80-9689b589313d")), ExerciseId137, WordNumber.Create(3).Value, Text.Create("invited").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("3e2b400d-0ade-4729-ac7c-2dd6f22f4fec")), ExerciseId137, WordNumber.Create(4).Value, Text.Create("to").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("2156d402-17f8-418a-9fb5-d34ccc5a5616")), ExerciseId137, WordNumber.Create(5).Value, Text.Create("a").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("33a1e142-bad6-4f6d-afe5-c37708e91cae")), ExerciseId137, WordNumber.Create(6).Value, Text.Create("party.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("7cd33e20-0864-430c-83d1-1cd0ec9ebff1")), ExerciseId138, WordNumber.Create(1).Value, Text.Create("He").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("6639e293-bd6a-4170-9cbc-600ba4728cc4")), ExerciseId138, WordNumber.Create(2).Value, Text.Create("was").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("2c0a9342-ac96-4726-a51c-182bfdaa6378")), ExerciseId138, WordNumber.Create(3).Value, Text.Create("offered").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("e3a80af3-f3f5-43b7-af9e-e45fd7933514")), ExerciseId138, WordNumber.Create(4).Value, Text.Create("a").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("541b70dc-8997-4414-9180-3616f0b3b5c5")), ExerciseId138, WordNumber.Create(5).Value, Text.Create("good").Value, WordType.Adjective),
            Word.Create(WordId.Create(Guid.Parse("fb64c37a-91c0-4374-aa9c-ff503658edc5")), ExerciseId138, WordNumber.Create(6).Value, Text.Create("job").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("3bca7fcf-57af-4700-94b7-a75143653182")), ExerciseId138, WordNumber.Create(7).Value, Text.Create("at").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("fc1219c4-6348-4788-9e12-cae8a4345e3c")), ExerciseId138, WordNumber.Create(8).Value, Text.Create("a").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("1b458b6b-53c2-4889-a85d-1e1e41850425")), ExerciseId138, WordNumber.Create(9).Value, Text.Create("large").Value, WordType.Adjective),
            Word.Create(WordId.Create(Guid.Parse("fd55fefb-a6c9-400e-8cd0-06df28f70442")), ExerciseId138, WordNumber.Create(10).Value, Text.Create("construction").Value, WordType.Adjective),
            Word.Create(WordId.Create(Guid.Parse("3d81f050-8f49-41b8-bcd8-d7a079e8358b")), ExerciseId138, WordNumber.Create(11).Value, Text.Create("company.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("94f8584c-8b48-4f75-a44e-a89a12e4a8f5")), ExerciseId139, WordNumber.Create(1).Value, Text.Create("Dinner").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("e1cbb7f5-3b6e-4fce-9626-3a2f8a3962ba")), ExerciseId139, WordNumber.Create(2).Value, Text.Create("is").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("ad7ae66f-9d78-48b5-ab76-494afee5932a")), ExerciseId139, WordNumber.Create(3).Value, Text.Create("served").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("cd722437-47ae-4d53-9be4-c4bef24f2725")), ExerciseId139, WordNumber.Create(4).Value, Text.Create("after").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("dac0e0dd-f9e8-4ace-81e8-38f7b916cabb")), ExerciseId139, WordNumber.Create(5).Value, Text.Create("seven.").Value, WordType.LetterNumber),

            Word.Create(WordId.Create(Guid.Parse("8c712053-3437-47cf-aeff-98fa3a741122")), ExerciseId140, WordNumber.Create(1).Value, Text.Create("He").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("18253ed6-fa40-4507-84be-2941b2e46fe3")), ExerciseId140, WordNumber.Create(2).Value, Text.Create("was").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("5c662633-6f9a-49d1-b6fc-b58d496aa777")), ExerciseId140, WordNumber.Create(3).Value, Text.Create("followed").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("1e1e8977-d9d6-4faf-8e6b-8377018e04a4")), ExerciseId140, WordNumber.Create(4).Value, Text.Create("by").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("53d10736-8c9a-463c-bd3f-9abe5f1f5a72")), ExerciseId140, WordNumber.Create(5).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("c6100b7c-c004-41f1-b4f3-2ffe742cb9f3")), ExerciseId140, WordNumber.Create(6).Value, Text.Create("police.").Value, WordType.Noun),

            #endregion

            #region Lesson 29

            Word.Create(WordId.Create(Guid.Parse("1dd63ab8-9857-40ef-9c54-b3082baf99e5")), ExerciseId141, WordNumber.Create(1).Value, Text.Create("Was").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("df4689a1-9eaa-4856-b2b3-7fd7be19cb56")), ExerciseId141, WordNumber.Create(2).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("8cc2aca9-2045-4f88-bf9b-001d0b4f8731")), ExerciseId141, WordNumber.Create(3).Value, Text.Create("question").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("adb8902f-1317-45cf-8620-a1534f8c7de8")), ExerciseId141, WordNumber.Create(4).Value, Text.Create("being").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("20146b2c-be56-4963-92c5-26fbb4dc564a")), ExerciseId141, WordNumber.Create(5).Value, Text.Create("discussed").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("52eee71e-627e-4d3a-967b-fd64d344a5a7")), ExerciseId141, WordNumber.Create(6).Value, Text.Create("at").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("a53b31ac-410d-435f-85fd-5db9de4d5944")), ExerciseId141, WordNumber.Create(7).Value, Text.Create("seven").Value, WordType.LetterNumber),
            Word.Create(WordId.Create(Guid.Parse("139a3180-c4e6-4f3c-82ed-7f939f3ac95d")), ExerciseId141, WordNumber.Create(8).Value, Text.Create("o'clock?").Value, WordType.Adverb),

            Word.Create(WordId.Create(Guid.Parse("7c9df338-58de-436f-a797-5175f5914a1b")), ExerciseId142, WordNumber.Create(1).Value, Text.Create("The").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("48cd3a8f-3c8f-4ee2-9233-93d88e09190a")), ExerciseId142, WordNumber.Create(2).Value, Text.Create("room").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("1ff448ee-f178-45b8-a29f-a97febea046b")), ExerciseId142, WordNumber.Create(3).Value, Text.Create("is").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("1d20b4d5-f072-40f6-b4fc-0e17702c40a7")), ExerciseId142, WordNumber.Create(4).Value, Text.Create("being").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("64b0b513-714e-4e1e-821c-24a64df97960")), ExerciseId142, WordNumber.Create(5).Value, Text.Create("cleaned").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("f57d52fa-22ca-4c3c-8fde-43b03bb53d81")), ExerciseId142, WordNumber.Create(6).Value, Text.Create("at").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("504616da-c94e-46b1-8239-fd3de78ace27")), ExerciseId142, WordNumber.Create(7).Value, Text.Create("this").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("4cf2b063-7ef8-4f17-934b-398aa7c7c448")), ExerciseId142, WordNumber.Create(8).Value, Text.Create("moment.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("99eb97be-77bc-42da-b05a-b92340bc73ba")), ExerciseId143, WordNumber.Create(1).Value, Text.Create("He").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("27f03fca-1645-4e4c-9185-420507fe151a")), ExerciseId143, WordNumber.Create(2).Value, Text.Create("is").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("067654a4-f4ec-4844-86c5-1f427e1297f2")), ExerciseId143, WordNumber.Create(3).Value, Text.Create("being").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("405b5f3a-bfb4-4004-aaa0-18b25c46f256")), ExerciseId143, WordNumber.Create(4).Value, Text.Create("examined").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("ded04aa4-ed87-404e-9b93-380a27ba64d2")), ExerciseId143, WordNumber.Create(5).Value, Text.Create("by").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("81e9fff6-b72a-48c2-93bc-1837d10daed3")), ExerciseId143, WordNumber.Create(6).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("9d522e94-6c43-4aee-b1ed-2348e62959cb")), ExerciseId143, WordNumber.Create(7).Value, Text.Create("doctor").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("dd35e8ca-ad0a-4c31-8419-a1037c03ca04")), ExerciseId143, WordNumber.Create(8).Value, Text.Create("at").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("0824b483-354e-40d6-a928-0d56cb29a764")), ExerciseId143, WordNumber.Create(9).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("6f26e384-f23e-4ad0-ab2d-38f64b2eb1f6")), ExerciseId143, WordNumber.Create(10).Value, Text.Create("moment.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("500e3e0a-a822-4bef-972d-1399bec02d43")), ExerciseId144, WordNumber.Create(1).Value, Text.Create("He").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("bc7c56b0-20b2-4706-8d73-d4c3ccff2f9c")), ExerciseId144, WordNumber.Create(2).Value, Text.Create("is not").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("17b61e0a-f6b4-4ddf-9b33-82bdd108bb54")), ExerciseId144, WordNumber.Create(3).Value, Text.Create("being").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("795422cc-4e26-4fcb-bda9-c567bf2ae20f")), ExerciseId144, WordNumber.Create(4).Value, Text.Create("followed").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("2e18b5a8-2496-4ccb-ac16-d5a108f0db87")), ExerciseId144, WordNumber.Create(5).Value, Text.Create("by").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("1fcdeaec-a6c4-4c97-9dbf-0d57ebdf3453")), ExerciseId144, WordNumber.Create(6).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("2f22159c-07c4-4302-a6a3-6148b775c4d7")), ExerciseId144, WordNumber.Create(7).Value, Text.Create("police").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("c6fde8d1-3b93-4955-aefd-e03bf5ff104c")), ExerciseId144, WordNumber.Create(8).Value, Text.Create("at").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("4dcdca46-5bed-42e4-859a-40f563653149")), ExerciseId144, WordNumber.Create(9).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("d2c652b1-255d-436b-bbb6-bbd2c3801da8")), ExerciseId144, WordNumber.Create(10).Value, Text.Create("moment.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("3e945626-f4df-437a-9ecf-a9d9f81e36d5")), ExerciseId145, WordNumber.Create(1).Value, Text.Create("Is").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("47f98148-c919-4017-aa22-9c92ff912ab3")), ExerciseId145, WordNumber.Create(2).Value, Text.Create("his").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("9fa3f98c-f8c4-41ff-a1b2-929c9690ff4a")), ExerciseId145, WordNumber.Create(3).Value, Text.Create("house").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("b6c84f05-40bc-489d-a60b-3b2d344e167c")), ExerciseId145, WordNumber.Create(4).Value, Text.Create("being").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("7f333226-159f-4638-aad4-06f3e94efcc4")), ExerciseId145, WordNumber.Create(5).Value, Text.Create("built").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("ca740314-9ee4-47a7-9ffe-4afd9bae822f")), ExerciseId145, WordNumber.Create(6).Value, Text.Create("now?").Value, WordType.Adverb),

            #endregion

            #region Lesson 30

            Word.Create(WordId.Create(Guid.Parse("98cca87b-608b-49d1-82ac-b4ef7ca684c5")), ExerciseId146, WordNumber.Create(1).Value, Text.Create("Will").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("af9e6639-722a-46f1-9979-bcb66b2c4f83")), ExerciseId146, WordNumber.Create(2).Value, Text.Create("this").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("f7bca980-1e42-47ac-8448-4dd42707f7b4")), ExerciseId146, WordNumber.Create(3).Value, Text.Create("book").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("bb06c23e-45d3-4124-83a5-424083bede1c")), ExerciseId146, WordNumber.Create(4).Value, Text.Create("have").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("99899f35-d427-42d1-827a-e5ee03499c04")), ExerciseId146, WordNumber.Create(5).Value, Text.Create("been").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("8a749fc8-c5a2-4921-9cba-9a5df2e446a0")), ExerciseId146, WordNumber.Create(6).Value, Text.Create("read").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("58e7f038-ae0f-485d-98f7-da1b9c18d1c0")), ExerciseId146, WordNumber.Create(7).Value, Text.Create("by").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("7ffb9bae-f0e6-4e35-a84e-8ed63caeb84d")), ExerciseId146, WordNumber.Create(8).Value, Text.Create("two").Value, WordType.LetterNumber),
            Word.Create(WordId.Create(Guid.Parse("91a23124-3e4c-461f-a495-eb1fa911d9de")), ExerciseId146, WordNumber.Create(9).Value, Text.Create("o'clock").Value, WordType.Adverb),
            Word.Create(WordId.Create(Guid.Parse("6ed71e5e-5843-4f34-b7e2-7dcb71bf7f45")), ExerciseId146, WordNumber.Create(10).Value, Text.Create("tomorrow?").Value, WordType.Adverb),

            Word.Create(WordId.Create(Guid.Parse("058f2619-f9bf-489a-965e-cd69ca1e511a")), ExerciseId147, WordNumber.Create(1).Value, Text.Create("This").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("42622b8d-9415-46f0-a215-fdad180e6839")), ExerciseId147, WordNumber.Create(2).Value, Text.Create("book").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("ff1947cd-9e1a-4e8e-8c0a-e95a1ebdf243")), ExerciseId147, WordNumber.Create(3).Value, Text.Create("has").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("138ec36f-404b-467f-9fa4-d0e18fbfa5c3")), ExerciseId147, WordNumber.Create(4).Value, Text.Create("been").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("164790a5-218e-47d1-8669-b259a49ef627")), ExerciseId147, WordNumber.Create(5).Value, Text.Create("read.").Value, WordType.Verb),

            Word.Create(WordId.Create(Guid.Parse("9b41c54a-5664-47fc-8efa-6e27c654cc21")), ExerciseId148, WordNumber.Create(1).Value, Text.Create("The").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("54ed7bf2-ebcd-4a3b-8354-62493c4623da")), ExerciseId148, WordNumber.Create(2).Value, Text.Create("message").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("19c2b720-2171-41d4-9986-88cd50e7e910")), ExerciseId148, WordNumber.Create(3).Value, Text.Create("had not").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("6865a5c6-fe05-40b0-a594-3334ea6f9f59")), ExerciseId148, WordNumber.Create(4).Value, Text.Create("been").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("6c339876-e179-4c1a-a6ad-03c72c5a1337")), ExerciseId148, WordNumber.Create(5).Value, Text.Create("read").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("02235be5-e3d9-4216-b833-972679bfdbb0")), ExerciseId148, WordNumber.Create(6).Value, Text.Create("by").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("40593203-4468-4a36-9c4f-9aecf9f3306c")), ExerciseId148, WordNumber.Create(7).Value, Text.Create("two").Value, WordType.LetterNumber),
            Word.Create(WordId.Create(Guid.Parse("53a6a7d0-3c3c-4333-93c0-780b2f924cd2")), ExerciseId148, WordNumber.Create(8).Value, Text.Create("o'clock.").Value, WordType.Adverb),

            Word.Create(WordId.Create(Guid.Parse("31ee26e9-ae81-467d-b703-b92729d1fa50")), ExerciseId149, WordNumber.Create(1).Value, Text.Create("She").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("ca921e4b-4d37-4432-a216-c7b281e94a7a")), ExerciseId149, WordNumber.Create(2).Value, Text.Create("has").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("09c367ba-98eb-4d82-b05d-cd7f0f58071a")), ExerciseId149, WordNumber.Create(3).Value, Text.Create("been").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("5b954a35-89b0-4d10-81cf-cac1bcac57e7")), ExerciseId149, WordNumber.Create(4).Value, Text.Create("invited").Value, WordType.Verb),
            Word.Create(WordId.Create(Guid.Parse("985f62a3-013a-4a60-96c8-a57f686eb497")), ExerciseId149, WordNumber.Create(5).Value, Text.Create("to").Value, WordType.Preposition),
            Word.Create(WordId.Create(Guid.Parse("c1e91db2-5adb-44f6-8ce4-05d716117495")), ExerciseId149, WordNumber.Create(6).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("2cf01a38-08a2-475d-b16b-00cb9a76fbd4")), ExerciseId149, WordNumber.Create(7).Value, Text.Create("restaurant.").Value, WordType.Noun),

            Word.Create(WordId.Create(Guid.Parse("5a38ce2d-574e-485a-8ebe-5a7e028dc4a6")), ExerciseId150, WordNumber.Create(1).Value, Text.Create("Have").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("2aead743-b8ac-47f2-b999-683c84b21903")), ExerciseId150, WordNumber.Create(2).Value, Text.Create("the").Value, WordType.Determiner),
            Word.Create(WordId.Create(Guid.Parse("12a68596-6621-46eb-8d6a-a006a2f5a16f")), ExerciseId150, WordNumber.Create(3).Value, Text.Create("books").Value, WordType.Noun),
            Word.Create(WordId.Create(Guid.Parse("ef696647-88e8-4de3-b883-816513b4474c")), ExerciseId150, WordNumber.Create(4).Value, Text.Create("been").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("2678982c-4549-4124-85fd-29ef90acdc2d")), ExerciseId150, WordNumber.Create(5).Value, Text.Create("sold?").Value, WordType.Verb),

            #endregion
        ];
    }

    public static IReadOnlyList<object> GetLessonIdsForExercises()
    {
        return
        [
            #region Lesson 1

            new
            {
                Id = 1,
                Value = LessonSeed.GuidForLessonId1,
                ExerciseId = ExerciseId1,
            },
            new
            {
                Id = 2,
                Value = LessonSeed.GuidForLessonId1,
                ExerciseId = ExerciseId2,
            },
            new
            {
                Id = 3,
                Value = LessonSeed.GuidForLessonId1,
                ExerciseId = ExerciseId3,
            },
            new
            {
                Id = 4,
                Value = LessonSeed.GuidForLessonId1,
                ExerciseId = ExerciseId4,
            },
            new
            {
                Id = 5,
                Value = LessonSeed.GuidForLessonId1,
                ExerciseId = ExerciseId5,
            },

            #endregion

            #region Lesson 2

            new
            {
                Id = 6,
                Value = LessonSeed.GuidForLessonId2,
                ExerciseId = ExerciseId6,
            },
            new
            {
                Id = 7,
                Value = LessonSeed.GuidForLessonId2,
                ExerciseId = ExerciseId7,
            },
            new
            {
                Id = 8,
                Value = LessonSeed.GuidForLessonId2,
                ExerciseId = ExerciseId8,
            },
            new
            {
                Id = 9,
                Value = LessonSeed.GuidForLessonId2,
                ExerciseId = ExerciseId9,
            },
            new
            {
                Id = 10,
                Value = LessonSeed.GuidForLessonId2,
                ExerciseId = ExerciseId10,
            },

            #endregion

            #region Lesson 3

            new
            {
                Id = 11,
                Value = LessonSeed.GuidForLessonId3,
                ExerciseId = ExerciseId11,
            },
            new
            {
                Id = 12,
                Value = LessonSeed.GuidForLessonId3,
                ExerciseId = ExerciseId12,
            },
            new
            {
                Id = 13,
                Value = LessonSeed.GuidForLessonId3,
                ExerciseId = ExerciseId13,
            },
            new
            {
                Id = 14,
                Value = LessonSeed.GuidForLessonId3,
                ExerciseId = ExerciseId14,
            },
            new
            {
                Id = 15,
                Value = LessonSeed.GuidForLessonId3,
                ExerciseId = ExerciseId15,
            },

            #endregion

            #region Lesson 4

            new
            {
                Id = 16,
                Value = LessonSeed.GuidForLessonId4,
                ExerciseId = ExerciseId16,
            },
            new
            {
                Id = 17,
                Value = LessonSeed.GuidForLessonId4,
                ExerciseId = ExerciseId17,
            },
            new
            {
                Id = 18,
                Value = LessonSeed.GuidForLessonId4,
                ExerciseId = ExerciseId18,
            },
            new
            {
                Id = 19,
                Value = LessonSeed.GuidForLessonId4,
                ExerciseId = ExerciseId19,
            },
            new
            {
                Id = 20,
                Value = LessonSeed.GuidForLessonId4,
                ExerciseId = ExerciseId20,
            },

            #endregion

            #region Lesson 5

            new
            {
                Id = 21,
                Value = LessonSeed.GuidForLessonId5,
                ExerciseId = ExerciseId21,
            },
            new
            {
                Id = 22,
                Value = LessonSeed.GuidForLessonId5,
                ExerciseId = ExerciseId22,
            },
            new
            {
                Id = 23,
                Value = LessonSeed.GuidForLessonId5,
                ExerciseId = ExerciseId23,
            },
            new
            {
                Id = 24,
                Value = LessonSeed.GuidForLessonId5,
                ExerciseId = ExerciseId24,
            },
            new
            {
                Id = 25,
                Value = LessonSeed.GuidForLessonId5,
                ExerciseId = ExerciseId25,
            },

            #endregion

            #region Lesson 6

            new
            {
                Id = 26,
                Value = LessonSeed.GuidForLessonId6,
                ExerciseId = ExerciseId26,
            },
            new
            {
                Id = 27,
                Value = LessonSeed.GuidForLessonId6,
                ExerciseId = ExerciseId27,
            },
            new
            {
                Id = 28,
                Value = LessonSeed.GuidForLessonId6,
                ExerciseId = ExerciseId28,
            },
            new
            {
                Id = 29,
                Value = LessonSeed.GuidForLessonId6,
                ExerciseId = ExerciseId29,
            },
            new
            {
                Id = 30,
                Value = LessonSeed.GuidForLessonId6,
                ExerciseId = ExerciseId30,
            },

            #endregion

            #region Lesson 7

            new
            {
                Id = 31,
                Value = LessonSeed.GuidForLessonId7,
                ExerciseId = ExerciseId31,
            },
            new
            {
                Id = 32,
                Value = LessonSeed.GuidForLessonId7,
                ExerciseId = ExerciseId32,
            },
            new
            {
                Id = 33,
                Value = LessonSeed.GuidForLessonId7,
                ExerciseId = ExerciseId33,
            },
            new
            {
                Id = 34,
                Value = LessonSeed.GuidForLessonId7,
                ExerciseId = ExerciseId34,
            },
            new
            {
                Id = 35,
                Value = LessonSeed.GuidForLessonId7,
                ExerciseId = ExerciseId35,
            },

            #endregion

            #region Lesson 8

            new
            {
                Id = 36,
                Value = LessonSeed.GuidForLessonId8,
                ExerciseId = ExerciseId36,
            },
            new
            {
                Id = 37,
                Value = LessonSeed.GuidForLessonId8,
                ExerciseId = ExerciseId37,
            },
            new
            {
                Id = 38,
                Value = LessonSeed.GuidForLessonId8,
                ExerciseId = ExerciseId38,
            },
            new
            {
                Id = 39,
                Value = LessonSeed.GuidForLessonId8,
                ExerciseId = ExerciseId39,
            },
            new
            {
                Id = 40,
                Value = LessonSeed.GuidForLessonId8,
                ExerciseId = ExerciseId40,
            },

            #endregion

            #region Lesson 9

            new
            {
                Id = 41,
                Value = LessonSeed.GuidForLessonId9,
                ExerciseId = ExerciseId41,
            },
            new
            {
                Id = 42,
                Value = LessonSeed.GuidForLessonId9,
                ExerciseId = ExerciseId42,
            },
            new
            {
                Id = 43,
                Value = LessonSeed.GuidForLessonId9,
                ExerciseId = ExerciseId43,
            },
            new
            {
                Id = 44,
                Value = LessonSeed.GuidForLessonId9,
                ExerciseId = ExerciseId44,
            },
            new
            {
                Id = 45,
                Value = LessonSeed.GuidForLessonId9,
                ExerciseId = ExerciseId45,
            },

            #endregion

            #region Lesson 10

            new
            {
                Id = 46,
                Value = LessonSeed.GuidForLessonId10,
                ExerciseId = ExerciseId46,
            },
            new
            {
                Id = 47,
                Value = LessonSeed.GuidForLessonId10,
                ExerciseId = ExerciseId47,
            },
            new
            {
                Id = 48,
                Value = LessonSeed.GuidForLessonId10,
                ExerciseId = ExerciseId48,
            },
            new
            {
                Id = 49,
                Value = LessonSeed.GuidForLessonId10,
                ExerciseId = ExerciseId49,
            },
            new
            {
                Id = 50,
                Value = LessonSeed.GuidForLessonId10,
                ExerciseId = ExerciseId50,
            },

            #endregion

            #region Lesson 11

            new
            {
                Id = 51,
                Value = LessonSeed.GuidForLessonId11,
                ExerciseId = ExerciseId51,
            },
            new
            {
                Id = 52,
                Value = LessonSeed.GuidForLessonId11,
                ExerciseId = ExerciseId52,
            },
            new
            {
                Id = 53,
                Value = LessonSeed.GuidForLessonId11,
                ExerciseId = ExerciseId53,
            },
            new
            {
                Id = 54,
                Value = LessonSeed.GuidForLessonId11,
                ExerciseId = ExerciseId54,
            },
            new
            {
                Id = 55,
                Value = LessonSeed.GuidForLessonId11,
                ExerciseId = ExerciseId55,
            },

            #endregion

            #region Lesson 12

            new
            {
                Id = 56,
                Value = LessonSeed.GuidForLessonId12,
                ExerciseId = ExerciseId56,
            },
            new
            {
                Id = 57,
                Value = LessonSeed.GuidForLessonId12,
                ExerciseId = ExerciseId57,
            },
            new
            {
                Id = 58,
                Value = LessonSeed.GuidForLessonId12,
                ExerciseId = ExerciseId58,
            },
            new
            {
                Id = 59,
                Value = LessonSeed.GuidForLessonId12,
                ExerciseId = ExerciseId59,
            },
            new
            {
                Id = 60,
                Value = LessonSeed.GuidForLessonId12,
                ExerciseId = ExerciseId60,
            },

            #endregion

            #region Lesson 13

            new
            {
                Id = 61,
                Value = LessonSeed.GuidForLessonId13,
                ExerciseId = ExerciseId61,
            },
            new
            {
                Id = 62,
                Value = LessonSeed.GuidForLessonId13,
                ExerciseId = ExerciseId62,
            },
            new
            {
                Id = 63,
                Value = LessonSeed.GuidForLessonId13,
                ExerciseId = ExerciseId63,
            },
            new
            {
                Id = 64,
                Value = LessonSeed.GuidForLessonId13,
                ExerciseId = ExerciseId64,
            },
            new
            {
                Id = 65,
                Value = LessonSeed.GuidForLessonId13,
                ExerciseId = ExerciseId65,
            },

            #endregion

            #region Lesson 14

            new
            {
                Id = 66,
                Value = LessonSeed.GuidForLessonId14,
                ExerciseId = ExerciseId66,
            },
            new
            {
                Id = 67,
                Value = LessonSeed.GuidForLessonId14,
                ExerciseId = ExerciseId67,
            },
            new
            {
                Id = 68,
                Value = LessonSeed.GuidForLessonId14,
                ExerciseId = ExerciseId68,
            },
            new
            {
                Id = 69,
                Value = LessonSeed.GuidForLessonId14,
                ExerciseId = ExerciseId69,
            },
            new
            {
                Id = 70,
                Value = LessonSeed.GuidForLessonId14,
                ExerciseId = ExerciseId70,
            },

            #endregion

            #region Lesson 15

            new
            {
                Id = 71,
                Value = LessonSeed.GuidForLessonId15,
                ExerciseId = ExerciseId71,
            },
            new
            {
                Id = 72,
                Value = LessonSeed.GuidForLessonId15,
                ExerciseId = ExerciseId72,
            },
            new
            {
                Id = 73,
                Value = LessonSeed.GuidForLessonId15,
                ExerciseId = ExerciseId73,
            },
            new
            {
                Id = 74,
                Value = LessonSeed.GuidForLessonId15,
                ExerciseId = ExerciseId74,
            },
            new
            {
                Id = 75,
                Value = LessonSeed.GuidForLessonId15,
                ExerciseId = ExerciseId75,
            },

            #endregion

            #region Lesson 16

            new
            {
                Id = 76,
                Value = LessonSeed.GuidForLessonId16,
                ExerciseId = ExerciseId76,
            },
            new
            {
                Id = 77,
                Value = LessonSeed.GuidForLessonId16,
                ExerciseId = ExerciseId77,
            },
            new
            {
                Id = 78,
                Value = LessonSeed.GuidForLessonId16,
                ExerciseId = ExerciseId78,
            },
            new
            {
                Id = 79,
                Value = LessonSeed.GuidForLessonId16,
                ExerciseId = ExerciseId79,
            },
            new
            {
                Id = 80,
                Value = LessonSeed.GuidForLessonId16,
                ExerciseId = ExerciseId80,
            },

            #endregion

            #region Lesson 17

            new
            {
                Id = 81,
                Value = LessonSeed.GuidForLessonId17,
                ExerciseId = ExerciseId81,
            },
            new
            {
                Id = 82,
                Value = LessonSeed.GuidForLessonId17,
                ExerciseId = ExerciseId82,
            },
            new
            {
                Id = 83,
                Value = LessonSeed.GuidForLessonId17,
                ExerciseId = ExerciseId83,
            },
            new
            {
                Id = 84,
                Value = LessonSeed.GuidForLessonId17,
                ExerciseId = ExerciseId84,
            },
            new
            {
                Id = 85,
                Value = LessonSeed.GuidForLessonId17,
                ExerciseId = ExerciseId85,
            },

            #endregion

            #region Lesson 18

            new
            {
                Id = 86,
                Value = LessonSeed.GuidForLessonId18,
                ExerciseId = ExerciseId86,
            },
            new
            {
                Id = 87,
                Value = LessonSeed.GuidForLessonId18,
                ExerciseId = ExerciseId87,
            },
            new
            {
                Id = 88,
                Value = LessonSeed.GuidForLessonId18,
                ExerciseId = ExerciseId88,
            },
            new
            {
                Id = 89,
                Value = LessonSeed.GuidForLessonId18,
                ExerciseId = ExerciseId89,
            },
            new
            {
                Id = 90,
                Value = LessonSeed.GuidForLessonId18,
                ExerciseId = ExerciseId90,
            },

            #endregion

            #region Lesson 20

            new
            {
                Id = 96,
                Value = LessonSeed.GuidForLessonId20,
                ExerciseId = ExerciseId96,
            },
            new
            {
                Id = 97,
                Value = LessonSeed.GuidForLessonId20,
                ExerciseId = ExerciseId97,
            },
            new
            {
                Id = 98,
                Value = LessonSeed.GuidForLessonId20,
                ExerciseId = ExerciseId98,
            },
            new
            {
                Id = 99,
                Value = LessonSeed.GuidForLessonId20,
                ExerciseId = ExerciseId99,
            },
            new
            {
                Id = 100,
                Value = LessonSeed.GuidForLessonId20,
                ExerciseId = ExerciseId100,
            },

            #endregion

            #region Lesson 21

            new
            {
                Id = 101,
                Value = LessonSeed.GuidForLessonId21,
                ExerciseId = ExerciseId101,
            },
            new
            {
                Id = 102,
                Value = LessonSeed.GuidForLessonId21,
                ExerciseId = ExerciseId102,
            },
            new
            {
                Id = 103,
                Value = LessonSeed.GuidForLessonId21,
                ExerciseId = ExerciseId103,
            },
            new
            {
                Id = 104,
                Value = LessonSeed.GuidForLessonId21,
                ExerciseId = ExerciseId104,
            },
            new
            {
                Id = 105,
                Value = LessonSeed.GuidForLessonId21,
                ExerciseId = ExerciseId105,
            },

            #endregion

            #region Lesson 22

            new
            {
                Id = 106,
                Value = LessonSeed.GuidForLessonId22,
                ExerciseId = ExerciseId106,
            },
            new
            {
                Id = 107,
                Value = LessonSeed.GuidForLessonId22,
                ExerciseId = ExerciseId107,
            },
            new
            {
                Id = 108,
                Value = LessonSeed.GuidForLessonId22,
                ExerciseId = ExerciseId108,
            },
            new
            {
                Id = 109,
                Value = LessonSeed.GuidForLessonId22,
                ExerciseId = ExerciseId109,
            },
            new
            {
                Id = 110,
                Value = LessonSeed.GuidForLessonId22,
                ExerciseId = ExerciseId110,
            },

            #endregion

            #region Lesson 24

            new
            {
                Id = 116,
                Value = LessonSeed.GuidForLessonId24,
                ExerciseId = ExerciseId116,
            },
            new
            {
                Id = 117,
                Value = LessonSeed.GuidForLessonId24,
                ExerciseId = ExerciseId117,
            },
            new
            {
                Id = 118,
                Value = LessonSeed.GuidForLessonId24,
                ExerciseId = ExerciseId118,
            },
            new
            {
                Id = 119,
                Value = LessonSeed.GuidForLessonId24,
                ExerciseId = ExerciseId119,
            },
            new
            {
                Id = 120,
                Value = LessonSeed.GuidForLessonId24,
                ExerciseId = ExerciseId120,
            },

            #endregion

            #region Lesson 25

            new
            {
                Id = 121,
                Value = LessonSeed.GuidForLessonId25,
                ExerciseId = ExerciseId121,
            },
            new
            {
                Id = 122,
                Value = LessonSeed.GuidForLessonId25,
                ExerciseId = ExerciseId122,
            },
            new
            {
                Id = 123,
                Value = LessonSeed.GuidForLessonId25,
                ExerciseId = ExerciseId123,
            },
            new
            {
                Id = 124,
                Value = LessonSeed.GuidForLessonId25,
                ExerciseId = ExerciseId124,
            },
            new
            {
                Id = 125,
                Value = LessonSeed.GuidForLessonId25,
                ExerciseId = ExerciseId125,
            },

            #endregion

            #region Lesson 26

            new
            {
                Id = 126,
                Value = LessonSeed.GuidForLessonId26,
                ExerciseId = ExerciseId126,
            },
            new
            {
                Id = 127,
                Value = LessonSeed.GuidForLessonId26,
                ExerciseId = ExerciseId127,
            },
            new
            {
                Id = 128,
                Value = LessonSeed.GuidForLessonId26,
                ExerciseId = ExerciseId128,
            },
            new
            {
                Id = 129,
                Value = LessonSeed.GuidForLessonId26,
                ExerciseId = ExerciseId129,
            },
            new
            {
                Id = 130,
                Value = LessonSeed.GuidForLessonId26,
                ExerciseId = ExerciseId130,
            },

            #endregion

            #region Lesson 28

            new
            {
                Id = 136,
                Value = LessonSeed.GuidForLessonId28,
                ExerciseId = ExerciseId136,
            },
            new
            {
                Id = 137,
                Value = LessonSeed.GuidForLessonId28,
                ExerciseId = ExerciseId137,
            },
            new
            {
                Id = 138,
                Value = LessonSeed.GuidForLessonId28,
                ExerciseId = ExerciseId138,
            },
            new
            {
                Id = 139,
                Value = LessonSeed.GuidForLessonId28,
                ExerciseId = ExerciseId139,
            },
            new
            {
                Id = 140,
                Value = LessonSeed.GuidForLessonId28,
                ExerciseId = ExerciseId140,
            },

            #endregion

            #region Lesson 29

            new
            {
                Id = 141,
                Value = LessonSeed.GuidForLessonId29,
                ExerciseId = ExerciseId141,
            },
            new
            {
                Id = 142,
                Value = LessonSeed.GuidForLessonId29,
                ExerciseId = ExerciseId142,
            },
            new
            {
                Id = 143,
                Value = LessonSeed.GuidForLessonId29,
                ExerciseId = ExerciseId143,
            },
            new
            {
                Id = 144,
                Value = LessonSeed.GuidForLessonId29,
                ExerciseId = ExerciseId144,
            },
            new
            {
                Id = 145,
                Value = LessonSeed.GuidForLessonId29,
                ExerciseId = ExerciseId145,
            },

            #endregion

            #region Lesson 30

            new
            {
                Id = 146,
                Value = LessonSeed.GuidForLessonId30,
                ExerciseId = ExerciseId146,
            },
            new
            {
                Id = 147,
                Value = LessonSeed.GuidForLessonId30,
                ExerciseId = ExerciseId147,
            },
            new
            {
                Id = 148,
                Value = LessonSeed.GuidForLessonId30,
                ExerciseId = ExerciseId148,
            },
            new
            {
                Id = 149,
                Value = LessonSeed.GuidForLessonId30,
                ExerciseId = ExerciseId149,
            },
            new
            {
                Id = 150,
                Value = LessonSeed.GuidForLessonId30,
                ExerciseId = ExerciseId150,
            },

            #endregion

            #region Lesson 19

            new
            {
                Id = 156,
                Value = LessonSeed.GuidForLessonId19,
                ExerciseId = ExerciseId76,
            },
            new
            {
                Id = 157,
                Value = LessonSeed.GuidForLessonId19,
                ExerciseId = ExerciseId77,
            },
            new
            {
                Id = 158,
                Value = LessonSeed.GuidForLessonId19,
                ExerciseId = ExerciseId78,
            },
            new
            {
                Id = 159,
                Value = LessonSeed.GuidForLessonId19,
                ExerciseId = ExerciseId79,
            },
            new
            {
                Id = 160,
                Value = LessonSeed.GuidForLessonId19,
                ExerciseId = ExerciseId80,
            },

            new
            {
                Id = 161,
                Value = LessonSeed.GuidForLessonId19,
                ExerciseId = ExerciseId81,
            },
            new
            {
                Id = 162,
                Value = LessonSeed.GuidForLessonId19,
                ExerciseId = ExerciseId82,
            },
            new
            {
                Id = 163,
                Value = LessonSeed.GuidForLessonId19,
                ExerciseId = ExerciseId83,
            },
            new
            {
                Id = 164,
                Value = LessonSeed.GuidForLessonId19,
                ExerciseId = ExerciseId84,
            },
            new
            {
                Id = 165,
                Value = LessonSeed.GuidForLessonId19,
                ExerciseId = ExerciseId85,
            },

            new
            {
                Id = 166,
                Value = LessonSeed.GuidForLessonId19,
                ExerciseId = ExerciseId86,
            },
            new
            {
                Id = 167,
                Value = LessonSeed.GuidForLessonId19,
                ExerciseId = ExerciseId87,
            },
            new
            {
                Id = 168,
                Value = LessonSeed.GuidForLessonId19,
                ExerciseId = ExerciseId88,
            },
            new
            {
                Id = 169,
                Value = LessonSeed.GuidForLessonId19,
                ExerciseId = ExerciseId89,
            },
            new
            {
                Id = 170,
                Value = LessonSeed.GuidForLessonId19,
                ExerciseId = ExerciseId90,
            },

            #endregion

            #region Lesson 23

            new
            {
                Id = 171,
                Value = LessonSeed.GuidForLessonId23,
                ExerciseId = ExerciseId96,
            },
            new
            {
                Id = 172,
                Value = LessonSeed.GuidForLessonId23,
                ExerciseId = ExerciseId97,
            },
            new
            {
                Id = 173,
                Value = LessonSeed.GuidForLessonId23,
                ExerciseId = ExerciseId98,
            },
            new
            {
                Id = 174,
                Value = LessonSeed.GuidForLessonId23,
                ExerciseId = ExerciseId99,
            },
            new
            {
                Id = 175,
                Value = LessonSeed.GuidForLessonId23,
                ExerciseId = ExerciseId100,
            },

            new
            {
                Id = 176,
                Value = LessonSeed.GuidForLessonId23,
                ExerciseId = ExerciseId101,
            },
            new
            {
                Id = 177,
                Value = LessonSeed.GuidForLessonId23,
                ExerciseId = ExerciseId102,
            },
            new
            {
                Id = 178,
                Value = LessonSeed.GuidForLessonId23,
                ExerciseId = ExerciseId103,
            },
            new
            {
                Id = 179,
                Value = LessonSeed.GuidForLessonId23,
                ExerciseId = ExerciseId104,
            },
            new
            {
                Id = 180,
                Value = LessonSeed.GuidForLessonId23,
                ExerciseId = ExerciseId105,
            },

            new
            {
                Id = 181,
                Value = LessonSeed.GuidForLessonId23,
                ExerciseId = ExerciseId106,
            },
            new
            {
                Id = 182,
                Value = LessonSeed.GuidForLessonId23,
                ExerciseId = ExerciseId107,
            },
            new
            {
                Id = 183,
                Value = LessonSeed.GuidForLessonId23,
                ExerciseId = ExerciseId108,
            },
            new
            {
                Id = 184,
                Value = LessonSeed.GuidForLessonId23,
                ExerciseId = ExerciseId109,
            },
            new
            {
                Id = 185,
                Value = LessonSeed.GuidForLessonId23,
                ExerciseId = ExerciseId110,
            },

            #endregion

            #region Lesson 27

            new
            {
                Id = 186,
                Value = LessonSeed.GuidForLessonId27,
                ExerciseId = ExerciseId116,
            },
            new
            {
                Id = 187,
                Value = LessonSeed.GuidForLessonId27,
                ExerciseId = ExerciseId117,
            },
            new
            {
                Id = 188,
                Value = LessonSeed.GuidForLessonId27,
                ExerciseId = ExerciseId118,
            },
            new
            {
                Id = 189,
                Value = LessonSeed.GuidForLessonId27,
                ExerciseId = ExerciseId119,
            },
            new
            {
                Id = 190,
                Value = LessonSeed.GuidForLessonId27,
                ExerciseId = ExerciseId120,
            },

            new
            {
                Id = 191,
                Value = LessonSeed.GuidForLessonId27,
                ExerciseId = ExerciseId121,
            },
            new
            {
                Id = 192,
                Value = LessonSeed.GuidForLessonId27,
                ExerciseId = ExerciseId122,
            },
            new
            {
                Id = 193,
                Value = LessonSeed.GuidForLessonId27,
                ExerciseId = ExerciseId123,
            },
            new
            {
                Id = 194,
                Value = LessonSeed.GuidForLessonId27,
                ExerciseId = ExerciseId124,
            },
            new
            {
                Id = 195,
                Value = LessonSeed.GuidForLessonId27,
                ExerciseId = ExerciseId125,
            },

            new
            {
                Id = 196,
                Value = LessonSeed.GuidForLessonId27,
                ExerciseId = ExerciseId126,
            },
            new
            {
                Id = 197,
                Value = LessonSeed.GuidForLessonId27,
                ExerciseId = ExerciseId127,
            },
            new
            {
                Id = 198,
                Value = LessonSeed.GuidForLessonId27,
                ExerciseId = ExerciseId128,
            },
            new
            {
                Id = 199,
                Value = LessonSeed.GuidForLessonId27,
                ExerciseId = ExerciseId129,
            },
            new
            {
                Id = 200,
                Value = LessonSeed.GuidForLessonId27,
                ExerciseId = ExerciseId130,
            },

            #endregion

            #region Lesson 31

            new
            {
                Id = 201,
                Value = LessonSeed.GuidForLessonId31,
                ExerciseId = ExerciseId136,
            },
            new
            {
                Id = 202,
                Value = LessonSeed.GuidForLessonId31,
                ExerciseId = ExerciseId137,
            },
            new
            {
                Id = 203,
                Value = LessonSeed.GuidForLessonId31,
                ExerciseId = ExerciseId138,
            },
            new
            {
                Id = 204,
                Value = LessonSeed.GuidForLessonId31,
                ExerciseId = ExerciseId139,
            },
            new
            {
                Id = 205,
                Value = LessonSeed.GuidForLessonId31,
                ExerciseId = ExerciseId140,
            },

            new
            {
                Id = 206,
                Value = LessonSeed.GuidForLessonId31,
                ExerciseId = ExerciseId141,
            },
            new
            {
                Id = 207,
                Value = LessonSeed.GuidForLessonId31,
                ExerciseId = ExerciseId142,
            },
            new
            {
                Id = 208,
                Value = LessonSeed.GuidForLessonId31,
                ExerciseId = ExerciseId143,
            },
            new
            {
                Id = 209,
                Value = LessonSeed.GuidForLessonId31,
                ExerciseId = ExerciseId144,
            },
            new
            {
                Id = 210,
                Value = LessonSeed.GuidForLessonId31,
                ExerciseId = ExerciseId145,
            },

            new
            {
                Id = 211,
                Value = LessonSeed.GuidForLessonId31,
                ExerciseId = ExerciseId146,
            },
            new
            {
                Id = 212,
                Value = LessonSeed.GuidForLessonId31,
                ExerciseId = ExerciseId147,
            },
            new
            {
                Id = 213,
                Value = LessonSeed.GuidForLessonId31,
                ExerciseId = ExerciseId148,
            },
            new
            {
                Id = 214,
                Value = LessonSeed.GuidForLessonId31,
                ExerciseId = ExerciseId149,
            },
            new
            {
                Id = 215,
                Value = LessonSeed.GuidForLessonId31,
                ExerciseId = ExerciseId150,
            },

            #endregion
        ];
    }
}