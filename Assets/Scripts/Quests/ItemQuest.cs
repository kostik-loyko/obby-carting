using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class ItemQuest : MonoBehaviour
{
    [SerializeField] int index;
    [SerializeField] GameObject moneyText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
           GetItemQuest();
        }
    }
    public void GetItemQuest()
    {
        ManagerQests.Instance.endQuest = true;
        ManagerQests.Instance.Inventory[index].SetActive(true);
        ArrowController.Instance.HideArrow();

        SoundManager.Instance.getMoney.Play();
        Instantiate(MoneyParticle.Instance.moneyPart, gameObject.transform.position, Quaternion.identity);
        Score.Instance.UpScoreItem();
        TextFloat textFloat = Instantiate(moneyText, transform.position, Quaternion.identity).GetComponent<TextFloat>();
        textFloat.SetCountText(Score.Instance.finalRate);

        gameObject.SetActive(false);
    }
}
