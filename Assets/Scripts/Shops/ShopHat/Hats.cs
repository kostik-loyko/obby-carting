using UnityEngine;
using YG;

public class Hats : MonoBehaviour
{
    public static Hats Instance { get; set; }
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

    public int currentHatIndex = 999;
    public bool hasHat = false;

    //public GameObject[] hats;
    //public GameObject[] hats1;
    //public GameObject[] hats2;
    public GameObject[] hats3;
    //public GameObject[] hats4;
    //public GameObject[] hats5;
    //public GameObject[] hats6;
    //public GameObject[] hats7;
    //public GameObject[] hats8;
    //public GameObject[] hats9;
    //public GameObject[] hats10;

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
        currentHatIndex = YandexGame.savesData.currentHatIndex;

        hasHat = YandexGame.savesData.hasHat;

        if (hasHat)
        {
            PickHat(currentHatIndex);
        }
    }

    public void PickHat(int indexHat)
    {
        //ToggleHat(indexHat, hats);
        //ToggleHat(indexHat, hats1);
        //ToggleHat(indexHat, hats2);
        ToggleHat(indexHat, hats3);
        //ToggleHat(indexHat, hats4);
        //ToggleHat(indexHat, hats5);
        //ToggleHat(indexHat, hats6);
        //ToggleHat(indexHat, hats7);
        //ToggleHat(indexHat, hats8);
        //ToggleHat(indexHat, hats9);
        //ToggleHat(indexHat, hats10);

        hasHat = true;

        YandexGame.savesData.hasHat = hasHat;
        YandexGame.SaveProgress();
    }
    public void ToggleHat(int indexHat, GameObject[] hats)
    {
        for (int i = 0; i < hats.Length; i++)
        {
            hats[i].SetActive(false);
        }
        hats[indexHat].SetActive(true);
    }
    public void FreeHat()
    {
        //for (int i = 0; i < hats.Length; i++)
        //{
        //    hats[i].SetActive(false);
        //}
        //for (int i = 0; i < hats1.Length; i++)
        //{
        //    hats1[i].SetActive(false);
        //}
        //for (int i = 0; i < hats2.Length; i++)
        //{
        //    hats2[i].SetActive(false);
        //}
        for (int i = 0; i < hats3.Length; i++)
        {
            hats3[i].SetActive(false);
        }
        //for (int i = 0; i < hats4.Length; i++)
        //{
        //    hats4[i].SetActive(false);
        //}
        //for (int i = 0; i < hats5.Length; i++)
        //{
        //    hats5[i].SetActive(false);
        //}
        //for (int i = 0; i < hats6.Length; i++)
        //{
        //    hats6[i].SetActive(false);
        //}
        //for (int i = 0; i < hats7.Length; i++)
        //{
        //    hats7[i].SetActive(false);
        //}
        //for (int i = 0; i < hats8.Length; i++)
        //{
        //    hats8[i].SetActive(false);
        //}
        //for (int i = 0; i < hats9.Length; i++)
        //{
        //    hats9[i].SetActive(false);
        //}
        //for (int i = 0; i < hats10.Length; i++)
        //{
        //    hats10[i].SetActive(false);
        //}
    }
}
