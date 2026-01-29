using System.Collections.Generic;
using UnityEngine;
using TMPro;
using YG;
using System.Collections;

public class HighScale : MonoBehaviour
{
    GameObject[] cubesArray;
    private List<GameObject> cubesList = new List<GameObject>();
    [SerializeField] GameObject cubePref;
    [SerializeField] Transform highScale;
    [SerializeField] GrowNeck growNeck;
    //int hightScale = 32;
    int numDownCube;
    int countCubes = 100;
    Renderer rend;

    void Start()
    {
        cubesArray = new GameObject[countCubes];
        StartCoroutine(WaitLoadData());
        StartCoroutine(ImpruveScaleHeight());
    }
    private IEnumerator WaitLoadData()
    {
        yield return new WaitForSeconds(0.8f);
        countCubes = YandexGame.savesData.countCubes;
        numDownCube = Mathf.RoundToInt(countCubes - 150);
        for (int i = 0; i < cubesArray.Length; i++)
        {
            GameObject newCube;

            newCube = Instantiate(cubePref);
            if (i == 0)
            {
                newCube.transform.position = transform.position;
            }
            else
            {
                newCube.transform.position = cubesArray[i - 1].transform.position + new Vector3(0, 2, 0);
            }

            newCube.transform.SetParent(highScale, true);
            rend = newCube.GetComponent<Renderer>();
            Color randomColor = Random.ColorHSV();
            rend.material.SetColor("_BaseColor", randomColor);
            TextMeshProUGUI textHight = newCube.GetComponentInChildren<TextMeshProUGUI>();
            if (GameManager.Instance.isRU)
            {
                textHight.text = ShortScaleString.parseFloat(numDownCube++, 1, 1000, true).ToString() + " ì";
            }
            else
            {
                textHight.text = ShortScaleString.parseFloat(numDownCube++, 1, 1000, true).ToString() + " m";
            }
            //print(i);
            cubesArray[i] = newCube;

        }
        cubesList = new List<GameObject>(cubesArray);
    }
    public void UpHighScale()
    {
        GameObject bottomCube = cubesList[0];
        Vector3 newTopPosition = cubesList[cubesList.Count - 1].transform.position + new Vector3(0, 2, 0);
        bottomCube.transform.position = newTopPosition;

        countCubes++;
        YandexGame.savesData.countCubes = countCubes;

        TextMeshProUGUI textHight = bottomCube.GetComponentInChildren<TextMeshProUGUI>();
        if (GameManager.Instance.isRU)
        {
            textHight.text = ShortScaleString.parseFloat(countCubes - 50, 1, 1000, true).ToString() + " ì";
        }
        else
        {
            textHight.text = ShortScaleString.parseFloat(countCubes - 50, 1, 1000, true).ToString() + " m";
        }

        cubesList.RemoveAt(0);
        cubesList.Add(bottomCube);
    }
    public void SetHeightScale(int heightPos)
    {
        transform.position = new Vector3(transform.position.x, heightPos - 101f, transform.position.z);
    }
    public void ResetHeightScale(int heightPos)
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
        transform.position = new Vector3(transform.position.x, heightPos - 102f, transform.position.z);
        countCubes = 100;
        YandexGame.savesData.countCubes = countCubes;
        numDownCube = Mathf.RoundToInt(countCubes - 150);
        for (int i = 0; i < countCubes; i++)
        {
            GameObject newCube;

            newCube = Instantiate(cubePref);
            if (i == 0)
            {
                newCube.transform.position = transform.position;
            }
            else
            {
                newCube.transform.position = cubesArray[i - 1].transform.position + new Vector3(0, 2, 0);
            }

            newCube.transform.SetParent(highScale, true);
            rend = newCube.GetComponent<Renderer>();
            Color randomColor = Random.ColorHSV();
            rend.material.SetColor("_BaseColor", randomColor);
            TextMeshProUGUI textHight = newCube.GetComponentInChildren<TextMeshProUGUI>();
            if (GameManager.Instance.isRU)
            {
                textHight.text = ShortScaleString.parseFloat(numDownCube++, 1, 1000, true).ToString() + " ì";

            }
            else
            {
                textHight.text = ShortScaleString.parseFloat(numDownCube++, 1, 1000, true).ToString() + " m";
            }
            cubesArray[i] = newCube;

        }
        cubesList = new List<GameObject>(cubesArray);
    }

    private IEnumerator ImpruveScaleHeight()
    {
        yield return new WaitForSeconds(150f);

        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
        transform.position = new Vector3(transform.position.x, growNeck.GetNeckPosY() - 101f, transform.position.z);

        countCubes = YandexGame.savesData.countCubes;
        numDownCube = Mathf.RoundToInt(countCubes - 150);
        for (int i = 0; i < cubesArray.Length; i++)
        {
            GameObject newCube;

            newCube = Instantiate(cubePref);
            if (i == 0)
            {
                newCube.transform.position = transform.position;
            }
            else
            {
                newCube.transform.position = cubesArray[i - 1].transform.position + new Vector3(0, 2, 0);
            }

            newCube.transform.SetParent(highScale, true);
            rend = newCube.GetComponent<Renderer>();
            Color randomColor = Random.ColorHSV();
            rend.material.SetColor("_BaseColor", randomColor);
            TextMeshProUGUI textHight = newCube.GetComponentInChildren<TextMeshProUGUI>();
            if (GameManager.Instance.isRU)
            {
                textHight.text = ShortScaleString.parseFloat(numDownCube++, 1, 1000, true).ToString() + " ì";
            }
            else
            {
                textHight.text = ShortScaleString.parseFloat(numDownCube++, 1, 1000, true).ToString() + " m";
            }
            cubesArray[i] = newCube;

        }
        cubesList = new List<GameObject>(cubesArray);
        StartCoroutine(ImpruveScaleHeight());
    }
}
