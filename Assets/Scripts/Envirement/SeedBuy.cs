using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using YG;

public class SeedBuy : MonoBehaviour
{
    [SerializeField] int indexSeed;
    [SerializeField] GameObject objSeed;
    [SerializeField] GameObject btnBuy;
    [SerializeField] int prise;

    [SerializeField] TextMeshProUGUI textPrise;

    bool isFirstGetload = true;
    bool isUnlockSeed = false;

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
        if (indexSeed == 0)
        {
            isUnlockSeed = YandexGame.savesData.seedPlaces[indexSeed];
        }
        else if (indexSeed == 1)
        {
            isUnlockSeed = YandexGame.savesData.seedPlaces[indexSeed];
        }
        else if (indexSeed == 2)
        {
            isUnlockSeed = YandexGame.savesData.seedPlaces[indexSeed];
        }
        else if (indexSeed == 3)
        {
            isUnlockSeed = YandexGame.savesData.seedPlaces[indexSeed];
        }
        else if (indexSeed == 4)
        {
            isUnlockSeed = YandexGame.savesData.seedPlaces[indexSeed];
        }
        else if (indexSeed == 5)
        {
            isUnlockSeed = YandexGame.savesData.seedPlaces[indexSeed];
        }
        else if (indexSeed == 6)
        {
            isUnlockSeed = YandexGame.savesData.seedPlaces[indexSeed];
        }
        else if (indexSeed == 7)
        {
            isUnlockSeed = YandexGame.savesData.seedPlaces[indexSeed];
        }
        else if (indexSeed == 8)
        {
            isUnlockSeed = YandexGame.savesData.seedPlaces[indexSeed];
        }
        else if (indexSeed == 9)
        {
            isUnlockSeed = YandexGame.savesData.seedPlaces[indexSeed];
        }

        if (isUnlockSeed && isFirstGetload)
        {
            isFirstGetload = false;
            Destroy(objSeed);
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
            if (Score.Instance.score >= prise)
            {
                Score.Instance.DownScore(prise);
                isUnlockSeed = true;
                SaveWall();

                Destroy(objSeed);
                Destroy(btnBuy);
            }
            else
            {
                SoundManager.Instance.notmoney.Play();
            }
        }
    }

    private void SaveWall()
    {
        if (indexSeed == 0)
        {
            YandexGame.savesData.seedPlaces[indexSeed] = isUnlockSeed;
        }
        else if (indexSeed == 1)
        {
            YandexGame.savesData.seedPlaces[indexSeed] = isUnlockSeed;
        }
        else if (indexSeed == 2)
        {
            YandexGame.savesData.seedPlaces[indexSeed] = isUnlockSeed;
        }
        else if (indexSeed == 3)
        {
            YandexGame.savesData.seedPlaces[indexSeed] = isUnlockSeed;
        }
        else if (indexSeed == 4)
        {
            YandexGame.savesData.seedPlaces[indexSeed] = isUnlockSeed;
        }
        else if (indexSeed == 5)
        {
            YandexGame.savesData.seedPlaces[indexSeed] = isUnlockSeed;
        }
        else if (indexSeed == 6)
        {
            YandexGame.savesData.seedPlaces[indexSeed] = isUnlockSeed;
        }
        else if (indexSeed == 7)
        {
            YandexGame.savesData.seedPlaces[indexSeed] = isUnlockSeed;
        }
        else if (indexSeed == 8)
        {
            YandexGame.savesData.seedPlaces[indexSeed] = isUnlockSeed;
        }
        else if (indexSeed == 9)
        {
            YandexGame.savesData.seedPlaces[indexSeed] = isUnlockSeed;
        }
    }
}
