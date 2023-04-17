using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flappy : MonoBehaviour
{
    Rigidbody2D flappy;  
    
    // Start is called before the first frame update
    void Start(){
        flappy = GetComponent<Rigidbody2D> ();
    }

    
    void Update()
    {
        //---Jumping---
        if(Input.GetKeyDown(KeyCode.Space)){
            flappy.AddForce(new Vector2(0,1) * 200);
        }
    }
}
