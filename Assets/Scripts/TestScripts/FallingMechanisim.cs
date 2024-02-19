using UnityEngine;

public class FallingMechanisim : MonoBehaviour
{
    Vector2 speedMinMax;
    float fallingSpeed ;
    float screenWorldPoints;
    void Start()
    {
        speedMinMax = new Vector2(3, 7);
        screenWorldPoints= Camera.main.orthographicSize+5f;
        fallingSpeed= Mathf.Lerp(speedMinMax.x, speedMinMax.y, Difficulty.GetDifficultyPercentage2());
    }

    void Update()
    {
        transform.Translate(Vector3.down* Time.deltaTime* fallingSpeed);

        if(transform.position.y < - screenWorldPoints)
        {
            Destroy(gameObject);
        }
        
    }
}
