using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class Trails : MonoBehaviour
{
    public static Trails Instance { get; set; }
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

    public int currentTrailIndex = 999;
    public bool hasTrail = false;

    //public GameObject[] trailsLeft;
    //public GameObject[] trailsRight;
    //public GameObject[] trailsLeft1;
    //public GameObject[] trailsRight1;
    //public GameObject[] trailsLeft2;
    //public GameObject[] trailsRight2;
    public GameObject[] trailsLeft3;
    public GameObject[] trailsRight3;
    //public GameObject[] trailsLeft4;
    //public GameObject[] trailsRight4;
    //public GameObject[] trailsLeft5;
    //public GameObject[] trailsRight5;
    //public GameObject[] trailsLeft6;
    //public GameObject[] trailsRight6;
    //public GameObject[] trailsLeft7;
    //public GameObject[] trailsRight7;
    //public GameObject[] trailsLeft8;
    //public GameObject[] trailsRight8;
    //public GameObject[] trailsLeft9;
    //public GameObject[] trailsRight9;
    //public GameObject[] trailsLeft10;
    //public GameObject[] trailsRight10;

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
        currentTrailIndex = YandexGame.savesData.currentTrailIndex;

        hasTrail = YandexGame.savesData.hasTrail;

        if (hasTrail)
        {
            PickTrail(currentTrailIndex);
        }
    }

    public void PickTrail(int indexTrail)
    {
        //ToggleTrail(indexTrail, trailsLeft, trailsRight);
        //ToggleTrail(indexTrail, trailsLeft1, trailsRight1);
        //ToggleTrail(indexTrail, trailsLeft2, trailsRight2);
        ToggleTrail(indexTrail, trailsLeft3, trailsRight3);
        //ToggleTrail(indexTrail, trailsLeft4, trailsRight4);
        //ToggleTrail(indexTrail, trailsLeft5, trailsRight5);
        //ToggleTrail(indexTrail, trailsLeft6, trailsRight6);
        //ToggleTrail(indexTrail, trailsLeft7, trailsRight7);
        //ToggleTrail(indexTrail, trailsLeft8, trailsRight8);
        //ToggleTrail(indexTrail, trailsLeft9, trailsRight9);
        //ToggleTrail(indexTrail, trailsLeft10, trailsRight10);

        hasTrail = true;
        YandexGame.savesData.hasTrail = hasTrail;
        YandexGame.SaveProgress();
    }

    public void ToggleTrail(int indexTrail, GameObject[] trailsLeft, GameObject[] trailsRight)
    {
        for (int i = 0; i < trailsLeft.Length; i++)
        {
            trailsLeft[i].SetActive(false);
            trailsRight[i].SetActive(false);
        }
        trailsLeft[indexTrail].SetActive(true);
        trailsRight[indexTrail].SetActive(true);
    }
}
