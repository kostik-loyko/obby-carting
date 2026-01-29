using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YG;

public class ShopTrailBTN : MonoBehaviour
{
    public int trailPrice = 0;
    public float velocityCoficient = 1.1f;
    public Button buyButton; // Кнопка покупки
    public TextMeshProUGUI statusText; // Текстовое поле для вывода статуса покупки
    public int TrailIndex = 0;
    public bool firstTrailBuy = false;
    //int currentTrailIndex = 999; // Стартовый технический индекс для корректоной работы кода

    private ShopTrails manager;

    int trailBought_0;
    int trailBought_1;
    int trailBought_2;
    int trailBought_3;
    int trailBought_4;
    int trailBought_5;
    int trailBought_6;
    int trailBought_7;

    private void Start()
    {
        buyButton.onClick.AddListener(BuyTrail);

        if (YandexGame.SDKEnabled == true)
        {
            GetLoad();
        }
    }

    private void OnEnable() => YandexGame.GetDataEvent += GetLoad;

    private void OnDisable() => YandexGame.GetDataEvent -= GetLoad;

    private void GetLoad()
    {
        trailBought_0 = YandexGame.savesData.trailBought_0;
        trailBought_1 = YandexGame.savesData.trailBought_1;
        trailBought_2 = YandexGame.savesData.trailBought_2;
        trailBought_3 = YandexGame.savesData.trailBought_3;
        trailBought_4 = YandexGame.savesData.trailBought_4;
        trailBought_5 = YandexGame.savesData.trailBought_5;
        trailBought_6 = YandexGame.savesData.trailBought_6;
        trailBought_7 = YandexGame.savesData.trailBought_7;
        //Pets.Instance.currentPetIndex = YandexGame.savesData.currentPetIndex;

        UpdateInfo();
    }
    public void SetManager(ShopTrails shopManager)
    {
        manager = shopManager;
    }

    public void UpdateInfo()
    {
        if (TrailIndex == 0)
        {
            if (Trails.Instance.currentTrailIndex == TrailIndex)
            {
                if (GameManager.Instance.isRU)
                {
                    statusText.text = "Выбран";
                }
                else
                {
                    statusText.text = "Selected";
                }
                Trails.Instance.PickTrail(Trails.Instance.currentTrailIndex);
                PlayerBehavior.Instance.UpVelocity(velocityCoficient);
            }
            else if (trailBought_0 == 1)
            {
                if (GameManager.Instance.isRU)
                {
                    statusText.text = "Куплен";
                }
                else
                {
                    statusText.text = "Bought";
                }
            }
            else if (trailBought_0 != 1)
            {
                statusText.text = ShortScaleString.parseFloat(trailPrice, 1, 1000, true).ToString();
            }
        }

        if (TrailIndex == 1)
        {
            if (Trails.Instance.currentTrailIndex == TrailIndex)
            {
                if (GameManager.Instance.isRU)
                {
                    statusText.text = "Выбран";
                }
                else
                {
                    statusText.text = "Selected";
                }
                Trails.Instance.PickTrail(Trails.Instance.currentTrailIndex);
                PlayerBehavior.Instance.UpVelocity(velocityCoficient);
            }
            else if (trailBought_1 == 1)
            {
                if (GameManager.Instance.isRU)
                {
                    statusText.text = "Куплен";
                }
                else
                {
                    statusText.text = "Bought";
                }
            }
            else if (trailBought_1 != 1)
            {
                statusText.text = ShortScaleString.parseFloat(trailPrice, 1, 1000, true).ToString();
            }
        }

        if (TrailIndex == 2)
        {
            if (Trails.Instance.currentTrailIndex == TrailIndex)
            {
                if (GameManager.Instance.isRU)
                {
                    statusText.text = "Выбран";
                }
                else
                {
                    statusText.text = "Selected";
                }
                Trails.Instance.PickTrail(Trails.Instance.currentTrailIndex);
                PlayerBehavior.Instance.UpVelocity(velocityCoficient);
            }
            else if (trailBought_2 == 1)
            {
                if (GameManager.Instance.isRU)
                {
                    statusText.text = "Куплен";
                }
                else
                {
                    statusText.text = "Bought";
                }
            }
            else if (trailBought_2 != 1)
            {
                statusText.text = ShortScaleString.parseFloat(trailPrice, 1, 1000, true).ToString();
            }
        }

        if (TrailIndex == 3)
        {
            if (Trails.Instance.currentTrailIndex == TrailIndex)
            {
                if (GameManager.Instance.isRU)
                {
                    statusText.text = "Выбран";
                }
                else
                {
                    statusText.text = "Selected";
                }
                Trails.Instance.PickTrail(Trails.Instance.currentTrailIndex);
                PlayerBehavior.Instance.UpVelocity(velocityCoficient);
            }
            else if (trailBought_3 == 1)
            {
                if (GameManager.Instance.isRU)
                {
                    statusText.text = "Куплен";
                }
                else
                {
                    statusText.text = "Bought";
                }
            }
            else if (trailBought_3 != 1)
            {
                statusText.text = ShortScaleString.parseFloat(trailPrice, 1, 1000, true).ToString();
            }
        }

        if (TrailIndex == 4)
        {
            if (Trails.Instance.currentTrailIndex == TrailIndex)
            {
                if (GameManager.Instance.isRU)
                {
                    statusText.text = "Выбран";
                }
                else
                {
                    statusText.text = "Selected";
                }
                Trails.Instance.PickTrail(Trails.Instance.currentTrailIndex);
                PlayerBehavior.Instance.UpVelocity(velocityCoficient);
            }
            else if (trailBought_4 == 1)
            {
                if (GameManager.Instance.isRU)
                {
                    statusText.text = "Куплен";
                }
                else
                {
                    statusText.text = "Bought";
                }
            }
            else if (trailBought_4 != 1)
            {
                statusText.text = ShortScaleString.parseFloat(trailPrice, 1, 1000, true).ToString();
            }
        }

        if (TrailIndex == 5)
        {
            if (Trails.Instance.currentTrailIndex == TrailIndex)
            {
                if (GameManager.Instance.isRU)
                {
                    statusText.text = "Выбран";
                }
                else
                {
                    statusText.text = "Selected";
                }
                Trails.Instance.PickTrail(Trails.Instance.currentTrailIndex);
                PlayerBehavior.Instance.UpVelocity(velocityCoficient);
            }
            else if (trailBought_5 == 1)
            {
                if (GameManager.Instance.isRU)
                {
                    statusText.text = "Куплен";
                }
                else
                {
                    statusText.text = "Bought";
                }
            }
            else if (trailBought_5 != 1)
            {
                statusText.text = ShortScaleString.parseFloat(trailPrice, 1, 1000, true).ToString();
            }
        }

        if (TrailIndex == 6)
        {
            if (Trails.Instance.currentTrailIndex == TrailIndex)
            {
                if (GameManager.Instance.isRU)
                {
                    statusText.text = "Выбран";
                }
                else
                {
                    statusText.text = "Selected";
                }
                Trails.Instance.PickTrail(Trails.Instance.currentTrailIndex);
                PlayerBehavior.Instance.UpVelocity(velocityCoficient);
            }
            else if (trailBought_6 == 1)
            {
                if (GameManager.Instance.isRU)
                {
                    statusText.text = "Куплен";
                }
                else
                {
                    statusText.text = "Bought";
                }
            }
            else if (trailBought_6 != 1)
            {
                statusText.text = ShortScaleString.parseFloat(trailPrice, 1, 1000, true).ToString();
            }
        }

        if (TrailIndex == 7)
        {
            if (Trails.Instance.currentTrailIndex == TrailIndex)
            {
                if (GameManager.Instance.isRU)
                {
                    statusText.text = "Выбран";
                }
                else
                {
                    statusText.text = "Selected";
                }
                Trails.Instance.PickTrail(Trails.Instance.currentTrailIndex);
                PlayerBehavior.Instance.UpVelocity(velocityCoficient);
            }
            else if (trailBought_7 == 1)
            {
                if (GameManager.Instance.isRU)
                {
                    statusText.text = "Куплен";
                }
                else
                {
                    statusText.text = "Bought";
                }
            }
            else if (trailBought_7 != 1)
            {
                statusText.text = ShortScaleString.parseFloat(trailPrice, 1, 1000, true).ToString();
            }
        }
    }

    public void BuyTrail()
    {
        if (TrailIndex == 0)
        {
            if (trailBought_0 != 1)
            {
                if (Score.Instance.score >= trailPrice)
                {
                    Score.Instance.DownScore(trailPrice);

                    trailBought_0 = 1;
                    YandexGame.savesData.trailBought_0 = 1;

                    Trails.Instance.currentTrailIndex = TrailIndex;
                    YandexGame.savesData.currentTrailIndex = TrailIndex;

                    manager.UpdateInfoButton();
                }
                else
                {
                    SoundManager.Instance.notmoney.Play();
                }
            }
            else
            {
                Trails.Instance.currentTrailIndex = TrailIndex;
                YandexGame.savesData.currentTrailIndex = TrailIndex;
                YandexGame.SaveProgress();

                manager.UpdateInfoButton();
            }
        }

        if (TrailIndex == 1)
        {
            if (trailBought_1 != 1)
            {
                if (Score.Instance.score >= trailPrice)
                {
                    Score.Instance.DownScore(trailPrice);

                    trailBought_1 = 1;
                    YandexGame.savesData.trailBought_1 = 1;

                    Trails.Instance.currentTrailIndex = TrailIndex;
                    YandexGame.savesData.currentTrailIndex = TrailIndex;

                    manager.UpdateInfoButton();
                }
                else
                {
                    SoundManager.Instance.notmoney.Play();
                }
            }
            else
            {
                Trails.Instance.currentTrailIndex = TrailIndex;
                YandexGame.savesData.currentTrailIndex = TrailIndex;
                YandexGame.SaveProgress();

                manager.UpdateInfoButton();
            }
        }

        if (TrailIndex == 2)
        {
            if (trailBought_2 != 1)
            {
                if (Score.Instance.score >= trailPrice)
                {
                    Score.Instance.DownScore(trailPrice);

                    trailBought_2 = 1;
                    YandexGame.savesData.trailBought_2 = 1;

                    Trails.Instance.currentTrailIndex = TrailIndex;
                    YandexGame.savesData.currentTrailIndex = TrailIndex;

                    manager.UpdateInfoButton();
                }
                else
                {
                    SoundManager.Instance.notmoney.Play();
                }
            }
            else
            {
                Trails.Instance.currentTrailIndex = TrailIndex;
                YandexGame.savesData.currentTrailIndex = TrailIndex;
                YandexGame.SaveProgress();

                manager.UpdateInfoButton();
            }
        }

        if (TrailIndex == 3)
        {
            if (trailBought_3 != 1)
            {
                if (Score.Instance.score >= trailPrice)
                {
                    Score.Instance.DownScore(trailPrice);

                    trailBought_3 = 1;
                    YandexGame.savesData.trailBought_3 = 1;

                    Trails.Instance.currentTrailIndex = TrailIndex;
                    YandexGame.savesData.currentTrailIndex = TrailIndex;

                    manager.UpdateInfoButton();
                }
                else
                {
                    SoundManager.Instance.notmoney.Play();
                }
            }
            else
            {
                Trails.Instance.currentTrailIndex = TrailIndex;
                YandexGame.savesData.currentTrailIndex = TrailIndex;
                YandexGame.SaveProgress();

                manager.UpdateInfoButton();
            }
        }

        if (TrailIndex == 4)
        {
            if (trailBought_4 != 1)
            {
                if (Score.Instance.score >= trailPrice)
                {
                    Score.Instance.DownScore(trailPrice);

                    trailBought_4 = 1;
                    YandexGame.savesData.trailBought_4 = 1;

                    Trails.Instance.currentTrailIndex = TrailIndex;
                    YandexGame.savesData.currentTrailIndex = TrailIndex;
                    YandexGame.SaveProgress();

                    manager.UpdateInfoButton();
                }
                else
                {
                    SoundManager.Instance.notmoney.Play();
                }
            }
            else
            {
                Trails.Instance.currentTrailIndex = TrailIndex;
                YandexGame.savesData.currentTrailIndex = TrailIndex;

                manager.UpdateInfoButton();
            }
        }

        if (TrailIndex == 5)
        {
            if (trailBought_5 != 1)
            {
                if (Score.Instance.score >= trailPrice)
                {
                    Score.Instance.DownScore(trailPrice);

                    trailBought_5 = 1;
                    YandexGame.savesData.trailBought_5 = 1;

                    Trails.Instance.currentTrailIndex = TrailIndex;
                    YandexGame.savesData.currentTrailIndex = TrailIndex;
                    YandexGame.SaveProgress();

                    manager.UpdateInfoButton();
                }
                else
                {
                    SoundManager.Instance.notmoney.Play();
                }
            }
            else
            {
                Trails.Instance.currentTrailIndex = TrailIndex;
                YandexGame.savesData.currentTrailIndex = TrailIndex;

                manager.UpdateInfoButton();
            }
        }

        if (TrailIndex == 6)
        {
            if (trailBought_6 != 1)
            {
                if (Score.Instance.score >= trailPrice)
                {
                    Score.Instance.DownScore(trailPrice);


                    trailBought_6 = 1;
                    YandexGame.savesData.trailBought_6 = 1;

                    Trails.Instance.currentTrailIndex = TrailIndex;
                    YandexGame.savesData.currentTrailIndex = TrailIndex;

                    manager.UpdateInfoButton();
                }
                else
                {
                    SoundManager.Instance.notmoney.Play();
                }
            }
            else
            {
                Trails.Instance.currentTrailIndex = TrailIndex;
                YandexGame.savesData.currentTrailIndex = TrailIndex;
                YandexGame.SaveProgress();

                manager.UpdateInfoButton();
            }
        }

        if (TrailIndex == 7)
        {
            if (trailBought_7 != 1)
            {
                if (Score.Instance.score >= trailPrice)
                {
                    Score.Instance.DownScore(trailPrice);

                    trailBought_7 = 1;
                    YandexGame.savesData.trailBought_7 = 1;

                    Trails.Instance.currentTrailIndex = TrailIndex;
                    YandexGame.savesData.currentTrailIndex = TrailIndex;

                    manager.UpdateInfoButton();
                }
                else
                {
                    SoundManager.Instance.notmoney.Play();
                }
            }
            else
            {
                Trails.Instance.currentTrailIndex = TrailIndex;
                YandexGame.savesData.currentTrailIndex = TrailIndex;
                YandexGame.SaveProgress();

                manager.UpdateInfoButton();
            }
        }
    }
}
