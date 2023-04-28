using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{   
    public float speed = 5.0f;

    void Start()
    {
        
    }

    void Update()
    {
        //---Pipe Movement (Left)---
        transform.Translate(Vector2.left * Time.deltaTime * speed);

        //---Pipe Destroyer Offscreen---
        if (transform.position.magnitude > 20f)
        {
            Destroy(gameObject);
        }
    }
}
