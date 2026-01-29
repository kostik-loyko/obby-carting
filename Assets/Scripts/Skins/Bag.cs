using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bag : MonoBehaviour
{
    [SerializeField] int rateDamage;
    [SerializeField] GameObject moneyText;

    [SerializeField] GameObject hitPart;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Glove"))
        {
            Damage.Instance.UpDamage(rateDamage);
            PlayerBehavior.Instance.GetRateDamageText(rateDamage);

            Vector3 posParticle = new Vector3(0, 0, 0f);
            Instantiate(hitPart, other.gameObject.transform.position + posParticle, Quaternion.identity);

            SoundManager.Instance.punch.Play();
        }
    }
}
