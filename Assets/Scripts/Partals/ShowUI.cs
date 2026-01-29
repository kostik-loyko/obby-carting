using UnityEngine;

public class ShowUI : MonoBehaviour
{
    public static ShowUI Instance { get; set; }
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
    [SerializeField] GameObject[] elementsUI;
    private bool isCanShoot = false;

    private void OnTriggerEnter(Collider other)
    {
        ShowIcons();
    }
    public void ShowIcons()
    {
        isCanShoot = true;
        for (int i = 0; i < elementsUI.Length; i++)
        {
            elementsUI[i].SetActive(true);
        }
    }
    public bool CanShoot()
    {
        return isCanShoot;
    }
    public void ToggleCanShoot()
    {
        isCanShoot = !isCanShoot;
    }
}
