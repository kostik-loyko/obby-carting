using UnityEngine;

public class MoveTop : MonoBehaviour
{
    float speed = 5.0f;
    bool isMoveTop = false;

    void Update()
    {
        if (isMoveTop)
        {
            Vector3 direction = new Vector3(0, 1, 1).normalized;
            transform.Translate(direction * speed * Time.deltaTime);
        }
    }
    public void OnMoveTop()
    {

        isMoveTop = true;
    }
    public bool CanMoveTop()
    {
        return isMoveTop;
    }
}
