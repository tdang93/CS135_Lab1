using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class room_switch : MonoBehaviour
{
    private Transform t;
    // Start is called before the first frame update
    void Start()
    {
        t = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update(){
        if (Input.GetKeyDown("1"))
        {
            transform.position = new Vector3(6, 11, 21);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            #else
                        Application.Quit();
            #endif
        }
    }

}

