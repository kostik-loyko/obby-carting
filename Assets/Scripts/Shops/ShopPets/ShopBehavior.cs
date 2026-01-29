using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopBehavior : MonoBehaviour
{
    public GameObject Shop;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            OpenShop();
        }
    }

    public void OpenShop()
    {
        Shop.SetActive(true);
        GameManager.Instance.OffPunch();
        GameManager.Instance.OnPauseGame();
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void CloseShop()
    {
        Shop.SetActive(false);
        GameManager.Instance.OnPunch();
        GameManager.Instance.OffPauseGame();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
