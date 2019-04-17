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

    void ChasePlayer()
    {
        Vector3 direction = (player.position - transform.position).normalized;
        body.velocity = direction * speed * Time.fixedDeltaTime;
        transform.LookAt(player);
    }
}
