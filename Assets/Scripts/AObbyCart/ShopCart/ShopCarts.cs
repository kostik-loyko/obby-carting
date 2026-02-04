using UnityEngine;

public class ShopCarts : MonoBehaviour
{
    [SerializeField] private ShopCartBTN[] AllButton;

    private void Start()
    {
        AllButton = GetComponentsInChildren<ShopCartBTN>();

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
