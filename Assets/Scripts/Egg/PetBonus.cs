using System.Collections;
using UnityEngine;

public class PetBonus : MonoBehaviour
{
    [SerializeField] private int index;
    public GameObject bonusText;

    private void Start()
    {
        StartCoroutine(GetBonusPetCorut());
    }

    //private void OnEnable() => GameManager.GetPetBonus += OnBonusPet;

    //private void OnDisable() => GameManager.GetPetBonus -= OnBonusPet;

    public void OnBonusPet()
    {
        int multiplyBonus = index * 10;
        Score.Instance.UpScoreNewPet(multiplyBonus);
        TextFloat textFloat = Instantiate(bonusText, transform.position, Quaternion.identity).GetComponent<TextFloat>();
        textFloat.SetCountText(multiplyBonus);
    }

    private IEnumerator GetBonusPetCorut()
    {
        yield return new WaitForSeconds(3f);
        OnBonusPet();
        StartCoroutine(GetBonusPetCorut());
    }
}
