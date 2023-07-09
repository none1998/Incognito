using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewHealth : MonoBehaviour
{
    public static float newHealth = 5;
    public float numOfHearts = 5;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    public static bool addHealthPermit;

    void Update(){
        if(newHealth == 5){
            addHealthPermit = false;
        }
        else{
            addHealthPermit = true;
        }

        if(newHealth > numOfHearts){
            newHealth = numOfHearts;
        }

        if(newHealth <= 0){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            newHealth = 5;
            BossHealth.newHealth = 5;
            Boss2Health.newHealth = 5;
            Boss3Health.newHealth = 5;
            Boss4Health.newHealth = 5;
            Coin.incognitoScore = 0;
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
