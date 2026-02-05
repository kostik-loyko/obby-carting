using TMPro;
using UnityEngine;

public class ScaleHeight : MonoBehaviour
{
    [Header("Настройки объектов")]
    [SerializeField] RectTransform pointer;
    [SerializeField] float minY;
    [SerializeField] float maxY;

    [Header("Диапазон данных")]
    [SerializeField] float minValue;
    [SerializeField] float maxValue;

    [SerializeField] TextMeshProUGUI _distanceText;

    public void UpdatePointer(float currentValue)
    {
        float t = Mathf.InverseLerp(minValue, maxValue, currentValue);
        float newY = Mathf.Lerp(minY, maxY, t);
        Vector2 pos = pointer.anchoredPosition;
        pos.y = newY;
        pointer.anchoredPosition = pos;

        _distanceText.text = ShortScaleString.parseFloat(currentValue, 1, 1000, true).ToString();
    }
    public void ResetDistanceText()
    {
        _distanceText.text = ShortScaleString.parseFloat(0, 1, 1000, true).ToString();
    }
}
