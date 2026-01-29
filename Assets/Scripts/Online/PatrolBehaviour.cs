using UnityEngine.AI;
using System.Collections.Generic;
using UnityEngine;

public class PatrolBehaviour : StateMachineBehaviour
{
    float timer;
    List<Transform> points = new List<Transform>();
    NavMeshAgent agent;
    Transform pointsObject;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        points.Clear();
        timer = 0;
        if (animator.GetComponent<AI>())
        {
            pointsObject = GameObject.FindGameObjectWithTag("Points").transform;
        }
        if (animator.GetComponent<AI1>())
        {
            pointsObject = GameObject.FindGameObjectWithTag("Points1").transform;
        }
        if (animator.GetComponent<AI2>())
        {
            pointsObject = GameObject.FindGameObjectWithTag("Points2").transform;
        }
        if (animator.GetComponent<AI3>())
        {
            pointsObject = GameObject.FindGameObjectWithTag("Points3").transform;
        }
        if (animator.GetComponent<AI4>())
        {
            pointsObject = GameObject.FindGameObjectWithTag("Points4").transform;
        }
        if (animator.GetComponent<AI5>())
        {
            pointsObject = GameObject.FindGameObjectWithTag("Points5").transform;
        }

        foreach (Transform t in pointsObject)
            points.Add(t);

        agent = animator.GetComponent<NavMeshAgent>();
        agent.SetDestination(points[0].position);
        //Debug.Log(points[Random.Range(0, points.Count)]);
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            int a = Random.Range(0, points.Count);

            agent.SetDestination(points[a].position);
        }

        timer += Time.deltaTime;
        if (timer > 30)
            animator.SetBool("isPatrolling", false);
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        agent.SetDestination(agent.transform.position);
    }
}
