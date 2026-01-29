using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopTrails : MonoBehaviour
{
    [SerializeField] private ShopTrailBTN[] AllButton;

    private void Start()
    {
        AllButton = GetComponentsInChildren<ShopTrailBTN>();

        for (int i = 0; i < AllButton.Length; i++)
        {
            AllButton[i].SetManager(this);
        }
    }

    public void UpdateInfoButton()
    {
        for (int i = 0; i < AllButton.Length; i++)
        {
            AllButton[i].UpdateInfo();
        }
    }
}
