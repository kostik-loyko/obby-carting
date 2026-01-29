using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycast : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject hitFX;
    [SerializeField] LayerMask layerMask;

    public void GatherResource()
    {
        RaycastHit hit;
        Ray ray = new Ray(player.transform.position, player.transform.forward);

        if (Physics.Raycast(ray, out hit, 1.5f, layerMask))
        {
            if (hit.collider.GetComponent<Tree>())
            {
                hit.collider.GetComponent<Tree>().CutTree();
            }
            if (hit.collider.GetComponent<Trash>())
            {
                hit.collider.GetComponent<Trash>().CutTrash();
            }
            if (hit.collider.GetComponent<LightRoad>())
            {
                hit.collider.GetComponent<LightRoad>().CutLightRoad();
            }
            if (hit.collider.GetComponent<Wall>())
            {
                hit.collider.GetComponent<Wall>().CutEgg();
            }
            Instantiate(hitFX, hit.point, Quaternion.LookRotation(hit.normal));
        }
    }
}
