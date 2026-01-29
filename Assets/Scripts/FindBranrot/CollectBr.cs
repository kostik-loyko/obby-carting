using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using YG;

public class CollectBr : MonoBehaviour
{
    [SerializeField] GameObject[] slotsBr;
    [SerializeField] BrainrotScriptableObject[] branrots;
    //[SerializeField] GameObject[] branrotsObj;
    private GameObject iconObj;

    [SerializeField] GameObject swipeUI;
    [SerializeField] GameObject noteSign;
    [SerializeField] Image swipeImgUI;

    public Button[] allButtons;

    private void Awake()
    {
        for (int i = 0; i < branrots.Length; i++)
        {
            branrots[i].index = i;
        }
    }
    private void Start()
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
        LoadCollect();
    }
    public void AddBranrot(Branrot br)
    {
        for (int i = 0; i < slotsBr.Length; i++)
        {
            if (i == br.index)
            {
                iconObj = slotsBr[i].transform.GetChild(0).gameObject;
                iconObj.GetComponent<Image>().sprite = br.Icon;

                SwipeUI(br.Icon);

                YG2.saves.unlockBranrot[i] = true;
                YG2.SaveProgress();
            }
        }
    }
    public void SwipeUI(Sprite brSprite)
    {
        swipeImgUI.sprite = brSprite;
        swipeUI.SetActive(true);
        StartCoroutine(HideSwipeUICoroutine());
    }
    private IEnumerator HideSwipeUICoroutine()
    {
        yield return new WaitForSeconds(1f);
        swipeUI.SetActive(false);
        noteSign.SetActive(true);
    }
    public void LoadCollect()
    {
        for (int i = 0; i < branrots.Length; i++)
        {
            if (YG2.saves.unlockBranrot[i])
            {
                iconObj = slotsBr[i].transform.GetChild(0).gameObject;
                iconObj.GetComponent<Image>().sprite = branrots[i].Icon;
                //if (branrotsObj[i].GetComponent<BrainrotBeahaver>().brData.index == i)
                //{
                //    Destroy(branrotsObj[i]);
                //}
            }
        }
    }
    public void OnButtonClick(Button clickedButton)
    {
        foreach (Button button in allButtons)
        {
            Image targetImage = button.GetComponent<Image>();
            if (button == clickedButton)
            {
                Color currentColor = targetImage.color;
                targetImage.color = new Color(currentColor.r, currentColor.g, currentColor.b, 0);
                button.GetComponent<CategoryBTN>().category.SetActive(true);
            }
            else
            {
                Color currentColor = targetImage.color;
                targetImage.color = new Color(currentColor.r, currentColor.g, currentColor.b, 1);
                button.GetComponent<CategoryBTN>().category.SetActive(false);
            }
        }
    }
}
