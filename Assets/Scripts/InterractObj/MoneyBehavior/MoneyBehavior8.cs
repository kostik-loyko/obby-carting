using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoneyBehavior8 : MonoBehaviour
{
    public GameObject moneyText;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Score.Instance.UpScore8();
            SoundManager.Instance.getMoney.Play();
            Instantiate(MoneyParticle.Instance.moneyPart, gameObject.transform.position, Quaternion.identity);

            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CatchMoney"))
        {
            Score.Instance.UpScore8();
            Instantiate(MoneyParticle.Instance.moneyPart, gameObject.transform.position, Quaternion.identity);

            TextFloat textFloat = Instantiate(moneyText, transform.position, Quaternion.identity).GetComponent<TextFloat>();
            textFloat.SetCountText(Score.Instance.finalRate);

            Destroy(gameObject);
        }
    }
}
