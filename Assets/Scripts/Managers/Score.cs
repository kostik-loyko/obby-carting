using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YG;

public class Score : MonoBehaviour
{
    public static Score Instance { get; set; }
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

    public int bestScore = 0;

    public float score = 0;
    public float rate = 100;
    public float rate1 = 200;
    public float rate2 = 300;
    public float rate3 = 400;
    public float rate4 = 500;
    public float rate5 = 600;
    public float rate6 = 700;
    public float rate7 = 800;
    public float rate8 = 900;
    public float rate9 = 1000;
    public float rateItem = 5000;

    public float bigRate = 500f;
    public float finalBigRate;
    public float bonusRate = 0;
    public float finalRate;

    public float upRatePrise = 1000;
    public float coeffRate = 0f;
    private float finalCoeffRate = 0f;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI upRateText;
    public TextMeshProUGUI upRatePriseText;
    public Image scoreImg;
    [SerializeField] private GameObject notMoneySign;

    [SerializeField] private LeaderboardYG leaderboardYG;

    void Start()
    {
        if (YandexGame.SDKEnabled == true)
        {
            GetLoad();
        }

        StartCoroutine(SaveData());
    }

    private void OnEnable() => YandexGame.GetDataEvent += GetLoad;

    private void OnDisable() => YandexGame.GetDataEvent -= GetLoad;

    private void GetLoad()
    {

        score = YandexGame.savesData.score;

        bestScore = YandexGame.savesData.bestScore;
        scoreText.text = ShortScaleString.parseFloat(score, 1, 1000, true).ToString();

        coeffRate = YandexGame.savesData.coeffRate;

        upRatePrise = YandexGame.savesData.upRatePrise;
        //upRateText.text = coeffRate.ToString();
        //upRatePriseText.text = ShortScaleString.parseFloat(upRatePrise, 1, 1000, true).ToString();

        bonusRate = YandexGame.savesData.bonusRate;
        BonusCoeffRate();

        StartLiderBoard();
    }

    public void ResetProgress()
    {
        YandexGame.ResetSaveProgress();
        YandexGame.SaveProgress();
    }

    public void UpScore()
    {
        GetRateFinal();
        score += finalRate;
        //UpBestScore();

        YandexGame.savesData.score = score;

        scoreText.text = ShortScaleString.parseFloat(score, 1, 1000, true).ToString();
        scoreImg.transform.localScale = new Vector2(1.1f, 1.1f);
        scoreText.fontSize = 80;
        StartCoroutine(BackScaleObjects());
    }
    public void UpScore1()
    {
        GetRateFinal1();
        score += finalRate;
        //UpBestScore();

        YandexGame.savesData.score = score;

        scoreText.text = ShortScaleString.parseFloat(score, 1, 1000, true).ToString();
        scoreImg.transform.localScale = new Vector2(1.1f, 1.1f);
        scoreText.fontSize = 80;
        StartCoroutine(BackScaleObjects());
    }
    public void UpScore2()
    {
        GetRateFinal2();
        score += finalRate;
        //UpBestScore();

        YandexGame.savesData.score = score;

        scoreText.text = ShortScaleString.parseFloat(score, 1, 1000, true).ToString();
        scoreImg.transform.localScale = new Vector2(1.1f, 1.1f);
        scoreText.fontSize = 80;
        StartCoroutine(BackScaleObjects());
    }
    public void UpScore3()
    {
        GetRateFinal3();
        score += finalRate;
        //UpBestScore();

        YandexGame.savesData.score = score;

        scoreText.text = ShortScaleString.parseFloat(score, 1, 1000, true).ToString();
        scoreImg.transform.localScale = new Vector2(1.1f, 1.1f);
        scoreText.fontSize = 80;
        StartCoroutine(BackScaleObjects());
    }
    public void UpScore4()
    {
        GetRateFinal4();
        score += finalRate;
        //UpBestScore();

        YandexGame.savesData.score = score;

        scoreText.text = ShortScaleString.parseFloat(score, 1, 1000, true).ToString();
        scoreImg.transform.localScale = new Vector2(1.1f, 1.1f);
        scoreText.fontSize = 80;
        StartCoroutine(BackScaleObjects());
    }
    public void UpScore5()
    {
        GetRateFinal5();
        score += finalRate;
        //UpBestScore();

        YandexGame.savesData.score = score;

        scoreText.text = ShortScaleString.parseFloat(score, 1, 1000, true).ToString();
        scoreImg.transform.localScale = new Vector2(1.1f, 1.1f);
        scoreText.fontSize = 80;
        StartCoroutine(BackScaleObjects());
    }
    public void UpScore6()
    {
        GetRateFinal6();
        score += finalRate;
        //UpBestScore();

        YandexGame.savesData.score = score;

        scoreText.text = ShortScaleString.parseFloat(score, 1, 1000, true).ToString();
        scoreImg.transform.localScale = new Vector2(1.1f, 1.1f);
        scoreText.fontSize = 80;
        StartCoroutine(BackScaleObjects());
    }
    public void UpScore7()
    {
        GetRateFinal7();
        score += finalRate;
        //UpBestScore();

        YandexGame.savesData.score = score;

        scoreText.text = ShortScaleString.parseFloat(score, 1, 1000, true).ToString();
        scoreImg.transform.localScale = new Vector2(1.1f, 1.1f);
        scoreText.fontSize = 80;
        StartCoroutine(BackScaleObjects());
    }
    public void UpScore8()
    {
        GetRateFinal8();
        score += finalRate;
        //UpBestScore();

        YandexGame.savesData.score = score;

        scoreText.text = ShortScaleString.parseFloat(score, 1, 1000, true).ToString();
        scoreImg.transform.localScale = new Vector2(1.1f, 1.1f);
        scoreText.fontSize = 80;
        StartCoroutine(BackScaleObjects());
    }
    public void UpScore9()
    {
        //GetRateFinal9();
        score += 1000;
        //UpBestScore();

        YandexGame.savesData.score = score;

        scoreText.text = ShortScaleString.parseFloat(score, 1, 1000, true).ToString();
        scoreImg.transform.localScale = new Vector2(1.1f, 1.1f);
        scoreText.fontSize = 80;
        StartCoroutine(BackScaleObjects());
    }

    public void UpScoreItem()
    {
        GetRateFinalItem();
        score += finalRate;
        //UpBestScore();

        YandexGame.savesData.score = score;

        scoreText.text = ShortScaleString.parseFloat(score, 1, 1000, true).ToString();
        scoreImg.transform.localScale = new Vector2(1.1f, 1.1f);
        scoreText.fontSize = 80;
        StartCoroutine(BackScaleObjects());
    }

    public void UpScoreBig()
    {
        GetBigRateFinal();
        score += finalBigRate;

        YandexGame.savesData.score = score;

        scoreText.text = ShortScaleString.parseFloat(score, 1, 1000, true).ToString();
        scoreImg.transform.localScale = new Vector2(1.1f, 1.1f);
        scoreText.fontSize = 80;
        StartCoroutine(BackScaleObjects());
        SoundManager.Instance.getMoney.Play();
    }

    public float UpScore(float money)
    {
        float bonus = money * finalCoeffRate;
        money += bonus;
        score += money;
        //UpBestScore();

        YandexGame.savesData.score = score;

        scoreText.text = ShortScaleString.parseFloat(score, 1, 1000, true).ToString();
        scoreImg.transform.localScale = new Vector2(1.1f, 1.1f);
        scoreText.fontSize = 80;
        StartCoroutine(BackScaleObjects());
        return money;
    }

    public void UpScorePresent(float money)
    {
        score += money;
        YandexGame.savesData.score = score;
        //UpBestScore();

        scoreText.text = ShortScaleString.parseFloat(score, 1, 1000, true).ToString();
        scoreImg.transform.localScale = new Vector2(1.1f, 1.1f);
        scoreText.fontSize = 80;
        StartCoroutine(BackScaleObjects());
        SoundManager.Instance.getMoney.Play();
    }

    public void UpBestScore()
    {
        bestScore += 2;
        if (bestScore >= YandexGame.savesData.bestScore)
        {
            YandexGame.savesData.bestScore = bestScore;
        }
    }
    public void UpScoreForWall(float upScore)
    {
        score += upScore;
        UpBestScore();

        YandexGame.savesData.score = score;

        scoreText.text = ShortScaleString.parseFloat(score, 1, 1000, true).ToString();
        scoreImg.transform.localScale = new Vector2(1.1f, 1.1f);
        scoreText.fontSize = 80;
        StartCoroutine(BackScaleObjects());
    }
    public bool DownScore(float prise)
    {   
        if(score < prise)
        {
            SoundManager.Instance.notmoney.Play();
            StartCoroutine(NotMoneyCorut());
            return false;
        }
        score -= prise;
        YandexGame.savesData.score = score;
        scoreText.text = ShortScaleString.parseFloat(score, 1, 1000, true).ToString();
        scoreImg.transform.localScale = new Vector2(1.1f, 1.1f);
        scoreText.fontSize = 80;
        StartCoroutine(BackScaleObjects());
        SoundManager.Instance.buy.Play();
        PlayerBehavior.Instance.MissMoney(prise);
        return true;
    }
    public void DownScoreDamage(float prise)
    {
        score -= prise;
        YandexGame.savesData.score = score;

        scoreText.text = ShortScaleString.parseFloat(score, 1, 1000, true).ToString();
        scoreImg.transform.localScale = new Vector2(1.1f, 1.1f);
        scoreText.fontSize = 80;
        StartCoroutine(BackScaleObjects());
        SoundManager.Instance.damage.Play();
    }
    public void UpCoeffRate()
    {
        if (score >= upRatePrise)
        {
            DownScore(upRatePrise);
            coeffRate += 0.1f;

            YandexGame.savesData.coeffRate = coeffRate;

            BonusCoeffRate();
            upRatePrise *= coeffRate;

            YandexGame.savesData.upRatePrise = upRatePrise;

            scoreText.text = ShortScaleString.parseFloat(score, 1, 1000, true).ToString();
            upRateText.text = coeffRate.ToString();
            upRatePriseText.text = ShortScaleString.parseFloat(upRatePrise, 1, 1000, true).ToString();
            scoreImg.transform.localScale = new Vector2(1.1f, 1.1f);
            scoreText.fontSize = 80;
            StartCoroutine(BackScaleObjects());
        } else
        {
            SoundManager.Instance.notmoney.Play();
        }
    }

    public void GetBonusRate(int indexCurrPet)
    {
        bonusRate = indexCurrPet * 0.2f;

        YandexGame.savesData.bonusRate = bonusRate;

        BonusCoeffRate();
    }
    public void BonusCoeffRate()
    {
        finalCoeffRate = coeffRate + bonusRate;
    }
    public void GetRateFinal()
    {
        finalRate = rate * finalCoeffRate;
    }
    public void GetRateFinal1()
    {
        finalRate = rate1 * finalCoeffRate;
    }
    public void GetRateFinal2()
    {
        finalRate = rate2 * finalCoeffRate;
    }
    public void GetRateFinal3()
    {
        finalRate = rate3 * finalCoeffRate;
    }
    public void GetRateFinal4()
    {
        finalRate = rate4 * finalCoeffRate;
    }
    public void GetRateFinal5()
    {
        finalRate = rate5 * finalCoeffRate;
    }
    public void GetRateFinal6()
    {
        finalRate = rate6 * finalCoeffRate;
    }
    public void GetRateFinal7()
    {
        finalRate = rate7 * finalCoeffRate;
    }
    public void GetRateFinal8()
    {
        finalRate = rate8 * finalCoeffRate;
    }
    public void GetRateFinal9()
    {
        finalRate = rate9 * finalCoeffRate;
    }
    public void GetRateFinalItem()
    {
        finalRate = rateItem * finalCoeffRate;
        finalRate = rateItem * finalCoeffRate;
    }

    public float GetRateFinalForWall(int wallHP)
    {
        return (rate * finalCoeffRate) + (wallHP * 100f);
    }

    public void GetBigRateFinal()
    {
        finalBigRate = bigRate * finalCoeffRate;
    }

    private IEnumerator BackScaleObjects()
    {
        yield return new WaitForSeconds(0.1f);
        scoreImg.transform.localScale = new Vector2(1f, 1f);
        scoreText.fontSize = 70;
    }

    public void StartLiderBoard()
    {
        StartCoroutine(WaitSaveLiderBoard());
    }

    private IEnumerator WaitSaveLiderBoard()
    {
        //YandexGame.NewLeaderboardScores("theBestScore", bestScore);
        YG2.SetLeaderboard("theBestScore", bestScore);
        leaderboardYG.UpdateLB();

        yield return new WaitForSeconds(23f);

        StartLiderBoard();
    }

    private IEnumerator SaveData()
    {
        yield return new WaitForSeconds(10f);
        YandexGame.SaveProgress();

        StartCoroutine(SaveData());
    }
    private IEnumerator NotMoneyCorut()
    {
        notMoneySign.SetActive(true);
        yield return new WaitForSeconds(2f);
        notMoneySign.SetActive(false);
    }
    public void UpScoreNewPet(int multiplyBonus)
    {
        score += multiplyBonus;
        YandexGame.savesData.score = score;

        scoreText.text = ShortScaleString.parseFloat(score, 1, 1000, true).ToString();
    }
}
