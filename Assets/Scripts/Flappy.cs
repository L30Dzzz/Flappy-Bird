using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flappy : MonoBehaviour
{
    Rigidbody2D flappy;  
    
    int score = 0;
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

    private void OnTriggerEnter2D (Collider2D other)
    {
        score++;
        Debug.Log(score);
    } 
}
