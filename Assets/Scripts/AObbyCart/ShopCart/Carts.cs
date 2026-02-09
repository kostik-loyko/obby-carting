using UnityEngine;
using YG;

public class Carts : MonoBehaviour
{
    public static Carts Instance { get; set; }
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public int currentCartIndex;
    public bool hasCarts = false;

    public GameObject[] cartsBack;
    [SerializeField] GameObject[] cartsMove;
    [SerializeField] GameObject[] hideCarts;
    [SerializeField] MoveTop moveTop;

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
        currentCartIndex = YandexGame.savesData.currentCartIndex;

        hasCarts = YandexGame.savesData.hasCarts;

        if (hasCarts)
        {
            PickCarts(currentCartIndex);
        }
    }
    public void PickCarts(int indexCart)
    {
        for (int i = 0; i < cartsBack.Length; i++)
        {
            cartsBack[i].SetActive(false);
        }
        cartsBack[indexCart].SetActive(true);
        hasCarts = true;

        moveTop.SetSpeedCart(currentCartIndex);

        YandexGame.savesData.hasCarts = hasCarts;
        YandexGame.SaveProgress();
    }
    public void ShowCart(int currIndex)
    {
        for (int i = 0; i < hideCarts.Length; i++)
        {
            if (i == currIndex && currIndex != hideCarts.Length - 1)
            {
                if (hideCarts[i + 1] != null)
                {
                    hideCarts[i + 1].SetActive(false);
                }
            }
        }
    }
    public void SetCartMove()
    {
        cartsBack[currentCartIndex].SetActive(false);
        cartsMove[currentCartIndex].SetActive(true);
    }
    public void SetCartStop()
    {
        cartsBack[currentCartIndex].SetActive(true);
        cartsMove[currentCartIndex].SetActive(false);
    }
}
