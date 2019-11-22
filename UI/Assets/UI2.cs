using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI2 : MonoBehaviour {
    public Canvas mycanvas;
    public Slider myslider;
    public bool increase;

    void Start () {
        increase=true;     

    }

    void Update () {

        Vector3 worldPos = new Vector3(transform.position.x, transform.position.y + 2.2f, transform.position.z);
        Vector3 screenPos = Camera.main.WorldToScreenPoint(worldPos);
        myslider.transform.position = new Vector3(screenPos.x, screenPos.y , screenPos.z);
        
        if(increase){
            myslider.value+=0.5f;
        }
        else{
            myslider.value-=0.5f;
        }
        if(myslider.value>=80) increase=false;
        if(myslider.value<=20) increase=true;
    }
}