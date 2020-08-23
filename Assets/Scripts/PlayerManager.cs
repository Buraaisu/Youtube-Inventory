using System.Collections;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    Vector3 moveInput;
    Vector3 moveVelocity;
    Rigidbody rBody;
    public float moveSpeed = 4;

    public Transform hand;
    public Transform body;

    void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }
    void Update()
    {
            moveInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveVelocity = moveInput * moveSpeed;
    }
    void FixedUpdate()
    {
        rBody.velocity = moveVelocity;
    }
}
