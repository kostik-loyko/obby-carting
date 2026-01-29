using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using YG;

public class ManagerQests : MonoBehaviour
{
    public static ManagerQests Instance { get; set; }
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

    public PeapleQuests[] NPS;
    public GameObject[] Items;
    public GameObject[] Inventory;
    public GameObject[] note;

    public bool[] completeQuest = new bool[40];
    public bool[] notActiveteOtherQuest = new bool[40];
    public bool endQuest = false;

    public int couterQuestFinished = 0;

    public TextMeshProUGUI couterQuestFinishedText;
    public TextMeshProUGUI couterQuestFinishedText1;

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
        completeQuest = YandexGame.savesData.completeQuest;
        couterQuestFinished = YandexGame.savesData.couterQuestFinished;
        couterQuestFinishedText.text = couterQuestFinished.ToString();
        couterQuestFinishedText1.text = couterQuestFinished.ToString();

        if (couterQuestFinished >= 20)
        {
            Gates.Instance.OpenGate();
        }
        if (couterQuestFinished >= 30)
        {
            Gates.Instance.OpenGate1();
        }

        CheckItemNPS();
    }

    public void CheckItemNPS()
    {
        for (int i = 0; i < NPS.Length; i++)
        {
            if (completeQuest[i])
            {
               NPS[i].itemNPS.SetActive(true);
            }
        }
    }
}
