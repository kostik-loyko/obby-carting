using System.Collections;
using TMPro;
using UnityEngine;

public class BrainrotBeahaver : MonoBehaviour
{
    public Branrot[] brData;
    private int indexBr;
    private void Start()
    {
        StartCoroutine(SpawnBrairotCorut());
    }
    private IEnumerator SpawnBrairotCorut()
    {
        indexBr = Random.Range(0, brData.Length);
        yield return new WaitForSeconds(0.5f);

        GetSprite(gameObject, indexBr);
        SetName(gameObject, indexBr);
    }
    public void GetSprite(GameObject br, int index)
    {
        SpriteRenderer[] allSprites = br.GetComponentsInChildren<SpriteRenderer>();
        allSprites[0].sprite = brData[index].Icon;
    }
    public void SetName(GameObject br, int index)
    {
        TextMeshProUGUI[] allTexts = br.GetComponentsInChildren<TextMeshProUGUI>();
        for (int j = 0; j < allTexts.Length; j++)
        {
            if (allTexts[j].name == "TxtName")
            {
                TextMeshProUGUI textBr = allTexts[j].GetComponent<TextMeshProUGUI>();
                if (GameManager.Instance.isRU)
                {
                    textBr.text = brData[index].nameRU;
                }
                else
                {
                    textBr.text = brData[index].nameEN;
                }
            }
            if (allTexts[j].name == "TxtRarity")
            {
                TextMeshProUGUI textBr = allTexts[j].GetComponent<TextMeshProUGUI>();
                if (GameManager.Instance.isRU)
                {
                    textBr.text = brData[index].rarityRU;
                }
                else
                {
                    textBr.text = brData[index].rarityEN;
                }

                if (brData[index].rarityEN == "rare")
                {
                    textBr.color = new Color(0.18f, 0.38f, 0.82f, 1);
                }
                if (brData[index].rarityEN == "epic")
                {
                    textBr.color = new Color(0.67f, 0f, 1f, 1);
                }
                if (brData[index].rarityEN == "legendary")
                {
                    textBr.color = new Color(1f, 0.63f, 0f, 1);
                }
                if (brData[index].rarityEN == "mythic")
                {
                    textBr.color = new Color(1f, 0f, 0.93f, 1);
                }
                if (brData[index].rarityEN == "godly")
                {
                    textBr.color = new Color(1f, 0.37f, 0.07f, 1);
                }
                if (brData[index].rarityEN == "secret")
                {
                    textBr.color = new Color(0.2f, 0.2f, 0.2f, 1);
                }
            }
        }
    }
    public Branrot GetBrData()
    {
        return brData[indexBr];
    }
}
