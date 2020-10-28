using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDropScript : MonoBehaviour
{
    public GameObject ball;
    void OnTriggerEnter(Collider other)
    {
        ball.GetComponent<Rigidbody>();
        ball.rigidbody.useGravity = true;
    }

}

