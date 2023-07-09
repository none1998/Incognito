using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow1 : MonoBehaviour
{
    private Transform player;
    
    private Vector3 tempPos;

    public float XMin, XMax;

    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    void LateUpdate()
    {   
        if(player != null)
        {
            tempPos = transform.position;

            if(player.position.x > XMin && player.position.x < XMax){
                tempPos.x = player.position.x + 3;
                transform.position = tempPos;
            }
            if(player.position.y > -8f && player.position.y < 8f){
                tempPos.y = player.position.y + 3;
                transform.position = tempPos;
            }
        }
    }
}