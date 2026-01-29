using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Portal : MonoBehaviour
{
    public static Portal Instance { get; set; }
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
    public static event UnityAction StartBrCatch;

    [SerializeField] GameObject targetPosition;
    [SerializeField] GameObject targetPosition1;

    [SerializeField] GameObject[] elementsUI;
    [SerializeField] GameObject[] elementsBrCatch;
    private bool isCanShoot = false;

    public void MoveNewPosition(GameObject player, int index)
    {
        StartCoroutine(TogglePortalCorut());
        if (index == 0)
        {
            player.transform.position = targetPosition1.transform.position;
            ShowCity();
        }
        if (index == 1)
        {
            player.transform.position = targetPosition.transform.position;
            HideCity();
        }
    }
    private IEnumerator TogglePortalCorut()
    {
        Gates.Instance.PlayerInPoral(true);
        yield return new WaitForSeconds(0.1f);
        Gates.Instance.PlayerInPoral(false);
    }
    private void ShowCity()
    {
        isCanShoot = true;
        Score.Instance.DownScore(Score.Instance.score);
        for (int i = 0; i < elementsUI.Length; i++)
        {
            elementsUI[i].SetActive(true);
        }
        HideBrCatch();
    }
    private void HideCity()
    {
        isCanShoot = false;
        Score.Instance.DownScore(Score.Instance.score);
        for (int i = 0; i < elementsUI.Length; i++)
        {
            elementsUI[i].SetActive(false);
        }
        ShowBrCatch();
    }
    private void HideBrCatch()
    {
        for (int j = 0; j < elementsBrCatch.Length; j++)
        {
            elementsBrCatch[j].SetActive(false);
        }
    }
    private void ShowBrCatch()
    {
        for (int j = 0; j < elementsBrCatch.Length; j++)
        {
            elementsBrCatch[j].SetActive(true);
        }
        StartBrCatch?.Invoke();
    }
    public bool CanShoot()
    {
        return isCanShoot;
    }
}
