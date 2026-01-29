using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using YG;

public class ShopButton : MonoBehaviour
{
    public int petPrice = 0; // Цена машинки
    public Button buyButton; // Кнопка покупки
    public TextMeshProUGUI statusText; // Текстовое поле для вывода статуса покупки
    public int PetIndex = 0;
    public GameObject PointSpawnPet;
    public bool firstPetBuy = false;

    int petBought_0;
    int petBought_1;
    int petBought_2;
    int petBought_3;
    int petBought_4;
    int petBought_5;

    private ShopManager manager;

    //int coffForMoney = 0;

    private void Start()
    {
        buyButton.onClick.AddListener(BuyPet);


        if (YandexGame.SDKEnabled == true)
        {
            GetLoad();
        }

    }

    private void OnEnable() => YandexGame.GetDataEvent += GetLoad;

    private void OnDisable() => YandexGame.GetDataEvent -= GetLoad;

    private void GetLoad()
    {
        petBought_0 = YandexGame.savesData.petBought_0;
        petBought_1 = YandexGame.savesData.petBought_1;
        petBought_2 = YandexGame.savesData.petBought_2;
        petBought_3 = YandexGame.savesData.petBought_3;
        petBought_4 = YandexGame.savesData.petBought_4;
        petBought_5 = YandexGame.savesData.petBought_5;
        Pets.Instance.currentPetIndex = YandexGame.savesData.currentPetIndex;

        UpdateInfo();
    }

    public void SetManager(ShopManager shopManager)
    {
        manager = shopManager;
    }

    //public void UpdateInfo()
    //{
    //    if (PlayerPrefs.HasKey("CurrentPet"))
    //    {
    //        currentPetIndex = PlayerPrefs.GetInt("CurrentPet");
    //    }

    //    if (currentPetIndex == PetIndex)
    //    {
    //        if (GameManager.Instance.isRU)
    //        {
    //            statusText.text = "Выбран";
    //        }
    //        else
    //        {
    //            statusText.text = "Selected";
    //        }

    //        Pets.Instance.PickPets(currentPetIndex);
    //        Score.Instance.GetBonusRate(currentPetIndex);
    //    }
    //    else if (PlayerPrefs.GetInt("PetBought_" + PetIndex, 0) == 1)
    //    {
    //        if (GameManager.Instance.isRU)
    //        {
    //            statusText.text = "Куплен";
    //        }
    //        else
    //        {
    //            statusText.text = "Bought";
    //        }
    //    }
    //    else if (PlayerPrefs.GetInt("PetBought_" + PetIndex, 0) != 1)
    //    {
    //        statusText.text = ShortScaleString.parseFloat(petPrice, 1, 1000, true).ToString();
    //    }
    //}

    public void UpdateInfo()
    {
        if (PetIndex == 0)
        {
            //currentPetIndex = YandexGame.savesData.currentPetIndex;

            if (Pets.Instance.currentPetIndex == PetIndex)
            {
                if (GameManager.Instance.isRU)
                {
                    statusText.text = "Выбран";
                }
                else
                {
                    statusText.text = "Selected";
                }

                Pets.Instance.PickPets(Pets.Instance.currentPetIndex);
                Score.Instance.GetBonusRate(Pets.Instance.currentPetIndex);
            }
            else if (petBought_0 == 1)
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
            else if (petBought_0 != 1)
            {
                statusText.text = ShortScaleString.parseFloat(petPrice, 1, 1000, true).ToString();
            }
        }


        if (PetIndex == 1)
        {
            //currentPetIndex = YandexGame.savesData.currentPetIndex;

            if (Pets.Instance.currentPetIndex == PetIndex)
            {
                if (GameManager.Instance.isRU)
                {
                    statusText.text = "Выбран";
                }
                else
                {
                    statusText.text = "Selected";
                }

                Pets.Instance.PickPets(Pets.Instance.currentPetIndex);
                Score.Instance.GetBonusRate(Pets.Instance.currentPetIndex);
            }
            else if (petBought_1 == 1)
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
            else if (petBought_1 != 1)
            {
                statusText.text = ShortScaleString.parseFloat(petPrice, 1, 1000, true).ToString();
            }
        }


        if (PetIndex == 2)
        {
            //currentPetIndex = YandexGame.savesData.currentPetIndex;

            if (Pets.Instance.currentPetIndex == PetIndex)
            {
                if (GameManager.Instance.isRU)
                {
                    statusText.text = "Выбран";
                }
                else
                {
                    statusText.text = "Selected";
                }

                Pets.Instance.PickPets(Pets.Instance.currentPetIndex);
                Score.Instance.GetBonusRate(Pets.Instance.currentPetIndex);
            }
            else if (petBought_2 == 1)
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
            else if (petBought_2 != 1)
            {
                statusText.text = ShortScaleString.parseFloat(petPrice, 1, 1000, true).ToString();
            }
        }


        if (PetIndex == 3)
        {
            //currentPetIndex = YandexGame.savesData.currentPetIndex;

            if (Pets.Instance.currentPetIndex == PetIndex)
            {
                if (GameManager.Instance.isRU)
                {
                    statusText.text = "Выбран";
                }
                else
                {
                    statusText.text = "Selected";
                }

                Pets.Instance.PickPets(Pets.Instance.currentPetIndex);
                Score.Instance.GetBonusRate(Pets.Instance.currentPetIndex);
            }
            else if (petBought_3 == 1)
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
            else if (petBought_3 != 1)
            {
                statusText.text = ShortScaleString.parseFloat(petPrice, 1, 1000, true).ToString();
            }
        }


        if (PetIndex == 4)
        {
            //currentPetIndex = YandexGame.savesData.currentPetIndex;

            if (Pets.Instance.currentPetIndex == PetIndex)
            {
                if (GameManager.Instance.isRU)
                {
                    statusText.text = "Выбран";
                }
                else
                {
                    statusText.text = "Selected";
                }

                Pets.Instance.PickPets(Pets.Instance.currentPetIndex);
                Score.Instance.GetBonusRate(Pets.Instance.currentPetIndex);
            }
            else if (petBought_4 == 1)
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
            else if (petBought_4 != 1)
            {
                statusText.text = ShortScaleString.parseFloat(petPrice, 1, 1000, true).ToString();
            }
        }


        if (PetIndex == 5)
        {
            //currentPetIndex = YandexGame.savesData.currentPetIndex;

            if (Pets.Instance.currentPetIndex == PetIndex)
            {
                if (GameManager.Instance.isRU)
                {
                    statusText.text = "Выбран";
                }
                else
                {
                    statusText.text = "Selected";
                }

                Pets.Instance.PickPets(Pets.Instance.currentPetIndex);
                Score.Instance.GetBonusRate(Pets.Instance.currentPetIndex);
            }
            else if (petBought_5 == 1)
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
            else if (petBought_5 != 1)
            {
                statusText.text = ShortScaleString.parseFloat(petPrice, 1, 1000, true).ToString();
            }
        }
    }

    //public void BuyPet()
    //{
    //    if (PlayerPrefs.GetInt("PetBought_" + PetIndex, 0) != 1)
    //    {
    //        if (Score.Instance.score >= petPrice)
    //        {
    //            Score.Instance.DownScore(petPrice);

    //            //PlayerPrefs.SetInt("PetBought_" + PetIndex, 1);
    //            if (PetIndex == 0)
    //            {
    //                YandexGame.savesData.petBought_0 = 1;
    //            }
    //            else if (PetIndex == 1)
    //            {
    //                YandexGame.savesData.petBought_1 = 1;
    //            }


    //            // Если машинка только что куплена, установим ее как выбранную
    //            //PlayerPrefs.SetInt("CurrentPet", PetIndex);
    //            YandexGame.savesData.currentPetIndex = currentPetIndex;
    //            YandexGame.SaveProgress();

    //            manager.UpdateInfoButton();
    //        }
    //        else
    //        {
    //            SoundManager.Instance.notmoney.Play();
    //        }
    //    }
    //    else
    //    {
    //        //PlayerPrefs.SetInt("CurrentPet", PetIndex);
    //        YandexGame.savesData.currentPetIndex = currentPetIndex;
    //        YandexGame.SaveProgress();

    //        manager.UpdateInfoButton();
    //    }
    //}

    public void BuyPet()
    {
        if (PetIndex == 0)
        {
            if (petBought_0 != 1)
            {
                if (Score.Instance.score >= petPrice)
                {
                    Score.Instance.DownScore(petPrice);

                    petBought_0 = 1;
                    YandexGame.savesData.petBought_0 = 1;

                    // Если машинка только что куплена, установим ее как выбранную
                    //PlayerPrefs.SetInt("CurrentPet", PetIndex);
                    Pets.Instance.currentPetIndex = PetIndex;
                    YandexGame.savesData.currentPetIndex = PetIndex;
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
                //PlayerPrefs.SetInt("CurrentPet", PetIndex);
                Pets.Instance.currentPetIndex = PetIndex;
                YandexGame.savesData.currentPetIndex = PetIndex;
                YandexGame.SaveProgress();

                manager.UpdateInfoButton();
            }
        }


        if (PetIndex == 1)
        {
            if (petBought_1 != 1)
            {
                if (Score.Instance.score >= petPrice)
                {
                    Score.Instance.DownScore(petPrice);

                    petBought_1 = 1;
                    YandexGame.savesData.petBought_1 = 1;

                    // Если машинка только что куплена, установим ее как выбранную
                    //PlayerPrefs.SetInt("CurrentPet", PetIndex);
                    Pets.Instance.currentPetIndex = PetIndex;
                    YandexGame.savesData.currentPetIndex = PetIndex;
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
                //PlayerPrefs.SetInt("CurrentPet", PetIndex);
                Pets.Instance.currentPetIndex = PetIndex;
                YandexGame.savesData.currentPetIndex = PetIndex;
                YandexGame.SaveProgress();

                manager.UpdateInfoButton();
            }
        }


        if (PetIndex == 2)
        {
            if (petBought_2 != 1)
            {
                if (Score.Instance.score >= petPrice)
                {
                    Score.Instance.DownScore(petPrice);

                    petBought_2 = 1;
                    YandexGame.savesData.petBought_2 = 1;

                    // Если машинка только что куплена, установим ее как выбранную
                    //PlayerPrefs.SetInt("CurrentPet", PetIndex);
                    Pets.Instance.currentPetIndex = PetIndex;
                    YandexGame.savesData.currentPetIndex = PetIndex;
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
                //PlayerPrefs.SetInt("CurrentPet", PetIndex);
                Pets.Instance.currentPetIndex = PetIndex;
                YandexGame.savesData.currentPetIndex = PetIndex;
                YandexGame.SaveProgress();

                manager.UpdateInfoButton();
            }
        }


        if (PetIndex == 3)
        {
            if (petBought_3 != 1)
            {
                if (Score.Instance.score >= petPrice)
                {
                    Score.Instance.DownScore(petPrice);

                    petBought_3 = 1;
                    YandexGame.savesData.petBought_3 = 1;


                    // Если машинка только что куплена, установим ее как выбранную
                    //PlayerPrefs.SetInt("CurrentPet", PetIndex);
                    Pets.Instance.currentPetIndex = PetIndex;
                    YandexGame.savesData.currentPetIndex = PetIndex;
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
                //PlayerPrefs.SetInt("CurrentPet", PetIndex);
                Pets.Instance.currentPetIndex = PetIndex;
                YandexGame.savesData.currentPetIndex = PetIndex;
                YandexGame.SaveProgress();

                manager.UpdateInfoButton();
            }
        }


        if (PetIndex == 4)
        {
            if (petBought_4 != 1)
            {
                if (Score.Instance.score >= petPrice)
                {
                    Score.Instance.DownScore(petPrice);

                    petBought_4 = 1;
                    YandexGame.savesData.petBought_4 = 1;


                    // Если машинка только что куплена, установим ее как выбранную
                    //PlayerPrefs.SetInt("CurrentPet", PetIndex);
                    Pets.Instance.currentPetIndex = PetIndex;
                    YandexGame.savesData.currentPetIndex = PetIndex;
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
                //PlayerPrefs.SetInt("CurrentPet", PetIndex);
                Pets.Instance.currentPetIndex = PetIndex;
                YandexGame.savesData.currentPetIndex = PetIndex;
                YandexGame.SaveProgress();

                manager.UpdateInfoButton();
            }
        }


        if (PetIndex == 5)
        {
            if (petBought_5 != 1)
            {
                if (Score.Instance.score >= petPrice)
                {
                    Score.Instance.DownScore(petPrice);

                    petBought_5 = 1;
                    YandexGame.savesData.petBought_5 = 1;


                    // Если машинка только что куплена, установим ее как выбранную
                    //PlayerPrefs.SetInt("CurrentPet", PetIndex);
                    Pets.Instance.currentPetIndex = PetIndex;
                    YandexGame.savesData.currentPetIndex = PetIndex;
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
                //PlayerPrefs.SetInt("CurrentPet", PetIndex);
                Pets.Instance.currentPetIndex = PetIndex;
                YandexGame.savesData.currentPetIndex = PetIndex;
                YandexGame.SaveProgress();

                manager.UpdateInfoButton();
            }
        }
    }
}