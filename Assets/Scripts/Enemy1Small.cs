using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy1Small : MonoBehaviour
{
    private float speed = 1f;

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
        if(incognito.transform.position.x < transform.position.x){
            tempPos.x -= speed * Time.deltaTime;
        }
        else if(incognito.transform.position.x > transform.position.x){
            tempPos.x += speed * Time.deltaTime;
        }
        if(incognito.transform.position.y < transform.position.y){
            tempPos.y -= speed * Time.deltaTime;
        }
        else if(incognito.transform.position.y > transform.position.y){
            tempPos.y += speed * Time.deltaTime;
        }
        transform.position = tempPos;

    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Player"){
            Destroy(this.gameObject);
        }
    }

}