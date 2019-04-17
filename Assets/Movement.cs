using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float sensitivity = 500;
    public float speed = 2.33f;
    public Rigidbody body;

    public event System.Action OnDeath;

    public void reset(Vector3 position)
    {
        transform.rotation = Quaternion.identity;
        transform.position = position;
    }

    void FixedUpdate()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X") * Time.fixedDeltaTime * sensitivity, 0);
        Vector3 Movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;
        if (Movement.sqrMagnitude != 0)
        {
            Movement = transform.TransformDirection(Movement);
        }
        body.MovePosition(body.position + Movement * speed * Time.fixedDeltaTime);
        body.velocity = Vector3.zero;
    }

    void OnCollisionEnter(Collision col)
    {
        //check layer
        if (false)
        {
            OnDeath();
        }
    }
}
