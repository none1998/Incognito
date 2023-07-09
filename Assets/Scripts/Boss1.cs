using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Boss1 : MonoBehaviour
{
    public float tempPosY;

    public GameObject player;

    public Vector2 playerPos;

    private float timer;

    private Animator animator;

    public GameObject bullet;

    public Transform bulletPos;

    public GameObject smallEnemy;

    public Transform smallPos1;
    // public Transform smallPos2;
    // public Transform smallPos3;


    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.FindWithTag("Player");
        animator = GetComponent<Animator>();
    }

    void Start(){
        StartCoroutine(coroutineA());
        StartCoroutine(coroutineB());
    }
    
    // Update is called once per frame
    void Update()
    {
        playerPos = player.transform.position;

        if(playerPos.y + 0.5f > transform.position.y){
            animator.SetBool("attackParam", false);
            tempPosY += 0.008f;
            transform.position = new Vector2(transform.position.x, tempPosY);   
        }
        else if(playerPos.y + 0.5f < transform.position.y){
            animator.SetBool("attackParam", false);
            tempPosY -= 0.008f;
            transform.position = new Vector2(transform.position.x, tempPosY);   
        }
        if(Math.Round(playerPos.y + 0.5f,1) == Math.Round(transform.position.y,1)){
            // animator.SetBool("attackParam", true);
            // Shoot();
        }
        
    }

    IEnumerator coroutineA()
    {
        while (true){
                yield return new WaitForSeconds(3.0f);
                if(Incognito.isLoading == false)
                animator.SetBool("attackParam", true);
                Shoot(); 
        }
        
    }

    IEnumerator coroutineB()
    {
        while (true){
                yield return new WaitForSeconds(10f);
                createSmallEnemies(); 
        }
        
    }

    void Shoot() {
        if(Incognito.isLoading == false)
        Instantiate(bullet, bulletPos.position, Quaternion.identity);
    }

    void createSmallEnemies(){
        if(Incognito.isLoading == false)
        Instantiate(smallEnemy, smallPos1.position, Quaternion.identity);
        //Instantiate(smallEnemy, smallPos2.position, Quaternion.identity);
        //Instantiate(smallEnemy, smallPos3.position, Quaternion.identity);
    }

}
