
using System.Collections.Generic;
using UnityEngine;

namespace YG
{
    public partial class SavesYG
    {
        // Тестовые сохранения для демо сцены
        // Можно удалить этот код, но тогда удалите и демо (папка Example)
        public int money = 1;                       // Можно задать полям значения по умолчанию
        public string newPlayerName = "Hello!";
        public bool[] openLevels = new bool[3];

        // Ваши сохранения
        public int bestScore = 0;
        public float score = 500000;
        public float cup = 0;
        public float rate = 100;
        public float bigRate = 500f;
        public float finalBigRate;
        public float bonusRate = 0;
        //public float finalRate;
        public float upRatePrise = 2500;
        public float coeffRate = 0;
        public float finalCoeffRate = 0;

        public float velocity = 5f;

        public int indexDialog;
        public bool enableNextDialog = true;
        public int indexAction = 0;
        public int indexActionName = 0;

        public int currentPetIndex = 999;
        public int currentPetIndexNew = 999;
        public bool hasPets = false;
        public bool hasPetsNew = false;
        public bool[] closePanels = new bool[23];

        public int petBought_0;
        public int petBought_1;
        public int petBought_2;
        public int petBought_3;
        public int petBought_4;
        public int petBought_5;

        public int petBoughtNew_0;
        public int petBoughtNew_1;
        public int petBoughtNew_2;
        public int petBoughtNew_3;
        public int petBoughtNew_4;
        public int petBoughtNew_5;
        public int petBoughtNew_6;
        public int petBoughtNew_7;
        public int petBoughtNew_8;
        public int petBoughtNew_9;
        public int petBoughtNew_10;
        public int petBoughtNew_11;
        public int petBoughtNew_12;
        public int petBoughtNew_13;
        public int petBoughtNew_14;
        public int petBoughtNew_15;
        public int petBoughtNew_16;
        public int petBoughtNew_17;
        public int petBoughtNew_18;
        public int petBoughtNew_19;
        public int petBoughtNew_20;
        public int petBoughtNew_21;
        public int petBoughtNew_22;

        public int currentTrailIndex = 999;
        public bool hasTrail = false;
        public int trailBought_0;
        public int trailBought_1;
        public int trailBought_2;
        public int trailBought_3;
        public int trailBought_4;
        public int trailBought_5;
        public int trailBought_6;
        public int trailBought_7;

        public int currentHatIndex = 999;
        public bool hasHat = false;
        public int hatBought_0;
        public int hatBought_1;
        public int hatBought_2;
        public int hatBought_3;
        public int hatBought_4;
        public int hatBought_5;
        public int hatBought_6;
        public int hatBought_7;

        public int indexSpawnNPC;

        public int indexSpawnObjects;
        public bool enableSpawnObgect = true;

        public int LastDate;
        public int Day_1;
        public int Day_2;
        public int Day_3;
        public int Day_4;
        public int Day_5;
        public int Day_6;
        public int Day_7;

        public bool mineUnlock_0;
        public bool mineUnlock_1;
        public bool mineUnlock_2;
        public bool mineUnlock_3;
        public bool mineUnlock_4;
        public bool mineUnlock_5;
        public bool mineUnlock_6;
        public bool mineUnlock_7;
        public bool mineUnlock_8;
        public bool mineUnlock_9;
        public bool mineUnlock_10;
        public bool mineUnlock_11;
        public bool mineUnlock_12;
        public bool mineUnlock_13;

        public int upMineIndex0;
        public int upMineIndex1;
        public int upMineIndex2;
        public int upMineIndex3;
        public int upMineIndex4;
        public int upMineIndex5;
        public int upMineIndex6;
        public int upMineIndex7;
        public int upMineIndex8;
        public int upMineIndex9;
        public int upMineIndex10;
        public int upMineIndex11;
        public int upMineIndex12;
        public int upMineIndex13;

        public bool buildHouseUnlock_0;
        public bool buildHouseUnlock_1;
        public bool buildHouseUnlock_2;
        public bool buildHouseUnlock_3;
        public bool buildHouseUnlock_4;
        public bool buildHouseUnlock_5;
        public bool buildHouseUnlock_6;
        public bool buildHouseUnlock_7;
        public bool buildHouseUnlock_8;
        public bool buildHouseUnlock_9;
        public bool buildHouseUnlock_10;
        public bool buildHouseUnlock_11;
        public bool buildHouseUnlock_12;
        public bool buildHouseUnlock_13;
        public bool buildHouseUnlock_14;
        public bool buildHouseUnlock_15;
        public bool buildHouseUnlock_16;
        public bool buildHouseUnlock_17;
        public bool buildHouseUnlock_18;
        public bool buildHouseUnlock_19;
        public bool buildHouseUnlock_20;
        public bool buildHouseUnlock_21;
        public bool buildHouseUnlock_22;
        public bool buildHouseUnlock_23;
        public bool buildHouseUnlock_24;
        public bool buildHouseUnlock_25;
        public bool buildHouseUnlock_26;
        public bool buildHouseUnlock_27;
        public bool buildHouseUnlock_28;
        public bool buildHouseUnlock_29;
        public bool buildHouseUnlock_30;
        public bool buildHouseUnlock_31;
        public bool buildHouseUnlock_32;
        public bool buildHouseUnlock_33;
        public bool buildHouseUnlock_34;
        public bool buildHouseUnlock_35;
        public bool buildHouseUnlock_36;
        public bool buildHouseUnlock_37;
        public bool buildHouseUnlock_38;
        public bool buildHouseUnlock_39;
        public bool buildHouseUnlock_40;
        public bool buildHouseUnlock_41;
        public bool buildHouseUnlock_42;
        public bool buildHouseUnlock_43;
        public bool buildHouseUnlock_44;
        public bool buildHouseUnlock_45;
        public bool buildHouseUnlock_46;
        public bool buildHouseUnlock_47;
        public bool buildHouseUnlock_48;
        public bool buildHouseUnlock_49;
        public bool buildHouseUnlock_50;
        public bool buildHouseUnlock_51;
        public bool buildHouseUnlock_52;
        public bool buildHouseUnlock_53;
        public bool buildHouseUnlock_54;
        public bool buildHouseUnlock_55;
        public bool buildHouseUnlock_56;
        public bool buildHouseUnlock_57;
        public bool buildHouseUnlock_58;
        public bool buildHouseUnlock_59;
        public bool buildHouseUnlock_60;
        public bool buildHouseUnlock_61;
        public bool buildHouseUnlock_62;
        public bool buildHouseUnlock_63;
        public bool buildHouseUnlock_64;
        public bool buildHouseUnlock_65;
        public bool buildHouseUnlock_66;
        public bool buildHouseUnlock_67;
        public bool buildHouseUnlock_68;
        public bool buildHouseUnlock_69;
        public bool buildHouseUnlock_70;
        public bool buildHouseUnlock_71;
        public bool buildHouseUnlock_72;
        public bool buildHouseUnlock_73;
        public bool buildHouseUnlock_74;
        public bool buildHouseUnlock_75;
        public bool buildHouseUnlock_76;
        public bool buildHouseUnlock_77;
        public bool buildHouseUnlock_78;
        public bool buildHouseUnlock_79;
        public bool buildHouseUnlock_80;

        public bool workerUnlock_0;
        public bool workerUnlock_1;
        public bool workerUnlock_2;
        public bool workerUnlock_3;
        public bool workerUnlock_4;
        public bool workerUnlock_5;
        public bool workerUnlock_6;
        public bool workerUnlock_7;
        public bool workerUnlock_8;
        public bool workerUnlock_9;
        public bool workerUnlock_10;
        public bool workerUnlock_11;
        public bool workerUnlock_12;
        public bool workerUnlock_13;
        public bool workerUnlock_14;
        public bool workerUnlock_15;
        public bool workerUnlock_16;
        public bool workerUnlock_17;
        public bool workerUnlock_18;
        public bool workerUnlock_19;
        public bool workerUnlock_20;
        public bool workerUnlock_21;
        public bool workerUnlock_22;
        public bool workerUnlock_23;
        public bool workerUnlock_24;
        public bool workerUnlock_25;

        public int damageBoxing = 1;
        public bool[] walls = new bool[23];
        public bool[] bagPlaces = new bool[11];
        public bool[] seedPlaces = new bool[11];
        public bool[] doorsBranrot = new bool[11];
        public bool[] homesBranrot = new bool[4];
        public bool[] objFirst = new bool[3];
        public bool isHideTask1;
        public bool isHideTask2;

        public bool[] completeQuest = new bool[40];
        public int couterQuestFinished = 0;

        public bool isBranrotHand;
        public bool isFirstGameOpen = true;

        public bool[] slotPlBr = new bool[31];

        public float neckHightLocal = 0f;
        public int neckHeightUI = 0;
        public float speedGrowNeck = 0.1f;
        public int neckSecondRateUI = 1;

        public int countCubes = 100;
        public bool[] unlockBranrot = new bool[230];

        public int currentCartIndex = 0;
        public bool hasCarts = true;
        public int cartBought_0 = 1;
        public int cartBought_1 = 0;
        public int cartBought_2 = 0;
        public int cartBought_3 = 0;
        public int cartBought_4 = 0;
        public int cartBought_5 = 0;
        public int cartBought_6 = 0;
        public int cartBought_7 = 0;
        public int cartBought_8 = 0;
        public int cartBought_9 = 0;
        public int cartBought_10 = 0;
        public int cartBought_11 = 0;
        public int cartBought_12 = 0;
        public int cartBought_13 = 0;
        public int cartBought_14 = 0;
        public int cartBought_15 = 0;
        public int cartBought_16 = 0;
        public int cartBought_17 = 0;
        public int cartBought_18 = 0;
        public int cartBought_19 = 0;
        public int cartBought_20 = 0;
        public int cartBought_21 = 0;
        public int cartBought_22 = 0;
        public int cartBought_23 = 0;
        public int cartBought_24 = 0;
        public int cartBought_25 = 0;
        public int cartBought_26 = 0;
        public int cartBought_27 = 0;

        //public Vector3 neckPosition = new Vector3(806.48f, 10.30f, -6.33f);
        public SavesYG()
        {
            //objFirst[0] = true;
        }
    }
}
