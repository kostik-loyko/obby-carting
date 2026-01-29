using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PatrulBr : MonoBehaviour
{
    public Transform[] points;
    private int destPoint = 0;
    private NavMeshAgent agent;
    [SerializeField] int patrolSpeed;
    [SerializeField] Transform player;
    [SerializeField] TriggerSleep sleep;
    [SerializeField] GameObject sleepSign;
    [SerializeField] GameObject patrolSign;
    [SerializeField] GameObject chasingSign;

    private bool chasing = false;

    [SerializeField] Animator animator;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.autoBraking = false;

        GotoNextPoint();
    }


    void GotoNextPoint()
    {
        if (points.Length == 0)
            return;

        agent.destination = points[destPoint].position;

        destPoint = (destPoint + 1) % points.Length;
    }


    void Update()
    {
        if (sleep.GetSleep())
        {
            animator.SetBool("run", false);
            agent.speed = 0;
            ShowSleepSing();
            return;
        }
        agent.speed = patrolSpeed;
        animator.SetBool("run", true);
        ShowPatrolSing();

        if (chasing)
        {
            ShowChasingSing();
            ChasingPlayer();
            agent.speed = PlayerBehavior.Instance.velocity;
        }

        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {            
            GotoNextPoint();
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerController>())
        {
            chasing = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerController>())
        {
            chasing = false;
            GotoNextPoint();
        }
    }

    public void ChasingPlayer()
    {
        agent.destination = player.position;
    }
    public void ShowSleepSing()
    {
        sleepSign.SetActive(true);
        patrolSign.SetActive(false);
        chasingSign.SetActive(false);
    }
    public void ShowPatrolSing()
    {
        sleepSign.SetActive(false);
        patrolSign.SetActive(true);
        chasingSign.SetActive(false);
    }
    public void ShowChasingSing()
    {
        sleepSign.SetActive(false);
        patrolSign.SetActive(false);
        chasingSign.SetActive(true);
    }
}
