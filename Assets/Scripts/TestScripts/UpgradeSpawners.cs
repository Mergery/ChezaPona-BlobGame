using UnityEngine;

public class UpgradeSpawners : MonoBehaviour
{
    public int blocksPassed;
    
    private void OnTriggerEnter2D(Collider2D triggercollision) 
   {
    if(triggercollision.tag=="Enemy")
    {
        blocksPassed += 1;
    }


   }
}
