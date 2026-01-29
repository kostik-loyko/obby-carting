using UnityEngine;

public class HideUI : MonoBehaviour
{
    [SerializeField] GameObject[] elementsUI;

    private void OnTriggerEnter(Collider other)
    {
        HideIcons();
    }
    public void HideIcons()
    {
        ShowUI.Instance.ToggleCanShoot();
        for (int i = 0; i < elementsUI.Length; i++)
        {
            elementsUI[i].SetActive(false);
        }
    }
}
