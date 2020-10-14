using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightswitch : MonoBehaviour{
    // Start is called before the first frame update
    int counter = 0;
    void Start(){
        GetComponent<Light>();
    }

    // Update is called once per frame
    void Update(){
        if (Input.GetKeyDown("tab")){
            counter++;
            if(counter == 1)
            {
                GetComponent<Light>().color = Color.red;
            }
            else if (counter == 2)
            {
                GetComponent<Light>().color = Color.blue;
            }
            else if (counter == 3)
            {
                GetComponent<Light>().color = Color.green;
                counter = 0;
            }
            else
            {
                GetComponent<Light>().color = Color.white;
            }
        }
    }
}
