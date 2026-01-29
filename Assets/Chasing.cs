using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Chasing : StateMachineBehaviour
{
    NavMeshAgent agent;
    Transform plyer;
    float chaseRange = 40;
    float timer;
    Enemy enemy;
    Boss boss;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        agent = animator.GetComponent<NavMeshAgent>();
        if (animator.GetComponent<Enemy>() != null )
        {
            enemy = animator.GetComponent<Enemy>();
            enemy.SoundEnemy();
        }
        if (animator.GetComponent<Boss>() != null)
        {
            boss = animator.GetComponent<Boss>();
            chaseRange = 60;
            boss.SoundEnemy();
        }
        plyer = GameObject.FindGameObjectWithTag("Player").transform;
        agent.speed = 2f;
        timer = 0;
        SoundManager.Instance.back.volume = 0.3f;
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        agent.SetDestination(plyer.position);
        float distanse = Vector3.Distance(animator.transform.position, plyer.position);

        timer += Time.deltaTime;
        if (timer > 2.5f)
        {
            if (enemy != null)
            {
                enemy.Shoot();
            }
            if (boss != null)
            {
                boss.Shooting();
            }
            timer = 0;
        }

        if (distanse > chaseRange)
        {
            animator.SetBool("isChacing", false);
            SoundManager.Instance.back.volume = 1f;
        }
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        agent.SetDestination(agent.transform.position);
        agent.speed = 0;
    }
}
