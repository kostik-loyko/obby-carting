using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class SpawnNPC : MonoBehaviour
{
    public static SpawnNPC Instance { get; set; }
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

    [SerializeField] GameObject[] spawnsNPC;
    [SerializeField] GameObject[] stubsNPC;
    public int indexSpawnNPC;

    private void Start()
    {
        indexSpawnNPC = 0;
        //if (PlayerPrefs.HasKey("indexSpawnNPC"))
        //{
        //    indexSpawnNPC = PlayerPrefs.GetInt("indexSpawnNPC");
        //}
        if (YandexGame.SDKEnabled == true)
        {
            GetLoad();
        }
    }

    private void OnEnable() => YandexGame.GetDataEvent += GetLoad;

    private void OnDisable() => YandexGame.GetDataEvent -= GetLoad;

    private void GetLoad()
    {
        indexSpawnNPC = YandexGame.savesData.indexSpawnNPC;

        NextSpawnNPC();
    }

    public void NextSpawnNPC()
    {
        for (int i = 0; i < spawnsNPC.Length; i++)
        {
            spawnsNPC[i].SetActive(false);
        }
        spawnsNPC[indexSpawnNPC].SetActive(true);
    }

    public void UpNextSpawnNPC()
    {
        indexSpawnNPC++;
        NextSpawnNPC();
        //PlayerPrefs.SetInt("indexSpawnNPC", indexSpawnNPC);
        YandexGame.savesData.indexSpawnNPC = indexSpawnNPC;
        YandexGame.SaveProgress();
    }

    public void StubNPC()
    {
        StartCoroutine(WaitStubNPC());
    }
    public void ResetSpawnNPC()
    {
        indexSpawnNPC = 0;
        //PlayerPrefs.SetInt("indexSpawnNPC", indexSpawnNPC);
        YandexGame.savesData.indexSpawnNPC = indexSpawnNPC;
        YandexGame.SaveProgress();
    }
    private IEnumerator WaitStubNPC()
    {
        for (int i = 0; i < stubsNPC.Length; i++)
        {
            stubsNPC[i].SetActive(false);
        }
        if(indexSpawnNPC == 0)
        {
            stubsNPC[indexSpawnNPC].SetActive(true);
        }
        else
        {
            stubsNPC[indexSpawnNPC - 1].SetActive(true);
        }
        
        yield return new WaitForSeconds(15f);

        if (indexSpawnNPC == 0)
        {
            stubsNPC[indexSpawnNPC].SetActive(false);
        }
        else
        {
            stubsNPC[indexSpawnNPC - 1].SetActive(false);
        }
    }
}
