using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerGame : MonoBehaviour {
    public GameObject[] Boxes;
    public GameObject[] Lights;
    private float timer;
    private bool begun;
    private int prev;
    public int curr;
    public int point;
    public Text Score1, Score2, Score3, Score4;

    private void Start() {
        /*
        int i = 0;
        Lights = new GameObject[4];
        foreach(GameObject GO in Boxes) {
            Lights[i] = GO.GetComponentInChildren<GameObject>();
            i++;
        }
        */
        timer = 0f;
        begun = false;
        prev = 0;
        curr = 0;
        point = 0;
        Score1.text = "Points: 0";
        Score2.text = "Points: 0";
        Score3.text = "Points: 0";
        Score4.text = "Points: 0";
    }

    
    private void FixedUpdate() {
        timer += Time.fixedDeltaTime;
        if(!begun) {RunGame();}
    }

    private void RunGame() {
        if(timer >= 3) { timer = 0; LightRandomly(); }
    }

    public void GetPoint() {
        Score1.text = "Points: " + ++point;
        Score4.text = Score3.text = Score2.text = Score1.text;
        timer = 0f;
        LightRandomly();
    }

    private void LightRandomly() {
        prev = curr;
        curr = Random.Range(0, 4);
        if(curr == prev) {
            curr--;
            if(curr < 0) {curr = 3;}
        }
        Lights[prev].SetActive(false);
        Lights[curr].SetActive(true);
    }
}
