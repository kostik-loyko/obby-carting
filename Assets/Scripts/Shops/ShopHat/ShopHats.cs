using UnityEngine;

public class ShopHats : MonoBehaviour
{
    [SerializeField] private ShopHatBTN[] AllButton;

    private void Start()
    {
        AllButton = GetComponentsInChildren<ShopHatBTN>();

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
