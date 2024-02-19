using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerX : MonoBehaviour
{

    //============================================================GAMEOBJECTS==============================================================================================

    [SerializeField]
    private GameObject Audiomanager;

    public AudioManager audiomanager;

    //===================================================================UI================================================================================================
    public Text scoreText;
    public Text highscore;
    //==================================================================VARIABLES==================================================================================================
    public int score= 0;
    bool isGameOver;
    public bool isGameStarted;

    void Start()
    {
        isGameOver= false;
        isGameStarted= true;
        audiomanager = Audiomanager.GetComponent<AudioManager>();
        
        Time.timeScale=1f;
        highscore.text = PlayerPrefs.GetInt("highScore").ToString();
        if(!isGameOver)
        {
            audiomanager.Play("Background");
        }
        
    }

    public void UpdateScore()
    {
        score +=1;
        scoreText.text= score.ToString();
        PlayerPrefs.SetInt("currentScore", score);
        
    }

    public void GameOver()
    {
        isGameOver=true;
        isGameStarted= false;

        Time.timeScale= 0;
        SceneManager.LoadScene("EndGame");

        if(PlayerPrefs.GetInt("currentScore")> PlayerPrefs.GetInt("highScore"))
        {
            string high = PlayerPrefs.GetInt("currentScore").ToString();
            PlayerPrefs.SetInt("highScore", int.Parse(high));
            
        }

    }
}
