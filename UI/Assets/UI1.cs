using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI1 : MonoBehaviour {
    int health;

    void Start(){
        health=100;
    }

	void OnGUI (){
        if (GUI.Button(new Rect(50, 50, 50, 50), "+"))
        {
            health+=10;
            if(health>100) health=100;
        }
        if (GUI.Button(new Rect(50, 100, 50, 50), "-"))
        {
            health-=10;
            if(health<0) health=0;
        }

        Vector3 worldPos = new Vector3(transform.position.x, transform.position.y + 2.2f, transform.position.z );
        Vector2 screenPos = Camera.main.WorldToScreenPoint(worldPos);
        Rect rect = new Rect(screenPos.x - 50, Screen.height - screenPos.y,100,100);
        GUI.HorizontalScrollbar(rect, 0, health, 0, 100);
	}
}