using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YG;

public class ShopBtnPet : MonoBehaviour
{
    public int petPrice = 0;
    public Button buyButton;
    public TextMeshProUGUI statusText;
    public int PetIndexNew = 0;
    public GameObject PointSpawnPet;
    public bool firstPetBuy = false;

    int petBoughtNew_0;
    int petBoughtNew_1;
    int petBoughtNew_2;
    int petBoughtNew_3;
    int petBoughtNew_4;
    int petBoughtNew_5;
    int petBoughtNew_6;
    int petBoughtNew_7;
    int petBoughtNew_8;
    int petBoughtNew_9;
    int petBoughtNew_10;
    int petBoughtNew_11;
    int petBoughtNew_12;
    int petBoughtNew_13;
    int petBoughtNew_14;
    int petBoughtNew_15;
    int petBoughtNew_16;
    int petBoughtNew_17;
    int petBoughtNew_18;
    int petBoughtNew_19;
    int petBoughtNew_20;
    int petBoughtNew_21;
    int petBoughtNew_22;

    private ShopPet manager;

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
        petBoughtNew_0 = YandexGame.savesData.petBoughtNew_0;
        petBoughtNew_1 = YandexGame.savesData.petBoughtNew_1;
        petBoughtNew_2 = YandexGame.savesData.petBoughtNew_2;
        petBoughtNew_3 = YandexGame.savesData.petBoughtNew_3;
        petBoughtNew_4 = YandexGame.savesData.petBoughtNew_4;
        petBoughtNew_5 = YandexGame.savesData.petBoughtNew_5;
        petBoughtNew_6 = YandexGame.savesData.petBoughtNew_6;
        petBoughtNew_7 = YandexGame.savesData.petBoughtNew_7;
        petBoughtNew_8 = YandexGame.savesData.petBoughtNew_8;
        petBoughtNew_9 = YandexGame.savesData.petBoughtNew_9;
        petBoughtNew_10 = YandexGame.savesData.petBoughtNew_10;
        petBoughtNew_11 = YandexGame.savesData.petBoughtNew_11;
        petBoughtNew_12 = YandexGame.savesData.petBoughtNew_12;
        petBoughtNew_13 = YandexGame.savesData.petBoughtNew_13;
        petBoughtNew_14 = YandexGame.savesData.petBoughtNew_14;
        petBoughtNew_15 = YandexGame.savesData.petBoughtNew_15;
        petBoughtNew_16 = YandexGame.savesData.petBoughtNew_16;
        petBoughtNew_17 = YandexGame.savesData.petBoughtNew_17;
        petBoughtNew_18 = YandexGame.savesData.petBoughtNew_18;
        petBoughtNew_19 = YandexGame.savesData.petBoughtNew_19;
        petBoughtNew_20 = YandexGame.savesData.petBoughtNew_20;
        petBoughtNew_21 = YandexGame.savesData.petBoughtNew_21;
        petBoughtNew_22 = YandexGame.savesData.petBoughtNew_22;
        PetNew.Instance.currentPetIndexNew = YandexGame.savesData.currentPetIndexNew;

        UpdateInfo();
    }

    public void SetManager(ShopPet shopManager)
    {
        manager = shopManager;
    }

    public void Info(int bought)
    {
        if (PetNew.Instance.currentPetIndexNew == PetIndexNew)
        {
            if (GameManager.Instance.isRU)
            {
                statusText.text = "Выбран";
            }
            else
            {
                statusText.text = "Selected";
            }

            PetNew.Instance.PickPets(PetNew.Instance.currentPetIndexNew);
            PetNew.Instance.ShowNewPets(PetIndexNew);
        }
        else if (bought == 1)
        {

            if (GameManager.Instance.isRU)
            {
                statusText.text = "Куплен";
            }
            else
            {
                statusText.text = "Bought";
            }
            PetNew.Instance.ShowNewPets(PetIndexNew);
        }
        else if (bought != 1)
        {
            statusText.text = ShortScaleString.parseFloat(petPrice, 1, 1000, true).ToString();
        }
    }
    public void Buy()
    {
        Score.Instance.DownScore(petPrice);
        Bought();
    }
    public void Bought()
    {
        PetNew.Instance.currentPetIndexNew = PetIndexNew;
        YandexGame.savesData.currentPetIndexNew = PetIndexNew;
        YandexGame.SaveProgress();
        manager.UpdateInfoButton();
    }

    public void UpdateInfo()
    {
        if (PetIndexNew == 0)
        {
            Info(petBoughtNew_0);
            //if (PetNew.Instance.currentPetIndexNew == PetIndexNew)
            //{
            //    if (GameManager.Instance.isRU)
            //    {
            //        statusText.text = "Выбран";
            //    }
            //    else
            //    {
            //        statusText.text = "Selected";
            //    }

            //    PetNew.Instance.PickPets(PetNew.Instance.currentPetIndexNew);
            //}
            //else if (petBoughtNew_0 == 1)
            //{

            //    if (GameManager.Instance.isRU)
            //    {
            //        statusText.text = "Куплен";
            //    }
            //    else
            //    {
            //        statusText.text = "Bought";
            //    }
            //}
            //else if (petBoughtNew_0 != 1)
            //{
            //    statusText.text = ShortScaleString.parseFloat(petPrice, 1, 1000, true).ToString();
            //}
        }
        if (PetIndexNew == 1)
        {
            Info(petBoughtNew_1);
        }
        if (PetIndexNew == 2)
        {
            Info(petBoughtNew_2);
        }
        if (PetIndexNew == 3)
        {
            Info(petBoughtNew_3);
        }
        if (PetIndexNew == 4)
        {
            Info(petBoughtNew_4);
        }
        if (PetIndexNew == 5)
        {
            Info(petBoughtNew_5);
        }
        if (PetIndexNew == 6)
        {
            Info(petBoughtNew_6);
        }
        if (PetIndexNew == 7)
        {
            Info(petBoughtNew_7);
        }
        if (PetIndexNew == 8)
        {
            Info(petBoughtNew_8);
        }
        if (PetIndexNew == 9)
        {
            Info(petBoughtNew_9);
        }
        if (PetIndexNew == 10)
        {
            Info(petBoughtNew_10);
        }
        if (PetIndexNew == 11)
        {
            Info(petBoughtNew_11);
        }
        if (PetIndexNew == 12)
        {
            Info(petBoughtNew_12);
        }
        if (PetIndexNew == 13)
        {
            Info(petBoughtNew_13);
        }
        if (PetIndexNew == 14)
        {
            Info(petBoughtNew_14);
        }
        if (PetIndexNew == 15)
        {
            Info(petBoughtNew_15);
        }
        if (PetIndexNew == 16)
        {
            Info(petBoughtNew_16);
        }
        if (PetIndexNew == 17)
        {
            Info(petBoughtNew_17);
        }
        if (PetIndexNew == 18)
        {
            Info(petBoughtNew_18);
        }
        if (PetIndexNew == 19)
        {
            Info(petBoughtNew_19);
        }
        if (PetIndexNew == 20)
        {
            Info(petBoughtNew_20);
        }
        if (PetIndexNew == 21)
        {
            Info(petBoughtNew_21);
        }
        if (PetIndexNew == 22)
        {
            Info(petBoughtNew_22);
        }
    }

    public void BuyPet()
    {
        if (PetIndexNew == 0)
        {
            if (petBoughtNew_0 != 1)
            {
                if (Score.Instance.score >= petPrice)
                {
                    petBoughtNew_0 = 1;
                    YandexGame.savesData.petBoughtNew_0 = 1;
                    Buy();
                }
                else
                {
                    SoundManager.Instance.notmoney.Play();
                }
            }
            else
            {
                Bought();
            }
        }
        if (PetIndexNew == 1)
        {
            if (petBoughtNew_1 != 1)
            {
                if (Score.Instance.score >= petPrice)
                {
                    petBoughtNew_1 = 1;
                    YandexGame.savesData.petBoughtNew_1 = 1;
                    Buy();
                }
                else
                {
                    SoundManager.Instance.notmoney.Play();
                }
            }
            else
            {
                Bought();
            }
        }
        if (PetIndexNew == 2)
        {
            if (petBoughtNew_2 != 1)
            {
                if (Score.Instance.score >= petPrice)
                {
                    petBoughtNew_2 = 1;
                    YandexGame.savesData.petBoughtNew_2 = 1;
                    Buy();
                }
                else
                {
                    SoundManager.Instance.notmoney.Play();
                }
            }
            else
            {
                Bought();
            }
        }
        if (PetIndexNew == 3)
        {
            if (petBoughtNew_3 != 1)
            {
                if (Score.Instance.score >= petPrice)
                {
                    petBoughtNew_3 = 1;
                    YandexGame.savesData.petBoughtNew_3 = 1;
                    Buy();
                }
                else
                {
                    SoundManager.Instance.notmoney.Play();
                }
            }
            else
            {
                Bought();
            }
        }
        if (PetIndexNew == 4)
        {
            if (petBoughtNew_4 != 1)
            {
                if (Score.Instance.score >= petPrice)
                {
                    petBoughtNew_4 = 1;
                    YandexGame.savesData.petBoughtNew_4 = 1;
                    Buy();
                }
                else
                {
                    SoundManager.Instance.notmoney.Play();
                }
            }
            else
            {
                Bought();
            }
        }
        if (PetIndexNew == 5)
        {
            if (petBoughtNew_5 != 1)
            {
                if (Score.Instance.score >= petPrice)
                {
                    petBoughtNew_5 = 1;
                    YandexGame.savesData.petBoughtNew_5 = 1;
                    Buy();
                }
                else
                {
                    SoundManager.Instance.notmoney.Play();
                }
            }
            else
            {
                Bought();
            }
        }
        if (PetIndexNew == 6)
        {
            if (petBoughtNew_6 != 1)
            {
                if (Score.Instance.score >= petPrice)
                {
                    petBoughtNew_6 = 1;
                    YandexGame.savesData.petBoughtNew_6 = 1;
                    Buy();
                }
                else
                {
                    SoundManager.Instance.notmoney.Play();
                }
            }
            else
            {
                Bought();
            }
        }
        if (PetIndexNew == 7)
        {
            if (petBoughtNew_7 != 1)
            {
                if (Score.Instance.score >= petPrice)
                {
                    petBoughtNew_7 = 1;
                    YandexGame.savesData.petBoughtNew_7 = 1;
                    Buy();
                }
                else
                {
                    SoundManager.Instance.notmoney.Play();
                }
            }
            else
            {
                Bought();
            }
        }
        if (PetIndexNew == 8)
        {
            if (petBoughtNew_8 != 1)
            {
                if (Score.Instance.score >= petPrice)
                {
                    petBoughtNew_8 = 1;
                    YandexGame.savesData.petBoughtNew_8 = 1;
                    Buy();
                }
                else
                {
                    SoundManager.Instance.notmoney.Play();
                }
            }
            else
            {
                Bought();
            }
        }
        if (PetIndexNew == 9)
        {
            if (petBoughtNew_9 != 1)
            {
                if (Score.Instance.score >= petPrice)
                {
                    petBoughtNew_9 = 1;
                    YandexGame.savesData.petBoughtNew_9 = 1;
                    Buy();
                }
                else
                {
                    SoundManager.Instance.notmoney.Play();
                }
            }
            else
            {
                Bought();
            }
        }
        if (PetIndexNew == 10)
        {
            if (petBoughtNew_10 != 1)
            {
                if (Score.Instance.score >= petPrice)
                {
                    petBoughtNew_10 = 1;
                    YandexGame.savesData.petBoughtNew_10 = 1;
                    Buy();
                }
                else
                {
                    SoundManager.Instance.notmoney.Play();
                }
            }
            else
            {
                Bought();
            }
        }
        if (PetIndexNew == 11)
        {
            if (petBoughtNew_11 != 1)
            {
                if (Score.Instance.score >= petPrice)
                {
                    petBoughtNew_11 = 1;
                    YandexGame.savesData.petBoughtNew_11 = 1;
                    Buy();
                }
                else
                {
                    SoundManager.Instance.notmoney.Play();
                }
            }
            else
            {
                Bought();
            }
        }
        if (PetIndexNew == 12)
        {
            if (petBoughtNew_12 != 1)
            {
                if (Score.Instance.score >= petPrice)
                {
                    petBoughtNew_12 = 1;
                    YandexGame.savesData.petBoughtNew_12 = 1;
                    Buy();
                }
                else
                {
                    SoundManager.Instance.notmoney.Play();
                }
            }
            else
            {
                Bought();
            }
        }
        if (PetIndexNew == 13)
        {
            if (petBoughtNew_13 != 1)
            {
                if (Score.Instance.score >= petPrice)
                {
                    petBoughtNew_13 = 1;
                    YandexGame.savesData.petBoughtNew_13 = 1;
                    Buy();
                }
                else
                {
                    SoundManager.Instance.notmoney.Play();
                }
            }
            else
            {
                Bought();
            }
        }
        if (PetIndexNew == 14)
        {
            if (petBoughtNew_14 != 1)
            {
                if (Score.Instance.score >= petPrice)
                {
                    petBoughtNew_14 = 1;
                    YandexGame.savesData.petBoughtNew_14 = 1;
                    Buy();
                }
                else
                {
                    SoundManager.Instance.notmoney.Play();
                }
            }
            else
            {
                Bought();
            }
        }
        if (PetIndexNew == 15)
        {
            if (petBoughtNew_15 != 1)
            {
                if (Score.Instance.score >= petPrice)
                {
                    petBoughtNew_15 = 1;
                    YandexGame.savesData.petBoughtNew_15 = 1;
                    Buy();
                }
                else
                {
                    SoundManager.Instance.notmoney.Play();
                }
            }
            else
            {
                Bought();
            }
        }
        if (PetIndexNew == 16)
        {
            if (petBoughtNew_16 != 1)
            {
                if (Score.Instance.score >= petPrice)
                {
                    petBoughtNew_16 = 1;
                    YandexGame.savesData.petBoughtNew_16 = 1;
                    Buy();
                }
                else
                {
                    SoundManager.Instance.notmoney.Play();
                }
            }
            else
            {
                Bought();
            }
        }
        if (PetIndexNew == 17)
        {
            if (petBoughtNew_17 != 1)
            {
                if (Score.Instance.score >= petPrice)
                {
                    petBoughtNew_17 = 1;
                    YandexGame.savesData.petBoughtNew_17 = 1;
                    Buy();
                }
                else
                {
                    SoundManager.Instance.notmoney.Play();
                }
            }
            else
            {
                Bought();
            }
        }
        if (PetIndexNew == 18)
        {
            if (petBoughtNew_18 != 1)
            {
                if (Score.Instance.score >= petPrice)
                {
                    petBoughtNew_18 = 1;
                    YandexGame.savesData.petBoughtNew_18 = 1;
                    Buy();
                }
                else
                {
                    SoundManager.Instance.notmoney.Play();
                }
            }
            else
            {
                Bought();
            }
        }
        if (PetIndexNew == 19)
        {
            if (petBoughtNew_19 != 1)
            {
                if (Score.Instance.score >= petPrice)
                {
                    petBoughtNew_19 = 1;
                    YandexGame.savesData.petBoughtNew_19 = 1;
                    Buy();
                }
                else
                {
                    SoundManager.Instance.notmoney.Play();
                }
            }
            else
            {
                Bought();
            }
        }
        if (PetIndexNew == 20)
        {
            if (petBoughtNew_20 != 1)
            {
                if (Score.Instance.score >= petPrice)
                {
                    petBoughtNew_20 = 1;
                    YandexGame.savesData.petBoughtNew_20 = 1;
                    Buy();
                }
                else
                {
                    SoundManager.Instance.notmoney.Play();
                }
            }
            else
            {
                Bought();
            }
        }
        if (PetIndexNew == 21)
        {
            if (petBoughtNew_21 != 1)
            {
                if (Score.Instance.score >= petPrice)
                {
                    petBoughtNew_21 = 1;
                    YandexGame.savesData.petBoughtNew_21 = 1;
                    Buy();
                }
                else
                {
                    SoundManager.Instance.notmoney.Play();
                }
            }
            else
            {
                Bought();
            }
        }
        if (PetIndexNew == 22)
        {
            if (petBoughtNew_22 != 1)
            {
                if (Score.Instance.score >= petPrice)
                {
                    petBoughtNew_22 = 1;
                    YandexGame.savesData.petBoughtNew_22 = 1;
                    Buy();
                }
                else
                {
                    SoundManager.Instance.notmoney.Play();
                }
            }
            else
            {
                Bought();
            }
        }
    }
}
