using System;
using UnityEngine;
using System.Collections;

public class HeightShops : MonoBehaviour
{
    [SerializeField] GrowNeck growNeck;
    [SerializeField] int correctHeight;
    void Start()
    {
        StartCoroutine(UpNeckSecond());
    }

    private IEnumerator UpNeckSecond()
    {
        yield return new WaitForSeconds(1f);
        transform.position = new Vector3(transform.position.x, growNeck.GetNeckPosY() - correctHeight, transform.position.z);

        StartCoroutine(UpNeckSecond());
    }
}
