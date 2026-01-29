using UnityEngine;
using UnityEngine.UI;

public class GetBr : MonoBehaviour
{
    [SerializeField] CollectBr collectBr;
    [SerializeField] GameObject part;
    [SerializeField] GameObject moneyTextPart;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<BrainrotBeahaver>())
        {
            Branrot brData = other.gameObject.GetComponent<BrainrotBeahaver>().GetBrData();
            collectBr.AddBranrot(brData);
            Instantiate(part, other.gameObject.transform.position, Quaternion.identity);

            //PlayerBehavior.Instance.TakeMoney(brData.mine);

            TakeMoney(brData.mine);
            Score.Instance.UpScoreForWall(brData.mine);

            Destroy(other.gameObject);
        }
    }

    public void TakeMoney(float money)
    {
        Vector3 newPos = new Vector3(0, 2f, 0);
        TextFloat textFloat = Instantiate(moneyTextPart, transform.position + newPos, Quaternion.identity).GetComponent<TextFloat>();
        textFloat.SetCountText(money);
    }
}
