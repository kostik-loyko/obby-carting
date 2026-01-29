using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YG;

public class PetManager : MonoBehaviour
{
    public static PetManager Instance { get; set; }
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

    public static event UnityAction PetDestroy;

    [SerializeField] GameObject getPaneE;
    [SerializeField] GameObject getPaneMobileE;
    public bool getPetE = false;

    [SerializeField] GameObject swipeUI;
    [SerializeField] Image swipeImgUI;
    [SerializeField] Sprite[] swipeImgs;

    public GameObject[] closePanels;
    [SerializeField] GameObject noteSign;

    private void Start()
    {
        if (YandexGame.SDKEnabled == true)
        {
            GetLoad();
        }
    }

    private void GetLoad()
    {
        for (int i = 0; i < closePanels.Length; i++)
        {
            bool isOpenPet = YandexGame.savesData.closePanels[i];
            if (isOpenPet)
            {
                closePanels[i].SetActive(false);
            }
        }
    }
    private void OnEnable()
    {
        YandexGame.GetDataEvent += GetLoad;
    }

    private void OnDisable()
    {
        YandexGame.GetDataEvent -= GetLoad;
    }
    public void ShowPanel()
    {
        getPetE = true;
        if (!MobileInputManager.Instance.IsMobileDevice())
        {
            getPaneE.SetActive(true);
        }
        else
        {
            getPaneMobileE.SetActive(true);
        }
    }
    public void HidePanel()
    {
        getPetE = false;
        if (!MobileInputManager.Instance.IsMobileDevice())
        {
            getPaneE.SetActive(false);
        }
        else
        {
            getPaneMobileE.SetActive(false);
        }
    }

    public void GetPet()
    {
        if (!MobileInputManager.Instance.IsMobileDevice())
        {
            if (Input.GetKeyDown(KeyCode.E) && getPetE)
            {
                HidePanel();
                PetDestroy?.Invoke();
            }
        }
        else if (SimpleInput.GetButtonDown("Get") && getPetE)
        {
            HidePanel();
            PetDestroy?.Invoke();
        }
    }

    public void SwipeUI(int index)
    {
        swipeImgUI.sprite = swipeImgs[index];
        swipeUI.SetActive(true);
        StartCoroutine(HideSwipeUICoroutine());
    }
    private IEnumerator HideSwipeUICoroutine()
    {
        yield return new WaitForSeconds(1f);
        swipeUI.SetActive(false);
        noteSign.SetActive(true);
    }
}
