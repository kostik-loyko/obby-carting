using UnityEngine;

public class Gates : MonoBehaviour
{

    public static Gates Instance { get; set; }
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
    public GameObject gate;
    public GameObject gate1;
    private bool inPortal = false;

    public void OpenGate()
    {
        gate.SetActive(false);
    }
    public void OpenGate1()
    {
        gate1.SetActive(false);
    }

    // ×ÀÑÒÜ ÄËß ÏÎĞÒÀËÎÂ, ÍÅ ÄËß ÂÎĞÎÒ
    public void PlayerInPoral(bool insidePortal)
    {
        inPortal = insidePortal;
    }
    public bool InPortal()
    {
        return inPortal;
    }
}
