using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textCollecting : MonoBehaviour
{
    private Vector3 tempRot;

    private AudioSource letterSound;

    public string letter;

    public GameObject findLetter;


    void Awake()
    {
        GameObject audio = GameObject.FindWithTag("Audio");
        if(audio != null){
            letterSound = audio.GetComponent<AudioSource>();
        }
        tempRot.y = transform.rotation.y;

        letter = "Dark_" + this.gameObject.name.Substring(this.gameObject.name.Length - 1);
        Debug.Log(letter);

        findLetter = GameObject.Find(letter);
    }

    void Update()
    {
        LetterRotation();
    }

    void LetterRotation(){
        tempRot.y ++;
        transform.rotation = Quaternion.Euler(transform.rotation.x, tempRot.y, transform.rotation.z);
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Player"){
            Debug.Log("Letter = " + letter);
            letterSound.Play();
            this.gameObject.SetActive(false);
            //findLetter.gameObject.SetActive(false);
            if(letter == "Dark_I") Collector.I = true;
            if(letter == "Dark_N") Collector.N = true;
            if(letter == "Dark_C") Collector.C = true;
            if(letter == "Dark_O") Collector.O = true;
            if(letter == "Dark_G") Collector.G = true;
            if(letter == "Dark_A") Collector.N2 = true;
            if(letter == "Dark_Z") Collector.I2 = true;
            if(letter == "Dark_T") Collector.T = true;
            if(letter == "Dark_E") Collector.O2 = true;
        }
    }
}
