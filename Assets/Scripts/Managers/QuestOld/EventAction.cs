using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using YG;

public class EventAction : MonoBehaviour
{
    public static EventAction Instance { get; set; }
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

    public int indexAction;
    public int indexActionName;
    public TextMeshProUGUI actionName;
    [SerializeField] GameObject actionTimer;
    [SerializeField] TextMeshProUGUI actionTimerText;
    [SerializeField] TextMeshProUGUI actionTimerCount;
    public string[] actionsName;
    public string[] actionsNameRu;
    public string[] actionsNameEn;

    void Start()
    {
        indexAction = 0;
        indexActionName = 0;

        if (YandexGame.SDKEnabled == true)
        {
            GetLoad();
        }
    }

    private void OnEnable() => YandexGame.GetDataEvent += GetLoad;

    private void OnDisable() => YandexGame.GetDataEvent -= GetLoad;

    private void GetLoad()
    {
        indexAction = YandexGame.savesData.indexAction;
        indexActionName = YandexGame.savesData.indexActionName;

        //ShowActionName();
    }
    public void DicremetCountObjects()
    {
        SpawnObjects.Instance.countObgects--;
        ShowActionTimer();

        if (SpawnObjects.Instance.countObgects <= 0)
        {
            UpIndexAction();
            
            SpawnObjects.Instance.countObgects = 10;
            SpawnObjects.Instance.EnableSpawnObgectToggle();
        }
    }

    public void UpIndexAction()
    {
        indexAction++;
        //PlayerPrefs.SetInt("indexAction", indexAction);
        YandexGame.savesData.indexAction = indexAction;
        //YandexGame.SaveProgress();

        UpIndexActionName();
        HideActionTimer();

        DialogSystem.Instance.enableNextDialog = true;
        //PlayerPrefs.SetInt("enableNextDialog", DialogSystem.Instance.enableNextDialog ? 1 : 0);
        YandexGame.savesData.enableNextDialog = DialogSystem.Instance.enableNextDialog;
        YandexGame.SaveProgress();
    }
    public void ShowActionName()
    {
        actionName.text = actionsName[indexActionName];
    }
    public void UpIndexActionName()
    {
        indexActionName++;
        //PlayerPrefs.SetInt("indexActionName", indexActionName);
        YandexGame.savesData.indexActionName = indexActionName;
        YandexGame.SaveProgress();

        ShowActionName();
    }
    public void ShowActionTimer()
    {
        actionTimer.SetActive(true);
        actionTimerCount.text = SpawnObjects.Instance.countObgects.ToString();
    }
    public void HideActionTimer()
    {
        actionTimer.SetActive(false);
        actionTimerCount.text = SpawnObjects.Instance.countObgects.ToString();
    }
    public void ResetEventAction()
    {
        indexAction = 0;
        indexActionName = 0;
        YandexGame.savesData.indexAction = indexAction;

        YandexGame.savesData.indexActionName = indexActionName;
        YandexGame.SaveProgress();
    }
    public void HideQuest()
    {
        actionName.alpha = 0;
        actionTimerText.alpha = 0;
        actionTimerCount.alpha = 0;
    }
    public void ShowQuest()
    {
        actionName.alpha = 1;
        actionTimerText.alpha = 1;
        actionTimerCount.alpha = 1;
    }
}
