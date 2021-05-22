using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftScript : MonoBehaviour
{

    Rigidbody2D obstacleRB;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        obstacleRB=GetComponent<Rigidbody2D>();
    }


void Update()
{

}
    // Update is called once per frame
private void FixedUpdate()
    {
        obstacleRB.velocity= Vector2.left * moveSpeed;
        if(transform.position.x <-12.0f)
        {
            Destroy(gameObject);
        }
    }
}
