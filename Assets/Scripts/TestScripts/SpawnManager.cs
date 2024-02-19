using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //=========================================================GAMEOBJECTS============================================================================================================================================
    [SerializeField]
    private GameObject[] enemyBlocksArray;

    [SerializeField]
    private GameObject[] ballArray;
//=============================================================VECTORS=========================================================================================================================================================
    Vector3 spawnposition;
    Vector3 lastSpawnPos;

    //=======================================================VARIABLES========================================================================================================================================================

    float screenWorldUnitsX;
    float screenWorldUnitsY1;
    float screenWorldUnitsY2;
    float blockSpawnTime=10f;
    float ballSpawnTime=10f;
    float secondBetweenSpawns;
    Vector2 spawnSecondsMinMax;
    int phase;
    int enemyIndex;
    int ballIndex;
    float spawnX;
    float spawnY;

    void Start()
    {
        screenWorldUnitsX= Camera.main.aspect* Camera.main.orthographicSize-4;
        screenWorldUnitsY1= Camera.main.orthographicSize+5f;
        screenWorldUnitsY2= Camera.main.orthographicSize+8f;
        spawnSecondsMinMax= new Vector2(1, 10);
    }

    void Update()
    {
        if(Time.timeSinceLevelLoad> blockSpawnTime)
        {
            secondBetweenSpawns= Mathf.Lerp(spawnSecondsMinMax.y, spawnSecondsMinMax.x,Difficulty.GetDifficultyPercentage());
            blockSpawnTime= Time.timeSinceLevelLoad+secondBetweenSpawns;
            phase = Random.Range(1,4);

            for(int i=0; i<phase; i++)
            {
                SpawnEnemy();
                lastSpawnPos= spawnposition;
            }

        }

        if(Time.timeSinceLevelLoad> ballSpawnTime)
        {
            ballSpawnTime= Time.timeSinceLevelLoad+secondBetweenSpawns;
            
            phase = Random.Range(1,4);

            for(int i=0; i<phase; i++)
            {
                SpawnBall();
                lastSpawnPos= spawnposition;
                                
            }

        }


        
    }
     void SpawnEnemy()
     {
        enemyIndex= Random.Range(0,enemyBlocksArray.Length);
        
        spawnX= Random.Range(-screenWorldUnitsX, screenWorldUnitsX);
        spawnY= Random.Range(screenWorldUnitsY1, screenWorldUnitsY2);

        spawnposition= new Vector3(spawnX, spawnY, 0);

        Instantiate(enemyBlocksArray[enemyIndex] , spawnposition , Quaternion.identity);
     }

     void SpawnBall()
     {
        ballIndex= Random.Range(0,ballArray.Length);
        
        spawnX= Random.Range(-screenWorldUnitsX, screenWorldUnitsX);

        spawnY= Random.Range(screenWorldUnitsY1, screenWorldUnitsY2);

        spawnposition= new Vector3(spawnX, spawnY, 0);

        Instantiate(ballArray[ballIndex] , spawnposition , Quaternion.identity);

     }

}
/*


    //=========================================================GAMEOBJECTS============================================================================================================================================
    [SerializeField]
    private GameObject[] enemyBlocksArray;

    [SerializeField]
    private GameObject[] ballArray;
//=============================================================VECTORS=========================================================================================================================================================
    Vector3 spawnposition;

    //=======================================================VARIABLES========================================================================================================================================================

    float screenWorldUnitsX;
    float screenWorldUnitsY1;
    float screenWorldUnitsY2;
    float blockSpawnTime=10f;
    float ballSpawnTime=10f;
    float secondBetweenSpawns;
    Vector2 spawnSecondsMinMax;
    int phase;
    int enemyIndex;
    int ballIndex;
    float spawnX;
    float spawnY;
    float lastSpawnX;
    float lastSpawnY;
    void Start()
    {
        //screenWorldHalfWidth= new Vector3(Camera.main.aspect*Camera.main.orthographicSize,Camera.main.orthographicSize
        screenWorldUnitsX= Camera.main.aspect* Camera.main.orthographicSize-4;
        screenWorldUnitsY1= Camera.main.orthographicSize+5f;
        screenWorldUnitsY2= Camera.main.orthographicSize+8f;
        spawnSecondsMinMax= new Vector2(1, 10);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(screenWorldUnitsX);
        if(Time.timeSinceLevelLoad> blockSpawnTime)
        {
            secondBetweenSpawns= Mathf.Lerp(spawnSecondsMinMax.y, spawnSecondsMinMax.x,Difficulty.GetDifficultyPercentage());
            Debug.Log(secondBetweenSpawns);
            blockSpawnTime= Time.timeSinceLevelLoad+secondBetweenSpawns;
            phase = Random.Range(1,4);

            for(int i=0; i<phase; i++)
            {
                SpawnEnemy();
            }

        }

        if(Time.timeSinceLevelLoad> ballSpawnTime)
        {
            ballSpawnTime= Time.timeSinceLevelLoad+secondBetweenSpawns;
            //secondBetweenSpawns=Random.Range(0f,10f);
            phase = Random.Range(1,2);

            for(int i=0; i<phase; i++)
            {
                SpawnBall();
            }

        }


        
    }
     void SpawnEnemy()
     {
        enemyIndex= Random.Range(0,enemyBlocksArray.Length);
        
        spawnX= Random.Range(-screenWorldUnitsX, screenWorldUnitsX);

        spawnY= Random.Range(screenWorldUnitsY1, screenWorldUnitsY2);

        spawnposition= new Vector3(spawnX, spawnY, 0);

        Instantiate(enemyBlocksArray[enemyIndex] , spawnposition , Quaternion.identity);

     }

     void SpawnBall()
     {
        ballIndex= Random.Range(0,ballArray.Length);
        
        spawnX= Random.Range(-screenWorldUnitsX, screenWorldUnitsX);

        spawnY= Random.Range(screenWorldUnitsY1, screenWorldUnitsY2);

        spawnposition= new Vector3(spawnX, spawnY, 0);

        Instantiate(ballArray[ballIndex] , spawnposition , Quaternion.identity);

     }

*/

