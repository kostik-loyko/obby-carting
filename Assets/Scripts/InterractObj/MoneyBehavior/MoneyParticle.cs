using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyParticle : MonoBehaviour
{
    public static MoneyParticle Instance { get; set; }
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
    public GameObject moneyPart;
}
