using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using YG;

public class BuyBag : MonoBehaviour
{
    [SerializeField] int indexBag;
    [SerializeField] GameObject cell;
    [SerializeField] GameObject btnBuy;
    [SerializeField] int prise;
    [SerializeField] string idSkin;
    private string _priseSkin;

    [SerializeField] TextMeshProUGUI textPrise;
    bool isFirstGetload = true;
    bool isUnlockBag = false;

    private void Start()
    {
        if (YandexGame.SDKEnabled == true)
        {
            GetLoad();
        }
    }

    private void OnEnable()
    {
        YandexGame.GetDataEvent += GetLoad;
        EventManager.skin0 += UnlockSkin;

    }

    private void OnDisable()
    {
        YandexGame.GetDataEvent -= GetLoad;
        EventManager.skin0 -= UnlockSkin;
    }

    private void GetLoad()
    {
        _priseSkin = YG2.purchases[indexBag].price;
        textPrise.text = _priseSkin;
        if (indexBag == 0)
        {
            isUnlockBag = YandexGame.savesData.bagPlaces[indexBag];
        }
        else if (indexBag == 1)
        {
            isUnlockBag = YandexGame.savesData.bagPlaces[indexBag];
        }
        else if (indexBag == 2)
        {
            isUnlockBag = YandexGame.savesData.bagPlaces[indexBag];
        }
        else if (indexBag == 3)
        {
            isUnlockBag = YandexGame.savesData.bagPlaces[indexBag];
        }
        else if (indexBag == 4)
        {
            isUnlockBag = YandexGame.savesData.bagPlaces[indexBag];
        }
        else if (indexBag == 5)
        {
            isUnlockBag = YandexGame.savesData.bagPlaces[indexBag];
        }
        else if (indexBag == 6)
        {
            isUnlockBag = YandexGame.savesData.bagPlaces[indexBag];
        }
        else if (indexBag == 7)
        {
            isUnlockBag = YandexGame.savesData.bagPlaces[indexBag];
        }

        if (isUnlockBag && isFirstGetload)
        {
            isFirstGetload = false;
            Destroy(btnBuy);
            Destroy(cell);
        }
        //else
        //{
        //    textPrise.text = ShortScaleString.parseFloat(prise, 1, 1000, true).ToString();
        //}
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            YG2.BuyPayments(idSkin);
            //if (Score.Instance.score >= prise)
            //{
            //    Score.Instance.DownScore(prise);
            //    isUnlockBag = true;
            //    SaveWall();

            //    Destroy(btnBuy);
            //    Destroy(cell);
            //}
            //else
            //{
            //    SoundManager.Instance.notmoney.Play();
            //}
        }
    }
    public void UnlockSkin(string id)
    {
        if (id == idSkin)
        {
            isUnlockBag = true;
            SaveWall();

            Destroy(btnBuy);
            Destroy(cell);
        }
    }
    private void SaveWall()
    {
        if (indexBag == 0)
        {
            YandexGame.savesData.bagPlaces[indexBag] = isUnlockBag;
        }
        else if (indexBag == 1)
        {
            YandexGame.savesData.bagPlaces[indexBag] = isUnlockBag;
        }
        else if (indexBag == 2)
        {
            YandexGame.savesData.bagPlaces[indexBag] = isUnlockBag;
        }
        else if (indexBag == 3)
        {
            YandexGame.savesData.bagPlaces[indexBag] = isUnlockBag;
        }
        else if (indexBag == 4)
        {
            YandexGame.savesData.bagPlaces[indexBag] = isUnlockBag;
        }
        else if (indexBag == 5)
        {
            YandexGame.savesData.bagPlaces[indexBag] = isUnlockBag;
        }
        else if (indexBag == 6)
        {
            YandexGame.savesData.bagPlaces[indexBag] = isUnlockBag;
        }
        else if (indexBag == 7)
        {
            YandexGame.savesData.bagPlaces[indexBag] = isUnlockBag;
        }
        YandexGame.SaveProgress();
    }
}
