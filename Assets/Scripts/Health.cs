using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public static int incognitoHealth;
    public int setHealth = 5;

    private bool dead;

    public static bool addHealthPermit;

    public GameObject[] hearts;

    void Awake()
    {
        incognitoHealth = setHealth;
        Debug.Log("Health is: " + incognitoHealth);
    }

    void Update()
    {
        Debug.Log(incognitoHealth);
        if(incognitoHealth <= 0){
            dead = true;
            //SceneManager.LoadScene("Scene_Name");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if(incognitoHealth == 5){
            addHealthPermit = false;
        }
        else{
            addHealthPermit = true;
        }
        


        if(incognitoHealth == 0 && hearts[0].gameObject.activeSelf == true)
        hearts[0].gameObject.SetActive(false);

        else if(incognitoHealth == 1 && hearts[1].gameObject.activeSelf == true)
        hearts[1].gameObject.SetActive(false);

        else if(incognitoHealth == 2 && hearts[2].gameObject.activeSelf == true)
        hearts[2].gameObject.SetActive(false);

        else if(incognitoHealth == 3 && hearts[3].gameObject.activeSelf == true)
        hearts[3].gameObject.SetActive(false);

        else if(incognitoHealth == 4 && hearts[4].gameObject.activeSelf == true)
        hearts[4].gameObject.SetActive(false);




        if(incognitoHealth == 1 && hearts[0].gameObject.activeSelf == false)
        hearts[0].gameObject.SetActive(true);

        else if(incognitoHealth == 2 && hearts[1].gameObject.activeSelf == false)
        hearts[1].gameObject.SetActive(true);

        else if(incognitoHealth == 3 && hearts[2].gameObject.activeSelf == false)
        hearts[2].gameObject.SetActive(true);

        else if(incognitoHealth == 4 && hearts[3].gameObject.activeSelf == false)
        hearts[3].gameObject.SetActive(true);

        else if(incognitoHealth == 5 && hearts[4].gameObject.activeSelf == false)
        hearts[4].gameObject.SetActive(true);
    }

}
