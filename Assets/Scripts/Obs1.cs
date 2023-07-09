using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obs1 : MonoBehaviour
{
    private Vector3 tempRot;

    private Transform incognito;

    void Awake()
    {
        tempRot.z = transform.rotation.z;

        GameObject player = GameObject.FindWithTag("Player");
        incognito = player.GetComponent<Transform>();
    }

    void Update()
    { 
        Obs1Rotation();
    }

    void Obs1Rotation(){
        tempRot.z += 2;
        transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, tempRot.z);
    }

    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.tag == "Player"){
            Health.incognitoHealth --;
            incognito.transform.position = Incognito.startingPosition;
        }
    }
}