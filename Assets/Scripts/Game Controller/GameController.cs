using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int points = 0;
    public Text txt;
    int count;
    public Spawn spn; 

    void Start(){
        count = 0;
    }

    void FixedUpdate()
    {
        if(count < 1){
            spn.SpawnNow();
            count++;
        }
    }

    public void subtractCount(){

        points++;
        txt.text = "Sanduiches: "+points;
        count--;
    }
}
