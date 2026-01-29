using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;
using TMPro;
using YG;

public class RandomUISpawner : MonoBehaviour
{
    [SerializeField] GameObject uiPrefab;
    [SerializeField] Vector2 spawnAreaMin = new Vector2(-300, -200);
    [SerializeField] Vector2 spawnAreaMax = new Vector2(300, 200);

    [SerializeField] GrowNeck growNeck;

    void Start()
    {
        StartCoroutine(SpawSecondHeight());
    }

    void SpawnRandomUIElements()
    {
        if (!GameManager.Instance.PauseGame())
        {
            float randomX = Random.Range(spawnAreaMin.x, spawnAreaMax.x);
            float randomY = Random.Range(spawnAreaMin.y, spawnAreaMax.y);

            GameObject newUIElement = Instantiate(uiPrefab, transform); // Создаем дочерним к этому объекту
            newUIElement.GetComponent<TextMeshProUGUI>().text = "+" + growNeck.GetHeightNeckSecond().ToString();
            RectTransform elementRect = newUIElement.GetComponent<RectTransform>();

            elementRect.anchoredPosition = new Vector2(randomX, randomY);
        }
    }
    private IEnumerator SpawSecondHeight()
    {
        yield return new WaitForSeconds(2f);
        //PlayerBehavior.Instance.UpSpeedSecond();
        SpawnRandomUIElements();
        StartCoroutine(SpawSecondHeight());
    }
}
