using UnityEngine;

public class DestroyTree : MonoBehaviour
{
    private void OnEnable()
    {
        EventManager.treeRemove += TreeDestroy;
    }
    private void OnDisable()
    {
        EventManager.treeRemove -= TreeDestroy;
    }

    private void TreeDestroy()
    {
        Destroy(gameObject);
    }
}
