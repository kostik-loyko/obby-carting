using UnityEngine;

public class Platform : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(transform);
            collision.transform.GetComponent<CharacterController>().enabled = false;
            EventManager.OntouchPlatform();
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
            EventManager.OfftouchPlatform();
            //collision.transform.GetComponent<CharacterController>().enabled = true;
        }
    }
}
