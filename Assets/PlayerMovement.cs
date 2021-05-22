using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D playerRB;
    public float jumpVelocity;
    bool Grounded=false;
    Animator animator;
  
    public Canvas canvas;
    SpawnManager spawnObj;
      // Start is called before the first frame update
    void Start()
    {
        playerRB= GetComponent<Rigidbody2D>();
        animator=GetComponent<Animator>();
        spawnObj=FindObjectOfType<SpawnManager>();
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            if(Grounded)
            {
               Jump();
               animator.SetTrigger("Jump");
            } 
        }
    }

void OnCollisionEnter2D(Collision2D collision)
{
    if(collision.gameObject.tag == "Ground")
    {
        Grounded=true;
    }

    if(collision.gameObject.CompareTag("Obstacle"))
        {
            animator.SetTrigger("Dead");
         //   animator.enabled=false;
            Destroy(collision.gameObject);
            spawnObj.CancelInvoke("Spawn");
           // canvas.gameObject.SetActive(true);
       }
}
    private void Jump()
    {
        Grounded=false;
         playerRB.velocity =new Vector2(0, jumpVelocity);
    }
}
