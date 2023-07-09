using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy2 : MonoBehaviour
{
    private float speed = -1f;

    [SerializeField]
    private float distance;

    private float start;

    private float end;

    private Vector2 tempPos;

    private float tempScale;

    private Transform incognito;

    private SpriteRenderer sr;

    void Awake()
    {
        GameObject player = GameObject.FindWithTag("Player");
        incognito = player.GetComponent<Transform>();
        tempScale = transform.localScale.x;
        sr = GetComponent<SpriteRenderer>();
        start = transform.position.x;
        end = transform.position.x + distance;
    }

    void Update()
    {
        tempPos = transform.position;
        tempPos.x += speed * Time.deltaTime;
        transform.position = tempPos;

        if(tempPos.x > end){
            speed = -1f;
            sr.flipX = false;
        }

        if(tempPos.x < start){
            speed = 1f;
            sr.flipX = true;
        }
    }

}