using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Player : MonoBehaviour {
    public TriggerGame TG;
    private bool A_pressed;
    private bool B_pressed;

    private void Start() {
        A_pressed = false;
        B_pressed = false;
    }

    private void Update() {
        if(Input.GetKey(KeyCode.A)) {A_pressed = true;}
        else {A_pressed = false;}
        if(Input.GetKeyDown(KeyCode.B)) {B_pressed = true;}
    }

    private void FixedUpdate() {
        if(B_pressed) {
            Application.Quit(); 
            EditorApplication.isPlaying = false;
            Debug.Log("\"B\" pressed. Quitting the game!");
        }
    }

    private void OnTriggerStay(Collider other) {
        int num = (other.name[4] - 49);
        //Debug.Log("number: " + num);
        if(A_pressed && TG.curr == num) {TG.GetPoint();}
    }
}
