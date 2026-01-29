using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenShopHat : MonoBehaviour
{
    [SerializeField] GameObject hatShop;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            hatShop.SetActive(true);
            GameManager.Instance.OffPunch();
            GameManager.Instance.OnPauseGame();
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
    public void CloseShop()
    {
        GameManager.Instance.OnPunch();
        GameManager.Instance.OffPauseGame();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
