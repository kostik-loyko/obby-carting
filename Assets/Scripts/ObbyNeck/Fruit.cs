using UnityEngine;

public class Fruit : MonoBehaviour
{
    [SerializeField] int index;
    [SerializeField] GameObject prefPart;
    [SerializeField] GameObject prefBonusTXT;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<GrowNeck>())
        {
            other.gameObject.GetComponent<GrowNeck>().UpNeck(index);
            TextFloat textFloat = Instantiate(prefBonusTXT, transform.position, Quaternion.identity).GetComponent<TextFloat>();
            textFloat.SetCountText(index);

            Instantiate(prefPart, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
