using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpPets : MonoBehaviour
{
    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Player"))
    //    {
    //        if (Pets.Instance.hasPets)
    //        {
    //            Score.Instance.UpCoeffRate();
    //        } else
    //        {
    //            SoundManager.Instance.notmoney.Play();
    //        }

    //    }
    //}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (Pets.Instance.hasPets)
            {
                Score.Instance.UpCoeffRate();
            }
            else
            {
                SoundManager.Instance.notmoney.Play();
            }

        }
    }
}
