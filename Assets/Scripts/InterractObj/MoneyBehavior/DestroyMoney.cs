using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMoney : MonoBehaviour
{ 
    void Start()
    {
        StartCoroutine(DestroyObj());
    }

    private IEnumerator DestroyObj()
    {
        yield return new WaitForSeconds(60f);
        Destroy(gameObject);
    }
}
