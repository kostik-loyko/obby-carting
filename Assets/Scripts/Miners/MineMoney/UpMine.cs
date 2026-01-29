using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpMine : MonoBehaviour
{
    [SerializeField] BuyMine BuyMine;

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Player"))
    //    {
    //        BuyMine.UpMiner();
    //    }
    //}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            BuyMine.UpMiner();
        }
    }
}
