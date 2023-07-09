using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevator2 : MonoBehaviour
{
    private float startingX;
    private float startingY;
    private bool playerOnIt;
    private float x;
    private float y;
    private float timer;
    private int direction;

    void Awake()
    {
        startingX = transform.position.x;
        startingY = transform.position.y;
        playerOnIt = false;
        direction = 0;
    }

    void Update()
    {
        x = transform.position.x;
        y = transform.position.y;

        //Going left
        if(direction == 0){
            if(playerOnIt == true){
                if(x > (startingX - 9) && y < (startingY + 3)){
                    x -= 3f * Time.deltaTime;
                    y += 1f * Time.deltaTime;
                    transform.position = new Vector2(x,y);
                }
                else{
                    direction = 1;
                    playerOnIt = false;
                }
            }
        }

        //Going right
        if(direction == 1){
            if(playerOnIt == true){
                if(x < startingX && y > startingY){
                    x += 3f * Time.deltaTime;
                    y -= 1f * Time.deltaTime;
                    transform.position = new Vector2(x,y);
                }
                else{
                    direction = 0;
                    playerOnIt = false;
                }
            }
        }
        
    }

    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.tag == "Player"){
            playerOnIt = true;
        }
    }
}
