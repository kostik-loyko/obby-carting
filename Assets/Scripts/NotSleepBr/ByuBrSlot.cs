using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using YG;

public class ByuBrSlot : MonoBehaviour
{
    [SerializeField] int indexSlot;
    [SerializeField] GameObject slot;
    [SerializeField] GameObject btnBuy;
    [SerializeField] int prise;

    [SerializeField] TextMeshProUGUI textPrise;

    bool isFirstGetload = true;
    bool isUnlockSlot = false;

    private void Start()
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
        if (indexSlot == 0)
        {
            isUnlockSlot = YandexGame.savesData.slotPlBr[indexSlot];
        }
        else if (indexSlot == 1)
        {
            isUnlockSlot = YandexGame.savesData.slotPlBr[indexSlot];
        }
        else if (indexSlot == 2)
        {
            isUnlockSlot = YandexGame.savesData.slotPlBr[indexSlot];
        }
        else if (indexSlot == 3)
        {
            isUnlockSlot = YandexGame.savesData.slotPlBr[indexSlot];
        }
        else if (indexSlot == 4)
        {
            isUnlockSlot = YandexGame.savesData.slotPlBr[indexSlot];
        }
        else if (indexSlot == 5)
        {
            isUnlockSlot = YandexGame.savesData.slotPlBr[indexSlot];
        }
        else if (indexSlot == 6)
        {
            isUnlockSlot = YandexGame.savesData.slotPlBr[indexSlot];
        }
        else if (indexSlot == 7)
        {
            isUnlockSlot = YandexGame.savesData.slotPlBr[indexSlot];
        }
        else if (indexSlot == 8)
        {
            isUnlockSlot = YandexGame.savesData.slotPlBr[indexSlot];
        }
        else if (indexSlot == 9)
        {
            isUnlockSlot = YandexGame.savesData.slotPlBr[indexSlot];
        }
        else if (indexSlot == 10)
        {
            isUnlockSlot = YandexGame.savesData.slotPlBr[indexSlot];
        }
        else if (indexSlot == 11)
        {
            isUnlockSlot = YandexGame.savesData.slotPlBr[indexSlot];
        }
        else if (indexSlot == 12)
        {
            isUnlockSlot = YandexGame.savesData.slotPlBr[indexSlot];
        }
        else if (indexSlot == 13)
        {
            isUnlockSlot = YandexGame.savesData.slotPlBr[indexSlot];
        }
        else if (indexSlot == 14)
        {
            isUnlockSlot = YandexGame.savesData.slotPlBr[indexSlot];
        }
        else if (indexSlot == 15)
        {
            isUnlockSlot = YandexGame.savesData.slotPlBr[indexSlot];
        }
        else if (indexSlot == 16)
        {
            isUnlockSlot = YandexGame.savesData.slotPlBr[indexSlot];
        }
        else if (indexSlot == 17)
        {
            isUnlockSlot = YandexGame.savesData.slotPlBr[indexSlot];
        }
        else if (indexSlot == 18)
        {
            isUnlockSlot = YandexGame.savesData.slotPlBr[indexSlot];
        }
        else if (indexSlot == 19)
        {
            isUnlockSlot = YandexGame.savesData.slotPlBr[indexSlot];
        }
        else if (indexSlot == 20)
        {
            isUnlockSlot = YandexGame.savesData.slotPlBr[indexSlot];
        }
        else if (indexSlot == 21)
        {
            isUnlockSlot = YandexGame.savesData.slotPlBr[indexSlot];
        }
        else if (indexSlot == 22)
        {
            isUnlockSlot = YandexGame.savesData.slotPlBr[indexSlot];
        }
        else if (indexSlot == 23)
        {
            isUnlockSlot = YandexGame.savesData.slotPlBr[indexSlot];
        }
        else if (indexSlot == 24)
        {
            isUnlockSlot = YandexGame.savesData.slotPlBr[indexSlot];
        }
        else if (indexSlot == 25)
        {
            isUnlockSlot = YandexGame.savesData.slotPlBr[indexSlot];
        }
        else if (indexSlot == 26)
        {
            isUnlockSlot = YandexGame.savesData.slotPlBr[indexSlot];
        }
        else if (indexSlot == 27)
        {
            isUnlockSlot = YandexGame.savesData.slotPlBr[indexSlot];
        }
        else if (indexSlot == 28)
        {
            isUnlockSlot = YandexGame.savesData.slotPlBr[indexSlot];
        }
        else if (indexSlot == 29)
        {
            isUnlockSlot = YandexGame.savesData.slotPlBr[indexSlot];
        }
        else if (indexSlot == 30)
        {
            isUnlockSlot = YandexGame.savesData.slotPlBr[indexSlot];
        }

        if (isUnlockSlot && isFirstGetload)
        {
            isFirstGetload = false;
            slot.SetActive(true);
            Destroy(btnBuy);
        }
        else
        {
            textPrise.text = ShortScaleString.parseFloat(prise, 1, 1000, true).ToString();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (Score.Instance.DownScore(prise))
            {
                isUnlockSlot = true;
                SaveSlot();

                slot.SetActive(true);
                Destroy(btnBuy);
            }
        }
    }

    private void SaveSlot()
    {
        if (indexSlot == 0)
        {
            YandexGame.savesData.slotPlBr[indexSlot] = isUnlockSlot;
        }
        else if (indexSlot == 1)
        {
            YandexGame.savesData.slotPlBr[indexSlot] = isUnlockSlot;
        }
        else if (indexSlot == 2)
        {
            YandexGame.savesData.slotPlBr[indexSlot] = isUnlockSlot;
        }
        else if (indexSlot == 3)
        {
            YandexGame.savesData.slotPlBr[indexSlot] = isUnlockSlot;
        }
        else if (indexSlot == 4)
        {
            YandexGame.savesData.slotPlBr[indexSlot] = isUnlockSlot;
        }
        else if (indexSlot == 5)
        {
            YandexGame.savesData.slotPlBr[indexSlot] = isUnlockSlot;
        }
        else if (indexSlot == 6)
        {
            YandexGame.savesData.slotPlBr[indexSlot] = isUnlockSlot;
        }
        else if (indexSlot == 7)
        {
            YandexGame.savesData.slotPlBr[indexSlot] = isUnlockSlot;
        }
        else if (indexSlot == 8)
        {
            YandexGame.savesData.slotPlBr[indexSlot] = isUnlockSlot;
        }
        else if (indexSlot == 9)
        {
            YandexGame.savesData.slotPlBr[indexSlot] = isUnlockSlot;
        }
        else if (indexSlot == 10)
        {
            YandexGame.savesData.slotPlBr[indexSlot] = isUnlockSlot;
        }
        else if (indexSlot == 11)
        {
            YandexGame.savesData.slotPlBr[indexSlot] = isUnlockSlot;
        }
        else if (indexSlot == 12)
        {
            YandexGame.savesData.slotPlBr[indexSlot] = isUnlockSlot;
        }
        else if (indexSlot == 13)
        {
            YandexGame.savesData.slotPlBr[indexSlot] = isUnlockSlot;
        }
        else if (indexSlot == 14)
        {
            YandexGame.savesData.slotPlBr[indexSlot] = isUnlockSlot;
        }
        else if (indexSlot == 15)
        {
            YandexGame.savesData.slotPlBr[indexSlot] = isUnlockSlot;
        }
        else if (indexSlot == 16)
        {
            YandexGame.savesData.slotPlBr[indexSlot] = isUnlockSlot;
        }
        else if (indexSlot == 17)
        {
            YandexGame.savesData.slotPlBr[indexSlot] = isUnlockSlot;
        }
        else if (indexSlot == 18)
        {
            YandexGame.savesData.slotPlBr[indexSlot] = isUnlockSlot;
        }
        else if (indexSlot == 19)
        {
            YandexGame.savesData.slotPlBr[indexSlot] = isUnlockSlot;
        }
        else if (indexSlot == 20)
        {
            YandexGame.savesData.slotPlBr[indexSlot] = isUnlockSlot;
        }
        else if (indexSlot == 21)
        {
            YandexGame.savesData.slotPlBr[indexSlot] = isUnlockSlot;
        }
        else if (indexSlot == 22)
        {
            YandexGame.savesData.slotPlBr[indexSlot] = isUnlockSlot;
        }
        else if (indexSlot == 23)
        {
            YandexGame.savesData.slotPlBr[indexSlot] = isUnlockSlot;
        }
        else if (indexSlot == 24)
        {
            YandexGame.savesData.slotPlBr[indexSlot] = isUnlockSlot;
        }
        else if (indexSlot == 25)
        {
            YandexGame.savesData.slotPlBr[indexSlot] = isUnlockSlot;
        }
        else if (indexSlot == 26)
        {
            YandexGame.savesData.slotPlBr[indexSlot] = isUnlockSlot;
        }
        else if (indexSlot == 27)
        {
            YandexGame.savesData.slotPlBr[indexSlot] = isUnlockSlot;
        }
        else if (indexSlot == 28)
        {
            YandexGame.savesData.slotPlBr[indexSlot] = isUnlockSlot;
        }
        else if (indexSlot == 29)
        {
            YandexGame.savesData.slotPlBr[indexSlot] = isUnlockSlot;
        }
        else if (indexSlot == 30)
        {
            YandexGame.savesData.slotPlBr[indexSlot] = isUnlockSlot;
        }
        YG2.SaveProgress();
    }
}
