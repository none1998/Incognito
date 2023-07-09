using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Boss4Health : MonoBehaviour
{
    public static float newHealth = 5;
    public float numOfHearts = 5;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    public static bool addHealthPermit;

    public GameObject boss;
    public GameObject boss2;
    public GameObject boss3;
    public GameObject boss4;

    public GameObject letterO;

    public GameObject fin;
    private GameObject plat;

    void Awake(){
        boss = GameObject.Find("Boss");
        boss2 = GameObject.Find("Boss2");
        boss3 = GameObject.Find("Boss3");
        boss4 = GameObject.Find("MummyBoss");
        plat = GameObject.Find("Plat55");
        if(plat != null)
        plat.gameObject.SetActive(false);
        if(fin != null)
        fin.gameObject.SetActive(false);
    }

    void Update(){

        if(newHealth <= 0){
            Destroy(boss);
            Destroy(boss2);
            Destroy(boss3);
            Destroy(boss4);
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
