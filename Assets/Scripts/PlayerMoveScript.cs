using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMoveScript : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform orientation;

    public Joystick jstk;

    public float moveSpd;

    public Vector3 moveDirect;

    public float xInput;
    public float yInput;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        walk();
    }

    public void walk()
    {
        xInput = jstk.Horizontal;
        yInput = jstk.Vertical;

        moveDirect = transform.position + transform.right * xInput + transform.forward * yInput;
        agent.destination = moveDirect;
    }
}
