using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinAI : MonoBehaviour
{
    [SerializeField] GameObject[] bodes;
    void Start()
    {
        bodes[Random.Range(0, bodes.Length)].SetActive(true);
    }
}
