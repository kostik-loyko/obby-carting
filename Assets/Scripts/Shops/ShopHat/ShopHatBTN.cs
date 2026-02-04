using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YG;

public class ShopHatBTN : MonoBehaviour
{
    public int hatPrice = 0;
    public Button buyButton; 
    public TextMeshProUGUI statusText;
    public int hatIndex = 0;
    public bool firstHatBuy = false;

    private ShopHats manager;

    int hatBought_0;
    int hatBought_1;
    int hatBought_2;
    int hatBought_3;
    int hatBought_4;
    int hatBought_5;
    int hatBought_6;
    int hatBought_7;

    private void Start()
    {
        buyButton.onClick.AddListener(BuyHat);

        if (YandexGame.SDKEnabled == true)
        {
            GetLoad();
        }
    }

    private void OnEnable() => YandexGame.GetDataEvent += GetLoad;

    private void OnDisable() => YandexGame.GetDataEvent -= GetLoad;

    private void GetLoad()
    {
        hatBought_0 = YandexGame.savesData.hatBought_0;
        hatBought_1 = YandexGame.savesData.hatBought_1;
        hatBought_2 = YandexGame.savesData.hatBought_2;
        hatBought_3 = YandexGame.savesData.hatBought_3;
        hatBought_4 = YandexGame.savesData.hatBought_4;
        hatBought_5 = YandexGame.savesData.hatBought_5;
        hatBought_6 = YandexGame.savesData.hatBought_6;
        hatBought_7 = YandexGame.savesData.hatBought_7;
        Hats.Instance.currentHatIndex = YandexGame.savesData.currentHatIndex;

        UpdateInfo();
    }
    public void SetManager(ShopHats shopManager)
    {
        manager = shopManager;
    }

    public void UpdateInfo()
    {
        if (hatIndex == 0)
        {
            if (Hats.Instance.currentHatIndex == hatIndex)
            {
                if (GameManager.Instance.isRU)
                {
                    statusText.text = "Выбран";
                }
                else
                {
                    statusText.text = "Selected";
                }
                Hats.Instance.PickHat(Hats.Instance.currentHatIndex);
                //PlayerBehavior.Instance.UpVelocity(velocityCoficient);
            }
            else if (hatBought_0 == 1)
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
            else if (hatBought_0 != 1)
            {
                statusText.text = ShortScaleString.parseFloat(hatPrice, 1, 1000, true).ToString();
            }
        }

        if (hatIndex == 1)
        {
            if (Hats.Instance.currentHatIndex == hatIndex)
            {
                if (GameManager.Instance.isRU)
                {
                    statusText.text = "Выбран";
                }
                else
                {
                    statusText.text = "Selected";
                }
                Hats.Instance.PickHat(Hats.Instance.currentHatIndex);
                //PlayerBehavior.Instance.UpVelocity(velocityCoficient);
            }
            else if (hatBought_1 == 1)
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
            else if (hatBought_1 != 1)
            {
                statusText.text = ShortScaleString.parseFloat(hatPrice, 1, 1000, true).ToString();
            }
        }

        if (hatIndex == 2)
        {
            if (Hats.Instance.currentHatIndex == hatIndex)
            {
                if (GameManager.Instance.isRU)
                {
                    statusText.text = "Выбран";
                }
                else
                {
                    statusText.text = "Selected";
                }
                Hats.Instance.PickHat(Hats.Instance.currentHatIndex);
                //PlayerBehavior.Instance.UpVelocity(velocityCoficient);
            }
            else if (hatBought_2 == 1)
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
            else if (hatBought_2 != 1)
            {
                statusText.text = ShortScaleString.parseFloat(hatPrice, 1, 1000, true).ToString();
            }
        }

        if (hatIndex == 3)
        {
            if (Hats.Instance.currentHatIndex == hatIndex)
            {
                if (GameManager.Instance.isRU)
                {
                    statusText.text = "Выбран";
                }
                else
                {
                    statusText.text = "Selected";
                }
                Hats.Instance.PickHat(Hats.Instance.currentHatIndex);
                //PlayerBehavior.Instance.UpVelocity(velocityCoficient);
            }
            else if (hatBought_3 == 1)
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
            else if (hatBought_3 != 1)
            {
                statusText.text = ShortScaleString.parseFloat(hatPrice, 1, 1000, true).ToString();
            }
        }

        if (hatIndex == 4)
        {
            if (Hats.Instance.currentHatIndex == hatIndex)
            {
                if (GameManager.Instance.isRU)
                {
                    statusText.text = "Выбран";
                }
                else
                {
                    statusText.text = "Selected";
                }
                Hats.Instance.PickHat(Hats.Instance.currentHatIndex);
                //PlayerBehavior.Instance.UpVelocity(velocityCoficient);
            }
            else if (hatBought_4 == 1)
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
            else if (hatBought_4 != 1)
            {
                statusText.text = ShortScaleString.parseFloat(hatPrice, 1, 1000, true).ToString();
            }
        }

        if (hatIndex == 5)
        {
            if (Hats.Instance.currentHatIndex == hatIndex)
            {
                if (GameManager.Instance.isRU)
                {
                    statusText.text = "Выбран";
                }
                else
                {
                    statusText.text = "Selected";
                }
                Hats.Instance.PickHat(Hats.Instance.currentHatIndex);
                //PlayerBehavior.Instance.UpVelocity(velocityCoficient);
            }
            else if (hatBought_5 == 1)
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
            else if (hatBought_5 != 1)
            {
                statusText.text = ShortScaleString.parseFloat(hatPrice, 1, 1000, true).ToString();
            }
        }

        if (hatIndex == 6)
        {
            if (Hats.Instance.currentHatIndex == hatIndex)
            {
                if (GameManager.Instance.isRU)
                {
                    statusText.text = "Выбран";
                }
                else
                {
                    statusText.text = "Selected";
                }
                Hats.Instance.PickHat(Hats.Instance.currentHatIndex);
                //PlayerBehavior.Instance.UpVelocity(velocityCoficient);
            }
            else if (hatBought_6 == 1)
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
            else if (hatBought_6 != 1)
            {
                statusText.text = ShortScaleString.parseFloat(hatPrice, 1, 1000, true).ToString();
            }
        }

        if (hatIndex == 7)
        {
            if (Hats.Instance.currentHatIndex == hatIndex)
            {
                if (GameManager.Instance.isRU)
                {
                    statusText.text = "Выбран";
                }
                else
                {
                    statusText.text = "Selected";
                }
                Hats.Instance.PickHat(Hats.Instance.currentHatIndex);
                //PlayerBehavior.Instance.UpVelocity(velocityCoficient);
            }
            else if (hatBought_7 == 1)
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
            else if (hatBought_7 != 1)
            {
                statusText.text = ShortScaleString.parseFloat(hatPrice, 1, 1000, true).ToString();
            }
        }
    }

    public void BuyHat()
    {
        if (hatIndex == 0)
        {
            if (hatBought_0 != 1)
            {
                if (Score.Instance.score >= hatPrice)
                {
                    Score.Instance.DownScore(hatPrice);

                    hatBought_0 = 1;
                    YandexGame.savesData.hatBought_0 = 1;

                    Hats.Instance.currentHatIndex = hatIndex;
                    YandexGame.savesData.currentHatIndex = hatIndex;

                    manager.UpdateInfoButton();
                }
                else
                {
                    SoundManager.Instance.notmoney.Play();
                }
            }
            else
            {
                Hats.Instance.currentHatIndex = hatIndex;
                YandexGame.savesData.currentHatIndex = hatIndex;
                //YandexGame.SaveProgress();

                manager.UpdateInfoButton();
            }
        }

        if (hatIndex == 1)
        {
            if (hatBought_1 != 1)
            {
                if (Score.Instance.score >= hatPrice)
                {
                    Score.Instance.DownScore(hatPrice);

                    hatBought_1 = 1;
                    YandexGame.savesData.hatBought_1 = 1;

                    Hats.Instance.currentHatIndex = hatIndex;
                    YandexGame.savesData.currentHatIndex = hatIndex;

                    manager.UpdateInfoButton();
                }
                else
                {
                    SoundManager.Instance.notmoney.Play();
                }
            }
            else
            {
                Hats.Instance.currentHatIndex = hatIndex;
                YandexGame.savesData.currentHatIndex = hatIndex;
                //YandexGame.SaveProgress();

                manager.UpdateInfoButton();
            }
        }

        if (hatIndex == 2)
        {
            if (hatBought_2 != 1)
            {
                if (Score.Instance.score >= hatPrice)
                {
                    Score.Instance.DownScore(hatPrice);

                    hatBought_2 = 1;
                    YandexGame.savesData.hatBought_2 = 1;

                    Hats.Instance.currentHatIndex = hatIndex;
                    YandexGame.savesData.currentHatIndex = hatIndex;

                    manager.UpdateInfoButton();
                }
                else
                {
                    SoundManager.Instance.notmoney.Play();
                }
            }
            else
            {
                Hats.Instance.currentHatIndex = hatIndex;
                YandexGame.savesData.currentHatIndex = hatIndex;
                //YandexGame.SaveProgress();

                manager.UpdateInfoButton();
            }
        }

        if (hatIndex == 3)
        {
            if (hatBought_3 != 1)
            {
                if (Score.Instance.score >= hatPrice)
                {
                    Score.Instance.DownScore(hatPrice);

                    hatBought_3 = 1;
                    YandexGame.savesData.hatBought_3 = 1;

                    Hats.Instance.currentHatIndex = hatIndex;
                    YandexGame.savesData.currentHatIndex = hatIndex;

                    manager.UpdateInfoButton();
                }
                else
                {
                    SoundManager.Instance.notmoney.Play();
                }
            }
            else
            {
                Hats.Instance.currentHatIndex = hatIndex;
                YandexGame.savesData.currentHatIndex = hatIndex;
                //YandexGame.SaveProgress();

                manager.UpdateInfoButton();
            }
        }

        if (hatIndex == 4)
        {
            if (hatBought_4 != 1)
            {
                if (Score.Instance.score >= hatPrice)
                {
                    Score.Instance.DownScore(hatPrice);

                    hatBought_4 = 1;
                    YandexGame.savesData.hatBought_4 = 1;

                    Hats.Instance.currentHatIndex = hatIndex;
                    YandexGame.savesData.currentHatIndex = hatIndex;
                    //YandexGame.SaveProgress();

                    manager.UpdateInfoButton();
                }
                else
                {
                    SoundManager.Instance.notmoney.Play();
                }
            }
            else
            {
                Hats.Instance.currentHatIndex = hatIndex;
                YandexGame.savesData.currentHatIndex = hatIndex;

                manager.UpdateInfoButton();
            }
        }

        if (hatIndex == 5)
        {
            if (hatBought_5 != 1)
            {
                if (Score.Instance.score >= hatPrice)
                {
                    Score.Instance.DownScore(hatPrice);

                    hatBought_5 = 1;
                    YandexGame.savesData.hatBought_5 = 1;

                    Hats.Instance.currentHatIndex = hatIndex;
                    YandexGame.savesData.currentHatIndex = hatIndex;
                    //YandexGame.SaveProgress();

                    manager.UpdateInfoButton();
                }
                else
                {
                    SoundManager.Instance.notmoney.Play();
                }
            }
            else
            {
                Hats.Instance.currentHatIndex = hatIndex;
                YandexGame.savesData.currentHatIndex = hatIndex;

                manager.UpdateInfoButton();
            }
        }

        if (hatIndex == 6)
        {
            if (hatBought_6 != 1)
            {
                if (Score.Instance.score >= hatPrice)
                {
                    Score.Instance.DownScore(hatPrice);


                    hatBought_6 = 1;
                    YandexGame.savesData.hatBought_6 = 1;

                    Hats.Instance.currentHatIndex = hatIndex;
                    YandexGame.savesData.currentHatIndex = hatIndex;

                    manager.UpdateInfoButton();
                }
                else
                {
                    SoundManager.Instance.notmoney.Play();
                }
            }
            else
            {
                Hats.Instance.currentHatIndex = hatIndex;
                YandexGame.savesData.currentHatIndex = hatIndex;
                //YandexGame.SaveProgress();

                manager.UpdateInfoButton();
            }
        }

        if (hatIndex == 7)
        {
            if (hatBought_7 != 1)
            {
                if (Score.Instance.score >= hatPrice)
                {
                    Score.Instance.DownScore(hatPrice);

                    hatBought_7 = 1;
                    YandexGame.savesData.hatBought_7 = 1;

                    Hats.Instance.currentHatIndex = hatIndex;
                    YandexGame.savesData.currentHatIndex = hatIndex;

                    manager.UpdateInfoButton();
                }
                else
                {
                    SoundManager.Instance.notmoney.Play();
                }
            }
            else
            {
                Hats.Instance.currentHatIndex = hatIndex;
                YandexGame.savesData.currentHatIndex = hatIndex;
                //YandexGame.SaveProgress();

                manager.UpdateInfoButton();
            }
        }
    }
}
