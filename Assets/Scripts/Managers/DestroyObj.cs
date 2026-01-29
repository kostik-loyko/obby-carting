using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObj : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(WaitDestroyObj());
    }
    private IEnumerator WaitDestroyObj()
    {
        yield return new WaitForSeconds(2f);

        Destroy(gameObject);
    }
}
