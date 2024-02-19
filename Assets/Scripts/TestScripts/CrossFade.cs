using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrossFade : MonoBehaviour
{
    //public Animator transition;

    public void TransitionLevel()
    {
        StartCoroutine(LoadLevel("EndGame"));
        
        IEnumerator LoadLevel(string levelName)
        {
            //transition.SetTrigger("Start");
            yield return new WaitForSeconds(1.20f);
            SceneManager.LoadScene(levelName);             
        }
    }
}
