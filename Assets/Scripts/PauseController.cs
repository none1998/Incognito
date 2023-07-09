using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class PauseController : MonoBehaviour
{
    private GameObject pauseCursor;

    void Awake()
    {
        pauseCursor = GameObject.Find("MenuBar");
        transform.GetChild(0).gameObject.SetActive(false);
        transform.GetChild(1).gameObject.SetActive(false);
        transform.GetChild(2).gameObject.SetActive(false);
        transform.GetChild(3).gameObject.SetActive(false);
    }

    void Update()
    {
        
        if(pauseCursor.gameObject.activeSelf == true){
            Incognito.isLoading = true;
        }
        else if(Loading.timer < 0){
            Incognito.isLoading = false;
        }

        if(Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(true);
            transform.GetChild(2).gameObject.SetActive(true);
            transform.GetChild(3).gameObject.SetActive(true);
        }

        if(Input.GetKeyDown(KeyCode.Space) && 
        Mathf.Round(pauseCursor.transform.localPosition.y) == 47f &&
        transform.GetChild(3).gameObject.activeSelf == true)
        {
            Incognito.isLoading = false;
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(false);
            transform.GetChild(2).gameObject.SetActive(false);
            transform.GetChild(3).gameObject.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.Space) && 
        Mathf.Round(pauseCursor.transform.localPosition.y) == -7f &&
        transform.GetChild(3).gameObject.activeSelf == true){
            NewHealth.newHealth = 5;
            BossHealth.newHealth = 5;
            Boss2Health.newHealth = 5;
            Boss3Health.newHealth = 5;
            Boss4Health.newHealth = 5;
            Coin.incognitoScore = 0;
            Incognito.numOfBullets = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if(Input.GetKeyDown(KeyCode.Space) && 
        Mathf.Round(pauseCursor.transform.localPosition.y) == -61f &&
        transform.GetChild(3).gameObject.activeSelf == true){
            NewHealth.newHealth = 5;
            BossHealth.newHealth = 5;
            Boss2Health.newHealth = 5;
            Boss3Health.newHealth = 5;
            Boss4Health.newHealth = 5;
            Coin.incognitoScore = 0;
            Incognito.numOfBullets = 0;
            SceneManager.LoadScene("Level0");
        }
    }
}
