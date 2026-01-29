using System.Collections;
using TMPro;
using UnityEngine;
using YG;

public class BuildHouse: MonoBehaviour
{
    [SerializeField] int houseIndex = 0;
    [SerializeField] int housePrice = 0;
    [SerializeField] TextMeshProUGUI housePriceText;
    [SerializeField] GameObject houseObject;
    [SerializeField] MeshRenderer houseMeshBTN;
    [SerializeField] GameObject[] houseHideItems;
    [SerializeField] GameObject[] nextHouseObjects;

    bool houseUnlock = false;
    bool openHouse = true;
    bool isFirstGetload = true;

    void Start()
    {
        if (YandexGame.SDKEnabled == true)
        {
            GetLoad();
        }
    }

    private void OnEnable() => YandexGame.GetDataEvent += GetLoad;

    private void OnDisable() => YandexGame.GetDataEvent -= GetLoad;

    private void GetLoad()
    {
        if (houseIndex == 0)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_0;
        } else if (houseIndex == 1)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_1;
        }
        else if (houseIndex == 2)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_2;
        }
        else if (houseIndex == 3)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_3;
        }
        else if (houseIndex == 4)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_4;
        }
        else if (houseIndex == 5)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_5;
        }
        else if (houseIndex == 6)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_6;
        }
        else if (houseIndex == 7)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_7;
        }
        else if (houseIndex == 8)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_8;
        }
        else if (houseIndex == 9)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_9;
        }
        else if (houseIndex == 10)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_10;
        }
        else if (houseIndex == 11)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_11;
        }
        else if (houseIndex == 12)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_12;
        }
        else if (houseIndex == 13)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_13;
        }
        else if (houseIndex == 14)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_14;
        }
        else if (houseIndex == 15)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_15;
        }
        else if (houseIndex == 16)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_16;
        }
        else if (houseIndex == 17)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_17;
        }
        else if (houseIndex == 18)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_18;
        }
        else if (houseIndex == 19)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_19;
        }
        else if (houseIndex == 20)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_20;
        }
        else if (houseIndex == 21)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_21;
        }
        else if (houseIndex == 22)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_22;
        }
        else if (houseIndex == 23)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_23;
        }
        else if (houseIndex == 24)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_24;
        }
        else if (houseIndex == 25)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_25;
        }
        else if (houseIndex == 26)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_26;
        }
        else if (houseIndex == 27)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_27;
        }
        else if (houseIndex == 28)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_28;
        }
        else if (houseIndex == 29)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_29;
        }
        else if (houseIndex == 30)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_30;
        }
        else if (houseIndex == 31)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_31;
        }
        else if (houseIndex == 32)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_32;
        }
        else if (houseIndex == 33)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_33;
        }
        else if (houseIndex == 34)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_34;
        }
        else if (houseIndex == 35)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_35;
        }
        else if (houseIndex == 36)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_36;
        }
        else if (houseIndex == 37)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_37;
        }
        else if (houseIndex == 38)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_38;
        }
        else if (houseIndex == 39)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_39;
        }
        else if (houseIndex == 40)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_40;
        }
        else if (houseIndex == 41)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_41;
        }
        else if (houseIndex == 42)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_42;
        }
        else if (houseIndex == 43)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_43;
        }
        else if (houseIndex == 44)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_44;
        }
        else if (houseIndex == 45)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_45;
        }
        else if (houseIndex == 46)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_46;
        }
        else if (houseIndex == 47)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_47;
        }
        else if (houseIndex == 48)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_48;
        }
        else if (houseIndex == 49)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_49;
        }
        else if (houseIndex == 50)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_50;
        }
        else if (houseIndex == 51)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_51;
        }
        else if (houseIndex == 52)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_52;
        }
        else if (houseIndex == 53)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_53;
        }
        else if (houseIndex == 54)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_54;
        }
        else if (houseIndex == 55)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_55;
        }
        else if (houseIndex == 56)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_56;
        }
        else if (houseIndex == 57)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_57;
        }
        else if (houseIndex == 58)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_58;
        }
        else if (houseIndex == 59)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_59;
        }
        else if (houseIndex == 60)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_60;
        }
        else if (houseIndex == 61)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_61;
        }
        else if (houseIndex == 62)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_62;
        }
        else if (houseIndex == 63)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_63;
        }
        else if (houseIndex == 64)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_64;
        }
        else if (houseIndex == 65)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_65;
        }
        else if (houseIndex == 66)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_66;
        }
        else if (houseIndex == 67)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_67;
        }
        else if (houseIndex == 68)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_68;
        }
        else if (houseIndex == 69)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_69;
        }
        else if (houseIndex == 70)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_70;
        }
        else if (houseIndex == 71)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_71;
        }
        else if (houseIndex == 72)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_72;
        }
        else if (houseIndex == 73)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_73;
        }
        else if (houseIndex == 74)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_74;
        }
        else if (houseIndex == 75)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_75;
        }
        else if (houseIndex == 76)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_76;
        }
        else if (houseIndex == 77)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_77;
        }
        else if (houseIndex == 78)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_78;
        }
        else if (houseIndex == 79)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_79;
        }
        else if (houseIndex == 80)
        {
            houseUnlock = YandexGame.savesData.buildHouseUnlock_80;
        }
        else
        {
            houseUnlock = false;
        }

        if (houseUnlock && isFirstGetload)
        {
            isFirstGetload = false;

            houseObject.SetActive(true);

            houseMeshBTN.enabled = false;
            foreach (GameObject item in houseHideItems)
            {
                item.SetActive(false);
            }
            foreach (GameObject nextHouse in nextHouseObjects)
            {
                nextHouse.SetActive(true);
            }
        }
        else
        {
            housePriceText.text = ShortScaleString.parseFloat(housePrice, 1, 1000, true).ToString();
        }
    }
    private void UnlockHouse()
    {
        if (Score.Instance.score >= housePrice)
        {
            Score.Instance.DownScore(housePrice);
            houseObject.SetActive(true);

            houseMeshBTN.enabled = false;
            foreach (GameObject item in houseHideItems)
            {
                item.SetActive(false);
            }
            foreach (GameObject nextHouse in nextHouseObjects)
            {
                nextHouse.SetActive(true);
            }

            houseUnlock = true;

            SaveHouse();

        } else
        {
            SoundManager.Instance.notmoney.Play();
        }
    }

    private void SaveHouse()
    {
        if (houseIndex == 0)
        {
            YandexGame.savesData.buildHouseUnlock_0 = openHouse;
        }
        else if (houseIndex == 1)
        {
            YandexGame.savesData.buildHouseUnlock_1 = openHouse;
        }
        else if (houseIndex == 2)
        {
            YandexGame.savesData.buildHouseUnlock_2 = openHouse;
        }
        else if (houseIndex == 3)
        {
            YandexGame.savesData.buildHouseUnlock_3 = openHouse;
        }
        else if (houseIndex == 4)
        {
            YandexGame.savesData.buildHouseUnlock_4 = openHouse;
        }
        else if (houseIndex == 5)
        {
            YandexGame.savesData.buildHouseUnlock_5 = openHouse;
        }
        else if (houseIndex == 6)
        {
            YandexGame.savesData.buildHouseUnlock_6 = openHouse;
        }
        else if (houseIndex == 7)
        {
            YandexGame.savesData.buildHouseUnlock_7 = openHouse;
        }
        else if (houseIndex == 8)
        {
            YandexGame.savesData.buildHouseUnlock_8 = openHouse;
        }
        else if (houseIndex == 9)
        {
            YandexGame.savesData.buildHouseUnlock_9 = openHouse;
        }
        else if (houseIndex == 10)
        {
            YandexGame.savesData.buildHouseUnlock_10 = openHouse;
        }
        else if (houseIndex == 11)
        {
            YandexGame.savesData.buildHouseUnlock_11 = openHouse;
        }
        else if (houseIndex == 12)
        {
            YandexGame.savesData.buildHouseUnlock_12 = openHouse;
        }
        else if (houseIndex == 13)
        {
            YandexGame.savesData.buildHouseUnlock_13 = openHouse;
        }
        else if (houseIndex == 14)
        {
            YandexGame.savesData.buildHouseUnlock_14 = openHouse;
        }
        else if (houseIndex == 15)
        {
            YandexGame.savesData.buildHouseUnlock_15 = openHouse;
        }
        else if (houseIndex == 16)
        {
            YandexGame.savesData.buildHouseUnlock_16 = openHouse;
        }
        else if (houseIndex == 17)
        {
            YandexGame.savesData.buildHouseUnlock_17 = openHouse;
        }
        else if (houseIndex == 18)
        {
            YandexGame.savesData.buildHouseUnlock_18 = openHouse;
        }
        else if (houseIndex == 19)
        {
            YandexGame.savesData.buildHouseUnlock_19 = openHouse;
        }
        else if (houseIndex == 20)
        {
            YandexGame.savesData.buildHouseUnlock_20 = openHouse;
        }
        else if (houseIndex == 21)
        {
            YandexGame.savesData.buildHouseUnlock_21 = openHouse;
        }
        else if (houseIndex == 22)
        {
            YandexGame.savesData.buildHouseUnlock_22 = openHouse;
        }
        else if (houseIndex == 23)
        {
            YandexGame.savesData.buildHouseUnlock_23 = openHouse;
        }
        else if (houseIndex == 24)
        {
            YandexGame.savesData.buildHouseUnlock_24 = openHouse;
        }
        else if (houseIndex == 25)
        {
            YandexGame.savesData.buildHouseUnlock_25 = openHouse;
        }
        else if (houseIndex == 26)
        {
            YandexGame.savesData.buildHouseUnlock_26 = openHouse;
        }
        else if (houseIndex == 27)
        {
            YandexGame.savesData.buildHouseUnlock_27 = openHouse;
        }
        else if (houseIndex == 28)
        {
            YandexGame.savesData.buildHouseUnlock_28 = openHouse;
        }
        else if (houseIndex == 29)
        {
            YandexGame.savesData.buildHouseUnlock_29 = openHouse;
        }
        else if (houseIndex == 30)
        {
            YandexGame.savesData.buildHouseUnlock_30 = openHouse;
        }
        else if (houseIndex == 31)
        {
            YandexGame.savesData.buildHouseUnlock_31 = openHouse;
        }
        else if (houseIndex == 32)
        {
            YandexGame.savesData.buildHouseUnlock_32 = openHouse;
        }
        else if (houseIndex == 33)
        {
            YandexGame.savesData.buildHouseUnlock_33 = openHouse;
        }
        else if (houseIndex == 34)
        {
            YandexGame.savesData.buildHouseUnlock_34 = openHouse;
        }
        else if (houseIndex == 35)
        {
            YandexGame.savesData.buildHouseUnlock_35 = openHouse;
        }
        else if (houseIndex == 36)
        {
            YandexGame.savesData.buildHouseUnlock_36 = openHouse;
        }
        else if (houseIndex == 37)
        {
            YandexGame.savesData.buildHouseUnlock_37 = openHouse;
        }
        else if (houseIndex == 38)
        {
            YandexGame.savesData.buildHouseUnlock_38 = openHouse;
        }
        else if (houseIndex == 39)
        {
            YandexGame.savesData.buildHouseUnlock_39 = openHouse;
        }
        else if (houseIndex == 40)
        {
            YandexGame.savesData.buildHouseUnlock_40 = openHouse;
        }
        else if (houseIndex == 41)
        {
            YandexGame.savesData.buildHouseUnlock_41 = openHouse;
        }
        else if (houseIndex == 42)
        {
            YandexGame.savesData.buildHouseUnlock_42 = openHouse;
        }
        else if (houseIndex == 43)
        {
            YandexGame.savesData.buildHouseUnlock_43 = openHouse;
        }
        else if (houseIndex == 44)
        {
            YandexGame.savesData.buildHouseUnlock_44 = openHouse;
        }
        else if (houseIndex == 45)
        {
            YandexGame.savesData.buildHouseUnlock_45 = openHouse;
        }
        else if (houseIndex == 46)
        {
            YandexGame.savesData.buildHouseUnlock_46 = openHouse;
        }
        else if (houseIndex == 47)
        {
            YandexGame.savesData.buildHouseUnlock_47 = openHouse;
        }
        else if (houseIndex == 48)
        {
            YandexGame.savesData.buildHouseUnlock_48 = openHouse;
        }
        else if (houseIndex == 49)
        {
            YandexGame.savesData.buildHouseUnlock_49 = openHouse;
        }
        else if (houseIndex == 50)
        {
            YandexGame.savesData.buildHouseUnlock_50 = openHouse;
        }
        else if (houseIndex == 51)
        {
            YandexGame.savesData.buildHouseUnlock_51 = openHouse;
        }
        else if (houseIndex == 52)
        {
            YandexGame.savesData.buildHouseUnlock_52 = openHouse;
        }
        else if (houseIndex == 53)
        {
            YandexGame.savesData.buildHouseUnlock_53 = openHouse;
        }
        else if (houseIndex == 54)
        {
            YandexGame.savesData.buildHouseUnlock_54 = openHouse;
        }
        else if (houseIndex == 55)
        {
            YandexGame.savesData.buildHouseUnlock_55 = openHouse;
        }
        else if (houseIndex == 56)
        {
            YandexGame.savesData.buildHouseUnlock_56 = openHouse;
        }
        else if (houseIndex == 57)
        {
            YandexGame.savesData.buildHouseUnlock_57 = openHouse;
        }
        else if (houseIndex == 58)
        {
            YandexGame.savesData.buildHouseUnlock_58 = openHouse;
        }
        else if (houseIndex == 59)
        {
            YandexGame.savesData.buildHouseUnlock_59 = openHouse;
        }
        else if (houseIndex == 60)
        {
            YandexGame.savesData.buildHouseUnlock_60 = openHouse;
        }
        else if (houseIndex == 61)
        {
            YandexGame.savesData.buildHouseUnlock_61 = openHouse;
        }
        else if (houseIndex == 62)
        {
            YandexGame.savesData.buildHouseUnlock_62 = openHouse;
        }
        else if (houseIndex == 63)
        {
            YandexGame.savesData.buildHouseUnlock_63 = openHouse;
        }
        else if (houseIndex == 64)
        {
            YandexGame.savesData.buildHouseUnlock_64 = openHouse;
        }
        else if (houseIndex == 65)
        {
            YandexGame.savesData.buildHouseUnlock_65 = openHouse;
        }
        else if (houseIndex == 66)
        {
            YandexGame.savesData.buildHouseUnlock_66 = openHouse;
        }
        else if (houseIndex == 67)
        {
            YandexGame.savesData.buildHouseUnlock_67 = openHouse;
        }
        else if (houseIndex == 68)
        {
            YandexGame.savesData.buildHouseUnlock_68 = openHouse;
        }
        else if (houseIndex == 69)
        {
            YandexGame.savesData.buildHouseUnlock_69 = openHouse;
        }
        else if (houseIndex == 70)
        {
            YandexGame.savesData.buildHouseUnlock_70 = openHouse;
        }
        else if (houseIndex == 71)
        {
            YandexGame.savesData.buildHouseUnlock_71 = openHouse;
        }
        else if (houseIndex == 72)
        {
            YandexGame.savesData.buildHouseUnlock_72 = openHouse;
        }
        else if (houseIndex == 73)
        {
            YandexGame.savesData.buildHouseUnlock_73 = openHouse;
        }
        else if (houseIndex == 74)
        {
            YandexGame.savesData.buildHouseUnlock_74 = openHouse;
        }
        else if (houseIndex == 75)
        {
            YandexGame.savesData.buildHouseUnlock_75 = openHouse;
        }
        else if (houseIndex == 76)
        {
            YandexGame.savesData.buildHouseUnlock_76 = openHouse;
        }
        else if (houseIndex == 77)
        {
            YandexGame.savesData.buildHouseUnlock_77 = openHouse;
        }
        else if (houseIndex == 78)
        {
            YandexGame.savesData.buildHouseUnlock_78 = openHouse;
        }
        else if (houseIndex == 79)
        {
            YandexGame.savesData.buildHouseUnlock_79 = openHouse;
        }
        else if (houseIndex == 80)
        {
            YandexGame.savesData.buildHouseUnlock_80 = openHouse;
        }
        YandexGame.SaveProgress();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !houseUnlock)
        {
            UnlockHouse();
        }
    }
}