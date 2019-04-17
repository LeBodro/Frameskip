using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GilleLeMonstre : MonoBehaviour
{
    public Transform player;
    public float speed = 1.33f;
    public Rigidbody body;

    void FixedUpdate()
    {
        ChasePlayer();
    }

    public void reset(Vector3 position)
    {
        transform.position = position;
    }

    void ChasePlayer()
    {
        transform.rotation = player.rotation;
        Vector3 direction = (player.position - transform.position).normalized;
        body.MovePosition(body.position + direction * speed * Time.fixedDeltaTime);
    }
}
