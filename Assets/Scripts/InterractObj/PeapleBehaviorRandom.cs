using UnityEngine;

public class PeapleBehaviorRandom : MonoBehaviour
{
    [SerializeField] GameObject textNPC;
    [SerializeField] GameObject[] textsOther;

    [SerializeField] int index;

    private bool isFirstTrigger = true;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (isFirstTrigger)
            {
                isFirstTrigger = false;
                textsOther[Random.Range(0, textsOther.Length)].SetActive(true);
                textNPC.SetActive(true);
                if (index == 0)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cry);
                }
                else if(index == 1)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.midle);
                }
                else if (index == 2)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cry);
                }
                else if (index == 3)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                }
                else if (index == 4)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                }
                else if (index == 5)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.fart);
                }
                else if (index == 6)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cry);
                }
                else if (index == 7)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.ask);
                }
                else if (index == 8)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cute);
                }
                else if (index == 9)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.midle);
                }
                else if (index == 10)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cute);
                }
                else if (index == 11)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.midle);
                }
                else if (index == 12)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cry);
                }
                else if (index == 13)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cute);
                }
                else if (index == 14)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.midle);
                }
                else if (index == 15)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                }
                else if (index == 16)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cute);
                }
                else if (index == 17)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cry);
                }
                else if (index == 18)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cute);
                }
                else if (index == 19)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cute);
                }
                else if (index == 20)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.Donkey);
                }
                else if (index == 21)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cow);
                }
                else if (index == 22)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.Chicken);
                }
                else if (index == 23)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.pig);
                }
                else if (index == 24)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.Ram);
                }
                else if (index == 25)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.Horse);
                }
                else if (index == 26)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cute);
                }
                else if (index == 27)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cute);
                }
                else if (index == 28)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.midle);
                }
                else if (index == 29)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.whistling);
                }
                else if (index == 30)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cute);
                }
                else if (index == 31)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cry);
                }
                else if (index == 32)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cry);
                }
                else if (index == 33)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.midle);
                }
                else if (index == 34)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cry);
                }
                else if (index == 35)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cute);
                }
                else if (index == 36)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                }
                else if (index == 37)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                }
                else if (index == 38)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cute);
                }
                else if (index == 39)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cry);
                }
                else if (index == 40)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.midle);
                }
                else if (index == 41)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cute);
                }
                else if (index == 42)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                }
                else if (index == 43)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                }
                else if (index == 44)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                }
                else if (index == 45)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                }
                else if (index == 46)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                }
                else if (index == 47)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.ask);
                }
                else if (index == 48)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cute);
                }
                else if (index == 49)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                }
                else if (index == 50)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cute);
                }
                else if (index == 51)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                }
                else if (index == 52)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.dontSpeak);
                }
                else if (index == 53)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                }
                else if (index == 54)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.midle);
                }
                else if (index == 55)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                }
                else if (index == 56)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                }
                else if (index == 57)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.woof);
                }
                else if (index == 58)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.ask);
                }
                else if (index == 63)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cry);
                }
                else if (index == 64)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                }
                else if (index == 65)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cute);
                }
                else if (index == 66)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cry);
                }
                else if (index == 67)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cute);
                }
                else if (index == 68)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.midle);
                }
                else if (index == 69)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cry);
                }
                else if (index == 70)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                }
                else if (index == 71)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cry);
                }
                else if (index == 72)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cry);
                }
                else if (index == 73)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cute);
                }
                else if (index == 74)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cry);
                }
                else if (index == 75)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                }
                else if (index == 76)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cry);
                }
                else if (index == 77)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cry);
                }
                else if (index == 78)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.ask);
                }
                else if (index == 79)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.ask);
                }
                else if (index == 80)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.ask);
                }
                else if (index == 81)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.ask);
                }
                else if (index == 82)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cry);
                }
                else if (index == 100)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cry);
                }
                else if (index == 101)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.ask);
                }
                else if (index == 102)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                }
                else if (index == 103)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                }
                else if (index == 104)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                }
                else if (index == 105)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                }
                else if (index == 106)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                }
                else if (index == 107)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.ask);
                }
                else if (index == 108)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.midle);
                }
                else if (index == 109)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cry);
                }
                else if (index == 110)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cute);
                }
                else if (index == 111)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                }
                else if (index == 112)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.ask);
                }
                else if (index == 113)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cute);
                }
                else if (index == 114)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                }
                else if (index == 115)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cute);
                }
                else if (index == 116)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cute);
                }
                else if (index == 117)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cute);
                }
                else if (index == 118)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.ask);
                }
                else if (index == 119)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.hard);
                }
                else if (index == 120)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cry);
                }
                else if (index == 121)
                {
                    SoundManager.Instance.PlayHello(SoundManager.Instance.cute);
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            for (int i = 0; i < textsOther.Length; i++)
            {
                textsOther[i].SetActive(false);
            }
            textNPC.SetActive(false);
            isFirstTrigger = true;
        }
    }
}
