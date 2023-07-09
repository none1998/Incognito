using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift2 : MonoBehaviour
{
    public Transform posA, posB;
    public int speed;
    Vector2 targetPos;
    private bool playerOnIt;
    private bool reset;
    public GameObject incognito;

    public Sprite liftOff, liftOn;

    void Awake()
    {
        playerOnIt = false;
        incognito = GameObject.Find("Incognito");
    }

    void Start()
    {
        targetPos = posA.position;
    }

    void Update()
    {
        if(Vector2.Distance(transform.position, posA.position)<.1f){
            // playerOnIt = false;
            // targetPos = posB.position;
        }
        if(Vector2.Distance(transform.position, posB.position)<.1f){
            // playerOnIt = false;
            // targetPos = posA.position;
        }
        if(playerOnIt == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
            GetComponent<SpriteRenderer>().sprite = liftOn;
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = liftOff;
        }
    }

    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.tag == "Player"){
            playerOnIt = true;
            other.transform.SetParent(this.transform);
            Incognito.canMove = true;
        }
    }
    void OnCollisionExit2D(Collision2D other){
        if(other.gameObject.tag == "Player"){
            other.transform.SetParent(null);
            Incognito.canMove = true;
        }
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.name == "posA"){
            playerOnIt = false;
            targetPos = posB.position;
        }
        if(other.gameObject.name == "posB"){
            playerOnIt = false;
            targetPos = posA.position;
        }
    }
    
}
