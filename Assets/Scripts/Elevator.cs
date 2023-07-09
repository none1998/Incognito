using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    private float speed = 3f;

    private Vector2 tempPos;

    void Awake()
    {
        
    }

    void Update()
    {
        tempPos = transform.position;
        tempPos.x += speed * Time.deltaTime;
        transform.position = tempPos;
    }

    void OnCollisionEnter2D(Collision2D other1){
        if(other1.gameObject.tag == "ElevStop"){
            speed *= -1;
        }
    }
}
