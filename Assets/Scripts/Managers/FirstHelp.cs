using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class FirstHelp : MonoBehaviour
{
    public static FirstHelp Instance { get; set; }
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
    [SerializeField] GameObject[] helpObj;
    bool[] isDestroy = new bool[3];
    void Start()
    {
        GetLoad();
    }
    private void OnEnable() => YandexGame.GetDataEvent += GetLoad;

    private void OnDisable() => YandexGame.GetDataEvent -= GetLoad;

    private void GetLoad()
    {
        isDestroy = YandexGame.savesData.objFirst;
        DestroyHelp();
    }
    public void DestroyHelp()
    {
        for (int i = 0; i < helpObj.Length; i++)
        {
            if (helpObj[i] != null)
            {
                if (isDestroy[i])
                {
                    Destroy(helpObj[i]);
                }
            }
        }
    }
    public void ChangeIsDesroy(int index)
    {
        isDestroy[index] = true;
        YandexGame.savesData.objFirst[index] = isDestroy[index];

        DestroyHelp();
    }
}
