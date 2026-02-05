using UnityEngine;
using System.Collections;
using TMPro;

public class MoveTop : MonoBehaviour
{
    float speed = 5.0f;
    float speedDefoult = 5.0f;
    bool isMoveTop = false;
    bool isMoveDown = false;
    bool inStartTriger = false;
    bool unableKeyE = true;
    [SerializeField] Transform startPos;
    [SerializeField] Transform endPos;
    [SerializeField] Transform endPos1;
    [SerializeField] GameObject btnDown;
    [SerializeField] GameObject btnUP;
    [SerializeField] GameObject btnUPmobile;

    Vector3 startPositionToDown;
    [SerializeField] Transform targetPositionToDown;
    float duration = 3.0f;
    float elapsedTime = 0f;

    [SerializeField] TextMeshProUGUI _revenueText;
    Vector3 lastPosition;
    float totalDistance = 0f;

    [SerializeField] ScaleHeight scaleHeight;

    private void Start()
    {
        lastPosition = startPos.position;
    }

    void Update()
    {
        StartMoveTop();
        if (isMoveTop)
        {
            if (!isMoveDown)
            {
                TopMove();
                RevenueToMove();
                StartMoveDown();
            }
            if (isMoveDown)
            {
                MoveDown();
            }
        }
    }
    public void OnMoveTop()
    {
        if (!inStartTriger)
        {
            inStartTriger = true;
            if (MobileInputManager.Instance.IsMobileDevice())
            {
                btnUPmobile.SetActive(true);
            }
            else
            {
                btnUP.SetActive(true);
            }
        }
    }
    public void OffMoveTop()
    {
        if (inStartTriger)
        {
            inStartTriger = false;
            if (MobileInputManager.Instance.IsMobileDevice())
            {
                btnUPmobile.SetActive(false);
            }
            btnUP.SetActive(false);
        }
    }
    public void StopMove(int index)
    {
        if (isMoveTop)
        {
            isMoveTop = false;
            isMoveDown = false;
            elapsedTime = 0f;
            if (index == 0)
            {
                transform.position = endPos.position;
                transform.rotation = endPos.rotation;
            }
            if (index == 1)
            {
                transform.position = endPos1.position;
                transform.rotation = endPos1.rotation;
            }
            Carts.Instance.SetCartStop();
            scaleHeight.ResetDistanceText();
        }
    }
    public void StartMoveTop()
    {
        if (Input.GetKeyDown(KeyCode.F) && inStartTriger)
        {
            transform.position = startPos.position;
            transform.rotation = startPos.rotation;
            Carts.Instance.SetCartMove();
            btnUP.SetActive(false);
            if (MobileInputManager.Instance.IsMobileDevice())
            {
                btnUPmobile.SetActive(false);
            }
            btnDown.SetActive(true);
            inStartTriger = false;
            isMoveTop = true;
        }
    }
    public void StartMoveTopMobile()
    {
        transform.position = startPos.position;
        transform.rotation = startPos.rotation;
        Carts.Instance.SetCartMove();
        btnUP.SetActive(false);
        if (MobileInputManager.Instance.IsMobileDevice())
        {
            btnUPmobile.SetActive(false);
        }
        btnDown.SetActive(true);
        inStartTriger = false;
        isMoveTop = true;
    }
    public void StartMoveDown()
    {
        if (Input.GetKeyDown(KeyCode.E) && unableKeyE)
        {
            transform.Translate(-15f, 0f, 0f);
            transform.Rotate(0, 180, 0);

            ResetRevenueToMove();
            btnDown.SetActive(false);
            isMoveDown = true;
            startPositionToDown = transform.position;

            StartCoroutine(DisableKeyE());
        }
    }
    public void StartMoveDownMobile()
    {
        transform.Translate(-15f, 0f, 0f);
        transform.Rotate(0, 180, 0);

        ResetRevenueToMove();
        btnDown.SetActive(false);
        isMoveDown = true;
        startPositionToDown = transform.position;

        StartCoroutine(DisableKeyE());
    }
    private void TopMove()
    {
        Vector3 direction = new Vector3(0, 0, 1).normalized;
        transform.Translate(direction * speed * Time.deltaTime);
    }
    private void MoveDown()
    {
        if (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float percentageComplete = elapsedTime / duration;
            transform.position = Vector3.Lerp(startPositionToDown, targetPositionToDown.position, percentageComplete);
        }
    }
    private IEnumerator DisableKeyE()
    {
        unableKeyE = false;
        yield return new WaitForSeconds(2.8f);
        unableKeyE = true;
    }
    public bool CanMoveTop()
    {
        return isMoveTop;
    }
    public void SetSpeedCart(int index)
    {
        if (index != 0)
        {
            speed = speedDefoult + (index * 2);
        }
        else
        {
            speed = speedDefoult + 1;
        }
    }
    private void RevenueToMove()
    {
        float distanceThisFrame = Vector3.Distance(transform.position, lastPosition);
        totalDistance += distanceThisFrame;
        lastPosition = transform.position;
        _revenueText.text = ShortScaleString.parseFloat(Mathf.Round(totalDistance), 1, 1000, true).ToString();

        scaleHeight.UpdatePointer(Mathf.Round(totalDistance));
    }
    private void ResetRevenueToMove()
    {
        Score.Instance.UpScorePresent(Mathf.Round(totalDistance));
        totalDistance = 0;
        lastPosition = startPos.position;
        _revenueText.text = ShortScaleString.parseFloat(totalDistance, 1, 1000, true).ToString();
    }
}
