using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBeahaver : MonoBehaviour
{
    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Player"))
    //    {
    //        Score.Instance.UpScoreBig();
    //        EventAction.Instance.DicremetCountObjects();
    //        gameObject.SetActive(false);
    //    }
    //}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Score.Instance.UpScoreBig();
            EventAction.Instance.DicremetCountObjects();
            Instantiate(MoneyParticle.Instance.moneyPart, gameObject.transform.position, Quaternion.identity);
            gameObject.SetActive(false);
        }
    }
}
