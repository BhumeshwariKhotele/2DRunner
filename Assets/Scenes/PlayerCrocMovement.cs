using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCrocMovement : MonoBehaviour
{
    Rigidbody2D PlayerRB;
    public float playerSpeed;
    SpriteRenderer PlayerSprite;
    // Start is called before the first frame update
    void Start()
    {
        PlayerRB=GetComponent<Rigidbody2D>();
        PlayerSprite=GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  private void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            PlayerRB.velocity= Vector2.right * playerSpeed;
            PlayerSprite.flipX=false;

        }
         if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            PlayerSprite.flipX=true;
            PlayerRB.velocity= Vector2.left * playerSpeed;
        }
    }
                            
}
