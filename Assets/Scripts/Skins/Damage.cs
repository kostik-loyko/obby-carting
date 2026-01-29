using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YG;

public class Damage : MonoBehaviour
{
    public static Damage Instance { get; set; }
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

    public int damage;
    //[SerializeField] TextMeshProUGUI textDamage;
    //public Image damageImg;

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
        damage = YandexGame.savesData.damageBoxing;
        //textDamage.text = ShortScaleString.parseFloat(damage, 1, 1000, true).ToString();
    }

    public void UpDamage(int rateDamage)
    {
        damage += rateDamage;
        YandexGame.savesData.damageBoxing = damage;
    }
}
