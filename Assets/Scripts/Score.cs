using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField]
    private Text score;

    void Awake()
    {
        score = GetComponent<Text>();
    }

    void Update()
    {
        score.text = Coin.incognitoScore.ToString();
    }
}
