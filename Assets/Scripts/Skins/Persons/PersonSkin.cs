using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonSkin : MonoBehaviour
{
    [SerializeField] int index;
    [SerializeField] GameObject bublePart;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            for (int i = 0; i < GameManager.Instance.personSkins.Length; i++)
            {
                GameManager.Instance.personSkins[i].SetActive(false);
            }
            for (int i = 0; i < GameManager.Instance.buySkins.Length; i++)
            {
                GameManager.Instance.buySkins[i].SetActive(true);
            }
            if (index == 0)
            {
                GetSkin(index);
            }
            if (index == 1)
            {
                GetSkin(index);
            }
            if (index == 2)
            {
                GetSkin(index);
            }
            if (index == 3)
            {
                GetSkin(index);
            }
            if (index == 4)
            {
                GetSkin(index);
            }
            if (index == 5)
            {
                GetSkin(index);
            }
            if (index == 6)
            {
                GetSkin(index);
            }
            if (index == 7)
            {
                GetSkin(index);
            }
            if (index == 8)
            {
                GetSkin(index);
            }
            if (index == 9)
            {
                GetSkin(index);
            }
            if (index == 10)
            {
                GetSkin(index);
            }
        }
    }
    public void GetSkin(int index)
    {
        GameManager.Instance.personSkins[index].SetActive(true);
        GameManager.Instance.buySkins[index].SetActive(false);
        //ControllerMobile.Instance.ChangeChild(index);
        Instantiate(bublePart, transform.position, Quaternion.identity);
    }
}
