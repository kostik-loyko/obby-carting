using System.Collections;
using UnityEngine;

public class AddPunch : MonoBehaviour
{
    CharacterController cc;
    Rigidbody rb;
    private float pushForce = 30f;
    [SerializeField] GameObject player;
    [SerializeField] GameObject sfera;
    void Start()
    {
        cc = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PunchEnemy"))
        {
            SoundManager.Instance.damage.Play();
            cc.enabled = false;
            rb.isKinematic = true;
            if (!MobileInputManager.Instance.IsMobileDevice())
            {
                player.GetComponent<ThirdPersonController>().enabled = false;
            }
            else
            {
                player.GetComponent<ControllerMobile>().enabled = false;
            }

            sfera.transform.parent = null;
            sfera.SetActive(true);
            player.transform.SetParent(sfera.transform);

            Vector3 pushDirection = -(other.transform.position - transform.position).normalized;
            sfera.GetComponent<Rigidbody>().AddForce(pushDirection * pushForce, ForceMode.Impulse);
            StartCoroutine(StandUpAfterPunch());
        }
    }

    private IEnumerator StandUpAfterPunch()
    {
        yield return new WaitForSeconds(3f);
        player.transform.parent = null;
        sfera.transform.SetParent(player.transform);
        sfera.SetActive(false);
        cc.enabled = true;
        rb.isKinematic = false;
        if (!MobileInputManager.Instance.IsMobileDevice())
        {
            player.GetComponent<ThirdPersonController>().enabled = true;
        }
        else
        {
            player.GetComponent<ControllerMobile>().enabled = true;
        }
    }
}
