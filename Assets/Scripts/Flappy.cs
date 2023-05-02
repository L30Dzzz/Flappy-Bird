using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using

public class Flappy : MonoBehaviour
{
    Rigidbody2D flappy;  
    int score = 0;
    public Text scoreUI;
    
    //true or false for when flappy is alive
    public bool isAlive;

    // Start is called before the first frame update
    void Start()
    {
        flappy = GetComponent<Rigidbody2D>();
        //set alive to true
        isAlive = true;
    }

    
    void Update()
    {
        //---Jumping---
        if(Input.GetKeyDown(KeyCode.Space) && isAlive)
        {
            flappy.AddForce(new Vector2(0,1) * 400);
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

       void OnCollisionEnter2D(Collision2D other)
        {
            isAlive = false;

            GameOverScreen GameOverScreenScript = GameObject.Find("GameOverScreen").GetComponent<GameOverScreen>();
        }
    
}
