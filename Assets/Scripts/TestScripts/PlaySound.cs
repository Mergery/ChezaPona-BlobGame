using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioManager audioManager;
    // Start is called before the first frame update
    public void Start() 
    {

        audioManager.Play("StartGame");        
    }
}
