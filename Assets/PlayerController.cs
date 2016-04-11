using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float moveSpeed = 10f;
    public float drag = 0.5f;
    public float terminalRotationSpeed = 25.0f;
    public Vector3 MoveVector { set; get; }
    public VirtualJoystick joystick;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        MoveVector = PoolInput();

        Move();
    }

    private void Move()
    {
        transform.Translate(MoveVector * moveSpeed * Time.deltaTime);   
    }

    private Vector3 PoolInput()
    {
        float rotationSpeed = 10f;
        Vector3 dir = Vector3.zero;

        dir.x = joystick.Horizontal();
        dir.z = joystick.Vertical();

        if (dir != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(
                transform.rotation,
                Quaternion.LookRotation(dir),
                Time.deltaTime * rotationSpeed
            );
        }

        if (dir.magnitude > 1)
            dir.Normalize();

        return dir;
    }
}

