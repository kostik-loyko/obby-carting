using UnityEngine;
using System.Collections;
using TMPro;

public class MoveTop : MonoBehaviour
{
    float speed = 5.0f;
    float speedDefoult = 5.0f;
    private float _speedBonusPet = 1f;
    private float _speedBonusCar = 1f;
    private float _revenuBonusPet = 1f;
    bool isMoveTop = false;
    bool isMoveDown = false;
    bool inStartTriger = false;
    bool inStartTrigerWihtTop = false;
    bool unableKeyE = true;
    [SerializeField] Transform startPos;
    [SerializeField] Transform startPos1;
    [SerializeField] Transform endPos;
    [SerializeField] Transform endPos1;
    [SerializeField] GameObject btnDown;
    [SerializeField] GameObject btnUP;
    [SerializeField] GameObject btnUPmobile;
    [SerializeField] GameObject btnDownWithTop;
    [SerializeField] GameObject btnDownMobileWithTop;

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
        StartMoveDownWithTop();
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
        //if (isMoveDown)
        //{
        //    MoveDown();
        //}
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
    public void OnMoveBottomWithTop()
    {
        if (!inStartTrigerWihtTop)
        {
            inStartTrigerWihtTop = true;
            if (MobileInputManager.Instance.IsMobileDevice())
            {
                btnDownMobileWithTop.SetActive(true);
            }
            else
            {
                btnDownWithTop.SetActive(true);
            }
        }
    }
    public void OffMoveBottomWithTop()
    {
        if (inStartTrigerWihtTop)
        {
            inStartTrigerWihtTop = false;
            if (MobileInputManager.Instance.IsMobileDevice())
            {
                btnDownMobileWithTop.SetActive(false);
            }
            else
            {
                btnDownWithTop.SetActive(false);
            }
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
                ResetRevenueToMove();
                btnDown.SetActive(false);
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
    public void StartMoveDownWithTop()
    {
        if (Input.GetKeyDown(KeyCode.E) && inStartTrigerWihtTop)
        {
            transform.position = startPos1.position;
            transform.rotation = startPos1.rotation;

            isMoveTop = true;
            isMoveDown = true;
            startPositionToDown = transform.position;

            inStartTrigerWihtTop = false;
            btnDownWithTop.SetActive(false);

            StartCoroutine(DisableKeyE());

            EventManager.OnCupSpawn();
        }
    }
    public void StartMoveDownWithTopMobile()
    {
        transform.position = startPos1.position;
        transform.rotation = startPos1.rotation;

        isMoveTop = true;
        isMoveDown = true;
        startPositionToDown = transform.position;

        inStartTrigerWihtTop = false;
        btnDownMobileWithTop.SetActive(false);

        StartCoroutine(DisableKeyE());

        EventManager.OnCupSpawn();
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
        yield return new WaitForSeconds(2.9f);
        unableKeyE = true;
    }
    public bool CanMoveTop()
    {
        return isMoveTop;
    }
    public void SetSpeedCart(int indexCar)
    {
        if (indexCar == 0)
        {
            _speedBonusCar = speedDefoult + 1;
        }
        if(indexCar >= 1 && indexCar < 5)
        {
            _speedBonusCar = speedDefoult + (indexCar * 3);
        }
        if (indexCar >= 5 && indexCar < 10)
        {
            _speedBonusCar = speedDefoult + (indexCar * 5);
        }
        if (indexCar >= 10 && indexCar < 20)
        {
            _speedBonusCar = speedDefoult + (indexCar * 10);
        }
        if (indexCar >= 20)
        {
            _speedBonusCar = speedDefoult + (indexCar * 15);
        }
        print("_speedBonusCar " + _speedBonusCar);
        SetSpeed();
    }
    public void SetSpeedPet(int indexPet)
    {
        if (indexPet == 0)
        {
            _speedBonusPet = 5;
        }
        else
        {
            _speedBonusPet = indexPet * 10;
        }
        print("petBonus " + _speedBonusPet);
        SetSpeed();
    }
    private void SetSpeed()
    {
        speed = _speedBonusPet + _speedBonusCar;
        print("totalSpeed " + speed);
    }
    public void SetBonusRevenuePet(int indexPet)
    {
        if (indexPet == 0)
        {
            _revenuBonusPet = 1;
        }
        else
        {
            _revenuBonusPet = indexPet;
        }
        
        print("petBonusRevenue " + _revenuBonusPet);
    }
    private void RevenueToMove()
    {
        float distanceThisFrame = Vector3.Distance(transform.position, lastPosition);
        totalDistance += distanceThisFrame;
        lastPosition = transform.position;
        _revenueText.text = ShortScaleString.parseFloat(Mathf.Round(totalDistance * _revenuBonusPet), 1, 1000, true).ToString();

        scaleHeight.UpdatePointer(Mathf.Round(totalDistance));
    }
    private void ResetRevenueToMove()
    {
        Score.Instance.UpScorePresent(Mathf.Round(totalDistance * _revenuBonusPet));
        totalDistance = 0;
        lastPosition = startPos.position;
        _revenueText.text = ShortScaleString.parseFloat(totalDistance, 1, 1000, true).ToString();
    }
    public void SetSpeedPet(ref float speedPet)
    {
        speedPet = speed;
    }
}
