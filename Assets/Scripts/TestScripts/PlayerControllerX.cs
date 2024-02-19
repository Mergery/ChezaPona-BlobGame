using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{

    //==========================================================GAMEOBJECT==================================================================================================
    [SerializeField]
    GameObject GameManagerobj;

    GameManagerX gamemanagerScript;

    //==========================================================VARIABLES==================================================================================================
    public float horizontalInput;
    float playerSpeed = 7.0f;

    float screenWorldPoints;
    float playerWidth;
    void Start()
    {
        gamemanagerScript= GameManagerobj.GetComponent<GameManagerX>();
        playerWidth = transform.localScale.x/2;
        screenWorldPoints= Camera.main.orthographicSize* Camera.main.aspect - playerWidth-3;
        
    }

    void Update()
    {
        horizontalInput= Input.GetAxis("Horizontal");
        float moveX= horizontalInput* Time.deltaTime*playerSpeed;
        transform.Translate(moveX,0, 0);
        transform.position=new Vector3(Mathf.Clamp(transform.position.x, -screenWorldPoints, screenWorldPoints), transform.position.y, transform.position.z);

    }

    //=====================================================DETECTING PLAYER COLLISIONS =====================================================================================
    private void OnTriggerEnter2D(Collider2D other) 
    {

        if(other.tag== "Enemy")
        {
            gamemanagerScript.GameOver();
        }

        if(other.tag== "Ball")
        {
            gamemanagerScript.UpdateScore();
            Destroy(other.gameObject);
        }
        
    }
}
