using UnityEngine;

public class MoveTop : MonoBehaviour
{
    float speed = 5.0f;
    bool isMoveTop = false;
    bool inStartTriger = false;
    [SerializeField] Transform startPos;
    [SerializeField] Transform endPos;
    [SerializeField] GameObject btnDown;
    [SerializeField] GameObject btnUP;

    void Update()
    {
        StartMoveTop();
        if (isMoveTop)
        {
            Vector3 direction = new Vector3(0, 0, 1).normalized;
            transform.Translate(direction * speed * Time.deltaTime);
            if (Input.GetKeyDown(KeyCode.E))
            {
                transform.Translate(-15f, 0f, 0f);
                transform.Rotate(0, 180, 0);
                btnDown.SetActive(false);
            }
        }
    }
    public void OnMoveTop()
    {
        if (!inStartTriger)
        {
            inStartTriger = true;
            btnUP.SetActive(true);
        }
        //if (Input.GetKeyDown(KeyCode.F))
        //{
        //    transform.position = startPos.position;
        //    transform.rotation = startPos.rotation;
        //    Carts.Instance.SetCartMove();
        //    btnUP.SetActive(false);
        //    btnDown.SetActive(true);
        //    inStartTriger = false;
        //    isMoveTop = true;
        //}
    }
    public void OffMoveTop()
    {
        if (inStartTriger)
        {
            inStartTriger = false;
            btnUP.SetActive(false);
        }
    }
    public void StopMove()
    {
        if (isMoveTop)
        {
            isMoveTop = false;
            transform.position = endPos.position;
            transform.rotation = endPos.rotation;
            Carts.Instance.SetCartMove();
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
            btnDown.SetActive(true);
            inStartTriger = false;
            isMoveTop = true;
        }
    }
    public bool CanMoveTop()
    {
        return isMoveTop;
    }
}
