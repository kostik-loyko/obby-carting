using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using YG;

public class DialogSystem : MonoBehaviour
{
    public static DialogSystem Instance { get; set; }
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

    public string[] lines;
    public string[] linesRu;
    public string[] linesEn;
    public TextMeshProUGUI dialogText;
    public GameObject dialogPanel;
    public GameObject Dgostik;
    public GameObject JumpBtn;
    public GameObject FireBtn;

    public int indexDialog;
    public bool enableNextDialog = true;

    void Start()
    {
        indexDialog = 0;
        if (YandexGame.SDKEnabled == true)
        {
            GetLoad();
        }
    }

    private void OnEnable() => YandexGame.GetDataEvent += GetLoad;

    private void OnDisable() => YandexGame.GetDataEvent -= GetLoad;

    private void GetLoad()
    {
        indexDialog = YandexGame.savesData.indexDialog;
        enableNextDialog = YandexGame.savesData.enableNextDialog;
    }

    public void StartDialog()
    {
        dialogPanel.SetActive(true);
        Dgostik.SetActive(false);
        JumpBtn.SetActive(false);
        FireBtn.SetActive(false);
        dialogText.text = string.Empty;
        dialogText.text = lines[indexDialog];

        PlayerBehavior.Instance.velocity = 0;
        GameManager.Instance.OffPunch();
        GameManager.Instance.canOpenUI = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        GameManager.Instance.OffIcon();
    }

    public void FinishDialog()
    {
        indexDialog++;
        YandexGame.savesData.indexDialog = indexDialog;

        enableNextDialog = false;
        YandexGame.savesData.enableNextDialog = enableNextDialog;
        YandexGame.SaveProgress();

        EventAction.Instance.UpIndexActionName();

        dialogPanel.SetActive(false);
        Dgostik.SetActive(true);
        JumpBtn.SetActive(true);
        FireBtn.SetActive(true);
        PlayerBehavior.Instance.velocity = PlayerBehavior.Instance.velocityAfterDialog;

        GameManager.Instance.OnPunch();
        GameManager.Instance.canOpenUI = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        GameManager.Instance.OnIcon();

        if (indexDialog % 2 != 0)
        {
            SpawnObjects.Instance.NextSpawnObjects();
        }

        if (indexDialog % 2 == 0)
        {
            if (EventAction.Instance.indexAction < 9)
            {
                SpawnNPC.Instance.UpNextSpawnNPC();
                SpawnObjects.Instance.UpNextSpawnObjects();
                SpawnObjects.Instance.EnableSpawnObgectToggle();

                enableNextDialog = true;
                YandexGame.savesData.enableNextDialog = enableNextDialog;
                YandexGame.SaveProgress();

                SpawnNPC.Instance.StubNPC();
            } else
            {
                SpawnObjects.Instance.ResetSpawnObjects();
                EventAction.Instance.ResetEventAction();
                SpawnNPC.Instance.ResetSpawnNPC();
                SpawnNPC.Instance.NextSpawnNPC();
                EventAction.Instance.ShowActionName();
                indexDialog = 0;
                YandexGame.savesData.indexDialog = indexDialog;

                enableNextDialog = true;
                YandexGame.savesData.enableNextDialog = enableNextDialog;
                YandexGame.SaveProgress();

                SpawnNPC.Instance.StubNPC();
            }
        }
    }
}
