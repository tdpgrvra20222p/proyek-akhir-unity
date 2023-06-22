using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collided : MonoBehaviour
{
    
    bool Trigger1;
    bool Trigger2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "DropArea"){
            Destroy(col.gameObject);
        }
       
    }
    void OnCollisionStay(Collision col)
    {
        if(col.gameObject.name == "DropArea"){
            Destroy(col.gameObject);
        }
       
    }

    void Update () {
        
    }
}
