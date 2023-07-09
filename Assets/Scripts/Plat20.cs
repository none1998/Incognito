using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plat20 : MonoBehaviour
{
    private float timer, timer2;
    private Vector2 startingPos;

    void Awake()
    {
        timer = 4f;
        startingPos = transform.position;
    }

    void Update()
    {
        if(this.gameObject.name == "PlatT2")
        {
            timer -= Time.deltaTime;
            if(timer < 2f && timer > 0f){
                transform.position = startingPos;
            }
            else if(timer < 0f){
                timer = 4f;
                transform.position = new Vector2(1000,1000);
            }
        }
        else
        {
            timer -= Time.deltaTime;
            if(timer < 2f && timer > 0f){
                transform.position = new Vector2(1000,1000);
            }
            else if(timer < 0f){
                timer = 4f;
                transform.position = startingPos;
            }
        }
    }
}