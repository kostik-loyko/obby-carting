using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using YG;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance { get; set; }
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

    public AudioSource getMoney;
    public AudioSource getObject;
    public AudioSource notmoney;
    public AudioSource buy;
    public AudioSource back;
    public AudioSource punch;
    public AudioSource egg;
    public AudioSource jump;
    public AudioSource put;
    public AudioSource swish;
    public AudioSource cry;
    public AudioSource treeHit;
    public AudioSource select;
    public AudioSource openDoor;
    public AudioSource closeDoor;
    public AudioSource openMetalDoor;
    public AudioSource closeMetalDoor;
    public AudioSource doorMove;
    public AudioSource metal;
    public AudioSource trashHit;
    public AudioSource lightHit;

    public AudioSource ask;
    public AudioSource cute;
    public AudioSource midle;
    public AudioSource hard;
    public AudioSource woof;
    public AudioSource cow;
    public AudioSource Donkey;
    public AudioSource Chicken;
    public AudioSource pig;
    public AudioSource Ram;
    public AudioSource Horse;
    public AudioSource fart;
    public AudioSource dontSpeak;
    public AudioSource whistling;
    //private bool isPlay = true;

    public AudioSource bullet;
    public AudioSource zombiStart;
    public AudioSource damage;
    //public AudioSource boss;


    public AudioSource capuchino;
    public AudioSource cocos;
    public AudioSource dinDon;
    public AudioSource fish;
    public AudioSource crocodilo;
    public AudioSource lagushka;
    public AudioSource elefant;
    public AudioSource monkey;
    public AudioSource duck;
    public AudioSource katFish;
    public AudioSource osminog;
    public AudioSource shark;
    public AudioSource monkeyNose;
    public AudioSource arbuz;
    public AudioSource kaktusElefant;
    public AudioSource delfini;
    public AudioSource tigr;
    public AudioSource camel;
    public AudioSource cowSaturnita;
    public AudioSource giraf;
    private void Start()
    {
        back.volume = 1f;
        back.Play();
    }

    public void PlayHello(AudioSource sound)
    {
        sound.pitch = Random.Range(0.8f, 1.2f);
        sound.Play();
    }
    public void SpeakOldNPC(int index)
    {
        if (index == 0)
        {
            hard.Play();
        }
        if (index == 1)
        {
            cry.Play();
        }
        if (index == 2)
        {
            midle.Play();
        }
        if (index == 3)
        {
            cry.Play();
        }
        if (index == 4)
        {
            midle.Play();
        }
        if (index == 5)
        {
            cry.Play();
        }
        if (index == 6)
        {
            midle.Play();
        }
        if (index == 7)
        {
            cry.Play();
        }
        if (index == 8)
        {
            dontSpeak.Play();
        }
        back.volume = 0.5f;
        StartCoroutine(SpeakOldCorutin());
    }
    private IEnumerator SpeakOldCorutin()
    {
        yield return new WaitForSeconds(6f);

        back.volume = 1f;
    }
    //public void PlayHello()
    //{
    //    if (isPlay)
    //    {
    //        StartCoroutine(WaitPlayHello());
    //        isPlay = false;
    //    }
    //}
    //private IEnumerator WaitPlayHello()
    //{
    //    hello.Play();
    //    yield return new WaitForSeconds(30f);
    //    isPlay = true;
    //}
}
