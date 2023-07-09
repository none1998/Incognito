using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBlue : MonoBehaviour
{
    public string name;

    private Transform incognito;

    public GameObject red1;
    public GameObject red2;
    public GameObject red3;

    void Awake()
    {
        name = this.gameObject.name.Substring(1,1);
        GameObject player = GameObject.FindWithTag("Player");
        incognito = player.GetComponent<Transform>();
    }

    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other){

        if(this.gameObject.name.Substring(0,1) == "R"){

            if(other.gameObject.tag == "Player"){
            incognito.transform.position = Incognito.startingPosition;
            Health.incognitoHealth -= 1;
            }
        }

        
        if(this.gameObject.name.Substring(0,1) == "B"){

            if(other.gameObject.tag == "Player"){
                Destroy(this.gameObject);
                red1 = GameObject.Find("R" + name + "_1");
                red2 = GameObject.Find("R" + name + "_2");
                red3 = GameObject.Find("R" + name + "_3");
                if(red1 is not null)
                Destroy(red1);
                if(red2 is not null)
                Destroy(red2);
                if(red3 is not null)
                Destroy(red3);
            }

        }
    }
}