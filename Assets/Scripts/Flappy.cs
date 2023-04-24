using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flappy : MonoBehaviour
{
    Rigidbody2D flappy;  
    int score = 0;
    public Text scoreUI;
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

    void OnTriggerEnter2D (Collider2D other)
    {
        if(other.gameObject.CompareTag("Points"))
        {
        score++;
        Debug.Log(score);
        scoreUI.text = score.ToString();
        }
    } 

       
    
}
