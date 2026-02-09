using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YG;

public class ShopCartBTN : MonoBehaviour
{
    public int cartPrice = 0;
    public Button buyButton;
    public TextMeshProUGUI statusText;
    public int cartIndex = 0;
    public bool firstCartBuy = false;

    private ShopCarts manager;

    int cartBought_0 = 1;
    int cartBought_1 = 0;
    int cartBought_2 = 0;
    int cartBought_3 = 0;
    int cartBought_4 = 0;
    int cartBought_5 = 0;
    int cartBought_6 = 0;
    int cartBought_7 = 0;
    int cartBought_8 = 0;
    int cartBought_9 = 0;
    int cartBought_10 = 0;
    int cartBought_11 = 0;
    int cartBought_12 = 0;
    int cartBought_13 = 0;
    int cartBought_14 = 0;
    int cartBought_15 = 0;
    int cartBought_16 = 0;
    int cartBought_17 = 0;
    int cartBought_18 = 0;
    int cartBought_19 = 0;
    int cartBought_20 = 0;
    int cartBought_21 = 0;
    int cartBought_22 = 0;
    int cartBought_23 = 0;
    int cartBought_24 = 0;
    int cartBought_25 = 0;
    int cartBought_26 = 0;
    int cartBought_27 = 0;

    private void Start()
    {
        buyButton.onClick.AddListener(BuyCart);

        if (YandexGame.SDKEnabled == true)
        {
            GetLoad();
        }
    }

    private void OnEnable() => YandexGame.GetDataEvent += GetLoad;

    private void OnDisable() => YandexGame.GetDataEvent -= GetLoad;

    private void GetLoad()
    {
        cartBought_0 = YandexGame.savesData.cartBought_0;
        cartBought_1 = YandexGame.savesData.cartBought_1;
        cartBought_2 = YandexGame.savesData.cartBought_2;
        cartBought_3 = YandexGame.savesData.cartBought_3;
        cartBought_4 = YandexGame.savesData.cartBought_4;
        cartBought_5 = YandexGame.savesData.cartBought_5;
        cartBought_6 = YandexGame.savesData.cartBought_6;
        cartBought_7 = YandexGame.savesData.cartBought_7;
        cartBought_8 = YandexGame.savesData.cartBought_8;
        cartBought_9 = YandexGame.savesData.cartBought_9;
        cartBought_10 = YandexGame.savesData.cartBought_10;
        cartBought_11 = YandexGame.savesData.cartBought_11;
        cartBought_12 = YandexGame.savesData.cartBought_12;
        cartBought_13 = YandexGame.savesData.cartBought_13;
        cartBought_14 = YandexGame.savesData.cartBought_14;
        cartBought_15 = YandexGame.savesData.cartBought_15;
        cartBought_16 = YandexGame.savesData.cartBought_16;
        cartBought_17 = YandexGame.savesData.cartBought_17;
        cartBought_18 = YandexGame.savesData.cartBought_18;
        cartBought_19 = YandexGame.savesData.cartBought_19;
        cartBought_20 = YandexGame.savesData.cartBought_20;
        cartBought_21 = YandexGame.savesData.cartBought_21;
        cartBought_22 = YandexGame.savesData.cartBought_22;
        cartBought_23 = YandexGame.savesData.cartBought_23;
        cartBought_24 = YandexGame.savesData.cartBought_24;
        cartBought_25 = YandexGame.savesData.cartBought_25;
        cartBought_26 = YandexGame.savesData.cartBought_26;
        cartBought_27 = YandexGame.savesData.cartBought_27;
        Carts.Instance.currentCartIndex = YandexGame.savesData.currentCartIndex;

        UpdateInfo();
    }
    public void SetManager(ShopCarts shopManager)
    {
        manager = shopManager;
    }

    public void UpdateInfo()
    {
        if (cartIndex == 0)
        {
            GetCart(cartBought_0);
        }
        if (cartIndex == 1)
        {
            GetCart(cartBought_1);
        }
        if (cartIndex == 2)
        {
            GetCart(cartBought_2);
        }
        if (cartIndex == 3)
        {
            GetCart(cartBought_3);
        }
        if (cartIndex == 4)
        {
            GetCart(cartBought_4);
        }
        if (cartIndex == 5)
        {
            GetCart(cartBought_5);
        }
        if (cartIndex == 6)
        {
            GetCart(cartBought_6);
        }
        if (cartIndex == 7)
        {
            GetCart(cartBought_7);
        }
        if (cartIndex == 8)
        {
            GetCart(cartBought_8);
        }
        if (cartIndex == 9)
        {
            GetCart(cartBought_9);
        }
        if (cartIndex == 10)
        {
            GetCart(cartBought_10);
        }
        if (cartIndex == 11)
        {
            GetCart(cartBought_11);
        }
        if (cartIndex == 12)
        {
            GetCart(cartBought_12);
        }
        if (cartIndex == 12)
        {
            GetCart(cartBought_12);
        }
        if (cartIndex == 13)
        {
            GetCart(cartBought_13);
        }
        if (cartIndex == 14)
        {
            GetCart(cartBought_14);
        }
        if (cartIndex == 15)
        {
            GetCart(cartBought_15);
        }
        if (cartIndex == 16)
        {
            GetCart(cartBought_16);
        }
        if (cartIndex == 17)
        {
            GetCart(cartBought_17);
        }
        if (cartIndex == 18)
        {
            GetCart(cartBought_18);
        }
        if (cartIndex == 19)
        {
            GetCart(cartBought_19);
        }
        if (cartIndex == 20)
        {
            GetCart(cartBought_20);
        }
        if (cartIndex == 21)
        {
            GetCart(cartBought_21);
        }
        if (cartIndex == 22)
        {
            GetCart(cartBought_22);
        }
        if (cartIndex == 23)
        {
            GetCart(cartBought_23);
        }
        if (cartIndex == 24)
        {
            GetCart(cartBought_24);
        }
        if (cartIndex == 25)
        {
            GetCart(cartBought_25);
        }
        if (cartIndex == 26)
        {
            GetCart(cartBought_26);
        }
        if (cartIndex == 27)
        {
            GetCart(cartBought_27);
        }
    }
    public void GetCart(int cartBought)
    {
        if (Carts.Instance.currentCartIndex == cartIndex)
        {
            if (GameManager.Instance.isRU)
            {
                statusText.text = "Выбран";
            }
            else
            {
                statusText.text = "Selected";
            }
            Carts.Instance.PickCarts(Carts.Instance.currentCartIndex);
            Carts.Instance.ShowCart(cartIndex);
        }
        else if (cartBought == 1)
        {
            if (GameManager.Instance.isRU)
            {
                statusText.text = "Куплен";
            }
            else
            {
                statusText.text = "Bought";
            }
            Carts.Instance.ShowCart(cartIndex);
        }
        else if (cartBought != 1)
        {
            statusText.text = ShortScaleString.parseFloat(cartPrice, 1, 1000, true).ToString();
        }
    }

    public void BuyCart()
    {
        if (cartIndex == 0)
        {
            CartBuy(ref cartBought_0, ref YandexGame.savesData.cartBought_0);
        }
        if (cartIndex == 1)
        {
            CartBuy(ref cartBought_1, ref YandexGame.savesData.cartBought_1);
        }
        if (cartIndex == 2)
        {
            CartBuy(ref cartBought_2, ref YandexGame.savesData.cartBought_2);
        }
        if (cartIndex == 3)
        {
            CartBuy(ref cartBought_3, ref YandexGame.savesData.cartBought_3);
        }
        if (cartIndex == 4)
        {
            CartBuy(ref cartBought_4, ref YandexGame.savesData.cartBought_4);
        }
        if (cartIndex == 5)
        {
            CartBuy(ref cartBought_5, ref YandexGame.savesData.cartBought_5);
        }
        if (cartIndex == 6)
        {
            CartBuy(ref cartBought_6, ref YandexGame.savesData.cartBought_6);
        }
        if (cartIndex == 7)
        {
            CartBuy(ref cartBought_7, ref YandexGame.savesData.cartBought_7);
        }
        if (cartIndex == 8)
        {
            CartBuy(ref cartBought_8, ref YandexGame.savesData.cartBought_8);
        }
        if (cartIndex == 9)
        {
            CartBuy(ref cartBought_9, ref YandexGame.savesData.cartBought_9);
        }
        if (cartIndex == 10)
        {
            CartBuy(ref cartBought_10, ref YandexGame.savesData.cartBought_10);
        }
        if (cartIndex == 11)
        {
            CartBuy(ref cartBought_11, ref YandexGame.savesData.cartBought_11);
        }
        if (cartIndex == 12)
        {
            CartBuy(ref cartBought_12, ref YandexGame.savesData.cartBought_12);
        }
        if (cartIndex == 13)
        {
            CartBuy(ref cartBought_13, ref YandexGame.savesData.cartBought_13);
        }
        if (cartIndex == 14)
        {
            CartBuy(ref cartBought_14, ref YandexGame.savesData.cartBought_14);
        }
        if (cartIndex == 15)
        {
            CartBuy(ref cartBought_15, ref YandexGame.savesData.cartBought_15);
        }
        if (cartIndex == 16)
        {
            CartBuy(ref cartBought_16, ref YandexGame.savesData.cartBought_16);
        }
        if (cartIndex == 17)
        {
            CartBuy(ref cartBought_17, ref YandexGame.savesData.cartBought_17);
        }
        if (cartIndex == 18)
        {
            CartBuy(ref cartBought_18, ref YandexGame.savesData.cartBought_18);
        }
        if (cartIndex == 19)
        {
            CartBuy(ref cartBought_19, ref YandexGame.savesData.cartBought_19);
        }
        if (cartIndex == 20)
        {
            CartBuy(ref cartBought_20, ref YandexGame.savesData.cartBought_20);
        }
        if (cartIndex == 21)
        {
            CartBuy(ref cartBought_21, ref YandexGame.savesData.cartBought_21);
        }
        if (cartIndex == 22)
        {
            CartBuy(ref cartBought_22, ref YandexGame.savesData.cartBought_22);
        }
        if (cartIndex == 23)
        {
            CartBuy(ref cartBought_23, ref YandexGame.savesData.cartBought_23);
        }
        if (cartIndex == 24)
        {
            CartBuy(ref cartBought_24, ref YandexGame.savesData.cartBought_24);
        }
        if (cartIndex == 25)
        {
            CartBuy(ref cartBought_25, ref YandexGame.savesData.cartBought_25);
        }
        if (cartIndex == 26)
        {
            CartBuy(ref cartBought_26, ref YandexGame.savesData.cartBought_26);
        }
        if (cartIndex == 27)
        {
            CartBuy(ref cartBought_27, ref YandexGame.savesData.cartBought_27);
        }
    }
    public void CartBuy(ref int cartBought, ref int cartBoughtYG)
    {
            if (cartBought != 1)
            {
                if (Score.Instance.score >= cartPrice)
                {
                    Score.Instance.DownScore(cartPrice);

                    cartBought = 1;
                    cartBoughtYG = cartBought;
                    Carts.Instance.currentCartIndex = cartIndex;
                    YandexGame.savesData.currentCartIndex = cartIndex;

                    manager.UpdateInfoButton();
                }
                else
                {
                    SoundManager.Instance.notmoney.Play();
                }
            }
            else
            {
                Carts.Instance.currentCartIndex = cartIndex;
                YandexGame.savesData.currentCartIndex = cartIndex;

                manager.UpdateInfoButton();
            }
    }
}