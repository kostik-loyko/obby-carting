using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using YG;

public class HelpTask : MonoBehaviour
{
    public static HelpTask Instance { get; set; }
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
    [SerializeField] GameObject helpTask1;
    [SerializeField] GameObject helpTask2;
    bool isHide1 = false;
    bool isHide2 = false;

    void Start()
    {
        GetLoad();
    }
    private void OnEnable() => YandexGame.GetDataEvent += GetLoad;

    private void OnDisable() => YandexGame.GetDataEvent -= GetLoad;

    private void GetLoad()
    {
        isHide1 = YandexGame.savesData.isHideTask1;
        isHide2 = YandexGame.savesData.isHideTask2;
        HideTaskHelp();
    }
    public void HideTaskHelp()
    {
        if (isHide1)
        {
            helpTask1.SetActive(false);
            helpTask2.SetActive(true);
        }
        if (isHide2)
        {
            helpTask2.SetActive(false);
        }
    }
    public void ChangeIsHide(int index)
    {
        if (index == 0 && !isHide1)
        {
            isHide1 = true;

            YandexGame.savesData.isHideTask1 = isHide1;
            YandexGame.SaveProgress();
        }
        else if (index == 1 && !isHide2)
        {
            isHide2 = true;
            YandexGame.savesData.isHideTask2 = isHide2;
            YandexGame.SaveProgress();
        }
        HideTaskHelp();
    }
}
