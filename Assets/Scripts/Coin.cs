using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private Vector3 tempRot;

    private AudioSource coinSound;

    public static int incognitoScore = 0;

    void Awake()
    {
        GameObject audio = GameObject.FindWithTag("Audio");
        if(audio != null){
            coinSound = audio.GetComponent<AudioSource>();
        }
        tempRot.y = transform.rotation.y;
        Debug.Log("Score: " + incognitoScore);
    }

    void Update()
    { 
        CoinRotation();
    }

    void CoinRotation(){
        tempRot.y ++;
        transform.rotation = Quaternion.Euler(transform.rotation.x, tempRot.y, transform.rotation.z);
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Player"){
            incognitoScore += 1;
            //Debug.Log("Score: " + incognitoScore);
            this.gameObject.SetActive(false);
            coinSound.Play();
            //Destroy(this.gameObject, 3f);
        }
    }
}