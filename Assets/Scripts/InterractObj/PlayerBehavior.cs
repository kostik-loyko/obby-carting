using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using YG;

public class PlayerBehavior : MonoBehaviour
{
    public static PlayerBehavior Instance { get; set; }
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
    public GameObject moneyText;
    public GameObject damageText;
    public GameObject rateText;
    public GameObject missMoney;

    public AudioClip[] spiks;
    public AudioSource audioSource => GetComponent<AudioSource>();

    public float velocityAfterDialog = 5f;
    private float startVelocity = 5f;
    public float velocity = 5f;

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
        velocity = YandexGame.savesData.velocity;
        velocityAfterDialog = velocity;
    }

    private void OnCollisionEnter(Collision collision)
    {
        //if (collision.gameObject.CompareTag("Money"))
        //{
        //    StartCoroutine(WaitTakeMoney());
        //}
        if (collision.gameObject.CompareTag("Object"))
        {
            StartCoroutine(WaitTakeBigMoney());
        }
    }
    public void TakeMoney(float money)
    {
        TextFloat textFloat = Instantiate(moneyText, transform.position, Quaternion.identity).GetComponent<TextFloat>();
        textFloat.SetCountText(money);
    }
    public void GetRateDamageText(int rateDamage)
    {
        Vector3 posTextDamage = new Vector3(0, 2, 0);
        TextFloat textFloat = Instantiate(rateText, transform.position + posTextDamage, Quaternion.identity).GetComponent<TextFloat>();
        textFloat.SetCountText(rateDamage);
    }

    public void GetDamageText(int damage)
    {
        Vector3 posTextDamage = new Vector3(0, 1, 1.5f);
        TextFloat textFloat = Instantiate(damageText, transform.position + posTextDamage, Quaternion.identity).GetComponent<TextFloat>();
        textFloat.SetCountText(damage);
    }
    public void MissMoney(float money)
    {
        Vector3 posTextDamage = new (0, 1, 1);
        TextFloat textFloat = Instantiate(missMoney, transform.position + posTextDamage, Quaternion.identity).GetComponent<TextFloat>();
        textFloat.SetCountText(money);
    }

    //private IEnumerator WaitTakeMoney()
    //{
    //    yield return new WaitForSeconds(0.1f);
    //    TakeMoney(Score.Instance.finalRate);
    //}
    private IEnumerator WaitTakeBigMoney()
    {
        yield return new WaitForSeconds(0.1f);
        TakeMoney(Score.Instance.finalBigRate);
    }

    public void SpeakPlayer()
    {
        StartCoroutine(WaitSpeakPlayer());
    }
    private IEnumerator WaitSpeakPlayer()
    {
        yield return new WaitForSeconds(20f);
        PlaySound(spiks[Random.Range(0, 19)]);
        SpeakPlayer();
    }
    public void PlaySound(AudioClip clip, float volum = 1f, float p1 = 1f, float p2 = 1f)
    {
        audioSource.pitch = Random.Range(p1, p2);
        audioSource.PlayOneShot(clip, volum);
    }
    public void UpVelocity(float coficiet)
    {
        velocity = startVelocity * coficiet;
        velocityAfterDialog = velocity;
        YandexGame.savesData.velocity = velocity;
        YandexGame.SaveProgress();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BulletEnemy"))
        {
            Score.Instance.DownScoreDamage(300);
            MissMoney(300);
        }
    }
}
