using UnityEngine;
using System.Collections;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemiesMovement : MonoBehaviour {

    public GameObject[] wayPoints;
    PlayerDetector playerC;
    Vector3 currentWaypoint;
    NavMeshAgent agent;
    private bool done = true;
    public bool waiting;
    public int maxRange;
    int randomNumber;
    // Use this for initialization
    void Start () {
        playerC = GetComponent<PlayerDetector>();
        agent = GetComponent<NavMeshAgent>();
    }
	
	// Update is called once per frame
	void Update () {
        if(!playerC.isDetected)
        {
            if (done)
            {
                done = false;
                waiting = true;
                StartCoroutine(NewGoalDelay());
                changeGoal();
            }
        }
    }
    void changeGoal()
    {
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
