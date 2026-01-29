using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
using YG;

public class SpawnObjects : MonoBehaviour
{
    public static SpawnObjects Instance { get; set; }
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

    [SerializeField] GameObject[] spawnsObjects;
    public int indexSpawnObjects;
    public int countObgects;
    public bool enableSpawnObgect;

    private void Start()
    {
        indexSpawnObjects = 0;
        countObgects = 10;
        enableSpawnObgect = true;
        if (YandexGame.SDKEnabled == true)
        {
            GetLoad();
        }
    }

    private void OnEnable() => YandexGame.GetDataEvent += GetLoad;

    private void OnDisable() => YandexGame.GetDataEvent -= GetLoad;

    private void GetLoad()
    {
        indexSpawnObjects = YandexGame.savesData.indexSpawnObjects;
        enableSpawnObgect = YandexGame.savesData.enableSpawnObgect;
        StartCoroutine(WaitNextSpawnObjects());
    }

    public void NextSpawnObjects()
    {
        for (int i = 0; i < spawnsObjects.Length; i++)
        {
            spawnsObjects[i].SetActive(false);
        }
        spawnsObjects[indexSpawnObjects].SetActive(true);
    }
    public void UpNextSpawnObjects()
    {
        indexSpawnObjects++;
        //PlayerPrefs.SetInt("indexSpawnObjects", indexSpawnObjects);
        YandexGame.savesData.indexSpawnObjects = indexSpawnObjects;
        YandexGame.SaveProgress();
    }
    public void EnableSpawnObgectToggle()
    {
        if (enableSpawnObgect)
        {
            enableSpawnObgect = false;
        } else
        {
            enableSpawnObgect = true;
        }
        //PlayerPrefs.SetInt("enableSpawnObgect", enableSpawnObgect ? 1 : 0);
        YandexGame.savesData.enableSpawnObgect = enableSpawnObgect;
        YandexGame.SaveProgress();
    }

    public void ResetSpawnObjects()
    {
        for (int i = 0; i < spawnsObjects.Length; i++)
        {
            for (int j = 0; j < spawnsObjects[i].transform.childCount; j++)
            {
                spawnsObjects[i].transform.GetChild(j).gameObject.SetActive(true);
            }
        }
        spawnsObjects[spawnsObjects.Length - 1].SetActive(false);
        indexSpawnObjects = 0;
        //PlayerPrefs.SetInt("indexSpawnObjects", indexSpawnObjects);
        YandexGame.savesData.indexSpawnObjects = indexSpawnObjects;
        YandexGame.SaveProgress();
        EnableSpawnObgectToggle();
    }

    private IEnumerator WaitNextSpawnObjects()
    {
        yield return new WaitForSeconds(0.2f);

        if (DialogSystem.Instance.indexDialog % 2 != 0 && enableSpawnObgect)
        {
            NextSpawnObjects();
        }
    }
}
