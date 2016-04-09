using UnityEngine;
using System.Collections;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyMovement : MonoBehaviour {

    public GameObject[] wayPoints;
    PlayerDetector playerC;
    Vector3 currentWaypoint;
    NavMeshAgent agent;
    private bool done = true;
    public bool waiting;
    public int maxRange;
    int randomNumber;
    // Use this for initialization
    void Start()
    {
        playerC = GetComponent<PlayerDetector>();
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((!playerC.isDetected)&&(!playerC.isClose))
        {
            agent.Resume();

            //Debug.Log("is detected: " + playerC.isDetected + " is close: " + playerC.isClose + "\n");
            if (done)
            {
                done = false;
                waiting = true;
                StartCoroutine(NewGoalDelay());
                changeGoal();
            }
        }
        else
        {
            agent.Stop();
            //Debug.Log("is detected: " + playerC.isDetected + " is close: " + playerC.isClose + "\n");
        }
    }
    void changeGoal()
    {
        Debug.Log("Change goal: " + Time.time);
        int randomNumber = Random.Range(1, maxRange);
        if (currentWaypoint != wayPoints[randomNumber - 1].transform.position)
        {
            currentWaypoint = wayPoints[randomNumber - 1].transform.position;
            agent.destination = currentWaypoint;
        }
        else
        {
            changeGoal();
        }

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Goal")
        {
            done = true;
        }
    }

    IEnumerator NewGoalDelay()
    {
        yield return new WaitForSeconds(2f);
        waiting = false;
    }
}
