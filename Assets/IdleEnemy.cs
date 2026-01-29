using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IdleEnemy : StateMachineBehaviour
{
    Transform plyer;
    float chaseRange = 40;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        plyer = GameObject.FindGameObjectWithTag("Player").transform;
        if (animator.GetComponent<Boss>() != null)
        {
            chaseRange = 60;
        }
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.transform.LookAt(plyer);
        float distanse = Vector3.Distance(animator.transform.position, plyer.position);

        if (distanse < chaseRange)
        {
            animator.SetBool("isChacing", true);
        }
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }
}
