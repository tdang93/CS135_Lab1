using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightswitch : MonoBehaviour{
    // Start is called before the first frame update
    int counter = 0;
    void Start(){
        light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update(){
        if (Input.GetKeyDown("tab")){
            counter++;
            if(counter == 1)
            {
                light.color = red;
            }
            else if (counter == 2)
            {
                light.color = blue;
            }
            else if (counter == 3)
            {
                light.color = green;
                counter = 0;
            }
            else
            {
                light.color = purple;
            }
        }
    }
}
