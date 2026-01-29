using System.Collections;
using UnityEngine;

public class RandomUpwardMovement : MonoBehaviour
{
    private float moveDuration = 2.0f;
    private float upwardDistance = 200.0f;
    private float horizontalDeviation = 50.0f;
    private AnimationCurve easeCurve = AnimationCurve.EaseInOut(0, 0, 1, 1);

    private RectTransform rectTransform;
    private Vector3 startPosition;
    private Vector3 endPosition;

    private CanvasGroup canvasGroup;

    void Start()
    {
        if (GameManager.Instance.PauseGame())
        {
            Destroy(gameObject);
        }
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();

        startPosition = rectTransform.anchoredPosition;

        float randomXOffset = Random.Range(-horizontalDeviation, horizontalDeviation);
        endPosition = startPosition + new Vector3(randomXOffset, upwardDistance, 0);

        StartCoroutine(AnimateMovement());
    }

    IEnumerator AnimateMovement()
    {
        float elapsedTime = 0;

        while (elapsedTime < moveDuration)
        {
            float t = elapsedTime / moveDuration;
            float curvedT = easeCurve.Evaluate(t);

            rectTransform.anchoredPosition = Vector3.Lerp(startPosition, endPosition, curvedT);
            canvasGroup.alpha = Mathf.Lerp(1f, 0f, elapsedTime / moveDuration);

            elapsedTime += Time.deltaTime;

            yield return null;
        }
        rectTransform.anchoredPosition = endPosition;
        canvasGroup.alpha = 0f;

        Destroy(gameObject); 
    }
}
