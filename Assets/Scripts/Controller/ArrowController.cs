using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ArrowController : MonoBehaviour
{
    public static ArrowController Instance { get; set; }
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
    float gameTime;

    Transform item;

    //private void Start()
    //{
    //    item = GameObject.FindGameObjectWithTag("ItemQuest").transform;
    //}

    public void GetArrowDirection()
    {
        item = GameObject.FindGameObjectWithTag("ItemQuest").transform;
    }
    public void HideArrow()
    {
        gameObject.SetActive(false);
    }

    void FixedUpdate()
    {
        gameTime += 1f * Time.deltaTime;
        if (gameTime >= 0.3f)
        {
            gameTime = 0;
            transform.LookAt(item.transform);
        }
    }
}
