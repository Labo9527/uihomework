using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Resources.Load("Prefabs/AcquireChan"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
