using System.Collections;
using TMPro;
using UnityEngine;
using YG;

public class BuyMine : MonoBehaviour
{
    [SerializeField] int mineIndex = 0;
    [SerializeField] int minePrice = 0;
    [SerializeField] int upMinePrice = 0;
    [SerializeField] TextMeshProUGUI minePriceText;
    [SerializeField] TextMeshProUGUI upMinePriceText;
    [SerializeField] GameObject mineStankiContainer;
    [SerializeField] GameObject[] mineStanki;
    [SerializeField] MeshRenderer mineMeshBTN;
    [SerializeField] GameObject upMineBTN;
    [SerializeField] GameObject[] mineItems;
    [SerializeField] GameObject[] nextMiners;

    bool mineUnlock = false;
    bool openMine = true;
    bool isFirstGetload = true;

    [SerializeField] Transform spawnPoint;
    [SerializeField] GameObject[] moneyPrefs;

    int upMineIndex = 0;

    float spawnRadius = 0.3f;

    void Start()
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
        if (mineIndex == 0)
        {
            mineUnlock = YandexGame.savesData.mineUnlock_0;
            upMineIndex = YandexGame.savesData.upMineIndex0;
        } else if (mineIndex == 1)
        {
            mineUnlock = YandexGame.savesData.mineUnlock_1;
            upMineIndex = YandexGame.savesData.upMineIndex1;
        }
        else if (mineIndex == 2)
        {
            mineUnlock = YandexGame.savesData.mineUnlock_2;
            upMineIndex = YandexGame.savesData.upMineIndex2;
        }
        else if (mineIndex == 3)
        {
            mineUnlock = YandexGame.savesData.mineUnlock_3;
            upMineIndex = YandexGame.savesData.upMineIndex3;
        }
        else if (mineIndex == 4)
        {
            mineUnlock = YandexGame.savesData.mineUnlock_4;
            upMineIndex = YandexGame.savesData.upMineIndex4;
        }
        else if (mineIndex == 5)
        {
            mineUnlock = YandexGame.savesData.mineUnlock_5;
            upMineIndex = YandexGame.savesData.upMineIndex5;
        }
        else if (mineIndex == 6)
        {
            mineUnlock = YandexGame.savesData.mineUnlock_6;
            upMineIndex = YandexGame.savesData.upMineIndex6;
        }
        else if (mineIndex == 7)
        {
            mineUnlock = YandexGame.savesData.mineUnlock_7;
            upMineIndex = YandexGame.savesData.upMineIndex7;
        }
        else if (mineIndex == 8)
        {
            mineUnlock = YandexGame.savesData.mineUnlock_8;
            upMineIndex = YandexGame.savesData.upMineIndex8;
        }
        else if (mineIndex == 9)
        {
            mineUnlock = YandexGame.savesData.mineUnlock_9;
            upMineIndex = YandexGame.savesData.upMineIndex9;
        }
        else if (mineIndex == 10)
        {
            mineUnlock = YandexGame.savesData.mineUnlock_10;
            upMineIndex = YandexGame.savesData.upMineIndex10;
        }
        else if (mineIndex == 11)
        {
            mineUnlock = YandexGame.savesData.mineUnlock_11;
            upMineIndex = YandexGame.savesData.upMineIndex11;
        }
        else if (mineIndex == 12)
        {
            mineUnlock = YandexGame.savesData.mineUnlock_12;
            upMineIndex = YandexGame.savesData.upMineIndex12;
        }
        else if (mineIndex == 13)
        {
            mineUnlock = YandexGame.savesData.mineUnlock_13;
            upMineIndex = YandexGame.savesData.upMineIndex13;
        }
        else
        {
            mineUnlock = false;
        }

        upMinePrice = minePrice * ((upMineIndex + 1) * 2);
        upMinePriceText.text = ShortScaleString.parseFloat(upMinePrice, 1, 1000, true).ToString();

        if (mineUnlock && isFirstGetload)
        {
            isFirstGetload = false;

            mineStankiContainer.SetActive(true);
            upMineBTN.SetActive(true);

            for (int i = 0; i < mineStanki.Length; i++)
            {
                mineStanki[i].SetActive(false);
            }

            for (int i = 0; i < mineStanki.Length; i++)
            {
                if (upMineIndex == i)
                {
                    mineStanki[i].SetActive(true);
                }
                // здесь изменить цифру на последний stanok чтобы убрать кнопку апгрейда майнера
                if (upMineIndex == 9)
                {
                    upMineBTN.SetActive(false);
                }
            }

            mineMeshBTN.enabled = false;
            foreach (GameObject item in mineItems)
            {
                item.SetActive(false);
            }
            foreach (GameObject nextMiner in nextMiners)
            {
                nextMiner.SetActive(true);
            }

            SpawnMoney();
        }
        else
        {
            minePriceText.text = ShortScaleString.parseFloat(minePrice, 1, 1000, true).ToString();
        }
    }
    private void UnlockMine()
    {
        if (Score.Instance.score >= minePrice)
        {
            Score.Instance.DownScore(minePrice);
            mineStankiContainer.SetActive(true);
            upMineBTN.SetActive(true);

            upMinePrice = minePrice * ((upMineIndex + 1) * 2);
            upMinePriceText.text = ShortScaleString.parseFloat(upMinePrice, 1, 1000, true).ToString();

            mineMeshBTN.enabled = false;
            foreach (GameObject item in mineItems)
            {
                item.SetActive(false);
            }
            foreach (GameObject nextMiner in nextMiners)
            {
                nextMiner.SetActive(true);
            }

            mineUnlock = true;

            SaveMine();

            SpawnMoney();
        } else
        {
            SoundManager.Instance.notmoney.Play();
        }
    }

    private void SaveMine()
    {
        if (mineIndex == 0)
        {
            YandexGame.savesData.mineUnlock_0 = openMine;
            YandexGame.savesData.upMineIndex0 = upMineIndex;
        }
        else if (mineIndex == 1)
        {
            YandexGame.savesData.mineUnlock_1 = openMine;
            YandexGame.savesData.upMineIndex1 = upMineIndex;
        }
        else if (mineIndex == 2)
        {
            YandexGame.savesData.mineUnlock_2 = openMine;
            YandexGame.savesData.upMineIndex2 = upMineIndex;
        }
        else if (mineIndex == 3)
        {
            YandexGame.savesData.mineUnlock_3 = openMine;
            YandexGame.savesData.upMineIndex3 = upMineIndex;
        }
        else if (mineIndex == 4)
        {
            YandexGame.savesData.mineUnlock_4 = openMine;
            YandexGame.savesData.upMineIndex4 = upMineIndex;
        }
        else if (mineIndex == 5)
        {
            YandexGame.savesData.mineUnlock_5 = openMine;
            YandexGame.savesData.upMineIndex5 = upMineIndex;
        }
        else if (mineIndex == 6)
        {
            YandexGame.savesData.mineUnlock_6 = openMine;
            YandexGame.savesData.upMineIndex6 = upMineIndex;
        }
        else if (mineIndex == 7)
        {
            YandexGame.savesData.mineUnlock_7 = openMine;
            YandexGame.savesData.upMineIndex7 = upMineIndex;
        }
        else if (mineIndex == 8)
        {
            YandexGame.savesData.mineUnlock_8 = openMine;
            YandexGame.savesData.upMineIndex8 = upMineIndex;
        }
        else if (mineIndex == 9)
        {
            YandexGame.savesData.mineUnlock_9 = openMine;
            YandexGame.savesData.upMineIndex9 = upMineIndex;
        }
        else if (mineIndex == 10)
        {
            YandexGame.savesData.mineUnlock_10 = openMine;
            YandexGame.savesData.upMineIndex10 = upMineIndex;
        }
        else if (mineIndex == 11)
        {
            YandexGame.savesData.mineUnlock_11 = openMine;
            YandexGame.savesData.upMineIndex11 = upMineIndex;
        }
        else if (mineIndex == 12)
        {
            YandexGame.savesData.mineUnlock_12 = openMine;
            YandexGame.savesData.upMineIndex12 = upMineIndex;
        }
        else if (mineIndex == 13)
        {
            YandexGame.savesData.mineUnlock_13 = openMine;
            YandexGame.savesData.upMineIndex13 = upMineIndex;
        }
        YandexGame.SaveProgress();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !mineUnlock)
        {
            UnlockMine();
        }
    }
    public void UpMiner()
    {
        if (Score.Instance.score >= upMinePrice)
        {
            Score.Instance.DownScore(upMinePrice);

            upMineIndex++;

            SaveMine();

            upMinePrice = minePrice * ((upMineIndex + 1) * 2);
            upMinePriceText.text = ShortScaleString.parseFloat(upMinePrice, 1, 1000, true).ToString();

            for (int i = 0; i < mineStanki.Length; i++)
            {
                mineStanki[i].SetActive(false);
            }

            for (int i = 0; i < mineStanki.Length; i++)
            {
                if (upMineIndex == i)
                {
                    mineStanki[i].SetActive(true);
                }
                // здесь изменить цифру на последний stanok чтобы убрать кнопку апгрейда майнера
                if (upMineIndex == 9)
                {
                    upMineBTN.SetActive(false);
                }
            }
        } else
        {
            SoundManager.Instance.notmoney.Play();
        }
    }

    private void SpawnMoney()
    {
        StartCoroutine(WaitSpawnMoney());
    }
    private IEnumerator WaitSpawnMoney()
    {
        Vector3 position = new Vector3(Random.Range(0, 180), Random.Range(0, 180), Random.Range(0, 180));

        for (int i = 0; i < mineStanki.Length; i++)
        {
            if (upMineIndex == i)
            {
                GameObject money = Instantiate(moneyPrefs[i], spawnPoint.position + Random.insideUnitSphere * spawnRadius,
                    Quaternion.Euler(position));
                Rigidbody moneyRb = money.GetComponent<Rigidbody>();
                moneyRb.AddForce(spawnPoint.forward * 5, ForceMode.Impulse);
            }
        }
        yield return new WaitForSeconds(6f);
        StartCoroutine(WaitSpawnMoney());
    }
}
