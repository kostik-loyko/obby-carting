using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metal : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SoundManager.Instance.metal.Play();
        }
    }
}
