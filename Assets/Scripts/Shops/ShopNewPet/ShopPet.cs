using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopPet : MonoBehaviour
{
    [SerializeField] private ShopBtnPet[] AllButton;

    private void Start()
    {
        AllButton = GetComponentsInChildren<ShopBtnPet>();

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
