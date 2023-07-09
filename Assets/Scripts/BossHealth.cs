using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BossHealth : MonoBehaviour
{
    public static float newHealth = 5;
    public float numOfHearts = 5;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    public static bool addHealthPermit;

    public GameObject boss;

    public GameObject letterN;

    public GameObject fin;

    void Awake(){
        boss = GameObject.Find("Boss");
        letterN = GameObject.Find("Letter_N");
        letterN.gameObject.SetActive(false);
        fin = GameObject.Find("Finish");
        fin.gameObject.SetActive(false);
    }

    void Update(){

        if(newHealth <= 0){
            Destroy(boss);
            letterN.gameObject.SetActive(true);
            fin.gameObject.SetActive(true);
            // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            // newHealth = 5;
            // NewHealth.newHealth = 5;
        }

        for(int i=0; i<hearts.Length; i++){

            if(i<newHealth){
                hearts[i].sprite = fullHeart;
            }
            else {
                hearts[i].sprite = emptyHeart;
            }

            if(i<numOfHearts){
                hearts[i].enabled = true;
            }
            else {
                hearts[i].enabled = false;
            }
        }
    }
}
