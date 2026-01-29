using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Name : MonoBehaviour
{
    [SerializeField] GameObject[] names;

    void Start()
    {
        names[Random.Range(0, names.Length)].SetActive(true);
    }
}
