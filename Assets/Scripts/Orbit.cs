using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public float speed;
    private Transform t;
    private void Start() { t = GetComponent<Transform>(); if(speed == 0){ speed = 1;} }
    private void FixedUpdate() {
        /*
        Vector3 rot = t.rotation.eulerAngles;
        rot.y += 5;
        t.rotation = Quaternion.Euler(rot.x, rot.y, rot.z);
        */    
        t.Rotate(0, 1 * speed, 0);
    }
}
