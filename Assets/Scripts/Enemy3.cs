using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : MonoBehaviour
{
    public float distance, speed;

    private float startPos, endPos, tempPos;

    private bool isGoingRight;

    void Awake()
    {
        startPos = transform.position.x;
        endPos = transform.position.x - distance;
        isGoingRight = false;
    }

    void Update()
    {
        tempPos = transform.position.x;

        if(tempPos <= endPos)
        isGoingRight = true;
        else if(tempPos >= startPos)
        isGoingRight = false;

        if(isGoingRight == true)
        {
            tempPos += speed * Time.deltaTime;
            transform.localScale = new Vector2(-0.3f, transform.localScale.y);
        }
        else if(isGoingRight == false)
        {
            tempPos -= speed * Time.deltaTime;
            transform.localScale = new Vector2(0.3f, transform.localScale.y);
        }

        transform.position = new Vector2(tempPos, transform.position.y);
    }
}
