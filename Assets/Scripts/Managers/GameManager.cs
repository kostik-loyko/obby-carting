using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using YG;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; set; }
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

    public bool isRU;
    private bool isAutorised = false;
    public bool onGraundForADV;
    private bool inMenu = false;
    public bool canOpenUI = false;
    private bool firstGameOpen = true;

    [SerializeField] GameObject ADVpanel;
    [SerializeField] GameObject PausePanel;

    [SerializeField] GameObject player;

    public bool punchEnanle = false;

    [SerializeField] GameObject DailyPanel;
    [SerializeField] GameObject ShopeTrails;
    [SerializeField] GameObject WheelFortune;
    [SerializeField] GameObject TimerShop;
    [SerializeField] GameObject PetShop;
    [SerializeField] GameObject brCollect;

    [SerializeField] GameObject SignShoot;

    public GameObject DailyPanelIcon;
    public GameObject ShopeTrailsIcon;
    public GameObject WheelFortuneIcon;
    public GameObject TimerShopIcon;
    public GameObject PetShopIcon;
    [SerializeField] GameObject brCollectIcon;
    //public GameObject weaponIcon1;
    //public GameObject weaponIcon2;
    //public GameObject weaponIcon3;

    [SerializeField] GameObject[] KeyCodes;

    public float gameTime;

    public GameObject[] personSkins;
    public GameObject[] buySkins;

    private bool canShowADV = false;

    [SerializeField] GrowNeck growNeck;
    private void Start()
    {
        if (YandexGame.SDKEnabled == true)
        {
            GetLoad();
        }
        Time.timeScale = 0f;
        //if (MobileInputManager.Instance.IsMobileDevice())
        //{
        //    SignShoot.SetActive(false);
        //}
        //else
        //{
        //    SignShoot.SetActive(true);
        //}
        StartCoroutine(OnShowADV());
    }

    private void Update()
    {
        OnUI();
    }
    private void OnEnable()
    {
        YandexGame.GetDataEvent += GetLoad;
        YG2.onCloseAnyAdv += OffShowADV;
    }


    private void OnDisable()
    {
        YandexGame.GetDataEvent -= GetLoad;
        YG2.onCloseAnyAdv -= OffShowADV;
    }

    private void GetLoad()
    {
        firstGameOpen = YG2.saves.isFirstGameOpen;
        if (firstGameOpen)
        {
            YandexGame.ResetSaveProgress();
            YG2.saves.isFirstGameOpen = false;
            YandexGame.SaveProgress();
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (YG2.lang == "ru")
        {
            isRU = true;
        }

        if (YG2.lang == "en")
        {
            isRU = false;
        }
        //EventAction.Instance.ShowActionName();
        if (YG2.player.auth)
        {
            isAutorised = true;
        }
    }
    public void AdvShow()
    {
        if (canShowADV)
        {
            YG2.InterstitialAdvShow();
        }
    }
    private IEnumerator OnShowADV()
    {
        yield return new WaitForSeconds(86f);
        canShowADV = true;
    }
    private void OffShowADV()
    {
        canShowADV = false;
        StartCoroutine(OnShowADV());
    }
    public bool PauseGame()
    {
        return inMenu;
    }
    public void OnPauseGame()
    {
        inMenu = true; ;
    }
    public void OffPauseGame()
    {
        inMenu = false; ;
    }
    public bool ShowAuthorized()
    {
        return isAutorised;
    }

    public void ContinueGame()
    {
        Time.timeScale = 1.0f;
        AudioListener.pause = false;
        PausePanel.gameObject.SetActive(false);
        OnPunch();

        canOpenUI = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    public void OnUI()
    {
        if (canOpenUI)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                DailyPanel.SetActive(true);
                OffPunch();
                inMenu = true;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            //if (Input.GetKeyDown(KeyCode.T))
            //{
            //    ShopeTrails.SetActive(true);
            //    OffPunch();
            //    inMenu = true;
            //    Cursor.lockState = CursorLockMode.None;
            //    Cursor.visible = true;
            //}
            if (Input.GetKeyDown(KeyCode.Y))
            {
                WheelFortune.SetActive(true);
                OffPunch();
                inMenu = true;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            if (Input.GetKeyDown(KeyCode.U))
            {
                TimerShop.SetActive(true);
                OffPunch();
                inMenu = true;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            if (Input.GetKeyDown(KeyCode.G))
            {
                PetShop.SetActive(true);
                OffPunch();
                inMenu = true;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            //if (Input.GetKeyDown(KeyCode.J))
            //{
            //    brCollect.SetActive(true);
            //    OffPunch();
            //    inMenu = true;
            //    Cursor.lockState = CursorLockMode.None;
            //    Cursor.visible = true;
            //}
        }
    }
    public void OffUI()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        OnPunch();
        inMenu = false;
        DailyPanel.SetActive(false);
        ShopeTrails.SetActive(false);
        WheelFortune.SetActive(false);
        TimerShop.SetActive(false);
        PetShop.SetActive(false);
        brCollect.SetActive(false);
    }
    public void OffIcon()
    {
        DailyPanelIcon.SetActive(false);
        ShopeTrailsIcon.SetActive(false);
        WheelFortuneIcon.SetActive(false);
        TimerShopIcon.SetActive(false);
        PetShopIcon.SetActive(false);
        //weaponIcon1.SetActive(false);
        //weaponIcon2.SetActive(false);
        //weaponIcon3.SetActive(false);
        brCollectIcon.SetActive(false);
    }
    public void OnIcon()
    {
        DailyPanelIcon.SetActive(true);
        ShopeTrailsIcon.SetActive(true);
        WheelFortuneIcon.SetActive(true);
        TimerShopIcon.SetActive(true);
        PetShopIcon.SetActive(true);
        //weaponIcon1.SetActive(true);
        //weaponIcon2.SetActive(true);
        //weaponIcon3.SetActive(true);
        brCollectIcon.SetActive(true);
    }
    public void HideKeyCodeUI()
    {
        for (int i = 0; i < KeyCodes.Length; ++i)
        {
            KeyCodes[i].SetActive(false);
        }
    }

    public void OnPunch()
    {
        StartCoroutine(OnPunchWait());
    }
    private IEnumerator OnPunchWait()
    {
        yield return new WaitForSeconds(0.3f);
        if(!punchEnanle)
        {
            punchEnanle = true;
        }
    }
    public void OffPunch()
    {
        StartCoroutine(OffPunchWait());
    }
    private IEnumerator OffPunchWait()
    {
        yield return new WaitForSeconds(0.3f);
        if (punchEnanle)
        {
            punchEnanle = false;
        }
    }
}
