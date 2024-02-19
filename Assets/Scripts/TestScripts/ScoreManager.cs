using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    //==================================================VARIABLES======================================================================================================
    public Text highScore;
    public Text score ;

    void Start()
    {
        string high = PlayerPrefs.GetInt("highScore").ToString();
        highScore.text= high;

        string currScore =  PlayerPrefs.GetInt("currentScore").ToString();
        score.text= currScore;
        
    }

    void Update()
    {
        
    }
}
