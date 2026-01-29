using System.Collections;
using TMPro;
using UnityEngine;
using YG;

public class BuyWorker: MonoBehaviour
{
    [SerializeField] int workerIndex = 0;
    [SerializeField] int workerPrice = 0;
    [SerializeField] TextMeshProUGUI workerPriceText;
    [SerializeField] GameObject workerObject;
    [SerializeField] MeshRenderer workerMeshBTN;
    [SerializeField] GameObject[] workerHideItems;
    [SerializeField] GameObject[] nextUnlockObject;

    bool workerUnlock = false;
    bool openWorker = true;
    bool isFirstGetload = true;

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
        if (workerIndex == 0)
        {
            workerUnlock = YandexGame.savesData.workerUnlock_0;
        } else if (workerIndex == 1)
        {
            workerUnlock = YandexGame.savesData.workerUnlock_1;
        }
        else if (workerIndex == 2)
        {
            workerUnlock = YandexGame.savesData.workerUnlock_2;
        }
        else if (workerIndex == 3)
        {
            workerUnlock = YandexGame.savesData.workerUnlock_3;
        }
        else if (workerIndex == 4)
        {
            workerUnlock = YandexGame.savesData.workerUnlock_4;
        }
        else if (workerIndex == 5)
        {
            workerUnlock = YandexGame.savesData.workerUnlock_5;
        }
        else if (workerIndex == 6)
        {
            workerUnlock = YandexGame.savesData.workerUnlock_6;
        }
        else if (workerIndex == 7)
        {
            workerUnlock = YandexGame.savesData.workerUnlock_7;
        }
        else if (workerIndex == 8)
        {
            workerUnlock = YandexGame.savesData.workerUnlock_8;
        }
        else if (workerIndex == 9)
        {
            workerUnlock = YandexGame.savesData.workerUnlock_9;
        }
        else if (workerIndex == 10)
        {
            workerUnlock = YandexGame.savesData.workerUnlock_10;
        }
        else if (workerIndex == 11)
        {
            workerUnlock = YandexGame.savesData.workerUnlock_11;
        }
        else if (workerIndex == 12)
        {
            workerUnlock = YandexGame.savesData.workerUnlock_12;
        }
        else if (workerIndex == 13)
        {
            workerUnlock = YandexGame.savesData.workerUnlock_13;
        }
        else if (workerIndex == 14)
        {
            workerUnlock = YandexGame.savesData.workerUnlock_14;
        }
        else if (workerIndex == 15)
        {
            workerUnlock = YandexGame.savesData.workerUnlock_15;
        }
        else if (workerIndex == 16)
        {
            workerUnlock = YandexGame.savesData.workerUnlock_16;
        }
        else if (workerIndex == 17)
        {
            workerUnlock = YandexGame.savesData.workerUnlock_17;
        }
        else if (workerIndex == 18)
        {
            workerUnlock = YandexGame.savesData.workerUnlock_18;
        }
        else if (workerIndex == 19)
        {
            workerUnlock = YandexGame.savesData.workerUnlock_19;
        }
        else if (workerIndex == 20)
        {
            workerUnlock = YandexGame.savesData.workerUnlock_20;
        }
        else if (workerIndex == 21)
        {
            workerUnlock = YandexGame.savesData.workerUnlock_21;
        }
        else if (workerIndex == 22)
        {
            workerUnlock = YandexGame.savesData.workerUnlock_22;
        }
        else if (workerIndex == 23)
        {
            workerUnlock = YandexGame.savesData.workerUnlock_23;
        }
        else if (workerIndex == 24)
        {
            workerUnlock = YandexGame.savesData.workerUnlock_24;
        }
        else if (workerIndex == 25)
        {
            workerUnlock = YandexGame.savesData.workerUnlock_25;
        }
        else
        {
            workerUnlock = false;
        }

        if (workerUnlock && isFirstGetload)
        {
            isFirstGetload = false;

            workerObject.SetActive(true);

            workerMeshBTN.enabled = false;
            foreach (GameObject item in workerHideItems)
            {
                item.SetActive(false);
            }
            foreach (GameObject nextHouse in nextUnlockObject)
            {
                nextHouse.SetActive(true);
            }
        }
        else
        {
            workerPriceText.text = ShortScaleString.parseFloat(workerPrice, 1, 1000, true).ToString();
        }
    }
    private void UnlockWorcker()
    {
        if (Score.Instance.score >= workerPrice)
        {
            Score.Instance.DownScore(workerPrice);
            workerObject.SetActive(true);

            workerMeshBTN.enabled = false;
            foreach (GameObject item in workerHideItems)
            {
                item.SetActive(false);
            }
            foreach (GameObject nextHouse in nextUnlockObject)
            {
                nextHouse.SetActive(true);
            }

            workerUnlock = true;

            SaveHouse();

        } else
        {
            SoundManager.Instance.notmoney.Play();
        }
    }

    private void SaveHouse()
    {
        if (workerIndex == 0)
        {
            YandexGame.savesData.workerUnlock_0 = openWorker;
        }
        else if (workerIndex == 1)
        {
            YandexGame.savesData.workerUnlock_1 = openWorker;
        }
        else if (workerIndex == 2)
        {
            YandexGame.savesData.workerUnlock_2 = openWorker;
        }
        else if (workerIndex == 3)
        {
            YandexGame.savesData.workerUnlock_3 = openWorker;
        }
        else if (workerIndex == 4)
        {
            YandexGame.savesData.workerUnlock_4 = openWorker;
        }
        else if (workerIndex == 5)
        {
            YandexGame.savesData.workerUnlock_5 = openWorker;
        }
        else if (workerIndex == 6)
        {
            YandexGame.savesData.workerUnlock_6 = openWorker;
        }
        else if (workerIndex == 7)
        {
            YandexGame.savesData.workerUnlock_7 = openWorker;
        }
        else if (workerIndex == 8)
        {
            YandexGame.savesData.workerUnlock_8 = openWorker;
        }
        else if (workerIndex == 9)
        {
            YandexGame.savesData.workerUnlock_9 = openWorker;
        }
        else if (workerIndex == 10)
        {
            YandexGame.savesData.workerUnlock_10 = openWorker;
        }
        else if (workerIndex == 11)
        {
            YandexGame.savesData.workerUnlock_11 = openWorker;
        }
        else if (workerIndex == 12)
        {
            YandexGame.savesData.workerUnlock_12 = openWorker;
        }
        else if (workerIndex == 13)
        {
            YandexGame.savesData.workerUnlock_13 = openWorker;
        }
        else if (workerIndex == 14)
        {
            YandexGame.savesData.workerUnlock_14 = openWorker;
        }
        else if (workerIndex == 15)
        {
            YandexGame.savesData.workerUnlock_15 = openWorker;
        }
        else if (workerIndex == 16)
        {
            YandexGame.savesData.workerUnlock_16 = openWorker;
        }
        else if (workerIndex == 17)
        {
            YandexGame.savesData.workerUnlock_17 = openWorker;
        }
        else if (workerIndex == 18)
        {
            YandexGame.savesData.workerUnlock_18 = openWorker;
        }
        else if (workerIndex == 19)
        {
            YandexGame.savesData.workerUnlock_19 = openWorker;
        }
        else if (workerIndex == 20)
        {
            YandexGame.savesData.workerUnlock_20 = openWorker;
        }
        else if (workerIndex == 21)
        {
            YandexGame.savesData.workerUnlock_21 = openWorker;
        }
        else if (workerIndex == 22)
        {
            YandexGame.savesData.workerUnlock_22 = openWorker;
        }
        else if (workerIndex == 23)
        {
            YandexGame.savesData.workerUnlock_23 = openWorker;
        }
        else if (workerIndex == 24)
        {
            YandexGame.savesData.workerUnlock_24 = openWorker;
        }
        else if (workerIndex == 25)
        {
            YandexGame.savesData.workerUnlock_25 = openWorker;
        }
        YandexGame.SaveProgress();
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Player") && !workerUnlock)
    //    {
    //        UnlockHouse();
    //    }
    //}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !workerUnlock)
        {
            UnlockWorcker();
        }
    }
}