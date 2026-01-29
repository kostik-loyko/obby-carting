using UnityEngine;
using YG;

public class PetUnlock : MonoBehaviour
{
    [SerializeField] int index;
    [SerializeField] GameObject pet;

    //private void Start()
    //{
    //    pet.GetComponent<PetController>().enabled = false;
    //}

    private void OnEnable()
    {
        PetManager.PetDestroy += GetPet;
    }

    private void OnDisable()
    {
        PetManager.PetDestroy -= GetPet;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PetManager.Instance.ShowPanel();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PetManager.Instance.HidePanel();
        }
    }

    public void GetPet()
    {
        PetManager.Instance.closePanels[index].SetActive(false);
        YandexGame.savesData.closePanels[index] = true;
        YandexGame.SaveProgress();
        
        PetManager.Instance.SwipeUI(index);

        Destroy(pet);
    }
}