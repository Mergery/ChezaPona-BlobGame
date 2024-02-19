using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
  // PLAY BUTTON
  public void StartGame()
  {
    SceneManager.LoadScene("MainGame");
  }

  //EXITBUTTON
  public void ExitGame()
  {
    Application.Quit();
    Debug.Log("Game Closed");
  }

  //RESTART BUTTON
  public void RestartGame()
  {
    SceneManager.LoadScene("MainGame");
  }
}
