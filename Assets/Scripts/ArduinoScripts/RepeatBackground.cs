using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    float speed = 5f;
    Vector2 startPos;
    private float repeatWidth;
    public float offset;
    // Start is called before the first frame update
    void Start()
    {
        startPos= transform.position;
        repeatWidth= GetComponent<BoxCollider2D>().size.y/2;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down* Time.deltaTime * speed);
        if (transform.position.y< - (repeatWidth - offset))
        {
            transform.position= startPos;
        }
    }
}
