using UnityEngine;

public class Hat : MonoBehaviour
{
    [SerializeField] GameObject[] Hates;

    void Start()
    {
        Hates[Random.Range(0, Hates.Length)].SetActive(true);
    }
}
