using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using YG;

public class PeapleQuests : MonoBehaviour
{
    [SerializeField] int index;

    [SerializeField] GameObject textStart;
    [SerializeField] GameObject textEnd;
    [SerializeField] GameObject textOther;
    public GameObject[] textsOther;

    [SerializeField] GameObject arrow;
    public GameObject itemNPS;

    private bool startQuest = true;

    private bool isFirstTrigger = true;

    private void Start()
    {
        if (ManagerQests.Instance.completeQuest[index])
        {
            CloseNoteNPS();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (isFirstTrigger)
            {
                isFirstTrigger = false;

                if (ManagerQests.Instance.completeQuest[index])
                {
                    ShowOtherText();
                    ShowItemNPS();
                    if (index == 0)
                    {
                        SoundManager.Instance.PlayHello(SoundManager.Instance.midle);
                    }
                    if (index == 1)
                    {
                        SoundManager.Instance.PlayHello(SoundManager.Instance.cry);
                    }
                    if (index == 2)
                    {
                        SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                    }
                    if (index == 3)
                    {
                        SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                    }
                    if (index == 4)
                    {
                        SoundManager.Instance.PlayHello(SoundManager.Instance.cry);
                    }
                    if (index == 5)
                    {
                        SoundManager.Instance.PlayHello(SoundManager.Instance.cry);
                    }
                    if (index == 6)
                    {
                        SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                    }
                    if (index == 7)
                    {
                        SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                    }
                    if (index == 8)
                    {
                        SoundManager.Instance.PlayHello(SoundManager.Instance.fart);
                    }
                    if (index == 9)
                    {
                        SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                    }
                    if (index == 10)
                    {
                        SoundManager.Instance.PlayHello(SoundManager.Instance.cry);
                    }
                    if (index == 11)
                    {
                        SoundManager.Instance.PlayHello(SoundManager.Instance.ask);
                    }
                    if (index == 12)
                    {
                        SoundManager.Instance.PlayHello(SoundManager.Instance.ask);
                    }
                    if (index == 13)
                    {
                        SoundManager.Instance.PlayHello(SoundManager.Instance.midle);
                    }
                    if (index == 14)
                    {
                        SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                    }
                    if (index == 15)
                    {
                        SoundManager.Instance.PlayHello(SoundManager.Instance.woof);
                    }
                    if (index == 16)
                    {
                        SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                    }
                    if (index == 17)
                    {
                        SoundManager.Instance.PlayHello(SoundManager.Instance.ask);
                    }
                    if (index == 18)
                    {
                        SoundManager.Instance.PlayHello(SoundManager.Instance.cry);
                    }
                    if (index == 19)
                    {
                        SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                    }
                    if (index == 20)
                    {
                        SoundManager.Instance.PlayHello(SoundManager.Instance.cry);
                    }
                    if (index == 21)
                    {
                        SoundManager.Instance.PlayHello(SoundManager.Instance.cry);
                    }
                    if (index == 22)
                    {
                        SoundManager.Instance.PlayHello(SoundManager.Instance.cute);
                    }
                    if (index == 23)
                    {
                        SoundManager.Instance.PlayHello(SoundManager.Instance.fart);
                    }
                    if (index == 24)
                    {
                        SoundManager.Instance.PlayHello(SoundManager.Instance.cry);
                    }
                    if (index == 25)
                    {
                        SoundManager.Instance.PlayHello(SoundManager.Instance.fart);
                    }
                    if (index == 26)
                    {
                        SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                    }
                    if (index == 27)
                    {
                        SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                    }
                    if (index == 28)
                    {
                        SoundManager.Instance.PlayHello(SoundManager.Instance.cry);
                    }
                    if (index == 29)
                    {
                        SoundManager.Instance.PlayHello(SoundManager.Instance.ask);
                    }
                    if (index == 30)
                    {
                        SoundManager.Instance.PlayHello(SoundManager.Instance.midle);
                    }
                    if (index == 31)
                    {
                        SoundManager.Instance.PlayHello(SoundManager.Instance.cry);
                    }
                    if (index == 32)
                    {
                        SoundManager.Instance.PlayHello(SoundManager.Instance.cry);
                    }
                    if (index == 33)
                    {
                        SoundManager.Instance.PlayHello(SoundManager.Instance.duck);
                    }
                    if (index == 34)
                    {
                        SoundManager.Instance.PlayHello(SoundManager.Instance.ask);
                    }
                    if (index == 35)
                    {
                        SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                    }
                    if (index == 36)
                    {
                        SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                    }
                    if (index == 37)
                    {
                        SoundManager.Instance.PlayHello(SoundManager.Instance.cute);
                    }
                }
                else
                {
                    if (index == 0)
                    {
                        GetQuest();
                        CompleteQuest();
                        EndQuest();
                        SoundManager.Instance.PlayHello(SoundManager.Instance.midle);
                    }
                    if (index == 1)
                    {
                        GetQuest();
                        CompleteQuest();
                        EndQuest();
                        SoundManager.Instance.PlayHello(SoundManager.Instance.ask);
                    }
                    if (index == 2)
                    {
                        GetQuest();
                        CompleteQuest();
                        EndQuest();
                        SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                    }
                    if (index == 3)
                    {
                        GetQuest();
                        CompleteQuest();
                        EndQuest();
                        SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                    }
                    if (index == 4)
                    {
                        GetQuest();
                        CompleteQuest();
                        EndQuest();
                        SoundManager.Instance.PlayHello(SoundManager.Instance.cry);
                    }
                    if (index == 5)
                    {
                        GetQuest();
                        CompleteQuest();
                        EndQuest();
                        SoundManager.Instance.PlayHello(SoundManager.Instance.cry);
                    }
                    if (index == 6)
                    {
                        GetQuest();
                        CompleteQuest();
                        EndQuest();
                        SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                    }
                    if (index == 7)
                    {
                        GetQuest();
                        CompleteQuest();
                        EndQuest();
                        SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                    }
                    if (index == 8)
                    {
                        GetQuest();
                        CompleteQuest();
                        EndQuest();
                        SoundManager.Instance.PlayHello(SoundManager.Instance.fart);
                    }
                    if (index == 9)
                    {
                        GetQuest();
                        CompleteQuest();
                        EndQuest();
                        SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                    }
                    if (index == 10)
                    {
                        GetQuest();
                        CompleteQuest();
                        EndQuest();
                        SoundManager.Instance.PlayHello(SoundManager.Instance.cry);
                    }
                    if (index == 11)
                    {
                        GetQuest();
                        CompleteQuest();
                        EndQuest();
                        SoundManager.Instance.PlayHello(SoundManager.Instance.ask);
                    }
                    if (index == 12)
                    {
                        GetQuest();
                        CompleteQuest();
                        EndQuest();
                        SoundManager.Instance.PlayHello(SoundManager.Instance.ask);
                    }
                    if (index == 13)
                    {
                        GetQuest();
                        CompleteQuest();
                        EndQuest();
                        SoundManager.Instance.PlayHello(SoundManager.Instance.midle);
                    }
                    if (index == 14)
                    {
                        GetQuest();
                        CompleteQuest();
                        EndQuest();
                        SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                    }
                    if (index == 15)
                    {
                        GetQuest();
                        CompleteQuest();
                        EndQuest();
                        SoundManager.Instance.PlayHello(SoundManager.Instance.woof);
                    }
                    if (index == 16)
                    {
                        GetQuest();
                        CompleteQuest();
                        EndQuest();
                        SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                    }
                    if (index == 17)
                    {
                        GetQuest();
                        CompleteQuest();
                        EndQuest();
                        SoundManager.Instance.PlayHello(SoundManager.Instance.ask);
                    }
                    if (index == 18)
                    {
                        GetQuest();
                        CompleteQuest();
                        EndQuest();
                        SoundManager.Instance.PlayHello(SoundManager.Instance.cry);
                    }
                    if (index == 19)
                    {
                        GetQuest();
                        CompleteQuest();
                        EndQuest();
                        SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                    }
                    if (index == 20)
                    {
                        GetQuest();
                        CompleteQuest();
                        EndQuest();
                        SoundManager.Instance.PlayHello(SoundManager.Instance.cry);
                    }
                    if (index == 21)
                    {
                        GetQuest();
                        CompleteQuest();
                        EndQuest();
                        SoundManager.Instance.PlayHello(SoundManager.Instance.cry);
                    }
                    if (index == 22)
                    {
                        GetQuest();
                        CompleteQuest();
                        EndQuest();
                        SoundManager.Instance.PlayHello(SoundManager.Instance.cute);
                    }
                    if (index == 23)
                    {
                        GetQuest();
                        CompleteQuest();
                        EndQuest();
                        SoundManager.Instance.PlayHello(SoundManager.Instance.fart);
                    }
                    if (index == 24)
                    {
                        GetQuest();
                        CompleteQuest();
                        EndQuest();
                        SoundManager.Instance.PlayHello(SoundManager.Instance.cry);
                    }
                    if (index == 25)
                    {
                        GetQuest();
                        CompleteQuest();
                        EndQuest();
                        SoundManager.Instance.PlayHello(SoundManager.Instance.fart);
                    }
                    if (index == 26)
                    {
                        GetQuest();
                        CompleteQuest();
                        EndQuest();
                        SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                    }
                    if (index == 27)
                    {
                        GetQuest();
                        CompleteQuest();
                        EndQuest();
                        SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                    }
                    if (index == 28)
                    {
                        GetQuest();
                        CompleteQuest();
                        EndQuest();
                        SoundManager.Instance.PlayHello(SoundManager.Instance.cry);
                    }
                    if (index == 29)
                    {
                        GetQuest();
                        CompleteQuest();
                        EndQuest();
                        SoundManager.Instance.PlayHello(SoundManager.Instance.ask);
                    }
                    if (index == 30)
                    {
                        GetQuest();
                        CompleteQuest();
                        EndQuest();
                        SoundManager.Instance.PlayHello(SoundManager.Instance.midle);
                    }
                    if (index == 31)
                    {
                        GetQuest();
                        CompleteQuest();
                        EndQuest();
                        SoundManager.Instance.PlayHello(SoundManager.Instance.cry);
                    }
                    if (index == 32)
                    {
                        GetQuest();
                        CompleteQuest();
                        EndQuest();
                        SoundManager.Instance.PlayHello(SoundManager.Instance.cry);
                    }
                    if (index == 33)
                    {
                        GetQuest();
                        CompleteQuest();
                        EndQuest();
                        SoundManager.Instance.PlayHello(SoundManager.Instance.duck);
                    }
                    if (index == 34)
                    {
                        GetQuest();
                        CompleteQuest();
                        EndQuest();
                        SoundManager.Instance.PlayHello(SoundManager.Instance.ask);
                    }
                    if (index == 35)
                    {
                        GetQuest();
                        CompleteQuest();
                        EndQuest();
                        SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                    }
                    if (index == 36)
                    {
                        GetQuest();
                        CompleteQuest();
                        EndQuest();
                        SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                    }
                    if (index == 37)
                    {
                        GetQuest();
                        CompleteQuest();
                        EndQuest();
                        SoundManager.Instance.PlayHello(SoundManager.Instance.cute);
                    }
                }
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            CloseText();
            isFirstTrigger = true;
        }
    }
    public void ShowIdleState()
    {

        ShowOtherText();
    }
    public void GetQuest()
    {
        if(startQuest || ManagerQests.Instance.notActiveteOtherQuest[index])
        {
            OffOtherNPS();
            ShowItem();

            ShowStartText();
        } else
        {
            ShowOtherText();
        }
    }
    public void EndQuest()
    {
        if (startQuest && ManagerQests.Instance.endQuest)
        {
            ShowEndText();

            ManagerQests.Instance.completeQuest[index] = true;
            YandexGame.savesData.completeQuest[index] = ManagerQests.Instance.completeQuest[index];

            ManagerQests.Instance.couterQuestFinished++;
            YandexGame.savesData.couterQuestFinished = ManagerQests.Instance.couterQuestFinished;
            ManagerQests.Instance.couterQuestFinishedText.text = ManagerQests.Instance.couterQuestFinished.ToString();
            ManagerQests.Instance.couterQuestFinishedText1.text = ManagerQests.Instance.couterQuestFinished.ToString();
            if (ManagerQests.Instance.couterQuestFinished >= 20)
            {
                Gates.Instance.OpenGate();
            }
            if (ManagerQests.Instance.couterQuestFinished >= 30)
            {
                Gates.Instance.OpenGate1();
            }

            ManagerQests.Instance.Inventory[index].SetActive(false);
            ShowItemNPS();

            SoundManager.Instance.put.Play();

            OnAllNPS();
            CloseItem();

            ManagerQests.Instance.endQuest = false;
        }
    }
    public void CompleteQuest()
    {
        if (ManagerQests.Instance.completeQuest[index] || !startQuest)
        {
            ShowOtherText();
        }
    }
    public void OffOtherNPS()
    {
        for (int i = 0; i < ManagerQests.Instance.NPS.Length; i++)
        {
            ManagerQests.Instance.NPS[i].startQuest = false;
            ManagerQests.Instance.notActiveteOtherQuest[i] = false;
            ManagerQests.Instance.note[i].SetActive(false);
        }
        ManagerQests.Instance.NPS[index].startQuest = true;
    }
    public void OnAllNPS()
    {
        for (int i = 0; i < ManagerQests.Instance.NPS.Length; i++)
        {
            ManagerQests.Instance.NPS[i].startQuest = true;
            ManagerQests.Instance.notActiveteOtherQuest[i] = true;
            ManagerQests.Instance.note[i].SetActive(true);
            if (ManagerQests.Instance.completeQuest[i])
            {
                ManagerQests.Instance.note[i].SetActive(false);
            }
        }
    }
    public void ShowItem()
    {
        ManagerQests.Instance.Items[index].SetActive(true);
        arrow.SetActive(true);
        ArrowController.Instance.GetArrowDirection();
    }
    public void CloseItem()
    {
        ManagerQests.Instance.Items[index].SetActive(false);
        ArrowController.Instance.HideArrow();
    }
    public void ShowItemNPS()
    {
        itemNPS.SetActive(true);
    }
    public void CloseNoteNPS()
    {
        ManagerQests.Instance.note[index].SetActive(false);
    }
    public void CloseText()
    {
        textStart.SetActive(false);
        textEnd.SetActive(false);
        textOther.SetActive(false);
    }
    public void ShowStartText()
    {
        textStart.SetActive(true);
        textEnd.SetActive(false);
        textOther.SetActive(false);
        CloseNoteNPS();
    }
    public void ShowEndText()
    {
        textStart.SetActive(false);
        textEnd.SetActive(true);
        textOther.SetActive(false);
    }
    public void ShowOtherText()
    {
        for (int i = 0; i < textsOther.Length; i++)
        {
            textsOther[i].SetActive(false);
        }
        textsOther[Random.Range(0, textsOther.Length)].SetActive(true);

        textStart.SetActive(false);
        textEnd.SetActive(false);
        textOther.SetActive(true);
    }
}
