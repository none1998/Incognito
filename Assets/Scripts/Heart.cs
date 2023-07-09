using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    private Vector3 tempScale;

    private AudioSource heartSound;

    private bool timeSwitch;

    void Awake()
    {
        timeSwitch = true;
        GameObject audio = GameObject.FindWithTag("AddHeart");
        heartSound = audio.GetComponent<AudioSource>();

        tempScale = transform.localScale;
    }

    void Update()
    {
        if(tempScale.x < 0.23f && timeSwitch == true){
            tempScale.x += 0.0005f;
            tempScale.y += 0.0005f;
            tempScale.z += 0.0005f;
            transform.localScale = tempScale;
            if(tempScale.x >= 0.23f)
            timeSwitch = false;
        }
        else if(tempScale.x > 0.2f && timeSwitch == false){
            tempScale.x -= 0.0005f;
            tempScale.y -= 0.0005f;
            tempScale.z -= 0.0005f;
            transform.localScale = tempScale;
            if(tempScale.x <= 0.2f)
            timeSwitch = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.name == "Incognito" && NewHealth.addHealthPermit == true){
            NewHealth.newHealth += 1f;
            Debug.Log("Health is: " + Health.incognitoHealth);
            Destroy(this.gameObject);
            heartSound.Play();
        }
    }
}