using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float sensitivity = 500;
    public float speed = 2.33f;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X") * Time.fixedDeltaTime * sensitivity, 0);
        Vector3 Movement = new Vector3 (Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;
        if (Movement.sqrMagnitude != 0) {
            Movement = transform.TransformDirection(Movement);
        }
        rb.MovePosition(transform.position + Movement * speed * Time.fixedDeltaTime);
        rb.velocity = Vector3.zero;
    }
}
