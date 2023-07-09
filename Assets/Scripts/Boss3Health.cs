using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Boss3Health : MonoBehaviour
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

    public GameObject letterO;

    public GameObject fin;
    private GameObject plat;

    void Awake(){
        boss = GameObject.Find("Boss");
        boss2 = GameObject.Find("Boss2");
        boss3 = GameObject.Find("Boss3");
        plat = GameObject.Find("Plat55");
        if(plat != null)
        plat.gameObject.SetActive(false);
    }

    void Update(){

        if(newHealth <= 0){
            Destroy(boss);
            Destroy(boss2);
            Destroy(boss3);
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
