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

    int cartBought_0;
    int cartBought_1;
    int cartBought_2;
    int cartBought_3;
    int cartBought_4;
    int cartBought_5;
    int cartBought_6;
    int cartBought_7;

    
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
            if (cartBought_0 != 1)
            {
                if (Score.Instance.score >= cartPrice)
                {
                    Score.Instance.DownScore(cartPrice);

                    cartBought_0 = 1;
                    YandexGame.savesData.cartBought_0 = 1;
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
        if (cartIndex == 1)
        {
            if (cartBought_1 != 1)
            {
                if (Score.Instance.score >= cartPrice)
                {
                    Score.Instance.DownScore(cartPrice);

                    cartBought_1 = 1;
                    YandexGame.savesData.cartBought_1 = 1;
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
        if (cartIndex == 2)
        {
            if (cartBought_2 != 1)
            {
                if (Score.Instance.score >= cartPrice)
                {
                    Score.Instance.DownScore(cartPrice);

                    cartBought_2 = 1;
                    YandexGame.savesData.cartBought_2 = 1;
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
        if (cartIndex == 3)
        {
            if (cartBought_3 != 1)
            {
                if (Score.Instance.score >= cartPrice)
                {
                    Score.Instance.DownScore(cartPrice);

                    cartBought_3 = 1;
                    YandexGame.savesData.cartBought_3 = 1;
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
        if (cartIndex == 4)
        {
            if (cartBought_4 != 1)
            {
                if (Score.Instance.score >= cartPrice)
                {
                    Score.Instance.DownScore(cartPrice);

                    cartBought_4 = 1;
                    YandexGame.savesData.cartBought_4 = 1;
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
        if (cartIndex == 5)
        {
            if (cartBought_5 != 1)
            {
                if (Score.Instance.score >= cartPrice)
                {
                    Score.Instance.DownScore(cartPrice);

                    cartBought_5 = 1;
                    YandexGame.savesData.cartBought_5 = 1;
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
        if (cartIndex == 6)
        {
            if (cartBought_6 != 1)
            {
                if (Score.Instance.score >= cartPrice)
                {
                    Score.Instance.DownScore(cartPrice);

                    cartBought_6 = 1;
                    YandexGame.savesData.cartBought_6 = 1;
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
        if (cartIndex == 7)
        {
            if (cartBought_7 != 1)
            {
                if (Score.Instance.score >= cartPrice)
                {
                    Score.Instance.DownScore(cartPrice);

                    cartBought_7 = 1;
                    YandexGame.savesData.cartBought_7 = 1;
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
}
