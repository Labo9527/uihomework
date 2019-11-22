using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Me : MonoBehaviour
{
    public int test;

    public Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
        test=1;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate(){

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        //Debug.Log(x+z);

        if(transform.position.z>21){
            z=z>0?0:z;
        }
        if(transform.position.z<12){
            z=z<0?0:z;
        }
        if(transform.position.x>5){
            x=x>0?0:x;
        }
        if(transform.position.x<-5){
            x=x<0?0:x;
        }        

        Vector3 v = new Vector3(x, 0, z);


        if (x!=0 || z!=0) {
            ani.SetBool("running", true);
            //Debug.Log(x+z);
            Quaternion rotation = Quaternion.LookRotation(v);
            if (transform.rotation != rotation) transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.fixedDeltaTime * 15f);
        }
        else{
            ani.SetBool("running", false);
        }
        transform.position += v * Time.fixedDeltaTime * 5f;
    }

    private void OnTriggerEnter(Collider other) {
 
    }
}
