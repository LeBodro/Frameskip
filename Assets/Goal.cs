using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    private bool _isColliding = false;
    // Start is called before the first frame update
    void Start()
    {
        _isColliding = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool isColliding()
    {
        return this._isColliding;
    }

    void OnCollisionEnter(Collision collision)
    {
        _isColliding = true;
    }

    void OnCollisionExit(Collision collision)
    {
        _isColliding = false;
    }
}
