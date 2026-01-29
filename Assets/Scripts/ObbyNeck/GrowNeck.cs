using System.Collections;
using TMPro;
using UnityEngine;
using YG;

public class GrowNeck : MonoBehaviour
{
    [SerializeField] Transform neck;
    int neckHightSec;
    float neckHightLocal;
    [SerializeField] HighScale highScale;
    [SerializeField] SpawnerFruit spawnerFruit;
    [SerializeField] SpawnerBr spawnerBr;

    float speedGrowNeckDefault = 0.1f;
    float speedGrowNeck = 0.1f;
    int neckSecondRateUIDefault = 1;
    int neckSecondRateUI = 1;
    int neckHeightUI = 0;
    [SerializeField] TextMeshProUGUI neckHeightUItext;

    void Start()
    {
        if (YandexGame.SDKEnabled == true)
        {
            GetLoad();
        }
        StartCoroutine(UpNeckSecond());
    }
    private void OnEnable() => YandexGame.GetDataEvent += GetLoad;

    private void OnDisable() => YandexGame.GetDataEvent -= GetLoad;

    private void GetLoad()
    {
        speedGrowNeck = YandexGame.savesData.speedGrowNeck;

        neckHightLocal = YandexGame.savesData.neckHightLocal;
        neck.localPosition += new Vector3(0, neckHightLocal, 0);

        neckHightSec = Mathf.RoundToInt(neck.position.y);
        highScale.SetHeightScale(neckHightSec);
        spawnerFruit.SetHeightTreeSpawner(neckHightSec);

        neckHeightUI = YandexGame.savesData.neckHeightUI;
        neckHeightUItext.text = ShortScaleString.parseFloat(neckHeightUI, 1, 1000, true).ToString();

        neckSecondRateUI = YandexGame.savesData.neckSecondRateUI;
    }
    private IEnumerator UpNeckSecond()
    {
        yield return new WaitForSeconds(1f);
        neck.position += new Vector3(0, speedGrowNeck, 0);

        neckHightLocal = Mathf.RoundToInt(neck.localPosition.y);
        YandexGame.savesData.neckHightLocal = neckHightLocal;

        UPneckHeightSecondUI();

        if (neckHightSec != Mathf.RoundToInt(neck.position.y)
            && Mathf.RoundToInt(neck.position.y) % 2 == 0
            || Mathf.RoundToInt(neck.position.y) - neckHightSec >= 3)
        {
            highScale.UpHighScale();

            spawnerFruit.SetHeightTreeSpawner(neckHightSec);
            spawnerFruit.SpawnTree();
            spawnerBr.SpawnBr();

            neckHightSec = Mathf.RoundToInt(neck.position.y);

            Score.Instance.UpBestScore();
        }
        StartCoroutine(UpNeckSecond());
    }
    public void UpNeck(int indexFruit)
    {

        //neck.position += new Vector3(0, speedGrowNeck + (indexFruit * 0.1f), 0);
        neck.position += new Vector3(0, speedGrowNeck + 0.5f, 0);
        YandexGame.savesData.neckHightLocal = Mathf.RoundToInt(neck.localPosition.y);

        UPneckHeightFruitUI(indexFruit);

        if (neckHightSec != Mathf.RoundToInt(neck.position.y)
            && Mathf.RoundToInt(neck.position.y) % 2 == 0
            || Mathf.RoundToInt(neck.position.y) - neckHightSec >= 3)
        {
            highScale.UpHighScale();

            spawnerFruit.SetHeightTreeSpawner(neckHightSec);
            spawnerFruit.SpawnTree();
            spawnerBr.SpawnBr();

            neckHightSec = Mathf.RoundToInt(neck.position.y);

            Score.Instance.UpBestScore();
        }
    }
    public void ResetHeight()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            SellNeckHeight();

            spawnerFruit.SpawnTreesStart();

            neck.transform.localPosition = new Vector3(0, 0.5f, 0);
            YandexGame.savesData.neckHightLocal = Mathf.RoundToInt(neck.localPosition.y);

            neckHightSec = Mathf.RoundToInt(neck.position.y);
            highScale.ResetHeightScale(neckHightSec);

            EventManager.OnTreeRemove();
            YandexGame.SaveProgress();
        }
    }
    public void ResetHeightMobile()
    {
        SellNeckHeight();

        neck.transform.localPosition = new Vector3(0, 0.5f, 0);
        YandexGame.savesData.neckHightLocal = Mathf.RoundToInt(neck.localPosition.y);

        neckHightSec = Mathf.RoundToInt(neck.position.y);
        highScale.ResetHeightScale(neckHightSec);

        EventManager.OnTreeRemove();
        YandexGame.SaveProgress();
    }
    public int GetHeightNeckSecond()
    {
        return neckSecondRateUI;
    }
    public float GetNeckLocalPosition()
    {
        return neckHightLocal;
    }
    public float GetNeckPosY()
    {
        return neck.position.y;
    }
    private void UPneckHeightSecondUI()
    {
        neckHeightUI += neckSecondRateUI;
        neckHeightUItext.text = ShortScaleString.parseFloat(neckHeightUI, 1, 1000, true).ToString();
        YandexGame.savesData.neckHeightUI = neckHeightUI;
    }
    private void UPneckHeightFruitUI(int index)
    {
        neckHeightUI += index * 10;
        neckHeightUItext.text = ShortScaleString.parseFloat(neckHeightUI, 1, 1000, true).ToString();
        YandexGame.savesData.neckHeightUI = neckHeightUI;
    }
    private void SellNeckHeight()
    {
        Score.Instance.UpScorePresent(neckHeightUI);
        neckHeightUI = 0;
        neckHeightUItext.text = ShortScaleString.parseFloat(neckHeightUI, 1, 1000, true).ToString();
        YandexGame.savesData.neckHeightUI = neckHeightUI;
    }
    public void UpRateSecondGrowNeck(int indexPet)
    {
        if (indexPet == 0)
        {
            speedGrowNeck = speedGrowNeckDefault + 0.1f;
            YandexGame.savesData.speedGrowNeck = speedGrowNeck;
            print(speedGrowNeck);
        }
        else
        {
            speedGrowNeck = speedGrowNeckDefault + (indexPet * 0.2f);
            YandexGame.savesData.speedGrowNeck = speedGrowNeck;
            print(speedGrowNeck);
        }
        UPSecondRateUI(indexPet);
    }
    private void UPSecondRateUI(int index)
    {
        neckSecondRateUI = neckSecondRateUIDefault + 1 + index;
        YandexGame.savesData.neckSecondRateUI = neckSecondRateUI;
    }
}
