using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDropScript : MonoBehaviour
{
    public GameObject b;
    void OnTriggerEnter(Collider other)
    {
        b.GetComponent<Rigidbody>().useGravity = true;
    }
}

